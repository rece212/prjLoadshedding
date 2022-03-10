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
                Console.Clear();
                Console.Clear();
                Console.WriteLine("Welcome to Loadshedding Center");
                Console.WriteLine("Main menu : Enter 1 to view Schedule");
                Console.WriteLine("Main menu : Enter 2 to Add to the Schedule");
                Console.WriteLine("Main menu : Enter 3 to change the stage Schedule");
                Console.WriteLine("Main menu : Enter 0 or any other key to quit");

                int Menu = -1;
                try
                {
                     Menu = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception)
                {
                    Menu = -1;
                }
                


                if (Menu == 1)//view your schedule
                {
                    Console.Write("Please enter your area: ");
                    String strAreainput = Console.ReadLine();
                    
                    if (sd.setArea(strAreainput))
                    {
                        Console.WriteLine(sd.ToString());
                        System.Threading.Thread.Sleep(5000);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not found area");
                        Console.ResetColor();
                        System.Threading.Thread.Sleep(1000);
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
                    try
                    {
                        sd.setStage = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter in a valid number and try again");
                        Console.ResetColor();
                        System.Threading.Thread.Sleep(1000);
                    }
                    catch(Exception)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("You entered something the program did not like, try again");
                        Console.ResetColor();
                        System.Threading.Thread.Sleep(1000);
                    }


                }
                else // wrong input selected
                {
                    Console.WriteLine("Shutting down now");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Shutting 3");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Shutting 2");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Shutting 1");
                    bLoop = false;
                }
            }
            
        }
    }
}
