
using pigDiceNameSpace;
using PlayerNameSpace;

namespace BotPlayerNameSpace
{
    public class BotPlayer : Player
    {
        private int botTurnTracking;
        private int botTurnScore;
        private int botTotalScore;
        private DiceGame _diceGame;
        private int diceResult;
        public BotPlayer(DiceGame diceGame) : base(diceGame)
        {
            this._diceGame = diceGame;
        }
        public
         int botTurnTracker()
        {
            return botTurnTracking++;
        }

        public void takeTurn(int botDiceResult)
        {
            botTurnScore = 0; // Reset turn score at the start of each turn.

            // Process the result of the first dice roll passed from DiceGame.
            botProcessRoll(botDiceResult);

            // Ask the player if they want to roll again only if the score for this turn is greater than 0.
            while (botTurnScore > 0 && botTotalScore < 100)
            {
                Console.WriteLine("Do you want to roll again? (yes/no)");
                if (!AskUserToRollAgain())
                {
                    break; // Exit the loop if the player doesn't want to roll again.
                }

                diceResult = _diceGame.GetNumberRolled(); // Get a new roll result.
                botProcessRoll(diceResult);
            }

            // Update the total score after the turn ends.
            userTotalScore += userTurnScore;
            Console.WriteLine($"End of turn. Your total score is now: {userTotalScore}");

       }
        private void botProcessRoll(int botRollResult)
        {
            if (botRollResult == 1)
            {
                botTurnScore = 0;// Reset turn score if 1 is rolled.
                Console.WriteLine($"You rolled a 1. Your turn is over, and your score for this turn is {userTurnScore}");
            }
            else
            {
               botTurnScore  += rollResult;
                  Console.WriteLine($"Bot rolled: {rollResult}. Bot total score for this turn is: {userTurnScore}");
            }
        }

    }
}

