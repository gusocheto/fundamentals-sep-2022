using System;
using System.Collections.Generic;
using System.Linq;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int max = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputParams = input.Split();
                string command = inputParams[0];
                if (command.Contains("Add"))
                {
                    int value = int.Parse(inputParams[1]);
                    numbers.Add(value);
                }
                else
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] + int.Parse(command) <= max)
                        {
                            numbers[i] = numbers[i] + int.Parse(command);
                            break;
                        }
                        else
                        {
                            continue;
                        }

                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
