using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperator
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            List<List<int>> numberMatrix = new List<List<int>>();
            for (int i = 0; i < rows; i++)
            {
                List<int> numRow = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                numberMatrix.Add(numRow);
            }
            string comandLine = Console.ReadLine();
            while (!comandLine.Equals("end"))
            {
                string[] comand = comandLine.Split().ToArray();
                switch (comand[0])
                {
                    case "remove":
                        numberMatrix = RemoveElRows(comand, numberMatrix);
                        break;
                    case "swap":
                        numberMatrix = SwapRows(comand, numberMatrix);
                        break;
                    case "insert":
                        numberMatrix = InsertNumberRow(comand, numberMatrix);
                        break;
                }
                comandLine = Console.ReadLine();
            }

            foreach (var item in numberMatrix)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }

        private static List<List<int>> InsertNumberRow(string[] comand, List<List<int>> numberMatrix)
        {
            //The insert command – row and number that you need to insert at the beginning of the given row.
            int row = int.Parse(comand[1]);
            int number = int.Parse(comand[2]);
            numberMatrix[row].Insert(0, number);
            return numberMatrix;

        }

        private static List<List<int>> SwapRows(string[] comand, List<List<int>> numberMatrix)
        {
            //The swap command – the 2 rows that you need to swap.
            int firstRow = int.Parse(comand[1]);
            int secondRow = int.Parse(comand[2]);
            List<int> newRow = numberMatrix[firstRow];
            numberMatrix[firstRow] = numberMatrix[secondRow];
            numberMatrix[secondRow] = newRow;
            return numberMatrix;
        }

        private static List<List<int>> RemoveElRows(string[] comand, List<List<int>> numberMatrix)
        {
            //                The remove command – type and position.
            //                The type can be one of the following – positive / negative / odd / even.That means that you will need to remove said elements from the given row / col.
            //               The position will be in the following format: { row / col index}.

            string type = comand[1];
            string colOrRow = comand[2];
            int index = int.Parse(comand[3]);
            switch (colOrRow)
            {
                case "row":
                    numberMatrix = ChangeRow(numberMatrix, type, index);
                    break;
                case "col":
                    numberMatrix = ChangeCol(numberMatrix, type, index);
                    break;
            }
            return numberMatrix;
        }

        private static List<List<int>> ChangeCol(List<List<int>> numberMatrix, string type, int index)
        {
            if (numberMatrix.Any(x => x.Count > index))
            {
                foreach (var item in numberMatrix.Where(x => x.Count > index))
                {
                    switch (type)
                    {
                        case "positive":
                            if (item[index] >= 0)
                            {
                                item.RemoveAt(index);
                            }
                            break;
                        case "negative":
                            if (item[index] < 0)
                            {
                                item.RemoveAt(index);
                            }
                            break;
                        case "odd":
                            if (Math.Abs(item[index]) % 2 == 1)
                            {
                                item.RemoveAt(index);
                            }
                            break;
                        case "even":
                            if (Math.Abs(item[index]) % 2 == 0)
                            {
                                item.RemoveAt(index);
                            }

                            break;
                    }
                }
            }
            return numberMatrix;
        }

        private static List<List<int>> ChangeRow(List<List<int>> numberMatrix, string type, int index)
        {

            switch (type)
            {
                case "positive":
                    if (numberMatrix[index].Any(x => x >= 0))
                    {
                        numberMatrix[index] = numberMatrix[index].Where(x => x < 0).ToList();
                    }
                    break;
                case "negative":
                    if (numberMatrix[index].Any(x => x < 0))
                    {
                        numberMatrix[index] = numberMatrix[index].Where(x => x >= 0).ToList();
                    }
                    break;
                case "odd":
                    if (numberMatrix[index].Any(x =>Math.Abs(x) % 2 == 1))
                    {
                        numberMatrix[index] = numberMatrix[index].Where(x => Math.Abs(x) % 2 == 0).ToList();
                    }
                    break;
                case "even":
                    if (numberMatrix[index].Any(x => Math.Abs(x) % 2 == 0))
                    {
                        numberMatrix[index] = numberMatrix[index].Where(x => Math.Abs(x) % 2 == 1).ToList();
                    }
                    break;

            }
            return numberMatrix;
        }
    }
}
