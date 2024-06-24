// See https://aka.ms/new-console-template for more information
using AdvancedTopics.ExpressionTrees;




while (true)
{
    Console.WriteLine("\n\nWhich topic to run?");
    Console.WriteLine("Attributes 1\n" +
                      "Expression Trees 2");

    var myAnswer = Console.ReadLine();

    Console.Clear();

    if (Convert.ToInt32(myAnswer) == 0)
    {
        break;
    }
    else if (Convert.ToInt32(myAnswer) == 1)
    {

    }
    else if (Convert.ToInt32(myAnswer) == 2)
    {
        ExpresstionTree1 expresstionTree1 = new ExpresstionTree1();
        //expresstionTree1.lambda;
        ExpresstionTree1.ShowLambda();

        ExpresstionTree1.ExecuteExpression();
    }

}

