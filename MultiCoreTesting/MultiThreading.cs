using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCoreTesting
{
    public class MultiThreading
    {
        public static ConsoleKeyInfo inputKey;
        public static bool buttonPress = false;

        public void RunMultiCore()
        {
            while (buttonPress == false)
            {
                Console.WriteLine("Do you want to test all of this computers CPU cores at once? (y/n)");
                inputKey = Console.ReadKey(true);

                if (inputKey.Key == ConsoleKey.Y)
                {
                    int amount = 0;
                    List<int> list = new List<int>();

                    while (amount < 10000000)
                    {
                        amount++;
                        list.Add(amount);
                    }

                    Console.WriteLine();
                    Console.WriteLine("press enter to Start");
                    Console.ReadLine();
                    DateTime startTime = DateTime.Now;

                    // Code that uses ALL cores and threads
                    Parallel.ForEach(list, number =>
                    {
                        DateTime time = DateTime.Now.AddSeconds(number);
                    });

                    TimeSpan elapsed = DateTime.Now - startTime;

                    Console.WriteLine("Calculation finished in: " + elapsed.ToString());
                    Console.WriteLine("Used " + Environment.ProcessorCount + " cores on your CPU");

                    Console.ReadLine();
                    buttonPress = true;
                }
                else if (inputKey.Key == ConsoleKey.N)
                {
                    int amount = 0;
                    List<int> list = new List<int>();

                    while (amount < 10000000)
                    {
                        amount++;
                        list.Add(amount);
                    }

                    Console.WriteLine();
                    Console.WriteLine("press enter to Start");
                    Console.ReadLine();
                    DateTime startTime = DateTime.Now;

                    // Code that uses only ONE or limited core preformance
                    foreach (int number in list)
                    {
                        DateTime time = DateTime.Now.AddSeconds(number);
                    }

                    TimeSpan elapsed = DateTime.Now - startTime;

                    Console.WriteLine("Calculation finished in: " + elapsed.ToString());

                    Console.ReadLine();
                    buttonPress = true;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
