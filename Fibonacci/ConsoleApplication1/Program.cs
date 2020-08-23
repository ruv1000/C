using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

class Program
{

    static long Fibonacci(int n)
    {
        if (n < 3)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    static void Main(string[] args)
    {
        Stopwatch sWatch = new Stopwatch();
        sWatch.Start();
        for (int i = 1; i < 50; i++)
        //Console.Write("{0}, ", Fibonacci(i));
        //Console.WriteLine("...");
        sWatch.Stop();
        TimeSpan tSpan;
        tSpan = sWatch.Elapsed;
        Console.WriteLine(tSpan.ToString());

        int m = 50; double[] fib = new double[m];  
        fib[0] = 0; fib[1] = 1; double res = fib[1];
        Stopwatch sw2 = new Stopwatch();
        sw2.Start();
        for (int f = 2; f < m; f++)
        {
            fib[f] = fib[f - 1] + fib[f - 2];
            res = res + fib[f];
        }
        sw2.Stop();
        TimeSpan tSpan1;
        tSpan1 = sw2.Elapsed;
        Console.WriteLine(tSpan1.ToString());
        Console.WriteLine(res);
    }

}