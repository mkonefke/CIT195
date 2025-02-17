using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Transactions;

namespace Inheritance
{
    //Base Class
    class Club
    {
        private string _Game;
        private string _Name;
        private int _GameWins;

        public Club()
        {
            _Game = string.Empty;
            _Name = string.Empty;
            _GameWins = 0;
        }
        //parameterized constructor
        public Club(string game, string name, int gameWins)
        {
            _Game = game;
            _Name = name;
            _GameWins = gameWins;
        }
        // Get and Set Methods
        public string getGame() { return _Game; }
        public string getName() { return _Name; }
        public int getGameWins() { return _GameWins; }
        public void setGame(string game) { _Game = game; }
        public void setName(string name) { _Name = name; }
        public void setGameWins(int gameWins) { _GameWins = gameWins; }

        public virtual void addChange()
        {
            Console.Write("Game=");
            setGame(Console.ReadLine());
            Console.Write("Name=");
            setName(Console.ReadLine());
            Console.Write("Game Wins=");
            setGameWins(int.Parse(Console.ReadLine()));
        }
        public virtual void print()
        {
            Console.WriteLine();
            Console.WriteLine($"      Game: {getGame()}");
            Console.WriteLine($"    Name: {getName()}");
            Console.WriteLine($"     Game Wins: {getGameWins()}");
        }
    }
    class GameClub : Club
    {
        private double _Rewards;
        private string _Location;

        public GameClub()
            : base()
        {
            _Location = string.Empty;
            _Rewards= 0;
        }
        public GameClub( string game, string name, int gameWins, double rewards, string location)
            : base(game, name, gameWins)
        {
            _Rewards = rewards;
            _Location = location;
        }
        public void setRewards(double rewards) { _Rewards = rewards; }
        public void setLocation(string location) { _Location = location; }
        public double getRewards() { return _Rewards; }
        public string getLocation() { return _Location; }
        public override void addChange()
        {
            base.addChange();
            Console.Write("Convention Rewards=");
            setRewards(double.Parse(Console.ReadLine()));
            Console.Write("Location=");
            setLocation(Console.ReadLine());
        }
        public override void print()
        {
            base.print();
            Console.WriteLine($"  Convention Rewards: {getRewards()}");
            Console.WriteLine($"Location: {getLocation()}");
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many club members do you want to enter?");
            int maxClbs;
            while (!int.TryParse(Console.ReadLine(), out maxClbs))
                Console.WriteLine("Please enter a whole number");
            // array of Employee objects
            Club[] clbs = new Club[maxClbs];
            Console.WriteLine("How many game club members do you want to enter?");
            int maxGmr;
            while (!int.TryParse(Console.ReadLine(), out maxGmr))
                Console.WriteLine("Please enter a whole number");
            // array of Manager objects
            GameClub[] gmr = new GameClub[maxGmr];

            int choice, rec, type;
            int clbCounter = 0, gmrCounter = 0;
            choice = Menu();
            while (choice != 4)
            {
                Console.WriteLine("Enter 1 for Game Club or 2 for General Club");
                while (!int.TryParse(Console.ReadLine(), out type))
                    Console.WriteLine("1 for Game Club or 2 for General CLub");
                try
                {
                    switch (choice)
                    {
                        case 1: // Add
                            if (type == 1) //Manager
                            {
                                if (gmrCounter <= maxGmr)
                                {
                                    gmr[gmrCounter] = new GameClub(); // places an object in the array instead of null
                                    gmr[gmrCounter].addChange();
                                    gmrCounter++;
                                }
                                else
                                    Console.WriteLine("The maximum number of game club members has been added");

                            }
                            else //Employee
                            {
                                if (clbCounter <= maxClbs)
                                {
                                    clbs[clbCounter] = new Club(); // places an object in the array instead of null
                                    clbs[clbCounter].addChange();
                                    clbCounter++;
                                }
                                else
                                    Console.WriteLine("The maximum number of members has been added");
                            }

                            break;
                        case 2: //Change
                            Console.Write("Enter the record number you want to change: ");
                            while (!int.TryParse(Console.ReadLine(), out rec))
                                Console.Write("Enter the record number you want to change: ");
                            rec--;  // subtract 1 because array index begins at 0
                            if (type == 1) //Manager
                            {
                                while (rec > gmrCounter - 1 || rec < 0)
                                {
                                    Console.Write("The number you entered was out of range, try again");
                                    while (!int.TryParse(Console.ReadLine(), out rec))
                                        Console.Write("Enter the record number you want to change: ");
                                    rec--;
                                }
                                gmr[rec].addChange();
                            }
                            else // Employee
                            {
                                while (rec > clbCounter - 1 || rec < 0)
                                {
                                    Console.Write("The number you entered was out of range, try again");
                                    while (!int.TryParse(Console.ReadLine(), out rec))
                                        Console.Write("Enter the record number you want to change: ");
                                    rec--;
                                }
                                clbs[rec].addChange();
                            }
                            break;
                        case 3: // Print All
                            if (type == 1) //Manager
                            {
                                for (int i = 0; i < gmrCounter; i++)
                                    gmr[i].print();
                            }
                            else // Employee
                            {
                                for (int i = 0; i < clbCounter; i++)
                                    clbs[i].print();
                            }
                            break;
                        default:
                            Console.WriteLine("You made an invalid selection, please try again");
                            break;
                    }
                }


                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                choice = Menu();

            }
        }


        private static int Menu()
        {
            Console.WriteLine("Please make a selection from the menu");
            Console.WriteLine("1-Add  2-Change  3-Print  4-Quit");
            int selection = 0;
            while (selection < 1 || selection > 4)
                while (!int.TryParse(Console.ReadLine(), out selection))
                    Console.WriteLine("1-Add  2-Change  3-Print  4-Quit");
            return selection;
        }
    }
}