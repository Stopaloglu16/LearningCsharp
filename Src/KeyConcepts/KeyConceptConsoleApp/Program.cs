// See https://aka.ms/new-console-template for more information
using NullableLibrary;

Console.WriteLine("Hello, World!");


CreateNullable createNullable = new CreateNullable();
var newPerson = createNullable.CreatePerson();

Console.WriteLine(newPerson.firstname?.ToString());
Console.WriteLine(newPerson.surname?.ToString());
Console.WriteLine(newPerson.age.ToString());
Console.WriteLine(newPerson.department.ToString());

