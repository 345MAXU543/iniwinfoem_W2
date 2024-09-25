using Microsoft.VisualBasic;
using ReaLTaiizor.Forms;
using System.Windows.Forms;

namespace iniwinfoem_W2
{
    public partial class Form1 : PoisonForm
    {
        class Ini_class
        {
            public int ID {  get; set; }
            public string section {  get; set; }
            public string key {  get; set; }
            public string val { get; set; }
        }

        private int iUIstartX = 30;
        private int iUIstartY = 0;
        private List<Ini_class> Ini_classlst = new List<Ini_class>();
        private string strPathAndName = "";
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
            txtReadPath.Lines = new string[] { "D:\\" };
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtReadPath.Lines = new string[] { dialog.SelectedPath };
                fnReadFolder();
            }
        }

        private void fnReadFolder()
        {

            // string strGetDirectoryName = System.IO.Path.GetDirectoryName(System.Environment.CurrentDirectory) + @"\ini測試檔";
            DirectoryInfo dirInfo = new DirectoryInfo(txtReadPath.Lines[0]);
            FileInfo[] strArrayFileInfo = new FileInfo[] { };
            strArrayFileInfo = dirInfo.GetFiles("*.ini");
            lvFileList.Items.Clear();
            foreach (FileInfo file in strArrayFileInfo)
            {
                lvFileList.Items.Add(file.Name);
            }

            //strArrayFileInfo = null;

            int xxzcxz = 0;
            //lvFileList.RedrawItems(0,lvFileList.Items.Count-1,true);
            //lvFileList.Update();
            //lvFileList.Refresh();
        }


        private void airButton1_Click(object sender, EventArgs e)
        {
            IniMods iniMods = new IniMods();
            iniMods.INIWrite("strInputNewSection2", "NewKey1", "NewValue1", "D:\\C#程式\\iniwinfoem_W2\\bin\\Debug\\ini測試檔\\555.ini");
            iniMods.INIWrite("strInputNewSection", null,null, "D:\\C#程式\\iniwinfoem_W2\\bin\\Debug\\ini測試檔\\555.ini");
        }
       
        private void lvFileList_Click(object sender, EventArgs e)
        {
            Ini_classlst.Clear();
            iUIstartX = 30;
            iUIstartY = 0;
            pnlItembox.Controls.Clear();
            int iIDCounter =0;
            strPathAndName = txtReadPath.Lines[0] + @"\" + lvFileList.SelectedItems[0].Text;
            string[] strarrayGetSactionName = IniMods.SectionNames(strPathAndName);
            if (strarrayGetSactionName != null)
            {
                for (int i = 0; i < strarrayGetSactionName.Length; i++)
                {
                    Label label = new Label();
                    label.Name = "lblSection" + strarrayGetSactionName[i].ToString();
                    label.Text = strarrayGetSactionName[i];
                    label.ForeColor = Color.White;
                    label.Location = new Point(iUIstartX, iUIstartY);
                    pnlItembox.Controls.Add(label);
                    iUIstartY = iUIstartY + 30;

                    List<string> list = new List<string>();
                    IniMods dd = new IniMods();

                    list = dd.GetKeys(strPathAndName, strarrayGetSactionName[i]);
                    for (int j = 0; j < list.Count; j++)
                    {
                        Label labe2 = new Label();
                        labe2.Name = "lblKey" + list[j].ToString();
                        labe2.Text = list[j];
                        labe2.ForeColor = Color.White;
                        labe2.Location = new Point(iUIstartX, iUIstartY);
                        pnlItembox.Controls.Add(labe2);

                        string strVal = dd.INIRead(strarrayGetSactionName[i], list[j], strPathAndName);
                        TextBox textBox = new TextBox();
                        textBox.Text = strVal;
                        textBox.BackColor = Color.White;
                        textBox.Location = new Point(iUIstartX + 100, iUIstartY);
                        textBox.TextChanged += fnTextChange;
                        textBox.KeyPress += fnTextEnter;
                        pnlItembox.Controls.Add(textBox);

                        iUIstartY = iUIstartY + 30;

                        Ini_class iniclassItem = new Ini_class();
                        iniclassItem.ID = iIDCounter;
                        iniclassItem.section = strarrayGetSactionName[i];
                        iniclassItem.key = list[j].ToString();
                        iniclassItem.val = strVal.ToString();
                        Ini_classlst.Add(iniclassItem);
                        iIDCounter++;

                    }
                    int xxxx = 0;
                    
                }
            }
        }

        private void fnTextChange(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.Gray;
        }

        private void fnTextEnter(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar == (char)Keys.Enter)
            {
                Label label = new Label();
                foreach (Control control in pnlItembox.Controls)
                {
                    if (control.Location.Y == textBox.Location.Y && control is Label)
                    {
                        label = ((Label)control); 
                    }
                }
                Ini_class aa = Ini_classlst.Find(x => x.key == label.Text);
                Ini_classlst[aa.ID].val = textBox.Text;

            }


        }


        private void btnNewFile_Click(object sender, EventArgs e)
        {
            string strInputNewSection = Interaction.InputBox("輸入section", "輸入section", "NewSection", 100, 100);
            if (strInputNewSection == "")
            {
                strInputNewSection = "棋手1"; // 如果輸入為空，重置為默認名稱
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != null || saveFileDialog.FileName != null)
            {
                IniMods iniMods = new IniMods();
                string sssa = saveFileDialog.FileName.Substring(saveFileDialog.FileName.Length-4);
                if (sssa == ".ini")
                {
                    iniMods.INIWrite(strInputNewSection, "NewKey1", "NewValue1", saveFileDialog.FileName);
                    iniMods.INIWrite(strInputNewSection, "NewKey2", "NewValue2", saveFileDialog.FileName);
                    iniMods.INIWrite(strInputNewSection, "NewKey3", "NewValue3", saveFileDialog.FileName);
                }
                else
                {
                    iniMods.INIWrite(strInputNewSection, "NewKey1", "NewValue1", saveFileDialog.FileName + ".ini");
                    iniMods.INIWrite(strInputNewSection, "NewKey2", "NewValue2", saveFileDialog.FileName + ".ini");
                    iniMods.INIWrite(strInputNewSection, "NewKey3", "NewValue3", saveFileDialog.FileName + ".ini");
                }

                strPathAndName = saveFileDialog.FileName.Substring(0, saveFileDialog.FileName.LastIndexOf("\\"));
                txtReadPath.Text = strPathAndName;
                fnReadFolder();
            }
            int xx = 0; int yy = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fnReadFolder();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            IniMods iniMods = new IniMods();
            foreach (var IniItem in Ini_classlst)
            {
                iniMods.INIWrite(IniItem.section, IniItem.key, IniItem.val, txtReadPath.Lines[0] + @"\" + lvFileList.SelectedItems[0].Text);
            }
            pnlItembox.Controls.Clear();
        }
    }
}
