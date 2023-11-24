// See https://aka.ms/new-console-template for more information
using ConsoleAppWalkthrough;
using static ConsoleAppWalkthrough.Students;


Console.WriteLine("--==Create the query==--");

// The first line could also be written as "var studentQuery ="
IEnumerable<Student> studentQuery =
    from student in Students.students
    where student.Scores[0] > 90 && student.Scores[3] < 80
    //orderby student.Last ascending
    orderby student.Scores[0] descending
    select student;

foreach (Student student in studentQuery)
{
    Console.WriteLine("{0}, {1}", student.Last, student.First);
}


Console.WriteLine("--==To group the results==--");

IEnumerable<IGrouping<char, Student>> studentQuery2 =
    from student in students
    group student by student.Last[0];

foreach (IGrouping<char, Student> studentGroup in studentQuery2)
{
    Console.WriteLine(studentGroup.Key);
    foreach (Student student in studentGroup)
    {
        Console.WriteLine("   {0}, {1}",
                  student.Last, student.First);
    }
}


Console.WriteLine("--==To order the group==--");

var studentQuery4 =
    from student in students
    group student by student.Last[0] into studentGroup
    orderby studentGroup.Key
    select studentGroup;

foreach (var groupOfStudents in studentQuery4)
{
    Console.WriteLine(groupOfStudents.Key);
    foreach (var student in groupOfStudents)
    {
        Console.WriteLine("   {0}, {1}",
            student.Last, student.First);
    }
}


Console.WriteLine("--==Those students whose first test score " +
                  "was higher than their average score==--");


var studentQuery5 =
    from student in students
    let totalScore = student.Scores[0] + student.Scores[1] +
        student.Scores[2] + student.Scores[3]
    where totalScore / 4 < student.Scores[0]
    select student.Last + " " + student.First;

foreach (string s in studentQuery5)
{
    Console.WriteLine(s);
}