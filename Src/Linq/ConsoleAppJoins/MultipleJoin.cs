using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppJoins
{
    public class MultipleJoin
    {
        public static void Create()
        {

            Person magnus = new(FirstName: "Magnus", LastName: "Hedlund");
            Person terry = new("Terry", "Adams");
            Person charlotte = new("Charlotte", "Weiss");
            Person arlene = new("Arlene", "Huff");
            Person rui = new("Rui", "Raposo");
            Person phyllis = new("Phyllis", "Harris");

            List<Person> people = [magnus, terry, charlotte, arlene, rui, phyllis];

            List<Cat> cats =
            [
                new(Name: "Barley", Owner: terry),
                new("Boots", terry),
                new("Whiskers", charlotte),
                new("Blue Moon", rui),
                new("Daisy", magnus),
            ];

            List<Dog> dogs =
            [
                new(Name: "Four Wheel Drive", Owner: phyllis),
                new("Duke", magnus),
                new("Denim", terry),
                new("Wiley", charlotte),
                new("Snoopy", rui),
                new("Snickers", arlene),
            ];

            // The first join matches Person and Cat.Owner from the list of people and
            // cats, based on a common Person. The second join matches dogs whose names start
            // with the same letter as the cats that have the same owner.
            var query =
                from person in people
                join cat in cats on person equals cat.Owner
                join dog in dogs on new
                {
                    Owner = person,
                    Letter = cat.Name.Substring(0, 1)
                } equals new
                {
                    dog.Owner,
                    Letter = dog.Name.Substring(0, 1)
                }
                select new
                {
                    CatName = cat.Name,
                    DogName = dog.Name
                };

            //Or
            //var query = people.Join(cats,
            //person => person,
            //cat => cat.Owner,
            //(person, cat) => new { person, cat })
            //.Join(dogs,commonOwner => new { Owner = commonOwner.person, Letter = commonOwner.cat.Name.Substring(0, 1) },
            //dog => new { dog.Owner, Letter = dog.Name.Substring(0, 1) },
            //(commonOwner, dog) => new { CatName = commonOwner.cat.Name, DogName = dog.Name });

            string result = "";
            foreach (var obj in query)
            {
                result += $"The cat \"{obj.CatName}\" shares a house, and the first letter of their name, with \"{obj.DogName}\".\r\n";
            }
            Console.Write(result);
            //return result;

            /* Output:
                 The cat "Daisy" shares a house, and the first letter of their name, with "Duke".
                 The cat "Whiskers" shares a house, and the first letter of their name, with "Wiley".
             */
        }

    }
}
