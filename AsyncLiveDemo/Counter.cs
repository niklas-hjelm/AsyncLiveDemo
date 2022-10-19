namespace AsyncLiveDemo;

public class Counter
{
    public void Start()
    {
        //Startar CountUp
        Console.WriteLine("Starting CountUp");
        CountUp();

        //Startar CountDown
        Console.WriteLine("Starting CountDown");
        CountDown();

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

        for (int i = 9; i >= 0; i--)
        {
            //Be tråden vänta 200ms (placeholder för en tidskrävande operation tex. ladda in en fil)
            Thread.Sleep(200);
            //Skriv ut trådnamnet och värdet på i
            Console.WriteLine($"Thread: {thread.Name}, CountDown: {i}");
        }
    }
}