using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] a = new int[n];
            Random rand = new Random();
            int tmp, c;                          //c - значение которое ищем

            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next(1000);
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (a[j - 1] > a[j])
                    {
                        tmp = a[j - 1];
                        a[j - 1] = a[j];
                        a[j] = tmp;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Искомое значение = ");
            c = Convert.ToInt32(Console.ReadLine());

            int num = n;
            int index = -1;
            int indexA = 0;

            while (num > 0)
            {
                num = n / 2;

                if (a[indexA + num] == c) { index = indexA + num; break; }
                if (a[indexA + num] > c) n = num;
                if (a[indexA + num] < c)
                {
                    indexA += num;
                    n = n - num;
                }
            }

            Console.WriteLine();

            if (index != -1)
                Console.WriteLine(index);
            else
                Console.WriteLine("Значение не найдено");

            Console.ReadLine();
        }
    }
}
