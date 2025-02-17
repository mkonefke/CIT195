using System;

namespace Inheritance
{
    // base Class 
    class Animal
    {
        private string name; // only accessible within this class
        protected string type; //accessible from derived classes
        public string color;  // accessible from any class

        public void setName(string name)
        {
            this.name = name;
        }
        public virtual string getName() 
        { 
            return this.name; 
        }
        public void setType(string type) 
        { 
            this.type = type; 
        }
        public virtual string getType() 
        { 
            return this.type;
        }
    }
    class Bear : Animal
    {
        public string type;
        public int age;
        public double weight;

        public override string getType()
        {
            return type;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public virtual int getAge()
        {
            return age;
        }
        public void setWeight(double weight)
        {
            this.weight = weight;
        }
        public virtual double getWeight()
        {
            return weight;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Animal critter = new Animal();
            critter.setName("Doug");
            critter.setType("giraffe");
            critter.color = "tan with brown spots";

            Console.WriteLine("Animal Information...");
            Console.WriteLine($"My name is {critter.getName()}");
            Console.WriteLine($"I am a {critter.getType()}");
            Console.WriteLine($"I am a lovely {critter.color} color");
            Console.WriteLine();

            Bear beast = new Bear();
            beast.setName("Beast");
            beast.setType("Brown Bear");
            beast.weight= 250;
            beast.setAge(4);

            Console.WriteLine("Bear Information...");
            Console.WriteLine($"My name is {beast.getName()}");
            Console.WriteLine($"I weigh {beast.weight}");
            Console.WriteLine($"I am {beast.getAge()} years old");

            Console.ReadLine();
        }
    }
}