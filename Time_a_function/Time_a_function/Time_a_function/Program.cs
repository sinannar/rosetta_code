using System;
using System.Linq;
using System.Threading;
using System.Diagnostics;

namespace Time_a_function
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            DoSomething();
            sw.Stop();
            Console.WriteLine("Stopwatch -> DoSomething() took {0}ms.", sw.Elapsed.TotalMilliseconds);


            DateTime start, end;
            start = DateTime.Now;
            DoSomething();
            end = DateTime.Now;
            Console.WriteLine("DateTime -> DoSomething() took " + (end - start).TotalMilliseconds + "ms");

            Console.ReadKey();
        }

        static void DoSomething()
        {
            Thread.Sleep(1000);

            Enumerable.Range(1, 10000).Where(x => x % 2 == 0).Sum();  // Sum even numers from 1 to 10000
        }
    }
}
