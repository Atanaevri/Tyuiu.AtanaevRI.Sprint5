using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AtanaevRI.Sprint5.Task3.V1.Lib
{
    public class DataService : ISprint5Task3V1
    {
        public string SaveToFileTextData(int x)
        {
            // Используем Path.GetTempPath() для получения временной директории
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            // Вычисление выражения
            double num1 = Math.Pow(x, 3) - 8;
            double num2 = 2 * Math.Pow(x, 2);
            double result = num1 / num2;

            // Округление до трех знаков после запятой
            result = Math.Round(result, 3);

            // Записываем бинарное представление округленного double
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create), Encoding.UTF8))
            {
                writer.Write(result); // BinaryWriter.Write(double) записывает 8 байт double
            }

            return path;
        }
    }
}