using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[10];
           
            int[] array2 = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"choose number {i+1}");
                array[i] = Convert.ToInt32(Console.ReadLine());
                
               
            }

            Console.WriteLine("numbers you chose:");

            foreach (int x in array)
            {
                Console.WriteLine(x);
            }

            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }

            Array.Copy(array , array2, 0);

            Console.WriteLine("enter the elevnth value");
            array2[array2.Length - 1] = Convert.ToInt32(Console.ReadLine());

            Array.Sort(array2);
            Array.Reverse(array2);
            Console.WriteLine("ordered numbers are:");
            Console.WriteLine("====================================================");

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"{array2[i]}");
                
            }


        }
    }
}
