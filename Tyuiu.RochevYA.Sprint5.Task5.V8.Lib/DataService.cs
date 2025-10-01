using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RochevYA.Sprint5.Task5.V8.Lib
{
    public class DataService : ISprint5Task5V8
    {
        public double LoadFromDataFile(string path)
        {
            string x = File.ReadAllText(path);
            x = x.Replace('.', ',');
            double[] doubleArray = x.Split(" ").Select(x => double.Parse(x)).ToArray();

            double min = 10000000000000;
            for (int i = 0;i< doubleArray.Length; i++)
            {
                if ((doubleArray[i] < min) && (doubleArray[i]%1!=0))
                {
                    min = doubleArray[i];
                }
            }

            return min;
        }
    }
}
