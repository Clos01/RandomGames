using System.Diagnostics.Contracts;
using System.Security;
using System.Transactions;
using App;
using UserInterFaceNamespace;

namespace pigDiceNameSpace
{

    public class DiceGame : IUserInterface
    {
        //* Fields //*
        private readonly string userName;
        private int userTurn;  
        private int userTotalScore;
        private int userTurnScore;

            
        private readonly List<int> Die = new() { 1, 2, 3, 4, 5, 6 }; 
        Random random = new Random();

        //* Constructor //*
        public DiceGame(string name)
        {
            userName = name;
        }

        public void WelcomePlayer()
        {
            Console.WriteLine($"Welcome {userName}, to Pig Dice Game ");
        }
        public void startGame()
        {
            RollOfDice();
            playerTurn();

        }

        //* General information for roll dice  //*
        public void RollOfDice()
        {
            Console.WriteLine("Lets Roll the Dice. You will Roll First,  Press Number `1` to roll");
            RollDice();

        }
        public void RollDice() 
        {
            // string numStr = Console.ReadLine();

            if (int.TryParse(Console.ReadLine(), out int btnSelected))
            {
                // userClicked1();
                if (  btnSelected == 1)

                {
                    WaitTime();
                }

            }
            else
            {
                Console.WriteLine("Guess you don't want to play");
            }
        }
     
        public void WaitTime()
        {
            {
                Console.Write("Rolling Dice");

                DateTime startTime = DateTime.Now;
                TimeSpan duration = TimeSpan.FromSeconds(2);

                while (DateTime.Now - startTime < duration)
                {
                    Console.Write(".");
                    Thread.Sleep(300); // Sleep for 1 second
                }

                Console.WriteLine("\nDice has been rolled. ");
            }
        }

        public int getNumberRolled()
        {
       return Die[random.Next(Die.Count)]; 
        }


        public int userTurnTracker()
        {
            return userTurn++;  
        }
        public void playerTurn()
        {

            while (userTotalScore < 100)
            {  

                int rollResult = getNumberRolled();
                if (rollResult == 1)
                {
                    userTurnScore = 0;
                     int userCurrentTurn = userTurnTracker();
                     Console.WriteLine($"you have rolled: { rollResult }, your current turn is: {userCurrentTurn},  your total for this round is { userTurnScore }");
                     // should call bot method here 
                }
                else
                {
                 userTurnScore += rollResult;
                 int userCurrentTurn = userTurnTracker();
                    Console.WriteLine($"you have rolled: { rollResult } your current turn is: {userCurrentTurn} total is: {userTurnScore}, Do you want to roll again?");
                    askUserToToRollAgain();
                }
            }
        }



        public void askUserToToRollAgain()
        {
            string userInputToRollAgain = Console.ReadLine().ToLower();
            if (userInputToRollAgain != "yes")
            {
                userTotalScore += userTurnScore;
                userTurnScore = 0;
                Console.WriteLine($"Your total score is now: {userTotalScore}");

            }
           
        }

    }
}




