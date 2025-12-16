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
                    line = line.Replace(',', '.');

                    if (long.TryParse(line, NumberStyles.Integer, CultureInfo.InvariantCulture, out long intValue))
                    {
                        if (intValue > 0)
                            positiveSum += intValue;
                        else if (intValue < 0)
                            negativeSum += intValue;
                    }
                    else if (double.TryParse(line, NumberStyles.Float, CultureInfo.InvariantCulture, out double doubleValue))
                    {
                        double rounded = Math.Round(doubleValue, 3, MidpointRounding.AwayFromZero);
                        double fractional = Math.Abs(rounded - Math.Truncate(rounded));

                        if (fractional < 0.0001)
                        {
                            long roundedInt = (long)rounded;
                            if (roundedInt > 0)
                                positiveSum += roundedInt;
                            else if (roundedInt < 0)
                                negativeSum += roundedInt;
                        }
                    }
                }
            }

            return positiveSum + negativeSum;
        }
    }
}