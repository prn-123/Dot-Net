using System;
using System.Collections.Generic;
using System.Linq;

namespace consoleIf
{
    class Program
    {
        static void Main(string[] args)
        {
            IfEg();
            forl();
            Ifforeach();
        }
        public static void IfEg()
        {
            string sname;
            Console.Write("Enter your name:");
            sname = Console.ReadLine();
            if (sname == "Ashwani")
            {
                Console.WriteLine("Ashwani is from Kottayam");
            }
            else if (sname == "Liju")
            {
                Console.WriteLine("Liju is from Kottayam");
            }
            else if (sname == "Bini")
            {
                Console.WriteLine("Bini is from Mallappally");
            }
            else
            {
                Console.WriteLine("I don't know");
            }
        }
        public static void forl()
        {
            for (int i=0; i<10; i++)
            {
                Console.WriteLine("Hello " +i.ToString());
            }
        }
        public static void Ifforeach()
        {
            List<string>glt = new List<string>{
                "Liju","Ashwani","Jincy","Pournami"
            };

            var v = from p in glt
            where p.EndsWith("i")
            select p;
            foreach(string i in v)
            {
                Console.WriteLine(i);
            }
        }
    }
}
