using AsyncLiveDemo;

//Instansiera Den counter du vill köra Counter/AsyncCounter/ParallelCounter
var counter = new Counter();
//var counter = new AsyncCounter();
//var counter = new ParallelCounter();

//Hämta den aktuella tråden och ge den namnet main
var main = Thread.CurrentThread;
main.Name = "main";

//Kör Start
counter.Start();

//Skriv ut namnet på den aktuella tråden
Console.WriteLine(Thread.CurrentThread.Name);

//Finns bara här för att programmet ska vänta
Console.ReadLine();