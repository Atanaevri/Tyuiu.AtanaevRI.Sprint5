using Tyuiu.AtanaevRI.Sprint5.Task3.V1.Lib;

Console.Title = "Спринт #5 | Выполнил: Атанаев Р.И. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                             *");
Console.WriteLine("* Тема: Операции Сравнения                            *");
Console.WriteLine("* Задание #0                                                            *");
Console.WriteLine("* Вариант #28                                                      *");
Console.WriteLine("* Выполнил: Атанаев Р.И. | РППб-25-1                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("*   Дано выражение вычислить его значение при x = 3, результат сохранить в бинарный файл" +
    " OutPutFileTask3.bin и вывести на консоль. Округлить до трёх знаков после запятой.\r\n\r\n*");
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
