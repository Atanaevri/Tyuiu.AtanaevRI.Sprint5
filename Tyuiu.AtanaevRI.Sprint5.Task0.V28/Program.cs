using Tyuiu.AtanaevRI.Sprint5.Task0.V28.Lib;
Console.Title = "Спринт #5 | Выполнил: Атанаев Р.И. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                             *");
Console.WriteLine("* Тема: Операции Сравнения                            *");
Console.WriteLine("* Задание #0                                                            *");
Console.WriteLine("* Вариант #28                                                      *");
Console.WriteLine("* Выполнил: Атанаев Р.И. | РППб-25-1                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("*   Дано выражение вычислить его значение при x = 3, результат сохранить в текстовый файл OutPutFileTask0.txt" +
    " и вывести на консоль. Округлить до трёх знаков после запятой." +
    "Для составления " +
    "пути используйте Path.Combine() (не слеши)\r\nДиректорию берите через Path.GetTempPath()\r\n\r\nИли," +
    " чтобы не составлять путь можно использовать \r\nPath.GetTempFileName(), он сразу создает файл с случайным именем в темп папке*");
Console.WriteLine("*                                           *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");


Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
DataService ds = new DataService();
                int x = 3;

                string path = ds.SaveToFileTextData(x);

            
                string result = File.ReadAllText(path);

            Console.WriteLine("Результат: " + result);
            Console.WriteLine("Файл сохранён: " + path);
            Console.ReadKey();
        