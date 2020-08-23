using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace рюкзак_выполнимость
{
    class Program
    {
        static bool Rec_knapsack(int S, int n,bool[]x,int[]s)
        {
            if ((S < 0) || ((S > 0) && (n == 0))) return false;
            else if (S == 0) return true;
            else if (S > 0)
            {
                bool B;
                B = Rec_knapsack(S - s[n-1], n - 1,x,s);
                if (B == true)
                {
                    x[n-1] = true;
                    return B;
                }
                else
                {
                    x[n-1] = false;
                    return Rec_knapsack(S,n-1,x,s);
                }
            }
            return (Rec_knapsack(S,n-1,x,s)||Rec_knapsack(S-s[n],n-1,x,s));
        }
        static bool Din_knapsack(bool[,]V,int S,int[]s)
    {
        V[0, 0] = true;
        for (int i = 1; i < S; i++)
            V[i, 0] = false;
            for (int j=1;j<s.Length;j++)
                for (int i = 0; i <= S; i++)
                { 
                    V[i,j]=V[i,j-1];
                    if (i - s[j] >= 0) { V[i, j] = V[i, j] ||  V[i - s[j], j - 1]; }
                    
                }
            return V[S, s.Length];
    }
        static void Main(string[] args)
        {
            //TimeSpan rec_knap_time = new TimeSpan();
            //TimeSpan din_knap_time = new TimeSpan();
            System.TimeSpan T = new System.TimeSpan();
            System.Diagnostics.Stopwatch t = new System.Diagnostics.Stopwatch();

            int[]s=new int[10];
            Random r = new Random();
            for (int i = 0; i < s.Length; i++)
                s[i] = r.Next(1);
            int S = r.Next(1);
           
            bool[] x=new bool[s.Length];
            int n = s.Length;
            t.Start();
            bool l = Rec_knapsack(S, n, x, s);
            t.Stop();
            T = t.Elapsed;
            Console.WriteLine("рекурсивный рюкзак:  " + l + "  time:  " + T);
            bool[,] V=new bool[S+1,n+1];
            t.Start();
            bool a = Din_knapsack(V, S,s);
            t.Stop();
            T = t.Elapsed;
            Console.WriteLine("динамический рюкзак: " + a+"  time:  "+T);
        } 
    }
}
