using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sader_file_verifier
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        readonly config CONF = new config();
        bool Checked = false;
        List<string> broken_file = new List<string>();
        string path = "";

        private void Form1_Load(object sender, EventArgs e)
        {

            Process[] pname = Process.GetProcessesByName(CONF.CLINT_EXE);
            if (pname.Length > 0)
            {
                MessageBox.Show(CONF.CLINT_EXE + " is Running ,Please close it and run the program again!", "ERROR!! Client Detected");
                Environment.Exit(0);
            }
            path = Directory.GetCurrentDirectory() + @"/";
            BackgroundImageLayout = ImageLayout.Center;
            MainLabel("Ready");
            this.BackColor = Color.FromArgb(71, 50, 60);
            this.TransparencyKey = this.BackColor;


            main_button.BackgroundImage = Properties.Resources.load;
            main_button.Text = "Start";
        }
        private async void Main_button_Click(object sender, EventArgs e)
        {
            if (!Checked)
            {
                await MainCheckingFunc();
            }
            else
            {
                await MainFixingFunc();
                await MainCheckingFunc();

            }

            MessageBox.Show("done");
        }

        private async Task MainFixingFunc()
        {
            main_label.Text = "Fixing";
            main_button.Enabled = false;
            this.main_button.BackgroundImage = Properties.Resources.disabled;
            for (int i = 0; i < broken_file.Count; i += 2)
            {
                if (File.Exists(path + broken_file[i] + broken_file[i + 1]))
                {
                    File.Delete(path + broken_file[i] + broken_file[i + 1]);
                }

                main_label.Text = "Downloading: " + broken_file[i + 1];
                bool ex = await GetFile(CONF.FILES_URL + broken_file[i] + broken_file[i + 1], broken_file[i], broken_file[i + 1]);
                if (!ex)
                {
                    Environment.Exit(0);
                }
            }

            Checked = false;
        }

        private async Task MainCheckingFunc()
        {
            main_label.Text = "Getting Information File";
            main_button.Enabled = false;
            this.main_button.BackgroundImage = Properties.Resources.disabled;
            bool ex = await GetFile(CONF.INFO_TEXT_URL, "", CONF.INFO_TEXT_NAME);
            if (!ex)
            {
                Environment.Exit(0);
            }

            Task<List<string>> _v = new Task<List<string>>(() => ReadInfo());
            _v.Start();
            List<string> verifyed = await _v;

            main_label.Text = "Checking Client Files, this will take a while";
            Task<List<string>> verifing = new Task<List<string>>(() => CheckLocalFiles(verifyed));
            verifing.Start();
            broken_file = await verifing;

            if (broken_file.Count != 0)
            {
                this.main_button.BackgroundImage = Properties.Resources.load;
                main_button.Enabled = true;
                main_button.Text = "Fix";
                main_label.Text = broken_file.Count + " Files Found Broken.";
                Checked = true;
            }
            else
            {
                main_button.Text = "Done";
                main_label.Text = "Ready to Play!";
            }
            if (File.Exists(path + CONF.INFO_TEXT_NAME))
            {
                File.Delete(path + CONF.INFO_TEXT_NAME);
            }
        }

        //checking local files
        private List<string> CheckLocalFiles(List<string> verifyed)
        {
            List<string> f = new List<string>();
            for (int i = 0; i < verifyed.Count; i += 3)
            {
                if (!File.Exists(path + verifyed[i] + verifyed[i + 1]))
                {
                    f.Add(verifyed[i]);
                    f.Add(verifyed[i + 1]);
                }
                else
                {
                    if (SHA256(path + verifyed[i] + verifyed[i + 1]) != verifyed[i + 2])
                    {
                        f.Add(verifyed[i]);
                        f.Add(verifyed[i + 1]);
                    }
                }

            }
            return f;
        }

        private void MainLabel(string text)
        {
            main_label.Text = text;
            main_label.TextAlign = ContentAlignment.MiddleCenter;
        }

        //read information file and return array of the files name and haches
        private List<string> ReadInfo()
        {
            string info_file = path + CONF.INFO_TEXT_NAME;

            if (!File.Exists(info_file))
            {
                return null;
            }

            List<string> vrf = new List<string>();
            foreach (string line in File.ReadLines(info_file))
            {
                if (line != "" && !line.StartsWith("//"))
                {
                    List<string> _conf = line.Split(':').ToList<string>();
                    if (_conf.Count == 2)
                    {
                        vrf.Add("");
                        vrf.Add(_conf[0]);
                        vrf.Add(_conf[1]);
                    }
                    else
                    {
                        vrf.Add(_conf[0]);
                        vrf.Add(_conf[1]);
                        vrf.Add(_conf[2]);
                    }
                }
            }
            return vrf;
        }

        //calculate the files haches
        private static string SHA256(string p)
        {
            using (SHA256 SHA256 = SHA256Managed.Create())
            {
                using (FileStream fileStream = File.OpenRead(p))
                {
                    return Convert.ToBase64String(SHA256.ComputeHash(fileStream));
                }
            }
        }


        //download file from url
        private async Task<bool> GetFile(string _url, string p, string _name)
        {
            using (WebClient wc = new WebClient())
            {
                Uri file_url = new Uri(_url);
                try
                {
                    if (p != "")
                    {
                        if (!Directory.Exists(path + p))
                        {
                            Directory.CreateDirectory(path + p);
                        }
                    }

                    await wc.DownloadFileTaskAsync(file_url, path + p + _name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
            }
            return true;
        }


        //allow window moves
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                    {
                        m.Result = (IntPtr)0x2;
                    }

                    return;
            }
            base.WndProc(ref m);
        }

        private void Main_button_Enter(object sender, EventArgs e)
        {
            //main_button.Text = "test";
            if (main_button.Enabled != false)
            {
                this.main_button.BackgroundImage = Properties.Resources.click;
            }
        }

        private void Main_button_MouseHover(object sender, EventArgs e)
        {
            if (main_button.Enabled != false)
            {
                this.main_button.BackgroundImage = Properties.Resources.click;
            }
        }

        private void Main_button_MouseLeave(object sender, EventArgs e)
        {
            if (main_button.Enabled != false)
            {
                this.main_button.BackgroundImage = Properties.Resources.load;
            }
        }

        private void Main_button_MouseDown(object sender, MouseEventArgs e)
        {
            if (main_button.Enabled != false)
            {
                this.main_button.BackgroundImage = Properties.Resources.hover;
            }
        }

        private void Main_button_MouseUp(object sender, MouseEventArgs e)
        {
            this.main_button.BackgroundImage = Properties.Resources.click;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }

}