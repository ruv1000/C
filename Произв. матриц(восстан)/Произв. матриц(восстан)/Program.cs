using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace Произв.матриц_восстан_
{
    class Program
    {
       static List<uint[,]> R = new List<uint[,]>();
       static uint[,] Prom;
       static uint[,] P;
       static uint[,] B;
       static List<uint[,]> Reserv = new List<uint[,]>();
       static void Copy()
       {
           for (int i = 0; i < R.Count; i++)
               Reserv.Add(R[i]);
       }
        static void WriteFile(string s)
        {
            StreamWriter q = new StreamWriter(s);
            Random r = new Random();
            int n = r.Next(1,10); int m=r.Next(1,10);
            for (int k = 0; k < 10; k++)
            {
                n = m; m = r.Next(1,10);
                q.WriteLine("{0} {1}", n, m);
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        q.Write(r.Next(1,10)+" ");
                    }
                    q.WriteLine();
                }
                q.WriteLine();
            }
            q.Close();
        }
        static void ReadFile(string s)
        {
            string[] S; string d;
            StreamReader q = new StreamReader(s);
            while (q.EndOfStream == false)
            {
                s = q.ReadLine();
                Prom = new uint[int.Parse(s.Split(' ')[0]), int.Parse(s.Split(' ')[1])];
                for (int i = 0; i < int.Parse(s.Split(' ')[0]); i++)
                {
                    d = q.ReadLine(); S = d.Split(' ');
                    for (int j = 0; j < S.Length-1; j++)
                     Prom[i, j] = uint.Parse(S[j]);

                }
                R.Add(Prom);
                q.ReadLine();
           }            
        }
        static uint Min(int i, int d, uint[,] m, int[] r)
        {             
            uint r1 = m[i, i] + m[i + 1, d + i - 1] + (uint)(r[i - 1] * r[i] * r[d + i - 1]);
            for (int k = i; k <= d + i - 2; k++)
            {
                if (r1 > m[i, k] + m[k + 1, d + i - 1] + (uint)(r[i - 1] * r[k] * r[d + i - 1]))
                {
                    r1 = m[i, k] + m[k + 1, d + i - 1] + (uint)(r[i - 1] * r[k] * r[d + i - 1]);
                    }
            }
            return r1;
        }
        static void d_cost(uint[,] masscost, int[] r)
        {
            for (int q = 0; q < R.Count; q++)
            {
                r[q] = R[q].GetLength(1);
            }
            for (int i = 0; i < R.Count; i++)
            {
                masscost[i, i] = 0;
            }
            for (int d = 2; d <= R.Count; d++)
                for (int i = 1; i <= R.Count - 1 - d + 1; i++)
                    masscost[i, d + i - 1] = Min(i, d, masscost, r);
            Console.WriteLine("Минимальная стоимость:{0}", masscost[1, R.Count - 1]);
        }
        static void d_costWithP()
        {
            P = new uint[R.Count, R.Count];
            uint[,] masscost = new uint[R.Count, R.Count];
            int[] r = new int[R.Count];
            d_cost(masscost, r);
            uint help, s;
            for (uint d = 2; d < R.Count; d++)
                for (uint i = 1; i < R.Count - d + 1; i++)
                {
                    help = masscost[i, i] + masscost[i + 1, d + i - 1] + (uint)(r[i - 1] * r[i] * r[d + i - 1]);
                    P[i, d + i - 1] = i;
                    for (uint k = i + 1; k < d + i - 2; k++)
                    {
                        s = masscost[i, k] + masscost[k + 1, d + i - 1] + (uint)(r[i - 1] * r[k] * r[d + i - 1]);
                        if (help > s)
                        {
                            help = s;
                            P[i, d + i - 1] = k;
                        }
                    }
                }
        }
        static uint[,] product(uint[,] A, uint[,] C)
        {
            uint[,] B = new uint[A.GetLength(0), C.GetLength(1)];
            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                    for (int s = 0; s < A.GetLength(1); s++)
                        B[i, j] += A[i, s] * C[s, j];
            return B;
           
        }
        static uint[,] matrix_product(int i, int j)
        {
            Copy();
            if (i == j) return Reserv[i];
            else return product(matrix_product(i, (int)P[i, j]), matrix_product((int)P[i, j] + 1, j));
        }
        static void Vuvod(uint [,] D)
        {
            for (int i = 0; i < D.GetLength(0); i++)
            {
                for (int j = 0; j < D.GetLength(1); j++)
                    Console.Write("{0}\t",D[i,j]);
                Console.WriteLine();
            }

        }
        static void Proizv()
        {
            
            int e = 0;
            int cost = 0;
            while (R.Count != 1)
            {
                cost += R[e].GetLength(0) * R[e + 1].GetLength(1) * R[e].GetLength(1);
                B = new uint[R[e].GetLength(0), R[e + 1].GetLength(1)];
                for (int i = 0; i < B.GetLength(0); i++)
                    for (int j = 0; j < B.GetLength(1); j++)
                        for (int s = 0; s < R[e].GetLength(1); s++)
                          B[i, j] += R[e][i, s] * R[e + 1][s, j];
                R[e] = B;
                R.RemoveAt(e + 1);
                           }
            Console.WriteLine("Стоимость  не оптимального произведения {0}:",cost);
                    }
        static void Main(string[] args)
        {
            Stopwatch a = new Stopwatch();
            //WriteFile("FileOfMatrix");
            //ReadFile("FileOfMatrix");
            d_costWithP();
            Console.WriteLine("Оптимальное произведение матриц");
            a.Start();
            uint[,] Res = matrix_product(1, R.Count - 1);
            Vuvod(product(R[0], Res));
            a.Stop();
            Console.WriteLine("Время работы {0}", a.Elapsed);

            a.Start();
            Console.WriteLine("Не оптимальное произведение матриц");
            Proizv();
            a.Stop();
            Vuvod(R[0]);
            Console.WriteLine("Время работы {0}", a.Elapsed);
        }
    }
}
