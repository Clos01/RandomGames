using System.Diagnostics.Contracts;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using App;
using UserInterFaceNamespace;
using PlayerNameSpace;
using BotPlayerNameSpace;

namespace pigDiceNameSpace
{

    public class DiceGame : IUserInterface
    {
        //* Fields //*

        private readonly List<int> Die = new() { 1, 2, 3, 4, 5, 6 };
        Random random = new Random();
        //! instances of classes 
        private readonly Player _player;
        private readonly BotPlayer _botPlayer; 
        //* variable name from interface
        private string Username;
        //* Constructor //*


       public DiceGame(string name)
{
    Username = name;
    _player = new Player(this, name);
    _botPlayer = new BotPlayer(this);
}

        public void WelcomePlayer()
        {
            Console.WriteLine($"Welcome {Username}, to Pig Dice Game ");
        }
        public void startGame()
    {
        WelcomePlayer();
        while (_player.TotalScore < 100 && _botPlayer.TotalScore < 100)
        {
            Console.WriteLine($"{Username}'s Turn:");
            userRollDice();
            if (_player.TotalScore >= 100)
            {
                Console.WriteLine($"{Username} wins!");
                break;
            }
 Console.WriteLine("Bot's Turn:");
            BotTakesTurn();
            if (_botPlayer.TotalScore >= 100)
            {
                Console.WriteLine("Bot wins!");
                break;
            }
        }
    }

        //Rolling dice
        public int GetNumberRolled()
        {
            return Die[random.Next(Die.Count)];
        }

        //* General information for roll dice  //*
    
        
        public int RollDice()
        {
            WaitTime();
            int diceResult = GetNumberRolled();
            Console.WriteLine($"\nDice has been rolled: {diceResult}");
            return diceResult;
        }
public void BotTakesTurn()
{
    int diceResult = RollDice();
    _botPlayer.ProcessRoll(diceResult);
}



  public void userRollDice()
{
    int diceResult = RollDice(); // Roll dice and get the result
    _player.TakeTurn(diceResult); // Pass the result to the player's turn
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

          }
        }


       
    }
}




