using Tyuiu.AtanaevRI.Sprint5.Task2.V4.Lib;
namespace Tyuiu.AtanaevRI.Sprint5.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\atana\source\repos\Tyuiu.AtanaevRI.Sprint5\Tyuiu.AtanaevRI.Sprint5.Task2.V4\bin\Debug\net8.0\OutPutFileTask2.csv";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
