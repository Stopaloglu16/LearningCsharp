namespace FundamentalsConsoleApp.SampleClasses
{
    public delegate Small covarDel(Big mc);

    /// <summary>
    /// Delegates allows flexiblity in the return type of delegate methods
    /// </summary>
    public class CovarianceSample
    {
        public static Big Method1(Big bg)
        {
            Console.WriteLine("Method1");
            return new Big() { Id = 1 };
        }

        public static Small Method2(Big bg)
        {
            Console.WriteLine("Method2");
            return new Small() { Id = 2 };
        }

        public static Bigger Method3(Big bg)
        {
            Console.WriteLine("Method3");
            return new Bigger() { Id = 3 };
        }

        public static void Main()
        {

            covarDel del = Method1;
            Small sm1 = del(new Big());
            Console.WriteLine(sm1.Id);

            del = Method2;
            Small sm2 = del(new Big());
            Console.WriteLine(sm2.Id);

            del = Method3;
            Small sm3 = del(new Big());
            Console.WriteLine(sm3.Id);
        }
    }

    public class Small
    {
        public int Id;
    }
    public class Big : Small
    {
    }
    public class Bigger : Big
    {
    }
}
