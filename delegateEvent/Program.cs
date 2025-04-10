using System;

namespace delegatesAndEvents
{
    public delegate void RaceEvent(int winner);

    public class Race
    {
        public event RaceEvent RaceCompleted;
        public void Racing(int contestants, int laps)
        {
            Console.WriteLine("Ready\nSet\nGo!");
            Random r = new Random();
            int[] participants = new int[contestants];
            bool done = false;
            int champ = -1;
            // First to finish specified number of laps wins
            while (!done)
            {
                for (int i = 0; i < contestants; i++)
                {
                    if (participants[i] <= laps)
                    {
                        participants[i] += r.Next(1, 5);
                    }
                    if (participants[i] > laps)
                    {
                        champ = i;
                        done = true;
                        break;
                    }
                }
            }

            TheWinner(champ);
        }

        private void TheWinner(int champ)
        {
            Console.WriteLine("We have a winner!");
            RaceCompleted?.Invoke(champ); 
        }
    }

    class Program
    {
        public static void Main()
        {
            Race round1 = new Race();
            Race foot = new Race();
            foot.RaceCompleted += footRace;
            foot.Racing(5, 10);

            Race car = new Race();
            car.RaceCompleted += carRace;
            car.Racing(3, 15);
            
            Race bikeRaceRound = new Race();
            bikeRaceRound.RaceCompleted += (winner) =>
            {
                Console.WriteLine($"Biker number {winner} crosses the finish line first!");
            };
            bikeRaceRound.Racing(4, 12);
        }

        // Event handlers
        public static void carRace(int winner)
        {
            Console.WriteLine($"Car number {winner} is the winner.");
        }

        public static void footRace(int winner)
        {
            Console.WriteLine($"Racer number {winner} is the winner.");
        }
    }
}