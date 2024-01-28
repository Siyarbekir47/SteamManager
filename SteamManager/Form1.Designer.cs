namespace SteamManager
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            imgIcons = new ImageList(components);
            metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            tabMainPage = new TabPage();
            txtSearchBox = new MetroSet_UI.Controls.MetroSetTextBox();
            styleManager1 = new MetroSet_UI.Components.StyleManager();
            labelQuickSearch = new MetroSet_UI.Controls.MetroSetLabel();
            userListLabel = new MetroSet_UI.Controls.MetroSetLabel();
            pictureBoxProfile = new PictureBox();
            linkLabelProfile = new LinkLabel();
            lstvGames = new ListView();
            tabFirst = new ColumnHeader();
            buttonStartGame = new MetroSet_UI.Controls.MetroSetButton();
            comboBox1 = new MetroSet_UI.Controls.MetroSetComboBox();
            button2 = new MetroSet_UI.Controls.MetroSetButton();
            addUserButton = new MetroSet_UI.Controls.MetroSetButton();
            deleteUser = new MetroSet_UI.Controls.MetroSetButton();
            feetchGamesButton = new MetroSet_UI.Controls.MetroSetButton();
            btnCopyPassword = new MetroSet_UI.Controls.MetroSetButton();
            btnShowPassword = new MetroSet_UI.Controls.MetroSetButton();
            metroSetContextMenuStrip1 = new MetroSet_UI.Controls.MetroSetContextMenuStrip();
            metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            metroSetTabControl1.SuspendLayout();
            tabMainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            SuspendLayout();
            // 
            // imgIcons
            // 
            imgIcons.ColorDepth = ColorDepth.Depth32Bit;
            imgIcons.ImageSize = new Size(32, 32);
            imgIcons.TransparentColor = Color.Transparent;
            // 
            // metroSetTabControl1
            // 
            metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            metroSetTabControl1.AnimateTime = 200;
            metroSetTabControl1.BackgroundColor = Color.White;
            metroSetTabControl1.Controls.Add(tabMainPage);
            metroSetTabControl1.IsDerivedStyle = true;
            metroSetTabControl1.ItemSize = new Size(100, 38);
            metroSetTabControl1.Location = new Point(15, 45);
            metroSetTabControl1.Name = "metroSetTabControl1";
            metroSetTabControl1.SelectedIndex = 0;
            metroSetTabControl1.SelectedTextColor = Color.White;
            metroSetTabControl1.Size = new Size(771, 576);
            metroSetTabControl1.SizeMode = TabSizeMode.Fixed;
            metroSetTabControl1.Speed = 100;
            metroSetTabControl1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetTabControl1.StyleManager = styleManager1;
            metroSetTabControl1.TabIndex = 28;
            metroSetTabControl1.TabStyle = MetroSet_UI.Enums.TabStyle.Style2;
            metroSetTabControl1.ThemeAuthor = "Narwin";
            metroSetTabControl1.ThemeName = "MetroLight";
            metroSetTabControl1.UnselectedTextColor = Color.Gray;
            metroSetTabControl1.UseAnimation = false;
            metroSetTabControl1.SelectedIndexChanged += metroSetTabControl1_SelectedIndexChanged;
            // 
            // tabMainPage
            // 
            tabMainPage.AllowDrop = true;
            tabMainPage.BackColor = Color.Transparent;
            tabMainPage.Controls.Add(txtSearchBox);
            tabMainPage.Controls.Add(labelQuickSearch);
            tabMainPage.Controls.Add(userListLabel);
            tabMainPage.Controls.Add(pictureBoxProfile);
            tabMainPage.Controls.Add(linkLabelProfile);
            tabMainPage.Controls.Add(lstvGames);
            tabMainPage.Controls.Add(buttonStartGame);
            tabMainPage.Controls.Add(comboBox1);
            tabMainPage.Controls.Add(button2);
            tabMainPage.Controls.Add(addUserButton);
            tabMainPage.Controls.Add(deleteUser);
            tabMainPage.Controls.Add(feetchGamesButton);
            tabMainPage.Controls.Add(btnCopyPassword);
            tabMainPage.Controls.Add(btnShowPassword);
            tabMainPage.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabMainPage.ForeColor = SystemColors.ControlDark;
            tabMainPage.Location = new Point(4, 42);
            tabMainPage.Name = "tabMainPage";
            tabMainPage.RightToLeft = RightToLeft.No;
            tabMainPage.Size = new Size(763, 530);
            tabMainPage.TabIndex = 0;
            tabMainPage.Text = "Account";
            // 
            // txtSearchBox
            // 
            txtSearchBox.AutoCompleteCustomSource = null;
            txtSearchBox.AutoCompleteMode = AutoCompleteMode.None;
            txtSearchBox.AutoCompleteSource = AutoCompleteSource.None;
            txtSearchBox.BorderColor = Color.FromArgb(155, 155, 155);
            txtSearchBox.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtSearchBox.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtSearchBox.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtSearchBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchBox.HoverColor = Color.FromArgb(102, 102, 102);
            txtSearchBox.Image = null;
            txtSearchBox.IsDerivedStyle = true;
            txtSearchBox.Lines = null;
            txtSearchBox.Location = new Point(572, 10);
            txtSearchBox.MaxLength = 32767;
            txtSearchBox.Multiline = false;
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.ReadOnly = false;
            txtSearchBox.Size = new Size(152, 26);
            txtSearchBox.Style = MetroSet_UI.Enums.Style.Light;
            txtSearchBox.StyleManager = styleManager1;
            txtSearchBox.TabIndex = 31;
            txtSearchBox.TextAlign = HorizontalAlignment.Left;
            txtSearchBox.ThemeAuthor = "Narwin";
            txtSearchBox.ThemeName = "MetroLight";
            txtSearchBox.UseSystemPasswordChar = false;
            txtSearchBox.WatermarkText = "";
            // 
            // styleManager1
            // 
            styleManager1.CustomTheme = "C:\\Users\\john\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            styleManager1.MetroForm = this;
            styleManager1.Style = MetroSet_UI.Enums.Style.Light;
            styleManager1.ThemeAuthor = "Narwin";
            styleManager1.ThemeName = "MetroLight";
            // 
            // labelQuickSearch
            // 
            labelQuickSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQuickSearch.IsDerivedStyle = true;
            labelQuickSearch.Location = new Point(448, 13);
            labelQuickSearch.Name = "labelQuickSearch";
            labelQuickSearch.Size = new Size(121, 23);
            labelQuickSearch.Style = MetroSet_UI.Enums.Style.Light;
            labelQuickSearch.StyleManager = styleManager1;
            labelQuickSearch.TabIndex = 30;
            labelQuickSearch.Text = "Quick Search:";
            labelQuickSearch.ThemeAuthor = "Narwin";
            labelQuickSearch.ThemeName = "MetroLight";
            // 
            // userListLabel
            // 
            userListLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userListLabel.IsDerivedStyle = true;
            userListLabel.Location = new Point(234, 10);
            userListLabel.Name = "userListLabel";
            userListLabel.Size = new Size(197, 23);
            userListLabel.Style = MetroSet_UI.Enums.Style.Light;
            userListLabel.StyleManager = styleManager1;
            userListLabel.TabIndex = 28;
            userListLabel.Text = "Select Account:";
            userListLabel.ThemeAuthor = "Narwin";
            userListLabel.ThemeName = "MetroLight";
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Location = new Point(17, 36);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(175, 166);
            pictureBoxProfile.TabIndex = 23;
            pictureBoxProfile.TabStop = false;
            // 
            // linkLabelProfile
            // 
            linkLabelProfile.ActiveLinkColor = Color.Black;
            linkLabelProfile.AutoSize = true;
            linkLabelProfile.DisabledLinkColor = Color.Black;
            linkLabelProfile.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelProfile.ForeColor = Color.Black;
            linkLabelProfile.LinkColor = Color.Black;
            linkLabelProfile.Location = new Point(17, 205);
            linkLabelProfile.Name = "linkLabelProfile";
            linkLabelProfile.Size = new Size(0, 24);
            linkLabelProfile.TabIndex = 25;
            linkLabelProfile.TextAlign = ContentAlignment.MiddleCenter;
            linkLabelProfile.VisitedLinkColor = Color.Black;
            linkLabelProfile.LinkClicked += linkLabelProfile_LinkClicked;
            // 
            // lstvGames
            // 
            lstvGames.AutoArrange = false;
            lstvGames.BackColor = SystemColors.InactiveBorder;
            lstvGames.BorderStyle = BorderStyle.FixedSingle;
            lstvGames.Columns.AddRange(new ColumnHeader[] { tabFirst });
            lstvGames.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lstvGames.ForeColor = Color.Black;
            lstvGames.GroupImageList = imgIcons;
            lstvGames.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstvGames.ImeMode = ImeMode.Alpha;
            lstvGames.Location = new Point(444, 36);
            lstvGames.MinimumSize = new Size(32, 32);
            lstvGames.MultiSelect = false;
            lstvGames.Name = "lstvGames";
            lstvGames.ShowGroups = false;
            lstvGames.ShowItemToolTips = true;
            lstvGames.Size = new Size(316, 491);
            lstvGames.SmallImageList = imgIcons;
            lstvGames.TabIndex = 21;
            lstvGames.UseCompatibleStateImageBehavior = false;
            lstvGames.View = View.Details;
            lstvGames.SelectedIndexChanged += lstvGames_SelectedIndexChanged;
            // 
            // tabFirst
            // 
            tabFirst.Text = "Games: ";
            tabFirst.Width = 400;
            // 
            // buttonStartGame
            // 
            buttonStartGame.BackgroundImage = Properties.Resources.icon;
            buttonStartGame.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            buttonStartGame.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            buttonStartGame.DisabledForeColor = Color.Gray;
            buttonStartGame.Font = new Font("Algerian", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStartGame.HoverBorderColor = Color.FromArgb(95, 207, 255);
            buttonStartGame.HoverColor = Color.FromArgb(95, 207, 255);
            buttonStartGame.HoverTextColor = Color.White;
            buttonStartGame.IsDerivedStyle = true;
            buttonStartGame.Location = new Point(241, 371);
            buttonStartGame.Name = "buttonStartGame";
            buttonStartGame.NormalBorderColor = Color.FromArgb(65, 177, 225);
            buttonStartGame.NormalColor = Color.FromArgb(65, 177, 225);
            buttonStartGame.NormalTextColor = Color.White;
            buttonStartGame.PressBorderColor = Color.FromArgb(35, 147, 195);
            buttonStartGame.PressColor = Color.FromArgb(35, 147, 195);
            buttonStartGame.PressTextColor = Color.White;
            buttonStartGame.Size = new Size(197, 65);
            buttonStartGame.Style = MetroSet_UI.Enums.Style.Light;
            buttonStartGame.StyleManager = styleManager1;
            buttonStartGame.TabIndex = 22;
            buttonStartGame.Text = "Quick Start";
            buttonStartGame.ThemeAuthor = "Narwin";
            buttonStartGame.ThemeName = "MetroLight";
            buttonStartGame.Click += buttonStartGame_Click;
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.ArrowColor = Color.FromArgb(150, 150, 150);
            comboBox1.BackColor = Color.Transparent;
            comboBox1.BackgroundColor = Color.FromArgb(238, 238, 238);
            comboBox1.BorderColor = Color.FromArgb(150, 150, 150);
            comboBox1.CausesValidation = false;
            comboBox1.DisabledBackColor = Color.FromArgb(204, 204, 204);
            comboBox1.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            comboBox1.DisabledForeColor = Color.FromArgb(136, 136, 136);
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.IsDerivedStyle = true;
            comboBox1.ItemHeight = 20;
            comboBox1.Location = new Point(241, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            comboBox1.SelectedItemForeColor = Color.White;
            comboBox1.Size = new Size(197, 26);
            comboBox1.Style = MetroSet_UI.Enums.Style.Light;
            comboBox1.StyleManager = styleManager1;
            comboBox1.TabIndex = 3;
            comboBox1.ThemeAuthor = "Narwin";
            comboBox1.ThemeName = "MetroLight";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            button2.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            button2.DisabledForeColor = Color.Gray;
            button2.Font = new Font("Algerian", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.HoverBorderColor = Color.FromArgb(95, 207, 255);
            button2.HoverColor = Color.FromArgb(95, 207, 255);
            button2.HoverTextColor = Color.White;
            button2.IsDerivedStyle = true;
            button2.Location = new Point(241, 274);
            button2.Name = "button2";
            button2.NormalBorderColor = Color.FromArgb(65, 177, 225);
            button2.NormalColor = Color.FromArgb(65, 177, 225);
            button2.NormalTextColor = Color.White;
            button2.PressBorderColor = Color.FromArgb(35, 147, 195);
            button2.PressColor = Color.FromArgb(35, 147, 195);
            button2.PressTextColor = Color.White;
            button2.Size = new Size(197, 65);
            button2.Style = MetroSet_UI.Enums.Style.Light;
            button2.StyleManager = styleManager1;
            button2.TabIndex = 4;
            button2.Text = "Login";
            button2.ThemeAuthor = "Narwin";
            button2.ThemeName = "MetroLight";
            button2.Click += button2_Click;
            // 
            // addUserButton
            // 
            addUserButton.BackgroundImage = Properties.Resources.icon;
            addUserButton.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            addUserButton.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            addUserButton.DisabledForeColor = Color.Gray;
            addUserButton.Font = new Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUserButton.HoverBorderColor = Color.FromArgb(95, 207, 255);
            addUserButton.HoverColor = Color.FromArgb(95, 207, 255);
            addUserButton.HoverTextColor = Color.White;
            addUserButton.IsDerivedStyle = true;
            addUserButton.Location = new Point(241, 203);
            addUserButton.Name = "addUserButton";
            addUserButton.NormalBorderColor = Color.FromArgb(65, 177, 225);
            addUserButton.NormalColor = Color.FromArgb(65, 177, 225);
            addUserButton.NormalTextColor = Color.White;
            addUserButton.PressBorderColor = Color.FromArgb(35, 147, 195);
            addUserButton.PressColor = Color.FromArgb(35, 147, 195);
            addUserButton.PressTextColor = Color.White;
            addUserButton.Size = new Size(197, 65);
            addUserButton.Style = MetroSet_UI.Enums.Style.Light;
            addUserButton.StyleManager = styleManager1;
            addUserButton.TabIndex = 20;
            addUserButton.Text = "Add new User";
            addUserButton.ThemeAuthor = "Narwin";
            addUserButton.ThemeName = "MetroLight";
            addUserButton.Click += addUserButton_Click;
            // 
            // deleteUser
            // 
            deleteUser.BackgroundImage = Properties.Resources.icon;
            deleteUser.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            deleteUser.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            deleteUser.DisabledForeColor = Color.Gray;
            deleteUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            deleteUser.HoverBorderColor = Color.FromArgb(95, 207, 255);
            deleteUser.HoverColor = Color.FromArgb(95, 207, 255);
            deleteUser.HoverTextColor = Color.White;
            deleteUser.IsDerivedStyle = true;
            deleteUser.Location = new Point(241, 75);
            deleteUser.Name = "deleteUser";
            deleteUser.NormalBorderColor = Color.FromArgb(65, 177, 225);
            deleteUser.NormalColor = Color.FromArgb(65, 177, 225);
            deleteUser.NormalTextColor = Color.White;
            deleteUser.PressBorderColor = Color.FromArgb(35, 147, 195);
            deleteUser.PressColor = Color.FromArgb(35, 147, 195);
            deleteUser.PressTextColor = Color.White;
            deleteUser.Size = new Size(98, 43);
            deleteUser.Style = MetroSet_UI.Enums.Style.Light;
            deleteUser.StyleManager = styleManager1;
            deleteUser.TabIndex = 9;
            deleteUser.Text = "Delete User";
            deleteUser.ThemeAuthor = "Narwin";
            deleteUser.ThemeName = "MetroLight";
            deleteUser.Click += deleteUser_Click;
            // 
            // feetchGamesButton
            // 
            feetchGamesButton.BackgroundImage = Properties.Resources.icon;
            feetchGamesButton.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            feetchGamesButton.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            feetchGamesButton.DisabledForeColor = Color.Gray;
            feetchGamesButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            feetchGamesButton.HoverBorderColor = Color.FromArgb(95, 207, 255);
            feetchGamesButton.HoverColor = Color.FromArgb(95, 207, 255);
            feetchGamesButton.HoverTextColor = Color.White;
            feetchGamesButton.IsDerivedStyle = true;
            feetchGamesButton.Location = new Point(340, 75);
            feetchGamesButton.Name = "feetchGamesButton";
            feetchGamesButton.NormalBorderColor = Color.FromArgb(65, 177, 225);
            feetchGamesButton.NormalColor = Color.FromArgb(65, 177, 225);
            feetchGamesButton.NormalTextColor = Color.White;
            feetchGamesButton.PressBorderColor = Color.FromArgb(35, 147, 195);
            feetchGamesButton.PressColor = Color.FromArgb(35, 147, 195);
            feetchGamesButton.PressTextColor = Color.White;
            feetchGamesButton.Size = new Size(98, 43);
            feetchGamesButton.Style = MetroSet_UI.Enums.Style.Light;
            feetchGamesButton.StyleManager = styleManager1;
            feetchGamesButton.TabIndex = 18;
            feetchGamesButton.Text = "Feetch";
            feetchGamesButton.ThemeAuthor = "Narwin";
            feetchGamesButton.ThemeName = "MetroLight";
            feetchGamesButton.Click += feetchGamesButton_Click;
            // 
            // btnCopyPassword
            // 
            btnCopyPassword.BackgroundImage = Properties.Resources.icon;
            btnCopyPassword.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnCopyPassword.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnCopyPassword.DisabledForeColor = Color.Gray;
            btnCopyPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCopyPassword.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnCopyPassword.HoverColor = Color.FromArgb(95, 207, 255);
            btnCopyPassword.HoverTextColor = Color.White;
            btnCopyPassword.IsDerivedStyle = true;
            btnCopyPassword.Location = new Point(241, 124);
            btnCopyPassword.Name = "btnCopyPassword";
            btnCopyPassword.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnCopyPassword.NormalColor = Color.FromArgb(65, 177, 225);
            btnCopyPassword.NormalTextColor = Color.White;
            btnCopyPassword.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnCopyPassword.PressColor = Color.FromArgb(35, 147, 195);
            btnCopyPassword.PressTextColor = Color.White;
            btnCopyPassword.Size = new Size(98, 45);
            btnCopyPassword.Style = MetroSet_UI.Enums.Style.Light;
            btnCopyPassword.StyleManager = styleManager1;
            btnCopyPassword.TabIndex = 17;
            btnCopyPassword.Text = "Copy Password";
            btnCopyPassword.ThemeAuthor = "Narwin";
            btnCopyPassword.ThemeName = "MetroLight";
            btnCopyPassword.Click += btnCopyPassword_Click;
            // 
            // btnShowPassword
            // 
            btnShowPassword.BackgroundImage = Properties.Resources.icon;
            btnShowPassword.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnShowPassword.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnShowPassword.DisabledForeColor = Color.Gray;
            btnShowPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnShowPassword.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnShowPassword.HoverColor = Color.FromArgb(95, 207, 255);
            btnShowPassword.HoverTextColor = Color.White;
            btnShowPassword.IsDerivedStyle = true;
            btnShowPassword.Location = new Point(340, 124);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnShowPassword.NormalColor = Color.FromArgb(65, 177, 225);
            btnShowPassword.NormalTextColor = Color.White;
            btnShowPassword.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnShowPassword.PressColor = Color.FromArgb(35, 147, 195);
            btnShowPassword.PressTextColor = Color.White;
            btnShowPassword.Size = new Size(98, 45);
            btnShowPassword.Style = MetroSet_UI.Enums.Style.Light;
            btnShowPassword.StyleManager = styleManager1;
            btnShowPassword.TabIndex = 16;
            btnShowPassword.Text = "Show Password";
            btnShowPassword.ThemeAuthor = "Narwin";
            btnShowPassword.ThemeName = "MetroLight";
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // metroSetContextMenuStrip1
            // 
            metroSetContextMenuStrip1.IsDerivedStyle = true;
            metroSetContextMenuStrip1.Name = "metroSetContextMenuStrip1";
            metroSetContextMenuStrip1.Size = new Size(61, 4);
            metroSetContextMenuStrip1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetContextMenuStrip1.StyleManager = null;
            metroSetContextMenuStrip1.ThemeAuthor = "Narwin";
            metroSetContextMenuStrip1.ThemeName = "MetroLite";
            metroSetContextMenuStrip1.Opening += metroSetContextMenuStrip1_Opening;
            // 
            // metroSetControlBox1
            // 
            metroSetControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroSetControlBox1.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroSetControlBox1.CloseHoverForeColor = Color.White;
            metroSetControlBox1.CloseNormalForeColor = Color.Gray;
            metroSetControlBox1.DisabledForeColor = Color.DimGray;
            metroSetControlBox1.IsDerivedStyle = true;
            metroSetControlBox1.Location = new Point(788, 11);
            metroSetControlBox1.MaximizeBox = false;
            metroSetControlBox1.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox1.MaximizeHoverForeColor = Color.Gray;
            metroSetControlBox1.MaximizeNormalForeColor = Color.Gray;
            metroSetControlBox1.MinimizeBox = true;
            metroSetControlBox1.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox1.MinimizeHoverForeColor = Color.Gray;
            metroSetControlBox1.MinimizeNormalForeColor = Color.Gray;
            metroSetControlBox1.Name = "metroSetControlBox1";
            metroSetControlBox1.Size = new Size(100, 25);
            metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetControlBox1.StyleManager = styleManager1;
            metroSetControlBox1.TabIndex = 29;
            metroSetControlBox1.Text = "metroSetControlBox1";
            metroSetControlBox1.ThemeAuthor = "Narwin";
            metroSetControlBox1.ThemeName = "MetroLight";
            // 
            // MainForm
            // 
            AllowResize = false;
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 255);
            BackgroundImageLayout = ImageLayout.None;
            BorderThickness = 8F;
            ClientSize = new Size(800, 641);
            Controls.Add(metroSetControlBox1);
            Controls.Add(metroSetTabControl1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(815, 698);
            Name = "MainForm";
            Padding = new Padding(2, 70, 2, 2);
            ShowBorder = true;
            ShowHeader = true;
            ShowLeftRect = false;
            StartPosition = FormStartPosition.CenterScreen;
            StyleManager = styleManager1;
            Text = "@SIYARBEKIR'S ACM";
            TextColor = Color.White;
            ThemeName = "MetroLight";
            Load += Form1_Load;
            metroSetTabControl1.ResumeLayout(false);
            tabMainPage.ResumeLayout(false);
            tabMainPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MetroSet_UI.Controls.MetroSetTextBox textBox1;
        private MetroSet_UI.Controls.MetroSetTextBox textBox2;
        private MetroSet_UI.Controls.MetroSetButton showPasswordButton;
        private MetroSet_UI.Controls.MetroSetTextBox txtGameName;
        private MetroSet_UI.Controls.MetroSetButton btnAddGame;
        private MetroSet_UI.Controls.MetroSetButton deleteGameButton;
        private MetroSet_UI.Controls.MetroSetLabel userLabel;
        private MetroSet_UI.Controls.MetroSetLabel passLabel;
        private MetroSet_UI.Controls.MetroSetLabel gameNameLabel;
        private ImageList imgIcons;
        private ContextMenuStrip contextMenuStrip1;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private MetroSet_UI.Controls.MetroSetContextMenuStrip metroSetContextMenuStrip1;
        private TabPage tabMainPage;
        private MetroSet_UI.Controls.MetroSetTextBox txtSearchBox;
        private MetroSet_UI.Controls.MetroSetLabel labelQuickSearch;
        private MetroSet_UI.Controls.MetroSetLabel userListLabel;
        private PictureBox pictureBoxProfile;
        private LinkLabel linkLabelProfile;
        private ListView lstvGames;
        private MetroSet_UI.Controls.MetroSetButton buttonStartGame;
        private MetroSet_UI.Controls.MetroSetButton button2;
        private MetroSet_UI.Controls.MetroSetButton addUserButton;
        private MetroSet_UI.Controls.MetroSetButton deleteUser;
        private MetroSet_UI.Controls.MetroSetButton feetchGamesButton;
        private MetroSet_UI.Controls.MetroSetButton btnCopyPassword;
        private MetroSet_UI.Controls.MetroSetButton btnShowPassword;
        private MetroSet_UI.Components.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        public MetroSet_UI.Controls.MetroSetComboBox comboBox1;
        private ColumnHeader tabFirst;
    }
}
