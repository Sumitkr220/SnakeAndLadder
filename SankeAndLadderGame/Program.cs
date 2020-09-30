using System;

namespace SankeAndLadderGame
{
    class Program
    {
        public const int NO_OF_PLAYERS = 1;
        public const int INITIAL_POSITION = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Game!!!");
            Console.WriteLine("Player is at the starting position");
            Random random = new Random();
            int diceValue = random.Next(1, 7);
            Console.WriteLine("Player rolled : " + diceValue);
        }
    }
}
