using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Draw_a_Filled_Square
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintHeaderRow(number);

            for (int i = 0; i < number-2; i++)
            {
                PrintMiddleRows(number);
            }
            
            PrintHeaderRow(number);
        }

        private static void PrintHeaderRow(int num)
        {
            Console.WriteLine(new string('-', 2 * num));
        }

        private static void PrintMiddleRows(int num)
        {
            Console.Write('-');
            for (int i = 1; i < num; i++)
            {
                Console.Write("\\/");
            }
            
            Console.WriteLine('-');
        }

        
    }
}
