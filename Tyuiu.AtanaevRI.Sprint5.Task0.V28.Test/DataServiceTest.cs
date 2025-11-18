using Tyuiu.AtanaevRI.Sprint5.Task0.V28.Lib;
namespace Tyuiu.AtanaevRI.Sprint5.Task0.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
           
            {
                // - подготовка данных
                DataService ds = new DataService();
                int x = 3;
                string expectedResult = "64.000"; // Ожидаемый результат при x=3
                string expectedPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

                //  - выполнение действия
                string path = ds.SaveToFileTextData(x);
                string actualResult = File.ReadAllText(path);

                // Assert - проверка результатов
                Assert.AreEqual(expectedPath, path); // Проверяем путь
                Assert.AreEqual(expectedResult, actualResult); // Проверяем содержимое
                Assert.IsTrue(File.Exists(path)); // Проверяем что файл создан

                File.Delete(path);
          
            }
        }
    }
}
    

