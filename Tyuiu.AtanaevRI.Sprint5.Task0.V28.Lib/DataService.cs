
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AtanaevRI.Sprint5.Task0.V28.Lib
{
    public class DataService : ISprint5Task0V28
    {
        public string SaveToFileTextData(int x)
        {


            double result = x * Math.Sqrt(x + 3);

            string formattedResult = result.ToString("F3", CultureInfo.InvariantCulture);


            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            File.WriteAllText(path, formattedResult);

            return path;

        }
    }
}
  

