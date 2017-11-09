namespace DataTypesVariablesHomework
{
    using System;
    using System.Numerics;

    public class StartUp
    {
       public static void Main(string[] args)
        {
            P01_PracticeIntegers();
            P02_PracticeFloatingPoint();
            P03_PracticeChar();
            P04_PracticeHex();
            P05_Boolean();
            P06_StrAndObj();
            P07_ExchangeVariableValues();
            P08_EmployeeData();
            P09_ReversedChars();
            P10_CenturiesToNanoseconds();
            P11_ConvertSpeedUnits();
            P12_RectangleProperties();
            P13_VowelOrDigit();
            P14_IntegerToHexAndBinary();
            P15_FastPrimeChecker();
            P16_ComparingFloats();
            P17_PrintPartOfASCIITable();
            P18_DifferentIntegersSize();
            P19_TheaThePhotographer();
        }

        private static void P19_TheaThePhotographer()
        {
            int picturesCount = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            double percentage = filterFactor / 100.0;
            int usefulPictures = (int)Math.Ceiling(picturesCount * percentage);

            long totalPictures = picturesCount * (long)filterTime;
            long uploadedPictures = usefulPictures * (long)uploadTime;

            Console.WriteLine(
                TimeSpan.FromSeconds(totalPictures + uploadedPictures)
                    .ToString(new string('d', 1) + @"\:hh\:mm\:ss"));
        }

        private static void P18_DifferentIntegersSize()
        {
            // sbyte < byte < short < ushort < int < uint < long
            bool canFit = false;
            string numStr = Console.ReadLine();
            string message = "";

            try
            {
                sbyte sbyteNum = sbyte.Parse(numStr);
                message += "* sbyte\n";
                canFit = true;
            }
            catch (Exception)
            {
            }

            try
            {
                byte byteNum = byte.Parse(numStr);
                message += "* byte\n";
                canFit = true;
            }
            catch (Exception)
            {
            }

            try
            {
                short shortNum = short.Parse(numStr);
                message += "* short\n";
                canFit = true;
            }
            catch (Exception)
            {
            }

            try
            {
                ushort ushortNum = ushort.Parse(numStr);
                message += "* ushort\n";
                canFit = true;
            }
            catch (Exception)
            {
            }

            try
            {
                int intNum = int.Parse(numStr);
                message += "* int\n";
                canFit = true;
            }
            catch (Exception)
            {
            }

            try
            {
                uint uintNum = uint.Parse(numStr);
                message += "* uint\n";
                canFit = true;
            }
            catch (Exception)
            {
            }

            try
            {
                long longNum = long.Parse(numStr);
                message += "* long\n";
                canFit = true;
            }
            catch (Exception)
            {
            }

            if (canFit)
            {
                Console.WriteLine("{0} can fit in:", numStr);
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", numStr);
            }
        }

        private static void P17_PrintPartOfASCIITable()
        {
            int startnumber = int.Parse(Console.ReadLine());
            int endnumber = int.Parse(Console.ReadLine());
            char symbol = Convert.ToChar(startnumber);
            for (int i = startnumber; i <= endnumber; i++)
            {
                symbol = Convert.ToChar(i);
                Console.Write(symbol);
                Console.Write(' ');
            }
        }

        private static void P16_ComparingFloats()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            Console.WriteLine(Math.Abs(a - b) <= eps);
        }

        private static void P15_FastPrimeChecker()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool isPrime = true;
                for (int checker = 2; checker <= Math.Sqrt(i); checker++)
                {
                    if (i % checker == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }
        }

        private static void P14_IntegerToHexAndBinary()
        {
            int number = int.Parse(Console.ReadLine());
            string Hex = Convert.ToString(number, 16).ToUpper();
            string Binary = Convert.ToString(number, 2);
            Console.WriteLine(Hex);
            Console.WriteLine(Binary);
        }

        private static void P13_VowelOrDigit()
        {
            //  A, E, I, O, U, and sometimes Y
            char symbol = char.Parse(Console.ReadLine());
            if (symbol <= '9' && symbol >= '0')
            {
                Console.WriteLine("digit");
            }
            else if (symbol == 'a' || symbol == 'A' || symbol == 'e' || symbol == 'E' || symbol == 'i' || symbol == 'I' || symbol == 'o' || symbol == 'O' || symbol == 'U' || symbol == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }

        private static void P12_RectangleProperties()
        {
            // Create a program to calculate rectangle’s perimeter, area and diagonal by given its width and height.


            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            double perimeter = 2 * (width + height);
            double diagonal = Math.Sqrt(width * width + height * height);

            Console.WriteLine($"{perimeter}");
            Console.WriteLine($"{area}");
            Console.WriteLine($"{diagonal}");
        }

        private static void P11_ConvertSpeedUnits()
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            float timeInSecond = hours * 60 * 60 + minutes * 60 + seconds;
            float speed = (distanceInMeters / timeInSecond);
            float speedKmH = (distanceInMeters / 1000) / (timeInSecond / 3600);
            float speedMH = (distanceInMeters / 1609) / (timeInSecond / 3600);

            Console.WriteLine($"{speed}");
            Console.WriteLine($"{speedKmH}");
            Console.WriteLine($"{speedMH}");
        }

        private static void P10_CenturiesToNanoseconds()
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            int minutes = hours * 60;
            ulong seconds = (ulong)minutes * 60;
            ulong milliseconds = seconds * 1000;
            ulong microseconds = milliseconds * 1000;
            BigInteger nanoseconds = (BigInteger)microseconds * 1000;


            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }

        private static void P09_ReversedChars()
        {

            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char ch3 = char.Parse(Console.ReadLine());

            Console.WriteLine($"{ch3}{ch2}{ch1}");
        }

        private static void P08_EmployeeData()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalID = long.Parse(Console.ReadLine());
            int uniqueEmplNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"First name: {firstName}\nLast name: {lastName}\nAge: {age}\nGender: {gender}\nPersonal ID: {personalID}\nUnique Employee number: {uniqueEmplNumber}");
        }

        private static void P07_ExchangeVariableValues()
        {
            int a = 5;
            int b = 10;
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Before:\na = {b}\nb = {a}");
            Console.WriteLine($"After:\na = {a}\nb = {b}");
        }

        private static void P06_StrAndObj()
        {
            string one = "Hello";
            string two = "World";
            object concat = one + " " + two;
            string three = (string)concat;


            Console.WriteLine(three);
        }

        private static void P05_Boolean()
        {
            string isTrue = Console.ReadLine();
            if (Convert.ToBoolean(isTrue))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static void P04_PracticeHex()
        {
            string Hexi = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(Hexi, 16));
        }

        private static void P03_PracticeChar()
        {
            string one = "Software University";
            char two = 'B';
            char tree = 'y';
            char four = 'e';
            string five = "I love programming";

            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.WriteLine(tree);
            Console.WriteLine(four);
            Console.WriteLine(five);
        }

        private static void P02_PracticeFloatingPoint()
        {
            decimal num1 = 3.141592653589793238m;
            double num2 = 1.60217657;
            decimal num3 = 7.8184261974584555216535342341m;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }

        private static void P01_PracticeIntegers()
        {
            // Create a new C# project and create a program that assigns integer values to variables.
            //Be sure that each value is stored in the correct variable type (try to find the most suitable variable type in order to save memory).
            //      Finally, you need to print all variables to the console.
            sbyte num1 = -100;
            byte num2 = 128;
            short num3 = -3540;
            ushort num4 = 64876;
            uint num5 = 2147483648;
            int num6 = -1141583228;
            long num7 = -1223372036854775808;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
            Console.WriteLine(num6);
            Console.WriteLine(num7);
        }

    }
}
