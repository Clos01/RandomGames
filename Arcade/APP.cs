


using System.Security.Cryptography.X509Certificates;
using AgeNameSpace;

namespace App
{

    public class EntryToAPP
    {

        static void Main(string[] args)
        {

            AgeVerifier checkForLegalAge = new AgeVerifier();

            Console.WriteLine("Hello, What is your name?");
            string? name = Console.ReadLine();
            Console.WriteLine($"Whats up {name}, let me see your ID. (Type in Age.)");

            if (int.TryParse(Console.ReadLine(), out int age))
            {
                bool isOldEnough = checkForLegalAge .VerifyOfLegalAge(age);
                if (isOldEnough)
                {
                    Console.WriteLine("Welcome to the Arcade!");
                }
                else
                {
                    Console.WriteLine("Sorry, you are not old enough to enter the Arcade.");
                }


            }


        }


    }


}