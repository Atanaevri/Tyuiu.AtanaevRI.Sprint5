using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
namespace Tyuiu.AtanaevRI.Sprint5.Task3.V1.Lib
{
    public class DataService : ISprint5Task3V1
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";
            double num1 = Math.Pow(x, 3) - 8;
            double num2 = 2 * Math.Pow(x, 2);
            double num3 = num1 / num2;
            string resultString = num3.ToString("F3", System.Globalization.CultureInfo.InvariantCulture);
            File.WriteAllText(path, resultString, Encoding.UTF8);

            return path;
        }
        
    }
}
