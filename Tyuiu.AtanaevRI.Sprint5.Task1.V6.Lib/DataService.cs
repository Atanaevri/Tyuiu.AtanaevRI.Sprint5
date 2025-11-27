using System.Globalization;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AtanaevRI.Sprint5.Task1.V6.Lib
{
   
        public class DataService : ISprint5Task1V6
        {
            public string SaveToFileTextData(int startValue, int stopValue)
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

                using (StreamWriter writer = new StreamWriter(path, false, Encoding.Default))
                {
                    for (int x = startValue; x <= stopValue; x++)
                    {
                        double result = CalculateFunction(x);
                        string formattedResult = result.ToString("0.00", CultureInfo.GetCultureInfo("ru-RU"));
                        if (formattedResult.EndsWith(",00"))
                        {
                        formattedResult = formattedResult.Substring(0, formattedResult.Length - 3);
                        }
                        writer.WriteLine(formattedResult);
                    }
                }

                return path;
            }

            private double CalculateFunction(int x)
            {
                try
                {
                    double term1 = Math.Cos(x);
                    double term2 = (4 * x) / 2; 
                    double term3 = Math.Sin(x) * 3 * x;

                    return term1 + term2 - term3;
                }
                catch (DivideByZeroException)
                {
                    return 0;
                }
            }
        }
    }