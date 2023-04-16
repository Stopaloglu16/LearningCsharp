// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!" + DateTime.MinValue);


// Declare variable and assign it as null.
FooBar fooBar = null;

// Conditionally dereference variable.
var str = fooBar?.ToString();
Console.Write(str);

// The FooBar type definition.
record FooBar(int Id, string Name);

