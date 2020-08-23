using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Флоид
{
    class Program
    {
        static public string[] imena = new string[]
      {   "Луганск","Харьков","Донецк","Сумы","Полтава",
          "Днепропетровск","Запорожье","Херсон","Симферополь","Николаев",
          "Кировоград","Черкасы","Чернигов","Киев","Житомер",
          "Винница","Одесса","Хмельницк","Ровно","Луцк",
          "Тернополь","Черновцы","Львов","Ивано-Франковск","Ужгород"   };
        static public int[,] rasstoianiia = new int[,] 
      { { 0,303,151,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue},
        {303,0,283,185,144,222,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue, int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue},
        { 151,283,0,int.MaxValue,int.MaxValue,250,243,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue},
        {int.MaxValue,185,int.MaxValue,0,185,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,338,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue },
        {int.MaxValue,144,int.MaxValue,185,0,183,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,251,271,412,343,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue },
        { int.MaxValue,222,250,int.MaxValue,183,0,89,316,int.MaxValue,329,246,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue},
        {int.MaxValue,int.MaxValue,243,int.MaxValue,int.MaxValue,89,0,292,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue },
        {int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,316,292,0,279,71,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue, },
        { int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,279,0,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue},
        {int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,329,int.MaxValue,71,int.MaxValue,0,180,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,134,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue},
        {int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,251,246,int.MaxValue,int.MaxValue,int.MaxValue,180,0,126,int.MaxValue,int.MaxValue,int.MaxValue,317,337,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue },
        { int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,271,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,126,0,int.MaxValue,201,int.MaxValue,340,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue},
        {int.MaxValue,int.MaxValue,int.MaxValue,338,412,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,0,151,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue },
        { int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,343,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,201,151,0,140,226,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue},
        {int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,140,0,126,int.MaxValue,208,187,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue },
        {int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,317,340,int.MaxValue,226,126,0,429,122,int.MaxValue,int.MaxValue,int.MaxValue,312,int.MaxValue,int.MaxValue,int.MaxValue },
        {int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,134,337,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,429,0,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue },
        { int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,208,122,int.MaxValue,0,195,int.MaxValue,117,190,int.MaxValue,int.MaxValue,int.MaxValue},
        { int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,187,int.MaxValue,int.MaxValue,195,0,70,158,int.MaxValue,215,int.MaxValue,int.MaxValue},
        {int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,70,0,int.MaxValue,int.MaxValue,152,int.MaxValue,int.MaxValue },
        { int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,117,158,int.MaxValue,0,176,127,137,int.MaxValue},
        {int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,312,int.MaxValue,190,int.MaxValue,int.MaxValue,176,0,int.MaxValue,143,int.MaxValue},
        {int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,215,152,127,int.MaxValue,0,135,278},
        {int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,137,143,135,0,301 },
        { int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,int.MaxValue,278,301,0} };
        static void Main(string[] args)
        {int [,] W=new int[25,25];
        int help = 0;
        for (int i = 0; i < rasstoianiia.GetLength(0); i++)
        {
            for (int j = 0; j < rasstoianiia.GetLength(1); j++)
            {
                if (rasstoianiia[i, j] == int.MaxValue)
                { rasstoianiia[i, j] = int.MaxValue / 100; }
            }
        }
            for(int k=0; k<25; k++)
            {
            for (int i=0; i<25;i++)
            {
            for(int j=0; j<25;j++)
            {
                help = rasstoianiia[i, k] + rasstoianiia[k, j];
                if (help < rasstoianiia[i, j])
                {
                    rasstoianiia[i, j] = help;
                }
            }
            }
            }
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    Console.Write(rasstoianiia[i, j]+" ");
                }
                Console.WriteLine();
                    
            }
            }

        }
    }

