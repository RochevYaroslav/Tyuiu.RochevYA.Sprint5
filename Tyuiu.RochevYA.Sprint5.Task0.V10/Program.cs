using Tyuiu.RochevYA.Sprint5.Task0.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 2;
        Console.WriteLine(ds.SaveToFileTextData(x));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}