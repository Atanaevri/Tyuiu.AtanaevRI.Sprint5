using System;
using System.IO;
using Tyuiu.AtanaevRI.Sprint5.Task5.V12.Lib;

namespace Tyuiu.AtanaevRI.Sprint5.Task5.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Атанаев Р. И. | РППБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Атанаев Р. И. | РППБ-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл в котором есть набор значений. Найти разницу между суммой      *");
            Console.WriteLine("* всех положительных и отрицательных целых чисел в файле.                 *");
            Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V12.txt");


            Console.WriteLine("Данные находятся в файле: " + path);

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден! Создаю тестовый файл...");

                string[] testData = {
                    "10",
                    "15.5",
                    "-20",
                    "3.14159",
                    "-5",
                    "7",
                    "-3.999",
                    "12",
                    "0",
                    "-8.1"
                };

                File.WriteAllLines(path, testData);
                Console.WriteLine("Создан тестовый файл с данными.");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                double result = ds.LoadFromDataFile(path);
                Console.WriteLine("Разница между суммой положительных и отрицательных целых чисел = " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}