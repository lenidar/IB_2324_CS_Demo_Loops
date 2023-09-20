using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB_2324_CS_Demo_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            Console.WriteLine("While loop counting");
            // take note
            // a while loop takes a boolean statement
            // a boolean statement is any statement that yields a true or a false answer
            while(x < 100)
            {
                Console.WriteLine(x + 1);
                x++;
            }

            //Console.WriteLine("Press any key to start the endless loop");
            //Console.ReadKey();

            // this is an endless loop
            //while(true) 
            //{
            //    Console.WriteLine("hi");
            //}

            Console.WriteLine("For loop counting");
            // take note
            // the for loop requires 3 things
            // the initial state, the condition and an iteration/change to the state
            for (int a = 0; a < 100; a++)
            {
                Console.WriteLine(a + 1);
            }

            Console.ReadKey();
        }
    }
}
