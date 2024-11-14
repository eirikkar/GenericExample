namespace GenericExample;

class Program
{
    static void Main()
    {
        // Laget en generisk string variabel
        var strData = new Generic<string>();
        strData.Data = "Hello, World!";
        Console.WriteLine(strData.Data);

        // Laget en generisk int variabel
        Generic<int> intData = new();
        intData.Data = 10;
        Console.WriteLine(intData.Data);

        // Laget en generisk liste med string og int
        Generic<List<object>> listData = new();
        listData.Data = new List<object> { strData.Data, intData.Data };

        foreach (var item in listData.Data)
        {
            Console.WriteLine(item);
        }

        // Laget en generisk liste med int
        var intList = new Generic<List<int>>();
        intList.Data = new List<int> { 1, 2, 3, 4, 5 };
        foreach (var item in intList.Data)
        {
            Console.WriteLine(item);
        }

        // Laget en generisk liste med string
        var strList = new Generic<List<string>>();
        strList.Data = new List<string> { "Eirik", "Mats", "Kari", "Ola", "Knut" };
        foreach (var item in strList.Data)
        {
            Console.WriteLine(item);
        }

        // Laget en generisk liste med metoder
        var objList = new Generic<List<object>>();
        objList.Data = new List<object> { Hello(), Number() };

        string Hello()
        {
            return "returned from Hello()";
        }
        int Number()
        {
            return 10;
        }
        foreach (var item in objList.Data)
        {
            Console.WriteLine(item);
        }
    }
}
