using AgeNameSpace;
//this will be to call the different game collections as randomly

namespace EntranceOfApp
{
    public class Entrance
    {
        AgeVerifier checkForLegalAge = new AgeVerifier();

        private string userName;
        public Entrance(string name)
        {
            userName = name;
        }
        public void checkingForLegalAgeForEntrance()
        {
            Console.WriteLine($"Whats up {userName}, let me see your ID. (Type in Age.)");

            if (int.TryParse(Console.ReadLine(), out int age))
            {
                bool isOldEnough = checkForLegalAge.VerifyOfLegalAge(age);
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


