using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RochevYA.Sprint5.Task2.V5.Lib
{
    public class DataService : ISprint5Task2V5
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            var array = matrix;
            string[] result = new string[3];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] row = new string[3];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (array[i, j] % 2 == 1)
                    {
                        array[i, j] = 0;
                    }
                    row[j] = array[i, j].ToString();
                }
                result[i] = string.Join(";", row);
            }
            return string.Join("\n", result);
        }
    }
}
