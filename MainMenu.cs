using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading; 


namespace TextRPG
{
    public class MainMenu
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
                TypeWriter("Welcome to The Interview!");
                TypeWriter("This is a Text Based RPG adventure where you play a poor lowly candidate");
                TypeWriter("Your goal is to get the job of your dreams at NotMeta Corp");
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
                        TypeWriter("This doesn't work yet, sorry about that");
                        continue;
                    case "3":
                        TypeWriter("This will work someday I promise");
                        continue;
                    case "4":
                        TypeWriter("Steph is probably reading this and shes knows all about me.");
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





            }




        }
    