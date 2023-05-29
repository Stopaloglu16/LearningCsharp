namespace ExceptionsErrors
{

    public class ArgumentExceptionSample
    {
        public static void SampleMethod()
        {
            try
            {
                //ExceptionSample1
                ExceptionSample3 exceptionSample3 = new ExceptionSample3();
                var myRtn1 = exceptionSample3.ExcFunction(55);

                Console.WriteLine(myRtn1);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("StackTrace " + ex.StackTrace);
                Console.WriteLine("======================== ");
                Console.WriteLine("Message " + ex.Message);
                Console.WriteLine("ParamName " + ex.ParamName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }



    public class ExceptionSample3
    {
        public string ExcFunction(int num)
        {

            throw new ArgumentException(String.Format("{0} is not an even number", num), "num");

        }
    }
}
