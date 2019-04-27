using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sader_file_verifier
{
    public class config
    {
        public readonly string INFO_TEXT_URL = "http://arenaro.ragnarok.gs/opatch/Information.txt"; //direct link to the information file
        public readonly string INFO_TEXT_NAME = "Information.txt";  //name of the information file
        public readonly string FILES_URL = "http://arenaro.ragnarok.gs/opatch/verify/"; //link to the folder of the information file
        public readonly string CLINT_EXE = "Ragnarok";  //name of the exe you use as client , the program will not run if it found the client running.
    }
}
