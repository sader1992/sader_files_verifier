using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace get_information
{
    class Program
    {
        static void Main(string[] args)
        {
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
            string path = Directory.GetCurrentDirectory() + @"/";
            var fileNames = Directory.GetFiles(path).Select(Path.GetFileName);
            foreach (string fileName in fileNames)
            {
                if(fileName != myName && fileName != "Information.txt")
                {
                    string[] _conf = fileName.Split('/');
                    fileResult += fileName + ":";
                    string hach = _SHA256(path + fileName);
                    fileResult += hach + "\n";
                }
            }
            if (File.Exists(path + "Information.txt"))
                File.Delete(path + "Information.txt");

            var file = File.Create(path + "Information.txt");
            file.Close();

            File.WriteAllText(path + "Information.txt", fileResult);

            Console.WriteLine("Process Done . . .");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Information.txt now next to the program");
            Console.WriteLine("you can rename it but don't edit it if you don't know what you are doing!!!");
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
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
    }
}
