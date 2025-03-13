using System;
namespace recordDemo
{
    class Program
    { 
    public record Book(int ID, string Title, string Author, double Price);

        public static void Main()
        {
            Book book1 = new(5, "Where the Crawdads Sing","Delia Owens",12.99);
            Console.WriteLine(book1);
            Book book2 = new(10, "Twilight","Stephanie Meyer",10);
            Console.WriteLine(book2);
            Book book3 = new(15, "Fourth Wing","Rebecca Yarros",13.88);
            Console.WriteLine(book3);
        }
    }
}