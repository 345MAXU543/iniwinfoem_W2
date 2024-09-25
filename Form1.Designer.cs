namespace iniwinfoem_W2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnEXIT = new ReaLTaiizor.Controls.ParrotSuperButton();
            txtReadPath = new ReaLTaiizor.Controls.PoisonTextBox();
            btnRead = new ReaLTaiizor.Controls.PoisonButton();
            lvFileList = new ReaLTaiizor.Controls.PoisonListView();
            airButton1 = new ReaLTaiizor.Controls.AirButton();
            pnlItembox = new Panel();
            btnSave = new ReaLTaiizor.Controls.ParrotButton();
            btnKeyAdd = new ReaLTaiizor.Controls.ParrotButton();
            btnSaveAs = new ReaLTaiizor.Controls.ParrotButton();
            btnSectionAdd = new ReaLTaiizor.Controls.ParrotButton();
            btnNewFile = new ReaLTaiizor.Controls.ParrotButton();
            SuspendLayout();
            // 
            // btnEXIT
            // 
            btnEXIT.BackgroundColor = Color.Red;
            btnEXIT.ButtonImage = (Image)resources.GetObject("btnEXIT.ButtonImage");
            btnEXIT.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            btnEXIT.ButtonStyle = ReaLTaiizor.Controls.ParrotSuperButton.Style.RoundedEdges;
            btnEXIT.ButtonText = "EXIT";
            btnEXIT.CornerRadius = 9;
            btnEXIT.Font = new Font("Microsoft JhengHei UI", 14F);
            btnEXIT.Horizontal_Alignment = StringAlignment.Center;
            btnEXIT.HoverBackgroundColor = Color.DarkRed;
            btnEXIT.HoverTextColor = Color.White;
            btnEXIT.ImagePosition = ReaLTaiizor.Controls.ParrotSuperButton.ImgPosition.Left;
            btnEXIT.Location = new Point(844, 731);
            btnEXIT.Name = "btnEXIT";
            btnEXIT.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnEXIT.SelectedBackColor = Color.Red;
            btnEXIT.SelectedTextColor = Color.White;
            btnEXIT.Size = new Size(133, 46);
            btnEXIT.SuperSelected = false;
            btnEXIT.TabIndex = 1;
            btnEXIT.TextColor = Color.White;
            btnEXIT.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnEXIT.Vertical_Alignment = StringAlignment.Center;
            btnEXIT.Click += btnEXIT_Click;
            // 
            // txtReadPath
            // 
            txtReadPath.AccessibleRole = AccessibleRole.None;
            // 
            // 
            // 
            txtReadPath.CustomButton.Image = null;
            txtReadPath.CustomButton.Location = new Point(539, 2);
            txtReadPath.CustomButton.Name = "";
            txtReadPath.CustomButton.Size = new Size(29, 29);
            txtReadPath.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            txtReadPath.CustomButton.TabIndex = 1;
            txtReadPath.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            txtReadPath.CustomButton.UseSelectable = true;
            txtReadPath.CustomButton.Visible = false;
            txtReadPath.Font = new Font("Microsoft JhengHei UI", 20F);
            txtReadPath.FontSize = ReaLTaiizor.Extension.Poison.PoisonTextBoxSize.Tall;
            txtReadPath.Location = new Point(198, 79);
            txtReadPath.MaxLength = 32767;
            txtReadPath.Name = "txtReadPath";
            txtReadPath.PasswordChar = '\0';
            txtReadPath.ScrollBars = ScrollBars.None;
            txtReadPath.SelectedText = "";
            txtReadPath.SelectionLength = 0;
            txtReadPath.SelectionStart = 0;
            txtReadPath.ShortcutsEnabled = true;
            txtReadPath.Size = new Size(571, 34);
            txtReadPath.TabIndex = 2;
            txtReadPath.UseSelectable = true;
            txtReadPath.WaterMarkColor = Color.FromArgb(109, 109, 109);
            txtReadPath.WaterMarkFont = new Font("Segoe UI", 30F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.DarkGray;
            btnRead.FlatAppearance.MouseDownBackColor = Color.Red;
            btnRead.FlatStyle = FlatStyle.Flat;
            btnRead.Font = new Font("Wingdings", 6F);
            btnRead.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            btnRead.ForeColor = Color.White;
            btnRead.Location = new Point(70, 79);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(112, 34);
            btnRead.TabIndex = 3;
            btnRead.Text = "Choose File";
            btnRead.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            btnRead.UseCompatibleTextRendering = true;
            btnRead.UseCustomBackColor = true;
            btnRead.UseCustomForeColor = true;
            btnRead.UseSelectable = true;
            btnRead.UseStyleColors = true;
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // lvFileList
            // 
            lvFileList.AllowSorting = true;
            lvFileList.BackColor = Color.FromArgb(64, 64, 64);
            lvFileList.Font = new Font("Segoe UI", 12F);
            lvFileList.ForeColor = SystemColors.Info;
            lvFileList.FullRowSelect = true;
            lvFileList.HideSelection = true;
            lvFileList.Location = new Point(70, 179);
            lvFileList.MultiSelect = false;
            lvFileList.Name = "lvFileList";
            lvFileList.OwnerDraw = true;
            lvFileList.Size = new Size(229, 493);
            lvFileList.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Silver;
            lvFileList.TabIndex = 0;
            lvFileList.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            lvFileList.TileSize = new Size(428, 90);
            lvFileList.UseCompatibleStateImageBehavior = false;
            lvFileList.UseSelectable = true;
            lvFileList.View = View.Tile;
            lvFileList.Click += lvFileList_Click;
            // 
            // airButton1
            // 
            airButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            airButton1.Font = new Font("Segoe UI", 9F);
            airButton1.Image = null;
            airButton1.Location = new Point(23, 678);
            airButton1.Name = "airButton1";
            airButton1.NoRounding = false;
            airButton1.Size = new Size(150, 68);
            airButton1.TabIndex = 10;
            airButton1.Text = "airButton1";
            airButton1.Transparent = false;
            airButton1.Click += airButton1_Click;
            // 
            // pnlItembox
            // 
            pnlItembox.AutoScroll = true;
            pnlItembox.Location = new Point(331, 179);
            pnlItembox.Name = "pnlItembox";
            pnlItembox.Size = new Size(622, 374);
            pnlItembox.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnSave.ButtonImage = (Image)resources.GetObject("btnSave.ButtonImage");
            btnSave.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnSave.ButtonText = "SAVE";
            btnSave.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnSave.ClickTextColor = Color.DodgerBlue;
            btnSave.CornerRadius = 5;
            btnSave.Horizontal_Alignment = StringAlignment.Center;
            btnSave.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnSave.HoverTextColor = Color.DodgerBlue;
            btnSave.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnSave.Location = new Point(335, 573);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(168, 41);
            btnSave.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSave.TabIndex = 14;
            btnSave.TextColor = Color.DodgerBlue;
            btnSave.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSave.Vertical_Alignment = StringAlignment.Center;
            btnSave.Click += btnSave_Click;
            // 
            // btnKeyAdd
            // 
            btnKeyAdd.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnKeyAdd.ButtonImage = (Image)resources.GetObject("btnKeyAdd.ButtonImage");
            btnKeyAdd.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnKeyAdd.ButtonText = "+Key";
            btnKeyAdd.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnKeyAdd.ClickTextColor = Color.DodgerBlue;
            btnKeyAdd.CornerRadius = 5;
            btnKeyAdd.Horizontal_Alignment = StringAlignment.Center;
            btnKeyAdd.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnKeyAdd.HoverTextColor = Color.DodgerBlue;
            btnKeyAdd.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnKeyAdd.Location = new Point(759, 573);
            btnKeyAdd.Name = "btnKeyAdd";
            btnKeyAdd.Size = new Size(194, 99);
            btnKeyAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnKeyAdd.TabIndex = 15;
            btnKeyAdd.TextColor = Color.DodgerBlue;
            btnKeyAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnKeyAdd.Vertical_Alignment = StringAlignment.Center;
            // 
            // btnSaveAs
            // 
            btnSaveAs.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnSaveAs.ButtonImage = (Image)resources.GetObject("btnSaveAs.ButtonImage");
            btnSaveAs.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnSaveAs.ButtonText = "Save As";
            btnSaveAs.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnSaveAs.ClickTextColor = Color.DodgerBlue;
            btnSaveAs.CornerRadius = 5;
            btnSaveAs.Horizontal_Alignment = StringAlignment.Center;
            btnSaveAs.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnSaveAs.HoverTextColor = Color.DodgerBlue;
            btnSaveAs.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnSaveAs.Location = new Point(335, 630);
            btnSaveAs.Name = "btnSaveAs";
            btnSaveAs.Size = new Size(168, 42);
            btnSaveAs.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSaveAs.TabIndex = 16;
            btnSaveAs.TextColor = Color.DodgerBlue;
            btnSaveAs.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSaveAs.Vertical_Alignment = StringAlignment.Center;
            // 
            // btnSectionAdd
            // 
            btnSectionAdd.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnSectionAdd.ButtonImage = (Image)resources.GetObject("btnSectionAdd.ButtonImage");
            btnSectionAdd.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnSectionAdd.ButtonText = "+Section";
            btnSectionAdd.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnSectionAdd.ClickTextColor = Color.DodgerBlue;
            btnSectionAdd.CornerRadius = 5;
            btnSectionAdd.Horizontal_Alignment = StringAlignment.Center;
            btnSectionAdd.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnSectionAdd.HoverTextColor = Color.DodgerBlue;
            btnSectionAdd.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnSectionAdd.Location = new Point(531, 573);
            btnSectionAdd.Name = "btnSectionAdd";
            btnSectionAdd.Size = new Size(198, 99);
            btnSectionAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSectionAdd.TabIndex = 17;
            btnSectionAdd.TextColor = Color.DodgerBlue;
            btnSectionAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSectionAdd.Vertical_Alignment = StringAlignment.Center;
            // 
            // btnNewFile
            // 
            btnNewFile.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnNewFile.ButtonImage = (Image)resources.GetObject("btnNewFile.ButtonImage");
            btnNewFile.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnNewFile.ButtonText = "New File";
            btnNewFile.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnNewFile.ClickTextColor = Color.DodgerBlue;
            btnNewFile.CornerRadius = 5;
            btnNewFile.Horizontal_Alignment = StringAlignment.Center;
            btnNewFile.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnNewFile.HoverTextColor = Color.DodgerBlue;
            btnNewFile.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnNewFile.Location = new Point(808, 79);
            btnNewFile.Name = "btnNewFile";
            btnNewFile.Size = new Size(145, 75);
            btnNewFile.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnNewFile.TabIndex = 18;
            btnNewFile.TextColor = Color.DodgerBlue;
            btnNewFile.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnNewFile.Vertical_Alignment = StringAlignment.Center;
            btnNewFile.Click += btnNewFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 800);
            Controls.Add(btnNewFile);
            Controls.Add(btnSave);
            Controls.Add(btnSectionAdd);
            Controls.Add(btnSaveAs);
            Controls.Add(btnKeyAdd);
            Controls.Add(pnlItembox);
            Controls.Add(airButton1);
            Controls.Add(lvFileList);
            Controls.Add(btnRead);
            Controls.Add(txtReadPath);
            Controls.Add(btnEXIT);
            Name = "Form1";
            ShadowType = ReaLTaiizor.Enum.Poison.FormShadowType.None;
            Text = "ini讀寫";
            Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.ParrotSuperButton btnEXIT;
        private ReaLTaiizor.Controls.PoisonTextBox txtReadPath;
        private ReaLTaiizor.Controls.PoisonButton btnRead;
        private ReaLTaiizor.Controls.PoisonListView lvFileList;
        private ReaLTaiizor.Controls.AirButton airButton1;
        private Panel pnlItembox;
        private ReaLTaiizor.Controls.ParrotButton btnSave;
        private ReaLTaiizor.Controls.ParrotButton btnKeyAdd;
        private ReaLTaiizor.Controls.ParrotButton btnSaveAs;
        private ReaLTaiizor.Controls.ParrotButton btnSectionAdd;
        private ReaLTaiizor.Controls.ParrotButton btnNewFile;
    }
}
