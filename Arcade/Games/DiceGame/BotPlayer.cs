
using pigDiceNameSpace;

namespace BotPlayerNameSpace
{
    public class BotPlayer
    {
        private int botTurnTracking;
        private DiceGame diceGame;
        public BotPlayer(DiceGame diceGame)
        {
            this.diceGame = diceGame;
        }
        public int botTurnTracker()
        {
            return botTurnTracking++;
        }

        public void botTurn()
        {


        }


    }
}

