using Tyuiu.RochevYA.Sprint5.Task6.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine(ds.LoadFromDataFile(@"C:\Users\Ярослав\source\repos\Tyuiu.RochevYA.Sprint5\DataSprint5\InPutDataFileTask6V30.txt"));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}