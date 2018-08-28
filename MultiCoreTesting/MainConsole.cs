using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCoreTesting
{
    class MainConsole
    {
        static MultiThreading multiThread = new MultiThreading();
        static void Main(string[] args)
        {
            multiThread.RunMultiCore();
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
