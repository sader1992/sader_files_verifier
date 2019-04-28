using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pre_compiled_generator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        static readonly byte[] sfv = Properties.Resources.Sader_Files_Verifier;
        static readonly byte[] ginfo = Properties.Resources.get_information;
        //string iURL, iName, fURL, cName, sName, path;
        string path = "";
        private void Main_Load(object sender, EventArgs e)
        {
            path = Directory.GetCurrentDirectory() + @"/";
        }
        private void Start_b_Click(object sender, EventArgs e)
        {
            byte[] iURL = GetStringByte("http://127.0.0.1/verifier/Information.txt@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            byte[] iName = GetStringByte("Information.txt@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            byte[] fURL = GetStringByte("http://127.0.0.1/verifier/verify/@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            byte[] cName = GetStringByte("Ragnarok@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            byte[] sName = GetStringByte("Ragnarok Online@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

            byte[] iURL_New = GetStringByte(GetString(iURL_text.Text, iURL.Length));
            byte[] iName_New = GetStringByte(GetString(iName_text.Text, iName.Length));
            byte[] fURL_New = GetStringByte(GetString(fURL_text.Text, fURL.Length));
            byte[] cName_New = GetStringByte(GetString(cName_text.Text, cName.Length));
            byte[] sName_New = GetStringByte(GetString(sName_text.Text, sName.Length));

            byte[] b1 = ReplaceBytes(sfv, iURL, iURL_New);
            byte[] b2 = ReplaceBytes(b1, iName, iName_New);
            byte[] b3 = ReplaceBytes(b2, fURL, fURL_New);
            byte[] b4 = ReplaceBytes(b3, cName, cName_New);
            byte[] b5 = ReplaceBytes(b4, sName, sName_New);

            File.WriteAllBytes(path + "Sader Files Verifier.exe", b5);
            File.WriteAllBytes(path + "get_information.exe", ginfo);

            MessageBox.Show("Done!!");
            Environment.Exit(0);

        }
        private static byte[] GetStringByte(string s)
        {
            return Encoding.Unicode.GetBytes(s);
        }
        private static string GetString(string s, int i)
        {
            if (s == "")
            {
                MessageBox.Show("You Must full all the information!");
                Environment.Exit(0);
            }
            while (s.Length != i)
                s += "@";
            return s;
        }
        private static byte[] ReplaceBytes(byte[] src, byte[] OldByte, byte[] NewByte)
        {
            byte[] name = new byte[src.Length];
            for (int i = 0; i < src.Length; i++)
            {
                name[i] = src[i];
                if (OldByte[0] == src[i] && src.Length - i >= OldByte.Length)
                {
                    bool ismatch = true;
                    for (int j = 1; j < OldByte.Length && ismatch == true; j++)
                    {
                        if (src[i + j] != OldByte[j])
                            ismatch = false;
                    }
                    if (ismatch)
                    {
                        for (int j = 1; j < OldByte.Length; j++)
                        {
                            byte g = 0;
                            if (NewByte.Length > j)
                            {
                                g = NewByte[j];
                            }
                            name[i + j] = g;
                        }
                        i += OldByte.Length - 1;
                    }
                }
            }

            return name;
        }

    }
}
