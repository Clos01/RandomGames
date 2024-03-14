using System.Diagnostics.Contracts;
using System.Security;
using App;
using UserInterFaceNamespace;

namespace pigDiceNameSpace
{

    public class DiceGame : IUserInterface
    {
        //* Fields //*
        private string userName;
        private int userTotalScore = 0;
        private int userTurnScore = 0;
        Random random = new Random();

        //* Constructor //*
        public DiceGame(string name)
        {
            userName = name;
        }
        //! Greetings / Start Game //*
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
            click1ToRollDice();

        }
        public void click1ToRollDice()
        {
            // string numStr = Console.ReadLine();

            if (int.TryParse(Console.ReadLine(), out int usrPressed1))
            {
                // userClicked1();
                bool userWantsRoll = userClicked1(usrPressed1);
                if (userWantsRoll)
                {
                    WaitTime();
                }

            }
            else
            {
                Console.WriteLine("Guess you don't want to play");
            }
        }
        public bool userClicked1(int usrPressed1)
        {
            return usrPressed1 == 1;

        }
        public void WaitTime()
        {
            {
                Console.WriteLine("Waiting for 5 seconds...");

                DateTime startTime = DateTime.Now;
                TimeSpan duration = TimeSpan.FromSeconds(5);

                while (DateTime.Now - startTime < duration)
                {
                    Console.Write(".");
                    Thread.Sleep(1000); // Sleep for 1 second
                }

                Console.WriteLine("\n5 seconds have passed.");
            }
        }


        public int DiceNumbers()
        {
            List<int> DiceNumbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            return DiceNumbers[random.Next(DiceNumbers.Count)];

        }


        public int UserDiceRoll()
        {
            return DiceNumbers();
        }


        public void userTurnCounter()
        {
            int userTurn = 0;
            for (int i = 0; userTurn < i; userTurn++)
            {
                Console.WriteLine($"Number of Your Turn: {userTurn} ");
            }
        }
        public void playerTurn()
        {

            while (userTotalScore < 100)
            {

                int rollResult = UserDiceRoll();
                if (rollResult == 1)
                {
                    Console.WriteLine("Sorry no points this time.");
                    userTurnScore = 0;
                }
                else
                {
                    userTurnScore += rollResult;
                    Console.WriteLine($" your current turn total is: {userTurnScore}, Do you want to roll again?");
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
            else
            {
                Console.WriteLine($" Computer will now roll for BOT. ");
            }
        }

    }
}




