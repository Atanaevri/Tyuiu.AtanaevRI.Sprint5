using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AtanaevRI.Sprint5.Task5.V12.Lib
{
    public class DataService : ISprint5Task5V12
    {

        public double LoadFromDataFile(string path)
        {
            double sum = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Trim();
                    if (string.IsNullOrEmpty(line))
                        continue;

               
                    if (long.TryParse(line, out long intValue))
                    {
                        sum += intValue;
                    }
                    else if (double.TryParse(line.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double doubleValue))
                    {
    
                        if (Math.Abs(doubleValue % 1) < 0.000001 || Math.Abs(doubleValue % 1) > 0.999999)
                        {
                            long roundedValue = (long)Math.Round(doubleValue);
                            sum += roundedValue;
                        }
                    }
                }
            }

            return sum;
        }
    }
}