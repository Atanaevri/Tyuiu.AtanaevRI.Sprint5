using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AtanaevRI.Sprint5.Task7.V17.Lib;

namespace Tyuiu.AtanaevRI.Sprint5.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V17.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.IsTrue(fileExists);
        }

        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V17.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.IsTrue(fileExists);

            string testData = "Словарные слова с удвоеной согласной н";
            File.WriteAllText(path, testData, Encoding.Default);

            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V17.txt");

            DataService ds = new DataService();
            string resultPath = ds.LoadDataAndSave(path);

            Assert.IsTrue(File.Exists(resultPath));

            string result = File.ReadAllText(resultPath, Encoding.Default);

            string expected = "Словарные слова с удвоеой согласной";

            Assert.AreEqual(expected, result);
        }
    }
}