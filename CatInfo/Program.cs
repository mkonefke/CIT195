using System;

namespace bigCats
{
    public abstract class BigCat
    {
        public abstract string Type { get; set; }
        public abstract string Location { get; set; }

        public BigCat(string type, string location)
        {
            Type = type;
            Location = location;
        }

        public abstract void DisplayInfo();
    }
    class Program
    {
    public class BigCat : Lion
    {
        public string Color { get; set; }

        public BigCat(string type, string location, string color) : base(type, location)
        {
            Color = color;
        }
        public override string DisplayInfo()
        {
            return "I am a " + Type + "\nI live in " + Location;
        }
    }
  
        static void Main(string[] args)
        {

            BigCat tiger = new BigCat("Tiger", "Jungle", "Orange and black");
            tiger.DisplayInfo();

            Console.ReadLine();
        }
    }
}