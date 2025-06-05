public class Human : IWork, IEat
{
    public void Work()
    {
        Console.WriteLine("Working...");
    }

    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}