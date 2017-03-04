using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] fieldIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            while (!input.Equals("end"))
            {
                string[] flyInfo = input.Split(' ');
                ////read and check ladybug index 
                int ladybugIndex = int.Parse(flyInfo[0]);
                if (ladybugIndex>=fieldSize||ladybugIndex<0||fieldIndexes[ladybugIndex]==0)
                {
                    input = Console.ReadLine();
                    continue;
                }

                ////read and check ladybug direction 
                string direction = flyInfo[1];
                int flyLength = int.Parse(flyInfo[2]);
                ////right direction
                if (direction.Equals("right"))
                {
                    int positionNewRight = flyLength + ladybugIndex;
                    if (positionNewRight>=fieldSize)
                    {
                        fieldIndexes[ladybugIndex] = 0;
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {

                        while (fieldIndexes[positionNewRight] == 0)
                        {
                            if (positionNewRight>=fieldSize)
                            {
                                fieldIndexes[ladybugIndex] = 0;
                                input = Console.ReadLine();
                                continue;
                            }
                            positionNewRight++;
                        }
                        fieldIndexes[positionNewRight] = 1;
                    }
                }
                ////left direction
                else
                {
                    int positionNewLeft = ladybugIndex - flyLength;
                    if (positionNewLeft < 0)
                    {
                        fieldIndexes[ladybugIndex] = 0;
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {

                        while (fieldIndexes[positionNewLeft] == 0)
                        {
                            if (positionNewLeft <0)
                            {
                                fieldIndexes[ladybugIndex] = 0;
                                input = Console.ReadLine();
                                continue;
                            }
                            positionNewLeft--;
                        }
                        fieldIndexes[positionNewLeft] = 1;
                    }
                }
                ////read new input
                input = Console.ReadLine();
            }
            ////print result field

            Console.WriteLine(string.Join(" ", fieldIndexes));

        }
    }
}
