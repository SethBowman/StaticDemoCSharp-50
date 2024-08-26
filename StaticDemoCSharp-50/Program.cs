namespace StaticDemoCSharp_50;

class Program
{
    static void Main(string[] args)
    {
        //Static class/Static Method
        Console.WriteLine("Hello, World!");

        var storedReturn = MathHelper.Add(2, 2);
        Console.WriteLine(storedReturn);

        var classOne = new Classroom();
        var classTwo = new Classroom();
        Classroom.Subject = "C#";
        
        Greet("Seth");
    }

    public static void Greet(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}
