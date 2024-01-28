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
            comboBox1 = new ComboBox();
            button2 = new Button();
            deleteUser = new Button();
            userListLabel = new Label();
            listGameLabel = new Label();
            btnShowPassword = new Button();
            btnCopyPassword = new Button();
            feetchGamesButton = new Button();
            imgIcons = new ImageList(components);
            addUserButton = new Button();
            lstvGames = new ListView();
            columnGame = new ColumnHeader();
            buttonStartGame = new Button();
            pictureBoxProfile = new PictureBox();
            linkLabelProfile = new LinkLabel();
            txtSearchBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(270, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(197, 33);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.icon;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Algerian", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(270, 243);
            button2.Name = "button2";
            button2.Size = new Size(197, 65);
            button2.TabIndex = 4;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // deleteUser
            // 
            deleteUser.BackgroundImage = Properties.Resources.icon;
            deleteUser.FlatStyle = FlatStyle.Flat;
            deleteUser.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteUser.Location = new Point(270, 72);
            deleteUser.Name = "deleteUser";
            deleteUser.Size = new Size(98, 43);
            deleteUser.TabIndex = 9;
            deleteUser.Text = "Löschen";
            deleteUser.UseVisualStyleBackColor = true;
            deleteUser.Click += deleteUser_Click;
            // 
            // userListLabel
            // 
            userListLabel.AutoSize = true;
            userListLabel.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            userListLabel.ForeColor = Color.Ivory;
            userListLabel.Location = new Point(270, 9);
            userListLabel.Name = "userListLabel";
            userListLabel.Size = new Size(140, 21);
            userListLabel.TabIndex = 13;
            userListLabel.Text = "Account wählen:";
            // 
            // listGameLabel
            // 
            listGameLabel.AutoSize = true;
            listGameLabel.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            listGameLabel.ForeColor = Color.Ivory;
            listGameLabel.Location = new Point(473, 13);
            listGameLabel.Name = "listGameLabel";
            listGameLabel.Size = new Size(103, 21);
            listGameLabel.TabIndex = 15;
            listGameLabel.Text = "Spieleliste: ";
            // 
            // btnShowPassword
            // 
            btnShowPassword.BackgroundImage = Properties.Resources.icon;
            btnShowPassword.FlatStyle = FlatStyle.Flat;
            btnShowPassword.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowPassword.Location = new Point(369, 121);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(98, 45);
            btnShowPassword.TabIndex = 16;
            btnShowPassword.Text = "Passwort Anzeigen";
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // btnCopyPassword
            // 
            btnCopyPassword.BackgroundImage = Properties.Resources.icon;
            btnCopyPassword.FlatStyle = FlatStyle.Flat;
            btnCopyPassword.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCopyPassword.Location = new Point(270, 121);
            btnCopyPassword.Name = "btnCopyPassword";
            btnCopyPassword.Size = new Size(98, 45);
            btnCopyPassword.TabIndex = 17;
            btnCopyPassword.Text = "Passwort Kopieren";
            btnCopyPassword.UseVisualStyleBackColor = true;
            btnCopyPassword.Click += btnCopyPassword_Click;
            // 
            // feetchGamesButton
            // 
            feetchGamesButton.BackgroundImage = Properties.Resources.icon;
            feetchGamesButton.FlatStyle = FlatStyle.Flat;
            feetchGamesButton.Location = new Point(369, 72);
            feetchGamesButton.Name = "feetchGamesButton";
            feetchGamesButton.Size = new Size(98, 43);
            feetchGamesButton.TabIndex = 18;
            feetchGamesButton.Text = "SteamID";
            feetchGamesButton.UseVisualStyleBackColor = true;
            feetchGamesButton.Click += feetchGamesButton_Click;
            // 
            // imgIcons
            // 
            imgIcons.ColorDepth = ColorDepth.Depth32Bit;
            imgIcons.ImageSize = new Size(32, 32);
            imgIcons.TransparentColor = Color.Transparent;
            // 
            // addUserButton
            // 
            addUserButton.BackgroundImage = Properties.Resources.icon;
            addUserButton.FlatStyle = FlatStyle.Flat;
            addUserButton.Font = new Font("Algerian", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUserButton.Location = new Point(270, 172);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(197, 65);
            addUserButton.TabIndex = 20;
            addUserButton.Text = "Benutzer Hinzufügen";
            addUserButton.UseVisualStyleBackColor = true;
            addUserButton.Click += addUserButton_Click;
            // 
            // lstvGames
            // 
            lstvGames.BackColor = Color.DimGray;
            lstvGames.Columns.AddRange(new ColumnHeader[] { columnGame });
            lstvGames.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lstvGames.ForeColor = Color.Bisque;
            lstvGames.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstvGames.Location = new Point(473, 33);
            lstvGames.Name = "lstvGames";
            lstvGames.Size = new Size(364, 709);
            lstvGames.SmallImageList = imgIcons;
            lstvGames.TabIndex = 21;
            lstvGames.UseCompatibleStateImageBehavior = false;
            lstvGames.View = View.Details;
            // 
            // columnGame
            // 
            columnGame.Text = "Spieleliste: ";
            columnGame.Width = 300;
            // 
            // buttonStartGame
            // 
            buttonStartGame.BackgroundImage = Properties.Resources.icon;
            buttonStartGame.FlatStyle = FlatStyle.Flat;
            buttonStartGame.Font = new Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStartGame.Location = new Point(270, 421);
            buttonStartGame.Name = "buttonStartGame";
            buttonStartGame.Size = new Size(197, 65);
            buttonStartGame.TabIndex = 22;
            buttonStartGame.Text = "Start Game";
            buttonStartGame.UseVisualStyleBackColor = true;
            buttonStartGame.Click += buttonStartGame_Click;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Location = new Point(40, 33);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(203, 204);
            pictureBoxProfile.TabIndex = 23;
            pictureBoxProfile.TabStop = false;
            // 
            // linkLabelProfile
            // 
            linkLabelProfile.AutoSize = true;
            linkLabelProfile.Font = new Font("Yu Gothic Light", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabelProfile.LinkColor = SystemColors.Highlight;
            linkLabelProfile.Location = new Point(40, 240);
            linkLabelProfile.Name = "linkLabelProfile";
            linkLabelProfile.Size = new Size(0, 35);
            linkLabelProfile.TabIndex = 25;
            linkLabelProfile.TextAlign = ContentAlignment.MiddleCenter;
            linkLabelProfile.LinkClicked += linkLabelProfile_LinkClicked;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Location = new Point(711, 7);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new Size(126, 27);
            txtSearchBox.TabIndex = 26;
            txtSearchBox.TextChanged += txtSearchBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(582, 13);
            label1.Name = "label1";
            label1.Size = new Size(121, 21);
            label1.TabIndex = 27;
            label1.Text = "Schnellsuche:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(862, 759);
            Controls.Add(label1);
            Controls.Add(txtSearchBox);
            Controls.Add(linkLabelProfile);
            Controls.Add(pictureBoxProfile);
            Controls.Add(buttonStartGame);
            Controls.Add(lstvGames);
            Controls.Add(addUserButton);
            Controls.Add(feetchGamesButton);
            Controls.Add(btnCopyPassword);
            Controls.Add(btnShowPassword);
            Controls.Add(listGameLabel);
            Controls.Add(userListLabel);
            Controls.Add(deleteUser);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FloralWhite;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "@Siyarbekir's ACM";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addUserButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button button2;
        private Button showPasswordButton;
        private TextBox txtGameName;
        private Button btnAddGame;
        private Button deleteUser;
        private Button deleteGameButton;
        private Label userLabel;
        private Label passLabel;
        private Label userListLabel;
        private Label gameNameLabel;
        private Label listGameLabel;
        private Button btnShowPassword;
        private Button btnCopyPassword;
        private Button feetchGamesButton;
        private ImageList imgIcons;
        private ContextMenuStrip contextMenuStrip1;
        private ListView lstvGames;
        private ColumnHeader columnGame;
        private Button buttonStartGame;
        private PictureBox pictureBoxProfile;
        private LinkLabel linkLabelProfile;
        private TextBox txtSearchBox;
        private Label label1;
    }
}
