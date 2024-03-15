


using System.Security.Cryptography.X509Certificates;
using AgeNameSpace;
using RockPaperScissorNameSpace;
using EntranceOfApp;
 using pigDiceNameSpace;
using UserInterFaceNamespace;
namespace App
{

    public class EntryToAPP
    {

        static void Main(string[] args)
        {
            //intro
            Console.WriteLine("Hello, What is your name?");
            string name = Console.ReadLine();
        IUserInterface diceGame = new DiceGame(name);
        diceGame.WelcomePlayer();
        diceGame.startGame();

        }


    }


}