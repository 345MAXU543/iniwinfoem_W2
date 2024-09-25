using System.Runtime.InteropServices;
using System.Text;

namespace iniwinfoem_W2
{
    internal class IniMods
    {

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);


        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(
            string section,
            string key,
            string def,
            StringBuilder retVal,
            int size,
            string INIPath);

        public void INIWrite(string sectin, string key, string val, string FilePath)
        {
            try
            {
                WritePrivateProfileString(sectin, key, val, FilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string INIRead(string sectin, string key, string FilePath)
        {
            System.Text.StringBuilder temp = new System.Text.StringBuilder(255);
            try
            {
                GetPrivateProfileString(sectin, key, "", temp, 255, FilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return temp.ToString();
        }
        public void INIDelete(string FilePathe)
        {
            File.Delete(FilePathe);
        }

        [DllImport("kernel32")]
        static extern uint GetPrivateProfileSectionNames(IntPtr pszReturnBuffer, uint nSize, string lpFileName);

        public static string[] SectionNames(string path)
        {
            path = Path.GetFullPath(path);
            uint MAX_BUFFER = 32767;
            IntPtr pReturnedString = Marshal.AllocCoTaskMem((int)MAX_BUFFER);
            uint bytesReturned = GetPrivateProfileSectionNames(pReturnedString, MAX_BUFFER, path);

            if (bytesReturned == 0)
                return null;
            string local = Marshal.PtrToStringAnsi(pReturnedString, (int)bytesReturned).ToString();
            Marshal.FreeCoTaskMem(pReturnedString);
            //use of Substring below removes terminating null for split
            return local.Substring(0, local.Length - 1).Split('\0');
        }

        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileSection(string lpAppName, byte[] lpszReturnBuffer, int nSize, string lpFileName);

        public List<string> GetKeys(string iniFile, string category)
        {

            byte[] buffer = new byte[4086];
            try
            {
                GetPrivateProfileSection(category, buffer, 4086, iniFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            String[] tmp = Encoding.ASCII.GetString(buffer).Trim('\0').Split('\0');
            List<string> result = new List<string>();


            if (tmp.Length > 1)
            {
                foreach (String entry in tmp)
                {
                    result.Add(entry.Substring(0, entry.IndexOf("=")));
                }
            }


            return result;
        }
    }
}
