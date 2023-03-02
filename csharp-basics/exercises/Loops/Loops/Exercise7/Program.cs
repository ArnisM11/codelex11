﻿namespace Exercise7
{
    class Piglet
    {
        private int score;
        private Random rand;
        public Piglet()
        {
            score = 0;
            rand = new Random();
        }
        public void playPiglet()
        {
            string rollAgain = "";
            while (rollAgain != "no") {
                int roll = rand.Next(1, 7);
                if (roll == 1)
                {
                    Console.WriteLine("You rolled a 1!");
                    score = 0;
                    break;
                }
                Console.WriteLine("Welcome to Piglet!");
                Console.WriteLine("You rolled a " + roll + "!");
                Console.Write("Roll again? ('yes' or 'no')");
                score += roll;
                rollAgain = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("You got "+ score+ " points.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Piglet game = new Piglet();
            game.playPiglet();
            Console.ReadLine();
        }
    }
}