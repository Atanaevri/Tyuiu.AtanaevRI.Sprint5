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
            double positiveSum = 0;
            double negativeSum = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    line = line.Trim();
                    line = line.Replace(',', '.');

                    if (double.TryParse(line, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                    {
                        double rounded = Math.Round(number, 3);

                        if (Math.Abs(Math.Round(rounded) - rounded) < 0.0001)
                        {
                            long integerValue = (long)Math.Round(rounded);

                            if (integerValue > 0)
                            {
                                positiveSum += integerValue;
                            }
                            else if (integerValue < 0)
                            {
                                negativeSum += Math.Abs(integerValue);
                            }
                        }
                    }
                }
            }

            double result = positiveSum - negativeSum;
            return result;
        }
    }
}