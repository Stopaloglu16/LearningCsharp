// See https://aka.ms/new-console-template for more information
using AsynchronousApp;
using System.Diagnostics;

Console.WriteLine("Hello, World!");


var timer = new Stopwatch();
timer.Start();

Console.WriteLine($"Start");

SynchronousBreakfast.Create();

timer.Stop();
Console.WriteLine("--==Finish " + timer.ElapsedMilliseconds + "==--");


timer.Restart();
Console.WriteLine($"Start Async");

await AsynchronousBreakfast.Create();

timer.Stop();
Console.WriteLine("--==Finish Async " + timer.ElapsedMilliseconds + "==--");




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