using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCoreTesting
{
    class MainConsole
    {
        static ConsoleKeyInfo inputKey;
        static bool buttonPress = false;
        static void Main(string[] args)
        {
            while(buttonPress == false)
            {
                Console.WriteLine("Do you want to test all of this computers CPU cores at once? (y/n)");
                inputKey = Console.ReadKey(true);

                if (inputKey.Key == ConsoleKey.Y)
                {
                    Console.WriteLine("you pressed Yes");
                    buttonPress = true;
                }
                else if (inputKey.Key == ConsoleKey.N)
                {
                    Console.WriteLine("you pressed No");
                    buttonPress = true;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
