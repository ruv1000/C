using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Diagnostics;

class Program
{
    static long Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }
    static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < 20; i++)
            Console.WriteLine("{0}! = {1}", i, Factorial(i));
        sw.Stop();
        TimeSpan tSpan;
        tSpan = sw.Elapsed;
        Console.WriteLine(tSpan.ToString());
    }
}