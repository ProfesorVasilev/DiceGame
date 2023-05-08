namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int round = 1;
            int playerScore = 0;
            int AIscore = 0;
            int min = 1;
            int max = 7;

            for (int i = 1; i <= 10; i++)
            {
                Random numberGenerator = new Random();
                int playerNumber = numberGenerator.Next(min , max);
                int AInumber = numberGenerator.Next(min , max);
                Console.WriteLine($"--------------Round {round}------------------");
                Console.WriteLine("Press enter to roll the dice.");
                Console.ReadKey();
                Console.WriteLine($"-You rolled a {playerNumber}");
                System.Threading.Thread.Sleep(800); //delay
                Console.WriteLine($"-AI rolled a {AInumber}");
                if (playerNumber > AInumber)
                {
                    Console.WriteLine("Player wins this round!");
                    playerScore++;
                    Console.WriteLine($"The score is now {playerScore} : {AIscore}");
                    round++;
                }
                else if (playerNumber < AInumber)
                {
                    Console.WriteLine("Enemy wins this round!");
                    AIscore++;
                    Console.WriteLine($"The score is now {playerScore} : {AIscore}");
                    round++;
                }
                else
                {
                    Console.WriteLine("Draw!");
                    Console.WriteLine($"The score is still {playerScore} : {AIscore}");
                    round++;
                }
            }
            Console.WriteLine("--------------Results-------------------");
            if (playerScore > AIscore)
            {
                int difference = playerScore- AIscore;
                if (difference == 1)
                {
                    Console.WriteLine($"Player won by {difference} point.");
                    Console.WriteLine("Pure luck.");
                }
                else
                {
                    Console.WriteLine($"Player won by {difference} points.");
                    Console.WriteLine("Pure luck.");
                }
            }
            else if (playerScore < AIscore)
            {
                int difference = AIscore - playerScore;
                if (difference == 1)
                {
                    Console.WriteLine($"Enemy won by {difference} point.");
                    Console.WriteLine("You're such a loser");
                }
                else
                {
                    Console.WriteLine($"Enemy won by {difference} points.");
                    Console.WriteLine("You're such a loser");
                }
            }
            else
            {
                Console.WriteLine("It's a draw.");
                Console.WriteLine("Enemy : You escaped this time.");
            }
        }
    }
}