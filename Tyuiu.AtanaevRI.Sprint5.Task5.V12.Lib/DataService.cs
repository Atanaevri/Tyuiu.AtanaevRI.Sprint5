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

                    if (double.TryParse(line.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                    {
                        // Check if the number is essentially an integer (within a small tolerance)
                        double roundedToNearestInteger = Math.Round(number);
                        if (Math.Abs(number - roundedToNearestInteger) < 0.000001)
                        {
                            // It's an integer
                            long intValue = (long)roundedToNearestInteger;
                            sum += intValue;
                        }
                    }
                }
            }

            return sum;
        }
    }
}