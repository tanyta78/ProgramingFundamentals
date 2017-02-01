namespace _16DebuggingExerciseInstructionSet
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            string instruction = Console.ReadLine();
            ////INC <operand1> – increments the operand by 1
            ////DEC < operand1 > – decrements the operand by 1
            ////ADD < operand1 > < operand2 > – performs addition on the two operands
            ////MLA < operand1 > < operand2 > – performs multiplication on the two operands
            ////END – end of input
            while (instruction != "END")
            {
                string[] codeArgs = instruction.Split(' ');
                long result = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = operandOne + 1;
                            break;
                        }

                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = operandOne - 1;
                            break;
                        }

                    case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }

                    case "MLA":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = (long)(operandOne * operandTwo);
                            break;
                        }
                }

                instruction = Console.ReadLine();
                Console.WriteLine(result);
            }
        }
    }
}
