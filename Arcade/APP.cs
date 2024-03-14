


using System.Security.Cryptography.X509Certificates;
using AgeNameSpace;
using RockPaperScissorNameSpace;
using EntranceOfApp;
 using pigDiceNameSpace;
namespace App
{

    public class EntryToAPP
    {

        static void Main(string[] args)
        {
            //intro
            Console.WriteLine("Hello, What is your name?");
            string name = Console.ReadLine();

            // Entrance gameSelector = new Entrance(name);
            // gameSelector.checkingForLegalAgeForEntrance();
            // RockPaperScissorsGame playRPC = new RockPaperScissorsGame(name);
            // playRPC.WelcomePlayer();
            // playRPC.startGame();
        DiceGame diceGame = new DiceGame(name);
        diceGame.startGame();

        }


    }


}