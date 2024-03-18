


using pigDiceNameSpace;
using BotPlayerNameSpace;

namespace PlayerNameSpace
{


    public class Player
    {
        //! Fields


        private int userTurn;
        private int userTotalScore;
        private int userTurnScore;
        private DiceGame _diceGame;
        //! Constructor 
        public Player(DiceGame diceGame)
        {
            _diceGame = diceGame;

        }

        public int userTurnTracker()
        {
            return userTurn++;
        }

        //player 
        public void playerTurn()
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
                    userTotalScoreWith_TurnScore();
                    int userCurrentTurn = userTurnTracker();
                    Console.WriteLine($"you have rolled: {rollResult} your current turn is: {userCurrentTurn} total is: {userTurnScore}, Do you want to roll again?");
                    askUserToToRollAgain();

            }
        }
        public int userTotalScoreWith_TurnScore()
        {
            return userTotalScore += userTurnScore;
        }
        public void askUserToToRollAgain()
        {
            string userInputToRollAgain = Console.ReadLine().ToLower();
            if (userInputToRollAgain == "yes")
            {
                // userTotalScore += userTurnScore;
                userTotalScoreWith_TurnScore();
                userTurnScore = 0;
                Console.WriteLine($"Your total score is now: ");

            }
            else
            {
                // PlayerDiceGame.botTurn();

            }
        }



    }



}