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
            Console.WriteLine("Press Number `1` to roll the dice.");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int selectedNumber) && selectedNumber == 1)
            {
                RollDice();
            }
            else
            {
                Console.WriteLine("Invalid input. Exiting the game.");
                // Handle invalid input or exit the game
            }
        }

        //Rolling dice
        public int GetNumberRolled()
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
            WaitTime(); // Simulate dice rolling
            int diceResult = GetNumberRolled();
            Console.WriteLine($"\nDice has been rolled: {diceResult}");
            _player.PlayerTurn(diceResult); // Pass the dice result to the player
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
    }
}




