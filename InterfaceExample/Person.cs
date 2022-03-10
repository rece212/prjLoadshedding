using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Person : IPerson ,ISchool
    {
        private String Name = "";
        private String Surname = "";
        public string GetName()
        {
            return Name;
        }

        public String GetSchoolName()
        {
            return "VC PE";
        }

        public string GetSurname()
        {
            return Surname;
        }

        public void SetName(string strName)
        {
            Name = strName;
        }

        public void SetSurname(string strSurname)
        {
            Surname = strSurname;
        }
    }
}
