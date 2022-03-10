using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class File : IFile
    {
        String strFile = "";
        public void ReadFile()
        {
            strFile = "I am a text file";
            Console.WriteLine("Reading the file");
        }

        public void Writefile(string text)
        {
            strFile += text;
        }

        public String ViewLoadedData()
        {
            return strFile;
        }
    }
}
