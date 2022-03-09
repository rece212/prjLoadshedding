using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjLoadshedding
{
    class Area//to rep a area eg Greenacers 
    {
        //set up our vars 
        private String strName = "";
        private String Stage1 = "";
        private String Stage2 = "";
        private String Stage3 = "";
        private String Stage4 = "";

        public Area(string strName, string stage1, string stage2, string stage3, string stage4)
        {//to set all the values
            this.strName = strName;
            Stage1 = stage1;
            Stage2 = stage2;
            Stage3 = stage3;
            Stage4 = stage4;
        }

        public string getAreaName()
        {// gets the areas name eg return St Georges
            return strName;
        }

        public Area()//Method overloading
        {

        }

        public string GetLoadshedding(int stage)
        {// gives us a string with what ever stage was selected
            switch (stage)
            {
                case 1:
                    return "For " + strName + " loadshedding is at :" + Stage1;
                case 2:
                    return "For " + strName + " loadshedding is at :" + Stage2;
                case 3:
                    return "For " + strName + " loadshedding is at :" + Stage3;
                case 4:
                    return "For " + strName + " loadshedding is at :" + Stage4;
                default:
                    return "No loadshedding for "+strName;
            }
        }
    }
}
