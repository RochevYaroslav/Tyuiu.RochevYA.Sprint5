using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RochevYA.Sprint5.Task6.V30.Lib
{
    public class DataService : ISprint5Task6V30
    {
        public int LoadFromDataFile(string path)
        {
            string[] x = File.ReadAllText(path).Split(" ");

            int col = 0;

            for (int i = 0; i < x.Length; i++)
            {
                int len = 0;

                for (int j = 0; j < x[i].Length; j++)
                {
                    len++;
                }

                if (len == 8)
                {
                    col ++;
                }
            }

            return col;
        }
    }
}
