using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Synox_Hax_Roblox_Executor_By_Rennox
{
    public partial class KeyForm : Form
    {

        public string KEY = "https://raw.githubusercontent.com/RennoXo/RennoX_ModZ_Data/master/Launcher/Games/Roblox/Key.txt";

        public KeyForm()
        {
            InitializeComponent();

         //   string key1 = Properties.Settings.Default.Key.Substring(0, 4);
         //   string key2 = key_s().Substring(0, 4);
         //   if (key1 == key2)
          //  {
            //    COMPARE_KEY(key1,key2);
          //  }
        }


        public string key_s()
        {
            WebClient client = new WebClient();
            string KeyGot = client.DownloadString(KEY);
            return KeyGot;
        }

        private void ENTER_Click(object sender, EventArgs e)
        {
            COMPARE_KEY(KEY_BOX.Text,key_s());
        }




        public bool COMPARE_KEY(string key1a,string key2a)
        {
            string key1 = key1a.Substring(0, 4);
            string key2 = key2a.Substring(0, 4);
            if (key1 == key2)
            {
                Form1 f1 = new Form1();
                f1.Show();
                Properties.Settings.Default.Key = key1;
                Properties.Settings.Default.Save();
                Thread.Sleep(100);
                System.Threading.Thread.Sleep(1000);
                this.Hide();
                return true;
            }
            else
            {
                MessageBox.Show("Wrong key!\nMake sure that your key have 4 numbers and no spaces!", "Synox Hax");
                KEY_BOX.Text = "";
                return false;
            }
        }

        private void EXIT_BUTTON_Click(object sender, EventArgs e)
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

        private void MINIMIZE_BUTTON_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void KeyForm_Load(object sender, EventArgs e)
        {

        }

        private void GET_KEY_LINK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://raw.githubusercontent.com/RennoXo/RennoX_ModZ_Data/master/Launcher/Games/Roblox/Key.txt");
        }
    }
}
