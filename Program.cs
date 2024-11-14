namespace GenericExample;

class Program
{
    static void Main(string[] args)
    {
        var strData = new GenericStore<string>("Hello World");

        Console.WriteLine(strData.Data);
    }
}
