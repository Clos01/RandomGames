


using System.Security.Cryptography.X509Certificates;
using AgeNameSpace;
using RockPaperScissorNameSpace;
using EntranceOfApp;
using pigDiceNameSpace;
using EntranceOfApp;
using UserInterFaceNamespace;
using PlayerNameSpace; 
namespace App
{

    public class EntryToAPP
    {

        static void Main(string[] args)
        {
            //intro
            Console.WriteLine("Hello, What is your name?");
            string name = Console.ReadLine();
            //makes sure that you are of legal 
            Entrance entranceToBeLetIn = new(name);
            entranceToBeLetIn.checkingForLegalAgeForEntrance();
            IUserInterface diceGame = new DiceGame(name);
            diceGame.startGame();
            

        }


    }


}