using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _01_Calculator;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            input1();
        }
        public static void input1()
        {
            bool tal1 = false;
            int i1 = 0;
            while (tal1 == false)
                {
                Console.WriteLine("Skriv et tal");
                string input1 = Console.ReadLine();
                bool parsed = Int32.TryParse(input1, out i1);

                if (!parsed)
                    Console.WriteLine(input1 + " er ikke et tal, prøv igen.");
                else
                    tal1 = true;

                }
            
            Console.WriteLine(i1);
        }
        public static void regnemetode ()
        {

        }
    }

}
