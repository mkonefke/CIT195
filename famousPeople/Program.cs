using System;
using System.Linq;

namespace FamousPeople
{
class famousPeople
    {
        public string Name { get; set; }
        public int? BirthYear { get; set; } = null;
        public int? DeathYear { get; set; } = null;
    }
    class Program
    {
    public static void Main()
	{
     IList < famousPeople > stemPeople = new List < famousPeople >() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
     };
            var queryA = from person in stemPeople
                         where person.BirthYear > 1900
                         select person;

            Console.WriteLine("Famous people with birthdates after 1900:");
            foreach (var person in queryA)
            {
                Console.WriteLine($"{person.Name} - Born: {person.BirthYear}");
            }
            
            var queryB = from person in stemPeople
                         where person.Name.Count(c => c == 'l') >= 2
                         select person;

            Console.WriteLine("Famouse people with two lowercase 'l's in their name:");
            foreach (var person in queryB)
            {
                Console.WriteLine($"{person.Name}");
            }
            
            var queryC = from person in stemPeople
                         where person.BirthYear > 1950
                         select person;

            int countC = queryC.Count();

            Console.WriteLine("Famouse people born after 1950: " + countC);
            
            var queryD = from person in stemPeople
                         where person.BirthYear >= 1920
                         where person.BirthYear <= 2000
                         select person;

            int countD = queryD.Count();

            Console.WriteLine("Famous people born between 1920 and 2000:");
            foreach (var person in queryD)
            {
                Console.WriteLine($"{person.Name} - Born: {person.BirthYear}");
            }
            Console.WriteLine("Total Count: " + countD);
            
            var queryE = from person in stemPeople
                         orderby person.BirthYear
                         select person;

            Console.WriteLine("Famous people sorted by BirthYear:");
            foreach (var person in queryE)
            {
                Console.WriteLine($"{person.Name} - Born: {person.BirthYear}");
            }

            var queryF = from person in stemPeople
                         where person.DeathYear > 1960
                         where person.DeathYear < 2015
                         orderby person.Name
                         select person;

            Console.WriteLine("Famous people who died between 1960 and 2015, sorted by name:");
            foreach (var person in queryF)
            {
                Console.WriteLine($"{person.Name} - Died: {person.DeathYear}");
            }
        }
    }
}   