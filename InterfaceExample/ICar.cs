using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface ICar
    {
        public String GetMake();
        public void setMake(String Make);
        public String GetSpeed();
        public void setSpeed();
    }
}
