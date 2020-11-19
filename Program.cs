using System;
using System.Collections.Generic;

namespace ProgramB
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());

            for (int i = 0; i < cases; i++)
            {
                int candidates = int.Parse(Console.ReadLine());
                int total = 0;
                int index = 0;
                int max = 0;
                int winner = 0;
                List<int> numbers = new List<int>();

                for (int x = 0; x < candidates; x++)
                {
                    int vote = int.Parse(Console.ReadLine());
                    numbers.Add(vote);
                    total += vote;
                }

                for (int x = 0; x < candidates; x++)
                {
                    max = Math.Max(max,
                                   numbers[x]);
                }

                for (int x = 0; x < candidates; x++)
                    if (numbers[x] == max)
                    {
                        index = x;
                        winner++;
                    }
                if (winner > 1)
                {
                    Console.WriteLine("no winner");
                }
                else
                {


                    if (max > (total / 2))
                    {
                        Console.WriteLine("majority winner {0}", (index + 1));
                    }
                    else
                    {
                        Console.WriteLine("minority winner {0}", (index + 1));
                    }
                }
            }
        }
    }
}
