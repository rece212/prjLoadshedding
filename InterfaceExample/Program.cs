using System;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.SetName("Jack");
            p.SetSurname("Smith");
            Console.WriteLine(p.GetName()+" "+p.GetSurname());

            File f = new File();
            f.ReadFile();
            f.Writefile(" new text added");
            Console.WriteLine(f.ViewLoadedData());
        }
    }
}
