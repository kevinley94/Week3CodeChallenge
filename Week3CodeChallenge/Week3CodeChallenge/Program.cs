using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            FindNPrime(100);
            EvenFibonacciSequencer(13);
            LongestCollatzSequence(1000000);
            Console.ReadKey();
        }



        static void LongestCollatzSequence(int NumberToCollatz)
        {
            int Count = 0;
            int NumberbeingCollatz = NumberToCollatz;
            while (NumberbeingCollatz != 1)
            {
                if (NumberbeingCollatz % 2 == 0 && NumberbeingCollatz != 0)
                {
                    NumberbeingCollatz = NumberbeingCollatz / 2;
                    Count++;

                }
                else
                    NumberbeingCollatz = (3 * NumberbeingCollatz) + 1;
                Count++;
            }
            Console.WriteLine("Number of time it took to Break down {0} was {1} times!", NumberToCollatz, Count);
        }





        static void EvenFibonacciSequencer(int maxValue)
        {
            //Fibonacci Squence 

            int firstNumber = 1;
            int lastNumber = 2;
            int totalOfEvenNumbers = 0;
            int sum = firstNumber + lastNumber;
            lastNumber = (sum - firstNumber);
            firstNumber = sum;
            while (sum < maxValue)
            {
                sum = firstNumber + lastNumber;
                lastNumber = (sum - lastNumber);
                firstNumber = sum;
                if (sum % 2 == 0)
                {
                    totalOfEvenNumbers++;

                }
            }
            Console.WriteLine("Total Number Of Even Fiboacci from 0-{0} is {1})", maxValue, totalOfEvenNumbers);
        }




        static void FindNPrime(int NumberOfWantedPrimeNumbers)
        {
            List<int> primeNumbersFound = new List<int>(0);
            int Counter = 0;

            ;
            for (int i = 0; Counter != NumberOfWantedPrimeNumbers; i++)
            {
                int NumberToCheckWith = GrabsPrimeNumberOrZero(i);
                if (NumberToCheckWith != 0)
                {
                    primeNumbersFound.Add(NumberToCheckWith);
                    Counter++;
                }

            }
            Console.WriteLine("Highest Prime Found Was: " + primeNumbersFound[Counter - 1]);

        }
        static int GrabsPrimeNumberOrZero(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return 0;
                }
            }
            if (i == number)
            {
                return number;
            }
            return 0;

        }
    }
}
