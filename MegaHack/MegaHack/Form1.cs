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
        string[] line;
        List<string[]> ManualHackList = new List<string[]>();
        List<string[]> AutoHackList = new List<string[]>();

        string[] Hack_List_Stuff;
        public MainForm()
        {
            InitializeComponent();
            manual_selected = "HEX";
            manual_replaced = "HEX";            
        }
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
        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (Login_Name != null && Login_Password != null)
            {
                checklogin();       
            }
        }
private void checklogin()
        {
            //This function is not added yet
            //need to add in a read to database to see if user is subscribed via PHP webpage (I made one already just need to link code to it)
            //need to add checks on the scan functions to validate that user is properly logged in.

        }
        private void Name_Login_Leave(object sender, EventArgs e)
        {
            Login_Name = Name_Login.Text;
        }

        private void Password_Login_Leave(object sender, EventArgs e)
        {
            Login_Password = Password_Login.Text;
        }
        

//BLABLA SCANNER CODE HERE

        public void Scan(string startscan)
        {
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
            if (filename != null && startscan == "Manual")
            {                
                scanfile();  
            }

        }

        public void scanfile()
        {
            FileInfo f = new FileInfo(filename);
            size = Convert.ToInt32(f.Length);

            //initialize the MegaHack class to open a file, offset, and size to read
            MegaHack scann = new MegaHack(filename, 0, size);
            //Filter out dynamic parts of the string
            Offset = scann.FindPattern(StringToByteArray(Hack_List_Stuff[3].Replace(" ", "")), Hack_List_Stuff[4].Replace(" ", ""), Convert.ToInt16(Hack_List_Stuff[7]));
            replacehex();
        }
        public void replacehex()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.Open)))
            {
                byte[] overwrite = StringToByteArray(line[5]);
                writer.Seek(Offset.ToInt32(), SeekOrigin.Begin);
                writer.Write(Hack_List_Stuff[5].Replace(" ", ""));
            }
        }
        // READ HEXDATA FROM FILE
        public void FetchHex()
        {
            int counter = 0;
            // Read the file and display it line by line. This will be changed to read the data from database instead
            System.IO.StreamReader file =
               new System.IO.StreamReader("MegaHackHex.hex");
            //-----------------
            string readline = null;
            do
            {
                readline = file.ReadLine();
                if (readline != null)
                {
                    ManualHackList.Add(readline.Replace(" ", "").Replace("+", " ").Split('*'));
                    //     listBox_AutoHack.Items.Add();
                    counter++;
                }

            } while (readline != null);
            file.Close();
        }       


        // END OF SCANNER CODE

        //WEBCLIENT CODE TO CHECK LOGIN AND TO DOWNLOAD HEX DATA

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

        private void Select_APK_OBB_Click(object sender, EventArgs e)
        {
            //Store file opened by user
            OpenFileDialog Select_File = new OpenFileDialog();
            Select_File.Filter = "APK files (*.apk)|*.apk|OBB files (*.obb)|*.obb";
            Select_File.FilterIndex = 1;
            if (Select_File.ShowDialog() == DialogResult.OK)
            {
                filename = Select_File.FileName;
            }
        }

        private void listBox_AutoHack_SelectedIndexChanged(object sender, EventArgs e)
        {
            int curItem = listBox_AutoHack.SelectedIndex;
            Author_Label.Text = AutoHackList[curItem].GetValue(1).ToString();
            Hack_Type_Label.Text = AutoHackList[curItem].GetValue(2).ToString();
        }

        private void AutoHack_Button_Click(object sender, EventArgs e)
        {
            //scanfile();
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

        private void button_generate_custom_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"Custom\"+manual_textbox_gamename.Text.Replace(" ", "")+"_" + Login_Name + ".mh", manual_textbox_gamename.Text.Replace(" ", "+") + "*" + manual_textbox_author.Text.Replace(" ", "+") + "*" + manual_textbox_hacktype.Text.Replace(" ", "+") + "*" + Manual_Search_TextBox.Text + "*" + Manual_SearchMask_TextBox.Text + "*" + Replace_String_Textbox.Text + "*" + Move_Bytes_Textbox.Text);
        }

        private void Load_Custom_Button_Click(object sender, EventArgs e)
        {
            Scan("Manual");
        }

        private void Load_Hacklist_Button_Click(object sender, EventArgs e)
        {
            connect("http://www.anonthanatos.com/MegaHack/index.php", "true", Login_Name, Login_Password, "All", "false");
        }
      }
    }
