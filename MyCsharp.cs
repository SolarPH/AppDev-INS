using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Survey before the MathApp launches please confirm if you are a human. ");
            Console.Write("Ikaw bagay puge o maganda? ");
            string sagot = Console.ReadLine();

            if (sagot == "puge"){
                diffMethods();
            }
            else
            {
                Console.WriteLine("Nakupo puge lang ang pepede dine!");
            }
            

            Console.ReadKey(true);
        }

        static void diffMethods()
        {
            Console.WriteLine(Math.Round(71.4));
            Console.WriteLine(Math.Abs(-3.9));
            Console.WriteLine(Math.Sqrt(46));
            Console.WriteLine(Math.Floor(789.456));
            Console.WriteLine(Math.Exp(123));
        }
    }
}
