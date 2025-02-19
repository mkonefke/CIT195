using System;
namespace Club
{
    interface IClub
{
    //Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //Methods
    public string Fullname();
}
        class Premium : IClub
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Rewards { get; set; }
            public DateTime MembershipDate { get; set; }

            public Premium()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
                Rewards = 0;
                MembershipDate = DateTime.Now;
            }
            public Premium(int id, string firstName, string lastName, double rewards, DateTime membershipDate)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Rewards = rewards;
                MembershipDate = membershipDate;
            }

            public string Fullname()
            {
                return FirstName + " " + LastName;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"ID: {Id}");
                Console.WriteLine($"Rewards: {Rewards}");
                Console.WriteLine($"Membership Start: {MembershipDate}");
            }
        static void Main(string[] args)
        {
            // Worker object created using parameterized constructor
            Premium dean = new Premium(3,"Dean","Smith",245,new DateTime(2024, 12, 22));
            Console.WriteLine(dean.Fullname());
            dean.DisplayInfo();

       
            Premium jake = new Premium();
            jake.Id = 20;
            jake.FirstName = "Jake";
            jake.LastName = "Gill";
            jake.Rewards = 40;
            jake.MembershipDate = new DateTime(2025, 1, 15);
            Console.WriteLine(jake.Fullname());
            jake.DisplayInfo();

        }
    }
 }
