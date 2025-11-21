
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AtanaevRI.Sprint5.Task0.V28.Lib
{
    public class DataService : ISprint5Task0V28
    {
        public string SaveToFileTextData(int x)
        {


            double result = Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 5 * x + 4;

            string formattedResult = result.ToString("F3", CultureInfo.InvariantCulture);


            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            File.WriteAllText(path, formattedResult);

            return path;

        }
    }
}
  

