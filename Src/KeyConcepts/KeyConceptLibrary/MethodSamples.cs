namespace KeyConceptLibrary
{
    public abstract class Motorcycle
    {
        // Anyone can call this.
        public void StartEngine() {/* Method statements here */ }

        // Only derived classes can call this.
        protected void AddGas(int gallons) { /* Method statements here */ }

        // Derived classes can override the base class implementation.
        public virtual int Drive(int miles, int speed) { /* Method statements here */ return 1; }

        // Derived classes can override the base class implementation.
        public virtual int Drive(TimeSpan time, int speed) { /* Method statements here */ return 0; }

        // Derived classes must implement this.
        public abstract double GetTopSpeed();
    }

    public class TestMotorcycle : Motorcycle
    {
        public override int Drive(int miles, int speed)
        {
            return (int)Math.Round(((double)miles) / speed, 0);
        }

        public override double GetTopSpeed()
        {
            return 108.4;
        }

        static void CreateTestMotorcycle()
        {
            TestMotorcycle moto = new TestMotorcycle();

            moto.StartEngine();
            moto.AddGas(15);
            var travelTime = moto.Drive(speed: 60, miles: 170);
            double speed = moto.GetTopSpeed();
            Console.WriteLine("My top speed is {0}", speed);
        }
    }

    public class TupleExampleClass
    {

        public (string, string, string, int) GetPersonalInfo(string id)
        {
            PersonInfo per = PersonInfo.RetrieveInfoById(id);
            return (per.FirstName, per.MiddleName, per.LastName, per.Age);
        }

        public (string FName, string MName, string LName, int Age) GetPersonalInfo1(string id)
        {
            PersonInfo per = PersonInfo.RetrieveInfoById(id);
            return (per.FirstName, per.MiddleName, per.LastName, per.Age);
        }

    }

    internal class PersonInfo
    {

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        internal static PersonInfo RetrieveInfoById(string id)
        {
            throw new NotImplementedException();
        }
    }



    //public class ExpressionBodiedMembers
    //{

    //    protected string First { get; set; }
    //    protected string Last { get; set; }

    //    public Point Move(int dx, int dy) => new Point(x + dx, y + dy);
    //    public void Print() => Console.WriteLine(First + " " + Last);
    //    // Works with operators, properties, and indexers too.
    //    public static Complex operator +(Complex a, Complex b) => a.Add(b);
    //    public string Name => First + " " + Last;
    //    //public Customer this[long id] => store.LookupCustomer(id);

    //}


}