// See https://aka.ms/new-console-template for more information
using AsynchronousApp;

Console.WriteLine("Hello, World!");

//Console.WriteLine($"Start {DateTime.Now}");

//SynchronousBreakfast.Create();

//Console.WriteLine($"Finish {DateTime.Now}");


//Console.WriteLine($"Start Async {DateTime.Now}");

//await AsynchronousBreakfast.Create();

//Console.WriteLine($"Finish Async {DateTime.Now}");



await ProcessAsync.SumPageSizesAsync();
