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

        static decimal Sum(decimal[] paramNumbersArray)
        {
            decimal total = 0;

            foreach (var number in paramNumbersArray)
            {
                total += number;
            }

            return total;
        }

        static decimal Subtract(decimal[] paramNumbersArray)
        {
            decimal total = paramNumbersArray[0];

            for (int i = 1; i < paramNumbersArray.Length; i++)
            {
                total -= paramNumbersArray[i];
            }

            return total;
        }

        static decimal Multiplicate(decimal[] paramNumbersArray)
        {
            decimal total = paramNumbersArray[0];

            foreach (var number in paramNumbersArray)
            {
                total *= number;
            }

            return total;
        }

        private static decimal[] ObtainNumbersInput(decimal[] paramNumbersArray)
        {
            for (int i = 0; i < paramNumbersArray.Length; i++)
            {
                Console.WriteLine("Add input " + (i + 1));
                paramNumbersArray[i] = Convert.ToDecimal(Console.ReadLine());
            }

            return paramNumbersArray;
        }
    }
}
