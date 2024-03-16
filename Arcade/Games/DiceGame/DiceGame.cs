using System.Diagnostics.Contracts;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using App;
using UserInterFaceNamespace;
using BotPlayerNameSpace;
using PlayerNameSpace;

namespace pigDiceNameSpace
{

    public class DiceGame : IUserInterface
    {
        //* Fields //*
        private readonly string userName;

        private readonly List<int> Die = new() { 1, 2, 3, 4, 5, 6 };
        Random random = new Random();
        // BotPlayer botPlayer = new();
        private Player _player; //Player Class
        private BotPlayer _bot;  //Bot Class
        private string name;


        //* Constructor //*
        public DiceGame(string name)
        {
            userName = name;
            
        }

        public DiceGame(string name,Player player, BotPlayer bot)
        {
            this.name = name;
              this._player = player;
            this._bot = bot;
        }

        public void WelcomePlayer()
        {
            Console.WriteLine($"Welcome {userName}, to Pig Dice Game ");
        }
        public void startGame()
        {
            RollOfDice();

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

        public void playerTurn()
        {
            _player.playerTurn();

        }

        public void botTurn()
        {
            _bot.botTurn();
        }




    }
}




