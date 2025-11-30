using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AtanaevRI.Sprint5.Task2.V4.Lib
{
    public class DataService : ISprint5Task2V4
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";
            
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            if ( fileExists)
            {
                File.Delete(path);
            }


            int rows = matrix.GetUpperBound(0);
            int cols = matrix.GetUpperBound(1);
            for (int i = 0;i < rows; i++)
            {
                for (int j = 0;j < cols;j++)
                {
                    if (matrix[i,j] > 0 )
                    {
                        matrix[i, j] = 1;
                    }
                    if (matrix[i,j] < 0)
                    {
                        matrix[i,j] = 0;
                    }
                }
            }
            return path;

            
        }
        
    }
}
