using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RochevYA.Sprint5.Task0.V10.Lib
{
    public class DataService : ISprint5Task0V10
    {
        public string SaveToFileTextData(int x)
        {
            double y = 1.6*Math.Pow(x,3) - 2.1*Math.Pow(x,2) + 7*x;
            string outputFile = "OutPutFileTask0.txt";
            //File.WriteAllText(outputFile, y.ToString());
            return y.ToString();
        }
    }
}
