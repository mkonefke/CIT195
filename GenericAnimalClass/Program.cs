using System;
    public class Animal < T >
    {
        public T data;

        public Animal(T data)
        {   
            this.data = data;
            Console.WriteLine("Animal: " + this.data);
        }
        public T getAnimal()
        {
            return data;
        }
    }
class Program
{
    static void Main()
    {
        Animal < string > animalName = new Animal < string >("Lion");
        Animal < string > animalHabitat = new Animal < string >("Lions habitats are found in the savannas of sub-Saharan Africa");
        Animal < bool > endangered = new Animal < bool >(false);
        Animal < bool > extinct = new Animal < bool >(false);
        Animal < int > averageLifespan = new Animal < int >(10);
        
        Console.WriteLine("Animal Name: " + animalName.getAnimal());
        Console.WriteLine("Animal Habitat: " + animalHabitat.getAnimal());
        Console.WriteLine("Endangered: " + endangered.getAnimal());
        Console.WriteLine("Extinct: " + extinct.getAnimal());
        Console.WriteLine("Average Lifespan: " + averageLifespan.getAnimal() + " years");
    }
}
