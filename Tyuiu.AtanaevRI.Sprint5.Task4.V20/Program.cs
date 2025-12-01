using Tyuiu.AtanaevRI.Sprint5.Task4.V20.Lib;
DataService ds  = new DataService();
Console.Title = "Спринт #5 | Выполнил: Атанаев Р.И. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                             *");
Console.WriteLine("* Тема: Операции Сравнения                            *");
Console.WriteLine("* Задание #4                                                           *");
Console.WriteLine("* Вариант #20                                                  *");
Console.WriteLine("* Выполнил: Атанаев Р.И. | РППб-25-1                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("*   Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt (файл взять из архива согласно вашему варианту." +
    " Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё файл) в котором есть вещественное значение. " +
    "Прочитать значение из файла и подставить вместо Х в формуле ." +
    " Вычислить значение по формуле (Полученное значение округлить до трёх знаков после запятой) и вернуть полученный результат на консоль.*");
Console.WriteLine("*                                           *");
Console.WriteLine("*              Исходные данные                                                           *");
Console.WriteLine("***************************************************************************");

string path = Path.Combine(Path.GetTempPath(),"InPutDataFileTask4V20");
Console.WriteLine("Данные находятся в файле" + path);



Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadKey();  