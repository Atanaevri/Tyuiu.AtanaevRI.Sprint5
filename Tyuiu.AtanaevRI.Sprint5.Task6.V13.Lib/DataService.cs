using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AtanaevRI.Sprint5.Task6.V13.Lib
{
    public class DataService : ISprint5Task6V13
    {
        public int LoadFromDataFile(string path)
        {
            // Читаем весь текст из файла
            string text = File.ReadAllText(path, Encoding.Default);

            int count = 0;

            // Проходим по строке, проверяя каждую пару символов
            for (int i = 0; i < text.Length - 1; i++)
            {
                // Проверяем, являются ли текущий и следующий символы буквой 'с' (кириллической)
                if (text[i] == 'с' && text[i + 1] == 'с')
                {
                    count++;
                }
            }

            return count;
        }
    }
}