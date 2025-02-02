using System;

namespace bookStore
{
    class book
    {
        private int _Id;
        private string _Title;
        private string _Author;

    public book()
    {
        _Id = 0;
        _Title = " ";
         _Author = " ";
    }
    public book(int i, string Title, string Author)
    {
        _Id = i;
        _Title=Title;
        _Author=Author;
    }
        public int GetId()
    {
        return _Id;
    }   
    public string GetTitle()
    { 
        return _Title;
    }
    public string GetAuthor()
    { 
        return _Author;
    }
    public void SetId(int identification)
    {
        _Id = identification;
    }

    public void SetTitle(string title)
    {
        _Title = title;
    }

    public void SetAuthor(string author)
    {
        _Author = author;
    }
    class myStore
    {
        static void Main(string[] args)
        {
            book member10 = new book(5,"Wizard Of Oz", "L. Frank Baum");
            Console.WriteLine($"ID = {member10.GetId}, Title = {member10.GetTitle}  Author = {member10.GetAuthor}");

            book member20 = new book();
            Console.WriteLine("Please enter the ID: ");
            member20.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the title: ");
            member20.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the author: ");
            member20.SetAuthor(Console.ReadLine());
            Console.WriteLine($"ID = {member20.GetId}, Title = {member20.GetTitle}  Author = {member20.GetAuthor}");

            book member30 = new book();
            member30.SetId(6);
            member30.SetTitle("The Hobbit");
            member30.SetAuthor("J. R.R. Tolkien");
            Console.WriteLine($"ID = {member30.GetId}, Title = {member30.GetTitle} Author = {member30.GetAuthor}");

            Console.WriteLine("Please enter the ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the author: ");
            string tempAuthor = Console.ReadLine();
            book member40 = new book(tempID, tempTitle, tempAuthor);

            displayBook(member10);
            displayBook(member20);
            displayBook(member30);
            displayBook(member40);
    }
    static void displayBook(book member)
        {
            Console.WriteLine("Here's your book information");
            Console.WriteLine($"Book ID: {member.GetId()}");
            Console.WriteLine($"Title Name: {member.GetTitle()}");
            Console.WriteLine($"Author Name: {member.GetAuthor()}");
        }
    }

}
}