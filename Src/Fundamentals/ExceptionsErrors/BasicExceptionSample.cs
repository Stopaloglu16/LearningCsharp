using System;
using System.Net.WebSockets;

namespace ExceptionsErrors
{
    public class BasicExceptionSample
    {
        public static void SampleMethod()
        {
            try
            {
                //ExceptionSample1
                ExceptionSample1 exceptionSample1 = new ExceptionSample1();
                var myRtn1 = exceptionSample1.ExcFunction();

                Console.WriteLine(myRtn1);

                //ExceptionSample2
                ExceptionSample2 exceptionSample2 = new ExceptionSample2();
                var myRtn2 = exceptionSample2.ExcFunction();

                Console.WriteLine(myRtn2);
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.FunctionName);
                Console.WriteLine("StackTrace " + ex.StackTrace);
                Console.WriteLine("Message " + ex.Message);
                //Console.WriteLine("Message " + ex.pa);
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



    public class ExceptionSample1
    {
        public string ExcFunction()
        {
            try
            {
                return "sucess 1 ";
            }
            catch (Exception ex)
            {
                throw new InvalidProgramException("failed 1");
            }
            finally
            {
                //Error CS0157  Control cannot leave the body of a finally clause 
                //return "final"; 
                Console.WriteLine("final touch 1");
            }
        }
    }


    public class CustomException : Exception
    {
        public string FunctionName { get; set; }

        public CustomException(string message, string name)
        {
            FunctionName = name;
        }

        public CustomException(string message, Exception innerexception) : base(message, innerexception)
        {
        }
    }


    public class ExceptionSample2
    {
        public string ExcFunction()
        {
            try
            {
                int[] array = { 1, 2, 3 };

                Console.WriteLine(array[10]);

                return "sucess 2";
            }
            catch (Exception ex)
            {
                throw new CustomException("failed 2", "ExceptionSample2");
            }
            finally
            {
                //Error CS0157  Control cannot leave the body of a finally clause 
                //return "final"; 
                Console.WriteLine("final touch 2");
            }
        }
    }

}