using System.Linq.Expressions;

namespace AdvancedTopics.ExpressionTrees
{
    public class ExpresstionTree1
    {
        public static Expression<Func<int, bool>> lessthanfive = num => num < 5;

        /// <summary>
        /// Prints the name of a variable for a variable access expression.
        /// The following code shows the practice of checking the node type, 
        /// then casting to a variable access expression and then checking the properties of the specific expression type
        /// </summary>
        public static void ShowLambda()
        {
            if (lessthanfive is LambdaExpression lambdaExp)
            {
                var parameter = lambdaExp.Parameters[0]; //first

                Console.WriteLine(parameter.Name);
                Console.WriteLine(parameter.Type);
            }
        }

        public static void ExecuteExpression()
        {
            // Compiling the expression tree into a delegate.
            Func<int, bool> result = lessthanfive.Compile();

            // Invoking the delegate and writing the result to the console.
            Console.WriteLine(result(4)); // Prints True.

            // You can also use simplified syntax to compile and run an expression tree.
            // The following line can replace two previous statements.
            Console.WriteLine(lessthanfive.Compile()(4));  // Also prints True.
        }

    }
}
