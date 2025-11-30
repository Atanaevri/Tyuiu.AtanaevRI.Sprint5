using Tyuiu.AtanaevRI.Sprint5.Task2.V4.Lib;
Console.Title = "Спринт #5 | Выполнил: Атанаев Р.И. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                             *");
Console.WriteLine("* Тема: Операции Сравнения                            *");
Console.WriteLine("* Задание #2                                                          *");
Console.WriteLine("* Вариант 4                                                     *");
Console.WriteLine("* Выполнил: Атанаев Р.И. | РППб-25-1                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("*  Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями с клавиатуры." +
    " Заменить положительные элементы массива на 1, " +
    "отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.*");
Console.WriteLine("*                                           *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Введите 9 чисел для заполнения матрицы 3x3:");
int[,] array = new int[3, 3];
for  (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Элемент [{i} ,{j}]:");
        array[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("Массив");
for (int i = 0;i < 3; i++)
{
    for (int j = 0; j < 3;j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}



Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
DataService ds = new DataService();
string res = ds.SaveToFileTextData(array);

           
            string path = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask2.csv");

            File.WriteAllText(path, res);

Console.WriteLine("\nПреобразованный массив:");
Console.WriteLine(res.Replace(";", "; "));

Console.WriteLine($"\nФайл сохранен: {path}");
Console.ReadKey();
        
    

