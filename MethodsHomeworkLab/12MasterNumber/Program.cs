using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //            A master number is an integer that holds the following properties:
            //•	Is symmetric (palindrome), e.g. 5, 77, 282, 14341, 9553559.
            //•	Its sum of digits is divisible by 7, e.g. 77, 313, 464, 5225, 37173.
            //•	Holds at least one even digit, e.g. 232, 707, 6886, 87578.
            //Write a program to print all master numbers in the range[1…n].


            int number = int.Parse(Console.ReadLine());
            for (int i = 10; i <= number; i++)
            {
               if(IsPalindrome(i) && IsSumDivSeven(i) && HasEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }

        }

        private static bool HasEvenDigit(int num)
        {
            bool EvenDigit = false;
            while (num>0)
            {
                int digit = num % 10;
                if (digit%2==0)
                {
                    EvenDigit = true;
                    break;
                }
                num = num / 10;
            }
            return EvenDigit;
        }
        

        private static bool IsSumDivSeven(int num)
        {
            bool IsSumDivSeven = false;
            int sum = 0;
            while (num > 0)
            {
               sum += num % 10;
               num = num / 10;
            }
            if (sum%7==0)
            {
                IsSumDivSeven = true;
            }
            return IsSumDivSeven;
        }

        private static bool IsPalindrome(int num)
        {
            string DigitsNumber = num.ToString();
            return DigitsNumber.SequenceEqual(DigitsNumber.Reverse());
            

        }

    }
}
