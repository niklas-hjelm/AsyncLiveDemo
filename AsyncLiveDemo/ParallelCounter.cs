namespace AsyncLiveDemo;

public class ParallelCounter
{
    public void Start()
    {
        //Instansiera en tråd och ge den operationen CountUp
        var up = new Thread(CountUp);
        //Instansiera en tråd och ge den operationen CountUp
        var down = new Thread(CountDown);

        //Ge trådarna var sina namn
        up.Name = "up";
        down.Name = "down";

        Console.WriteLine("Starting CountUp");
        //Starta tråden up
        up.Start();
        Console.WriteLine("Starting CountDown");
        //Starta tråden down
        down.Start();
        Console.WriteLine("Done");
    }

    public void CountUp()
    {
        //Hämta den aktuella tråden
        var thread = Thread.CurrentThread;

        for (int i = 0; i < 10; i++)
        {
            //Be tråden vänta 200ms (placeholder för en tidskrävande operation tex. ladda in en fil)
            Thread.Sleep(200);
            //Skriv ut trådnamnet och värdet på i
            Console.WriteLine($"Thread: {thread.Name}, CountUp: {i}");
        }
    }

    public void CountDown()
    {
        //Hämta den aktuella tråden
        var thread = Thread.CurrentThread;

        for (int i = 0; i < 10; i++)
        {
            //Be tråden vänta 200ms (placeholder för en tidskrävande operation tex. ladda in en fil)
            Thread.Sleep(200);
            //Skriv ut trådnamnet och värdet på i
            Console.WriteLine($"Thread: {thread.Name}, CountUp: {i}");
        }
    }
}