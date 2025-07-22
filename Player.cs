using System.Security.Cryptography;

namespace TextRPG
{

    public abstract class Player
    {
        public string Title { get; set; }
        public string Health { get; set; }

        public int Typing { get; set; }

        public int ProblemSolving { get; set; }

        public int Smugness { get; set; }

        public int Interviewing { get; set; }

        public int Admin { get; set; }

        public int Grit { get; set; }


        public abstract void Attack();

        public static string Name;
        public static void PlayerName()
        {

            MainMenu.TypeWriter("Huh, I can see why the Hiring Manager wanted to talk to you. Is this your real name?");
            Console.ForegroundColor = ConsoleColor.Red;
            MainMenu.TypeWriter("Please enter your name");
            Name = Console.ReadLine();
            Console.ResetColor();
    
        }
    

    }
}