// See https://aka.ms/new-console-template for more information
using NullableLibrary;

Console.WriteLine($"Hello, World!");

//CreateNullable createNullable = new CreateNullable();
//var newPerson = createNullable.CreatePerson();

//Console.WriteLine(newPerson.firstname?.ToString());
//Console.WriteLine(newPerson.surname?.ToString());
//Console.WriteLine(newPerson.age.ToString());
//Console.WriteLine(newPerson.department.ToString());

Employee employee = new Employee();

var rr =  Employee.Sum(5, 7);

employee.FullName = null;



Console.WriteLine(employee.FullName?.Firstname ?? "not found");





public class Employee
{
    public FullName FullName { get; set; }

    public static string Sum(int x, int y)
    {
        return $"x+y= {x + y}";
    }
}

public class FullName
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
}