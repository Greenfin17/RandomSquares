using System;
using System.Collections.Generic;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> integerList = new List<int>();
            for(int i = 0; i < 20; i++)
            {
                integerList.Add(random.Next(1,50));
            }
            int index = 0;
            Console.WriteLine("Random numbers between 1 and 50 and their squares:");
            foreach(var number in integerList)
            {
                Console.Write("{0,5:D}: {1,5:D}", number, number * number);
                index++;
                if(index == 5)
                {
                    Console.Write('\n');
                    index = 0;
                } else
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("Press any key to exit");
            var key = Console.ReadKey();
        }
    }
}
