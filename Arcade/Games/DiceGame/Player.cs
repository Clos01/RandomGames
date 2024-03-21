
using pigDiceNameSpace;
namespace PlayerNameSpace
{
    public class Player
    {
        public int userTurn = 1;
        public int TotalScore;
        protected int TurnScore;
        protected readonly DiceGame _diceGame;
        public string Username { get; set; }

        public Player(DiceGame diceGame, string username)
        {
            _diceGame = diceGame;
            Username = username;
        }

        public void TakeTurn(int diceResult)
        {
            TurnScore = 0;
            ProcessRoll(diceResult);

            while (TurnScore > 0 && TotalScore < 100)
            {
                Console.WriteLine($"{Username}, do you want to roll again? (yes/no)");
                if (!AskUserToRollAgain())
                {
                    break;
                }

                diceResult = _diceGame.GetNumberRolled();
                ProcessRoll(diceResult);
            }

            TotalScore += TurnScore;
            Console.WriteLine($"End of {Username}'s turn. {Username}'s total score is now: {TotalScore}.");
        }

        public virtual void ProcessRoll(int rollResult)
        {
            if (rollResult == 1)
            {
                TurnScore = 0;
                Console.WriteLine($"{Username} rolled a 1. {Username}'s turn is over, and the score for this turn is 0.");
            }
            else
            {
                TurnScore += rollResult;
                Console.WriteLine($"{Username} rolled: {rollResult}. {Username}'s total score for this turn is: {TurnScore}.");
            }
        }

        public bool AskUserToRollAgain()
        {
            string userInput = Console.ReadLine().ToLower();
            return userInput == "yes";
        }
    }
}
