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

        public static void Write(object o)
        {
            int i = 1000;
            while (i-- > 0)
            {
                Console.Write(o);
            }
        }

        public static int TextLength(object o)
        {
            Console.WriteLine($"\nTask with id {Task.CurrentId} processing object {o}...");
            return o.ToString().Length;
        }

        static void Main(string[] args)
        {
            Task t = new Task(Write, "hello");
            t.Start();
            Task.Factory.StartNew(Write, 123);

            Console.WriteLine("Main program done.");
            Console.ReadKey();
        }
    }
}
