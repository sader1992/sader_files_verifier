//#define PRECOMPILED //pre-compiled support
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sader_file_verifier
{
    public class Config
    {
#if !PRECOMPILED
        public readonly string INFO_TEXT_URL = "http://127.0.0.1/verifier/Information.txt"; //direct link to the information file
        public readonly string INFO_TEXT_NAME = "Information.txt";  //name of the information file
        public readonly string FILES_URL = "http://127.0.0.1/verifier/verify/"; //link to the folder of the information file
        public readonly string CLINT_EXE = "Ragnarok";  //name of the exe you use as client , the program will not run if it found the client running.

#else
        //pre-compiled support
        private static readonly string InformationURL = "http://127.0.0.1/verifier/Information.txt@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@";
        private static readonly string InformationName = "Information.txt@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@";
        private static readonly string FilesURL = "http://127.0.0.1/verifier/verify/@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@";
        private static readonly string ClientName = "Ragnarok@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@";
        private static readonly string ServerName = "Ragnarok Online@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@";

        public readonly string INFO_TEXT_URL = InformationURL.Replace("@", string.Empty);
        public readonly string INFO_TEXT_NAME = InformationName.Replace("@", string.Empty);
        public readonly string FILES_URL = FilesURL.Replace("@", string.Empty);
        public readonly string CLINT_EXE = ClientName.Replace("@", string.Empty);
        public readonly string SERVER_NAME = ServerName.Replace("@", string.Empty);
#endif
    }
}
