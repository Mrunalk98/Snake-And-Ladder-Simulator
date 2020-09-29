using System;

namespace SnakeAndLadderSimulator
{
    class Program
    {
        public static bool gameEnd = false;
        static int[] position = { 0, 0 };
        public const int IS_LADDER = 1;
        public const int IS_SNAKE = 2;
        static bool getsLadder = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulator\n");
            GetNumberOnDie();
        }


        static int GetNumberOnDie()
        {
            int result = 0;
            while (!gameEnd)
            {
                for (int i=0; i < position.Length; i++)
                {
                    Console.WriteLine("For Player " + (i+1));
                    Random random = new Random();
                    int number = random.Next(1, 7);
                    result = CheckForOptions(number, position[i]);
                    position[i] = result;
                    if (getsLadder)
                    {
                        i--;
                        getsLadder = false;
                    }
                    if (result == 100)
                    {
                        Console.WriteLine("Player " + (i+2) + " wins the game!");
                        gameEnd = true;
                        return result;
                    }

                }                
            }
            return result;
        }
        static int CheckForOptions(int numberOnDie, int position)
        {
            string option;
            Random rand = new Random();
            int opt = rand.Next(0, 3);

            switch (opt)
            {
                case IS_LADDER:
                    option = "Ladder";
                    position += numberOnDie;
                    if (position > 100)
                    {
                        position -= numberOnDie;
                    }
                    getsLadder = true;
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
            Console.WriteLine("Number on die : " + numberOnDie + "\t" + "Gets : " + option + "\t\t" + "Current Position : " + position + "\n");
            return position;
        }
    }
}
