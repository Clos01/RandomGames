using System.Formats.Asn1;
using pigDiceNameSpace;
using PlayerNameSpace; 
 namespace BotPlayerNameSpace
{
    public class BotPlayer : Player
    {
            int TotalScore;
            int TurnScore;
            DiceGame _diceGame; 
        public BotPlayer(DiceGame diceGame) : base(diceGame, "Bot") { }

        public override void ProcessRoll(int rollResult)
        {
            if (rollResult == 1)
            {
                TurnScore = 0;
                Console.WriteLine("Bot rolled a 1. Bot's turn is over, and the score for this turn is 0.");
            }
            else
            {
                TurnScore += rollResult;
                Console.WriteLine($"Bot rolled: {rollResult}. Bot's total score for this turn is: {TurnScore}.");
            }
        }

        public void TakeTurns(int diceResult)
        {
            TurnScore = 0;
            ProcessRoll(diceResult);

            while (TurnScore > 0 && TotalScore < 100)
            {
                if (!ShouldRollAgain(TurnScore, 20))
                {
                    break;
                }

                diceResult = _diceGame.GetNumberRolled();
                ProcessRoll(diceResult);
            }

            TotalScore += TurnScore;
            Console.WriteLine($"End of Bot's turn. Bot's total score is now: {TotalScore}.");
        }

        private bool ShouldRollAgain(int turnScore, int scoreThreshold)
        {
            return turnScore < scoreThreshold;
        }
    }
}
