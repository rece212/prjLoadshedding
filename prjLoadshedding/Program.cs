using System;

namespace prjLoadshedding
{
    class Program
    {
        static void Main(string[] args)
        {
            Schedule sd = new Schedule(4);
            sd.LoadPresetData();
            sd.AddCity("summerstrand", "9AM", "9AM and 11AM", "9AM,11AM 8PM", "whole night");
            sd.setStage = 2; ;
            if (sd.setArea("summerstrands"))
            {
                Console.WriteLine(sd.ToString());
            }
            else
            {
                Console.WriteLine("Not found area");
            }
            
            

        }
    }
}
