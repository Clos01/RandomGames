using UserInterFaceNamespace;
namespace RockPaperScissorNameSpace
{
    public class RockPaperScissorsGame : IUserInterface
    {
        //fields 
        public Random random = new Random();
        //greet player
        public void WelcomePlayer()
        {
            Console.WriteLine("This game is RockPaperScissors\nHow to play?????\t(Type your response in the console.) \n\t-Rock Beats Scissors\t-Paper Beats Rock\t-Scissors beats Paper\n\t-if you have the same as the computer you have tied");
        }
        //will run the game logic 
        public void startGame()
        {
            getComputerChoice();
            choicesOfRockPaperScissors();
             string userChoice = Console.ReadLine().ToLower();
            Choices(userChoice, getComputerChoice());
            OutComeWinner(userChoice,getComputerChoice());
            

        }
        public string getComputerChoice() //This method encapsulates the logic for determining the computer's choice, making it a pure function that's easy to test.
        {
            List<string> choiceOfRockPaperScissors = new List<string> { "rock", "paper", "scissors" };
            return choiceOfRockPaperScissors[random.Next(choiceOfRockPaperScissors.Count)];
        }

        public void choicesOfRockPaperScissors()
        {
            Console.WriteLine($"What is your choice 'Rock', 'Paper', 'Scissors'");
           

        }
        public string Choices(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
            {
                return "it was a tie";
            }
            else if ((userChoice == "rock" && computerChoice == "scissors") ||
                             (userChoice == "paper" && computerChoice == "rock") ||
                             (userChoice == "scissors" && computerChoice == "paper"))
            {
                return "You won!";
            }
            else
            {
                return "You lost";
            }
        }

        public void OutComeWinner(string userChoice, string computerChoice){
             Console.WriteLine($"Your choice: {userChoice}, Computer's choice: {computerChoice}");
    Console.WriteLine(Choices(userChoice, computerChoice));
        }



    }

}
