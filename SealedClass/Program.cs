using System;
namespace Employees
{
    interface IEmployee
    {
    //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    //Methods
        public string Fullname();
        public double Pay();
    }
    class Employee : IEmployee
    {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Employee()
    {
        Id = 0;
        FirstName = string.Empty;
        LastName = string.Empty;
    }
    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
    public string Fullname()
    {
        return FirstName + " " + LastName;
    }
    public virtual double Pay()
    {
        double salary;
        Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
        salary = double.Parse(Console.ReadLine());
        return salary;
    }
    sealed class Executive : Employee
    {
        public string Title{get;set;}
        public double Salary{get;set;}

        public Executive() : base()
        {
            Title = string.Empty;
            Salary = 0;
        }
        public Executive(int id, string firstName, string lastName, string title, double salary, int v)
        : base(id, firstName, lastName)
        {
        Title = title;
        Salary = salary;
        }
        public override double Pay()
        {
        double salary;
        salary = double.Parse(Console.ReadLine());
        return salary;
        }
    }
    
     class Program
    {
        static void Main(string[] args)
        {
            Employee jane = new Employee(25, "Jane", "Doe");
            jane.Pay();

            Executive bill = new Executive(45, "Bill", "Green", "GM", 90,000);
            Console.WriteLine(bill.Fullname());
            Console.WriteLine(bill.Pay());
    }
    }
    }
}