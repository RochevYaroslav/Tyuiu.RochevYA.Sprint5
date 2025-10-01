using Tyuiu.RochevYA.Sprint5.Task7.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine(ds.LoadDataAndSave(@"C:\Users\Ярослав\source\repos\Tyuiu.RochevYA.Sprint5\DataSprint5\InPutDataFileTask7V8.txt"));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}