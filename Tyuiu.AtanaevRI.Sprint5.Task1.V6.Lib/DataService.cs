using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AtanaevRI.Sprint5.Task1.V6.Lib
{
    public class DataService : ISprint5Task1V6
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
           
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine("╔═══════╦═════════════╗");
                    writer.WriteLine("║   x   ║    f(x)     ║");
                    writer.WriteLine("╠═══════╬═════════════╣");

                    for (int x = startValue; x <= stopValue; x++)
                    {
                        double result = CalculateFunction(x);
                        writer.WriteLine($"║  {x,3}  ║  {result,9:F2}  ║");
                    }

                    writer.WriteLine("╚═══════╩═════════════╝");
                }

                return path;
            }

            private double CalculateFunction(int x)
            {
                try
                {
                    
                    double term1 = Math.Cos(x);
                    double term2 = (4 * x) / 2;  // 2x
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

    

