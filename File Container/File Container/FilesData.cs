using System;
using System.IO;

namespace File_Container
{
    [Serializable]
    public class FilesData //класс, содержащий файлы
    {
        [Serializable] // присваиваем объекту атрибут сериализации 
        public struct fi //структура класса
        {
            public string path; //путь файла
            public string name; //имя файла
            public byte[] data; //содержимое файла
        }
        public readonly int count = 0; //количество файлов в классе
        public fi[] dataFi; // массив файлов

        public FilesData() { }
        public FilesData(string[] str,string[] strName) //конструктор класса
        {
            count = str.Length;
            fi[] K = new fi[count];
            foreach (string s in str)
            {
                count--;
                FileStream A = new FileStream(s, FileMode.Open, FileAccess.Read);
                BufferedStream B = new BufferedStream(A);
                K[count].path = s;
                K[count].data = new byte[B.Length];
                B.Read(K[count].data, 0, (int)B.Length);
                B.Close(); A.Close();
            }
            count = strName.Length;
            foreach (string n in strName)
            {
                count--;
                K[count].name = n;
            }
            dataFi = K;
            count = str.Length;
        }
        public FilesData(string[] str)
        {
            count = str.Length;
            fi[] K = new fi[count];
            foreach (string s in str)
            {
                count--;
                FileStream A = new FileStream(s, FileMode.Open, FileAccess.Read);
                BufferedStream B = new BufferedStream(A);
                K[count].path = s;
                K[count].data = new byte[B.Length];
                B.Read(K[count].data, 0, (int)B.Length);
                B.Close(); A.Close();
            }
            dataFi = K;
            count = str.Length;
        }
    }
}
