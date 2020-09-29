using System;

namespace SnakeAndLadderSimulator
{
    class Program
    {
        static int position = 0;
        public const int IS_LADDER = 1;
        public const int IS_SNAKE = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulator");
            
            Console.WriteLine("Player position : " + position);
            GetNumberOnDie();

        }

        static string GetNumberOnDie()
        {
            Random random = new Random();
            int number = random.Next(1, 7);

            Console.WriteLine("Number on die : " + number);
            return CheckForOptions(number);
        }
        static string CheckForOptions(int numberOnDie)
        {
            string option;
            Random rand = new Random();
            int opt = rand.Next(0, 3);

            switch (opt)
            {
                case IS_LADDER:
                    option = "Ladder";
                    position += numberOnDie;
                    break;

                case IS_SNAKE:
                    option = "Snake";
                    position -= numberOnDie;
                    if (position < 0)
                    {
                        position = 0;
                    }
                    break;

                default:
                    option = "No Play";
                    break;
            }

            Console.WriteLine("You got " + option);
            Console.WriteLine("New Position : " + position);
            return option;
        }
    }
}
