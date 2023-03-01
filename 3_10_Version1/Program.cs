//make two classes that uses get and set. One using the proper syntax and one that uses short hand

using System;

namespace task_3_10
{
    internal class Dog
    {
        private string name;
        //private int age;
        //private string test;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }

    internal class Cat
    {
        //a private string "name" makes no difference here, does it not have encapulation?
        public string Name
        {
            get; set;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog obj1 = new Dog();

            obj1.Name = "Fido";

            Console.WriteLine($"The dog's name is {obj1.Name}");


            Cat obj2 = new Cat();

            obj2.Name = "Morris";

            Console.WriteLine($"The cat's name is {obj2.Name}");


        }
    }
}
