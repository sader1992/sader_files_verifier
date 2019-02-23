using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Net;

namespace sader_file_verifier
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        config CONF = new config();
        bool Checked = false;
        List<string> broken_file = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            main_label.Text = "Ready";
            main_button.Text = "Start";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"/";
            if (!Checked)
            {
                await MainCheckingFunc(path);
            }
            else
            {
                await MainFixingFunc(path);
                await MainCheckingFunc(path);
            }
            
            MessageBox.Show("done");
        }

        private async Task MainFixingFunc(string path)
        {
            main_label.Text = "Fixing";
            main_button.Enabled = false;
            foreach (string _file in broken_file)
            {
                if (File.Exists(path + _file))
                    File.Delete(path + _file);
                main_label.Text = "Downloading: " + _file;
                bool ex = await GetFile(CONF.FILES_URL + _file, _file);
                if (!ex)
                {
                    Environment.Exit(0);
                }
            }

            Checked = false;
        }

        private async Task MainCheckingFunc(string path)
        {
            main_label.Text = "Getting Information File";
            main_button.Enabled = false;
            bool ex = await GetFile(CONF.INFO_TEXT_URL, CONF.INFO_TEXT_NAME);
            if (!ex)
            {
                Environment.Exit(0);
            }

            Task<List<string>> _v = new Task<List<string>>(() => ReadInfo(path));
            _v.Start();
            List<string> verifyed = await _v;

            main_label.Text = "Checking Client Files, this will take a while";
            Task<List<string>> verifing = new Task<List<string>>(() => CheckLocalFiles(path, verifyed));
            verifing.Start();
            broken_file = await verifing;

            if (broken_file.Count != 0)
            {
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
                File.Delete(path + CONF.INFO_TEXT_NAME);
        }

        //checking local files
        private static List<string> CheckLocalFiles(string path, List<string> verifyed)
        {
            List<string> f = new List<string>();
            for (int i = 0; i < verifyed.Count; i += 2)
            {
                if (!File.Exists(path + verifyed[i]))
                {
                    f.Add(verifyed[i]);
                }
                else
                {
                    if (_SHA256(path + verifyed[i]) != verifyed[i + 1])
                    {
                        f.Add(verifyed[i]);
                    }
                }

            }
            return f;
        }

        //read information file and return array of the files name and haches
        private List<string> ReadInfo(string path)
        {
            string info_file = path + CONF.INFO_TEXT_NAME;

            if (!File.Exists(info_file))
                return null;

            List<string> vrf = new List<string>();
            foreach (string line in File.ReadLines(info_file))
            {
                if(line != "")
                {
                    string[] _conf = line.Split(':');
                    vrf.Add(_conf[0]);
                    vrf.Add(_conf[1]);
                }
            }
            return vrf;
        }

        //calculate the files haches
        private static string _SHA256(string path)
        {
            using (SHA256 SHA256 = SHA256Managed.Create())
            {
                using (FileStream fileStream = File.OpenRead(path))
                    return Convert.ToBase64String(SHA256.ComputeHash(fileStream));
            }
        }


        //download file from url
        private async Task<bool> GetFile(string _url, string _name)
        {
            using (WebClient wc = new WebClient())
            {
                Uri file_url = new Uri(_url);
                try
                {
                    await wc.DownloadFileTaskAsync(file_url, _name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
            }
            return true;
        }
    }
}