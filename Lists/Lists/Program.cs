using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List <string> names = new List<string> { "Alice", "Bob", "Charlie", "Diana", "Edward", "Fiona", "George", "Hannah", "Irene", "Jack" };

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(i+1+"-"+names[i]);
            }
        }
    }
}
