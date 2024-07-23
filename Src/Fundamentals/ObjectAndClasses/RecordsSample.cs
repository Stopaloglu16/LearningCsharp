namespace ObjectAndClasses
{

    public class RecordsSample
    {
        public static void RecordsSampleMethod()
        {
            Person person1 = new("Nancy", "Davolio", "123") { PhoneNumbers = new string[1] };
            Console.WriteLine(person1);
            // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }

            Console.WriteLine(person1.Id);


            Person person2 = person1 with { FirstName = "John" };
            Console.WriteLine(person2);
            // output: Person { FirstName = John, LastName = Davolio, PhoneNumbers = System.String[] }
            Console.WriteLine(person1 == person2); // output: False

            person2 = person1 with { PhoneNumbers = new string[1] };
            Console.WriteLine(person2);
            // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }
            Console.WriteLine(person1 == person2); // output: False

            person2 = person1 with { };
            Console.WriteLine(person1 == person2); // output: True
        }


        public static void RecordsPersonCreate()
        {
            Person person1 = new("Nancy", "Davolio", "123") { PhoneNumbers = new string[1] };
            Console.WriteLine(person1);

            //person1.FirstName = "Sertac"; Error!!!
            //Error CS8852  Init - only property or indexer 'Person.FirstName' can only be assigned in an object initializer,
            //or on 'this' or 'base' in an instance constructor or an 'init' accessor.ObjectAndClasses

            person1.Salary = 1;
        }


        public static void RecordsStudentCreate()
        {
            Person person1 = new("Nancy", "Davolio", "123") { PhoneNumbers = new string[1] };
            Console.WriteLine(person1);

            Student student = new("Nancy", "Davolio", "124");

            Console.WriteLine(student);
            student.Salary = 6;

            Console.WriteLine(student == person1);

            student.Grade = 5;
            Console.WriteLine(student);
        }

    }

    internal record Person(string FirstName, string LastName, string Id)
    {
        public string[] PhoneNumbers { get; init; }
        public double Salary { get; set; }
        internal string Id { get; init; } = Id;
    }


    internal record Student : Person
    {
        public Student(string FirstName, string LastName, string Id) : base(FirstName, LastName, Id)
        {
        }

        public double Grade { get; set; }

    }

}
