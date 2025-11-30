
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AtanaevRI.Sprint5.Task2.V4.Lib
{
    public class DataService : ISprint5Task2V4
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";
            
            
            

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            
         
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                string data = "";

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (matrix[i, j] > 0)
                        {
                            data += "1";
                        }
                        else
                        {
                            data += "0";
                        }

                        if (j < cols - 1)
                        {
                            data += ";";
                        }
                    }

                    if (i < rows - 1)
                    {
                        data += Environment.NewLine;
                    }
                }

                return data;
            }
        }
    }