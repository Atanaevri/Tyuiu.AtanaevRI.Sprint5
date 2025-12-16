using System;
using System.IO;
using System.Text;
using Tyuiu.AtanaevRI.Sprint5.Task7.V17.Lib;

namespace Tyuiu.AtanaevRI.Sprint5.Task7.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Атанаев Р. И. | РППБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Атанаев Р. И. | РППБ-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных. Удалить все удвоенные  *");
            Console.WriteLine("* буквы 'нн' из файла.                                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask7V17.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден! Создаю тестовый файл...");

                Directory.CreateDirectory(@"C:\DataSprint5\");

                string[] testData = {
                    "Пример текста с удвоенными нн и одиночными н.",
                    "Анна и Иваннна пошли в осеннний лес.",
                    "В слове 'одинннадцать' тоже есть двойные нн.",
                    "Здесь нннн много подряд идущих букв нн.",
                    "А здесь просто одинарные н без изменений."
                };

                File.WriteAllLines(path, testData, Encoding.Default);
                Console.WriteLine("Создан тестовый файл с данными.");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                string resultPath = ds.LoadDataAndSave(path);
                Console.WriteLine("Обработанный файл сохранен по пути:");
                Console.WriteLine(resultPath);

                if (File.Exists(resultPath))
                {
                    Console.WriteLine();
                    Console.WriteLine("Содержимое обработанного файла:");
                    Console.WriteLine("--------------------------------");

                    string resultContent = File.ReadAllText(resultPath, Encoding.Default);
                    Console.WriteLine(resultContent);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при обработке файла: " + ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Для продолжения нажмите любую клавишу...                                *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}