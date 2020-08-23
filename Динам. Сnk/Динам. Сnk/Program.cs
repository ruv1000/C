using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace Динам.Сnk
{
    class Program
    {
        static int Cnk(int n, int k, int[,] mas)
        {
            if (k == 0)
            { return 1; }
            if (n == k)
            { return 1; }
            for (int i = 0; i <=k; i++)
            {
                mas[i, i] = 1;
            }
            for (int i = 1; i <= n - k; i++)
            {
                mas[i, 0] = 1;
            }
            for (int j = 1; j <= k; j++)
            {
                for (int i = j + 1; i <=n - k + j; i++)
                { 
                mas[i,j]=mas[i-1,j-1]+mas[i-1,j];
                }

            } return mas[n, k];
        }
        static void Main(string[] args)
        {
            //Random m = new Random();
            int n=40;
            int k = 20;
            int [,] mas = new int[n+1,k+1];
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            Cnk(10, 5, mas);
            sWatch.Stop();
            TimeSpan tSpan;
            tSpan = sWatch.Elapsed;
            Console.WriteLine(tSpan.ToString());
            Console.WriteLine("n=" + n + "  k=" + k + "  c=" + Cnk(n, k,mas));
           

        }
    }
}
// T(n)=(n^3)
