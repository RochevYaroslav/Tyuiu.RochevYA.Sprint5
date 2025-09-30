using Tyuiu.RochevYA.Sprint5.Task1.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int start = -5;
        int end = 5;
        Console.WriteLine(ds.SaveToFileTextData(start,end));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}