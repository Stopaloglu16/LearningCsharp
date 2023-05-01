﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAndClasses
{

    public class StructSample
    {
        static void StructSampleMethod()
        {
            // Create  struct instance and initialize by using "new".
            // Memory is allocated on thread stack.
            PersonStruct p1 = new PersonStruct("Alex", 9);
            Console.WriteLine("p1 Name = {0} Age = {1}", p1.Name, p1.Age);

            // Create  new struct object. Note that  struct can be initialized
            // without using "new".
            PersonStruct p2 = p1;

            // Assign values to p2 members.
            p2.Name = "Spencer";
            p2.Age = 7;
            Console.WriteLine("p2 Name = {0} Age = {1}", p2.Name, p2.Age);

            // p1 values remain unchanged because p2 is  copy.
            Console.WriteLine("p1 Name = {0} Age = {1}", p1.Name, p1.Age);
        }
    }
    /*
        Output:
        p1 Name = Alex Age = 9
        p2 Name = Spencer Age = 7
        p1 Name = Alex Age = 9
    */

    public struct PersonStruct
    {
        public string Name;
        public int Age;
        public PersonStruct(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

   
}
