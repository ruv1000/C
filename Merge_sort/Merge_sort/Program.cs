using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Merge_sort
{
    class Program
    {
        static int[] Merge_Sort(int[] massiv)
        {
            if (massiv.Length == 1)
                return massiv;
            int mid_point = massiv.Length / 2;
            return Merge(
                Merge_Sort(massiv.Take(mid_point).ToArray()),
                Merge_Sort(massiv.Skip(mid_point).ToArray())
                );
        }
        static int[] Merge(int[] mass1, int[] mass2)
        {
            int a = 0, b = 0;
            int[] merged = new int[mass1.Length + mass2.Length];
            for (int i = 0; i < mass1.Length + mass2.Length; i++)
            {
                if (b < mass2.Length && a < mass1.Length)
                    if (mass1[a] < mass2[b] && b < mass2.Length)
                        merged[i] = mass2[b++];
                    else
                        merged[i] = mass1[a++];
                else
                    if (b < mass2.Length)
                        merged[i] = mass2[b++];
                    else
                        merged[i] = mass1[a++];
            }
            return merged;
        }
        static void Main(string[] args)
        {
            int[] massiv = new int[100];
            int low = 0, high = 99;
            Stopwatch sWatch = new Stopwatch(); Stopwatch sWatch1 = new Stopwatch(); Stopwatch sWatch2 = new Stopwatch();
            Random rand = new Random();
            TimeSpan tSpan;
            Console.WriteLine("\t\t\tМассив до сортировки");
            for (int j = 0; j < massiv.Length; j++)
            {
                for (int i = 0; i < massiv.Length; i++)
                {
                    massiv[i] = rand.Next(1000);
                    Console.Write(massiv[i] + " ");
                }
                sWatch.Start();
                Merge_Sort(massiv);
                sWatch.Stop();
            }
            tSpan = sWatch.Elapsed;
            Console.WriteLine();
            Console.WriteLine("\t\t\tМассив после сортировки");
            Console.WriteLine(tSpan.ToString());
            Console.WriteLine("\t\t\tМассив после повторной сортировки");
            sWatch1.Start();
            Merge_Sort(massiv);
            sWatch1.Stop();
            TimeSpan tSpan1; tSpan1 = sWatch1.Elapsed;
            Console.WriteLine(tSpan1.ToString());
            int[] mas = new int[100];
            for (int j = massiv.Length - 1; j > 0; j--)
            {
                mas[j] = massiv[j];
            }
            Console.WriteLine("\t\t\t Массив после соритировки(худший случай)");
            sWatch2.Start();
            Merge_Sort(mas);
            sWatch2.Stop();
            TimeSpan tSpan2; tSpan2 = sWatch2.Elapsed;
            Console.WriteLine(tSpan2.ToString());
        }
    }
}
