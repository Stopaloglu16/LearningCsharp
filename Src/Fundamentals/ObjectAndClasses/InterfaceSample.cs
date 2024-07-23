namespace ObjectAndClasses
{
    public class InterfaceSample
    {
        public static void InterfaceSampleMethod()
        {
            Car car = new Car();

            var daysCount = car.ColllectionDays(car);

            Console.WriteLine("days " + daysCount.ToString()); ;
        }
    }

    interface IEquatable<T>
    {
        bool Equals(T obj);

    }

    interface ICollection<T>
    {
        int ColllectionDays(T obj)
        {
            Console.WriteLine("0");
            return 0;
        }
    }

    public class Car : IEquatable<Car>, ICollection<Car>
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? Year { get; set; }

        // Implementation of IEquatable<T> interface
        public bool Equals(Car? car)
        {
            return (this.Make, this.Model, this.Year) ==
                   (car?.Make, car?.Model, car?.Year);
        }

        // Implementation of ICollection<T> interface
        public int ColllectionDays(Car car)
        {
            Console.WriteLine("5");
            return 5;
        }

    }




}
