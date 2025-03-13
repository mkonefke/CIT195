using System;
using System.IO;
using System.Transactions;

namespace WordOfTheDay
{
    internal class Program
    {
        static void Main()
        {
            int choice = Menu();
            while(choice !=5)
            {
            switch (choice )
            {
                case 1:
                    AppendToFile();
                    break;
                case 2:
                    ReadFile();
                    break;
                case 3:
                    ReadToArray();
                    break;
                case 4:
                try
                {
                    string path = "Words.txt";
                    if (File.Exists(path))
                {
                    File.Delete(path);
                    Console.WriteLine("File deleted successfully.");
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (IOException ex)
            {
               Console.WriteLine("An error occurred: " + ex.Message);
            }
                break;
            }   
                choice = Menu();
            }
}
        static int Menu()
        {
            Console.WriteLine("Enter your choice:\n1. Add Word\n2. Read All\n" +
                "3. Read Current Word\n4. Delete\n5. Exit");
            int choice = 0;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice != 5)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
            }
            return choice;
        }
        static void AppendToFile()
        {
            string path = "Words.txt";

            Console.WriteLine("What is the word?");
            string newText = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(newText))
            {
                Console.WriteLine("Please enter valid word: ");
                newText = Console.ReadLine();
            }
            newText += " ";
            bool definitions = true;
            int counter = 1;

            do
            {
                Console.WriteLine("What is the definition?");
                string temp = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(temp))
                {
                    Console.WriteLine("Please enter a valid definition: ");
                    temp = Console.ReadLine();
                }
                newText += counter + ".  " + temp + "  ";
                Console.WriteLine("Do you want to add another definition? (yes/no)");
                string userResponse = Console.ReadLine()?.ToLower();
                if (userResponse == "yes")
                {
                    counter++;
                }
                else if (userResponse == "no")
                {
                    newText += "\n";
                    definitions = false;
                }
                else
                {
                    Console.WriteLine("Please enter 'yes' or 'no'.");
                } 
            }while (definitions);
    
            try
            {
                File.AppendAllText(path, newText);
                Console.WriteLine("Word and definitions successfully added to the file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");
            }
                return;
            }
        static void ReadFile()
        {
            string path = "Words.txt";
            try
            {
                if (File.Exists(path))
                {
                    string content = File.ReadAllText(path);
                    Console.WriteLine("File Content:\n" + content);
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return;

        }
        static void ReadToArray()
        {
            string path = "Words.txt";
            try
            {
                if (File.Exists(path))
                {
                    string[] lines = File.ReadAllLines(path);
                    string currentWord = lines[lines.Length - 1];
                    Console.WriteLine("File Content as Array:");
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}