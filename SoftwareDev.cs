
using System.ComponentModel.Design;

namespace TextRPG
{
    class SoftwareDev : Player
    {
        public SoftwareDev()
        {
            Title = "Software Developer";
            Health = "100";
        }
        public override void Attack()
        {
            Console.WriteLine("You launch a stack overflow attack!");
        }

        public static SoftwareDev SoftwareDevPath()
        {
            SoftwareDev dev = new SoftwareDev();

            while (true)
            {
                MainMenu.TypeWriter("Software Dev Path has been chosen! Sorry that was a bit dramatic...");
                MainMenu.TypeWriter("Alright then, lets hear about some of your skills.");
                MainMenu.TypeWriter("You have 100 attribute points. Please assign them to these 3 skills.");
                MainMenu.TypeWriter("1.Typing 2.Problem Solving 3.Smugness");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("How many points would you like to assign to Typing?");
                dev.Typing = int.Parse(Console.ReadLine());
                Console.WriteLine("How many points would you like to assign to Problem Solving?");
                dev.ProblemSolving = int.Parse(Console.ReadLine());
                Console.WriteLine("How many points would you like to assign to Smugness?");
                dev.Smugness = int.Parse(Console.ReadLine());

                Console.ResetColor();

                int total = dev.Typing + dev.ProblemSolving + dev.Smugness;


                if (total == 100)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    MainMenu.TypeWriter("\nPlayer Created!");
                    Console.ResetColor();

                    MainMenu.TypeWriter($"\nTitle: {dev.Title}");
                    MainMenu.TypeWriter($"Health: {dev.Health}");
                    MainMenu.TypeWriter($"Typing: {dev.Typing}");
                    MainMenu.TypeWriter($"Problem Solving: {dev.ProblemSolving}");
                    MainMenu.TypeWriter($"Smugness: {dev.Smugness}");
                    GameState.CurrentProgress = new GameProgress
                    {
                        Player = dev,
                        CurrentStage = "SWE_Round1"
                    };

                    MainMenu.TypeWriter("Alright well before we get too deep into this shizzle, maybe you should save your progress?");
                    MainMenu.TypeWriter("Would you like to:");
                    MainMenu.TypeWriter("1. Save and continue");
                    MainMenu.TypeWriter("2. Save and exit to main menu");
                    MainMenu.TypeWriter("3. Continue without saving");

                    string saveChoice = Console.ReadLine();

                    switch (saveChoice)
                    {
                        case "1":
                            SaveSystem.Save();
                            break;

                        case "2":
                            SaveSystem.Save();
                            MainMenu.TypeWriter("Game saved. Returning to main menu...");
                            MainMenu.Menu();
                            return null;

                        case "3":
                            MainMenu.TypeWriter("Okay, continuing without saving.");
                            break;

                        default:
                            MainMenu.TypeWriter("Invalid choice. Continuing without saving.");
                            break;
                    }


                    SWERoundOne(dev);
                   }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nInvalid total. You assigned {total}, but need exactly 100 points.");
                    Console.WriteLine("Please try again");
                    Console.ResetColor();

                }
                   
            }

        }
         public static SoftwareDev SWERoundOne(SoftwareDev dev) {

            MainMenu.TypeWriter("Wow you look like a strong candidate.");
            MainMenu.TypeWriter("Lets get into it. There will be 3 Rounds of interviews.");
            MainMenu.TypeWriter("Round 1 is with John, he's our HR guy. Loves to chat.");
            MainMenu.TypeWriter("Next up is Sheila, shes our Engineering Lead and has been here an eternity.");
            MainMenu.TypeWriter("Finally, you'll meet Galgomel, harbinger of souls. He's a PM");
            MainMenu.TypeWriter("Excited?");
            Console.ForegroundColor = ConsoleColor.Red;
            MainMenu.TypeWriter("Please enter Yes or No");
            string excitedAnswer = Console.ReadLine();
            Console.ResetColor();

            if (excitedAnswer == "Yes" | excitedAnswer == "Y" | excitedAnswer == "yes")
            {
                MainMenu.TypeWriter("Hmm...you really don't look it.");
                MainMenu.TypeWriter("Nevermind, not like you can leave any time you want. Which of course you can");
                Console.ForegroundColor = ConsoleColor.Yellow;
                MainMenu.TypeWriter("Gene was still smiling. It was as if he had been staring past me the entire time.");
                MainMenu.TypeWriter("I could feel sweat start to gather on my brow, I didn't want to wipe it away and hoped he couldn't see it.");
                MainMenu.TypeWriter("So far this process has been quite different than when I interviewed at Intercom.");
                MainMenu.TypeWriter("As long as you were a white man you had no issues getting into Intercom, this felt like it might be quite different.");
                Console.ResetColor();
                MainMenu.TypeWriter($"Alright {Player.Name} I think its time for you to meet with John. Please wait here.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                MainMenu.TypeWriter("Finally I could be alone for a few minutes.");
                MainMenu.TypeWriter("Strange, I feel I can hear whispering coming from inside the room. Or someone looking at me.");
                MainMenu.TypeWriter("Or that someone is standing awfully close to me. Scanning the room, I see nothing.");
                MainMenu.TypeWriter("Maybe, I should try the door? Just so I know in my own mind I can leave. I could be really quiet.");
                Console.ForegroundColor = ConsoleColor.Red;
                MainMenu.TypeWriter("Open the door?");
                MainMenu.TypeWriter("Yes or no?");
                string OpenTheDoor = Console.ReadLine();

                if (OpenTheDoor == "yes" | OpenTheDoor == "Yes" | OpenTheDoor == "y")
                {
                    JohnInterview.JohnInterviewLevel(dev);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    MainMenu.TypeWriter("You go and sit back down on the seat. Shaking your head at the ridiculousness of your feelings and anxiety.");
                    MainMenu.TypeWriter("How silly you think, this is just an interview and my nerves are getting to me.");
                    MainMenu.TypeWriter("Glancing back at the door you think you notice some vapour coming in at the bottom.");
                    MainMenu.TypeWriter("Hmm. There'sthat smell of chlorine again.");
                    MainMenu.TypeWriter("You suddenyl realize wahts happening. But its too late.");
                    MainMenu.TypeWriter("You died of poisoning.");
                    MainMenu.TypeWriter(@"   ____    _    __  __ _____    _____     _______ ____  
                                        / ___|  / \  |  \/  | ____|  / _ \ \   / / ____|  _ \ 
                                        | |  _  / _ \ | |\/| |  _|   | | | \ \ / /|  _| | |_) |
                                        | |_| |/ ___ \| |  | | |___  | |_| |\ V / | |___|  _ < 
                                        \____/_/   \_\_|  |_|_____|  \___/  \_/  |_____|_| \_\");
                    MainMenu.TypeWriter("");
                    MainMenu.TypeWriter("");

                    Console.ResetColor();
                    MainMenu.Menu();
                }


            }
            else
            {
                MainMenu.TypeWriter("Oh wow. Honesty the best policy eh?");
                MainMenu.TypeWriter("Well how aboiut I shoot you in the face? How is that huh?");
                Console.ForegroundColor = ConsoleColor.Magenta;
                MainMenu.TypeWriter("Gene shot you in the face. You Died.");
                MainMenu.TypeWriter(@"   ____    _    __  __ _____    _____     _______ ____  
                                        / ___|  / \  |  \/  | ____|  / _ \ \   / / ____|  _ \ 
                                        | |  _  / _ \ | |\/| |  _|   | | | \ \ / /|  _| | |_) |
                                        | |_| |/ ___ \| |  | | |___  | |_| |\ V / | |___|  _ < 
                                        \____/_/   \_\_|  |_|_____|  \___/  \_/  |_____|_| \_\");
                MainMenu.TypeWriter("");
                MainMenu.TypeWriter("");

                Console.ResetColor();
                MainMenu.Menu();
            }




            return null; 
        
            }
    }
}

    
    

    



