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
            string content = File.ReadAllText(path);
            string[] lines = content.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            double positiveSum = 0;
            double negativeSum = 0;

            foreach (string line in lines)
            {
                string trimmedLine = line.Trim();
                if (string.IsNullOrEmpty(trimmedLine))
                    continue;

                string normalizedLine = trimmedLine.Replace(',', '.');

                if (double.TryParse(normalizedLine, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
                {
                    double rounded = Math.Round(value, 3);

                    if (Math.Abs(rounded % 1) < 0.00001)
                    {
                        if (rounded > 0)
                        {
                            positiveSum += (long)rounded;
                        }
                        else if (rounded < 0)
                        {
                            negativeSum += Math.Abs((long)rounded);
                        }
                    }
                }
            }

            return positiveSum - negativeSum;
        }
    }
}