using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello World using Console.WriteLine()statement
            Console.WriteLine("Hello World from Marilyn Green");
           
            //declaring 2 strings w/o initializing
            string greeting = "Hello World from ";
            string name = "Marilyn Green";
           
            //Output using a single Console.WriteLine()statement and the variables
            Console.WriteLine(greeting + name);
            Console.ReadKey();

        }
    }
}
