using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Рекурс.С_из_n_по_k
{
    class Program
    {
        static int Cnk(int n, int k)
        {
            if (k == 0)
            {return 1;}
            if (n == k)
            { return 1; }
            else { return (Cnk(n - 1, k - 1) + Cnk(n - 1, k)); }
        }
        static void Main(string[] args)
        {//Random m = new Random();
            int n=40;
            int k =20;
            
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            Cnk(10,5);
            sWatch.Stop();
            TimeSpan tSpan;
            tSpan = sWatch.Elapsed;
            Console.WriteLine(tSpan.ToString());
            Console.WriteLine("n=" + n + "  k=" + k + "  c=" + Cnk(n, k));

        }
    }
}
//T(n)=(3^n)