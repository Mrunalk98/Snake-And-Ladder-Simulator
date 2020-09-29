using System;

namespace SnakeAndLadderSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulator");

            int position = 0;
            Console.WriteLine("Player position : " + position);
            GetNumberOnDie();

        }

        static int GetNumberOnDie()
        {
            Random random = new Random();
            int number = random.Next(1, 7);

            Console.WriteLine("Number on die : " + number);

            return number;

        }
    }
}
