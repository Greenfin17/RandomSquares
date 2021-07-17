using System;
using System.Collections.Generic;

namespace RandomSquare
{
    class Program
    {
        static bool isOdd(long value)
        {
            bool returnVal = false;
            if (value % 2 != 0)
            {
                returnVal = true;
            }
            if (value == 1)
            {
                returnVal = true;
            }
            return returnVal;
        }

        static void removeOdd(ref List<int> integerList)
        {
            int testInt;
            long squareInt;
            int count = integerList.Count;
            List<int> noOdd = new List<int>();
            for(int i = 0; i < count; i++)
            {
                testInt = integerList[i];
                squareInt = (long) Math.Pow(testInt, 2);

                if (!isOdd(squareInt))
                {
                    noOdd.Add(integerList[i]);
                }
            }
            integerList = noOdd;
        }

        static void printListWithSquares (List<int> integerList)
        {
            int square;
            int index = 0;
            foreach(var number in integerList)
            {
                square = number * number;
                Console.Write("{0,5:D}: {1,5:D}", number, square);
                index++;
                if(index == 5)
                {
                    Console.Write('\n');
                    index = 0;
                }
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> integerList = new List<int>();
            List<int> noOddList = new List<int>();
            for(int i = 0; i < 20; i++)
            {
                integerList.Add(random.Next(1,50));
            }
            Console.WriteLine("Random numbers between 1 and 50 and their squares:");
            printListWithSquares(integerList);

            removeOdd(ref integerList);
            Console.WriteLine("Random numbers between 1 and 50 and their squares, if square is even:");
            printListWithSquares(integerList);
            Console.WriteLine("\nPress any key to exit");
            var key = Console.ReadKey();
        }
    }
}
