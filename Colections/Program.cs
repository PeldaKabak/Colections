using System.Collections.Generic;

namespace Colections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Ayşenur", "Hilal", "Asya", "Tuğçe" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //names = new string[5];
            //names[4]= "Melis";
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[2]);


            List<string> names2 = new List<string> { "Ayşenur", "Hilal", "Asya", "Tuğçe" };
            System.Console.WriteLine(names2[0]);
            System.Console.WriteLine(names2[1]);
            System.Console.WriteLine(names2[2]);
            System.Console.WriteLine(names2[3]);

            names2.Add("Melis");

            System.Console.WriteLine(names2[4]);
            System.Console.WriteLine(names2[1]);





        }
    }
}
