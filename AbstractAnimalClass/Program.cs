using System;
namespace Animals
{
    abstract class Animal
    {
        // Property
        public abstract string Name { get; set; }
        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }
    class Program
    {
        class Monkey : Animal
        {
            // override the abstract property
            public override string Name { get; set; }
            public string Type{ get; set; }
            public int Weight {get; set;}

            public Monkey()
            {
                Name = string.Empty;
                Type = string.Empty;
                Weight = 0;
            }
            public Monkey(string name, string type, int weight)
            {
                Name = name;
                Type = type;
                Weight = weight;
            }
            // override the abstract method
            public override string Describe()
            {
                return "I am a " + Type + "\nMy name is " + Name;
            }

        }
        static void Main(string[] args)
        {
            Monkey gorilla = new Monkey();
            gorilla.Name = "Sam";
            gorilla.Type = "Gorilla";
            gorilla.Weight = 300;
            Console.WriteLine(gorilla.whatAmI());
            Console.WriteLine(gorilla.Describe());
        }
    }
}