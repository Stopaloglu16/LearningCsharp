using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAndClasses
{
    public class AnonymousTypeSample
    {
        public static void AnonymousTypeSampleMethod()
        {
            var product = new Product("Table");
            var bonus = new { note = "You won!" };
            var shipment = new { address = "Nowhere St.", product };
            var shipmentWithBonus = new { address = "Somewhere St.", product, bonus };

            //product.Name -> Error	CS0746 Invalid anonymous type member declarator. Anonymous type members must be declared with a member assignment, simple name or member access.	
            //var shipmentWithBonus1 = new { address = "Somewhere St.", product.Name = "chair", bonus };

            Console.WriteLine(shipmentWithBonus.product.Name);


            //Creatint a new instance of an anonymous type where one/more properties have new values
            var apple = new { Item = "apples", Price = 1.35 };
            var onSale = apple with { Price = 0.79 };
            Console.WriteLine(apple);
            Console.WriteLine(onSale);

        }
    }

    internal class Product
    {
        public Product(string _Name )
        {
            Name = _Name;
        }

        public string Name { get; set; }

    }

}
