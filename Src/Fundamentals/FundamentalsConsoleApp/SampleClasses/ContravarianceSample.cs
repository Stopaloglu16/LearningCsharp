namespace FundamentalsConsoleApp.SampleClasses
{
    delegate Small covarDel2(Big mc);

    /// <summary>
    /// A method with the parameter of a base class to be assigned to a delegate that expects the parameter of a derived class.
    /// </summary>
    public class ContravarianceSample
    {
        static Big Method1(Big bg)
        {
            Console.WriteLine("Method1");
            return new Big();
        }
        static Small Method2(Big bg)
        {
            Console.WriteLine("Method2");
            return new Small();
        }

        static Small Method3(Small sml)
        {
            Console.WriteLine("Method3");

            return new Small();
        }

        /// <summary>
        /// Covariance and contravariance at same time
        /// </summary>
        /// <param name="sml"></param>
        /// <returns></returns>
        static Big Method4(Small sml)
        {
            Console.WriteLine("Method4");

            return new Big();
        }

        public static void Main()
        {
            covarDel2 del = Method1;
            del += Method2;
            del += Method3;
            del += Method4;

            Small sm = del(new Big());
        }
    }
}
