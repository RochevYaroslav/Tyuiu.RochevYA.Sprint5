using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RochevYA.Sprint5.Task3.V12.Lib
{
    public class DataService : ISprint5Task3V12
    {
        public string SaveToFileTextData(int x)
        {
            string outputFile = "OutPutFileTask3.bin";

            string path = Path.Combine(Path.GetTempPath(), outputFile);

            FileInfo fileInfo = new(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(path);

            double r = Math.Round((Math.Pow(x, 3)) / (2 * Math.Pow((x+5), 2)), 3);

            using (BinaryWriter writer = new(File.Open(path, FileMode.Append)))
            {
                writer.Write(r);
            }
            return path;
        }
    }
}
