using System;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading; 


namespace TextRPG
{
    public class MainMenu
    {
        public static void Menu()


        // Intro art (need to make file later)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
     ______                        ______
  .-'      '-.                  .-'      '-.
 /          \    THE INTERVIEW /          \
|            |                |            |
|,  .-.  .-.  ,|              |,  .-.  .-.  ,|
| )(_o/  \o_)( |              | )(_o/  \o_)( |
|/     /\     \|              |/     /\     \|
(_     ^^     _)              (_     ^^     _)
 \__|IIIIII|__/                \__|IIIIII|__/
  | \IIIIII/ |                  | \IIIIII/ |
  \          /                  \          /
   `--------`                    `--------`

.___________. __    __   _______                                                             
|           ||  |  |  | |   ____|                                                            
`---|  |----`|  |__|  | |  |__                                                               
    |  |     |   __   | |   __|                                                              
    |  |     |  |  |  | |  |____                                                             
    |__|     |__|  |__| |_______|                                                            
                                                                                             
 __  .__   __. .___________. _______ .______     ____    ____  __   ___________    __    ____
|  | |  \ |  | |           ||   ____||   _  \    \   \  /   / |  | |   ____\   \  /  \  /   /
|  | |   \|  | `---|  |----`|  |__   |  |_)  |    \   \/   /  |  | |  |__   \   \/    \/   / 
|  | |  . `  |     |  |     |   __|  |      /      \      /   |  | |   __|   \            /  
|  | |  |\   |     |  |     |  |____ |  |\  \----.  \    /    |  | |  |____   \    /\    /   
|__| |__| \__|     |__|     |_______|| _| `._____|   \__/     |__| |_______|   \__/  \__/    
");
            Console.ResetColor();






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
                TypeWriter("Welcome to The Interview!");
                TypeWriter("This is a Text Based RPG adventure where you play a poor lowly candidate");
                TypeWriter("Your goal is to get the job of your dreams at NotMeta Corp");
                TypeWriter("But proceed with caution....");
                TypeWriter("Good luck!");
                Console.WriteLine();
                Console.WriteLine();
                TypeWriter("Please choose an option from the menu");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {

                    case "1":
                        NewGame.PlayerSelection();
                        break;
                    case "2":
                        SaveSystem.Save();
                        break;
                    case "3":
                        SaveSystem.Load();
                        ResumeGame();
                        break;
                    case "4":
                        About.AboutInfo();
                        continue;
                    case "5":
                        TypeWriter("See ya later alligator!");
                        Environment.Exit(0);
                        break;

                }
            }
        }


        // slow text effect

        public static void TypeWriter(string text, int delay = 10)
        {

            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
private static void ResumeGame()
{
    var progress = GameState.CurrentProgress;
    if (progress == null || progress.Player == null)
    {
        TypeWriter("No saved game to resume.");
        return;
    }

    switch (progress.CurrentStage)
    {
        case "SWE_Round1":
            var dev = new SoftwareDev();
            SoftwareDev.SWERoundOne(dev);
            break;
        default:
            TypeWriter("Saved stage not recognized.");
            break;
    }
}







            }




        }
    