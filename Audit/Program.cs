using System.ComponentModel.DataAnnotations;

namespace Audit
{
    class Auditor
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }
    class Business
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public Auditor Auditor { get; set; }
        
        public void DisplayBusiness()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Auditor Information");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Phone: " + Number);
            Console.WriteLine("Business Information");
            Console.WriteLine("Name: " + Business.Name);
            Console.WriteLine("Type: " + Business.Type);
            Console.WriteLine("Address: " + Business.Address);
            Console.WriteLine("Auditor: " + Business.Auditor);
            Console.ResetColor();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Auditor auditor = new Auditor
            {
                Name = "Smith",
                Number = "231-444-2343",
            };
      
            Business business = new Business
            {
                Name = "Marvin's",
                Type = "Grocery Store",
                Address = "922 8th Street , Traverse City, MI 49686",
                Auditor = auditor
            };
            business.DisplayBusiness();
        }
    }
}