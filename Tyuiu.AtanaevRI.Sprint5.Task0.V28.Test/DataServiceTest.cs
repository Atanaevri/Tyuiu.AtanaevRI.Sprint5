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
              
                DataService ds = new DataService();
                int x = 3;
                string expectedResult = "64.000"; 
                string expectedPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

               
                string path = ds.SaveToFileTextData(x);
                string actualResult = File.ReadAllText(path);

               
                Assert.AreEqual(expectedPath, path);
                Assert.AreEqual(expectedResult, actualResult); 
                Assert.IsTrue(File.Exists(path));
                File.Delete(path);
          
            }
        }
    }
}
    

