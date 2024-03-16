
using pigDiceNameSpace;

namespace BotPlayerNameSpace
{
    public class BotPlayer
    {

        private int BotScore;
        private int botTurnTracking;
        private int botTurnScore;
        private DiceGame _diceGame;



        public BotPlayer(DiceGame diceGame)
        {
            this._diceGame = diceGame;
        }
        public int botTurnTracker()
        {
            return botTurnTracking++;
        }

        public void botTurn()
        {
            while (BotScore < 100)
            {

                int botRollResults = _diceGame.getNumberRolled();
                if (botRollResults == 1)
                {
                    botTurnScore = 0;
                    botTurnTracking = botTurnTracker();
                    Console.WriteLine($"Bot has rolled: {botRollResults}, Bot current turn is: {botTurnTracking},  Bot total for this round is {BotScore}");
                }
                else
                {
                    botTurnScore += botRollResults;
                    int botTurnTracking = botTurnTracker();
                    Console.WriteLine($"Bot has rolled: {botRollResults} Bot current turn is: {botTurnTracking} total is: {botTurnScore}, Do you want to roll again?");
                    Console.WriteLine();
                }


            }


        }






















    }

}