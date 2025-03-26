using System;
using System.Text;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        string[] books =
            { "Sunrise on the Reaping", "The Ballad of Songbirds and Snakes", "The Hunger Games", "Catching Fire", "Mockingjay" };
        LinkedList < string > bookList = new LinkedList < string >(books);
        Console.WriteLine("Original book list");
        foreach (string book in bookList)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine();

        bookList.AddLast("Divergent");
        bookList.AddFirst("Maze Runner");
        
        LinkedListNode < string > targetLocation = bookList.Find("The Hunger Games");
        Console.WriteLine("The current book in the list after The Hunger Games is {0}",targetLocation.Next.Value);
        Console.WriteLine();
        bookList.AddAfter(targetLocation, "Insurgent");
        bookList.AddBefore(targetLocation, "The Scorch Trials");
        Console.WriteLine("List with additions");
        foreach (string book in bookList)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine();
        bookList.RemoveFirst();
        bookList.RemoveLast();
        Console.WriteLine("List after deletions");
        foreach (string book in bookList)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine();

        string[] bookArray = new string[bookList.Count];
        bookList.CopyTo(bookArray, 0);
        Console.WriteLine("bookList is now bookArray");
        foreach (string f in bookArray)
        {
            Console.WriteLine(f);
        }

        bookList.Clear();


    }

}