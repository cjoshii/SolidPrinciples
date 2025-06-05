public class Client
{
    private readonly IWork worker;
    private readonly IEat eater;

    public Client(IWork worker, IEat eater)
    {
        this.worker = worker;
        this.eater = eater;
    }

    public void Work()
    {
        worker.Work();
    }

    public void Eat()
    {
        eater.Eat();
    }
}