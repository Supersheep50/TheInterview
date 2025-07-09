namespace TextRPG
{
        class MainMenu
    {
        public static void Menu()
        {   
            // Main Menu 
            Console.WriteLine("------------");
            Console.WriteLine("THE INTERVIEW");
            Console.WriteLine("------------");
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Save Game");
            Console.WriteLine("3. Load Game");
            Console.WriteLine("4. About");
            Console.WriteLine("5. Exit");
            Console.WriteLine("------------");

            while (true)
            {
                Console.WriteLine("Welcome to The Interview!");
                Console.WriteLine("This is a Text Based RPG adventure where you play a poor lowly candidate");
                Console.WriteLine("Your goal is to get the job of your dreams at NotMeta Corp");
                Console.WriteLine("Good luck!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please choose an option from the menu");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {

                    case "1":
                        NewGame.PlayerCreation();
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
}