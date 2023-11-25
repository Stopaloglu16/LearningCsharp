// See https://aka.ms/new-console-template for more information
using ConsoleAppFileDirectories.Methods;



string filesFolder = @"C:\Users\" + Environment.UserName + @"\source\repos\LearningCsharp\Src\Linq\ConsoleAppFileDirectories\Files\";

//Find all files that have a specified file name extension (for example ".txt") in a specified directory tree.
//It also shows how to return either the newest or oldest file
//FindFileByExtension.Create(filesFolder);


//Advanced grouping and sorting operations on lists of files or folders.
//It also shows how to page output in the console window by using the Skip and Take methods.
//GroupByExtension.Create(filesFolder);


ReadCsvFile.Create(filesFolder);