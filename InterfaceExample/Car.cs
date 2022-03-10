using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Car : ICar
    {
        String strMake = "";
        String strSpeed = "";
        public string GetMake()
        {
            return strMake;
        }

        public string GetSpeed()
        {
            return strSpeed;
        }

        public void setMake(String Make)
        {
            this.strMake = Make;
        }

        public void setSpeed(int Speed)
        {
            this.strSpeed = Speed+"\kmph";
        }
    }
}
