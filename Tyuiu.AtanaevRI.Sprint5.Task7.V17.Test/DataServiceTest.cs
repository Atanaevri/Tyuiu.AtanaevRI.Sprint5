using System;
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
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V17.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.IsTrue(fileExists);

            string testData = "Это пример текста с двойными нн буквами.\n" +
                             "Здесь нннн много подряд идущих нн.\n" +
                             "Анна и Иваннна - имена с двойными нн.\n" +
                             "Одинннадцать и осеннний тоже.\n" +
                             "Одинарные н остаются без изменений.";

            File.WriteAllText(path, testData, Encoding.Default);

            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V17.txt");

            DataService ds = new DataService();
            string resultPath = ds.LoadDataAndSave(path);

            Assert.AreEqual(outputPath, resultPath);

            Assert.IsTrue(File.Exists(resultPath));

            string result = File.ReadAllText(resultPath, Encoding.Default);

            string expected = "Это пример текста с двойными н буквами.\n" +
                             "Здесь нн много подряд идущих н.\n" +
                             "Анна и Иванна - имена с двойными н.\n" +
                             "Одинадцать и осенний тоже.\n" +
                             "Одинарные н остаются без изменений.";

            Assert.AreEqual(expected, result);
        }
    }
}