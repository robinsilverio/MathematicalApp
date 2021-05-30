using System;

namespace MathematicalApp
{

    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Which math operator do you want to choose?");
            string inputOperator = Console.ReadLine().ToLower();

            Console.WriteLine("How many numbers do you want to use for this operation?");
            decimal[] numbersArray = new decimal[Convert.ToInt32(value: Console.ReadLine())];
            numbersArray = ObtainNumbersInput(numbersArray);

            switch (inputOperator)
            {
                case "add":
                    Console.WriteLine("\n" + Sum(numbersArray));
                    break;
                case "subtract":
                    Console.WriteLine("\n" + Subtract(numbersArray));
                    break;
                case "multiplication":
                    Console.WriteLine("\n" + Multiplicate(numbersArray));
                    break;
                default:
                    break;
            }
        }

        static decimal Sum(decimal[] paramDoubleArray)
        {
            decimal total = 0;

            foreach (var number in paramDoubleArray)
            {
                total += number;
            }

            return total;
        }

        static decimal Subtract(decimal[] paramDoubleArray)
        {
            decimal total = paramDoubleArray[0];

            for (int i = 1; i < paramDoubleArray.Length; i++)
            {
                total -= paramDoubleArray[i];
            }

            return total;
        }

        static decimal Multiplicate(decimal[] numbersArray)
        {
            decimal total = 0;

            foreach (var number in numbersArray)
            {
                total *= number;
            }

            return total;
        }

        private static decimal[] ObtainNumbersInput(decimal[] numbersArray)
        {
            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.WriteLine("Add input " + (i + 1));
                numbersArray[i] = Convert.ToDecimal(Console.ReadLine());
            }

            return numbersArray;
        }
    }
}
