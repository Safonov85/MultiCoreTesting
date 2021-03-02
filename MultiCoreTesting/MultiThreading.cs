using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCoreTesting
{
    public class MultiThreading
    {
        // Public Variables
        public static ConsoleKeyInfo inputKey;
        public static bool buttonPress = false;
        public static bool continueApp = true;
        
        public void RunSingleCore()
        {
            // code for running one core/thread for a task
        } 

        public void RunMultiCore()
        {
            while (continueApp == true)
            {
                // Continue Or Turn Off App
                Console.WriteLine("Do you want to start the app? (y/n)");
                inputKey = Console.ReadKey(true);
                if(inputKey.Key == ConsoleKey.Y)
                {
                    buttonPress = false;
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
                            Console.WriteLine("10 million numbers were added to list");
                            Console.WriteLine("press enter to Start");
                            Console.ReadLine();
                            DateTime startTime = DateTime.Now;

                            // Code that uses ALL cores and threads
                            Parallel.ForEach(list, number =>
                            {
                                DateTime time = DateTime.Now.AddSeconds(number);
                            });

                            TimeSpan elapsed = DateTime.Now - startTime;
                            
                            Console.Write("Calculation finished in: ");
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                            double convertToCommaSec = elapsed.TotalSeconds;
                            Console.Write(convertToCommaSec.ToString("0.00") + " seconds");
                            Console.WriteLine();
                            Console.WriteLine("Used " + Environment.ProcessorCount + " cores on your CPU");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;

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

                            Console.Write("Calculation finished in: ");
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                            double convertToCommaSec = elapsed.TotalSeconds;
                            Console.Write(convertToCommaSec.ToString("0.00") + " seconds");
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Used 1 core out of " + Environment.ProcessorCount);

                            buttonPress = true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else if(inputKey.Key == ConsoleKey.N)
                {
                    break;
                }
                else
                {
                    break;
                }
                // loop continues as long as you don't choose a calculation to preform
            }
            
        }
    }
}
