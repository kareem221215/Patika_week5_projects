using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose a number");

            try
            {

                string input =  Console.ReadLine();

                int number = int.Parse(input);
                int square =  number * number;
                Console.WriteLine($"the square of the  number  is {square}");
            }
            catch (FormatException)
            {
                Console.WriteLine("wrong input please enter a number");
            }
        }
    }
}
