using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AtanaevRI.Sprint5.Task4.V20.Lib
{
    public class DataService : ISprint5Task4V20
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            double num1 = Math.Round(Convert.ToDouble(strx), 2);
            double num2 = Math.Sin(Convert.ToDouble(strx));
            double y = num1 / num2;
            double res = Math.Round(Math.Pow(y,3), 3);
            return res;
        }
    }
}
