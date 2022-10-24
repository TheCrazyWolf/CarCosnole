using ConsoleApp4;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Vector3 vector = new Vector3(1, 2, 3);

        Car audi = new Car("Audi", vector);
        audi.Start();

        audi.Move(new Vector3(0, 4, 5));
        Console.WriteLine(audi.GetInfo());
        audi.Move(new Vector3(0, 4, 5));
        Console.WriteLine(audi.GetInfo());
        audi.Off();
        audi.Move(new Vector3(0, 4, 5));
        Console.WriteLine(audi.GetInfo());
        audi.Move(new Vector3(0, 4, 5));
        Console.WriteLine(audi.GetInfo());

    }
}
