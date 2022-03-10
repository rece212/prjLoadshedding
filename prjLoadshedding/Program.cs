using System;

namespace prjLoadshedding
{
    class Program
    {
        static void Main(string[] args)
        {
            Schedule sd = new Schedule(20);
            sd.LoadPresetData();
            sd.setStage = 0;
            Boolean bLoop = true;
            while(bLoop)
            {
                
                Console.WriteLine("Welcome to Loadshedding Center");
                Console.WriteLine("Main menu : Enter 1 to view Schedule");
                Console.WriteLine("Main menu : Enter 2 to Add to the Schedule");
                Console.WriteLine("Main menu : Enter 3 to change the stage Schedule");
                Console.WriteLine("Main menu : Enter 0 or any other key to quit");

                int Menu = Convert.ToInt32(Console.ReadLine());


                if (Menu == 1)//view your schedule
                {
                    Console.Write("Please enter your area: ");
                    String strAreainput = Console.ReadLine();
                    Console.Clear();
                    if (sd.setArea(strAreainput))
                    {
                        Console.WriteLine(sd.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Not found area");
                    }

                }
                else if (Menu == 2)// Add to schedule 
                {
                    Console.Write("Please enter the area Name :");
                    String strArea = Console.ReadLine();
                    Console.Write("Please enter stage 1:");
                    String strStage1 = Console.ReadLine();
                    Console.Write("Please enter stage 2:");
                    String strStage2 = Console.ReadLine();
                    Console.Write("Please enter stage 3 :");
                    String strStage3 = Console.ReadLine();
                    Console.Write("Please enter stage 4 :");
                    String strStage4 = Console.ReadLine();

                    sd.AddCity(strArea, strStage1, strStage2, strStage3, strStage4);

                }
                else if (Menu == 3)//change the stage
                {
                    Console.Write("Please enter from 0 to 4 , what stage of loadshedding it is: ");
                    sd.setStage = Convert.ToInt32(Console.ReadLine());
                }
                else // wrong input selected
                {
                    Console.WriteLine("Shutting down now");
                    bLoop = false;
                }
            }
            
        }
    }
}
