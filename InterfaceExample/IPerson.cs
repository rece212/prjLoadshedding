using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface IPerson
    {
        String GetName();

        String GetSurname();

        void SetName(String strName);

        void SetSurname(String strSurname);
    }
}
