using System;
using System.Collections.Generic;

namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue < string > familymembers = new Queue < string >();
            
            familymembers.Enqueue("Makayla");
            familymembers.Enqueue("Charlie");
            familymembers.Enqueue("Juniper");
            familymembers.Enqueue("Braum");
            familymembers.Enqueue("Shuzu");

            Console.WriteLine("How many family members would you like to add?");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Family member name: ");
                familymembers.Enqueue(Console.ReadLine());
            }

            Console.WriteLine($"Here are your {familymembers.Count()} family members");
            foreach (var m in familymembers)
            {
                Console.WriteLine(m);
            }

            string firstMem = familymembers.Peek();
            Console.WriteLine($"Would you like to remove {firstMem} from the beginning of the queue (yes or no)?");
            string answer = Console.ReadLine();
            while (answer=="yes")
            {
                familymembers.Dequeue(); 
                firstMem= familymembers.Peek();
                Console.WriteLine($"Would you like to remove {firstMem} from the beginning of the queue (yes or no)?");
                answer = Console.ReadLine();
            }
           
            if (familymembers.Peek() == null)
                Console.WriteLine("The queue is empty");
            else
                Console.WriteLine($"You have {familymembers.Count} left in the queue");

        }
    }
}