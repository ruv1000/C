using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ААС
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sWatch = new Stopwatch();
            Stopwatch sWatch1 = new Stopwatch();
            long s1 = 0;
            int i = 1;
            long s2;
            long s3=0;
            int j = 1;
            long [] s= new long [10000]; 

            sWatch1.Start();
            s2 = 10000 * 10001 / 2;
            sWatch1.Stop();
            TimeSpan tSpan1;
            tSpan1 = sWatch1.Elapsed;
            Console.WriteLine(tSpan1.ToString());
            sWatch.Start();
            {
                while (i <= 10000)
                {
                    s1 = s1 + i;
                    i++;
                }
            }
            sWatch.Stop();
            while (j <= 10000)
            {
                s3 = s3 + j;
                s[j-1] = s3;
                j++;

            }
            ////////////////////////
            TimeSpan tSpan;
            tSpan = sWatch.Elapsed;
            Console.WriteLine(tSpan.ToString());
            ////////////////////////
           
            //  Console.WriteLine(sWatch1.ElapsedMilliseconds.ToString());
       
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
