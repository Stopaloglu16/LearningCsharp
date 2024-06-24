namespace IntroductionSamples
{
    public class EnumSamples
    {
        public static void Create()
        {
            //var turnip = SomeRootVegetable.Turnip;

            //var spring = Seasons.Spring;
            //var startingOnEquinox = Seasons.Spring | Seasons.Autumn;
            //var theYear = Seasons.All;

            //Console.WriteLine(turnip);
            //Console.WriteLine(spring);
            //Console.WriteLine(startingOnEquinox);
            //Console.WriteLine(theYear);


            var test = AllowedPaymentSchemes.Bacs;
            Console.WriteLine(test);
        }
    }

    public enum SomeRootVegetable
    {
        HorseRadish,
        Radish,
        Turnip
    }

    [Flags]
    public enum Seasons
    {
        None = 0,
        Summer = 1,
        Autumn = 2,
        Winter = 4,
        Spring = 8,
        All = Summer | Autumn | Winter | Spring
    }


    public enum AllowedPaymentSchemes
    {
        FasterPayments = 1 << 0,
        Bacs = 1 << 1,
        Chaps = 1 << 2
    }
}
