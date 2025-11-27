using Tyuiu.AtanaevRI.Sprint5.Task1.V6.Lib;
Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"startValue = {startValue}");
            Console.WriteLine($"stopValue = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
     
            DataService ds = new DataService();
string path = ds.SaveToFileTextData(startValue, stopValue);

            
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine($"Файл: {path}");
            Console.WriteLine("Создан!");
            Console.ReadKey();
        
 
