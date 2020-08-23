using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Qsort
{
    class Program
    {
        public static void Sort(ref int[] massiv, int low, int high)
        {
            int i = low;
            int j = high;
            int x = massiv[(low + high) / 2];
            do
            {
                while (massiv[i] < x) i++;
                while (massiv[j] > x) j--;
                if (i <= j)
                {

                    int z = massiv[i];
                    massiv[i] = massiv[j];
                    massiv[j] = z;
                    i++; j--;
                }
            }
            while (i < j);
            {
                if (low < j) Sort(ref massiv, low, j);
                if (i < high) Sort(ref massiv, i, high);
            }

        }

        static void Main(string[] args)
        {
            int[] massiv = new int[100];
            int low = 0, high = 99;
            Stopwatch sWatch = new Stopwatch(); Stopwatch sWatch1 = new Stopwatch(); Stopwatch sWatch2 = new Stopwatch();
            Random rand = new Random();
            TimeSpan tSpan; 
            Console.WriteLine("\t\t\tМассив до сортировки");
            for (int j = 0; j < 100; j++)
            {
                for (int i = 0; i < massiv.Length; i++)
                {
                    massiv[i] = rand.Next(1000);
                    Console.Write(massiv[i] + " ");
                }
                sWatch.Start();
                Sort(ref massiv, low, high);
                sWatch.Stop();
            }
            tSpan = sWatch.Elapsed;
            Console.WriteLine();
            Console.WriteLine("\t\t\tМассив после сортировки");
            Console.WriteLine(tSpan.ToString());
            Console.WriteLine("\t\t\tМассив после повторной сортировки");
            sWatch1.Start();
            Sort(ref massiv, low, high);
            sWatch1.Stop();
            TimeSpan tSpan1; tSpan1 = sWatch1.Elapsed;
            Console.WriteLine(tSpan1.ToString());
            int[] mas = new int[100];
            for (int j = massiv.Length -1; j > 0; j--)
            {
                mas[j] = massiv[j];
            }
            Console.WriteLine("\t\t\t Массив после соритировки(худший случай)");
            sWatch2.Start();
            Sort(ref mas, low, high);
            sWatch2.Stop();
            TimeSpan tSpan2; tSpan2 = sWatch2.Elapsed;
            Console.WriteLine(tSpan2.ToString());
            Console.ReadKey();
        }
        
    }
}
