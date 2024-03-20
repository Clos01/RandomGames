
using pigDiceNameSpace;

namespace PlayerNameSpace
{
    public class Player
    {
        private int userTurn = 1;
        private int userTotalScore;
        private int userTurnScore;
        private readonly DiceGame _diceGame;

        public Player(DiceGame diceGame)
        {
            _diceGame = diceGame;
        }

        public int UserTurnTracker()
        {
            return userTurn++;
        }

        public void PlayerTurn(int diceResult) // added parameter 
        {
            userTurnScore = 0; // Reset turn score at the start of each turn.

            // Process the result of the first dice roll passed from DiceGame.
            ProcessRoll(diceResult);

            // Ask the player if they want to roll again only if the score for this turn is greater than 0.
            while (userTurnScore > 0 && userTotalScore < 100)
            {
                Console.WriteLine("Do you want to roll again? (yes/no)");
                if (!AskUserToRollAgain())
                {
                    break; // Exit the loop if the player doesn't want to roll again.
                }

                diceResult = _diceGame.GetNumberRolled(); // Get a new roll result.
                ProcessRoll(diceResult);
            }

            // Update the total score after the turn ends.
            userTotalScore += userTurnScore;
            Console.WriteLine($"End of turn. Your total score is now: {userTotalScore}");
        }

        private void ProcessRoll(int rollResult)
        {
            if (rollResult == 1)
            {
                userTurnScore = 0; // Reset turn score if 1 is rolled.
                Console.WriteLine($"You rolled a 1. Your turn is over, and your score for this turn is {userTurnScore}");
            }
            else
            {
                userTurnScore += rollResult;
                Console.WriteLine($"You rolled: {rollResult}. Your total score for this turn is: {userTurnScore}");
            }
        }

        private bool AskUserToRollAgain()
        {
            string userInput = Console.ReadLine().ToLower();
            return userInput == "yes";
        }
    }
}
