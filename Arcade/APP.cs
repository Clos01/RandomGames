


using System.Security.Cryptography.X509Certificates;
using AgeNameSpace;
using RockPaperScissorNameSpace;
using EntranceOfApp; 
namespace App
{

    public class EntryToAPP
    {

        static void Main(string[] args)
        {

             Console.WriteLine("Hello, What is your name?");
            string name = Console.ReadLine();

                // Console.WriteLine($"Whats up {userName}, let me see your ID. (Type in Age.)");
            GameSelector gameSelector = new GameSelector(name); 
            gameSelector.test();
            RockPaperScissorsGame playRPC = new RockPaperScissorsGame(name);
            playRPC.WelcomePlayer();
            playRPC.startGame();
        }


    }


}