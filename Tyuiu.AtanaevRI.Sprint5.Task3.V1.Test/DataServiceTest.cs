using Tyuiu.AtanaevRI.Sprint5.Task3.V1.Lib;
namespace Tyuiu.AtanaevRI.Sprint5.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\atana\source\repos\Tyuiu.AtanaevRI.Sprint5\Tyuiu.AtanaevRI.Sprint5.Task3.V1\bin\Debug\net8.0\OutPutFileTask3.bin ";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
