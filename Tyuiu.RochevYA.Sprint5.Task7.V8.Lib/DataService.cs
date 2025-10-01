using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RochevYA.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {
            string str = File.ReadAllText(path);
            string[] words = str.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] chars = words[i].ToCharArray();
                for (int j = 0; j < chars.Length; j++)
                {
                    if (chars[j] >= 'А' && chars[j] <= 'Я')
                    {
                        chars[j] = (char)(chars[j] + 32);
                    }
                }
                words[i] = new string(chars);
            }

            string result = string.Join(" ", words);
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V16.txt");
            File.WriteAllText(outputPath, result);
            return result;
        }
    }
}
