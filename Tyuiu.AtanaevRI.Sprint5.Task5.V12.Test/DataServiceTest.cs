
using Tyuiu.AtanaevRI.Sprint5.Task5.V12.Lib;

namespace Tyuiu.AtanaevRI.Sprint5.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestValidDataFile()
        {
            // Создаем временный файл с тестовыми данными
            string path = Path.GetTempFileName();

            // Записываем тестовые данные
            string[] testData = {
                "10",
                "-5",
                "15.5",
                "-3",
                "7",
                "-2.8",
                "12",
                "-9",
                "0",
                "100",
                "-50"
            };

            File.WriteAllLines(path, testData);

            // Создаем объект DataService
            DataService ds = new DataService();

            // Вызываем тестируемый метод
            double result = ds.LoadFromDataFile(path);

            // Ожидаемый результат:
            // Положительные целые: 10, 7, 12, 100 = 129
            // Отрицательные целые: -5, -3, -9, -50 = -67
            // Разница: 129 - (-67) = 196
            double expected = 196;

            // Проверяем результат
            Assert.AreEqual(expected, result);

            // Удаляем временный файл
            File.Delete(path);
        }

        [TestMethod]
        public void TestOnlyPositiveIntegers()
        {
            // Создаем временный файл только с положительными целыми
            string path = Path.GetTempFileName();

            string[] testData = {
                "5",
                "10",
                "15",
                "20",
                "25"
            };

            File.WriteAllLines(path, testData);

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            // Сумма положительных: 5+10+15+20+25 = 75
            // Сумма отрицательных: 0
            // Разница: 75 - 0 = 75
            double expected = 75;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        public void TestOnlyNegativeIntegers()
        {
            // Создаем временный файл только с отрицательными целыми
            string path = Path.GetTempFileName();

            string[] testData = {
                "-5",
                "-10",
                "-15",
                "-20",
                "-25"
            };

            File.WriteAllLines(path, testData);

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            // Сумма положительных: 0
            // Сумма отрицательных: -5-10-15-20-25 = -75
            // Разница: 0 - (-75) = 75
            double expected = 75;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        public void TestWithRealNumbers()
        {
            // Создаем временный файл с вещественными числами
            string path = Path.GetTempFileName();

            string[] testData = {
                "3.14159",
                "2.71828",
                "-1.61803",
                "4.66920",
                "-0.57721"
            };

            File.WriteAllLines(path, testData);

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            // Нет целых чисел - результат должен быть 0
            double expected = 0;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        public void TestMixedNumbers()
        {
            // Создаем временный файл со смешанными данными
            string path = Path.GetTempFileName();

            string[] testData = {
                "3.0",      // Целое после округления
                "-2.999",   // -3 после округления
                "4.500",    // Не целое
                "-1.001",   // -1 после округления
                "0",
                "7",
                "-3.0"      // -3 после округления
            };

            File.WriteAllLines(path, testData);

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            
            double expected = 17;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        public void TestEmptyFile()
        {
           
            string path = Path.GetTempFileName();

            

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            
            double expected = 0;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void TestFileNotFound()
        {
            string path = @"C:\NonExistentFolder\NonExistentFile.txt";

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);
        }

        [TestMethod]
        public void TestWithLargeNumbers()
        {
          
            string path = Path.GetTempFileName();

            string[] testData = {
                "1000000",
                "-500000",
                "750000",
                "-250000",
                "1000.5",
                "-999.9"
            };

            File.WriteAllLines(path, testData);

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            
            double expected = 2500000;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        public void TestWithScientificNotation()
        {
           
            string path = Path.GetTempFileName();

            string[] testData = {
                "1e3",     
                "-2e2",     
                "3.5e2",   
                "-4.2e1",  
                "1.23e-1",               
                "-5.6e0"    
            };

            File.WriteAllLines(path, testData);

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            
            double expected = 1592;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        public void TestOnlyZeros()
        {
            string path = Path.GetTempFileName();

            string[] testData = {
                "0",
                "0.0",
                "0.00",
                "0.000"
            };

            File.WriteAllLines(path, testData);

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            // Нет положительных или отрицательных целых чисел
            double expected = 0;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }
    }
}