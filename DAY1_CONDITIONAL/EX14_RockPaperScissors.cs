namespace Exe19Dec
{
    public class RockPaperScissors
    {
        /// <summary>
        /// Determine winner of rock paper scissors
        /// </summary>
        /// <param name="p1">Player 1 choice</param>
        /// <param name="p2">Player 2 choice</param>
        public void Play(string p1, string p2)
        {
            if (p1 == p2)
                Console.WriteLine("Draw");
            else if ((p1 == "rock" && p2 == "scissors") ||
                     (p1 == "scissors" && p2 == "paper") ||
                     (p1 == "paper" && p2 == "rock"))
                Console.WriteLine("Player 1 wins");
            else
                Console.WriteLine("Player 2 wins");
        }

        public static void Main(string[] args)
        {
            RockPaperScissors obj = new RockPaperScissors();
            Console.WriteLine("Enter Player1 and Player2 choice:");
            string? p1 = Console.ReadLine();
            string? p2 = Console.ReadLine();
            obj.Play(p1, p2);
        }
    }
}
