using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace MegaHack
{
    public partial class MainForm : Form
    {
        string manual_selected;
        string manual_replaced;
        public string filename;
        public string Login_Name;
        public string Login_Password;
        public byte[] manual_hexstring;
        public string manual_mask;
        Int32 size;
        IntPtr Offset;
        List<string[]> ManualHackList = new List<string[]>();
        List<IntPtr> ManualOffsetHackList = new List<IntPtr>();
        List<string[]> AutoHackList = new List<string[]>();
        string[] Hack_List_Stuff;
        public MainForm()
        {
            InitializeComponent();
            manual_selected = "HEX";
            manual_replaced = "HEX";
        }
        //CONVERTING FUNCTIONS
        private static string ConvertToHex(byte[] bytes)
        {
            var builder = new StringBuilder();

            var hexCharacters = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            for (var i = 0; i < bytes.Length; i++)
            {
                int firstValue = (bytes[i] >> 4) & 0x0F;
                int secondValue = bytes[i] & 0x0F;

                char firstCharacter = hexCharacters[firstValue];
                char secondCharacter = hexCharacters[secondValue];

                //builder.Append("0x");
                builder.Append(firstCharacter);
                builder.Append(secondCharacter);
                //builder.Append(' ');
            }

            return builder.ToString();
        }
        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        //LOGIN STUFF TO VALIDATE USER
        private void Name_Login_Leave(object sender, EventArgs e)
        {
            Login_Name = Name_Login.Text;
        }
        private void Password_Login_Leave(object sender, EventArgs e)
        {
            Login_Password = Password_Login.Text;
        }
        private void checklogin()
        {
            //This function is not added yet
            //need to add in a read to database to see if user is subscribed via PHP webpage (I made one already just need to link code to it)
            //need to add checks on the scan functions to validate that user is properly logged in.

        }

        //FUNCTION TO SELECT FILE
        public void Scan(string startscan)
        {
            if (startscan == "ManualHack")
            {
                //Store file opened by user
                OpenFileDialog Select_File = new OpenFileDialog();
                Select_File.Filter = "Any file (*.*)|*.*";
                Select_File.FilterIndex = 1;
                if (Select_File.ShowDialog() == DialogResult.OK)
                {
                    filename = Select_File.FileName;
                }
            }
            if (startscan == "AutoHack")
            {
                //Store file opened by user
                OpenFileDialog Select_File = new OpenFileDialog();
                Select_File.Filter = "APK files (*.apk)|*.apk|All files (*.*)|*.*";
                Select_File.FilterIndex = 1;
                if (Select_File.ShowDialog() == DialogResult.OK)
                {
                    filename = Select_File.FileName;
                }
            }
            if (startscan == "Manual")
            {
                //Store file opened by user
                OpenFileDialog Select_File = new OpenFileDialog();
                Select_File.Filter = "MegaHack files (*.mh)|*.mh";
                Select_File.FilterIndex = 1;
                if (Select_File.ShowDialog() == DialogResult.OK)
                {
                    filename = Select_File.FileName;
                }
            }
            if (filename != null && startscan == "ManualHack")
            {
                Manual_Filetohack_textbox.Text = filename;
            }
            if (filename != null && startscan == "AutoHack")
            {
                scanfile();
            }
            if (filename != null && startscan == "Manual")
            {
                FetchHex();
            }
        }

        //SCANNER STUFF
        public void scanfile()
        {
            int counter = 0;
            while ((counter < ManualHackList.Count))
            {
                string hackfilename = ManualHackList[counter].GetValue(7).ToString();
                FileInfo f = new FileInfo(hackfilename);
                try
                {
                    size = Convert.ToInt32(f.Length);
                }
                catch (Exception)
                {

                    MessageBox.Show("Make Sure you unpacked the game/program APK into correct folder!\nUnable to locate file " + hackfilename);
                }

                // TODO ADD IN A FUNCTION FOR THE AUTOHACK LOOKING AT WHAT LISTBOX INDEX ARE CHOOSEN
                //initialize the MegaHack class to open a file, offset, and size to read
                MegaHack scann = new MegaHack(hackfilename, 0, size);
                //Filter out dynamic parts of the string

                Offset = scann.FindPattern(StringToByteArray(ManualHackList[counter].GetValue(3).ToString()), ManualHackList[counter].GetValue(4).ToString(), Convert.ToInt16(ManualHackList[counter].GetValue(6)));

                ManualOffsetHackList.Add(Offset);
                counter++;
            }
            replacehex();
        }
        public void replacehex()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.Open)))
            {
                int counter = 0;
                while ((counter < ManualHackList.Count))
                {
                    byte[] overwrite = StringToByteArray(ManualHackList[counter].GetValue(5).ToString());
                    writer.Seek(Offset.ToInt32(), SeekOrigin.Begin);
                    writer.Write(Hack_List_Stuff[5].Replace(" ", ""));
                    counter++;
                }
            }
        }

        //LOAD A CUTOM HACKTABLE
        public void FetchHex()
        {
            int counter = 0;
            System.IO.StreamReader file =
               new System.IO.StreamReader(filename);
            //-----------------
            string readline = null;
            do
            {
                readline = file.ReadLine();
                if (readline != null)
                {
                    ManualHackList.Add(readline.Replace(" ", "").Replace("+", " ").Split('*'));
                    Load_Custom_HackTable_List.Items.Add(ManualHackList[counter].GetValue(0));
                    counter++;
                }

            } while (readline != null);
            file.Close();
            // scanfile(); NONONO Need to put this on a HackIt Button!!!!
        }

        //CONNECT TO DATABASE VIA PHP WEBSITE TO GET HACKTABLES
        public void connect(string towhat, string startup, string user, string pass, string game, string gethack)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(towhat);

                string postData = "startup=" + startup +
                                  "&validate_me1=" + Login_Name +
                                  "&validate_me2=" + Login_Password +
                                  "&gamename=" + game +
                                  "get_hacktable" + gethack;
                byte[] data = System.Text.Encoding.UTF8.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream());
                {
                    int counter = 0;
                    string line;

                    while ((line = responseString.ReadLine()) != null)
                    {

                        AutoHackList.Add(line.Split('-'));
                        listBox_AutoHack.Items.Add(AutoHackList[counter].GetValue(0));
                        counter++;
                    }
                }
            }



            catch (System.Net.WebException e)
            {
                MessageBox.Show("Error:\n" + e);
            }

            finally
            {

            }

        }

        //TEXTBOXES IN HERE
        private void Manual_SearchMask_TextBox_Leave(object sender, EventArgs e)
        {
            if (manual_selected == "HEX")
            {
                if (Manual_SearchMask_TextBox.Text.Count() != (Manual_Search_TextBox.Text.Count() / 2))
                {
                    MessageBox.Show("Mask size needs to be same as amount of bytes in the search string\nExample:\nSearch String 01020304 will need\nMask xxxxxxxx ");
                }
            }
            if (manual_selected == "TEXT")
            {
                if (Manual_SearchMask_TextBox.Text.Count() != (Manual_Search_TextBox.Text.Count()))
                {
                    MessageBox.Show("Mask size needs to be same as amount of bytes in the search string\nExample:\nSearch String 01020304 will need\nMask xxxxxxxx ");
                }
            }

        }
        private void Manual_Search_TextBox_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.Manual_Search_TextBox, "Make hexstring formatted like this 010203040506");
        }
        private void Manual_SearchMask_TextBox_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.Manual_SearchMask_TextBox, "Make mask formatted like this xx??xx?   x= static value ?= dynamic value");
        }
        private void Manual_SearchMask_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (manual_selected == "HEX")
            {
                Manual_SearchMask_TextBox.MaxLength = (Manual_Search_TextBox.Text.Count() / 2);
            }
            if (manual_selected == "TEXT")
            {
                Manual_SearchMask_TextBox.MaxLength = (Manual_Search_TextBox.Text.Count());
            }
            if (Manual_SearchMask_TextBox.Text.EndsWith("x") || Manual_SearchMask_TextBox.Text.EndsWith("?"))
            {

            }
            else
            {
                try
                {
                    Manual_SearchMask_TextBox.Text = Manual_SearchMask_TextBox.Text.Remove(Manual_SearchMask_TextBox.Text.Trim().Length - 1);
                    Manual_SearchMask_TextBox.Focus();
                    Manual_SearchMask_TextBox.SelectionStart = Manual_SearchMask_TextBox.Text.Length;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error wrong character used: \nValid letters used in searchmask are \nx for static byte/char\n? for dynamic byte/char ");
                }
            }

        }

        //LISTBOXES IN HERE
        private void listBox_AutoHack_SelectedIndexChanged(object sender, EventArgs e)
        {
            int curItem = listBox_AutoHack.SelectedIndex;
            AutoHackHackTextBox1.Text =
            AutoHackList[curItem].GetValue(0).ToString() + Environment.NewLine +
            AutoHackList[curItem].GetValue(1).ToString() + Environment.NewLine +
            AutoHackList[curItem].GetValue(2).ToString() + Environment.NewLine;
        }
        private void Load_Custom_HackTable_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            int curItem = Load_Custom_HackTable_List.SelectedIndex;
            CustomhackTextBox1.Text =
                ManualHackList[curItem].GetValue(0).ToString() + Environment.NewLine +
                ManualHackList[curItem].GetValue(1).ToString() + Environment.NewLine +
                ManualHackList[curItem].GetValue(2).ToString() + Environment.NewLine;

        }

        //OPTION BOXES IN HERE
        private void Replace_Hex_Click(object sender, EventArgs e)
        {
            manual_replaced = "HEX";
            Replace_Text_Option.Checked = false;
        }
        private void Replace_Text_Click(object sender, EventArgs e)
        {
            manual_replaced = "TEXT";
            Replace_Hex_Option.Checked = false;
        }
        private void search_hex_option_CheckedChanged(object sender, EventArgs e)
        {
            manual_selected = "HEX";
            search_text_option.Checked = false;
        }
        private void search_text_option_CheckedChanged(object sender, EventArgs e)
        {
            manual_selected = "TEXT";
            search_hex_option.Checked = false;
        }

        // BUTTONS IN HERE
        private void Manual_Hack_button_Click(object sender, EventArgs e)
        {
            if (manual_selected == "HEX" && manual_replaced == "HEX" && Manual_Search_TextBox.Text != "" && Manual_SearchMask_TextBox.Text != "" && Replace_String_Textbox.Text != "" && Move_Bytes_Textbox.Text != "")
            {
                //                AuthorList.Add("0" + "*" + "0" + "*" + "0" + "*" + Manual_Search_TextBox.Text + "*" + Manual_SearchMask_TextBox.Text + "*" + Replace_String_Textbox.Text + "*" + Move_Bytes_Textbox.Text);
            }
            if (manual_selected == "TEXT" && manual_replaced == "TEXT" && Manual_Search_TextBox.Text != "" && Manual_SearchMask_TextBox.Text != "" && Replace_String_Textbox.Text != "" && Move_Bytes_Textbox.Text != "")
            {
                //               AuthorList.Add("0" + "*" + "0" + "*" + "0" + "*" + ConvertToHex(Encoding.ASCII.GetBytes(Manual_Search_TextBox.Text)) + "*" + Manual_SearchMask_TextBox.Text + "*" + ConvertToHex(Encoding.ASCII.GetBytes(Replace_String_Textbox.Text)) + "*" + Move_Bytes_Textbox.Text);
            }

        }
        private void button_generate_custom_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"Custom\" + manual_textbox_gamename.Text.Replace(" ", "") + "_" + Login_Name + ".mh", manual_textbox_gamename.Text.Replace(" ", "+") + "*" + manual_textbox_author.Text.Replace(" ", "+") + "*" + manual_textbox_hacktype.Text.Replace(" ", "+") + "*" + Manual_Search_TextBox.Text + "*" + Manual_SearchMask_TextBox.Text + "*" + Replace_String_Textbox.Text + "*" + Move_Bytes_Textbox.Text + "*" + Manual_Filetohack_textbox.Text);
        }
        private void Load_Custom_Button_Click(object sender, EventArgs e)
        {
            Scan("Manual");
        }
        private void Select_APK_OBB_Click(object sender, EventArgs e)
        {
            Scan("ManualHack");
        }
        private void AutoHack_Button_Click(object sender, EventArgs e)
        {
            //scanfile();
        }
        private void Load_Hacklist_Button_Click(object sender, EventArgs e)
        {
            connect("http://www.anonthanatos.com/MegaHack/index.php", "true", Login_Name, Login_Password, "All", "false");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Add function to scan all files in folder to see if hacks are compatable and get up proper hacklist
        }
        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (Login_Name != null && Login_Password != null)
            {
                checklogin();
            }
            else MessageBox.Show("You need to put in a valid Name and Password to login and validate!");
        }

    }
    }
