using System.Diagnostics.Contracts;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using App;
using UserInterFaceNamespace;
using PlayerNameSpace;

namespace pigDiceNameSpace
{

    public class DiceGame : IUserInterface
    {
        //* Fields //*
        private int totalScoreToWin = 100;
        private readonly List<int> Die = new() { 1, 2, 3, 4, 5, 6 };
        Random random = new Random();
        //! instances of classes 
        private readonly Player _player;
        //* variable name from interface
        private string Username;
        //* Constructor //*


        public DiceGame(string name)
        {
            this.Username = name;
            _player = new Player(this);
        }

        public void WelcomePlayer()
        {
            Console.WriteLine($"Welcome {Username}, to Pig Dice Game ");
        }
        public void startGame()
        {
            RollOfDice();

            // _player.playerTurn();         

        }

        //*Rolling dice
        public int getNumberRolled()
        {
            return Die[random.Next(Die.Count)];
        }

        //* General information for roll dice  //*
        public void RollOfDice()
        {
            Console.WriteLine("Lets Roll the Dice. You will Roll First,  Press Number `1` to roll");
            RollDice();

        }
        public void RollDice()
        {

            if (int.TryParse(Console.ReadLine(), out int btnSelected))
            {
                // userClicked1();
                if (btnSelected == 1)

                {
                    WaitTime();
                    // call method here for player to run the dice 
                    //  _player.playerTurn();
                    TakeTurn();
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
        //should be abel to take the winner 
        private int TakeTurn()
        {

            bool rolling = true;

            while (rolling)
            {
                Console.WriteLine("Would you like to Roll or Hold [r/h]: ");
                string choice = Console.ReadLine().ToLower();
                if (choice == "h")
                {
                    break;
                }
                int rollResult = getNumberRolled();
                Console.WriteLine($"You rolled: {rollResult}");
                if (rollResult == 1)
                {
                    return 0; // Score nothing for this turn
                }
            }
            return _player.userTurnTracker();


        }








    }
}




