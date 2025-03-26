using System;
using System.Collections.Generic;

namespace StackCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack < string > games = new Stack < string >();

            games.Push("Stardew Valley");
            games.Push("Split Fiction");
            games.Push("The Sims 4");
            games.Push("World of Warcraft");
            games.Push("The Legend of Zelda");
         
            Console.WriteLine("How many video games would you like to add?");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Video game: ");
                games.Push(Console.ReadLine());
            }
            Console.WriteLine("Would you like to look for a video game (yes or no)");
            string answer = Console.ReadLine();
            while(answer == "yes")
            {
                Console.WriteLine("Enter the name of the video game you would like to search for");
                string videoGame = Console.ReadLine();
                if(games.Contains(videoGame))
                {
                    Console.WriteLine("The game is on the list.");
                }
                else
                {
                    Console.WriteLine("I am sorry, that game is not on the list");
                }
                Console.WriteLine("Would you like to look for another video game (yes or no)");
                answer = Console.ReadLine();
            }
            Console.WriteLine($"Here is your {games.Count()} video games");
            foreach (var g in games)
            {
                Console.WriteLine(g);
            }
            string firstGame = games.Peek();   
            Console.WriteLine($"Would you like to remove {firstGame} from the end of the Stack (yes or no)?");
            answer = Console.ReadLine();
            while (answer == "yes")
            {
                games.Pop(); 
                firstGame = games.Peek();
                Console.WriteLine($"Would you like to remove {firstGame} from the end of the Stack (yes or no)?");
                answer = Console.ReadLine();
            }

            if (games.Peek() == null)
                Console.WriteLine("The Stack is empty");
            else
                Console.WriteLine($"You have {games.Count} left in the Stack");

        }
    }
}