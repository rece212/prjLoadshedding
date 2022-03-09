using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjLoadshedding
{
    class Schedule
    {
        private static Area[] PELoad ;//array of Areas aka array of objects
        private static int iCount=-1;// keeps track of how many objects have been set
        private static int Stage = 0;// what stage of loadshedding are we at
        private static int AreaID =-1; //what area has been selected
        public int setStage { set => Stage = value; }// set property for the stage
        public Boolean setArea(String strAreaName)
        {// user to set the area 
            Boolean bFound = false;
            for (int i = 0; i < iCount+1; i++)
            {
                if (PELoad[i].getAreaName().ToLower().Equals(strAreaName.ToLower()))
                    {// search the whole array of objects and return back if it was found or not
                    AreaID = i;
                    bFound = true;
                    }
            }
            return bFound;
        }
        public String ToString()
        {// return back the loadshedding list of what has been selected 
            return PELoad[AreaID].GetLoadshedding(Stage);
        }


        public Schedule(int AreaSize)
        {
                PELoad = new Area[AreaSize];   
        }
        public void AddCity(String strName,String Stage1,
            String Stage2, String Stage3, String Stage4)
        {
            iCount++;
            PELoad[iCount] = new Area(strName, Stage1,
                Stage2, Stage3, Stage4);
        }

        public void LoadPresetData()
        {
            AddCity("St Georges", "1AM", "1AM and 9PM",
                "1AM , 6PM and 9PM", "Whole day with no power");
            AddCity("North End", "3AM", "3AM and 10PM",
                "3AM , 10PM and 11PM", "No power in the evening");
            AddCity("Greenacers", "2AM", "2AM and 12PM",
                "2AM , 2PM and 12PM", "No Loadshedding");
        }



    }
}
