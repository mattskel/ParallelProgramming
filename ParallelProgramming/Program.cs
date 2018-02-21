using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    internal static class Program
    {
        public static void Write(char c)
        {
            int i = 1000;
            while (i -- > 0)
            {
                Console.Write(c);
            }
        }

        static void Main(string[] args)
        {
            // Create a task
            Task.Factory.StartNew(() => Write('.'));    // Creating and starting at the same time
            // Another way of making a task
            //Make an instance
            var t = new Task(() => Write('?')); // We havent started yet
            // There is a difference between these implementations 
            t.Start();

            Write('-'); // On the main thread


            Console.WriteLine("Main program done.");
            Console.ReadKey();
        }
    }
}
