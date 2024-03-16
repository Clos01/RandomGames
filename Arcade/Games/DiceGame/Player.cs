


using pigDiceNameSpace;

namespace PlayerNameSpace
{


    public class Player
    { 
        //! Fields
        private DiceGame _diceGame;
        private int userTurn;
        private int userTotalScore;
        private int userTurnScore;
        //! Constructor 
        public Player(DiceGame diceGame)
        {
            this._diceGame = diceGame;
        }
        public int userTurnTracker()
        {
            return userTurn++;
        }

        //player 
        public void playerTurn()
        {

            while (userTotalScore < 100)
            {

                int rollResult = _diceGame.getNumberRolled();
                if (rollResult == 1)
                {
                    userTurnScore = 0;
                    int userCurrentTurn = userTurnTracker();
                    Console.WriteLine($"you have rolled: {rollResult}, your current turn is: {userCurrentTurn},  your total for this round is {userTurnScore}");
                    // should call bot method here 

                }
                else
                {
                    userTurnScore += rollResult;
                    int userCurrentTurn = userTurnTracker();
                    Console.WriteLine($"you have rolled: {rollResult} your current turn is: {userCurrentTurn} total is: {userTurnScore}, Do you want to roll again?");
                    askUserToToRollAgain();
                }

            }
        }
        public void askUserToToRollAgain()
        {
            string userInputToRollAgain = Console.ReadLine().ToLower();
            if (userInputToRollAgain == "yes")
            {
                userTotalScore += userTurnScore;
                userTurnScore = 0;
                Console.WriteLine($"Your total score is now: {userTotalScore}");

            }
            else
            {
                // PlayerDiceGame.botTurn();

            }
        }



    }



}