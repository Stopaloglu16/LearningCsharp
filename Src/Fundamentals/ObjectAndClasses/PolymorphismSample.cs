namespace ObjectAndClasses
{
    public class PolymorphismSample
    {
        public static void PolymorphismSampleMethod()
        {
            // Polymorphism at work #1: a Rectangle, Triangle and Circle
            // can all be used wherever a Shape is expected. No cast is
            // required because an implicit conversion exists from a derived
            // class to its base class.
            var shapes = new List<Shape>
            {
                new Rectangle("Yellow"),
                new Triangle("Red"),
                new Circle("Blue"),
                new RightAngled("Orange")
            };

            // Polymorphism at work #2: the virtual method Draw is
            // invoked on each of the derived classes, not the base class.
            foreach (var shape in shapes)
            {
                shape.Draw();
                shape.Paint();
            }

        }
    }


    public class Shape
    {
        public Shape(string? colourName)
        {
            ColourName = colourName;
        }

        // A few example members
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string? ColourName { get; set; }

        // Virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }

        public virtual void Paint()
        {
            Console.WriteLine("Paint to " + ColourName);
        }
    }

    public class Circle : Shape
    {
        public Circle(string? colourName) : base(colourName)
        {
        }

        public override void Draw()
        {
            // Code to draw a circle...
            Console.WriteLine("Drawing a circle");
            base.Draw();
        }
    }
    public class Rectangle : Shape
    {
        public Rectangle(string? colourName) : base(colourName)
        {
        }

        public override void Draw()
        {
            // Code to draw a rectangle...
            Console.WriteLine("Drawing a rectangle");
            base.Draw();
        }
    }
    public class Triangle : Shape
    {
        public Triangle(string? colourName) : base(colourName)
        {
        }

        public override void Draw()
        {
            // Code to draw a triangle...
            Console.WriteLine("Drawing a triangle");
            base.Draw();
        }

        public sealed override void Paint()
        {
            Console.WriteLine("No Colour ");
        }
    }


    public class Equilateral : Triangle
    {
        public Equilateral(string? colourName) : base(colourName)
        {
        }
    }

    public class RightAngled : Triangle
    {
        public RightAngled(string? colourName) : base(colourName)
        {
        }

        public override void Draw()
        {
            // Code to draw a rectangle...
            Console.WriteLine("Drawing a RightAngled");
            base.Draw();
        }

        public new void Paint()
        {
            Console.WriteLine("Paint to " + ColourName);
            base.Paint();


        }
    }

}
