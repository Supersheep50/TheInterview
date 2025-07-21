namespace TextRPG
{

    class NewGame
    {
        public static void PlayerSelection()
        {

            MainMenu.TypeWriter("Hey there Candidate! Welcome to NotMeta, lets head to the interview room.");
            MainMenu.TypeWriter("My name is Gene. I'm the Interview Coordinator and a pyscopath.");
            MainMenu.TypeWriter("Haha thats just one of my jokes. You'll get used to them. Probably.");
            MainMenu.TypeWriter("Lets take a look at this CV....");
            MainMenu.TypeWriter("Wow, that is a pretty terrible name");
            Console.ForegroundColor = ConsoleColor.Red;
            MainMenu.TypeWriter("Please enter your name");
            string userName = Console.ReadLine();
            Console.ResetColor();
            MainMenu.TypeWriter($"Alright, I'll call you {userName} if you insist");
            MainMenu.TypeWriter($"Now {userName}, what role are you here to interview for?");
            MainMenu.TypeWriter("1.Software Development 2.Recruitment 3.Sales 4.CEO");
            Console.ForegroundColor = ConsoleColor.Red;
            MainMenu.TypeWriter("Please choose an option");
            string jobChoice = Console.ReadLine();
            Console.ResetColor();

            Player player;

            switch (jobChoice)
            {

                case "1":
                    player = new SoftwareDev();
                    SoftwareDev.SoftwareDevPath();
                    break;
                case "2":
                    player = new Recruiter();
                    Recruiter.RecruiterPath();
                    break;
                case "3":
                    player = new Sales();
                    Sales.SalesPath();
                    break;
                case "4":
                    player = new CEO();
                    CEO.CEOPath();
                    break;
                
            }

        }
    }
}