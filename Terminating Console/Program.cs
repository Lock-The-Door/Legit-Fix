using System;
using System.Threading;

namespace Terminating_Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
                Random random = new Random();
                Thread.Sleep(random.Next(100, 2000));
            }
            Console.Clear();
            return;
        }
    }
}
