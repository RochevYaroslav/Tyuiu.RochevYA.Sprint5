using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RochevYA.Sprint5.Task1.V5.Lib
{
    public class DataService : ISprint5Task1V5
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            List<int> results = new List<int>();

            for (int i = startValue; i <= stopValue; i++)
            {
                double denominator = 2 * i - 0.5;

                if (Math.Abs(denominator) < 1e-10)
                {
                    results.Add(0);
                }
                else
                {
                    double value = 5 - 3 * i + (1 + Math.Sin(i)) / denominator;
                    results.Add((int)Math.Round(value,2)); 
                }
            }

            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            //File.WriteAllLines(filePath, results.Select(x => x.ToString()));
            return string.Join("\n", results);
        }
    }
}
