using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RochevYA.Sprint5.Task4.V8.Lib
{
    public class DataService : ISprint5Task4V8
    {
        public double LoadFromDataFile(string path)
        {
            string x = File.ReadAllText(path);
            x = x.Replace('.', ',');
            double temp = Convert.ToDouble(x);
            return Math.Round(Math.Pow(temp, 2) / Math.Sin(temp) + 3, 3);
        }
    }
}
