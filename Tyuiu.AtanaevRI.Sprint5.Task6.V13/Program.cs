using Tyuiu.AtanaevRI.Sprint5.Task6.V13.Lib;
using System;
using System.IO;
using Tyuiu.AtanaevRI.Sprint5.Task6.V13.Lib;

namespace Tyuiu.AtanaevRI.Sprint5.Task6.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string tempPath = Path.GetTempPath();
            string sourceFile = @"C:\DataSprint5\InPutDataFileTask6V13.txt";
            string tempFile = Path.GetTempFileName();

            Console.WriteLine("Исходный файл: " + sourceFile);

            try
            {
                if (File.Exists(sourceFile))
                {
                    File.Copy(sourceFile, tempFile, true);
                    Console.WriteLine("Файл успешно скопирован во временную директорию");
                }
                else
                {
                    Console.WriteLine("Ошибка: Исходный файл не найден!");
                    Console.WriteLine("Убедитесь, что файл находится по пути: " + sourceFile);
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine("Временный файл: " + tempFile);
                Console.WriteLine();

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
                Console.WriteLine("***************************************************************************");

                DataService ds = new DataService();
                int count = ds.LoadFromDataFile(tempFile);

                Console.WriteLine("Количество удвоенных букв 'сс' в файле = " + count);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при обработке файла: " + ex.Message);
            }
            finally
            {
                if (File.Exists(tempFile))
                {
                    File.Delete(tempFile);
                }
            }

            Console.ReadKey();
        }
    }
}