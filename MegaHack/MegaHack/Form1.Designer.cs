namespace MegaHack
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Password_Login = new ZBobb.MegaHackTextBox();
            this.Name_Login = new ZBobb.MegaHackTextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Manual_Filetohack_textbox = new ZBobb.MegaHackTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Manual_SearchMask_TextBox = new ZBobb.MegaHackTextBox();
            this.Manual_Search_TextBox = new ZBobb.MegaHackTextBox();
            this.Manual_Select_APK = new System.Windows.Forms.Button();
            this.manual_textbox_hacktype = new ZBobb.MegaHackTextBox();
            this.manual_label_hacktype = new System.Windows.Forms.Label();
            this.manual_textbox_author = new ZBobb.MegaHackTextBox();
            this.manual_label_author = new System.Windows.Forms.Label();
            this.manual_textbox_gamename = new ZBobb.MegaHackTextBox();
            this.manual_label_gamename = new System.Windows.Forms.Label();
            this.button_generate_custom = new System.Windows.Forms.Button();
            this.Replace_Text_Option = new System.Windows.Forms.CheckBox();
            this.Replace_Hex_Option = new System.Windows.Forms.CheckBox();
            this.search_text_option = new System.Windows.Forms.CheckBox();
            this.search_hex_option = new System.Windows.Forms.CheckBox();
            this.label_movebytes = new System.Windows.Forms.Label();
            this.Move_Bytes_Textbox = new ZBobb.MegaHackTextBox();
            this.Replace_String_Textbox = new ZBobb.MegaHackTextBox();
            this.label_replace_string = new System.Windows.Forms.Label();
            this.Manual_Hack_button = new System.Windows.Forms.Button();
            this.SearchMask_Label = new System.Windows.Forms.Label();
            this.HexString_Label = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Load_Custom_Button = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Load_Hacklist_Button = new System.Windows.Forms.Button();
            this.Select_APK_OBB = new System.Windows.Forms.Button();
            this.AutoHack_Button = new System.Windows.Forms.Button();
            this.label_Select_Game = new System.Windows.Forms.Label();
            this.listBox_AutoHack = new System.Windows.Forms.ListBox();
            this.Load_Custom_HackTable_List = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomhackTextBox1 = new ZBobb.MegaHackTextBox();
            this.AutoHackHackTextBox1 = new ZBobb.MegaHackTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(964, 673);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.BackgroundImage = global::MegaHack.Properties.Resources.background;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.Password_Login);
            this.tabPage1.Controls.Add(this.Name_Login);
            this.tabPage1.Controls.Add(this.Login_Button);
            this.tabPage1.Controls.Add(this.Name_Label);
            this.tabPage1.Controls.Add(this.Password_Label);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(956, 644);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Start";
            // 
            // Password_Login
            // 
            this.Password_Login.BackAlpha = 10;
            this.Password_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Password_Login.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Login.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Password_Login.Location = new System.Drawing.Point(502, 613);
            this.Password_Login.Name = "Password_Login";
            this.Password_Login.PasswordChar = '*';
            this.Password_Login.Size = new System.Drawing.Size(314, 27);
            this.Password_Login.TabIndex = 11;
            this.Password_Login.UseSystemPasswordChar = true;
            this.Password_Login.Leave += new System.EventHandler(this.Password_Login_Leave);
            // 
            // Name_Login
            // 
            this.Name_Login.BackAlpha = 10;
            this.Name_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Name_Login.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Login.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name_Login.Location = new System.Drawing.Point(64, 613);
            this.Name_Login.Name = "Name_Login";
            this.Name_Login.Size = new System.Drawing.Size(343, 27);
            this.Name_Login.TabIndex = 10;
            this.Name_Login.Leave += new System.EventHandler(this.Name_Login_Leave);
            // 
            // Login_Button
            // 
            this.Login_Button.BackgroundImage = global::MegaHack.Properties.Resources.button;
            this.Login_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Button.Location = new System.Drawing.Point(822, 616);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(119, 23);
            this.Login_Button.TabIndex = 7;
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.ForeColor = System.Drawing.Color.Yellow;
            this.Name_Label.Location = new System.Drawing.Point(13, 619);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(45, 17);
            this.Name_Label.TabIndex = 6;
            this.Name_Label.Text = "Name";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.ForeColor = System.Drawing.Color.Yellow;
            this.Password_Label.Location = new System.Drawing.Point(427, 619);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(69, 17);
            this.Password_Label.TabIndex = 5;
            this.Password_Label.Text = "Password";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.BackgroundImage = global::MegaHack.Properties.Resources.background;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.Manual_Filetohack_textbox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Manual_SearchMask_TextBox);
            this.tabPage2.Controls.Add(this.Manual_Search_TextBox);
            this.tabPage2.Controls.Add(this.Manual_Select_APK);
            this.tabPage2.Controls.Add(this.manual_textbox_hacktype);
            this.tabPage2.Controls.Add(this.manual_label_hacktype);
            this.tabPage2.Controls.Add(this.manual_textbox_author);
            this.tabPage2.Controls.Add(this.manual_label_author);
            this.tabPage2.Controls.Add(this.manual_textbox_gamename);
            this.tabPage2.Controls.Add(this.manual_label_gamename);
            this.tabPage2.Controls.Add(this.button_generate_custom);
            this.tabPage2.Controls.Add(this.Replace_Text_Option);
            this.tabPage2.Controls.Add(this.Replace_Hex_Option);
            this.tabPage2.Controls.Add(this.search_text_option);
            this.tabPage2.Controls.Add(this.search_hex_option);
            this.tabPage2.Controls.Add(this.label_movebytes);
            this.tabPage2.Controls.Add(this.Move_Bytes_Textbox);
            this.tabPage2.Controls.Add(this.Replace_String_Textbox);
            this.tabPage2.Controls.Add(this.label_replace_string);
            this.tabPage2.Controls.Add(this.Manual_Hack_button);
            this.tabPage2.Controls.Add(this.SearchMask_Label);
            this.tabPage2.Controls.Add(this.HexString_Label);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(956, 644);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manual Hack";
            // 
            // Manual_Filetohack_textbox
            // 
            this.Manual_Filetohack_textbox.BackAlpha = 50;
            this.Manual_Filetohack_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Manual_Filetohack_textbox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manual_Filetohack_textbox.ForeColor = System.Drawing.Color.Yellow;
            this.Manual_Filetohack_textbox.Location = new System.Drawing.Point(108, 202);
            this.Manual_Filetohack_textbox.Name = "Manual_Filetohack_textbox";
            this.Manual_Filetohack_textbox.Size = new System.Drawing.Size(836, 27);
            this.Manual_Filetohack_textbox.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(7, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "File to hack";
            // 
            // Manual_SearchMask_TextBox
            // 
            this.Manual_SearchMask_TextBox.BackAlpha = 50;
            this.Manual_SearchMask_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Manual_SearchMask_TextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manual_SearchMask_TextBox.ForeColor = System.Drawing.Color.Yellow;
            this.Manual_SearchMask_TextBox.Location = new System.Drawing.Point(107, 34);
            this.Manual_SearchMask_TextBox.Name = "Manual_SearchMask_TextBox";
            this.Manual_SearchMask_TextBox.Size = new System.Drawing.Size(837, 27);
            this.Manual_SearchMask_TextBox.TabIndex = 37;
            this.Manual_SearchMask_TextBox.TextChanged += new System.EventHandler(this.Manual_SearchMask_TextBox_TextChanged);
            this.Manual_SearchMask_TextBox.Leave += new System.EventHandler(this.Manual_SearchMask_TextBox_Leave);
            this.Manual_SearchMask_TextBox.MouseHover += new System.EventHandler(this.Manual_SearchMask_TextBox_MouseHover);
            // 
            // Manual_Search_TextBox
            // 
            this.Manual_Search_TextBox.BackAlpha = 50;
            this.Manual_Search_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Manual_Search_TextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manual_Search_TextBox.ForeColor = System.Drawing.Color.Yellow;
            this.Manual_Search_TextBox.Location = new System.Drawing.Point(107, 6);
            this.Manual_Search_TextBox.Name = "Manual_Search_TextBox";
            this.Manual_Search_TextBox.Size = new System.Drawing.Size(837, 27);
            this.Manual_Search_TextBox.TabIndex = 36;
            this.Manual_Search_TextBox.MouseHover += new System.EventHandler(this.Manual_Search_TextBox_MouseHover);
            // 
            // Manual_Select_APK
            // 
            this.Manual_Select_APK.BackgroundImage = global::MegaHack.Properties.Resources.button2;
            this.Manual_Select_APK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Manual_Select_APK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Manual_Select_APK.Location = new System.Drawing.Point(10, 366);
            this.Manual_Select_APK.Name = "Manual_Select_APK";
            this.Manual_Select_APK.Size = new System.Drawing.Size(108, 21);
            this.Manual_Select_APK.TabIndex = 35;
            this.Manual_Select_APK.UseVisualStyleBackColor = true;
            this.Manual_Select_APK.Click += new System.EventHandler(this.Select_APK_OBB_Click);
            // 
            // manual_textbox_hacktype
            // 
            this.manual_textbox_hacktype.BackAlpha = 50;
            this.manual_textbox_hacktype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.manual_textbox_hacktype.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manual_textbox_hacktype.ForeColor = System.Drawing.Color.Yellow;
            this.manual_textbox_hacktype.Location = new System.Drawing.Point(108, 174);
            this.manual_textbox_hacktype.Name = "manual_textbox_hacktype";
            this.manual_textbox_hacktype.Size = new System.Drawing.Size(836, 27);
            this.manual_textbox_hacktype.TabIndex = 34;
            this.manual_textbox_hacktype.Text = "Infinite everything";
            // 
            // manual_label_hacktype
            // 
            this.manual_label_hacktype.AutoSize = true;
            this.manual_label_hacktype.BackColor = System.Drawing.Color.Transparent;
            this.manual_label_hacktype.ForeColor = System.Drawing.Color.Yellow;
            this.manual_label_hacktype.Location = new System.Drawing.Point(7, 177);
            this.manual_label_hacktype.Name = "manual_label_hacktype";
            this.manual_label_hacktype.Size = new System.Drawing.Size(67, 17);
            this.manual_label_hacktype.TabIndex = 33;
            this.manual_label_hacktype.Text = "Hack Info";
            // 
            // manual_textbox_author
            // 
            this.manual_textbox_author.BackAlpha = 50;
            this.manual_textbox_author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.manual_textbox_author.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manual_textbox_author.ForeColor = System.Drawing.Color.Yellow;
            this.manual_textbox_author.Location = new System.Drawing.Point(107, 146);
            this.manual_textbox_author.Name = "manual_textbox_author";
            this.manual_textbox_author.Size = new System.Drawing.Size(837, 27);
            this.manual_textbox_author.TabIndex = 32;
            this.manual_textbox_author.Text = "Anonymous";
            // 
            // manual_label_author
            // 
            this.manual_label_author.AutoSize = true;
            this.manual_label_author.BackColor = System.Drawing.Color.Transparent;
            this.manual_label_author.ForeColor = System.Drawing.Color.Yellow;
            this.manual_label_author.Location = new System.Drawing.Point(7, 149);
            this.manual_label_author.Name = "manual_label_author";
            this.manual_label_author.Size = new System.Drawing.Size(50, 17);
            this.manual_label_author.TabIndex = 31;
            this.manual_label_author.Text = "Author";
            // 
            // manual_textbox_gamename
            // 
            this.manual_textbox_gamename.BackAlpha = 50;
            this.manual_textbox_gamename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.manual_textbox_gamename.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manual_textbox_gamename.ForeColor = System.Drawing.Color.Yellow;
            this.manual_textbox_gamename.Location = new System.Drawing.Point(108, 118);
            this.manual_textbox_gamename.Name = "manual_textbox_gamename";
            this.manual_textbox_gamename.Size = new System.Drawing.Size(836, 27);
            this.manual_textbox_gamename.TabIndex = 30;
            // 
            // manual_label_gamename
            // 
            this.manual_label_gamename.AutoSize = true;
            this.manual_label_gamename.BackColor = System.Drawing.Color.Transparent;
            this.manual_label_gamename.ForeColor = System.Drawing.Color.Yellow;
            this.manual_label_gamename.Location = new System.Drawing.Point(7, 121);
            this.manual_label_gamename.Name = "manual_label_gamename";
            this.manual_label_gamename.Size = new System.Drawing.Size(87, 17);
            this.manual_label_gamename.TabIndex = 29;
            this.manual_label_gamename.Text = "Game Name";
            // 
            // button_generate_custom
            // 
            this.button_generate_custom.BackgroundImage = global::MegaHack.Properties.Resources.generate_custom;
            this.button_generate_custom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_generate_custom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_generate_custom.Location = new System.Drawing.Point(281, 366);
            this.button_generate_custom.Name = "button_generate_custom";
            this.button_generate_custom.Size = new System.Drawing.Size(184, 39);
            this.button_generate_custom.TabIndex = 28;
            this.button_generate_custom.UseVisualStyleBackColor = true;
            this.button_generate_custom.Click += new System.EventHandler(this.button_generate_custom_Click);
            // 
            // Replace_Text_Option
            // 
            this.Replace_Text_Option.AutoSize = true;
            this.Replace_Text_Option.BackColor = System.Drawing.Color.Transparent;
            this.Replace_Text_Option.ForeColor = System.Drawing.Color.Yellow;
            this.Replace_Text_Option.Location = new System.Drawing.Point(481, 328);
            this.Replace_Text_Option.Name = "Replace_Text_Option";
            this.Replace_Text_Option.Size = new System.Drawing.Size(161, 21);
            this.Replace_Text_Option.TabIndex = 27;
            this.Replace_Text_Option.Text = "Replace TEXT string";
            this.Replace_Text_Option.UseVisualStyleBackColor = false;
            this.Replace_Text_Option.CheckedChanged += new System.EventHandler(this.Replace_Text_Click);
            // 
            // Replace_Hex_Option
            // 
            this.Replace_Hex_Option.AutoSize = true;
            this.Replace_Hex_Option.BackColor = System.Drawing.Color.Transparent;
            this.Replace_Hex_Option.Checked = true;
            this.Replace_Hex_Option.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Replace_Hex_Option.ForeColor = System.Drawing.Color.Yellow;
            this.Replace_Hex_Option.Location = new System.Drawing.Point(322, 328);
            this.Replace_Hex_Option.Name = "Replace_Hex_Option";
            this.Replace_Hex_Option.Size = new System.Drawing.Size(153, 21);
            this.Replace_Hex_Option.TabIndex = 26;
            this.Replace_Hex_Option.Text = "Replace HEX string";
            this.Replace_Hex_Option.UseVisualStyleBackColor = false;
            this.Replace_Hex_Option.CheckedChanged += new System.EventHandler(this.Replace_Hex_Click);
            // 
            // search_text_option
            // 
            this.search_text_option.AutoSize = true;
            this.search_text_option.BackColor = System.Drawing.Color.Transparent;
            this.search_text_option.ForeColor = System.Drawing.Color.Yellow;
            this.search_text_option.Location = new System.Drawing.Point(162, 328);
            this.search_text_option.Name = "search_text_option";
            this.search_text_option.Size = new System.Drawing.Size(154, 21);
            this.search_text_option.TabIndex = 25;
            this.search_text_option.Text = "Search TEXT string";
            this.search_text_option.UseVisualStyleBackColor = false;
            this.search_text_option.CheckedChanged += new System.EventHandler(this.search_text_option_CheckedChanged);
            // 
            // search_hex_option
            // 
            this.search_hex_option.AutoSize = true;
            this.search_hex_option.BackColor = System.Drawing.Color.Transparent;
            this.search_hex_option.Checked = true;
            this.search_hex_option.CheckState = System.Windows.Forms.CheckState.Checked;
            this.search_hex_option.ForeColor = System.Drawing.Color.Yellow;
            this.search_hex_option.Location = new System.Drawing.Point(10, 328);
            this.search_hex_option.Name = "search_hex_option";
            this.search_hex_option.Size = new System.Drawing.Size(146, 21);
            this.search_hex_option.TabIndex = 24;
            this.search_hex_option.Text = "Search HEX string";
            this.search_hex_option.UseVisualStyleBackColor = false;
            this.search_hex_option.CheckedChanged += new System.EventHandler(this.search_hex_option_CheckedChanged);
            // 
            // label_movebytes
            // 
            this.label_movebytes.AutoSize = true;
            this.label_movebytes.BackColor = System.Drawing.Color.Transparent;
            this.label_movebytes.ForeColor = System.Drawing.Color.Yellow;
            this.label_movebytes.Location = new System.Drawing.Point(7, 93);
            this.label_movebytes.Name = "label_movebytes";
            this.label_movebytes.Size = new System.Drawing.Size(289, 17);
            this.label_movebytes.TabIndex = 23;
            this.label_movebytes.Text = "Amount of bytes to move from location found";
            // 
            // Move_Bytes_Textbox
            // 
            this.Move_Bytes_Textbox.BackAlpha = 50;
            this.Move_Bytes_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Move_Bytes_Textbox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Move_Bytes_Textbox.ForeColor = System.Drawing.Color.Yellow;
            this.Move_Bytes_Textbox.Location = new System.Drawing.Point(302, 90);
            this.Move_Bytes_Textbox.Name = "Move_Bytes_Textbox";
            this.Move_Bytes_Textbox.Size = new System.Drawing.Size(642, 27);
            this.Move_Bytes_Textbox.TabIndex = 22;
            this.Move_Bytes_Textbox.Text = "0";
            // 
            // Replace_String_Textbox
            // 
            this.Replace_String_Textbox.BackAlpha = 50;
            this.Replace_String_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Replace_String_Textbox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Replace_String_Textbox.ForeColor = System.Drawing.Color.Yellow;
            this.Replace_String_Textbox.Location = new System.Drawing.Point(107, 62);
            this.Replace_String_Textbox.Name = "Replace_String_Textbox";
            this.Replace_String_Textbox.Size = new System.Drawing.Size(837, 27);
            this.Replace_String_Textbox.TabIndex = 19;
            // 
            // label_replace_string
            // 
            this.label_replace_string.AutoSize = true;
            this.label_replace_string.BackColor = System.Drawing.Color.Transparent;
            this.label_replace_string.ForeColor = System.Drawing.Color.Yellow;
            this.label_replace_string.Location = new System.Drawing.Point(7, 65);
            this.label_replace_string.Name = "label_replace_string";
            this.label_replace_string.Size = new System.Drawing.Size(101, 17);
            this.label_replace_string.TabIndex = 18;
            this.label_replace_string.Text = "Replace String";
            // 
            // Manual_Hack_button
            // 
            this.Manual_Hack_button.BackgroundImage = global::MegaHack.Properties.Resources.button3;
            this.Manual_Hack_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Manual_Hack_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Manual_Hack_button.Location = new System.Drawing.Point(141, 366);
            this.Manual_Hack_button.Name = "Manual_Hack_button";
            this.Manual_Hack_button.Size = new System.Drawing.Size(108, 21);
            this.Manual_Hack_button.TabIndex = 17;
            this.Manual_Hack_button.UseVisualStyleBackColor = true;
            this.Manual_Hack_button.Click += new System.EventHandler(this.Manual_Hack_button_Click);
            // 
            // SearchMask_Label
            // 
            this.SearchMask_Label.AutoSize = true;
            this.SearchMask_Label.BackColor = System.Drawing.Color.Transparent;
            this.SearchMask_Label.ForeColor = System.Drawing.Color.Yellow;
            this.SearchMask_Label.Location = new System.Drawing.Point(7, 37);
            this.SearchMask_Label.Name = "SearchMask_Label";
            this.SearchMask_Label.Size = new System.Drawing.Size(90, 17);
            this.SearchMask_Label.TabIndex = 11;
            this.SearchMask_Label.Text = "Search Mask";
            // 
            // HexString_Label
            // 
            this.HexString_Label.AutoSize = true;
            this.HexString_Label.BackColor = System.Drawing.Color.Transparent;
            this.HexString_Label.ForeColor = System.Drawing.Color.Yellow;
            this.HexString_Label.Location = new System.Drawing.Point(7, 9);
            this.HexString_Label.Name = "HexString_Label";
            this.HexString_Label.Size = new System.Drawing.Size(94, 17);
            this.HexString_Label.TabIndex = 9;
            this.HexString_Label.Text = "Search String";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.BackgroundImage = global::MegaHack.Properties.Resources.background;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.CustomhackTextBox1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.Load_Custom_HackTable_List);
            this.tabPage3.Controls.Add(this.Load_Custom_Button);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(956, 644);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Custom Hack";
            // 
            // Load_Custom_Button
            // 
            this.Load_Custom_Button.Location = new System.Drawing.Point(7, 615);
            this.Load_Custom_Button.Name = "Load_Custom_Button";
            this.Load_Custom_Button.Size = new System.Drawing.Size(171, 23);
            this.Load_Custom_Button.TabIndex = 0;
            this.Load_Custom_Button.Text = "Load Custom Hacktable";
            this.Load_Custom_Button.UseVisualStyleBackColor = true;
            this.Load_Custom_Button.Click += new System.EventHandler(this.Load_Custom_Button_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Black;
            this.tabPage4.BackgroundImage = global::MegaHack.Properties.Resources.background;
            this.tabPage4.Controls.Add(this.AutoHackHackTextBox1);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.Load_Hacklist_Button);
            this.tabPage4.Controls.Add(this.Select_APK_OBB);
            this.tabPage4.Controls.Add(this.AutoHack_Button);
            this.tabPage4.Controls.Add(this.label_Select_Game);
            this.tabPage4.Controls.Add(this.listBox_AutoHack);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(956, 644);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Auto Hack";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Scan Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Load_Hacklist_Button
            // 
            this.Load_Hacklist_Button.Location = new System.Drawing.Point(120, 7);
            this.Load_Hacklist_Button.Name = "Load_Hacklist_Button";
            this.Load_Hacklist_Button.Size = new System.Drawing.Size(122, 23);
            this.Load_Hacklist_Button.TabIndex = 12;
            this.Load_Hacklist_Button.Text = "Load Hacklist";
            this.Load_Hacklist_Button.UseVisualStyleBackColor = true;
            this.Load_Hacklist_Button.Click += new System.EventHandler(this.Load_Hacklist_Button_Click);
            // 
            // Select_APK_OBB
            // 
            this.Select_APK_OBB.BackColor = System.Drawing.Color.Black;
            this.Select_APK_OBB.BackgroundImage = global::MegaHack.Properties.Resources.button2;
            this.Select_APK_OBB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Select_APK_OBB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Select_APK_OBB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Select_APK_OBB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Select_APK_OBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select_APK_OBB.ForeColor = System.Drawing.Color.Yellow;
            this.Select_APK_OBB.Location = new System.Drawing.Point(10, 607);
            this.Select_APK_OBB.Name = "Select_APK_OBB";
            this.Select_APK_OBB.Size = new System.Drawing.Size(108, 21);
            this.Select_APK_OBB.TabIndex = 11;
            this.Select_APK_OBB.UseVisualStyleBackColor = false;
            this.Select_APK_OBB.Click += new System.EventHandler(this.Select_APK_OBB_Click);
            // 
            // AutoHack_Button
            // 
            this.AutoHack_Button.BackgroundImage = global::MegaHack.Properties.Resources.button3;
            this.AutoHack_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AutoHack_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoHack_Button.Location = new System.Drawing.Point(134, 607);
            this.AutoHack_Button.Name = "AutoHack_Button";
            this.AutoHack_Button.Size = new System.Drawing.Size(108, 21);
            this.AutoHack_Button.TabIndex = 6;
            this.AutoHack_Button.UseVisualStyleBackColor = true;
            this.AutoHack_Button.Click += new System.EventHandler(this.AutoHack_Button_Click);
            // 
            // label_Select_Game
            // 
            this.label_Select_Game.AutoSize = true;
            this.label_Select_Game.ForeColor = System.Drawing.Color.Yellow;
            this.label_Select_Game.Location = new System.Drawing.Point(7, 10);
            this.label_Select_Game.Name = "label_Select_Game";
            this.label_Select_Game.Size = new System.Drawing.Size(89, 17);
            this.label_Select_Game.TabIndex = 1;
            this.label_Select_Game.Text = "Select Game";
            // 
            // listBox_AutoHack
            // 
            this.listBox_AutoHack.BackColor = System.Drawing.Color.Black;
            this.listBox_AutoHack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_AutoHack.ForeColor = System.Drawing.Color.Yellow;
            this.listBox_AutoHack.FormattingEnabled = true;
            this.listBox_AutoHack.ItemHeight = 16;
            this.listBox_AutoHack.Location = new System.Drawing.Point(3, 34);
            this.listBox_AutoHack.Name = "listBox_AutoHack";
            this.listBox_AutoHack.Size = new System.Drawing.Size(371, 562);
            this.listBox_AutoHack.TabIndex = 0;
            this.listBox_AutoHack.SelectedIndexChanged += new System.EventHandler(this.listBox_AutoHack_SelectedIndexChanged);
            // 
            // Load_Custom_HackTable_List
            // 
            this.Load_Custom_HackTable_List.BackColor = System.Drawing.Color.Black;
            this.Load_Custom_HackTable_List.ForeColor = System.Drawing.Color.Yellow;
            this.Load_Custom_HackTable_List.FormattingEnabled = true;
            this.Load_Custom_HackTable_List.ItemHeight = 16;
            this.Load_Custom_HackTable_List.Location = new System.Drawing.Point(7, 35);
            this.Load_Custom_HackTable_List.Name = "Load_Custom_HackTable_List";
            this.Load_Custom_HackTable_List.Size = new System.Drawing.Size(358, 468);
            this.Load_Custom_HackTable_List.TabIndex = 1;
            this.Load_Custom_HackTable_List.SelectedIndexChanged += new System.EventHandler(this.Load_Custom_HackTable_List_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loaded HackTable";
            // 
            // CustomhackTextBox1
            // 
            this.CustomhackTextBox1.BackAlpha = 10;
            this.CustomhackTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CustomhackTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomhackTextBox1.ForeColor = System.Drawing.Color.Yellow;
            this.CustomhackTextBox1.Location = new System.Drawing.Point(393, 35);
            this.CustomhackTextBox1.Multiline = true;
            this.CustomhackTextBox1.Name = "CustomhackTextBox1";
            this.CustomhackTextBox1.Size = new System.Drawing.Size(526, 468);
            this.CustomhackTextBox1.TabIndex = 3;
            // 
            // AutoHackHackTextBox1
            // 
            this.AutoHackHackTextBox1.BackAlpha = 10;
            this.AutoHackHackTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AutoHackHackTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AutoHackHackTextBox1.ForeColor = System.Drawing.Color.Yellow;
            this.AutoHackHackTextBox1.Location = new System.Drawing.Point(405, 34);
            this.AutoHackHackTextBox1.Multiline = true;
            this.AutoHackHackTextBox1.Name = "AutoHackHackTextBox1";
            this.AutoHackHackTextBox1.Size = new System.Drawing.Size(519, 562);
            this.AutoHackHackTextBox1.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(964, 676);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "MegaHack";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label SearchMask_Label;
        private System.Windows.Forms.Label HexString_Label;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label_Select_Game;
        private System.Windows.Forms.ListBox listBox_AutoHack;
        private System.Windows.Forms.Button AutoHack_Button;
        private System.Windows.Forms.Button Manual_Hack_button;
        private System.Windows.Forms.Label label_replace_string;
        private System.Windows.Forms.Label label_movebytes;
        private System.Windows.Forms.CheckBox search_hex_option;
        private System.Windows.Forms.CheckBox Replace_Text_Option;
        private System.Windows.Forms.CheckBox Replace_Hex_Option;
        private System.Windows.Forms.CheckBox search_text_option;
        private System.Windows.Forms.Button button_generate_custom;
        private System.Windows.Forms.Label manual_label_author;
        private System.Windows.Forms.Label manual_label_gamename;
        private System.Windows.Forms.Label manual_label_hacktype;
        private System.Windows.Forms.Button Manual_Select_APK;
        private System.Windows.Forms.Button Select_APK_OBB;
        private ZBobb.MegaHackTextBox Password_Login;
        private ZBobb.MegaHackTextBox Name_Login;
        private ZBobb.MegaHackTextBox Manual_Search_TextBox;
        private ZBobb.MegaHackTextBox Replace_String_Textbox;
        private ZBobb.MegaHackTextBox Move_Bytes_Textbox;
        private ZBobb.MegaHackTextBox manual_textbox_author;
        private ZBobb.MegaHackTextBox manual_textbox_gamename;
        private ZBobb.MegaHackTextBox manual_textbox_hacktype;
        private ZBobb.MegaHackTextBox Manual_SearchMask_TextBox;
        private System.Windows.Forms.Button Load_Custom_Button;
        private System.Windows.Forms.Button Load_Hacklist_Button;
        private ZBobb.MegaHackTextBox Manual_Filetohack_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private ZBobb.MegaHackTextBox CustomhackTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Load_Custom_HackTable_List;
        private ZBobb.MegaHackTextBox AutoHackHackTextBox1;

    }
}

