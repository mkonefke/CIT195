using System;
using System.Drawing;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;
        public string color;
        public double weight;

        // constructor
        public Animal()
        {
            name = "";
            color = "";
            weight = 0;

        }
        public Animal(string name, string color, double weight)
        {
            this.name = name;
            this.color = color;
            this.weight = weight;
        }
        public void displayCatInfo()
        {
            Console.WriteLine($"Cat Information");
        }
        public void displayFishInfo()
        {
            Console.WriteLine($"Fish Information");
        }
    }

    // derived class of Animal 
    class Cat : Animal
    {
        public double age;
        public string color;
        public double weight;

        // constructor
        public Cat()
            :base()  // calls the Animal class constructor
        {           
            age = 0; 
            color = "";
            weight = 0;
        }
        //parameterized constructor
        public Cat(double age, string name, string color, double weight)
            :base(name,color,weight)
        {
            this.age = age;
            this.color = color;
            this.weight = weight;
        }
        public void getName()
        {
            Console.WriteLine($"Name:{name}");
        }
        public void getColor()
        {
            Console.WriteLine($"Color:{color}");
        }
        public void getAge()
        {
            Console.WriteLine($"Age:{age}");
        }
        public void getWeight()
        {
            Console.WriteLine($"Weight:{weight}");
        }
    }
    class Fish : Animal
    {
        public double age;
        public string color;
        public double weight;

        // constructor
        public Fish()
            :base()  // calls the Animal class constructor
        {           
            age = 0; 
            color = "";
            weight = 0;
        }
    public Fish(double age, string name, string color, double weight)
            :base(name,color,weight)
        {
            this.age = age;
            this.color = color;
            this.weight = weight;
        }
    public void getName()
        {
            Console.WriteLine($"Name:{name}");
        }
        public void getColor()
        {
            Console.WriteLine($"Color:{color}");
        }
        public void getAge()
        {
            Console.WriteLine($"Age:{age}");
        }
        public void getWeight()
        {
            Console.WriteLine($"Weight:{weight}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Jinx";
            myPet.color = "Black";
            myPet.displayCatInfo();

            Cat myCat = new Cat();
            myCat.age = 0.5;
            myCat.weight = 2.0;
            myCat.getName();
            myCat.getAge();
            myCat.getWeight();
            myCat.displayCatInfo();

            Fish myFish = new Fish();
            myFish.age = 0.5;
            myFish.weight = 2.0;
            myFish.getName();
            myFish.getAge();
            myFish.getWeight();
            myFish.displayFishInfo();

            //derived class object using parameterized constructor
            Cat daisy = new Cat(5, "Daisy", "Orange", 30);
            daisy.displayCatInfo();

            Fish fred = new Fish(2, "Fred", "Blue", 2);
            daisy.displayFishInfo();
        }

    }
}