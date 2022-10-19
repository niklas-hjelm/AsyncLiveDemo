namespace AsyncLiveDemo;

public class AsyncCounter
{
    //Start är här async och returnerar en Task.
    //Alla asynkrona metoder returnerar en Task.
    public async Task Start()
    {
        //Startar CountUp
        Console.WriteLine("Starting CountUp");
        CountUp();

        //Startar CountDown
        Console.WriteLine("Starting CountDown");
        CountDown();
        Console.WriteLine("Done");
    }

    public async Task CountUp()
    {
        //Hämta den aktuella tråden
        var thread = Thread.CurrentThread;
        for (int i = 0; i < 10; i++)
        {
            //Be tråden vänta 200ms (placeholder för en tidskrävande operation tex. ladda in en fil)
            //await bromsar operationen tills dess att det som står efter är klart
            await Task.Delay(200);
            Console.WriteLine($"Thread: {thread.Name}, CountUp: {i}");
        }
    }

    public async Task CountDown()
    {
        //Hämta den aktuella tråden
        var thread = Thread.CurrentThread;
        for (int i = 9; i >= 0; i--)
        {
            //Be tråden vänta 200ms (placeholder för en tidskrävande operation tex. ladda in en fil)
            //await bromsar operationen tills dess att det som står efter är klart
            await Task.Delay(200);
            Console.WriteLine($"Thread: {thread.Name}, CountDown: {i}");
        }
    }
}