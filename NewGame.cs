namespace TextRPG
{

    class NewGame
    {
        public static void PlayerSelection()
        {

            Console.WriteLine("Hey there Candidate! Welcome to NotMeta, lets head to the interview room.");
            Console.WriteLine("Lets take a look at this CV....");
            Console.WriteLine("Wow, that is a pretty terrible name");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter your name");
            string userName = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine($"Alright, I'll call you {userName} if you insist");
            Console.WriteLine($"Now {userName}, what role are you here to interview for?");
            Console.WriteLine("1.Software Development 2.Recruitment 3.Sales 4.CEO");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please choose an option");
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
                    //tbd 
                    break;
                case "3":
                    //tbd
                    break;
                case "4":
                    //tbd
                    break;
                case "5":
                    //tbd
                    break;
            }

        }
    }
}