
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
                Console.WriteLine("");
                Console.WriteLine("");

                MainMenu.TypeWriter("Gene: Software Dev Path has been chosen! Sorry that was a bit dramatic...");
                MainMenu.TypeWriter("Gene: So you like Anime eh? Have you ever showered? Sorry I can't think of any other stereotypes....");
                MainMenu.TypeWriter("Gene: I'm in HR we're allowed say that. We can also sleep with the CEO.");
                MainMenu.TypeWriter("Gene: Actually are you a Coldplay fan? Nevermind.");
                Console.WriteLine("");
                MainMenu.TypeWriter("Gene: Alright then, lets hear about some of your skills.");
                MainMenu.TypeWriter("Gene: You have 100 attribute points. Please assign them to these 3 skills.");
                Console.WriteLine("");

                MainMenu.TypeWriter("1.Typing ");
                MainMenu.TypeWriter("2.Problem Solving ");
                MainMenu.TypeWriter("3.Smugness");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("How many points would you like to assign to Typing?");
                Console.WriteLine(">>");
                dev.Typing = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("How many points would you like to assign to Problem Solving?");
                Console.WriteLine(">>");
                dev.ProblemSolving = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("How many points would you like to assign to Smugness?");
                Console.WriteLine(">>");
                dev.Smugness = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.ResetColor();

                int total = dev.Typing + dev.ProblemSolving + dev.Smugness;


                if (total == 100)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                   Console.WriteLine(@"
                            +----------------------+
                            |  🧙 Player Created! 🗡️ |
                            +----------------------+
                            ");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Green;
                    MainMenu.TypeWriter("Mysterious Voice: Go forth young candidate and save the universe. We need you.");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    MainMenu.TypeWriter("You: What do you mean save the universe? I'm just here for a job interview. Who's speaking?");
                    MainMenu.TypeWriter("You: This has been a super weird experience so far.");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Green;
                    MainMenu.TypeWriter("Mysterious Voice: Oh uhh...nevermind me. Off you pop...💨");

                    Console.WriteLine("\nPress ENTER to continue...");
                    Console.ReadLine();
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
                    Console.WriteLine("");
                    MainMenu.TypeWriter("Alright well before we get too deep into this shizzle, maybe you should save your progress?");
                    Console.WriteLine("");

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

            MainMenu.TypeWriter("Gene: Wow you look like a strong candidate.");
            MainMenu.TypeWriter("Gene: You might last longer than the last candidate, god rest her soul.");
            MainMenu.TypeWriter("Gene: Anyway, lets get into it. There will be 3 Rounds of interviews.");
            MainMenu.TypeWriter("Gene: Round 1 is with John, he's our HR guy. Loves to chat.");
            MainMenu.TypeWriter("Gene: Next up is Sheila, shes our Engineering Lead and has been here an eternity.");
            MainMenu.TypeWriter("Gene: Finally, you'll meet Galgomel, harbinger of souls. He's a PM");
            MainMenu.TypeWriter("Gene: Excited?");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Red;
            MainMenu.TypeWriter("Please enter Yes or No");
            Console.WriteLine(">>");

            string excitedAnswer = Console.ReadLine();
            Console.ResetColor();

            if (excitedAnswer == "Yes" | excitedAnswer == "Y" | excitedAnswer == "yes")
            {
                Console.WriteLine("");
                MainMenu.TypeWriter("Gene: Hmm...you really don't look it.");
                MainMenu.TypeWriter("Gene: Nevermind, not like you can leave any time you want. Which of course you can");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");

                MainMenu.TypeWriter("Gene was still smiling. It was as if he had been staring past me the entire time.");
                MainMenu.TypeWriter("I could feel sweat start to gather on my brow, I didn't want to wipe it away and hoped he couldn't see it.");
                MainMenu.TypeWriter("So far this process has been quite different than when I interviewed at Intercom.");
                MainMenu.TypeWriter("As long as you were a white man you had no issues getting into Intercom, this felt like it might be quite different.");
                Console.WriteLine("");

                Console.ResetColor();
                MainMenu.TypeWriter($"Gene: Alright {Player.Name} I think its time for you to meet with John. Please wait here.");
                MainMenu.TypeWriter("Gene: If I were you I wouldn't go anywhere. Although if I were you I'd wouldn't here in the first place.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                Console.WriteLine("\nPress ENTER to relax...");
                Console.ReadLine();
                Console.WriteLine("");

                MainMenu.TypeWriter("Finally I could be alone for a few minutes.");
                MainMenu.TypeWriter("Maybe it's just this Gene guy that's throwing me off? ");
                MainMenu.TypeWriter("Strange though, I feel like I can hear whispering coming from inside the room. Or someone looking at me?", 50);
                MainMenu.TypeWriter("Or wait...is someone standing awfully close to me? Scanning the room, I see nothing.", 50);
                MainMenu.TypeWriter("..........", 60);
                MainMenu.TypeWriter("Maybe, I should try the door? Just so I know in my own mind I can leave. I could be really quiet.", 60);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");

                MainMenu.TypeWriter("Open the door?");
                MainMenu.TypeWriter("Yes or no?");
                Console.WriteLine(">>");

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
                    MainMenu.TypeWriter("Hmm. There's that smell of chlorine again....");
                    Console.WriteLine("");

                    MainMenu.TypeWriter("You suddenyl realize whats happening. But its too late.");
                    MainMenu.TypeWriter("You died of poisoning.");
                    Console.WriteLine("");

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
                MainMenu.TypeWriter("Gene: Oh wow. Honesty the best policy eh?");
                MainMenu.TypeWriter("Gene: Well how aboiut I shoot you in the face? How is that huh?");
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

    
    

    



