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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Load_Custom_Button = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Load_Hacklist_Button = new System.Windows.Forms.Button();
            this.AutoHack_Button = new System.Windows.Forms.Button();
            this.Hack_Type_Label = new System.Windows.Forms.Label();
            this.label_hacktype = new System.Windows.Forms.Label();
            this.Author_Label = new System.Windows.Forms.Label();
            this.label_Author_text = new System.Windows.Forms.Label();
            this.label_Select_Game = new System.Windows.Forms.Label();
            this.listBox_AutoHack = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Password_Login = new ZBobb.MegaHackTextBox();
            this.Name_Login = new ZBobb.MegaHackTextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.Select_APK_OBB = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.BackgroundImage = global::MegaHack.Properties.Resources.background;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.tabPage4.Controls.Add(this.Load_Hacklist_Button);
            this.tabPage4.Controls.Add(this.Select_APK_OBB);
            this.tabPage4.Controls.Add(this.AutoHack_Button);
            this.tabPage4.Controls.Add(this.Hack_Type_Label);
            this.tabPage4.Controls.Add(this.label_hacktype);
            this.tabPage4.Controls.Add(this.Author_Label);
            this.tabPage4.Controls.Add(this.label_Author_text);
            this.tabPage4.Controls.Add(this.label_Select_Game);
            this.tabPage4.Controls.Add(this.listBox_AutoHack);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(956, 644);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Auto Hack";
            // 
            // Load_Hacklist_Button
            // 
            this.Load_Hacklist_Button.Location = new System.Drawing.Point(252, 7);
            this.Load_Hacklist_Button.Name = "Load_Hacklist_Button";
            this.Load_Hacklist_Button.Size = new System.Drawing.Size(122, 23);
            this.Load_Hacklist_Button.TabIndex = 12;
            this.Load_Hacklist_Button.Text = "Load Hacklist";
            this.Load_Hacklist_Button.UseVisualStyleBackColor = true;
            this.Load_Hacklist_Button.Click += new System.EventHandler(this.Load_Hacklist_Button_Click);
            // 
            // AutoHack_Button
            // 
            this.AutoHack_Button.BackgroundImage = global::MegaHack.Properties.Resources.button3;
            this.AutoHack_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AutoHack_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoHack_Button.Location = new System.Drawing.Point(737, 607);
            this.AutoHack_Button.Name = "AutoHack_Button";
            this.AutoHack_Button.Size = new System.Drawing.Size(108, 21);
            this.AutoHack_Button.TabIndex = 6;
            this.AutoHack_Button.UseVisualStyleBackColor = true;
            this.AutoHack_Button.Click += new System.EventHandler(this.AutoHack_Button_Click);
            // 
            // Hack_Type_Label
            // 
            this.Hack_Type_Label.AutoSize = true;
            this.Hack_Type_Label.ForeColor = System.Drawing.Color.Yellow;
            this.Hack_Type_Label.Location = new System.Drawing.Point(514, 34);
            this.Hack_Type_Label.Name = "Hack_Type_Label";
            this.Hack_Type_Label.Size = new System.Drawing.Size(0, 17);
            this.Hack_Type_Label.TabIndex = 5;
            // 
            // label_hacktype
            // 
            this.label_hacktype.AutoSize = true;
            this.label_hacktype.ForeColor = System.Drawing.Color.Yellow;
            this.label_hacktype.Location = new System.Drawing.Point(418, 34);
            this.label_hacktype.Name = "label_hacktype";
            this.label_hacktype.Size = new System.Drawing.Size(90, 17);
            this.label_hacktype.TabIndex = 4;
            this.label_hacktype.Text = "Type of hack";
            // 
            // Author_Label
            // 
            this.Author_Label.AutoSize = true;
            this.Author_Label.ForeColor = System.Drawing.Color.Yellow;
            this.Author_Label.Location = new System.Drawing.Point(514, 10);
            this.Author_Label.Name = "Author_Label";
            this.Author_Label.Size = new System.Drawing.Size(0, 17);
            this.Author_Label.TabIndex = 3;
            // 
            // label_Author_text
            // 
            this.label_Author_text.AutoSize = true;
            this.label_Author_text.ForeColor = System.Drawing.Color.Yellow;
            this.label_Author_text.Location = new System.Drawing.Point(418, 10);
            this.label_Author_text.Name = "label_Author_text";
            this.label_Author_text.Size = new System.Drawing.Size(50, 17);
            this.label_Author_text.TabIndex = 2;
            this.label_Author_text.Text = "Author";
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
            this.listBox_AutoHack.Size = new System.Drawing.Size(371, 594);
            this.listBox_AutoHack.TabIndex = 0;
            this.listBox_AutoHack.SelectedIndexChanged += new System.EventHandler(this.listBox_AutoHack_SelectedIndexChanged);
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
            this.Password_Login.Location = new System.Drawing.Point(502, 616);
            this.Password_Login.Name = "Password_Login";
            this.Password_Login.PasswordChar = '*';
            this.Password_Login.Size = new System.Drawing.Size(314, 22);
            this.Password_Login.TabIndex = 11;
            this.Password_Login.UseSystemPasswordChar = true;
            this.Password_Login.Leave += new System.EventHandler(this.Password_Login_Leave);
            // 
            // Name_Login
            // 
            this.Name_Login.BackAlpha = 10;
            this.Name_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Name_Login.Location = new System.Drawing.Point(64, 616);
            this.Name_Login.Name = "Name_Login";
            this.Name_Login.Size = new System.Drawing.Size(343, 22);
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
            // Manual_SearchMask_TextBox
            // 
            this.Manual_SearchMask_TextBox.BackAlpha = 10;
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
            this.Manual_Search_TextBox.BackAlpha = 10;
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
            this.Manual_Select_APK.Location = new System.Drawing.Point(11, 245);
            this.Manual_Select_APK.Name = "Manual_Select_APK";
            this.Manual_Select_APK.Size = new System.Drawing.Size(108, 21);
            this.Manual_Select_APK.TabIndex = 35;
            this.Manual_Select_APK.UseVisualStyleBackColor = true;
            this.Manual_Select_APK.Click += new System.EventHandler(this.Select_APK_OBB_Click);
            // 
            // manual_textbox_hacktype
            // 
            this.manual_textbox_hacktype.BackAlpha = 10;
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
            this.manual_label_hacktype.Location = new System.Drawing.Point(8, 177);
            this.manual_label_hacktype.Name = "manual_label_hacktype";
            this.manual_label_hacktype.Size = new System.Drawing.Size(90, 17);
            this.manual_label_hacktype.TabIndex = 33;
            this.manual_label_hacktype.Text = "Type of hack";
            // 
            // manual_textbox_author
            // 
            this.manual_textbox_author.BackAlpha = 10;
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
            this.manual_textbox_gamename.BackAlpha = 10;
            this.manual_textbox_gamename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.manual_textbox_gamename.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manual_textbox_gamename.ForeColor = System.Drawing.Color.Yellow;
            this.manual_textbox_gamename.Location = new System.Drawing.Point(108, 118);
            this.manual_textbox_gamename.Name = "manual_textbox_gamename";
            this.manual_textbox_gamename.Size = new System.Drawing.Size(836, 27);
            this.manual_textbox_gamename.TabIndex = 30;
            this.manual_textbox_gamename.Text = "Any Game";
            // 
            // manual_label_gamename
            // 
            this.manual_label_gamename.AutoSize = true;
            this.manual_label_gamename.BackColor = System.Drawing.Color.Transparent;
            this.manual_label_gamename.ForeColor = System.Drawing.Color.Yellow;
            this.manual_label_gamename.Location = new System.Drawing.Point(8, 121);
            this.manual_label_gamename.Name = "manual_label_gamename";
            this.manual_label_gamename.Size = new System.Drawing.Size(87, 17);
            this.manual_label_gamename.TabIndex = 29;
            this.manual_label_gamename.Text = "Game Name";
            // 
            // button_generate_custom
            // 
            this.button_generate_custom.Location = new System.Drawing.Point(275, 245);
            this.button_generate_custom.Name = "button_generate_custom";
            this.button_generate_custom.Size = new System.Drawing.Size(171, 23);
            this.button_generate_custom.TabIndex = 28;
            this.button_generate_custom.Text = "Generate Custom Hack";
            this.button_generate_custom.UseVisualStyleBackColor = true;
            this.button_generate_custom.Click += new System.EventHandler(this.button_generate_custom_Click);
            // 
            // Replace_Text_Option
            // 
            this.Replace_Text_Option.AutoSize = true;
            this.Replace_Text_Option.BackColor = System.Drawing.Color.Transparent;
            this.Replace_Text_Option.ForeColor = System.Drawing.Color.Yellow;
            this.Replace_Text_Option.Location = new System.Drawing.Point(482, 207);
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
            this.Replace_Hex_Option.Location = new System.Drawing.Point(323, 207);
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
            this.search_text_option.Location = new System.Drawing.Point(163, 207);
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
            this.search_hex_option.Location = new System.Drawing.Point(11, 207);
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
            this.Move_Bytes_Textbox.BackAlpha = 10;
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
            this.Replace_String_Textbox.BackAlpha = 10;
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
            this.Manual_Hack_button.Location = new System.Drawing.Point(142, 245);
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
            this.Select_APK_OBB.Location = new System.Drawing.Point(600, 607);
            this.Select_APK_OBB.Name = "Select_APK_OBB";
            this.Select_APK_OBB.Size = new System.Drawing.Size(108, 21);
            this.Select_APK_OBB.TabIndex = 11;
            this.Select_APK_OBB.UseVisualStyleBackColor = false;
            this.Select_APK_OBB.Click += new System.EventHandler(this.Select_APK_OBB_Click);
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.Label Hack_Type_Label;
        private System.Windows.Forms.Label label_hacktype;
        private System.Windows.Forms.Label Author_Label;
        private System.Windows.Forms.Label label_Author_text;
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

    }
}

