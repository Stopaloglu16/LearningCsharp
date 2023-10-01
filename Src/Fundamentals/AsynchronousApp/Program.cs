// See https://aka.ms/new-console-template for more information
using AsynchronousApp;

Console.WriteLine("Hello, World!");

//Console.WriteLine($"Start {DateTime.Now}");

//SynchronousBreakfast.Create();

//Console.WriteLine($"Finish {DateTime.Now}");


Console.WriteLine($"Start Async {DateTime.Now}");

await AsynchronousBreakfast.Create();

Console.WriteLine($"Finish Async {DateTime.Now}");



//await ProcessAsync.SumPageSizesAsync();


//CancellationTokenSource s_cts = new CancellationTokenSource();

//AsyncSandbox asyncSandbox = new AsyncSandbox();

//Task cancelTask = Task.Run(() =>
//{
//    while (Console.ReadKey().Key != ConsoleKey.Enter)
//    {
//        Console.WriteLine("Press the ENTER key to cancel...");
//    }

//    Console.WriteLine("\nENTER key pressed: cancelling downloads.\n");
//    s_cts.Cancel();
//});



//Task startSandboxTask = asyncSandbox.StartSandbox(s_cts.Token);

//Task finishedTask = await Task.WhenAny(new[] { cancelTask, startSandboxTask });

//if (finishedTask == cancelTask)
//{
//    // wait for the cancellation to take place:
//    try
//    {
//        await startSandboxTask;
//        Console.WriteLine("Task completed before cancel request was processed.");
//    }
//    catch (TaskCanceledException)
//    {
//        Console.WriteLine("Download task has been cancelled.");
//    }
//}