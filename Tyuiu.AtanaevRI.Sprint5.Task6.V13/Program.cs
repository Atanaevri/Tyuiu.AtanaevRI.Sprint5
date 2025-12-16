using System;
using System.IO;
using Tyuiu.AtanaevRI.Sprint5.Task6.V13.Lib;

namespace Tyuiu.AtanaevRI.Sprint5.Task6.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask6V13.txt";

            if (File.Exists(path))
            {
                int res = ds.LoadFromDataFile(path);
                Console.WriteLine("Количество удвоенных букв 'сс' = " + res);
            }
            else
            {
                Console.WriteLine("Файл не найден");
            }

            Console.ReadKey();
        }
    }
}