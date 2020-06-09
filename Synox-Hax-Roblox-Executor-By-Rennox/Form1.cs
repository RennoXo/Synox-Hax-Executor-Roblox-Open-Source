using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using EasyExploits;

namespace Synox_Hax_Roblox_Executor_By_Rennox
{
    public partial class Form1 : Form
    {

        EasyExploits.Module api = new EasyExploits.Module();

        public Form1()
        {
            InitializeComponent();
            ENABLED_MANAGER();
            VERSION_MANAGER();
            GET_SCRIPT_PATH();
            UPDATE_LIST_BOX();
        }
       
        //VARS\\
        public string START_PATH = Application.StartupPath;
        public string IS_ENABLED = "https://raw.githubusercontent.com/RennoXo/RennoX_ModZ_Data/master/Launcher/Games/Roblox/Enabled.txt";
        public string DISABLED_MESSAGE = "https://raw.githubusercontent.com/RennoXo/RennoX_ModZ_Data/master/Launcher/Games/Roblox/Dmessage.txt";
        public string VERSION_SERVER = "https://raw.githubusercontent.com/RennoXo/RennoX_ModZ_Data/master/Launcher/Games/Roblox/Version.txt";
        public bool IS_LIGHT = false;

        //=========CONTROL BUTTONS=========\\
        private void MINIMIZE_BUTTON_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void EXIT_BUTTON_Click(object sender, EventArgs e)
        {
            KILL_SYNOX();
        }


        private void KILL_SYNOX()
        {
            Process[] synox = Process.GetProcesses();
            foreach (Process getsynox in synox)
            {
                bool flag = getsynox.ProcessName == "Synox-Hax-Roblox-Executor-By-Rennox";
                if (flag)
                {
                    getsynox.Kill();
                }
            }
        }

        private void KILL_ROBLOX_BUTTON_Click(object sender, EventArgs e)
        {
            Process[] rb = Process.GetProcesses();
            foreach (Process openroblox in rb)
            {
                bool flag = openroblox.ProcessName == "RobloxPlayerBeta";
                if (flag)
                {
                    openroblox.Kill();
                }
            }
        }

        private void CLEAR_BUTTON_Click(object sender, EventArgs e)
        {
            EDITOR.Text = "";
        }

        private void REFRESH_LIST_Click(object sender, EventArgs e)
        {
            UPDATE_LIST_BOX();
        }

        //=========INTERN=========\\

        private string GET_SCRIPT_PATH()
        {
            string GET_FILE_FOLDER = Path.Combine(START_PATH, "Scripts");
            if (Directory.Exists(GET_FILE_FOLDER))
            {
                return GET_FILE_FOLDER;
            }
            else
            {
                Directory.CreateDirectory(GET_FILE_FOLDER);
                return GET_FILE_FOLDER;
            }
        }

        private void VERSION_MANAGER()
        {
            WebClient client = new WebClient();
            string VersionGot = client.DownloadString(VERSION_SERVER);
            string ValGot = VersionGot.Substring(0, 7); //7 = 7 Letters(with .) || If version changes to 10.0.0.0 then change to 8
            if (Application.ProductVersion == ValGot)
            {
              
            }
            else
            {
                MessageBox.Show("OH NO!\nThe exploit is outdated!\nYou can use this version, but it will probably not work anymore!\nIf the other versíon dont work to, there is probably a problem with synox .-.\nIf this version is not working too then follow this steps:\n1.Delete all EasyExploit.dll's in the folder\n2.Download the newest EasyExploit.dll on their website (https://easyexploits.com/)\n3.Make sure that its called 'EasyExploits.dll', or it wont work!", "SYNOX-HAX-OUTDATED");
                //this.Close();
            }
        }

        private void ENABLED_MANAGER()
        {
            WebClient client = new WebClient();
            string CommandGot = client.DownloadString(IS_ENABLED);
            if (CommandGot == "true")
            {
                //Console.WriteLine("ayayaya");
            }
            else
            {
              // string MessageGot = client.DownloadString(DISABLED_MESSAGE);
               // Console.WriteLine(CommandGot);
                //MessageBox.Show(MessageGot, "SYNOX-HAX-DISABLED");
             //   this.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string findscript = GET_SCRIPT_PATH();
            if (listBox1.SelectedIndex > -1)
            {
                string foundscript = findscript+"/"+ listBox1.SelectedItem.ToString();
                EDITOR.Text = (File.ReadAllText(foundscript));
            }
        }

        private void UPDATE_LIST_BOX()
        {
            listBox1.Items.Clear();
            string[] files = Directory.GetFiles(GET_SCRIPT_PATH());
            foreach (string file in files)
            {
                listBox1.Items.Add(System.IO.Path.GetFileName(file));
            }
        }

        private void OPEN_BUTTON_Click(object sender, EventArgs e)
        {
            OPEN_FILE.Filter = "Text and Lua Files|*.lua;*.txt";
            OPEN_FILE.ShowDialog();
            string PfadDatei = OPEN_FILE.FileName;
            if (File.Exists(PfadDatei))
            {
                EDITOR.Text = File.ReadAllText(PfadDatei);
            }
        }

        private void SAVE_BUTTON_Click(object sender, EventArgs e)
        {
            SaveFileDialog SAVE_FILE = new SaveFileDialog();

            SAVE_FILE.Filter = "Text and Lua Files|*.lua;*.txt";
            SAVE_FILE.FilterIndex = 2;
            SAVE_FILE.RestoreDirectory = true;

            if(SAVE_FILE.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(SAVE_FILE.FileName);

                sw.Write(EDITOR.Text);
                sw.Flush();
                sw.Close();
            }
        }

        private void CUSTOMIZE_BUTTON_Click(object sender, EventArgs e)
        {
            if (CUSTOMIZE_PANEL.Visible == true)
            {
                CUSTOMIZE_PANEL.Visible = false;
                EDITOR.Visible = true;
            }
            else
            {
                CUSTOMIZE_PANEL.Visible = true;
                EDITOR.Visible = false;
            }
        }

        public void SET_MODE(bool m)
        {
            if (m == true)
            {
                if (IS_LIGHT == false)
                {
                    IS_LIGHT = true;
                    EDITOR.BackColor = Color.White;
                    EDITOR.ForeColor = Color.Black;
                    EDITOR.IndentBackColor = Color.White;
                    EDITOR.LineNumberColor = Color.Black;
                    this.BackColor = Color.White;
                    listBox1.BackColor = Color.White;
                    listBox1.ForeColor = Color.Black;
                    CUSTOMIZE_PANEL.BackColor = Color.White;
                    LIGHT_MODE.ForeColor = Color.Black;
                    DARK_MODE.ForeColor = Color.Black;
                    GIF_RESET.ForeColor = Color.Black;
                    GIF_ADD.ForeColor = Color.Black;
                    COMMING1.ForeColor = Color.Black;
                    COMMING2.ForeColor = Color.Black;
                    REFRESH_LIST.ForeColor = Color.Black;
                    REFRESH_LIST.BackColor = Color.White;
                    BUTTONS_PANEL.BackColor = Color.White;
                    BUTTONS_PANEL_2.BackColor = Color.White;
                    KILL_ROBLOX_BUTTON.ForeColor = Color.Black;
                    EXECUTE_BUTTON.ForeColor = Color.Black;
                    INJECT_BUTTON.ForeColor = Color.Black;
                    CLEAR_BUTTON.ForeColor = Color.Black;
                    SAVE_BUTTON.ForeColor = Color.Black;
                    OPEN_BUTTON.ForeColor = Color.Black;
                    CUSTOMIZE_BUTTON.ForeColor = Color.Black;
                    DRAG_CONTROL.BackColor = Color.White;
                    HEAD_LABEL.ForeColor = Color.Black;
                    MINIMIZE_BUTTON.ForeColor = Color.Black;
                    EXIT_BUTTON.ForeColor = Color.Black;
                }
            }
            else
            {
                if (IS_LIGHT == true)
                {
                    IS_LIGHT = false;
                    Application.Restart();
                }
            }
        }

        private void LIGHT_MODE_Click(object sender, EventArgs e)
        {
            SET_MODE(true);
        }

        private void DARK_MODE_Click(object sender, EventArgs e)
        {
            SET_MODE(false);
        }

        private void INJECT_BUTTON_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void EXECUTE_BUTTON_Click(object sender, EventArgs e)
        {
            api.ExecuteScript(EDITOR.Text);
        }
    }
}
