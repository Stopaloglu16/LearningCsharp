// See https://aka.ms/new-console-template for more information
using WhereIfDemo;

Console.WriteLine("Hello, WhereIf!");

Console.WriteLine("It calls the WhereIf when the filter been value, it activates");

WhereIfFilter whereIfFilter = new WhereIfFilter();

var myList = Model.CreateParcelList();
whereIfFilter.PrintList(myList.ToList());


Console.WriteLine("Enter country Id");
var countryId = Console.ReadLine();

Console.WriteLine("Enter min weight");
var minWeight = Console.ReadLine();

Console.WriteLine("Enter max weight");
var maxWeight = Console.ReadLine();


whereIfFilter.CountryId = Convert.ToInt32(countryId);
whereIfFilter.MinWeight = Convert.ToInt32(minWeight);
whereIfFilter.MaxWeight = Convert.ToInt32(maxWeight);

var filterList = whereIfFilter.FilterList(myList, whereIfFilter);
whereIfFilter.PrintList(filterList);

Console.WriteLine("Done");
