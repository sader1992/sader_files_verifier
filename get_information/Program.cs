using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace get_information
{
    class Program
    {
        private static string path = Directory.GetCurrentDirectory() + @"/";
        static void Main()
        {
            string FileListName = "Information.txt";    //file name
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("         File Checker [By sader1992]         ");
            Console.WriteLine("------------------------------------------------------\n");
            Console.WriteLine("This program will make a information.txt file that you can upload to your website");
            Console.WriteLine("you need to run this program from your game flder with only the files that you want");
            Console.WriteLine("to add to the verifier!");
            Console.WriteLine("This process will take in average 10 min depending on your CPU.");
            Console.WriteLine("If you had any problem with the program please (run as administrator).");
            Console.WriteLine("when this process is done you will see 'Process Done . . .'..\n");
            Console.WriteLine("Are you Ready (y = yes | n = no)?");

            string x = Console.ReadLine();
            string myName = System.AppDomain.CurrentDomain.FriendlyName;
            if (x != "yes" && x != "y" && x != "YES" && x != "Y")
            {
                Console.WriteLine("Canceled . . .");
                Console.WriteLine("Press any key to continue . . .");
                Console.ReadKey();
                Environment.Exit(0);
            }
            string fileResult = "";
            Console.WriteLine("Processing . . .");
            List<string> fileNames = DirSearch(path);

            foreach (string fileName in fileNames)
            {
                if (fileName != myName && fileName != FileListName)
                {
                    string hach = SHA256(path + fileName);
                    //string[] _conf = fileName.Split('/');
                    string line = fileName + ":" + hach;
                    fileResult += line + "\n";
                    Console.WriteLine(line);
                }
            }
            if (File.Exists(path + FileListName))
            {
                File.Delete(path + FileListName);
            }

            var file = File.Create(path + FileListName);
            file.Close();

            File.WriteAllText(path + FileListName, fileResult);

            Console.WriteLine("Process Done . . .");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(FileListName + " now next to the program");
            Console.WriteLine("you can rename it but don't edit it if you don't know what you are doing!!!");
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }

        //calculate the files haches
        private static string SHA256(string path)
        {
            using (SHA256 SHA256 = SHA256Managed.Create())
            {
                using (FileStream fileStream = File.OpenRead(path))
                {
                    return Convert.ToBase64String(SHA256.ComputeHash(fileStream));
                }
            }
        }

        private static List<string> DirSearch(string sDir)
        {
            List<String> files = new List<String>();
            try
            {
                foreach (string f in Directory.GetFiles(sDir))
                {
                    string j = f.Replace(path, "");
                    files.Add(j);
                }
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    files.AddRange(DirSearch(d));
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }

            return files;
        }
    }
}
