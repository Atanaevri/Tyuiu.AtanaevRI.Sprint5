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
            double sumPositive = 0;
            double sumNegative = 0;

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
                        double rounded = Math.Round(number, 3);

                        bool isInteger = Math.Abs(rounded % 1) < 0.0001;

                        if (isInteger)
                        {
                            long intValue = (long)Math.Round(rounded);

                            if (intValue > 0)
                            {
                                sumPositive += intValue;
                            }
                            else if (intValue < 0)
                            {
                                sumNegative += intValue;
                            }
                        }
                    }
                }
            }

            return sumPositive + sumNegative;
        }
    }
}