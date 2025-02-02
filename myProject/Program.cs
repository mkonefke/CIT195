using System;

namespace gameStore
{
    class game
    {
        private int _Price;
        private string _Title;
        private string _System;

    public game()
    {
        _Price = 0;
        _Title = " ";
         _System = " ";
    }
    public game(int p, string Title, string System)
    {
        _Price = p;
        _Title=Title;
        _System=System;
    }
        public int GetPrice()
    {
        return _Price;
    }   
    public string GetTitle()
    { 
        return _Title;
    }
    public string GetSystem()
    { 
        return _System;
    }
    public void SetPrice(int price)
    {
        _Price = price;
    }

    public void SetTitle(string title)
    {
        _Title = title;
    }

    public void SetSystem(string system)
    {
        _System = system;
    }
    class myGames
    {
        static void Main(string[] args)
        {
            game member10 = new game(100,"Super Mario Sunshine", "Nintento");
            Console.WriteLine($"Price = {member10.GetPrice}, Title = {member10.GetTitle}  System = {member10.GetSystem}");

            game member20 = new game();
            Console.WriteLine("Please enter the Price: ");
            member20.SetPrice(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the title: ");
            member20.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the system: ");
            member20.SetSystem(Console.ReadLine());
            Console.WriteLine($"Price = {member20.GetPrice}, Title = {member20.GetTitle}  System = {member20.GetSystem}");

            game member30 = new game();
            member30.SetPrice(60);
            member30.SetTitle("God of War");
            member30.SetSystem("Sony");
            Console.WriteLine($"Price = {member30.GetPrice}, Title = {member30.GetTitle} System = {member30.GetSystem}");

            Console.WriteLine("Please enter the ID: ");
            int tempPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the author: ");
            string tempSystem = Console.ReadLine();
            game member40 = new game(tempPrice, tempTitle, tempSystem);

            displayGame(member10);
            displayGame(member20);
            displayGame(member30);
            displayGame(member40);
    }
    static void displayGame(game member)
        {
            Console.WriteLine("Here's your game info: ");
            Console.WriteLine($"Price: {member.GetPrice()}");
            Console.WriteLine($"Title Name: {member.GetTitle()}");
            Console.WriteLine($"System Name: {member.GetSystem()}");
        }
    }

}
}