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
            long positiveSum = 0;
            long negativeSum = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    line = line.Trim();

                    string normalizedLine = line.Replace(',', '.');

                    if (long.TryParse(normalizedLine, NumberStyles.Integer, CultureInfo.InvariantCulture, out long intValue))
                    {
                        if (intValue > 0)
                            positiveSum += intValue;
                        else if (intValue < 0)
                            negativeSum += intValue;
                    }
                    else if (double.TryParse(normalizedLine, NumberStyles.Float, CultureInfo.InvariantCulture, out double doubleValue))
                    {
                        double rounded = Math.Round(doubleValue, 3, MidpointRounding.AwayFromZero);

                        double diff = Math.Abs(rounded - Math.Round(rounded));
                        if (diff < 0.0001)
                        {
                            long value = (long)Math.Round(rounded);
                            if (value > 0)
                                positiveSum += value;
                            else if (value < 0)
                                negativeSum += value;
                        }
                    }
                }
            }

            long sumPositive = positiveSum;
            long sumNegative = Math.Abs(negativeSum);
            long difference = sumPositive - sumNegative;

            return (double)difference;
        }
    }
}