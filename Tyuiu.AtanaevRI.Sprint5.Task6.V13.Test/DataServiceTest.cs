using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;
using Tyuiu.AtanaevRI.Sprint5.Task6.V13.Lib;
namespace Tyuiu.AtanaevRI.Sprint5.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalcValid()
        {
            DataService ds = new DataService();

            string testData = "сссновая строка ссс повторением ссссс букв сс";
            string path = @"C:\DataSprint5\TestFileTask6V13.txt";

            File.WriteAllText(path, testData, Encoding.UTF8);

            int result = ds.LoadFromDataFile(path);
            int expected = 9;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        public void CheckCalcEmpty()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\TestFileTask6V13_Empty.txt";

            File.WriteAllText(path, "", Encoding.UTF8);

            int result = ds.LoadFromDataFile(path);
            int expected = 0;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        public void CheckCalcNoMatches()
        {
            DataService ds = new DataService();

            string testData = "абвгдежзиклмнопрстуфхцчшщъыьэюя";
            string path = @"C:\DataSprint5\TestFileTask6V13_NoMatches.txt";

            File.WriteAllText(path, testData, Encoding.UTF8);

            int result = ds.LoadFromDataFile(path);
            int expected = 0;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }
    }
}