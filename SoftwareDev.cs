
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
                Console.WriteLine("Software Dev Path has been chosen! Sorry that was a bit dramatic...");
                Console.WriteLine("Alright then, lets hear about some of your skills.");
                Console.WriteLine("You have 100 attribute points. Please assign them to these 3 skills.");
                Console.WriteLine("1.Typing 2.Problem Solving 3.Smugness");
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
                    Console.WriteLine("\nPlayer Created!");
                    Console.ResetColor();

                    Console.WriteLine($"\nTitle: {dev.Title}");
                    Console.WriteLine($"Health: {dev.Health}");
                    Console.WriteLine($"Typing: {dev.Typing}");
                    Console.WriteLine($"Problem Solving: {dev.ProblemSolving}");
                    Console.WriteLine($"Smugness: {dev.Smugness}");
                    SWERoundOne();
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
         public static SoftwareDev SWERoundOne() {

            Console.WriteLine("Wow you look like a strong candidate.");
            MainMenu.TypeWriter("Lets get into it. There will be 3 Rounds of interviews.");
            MainMenu.TypeWriter("Round 1 is with John, he's our HR guy. Loves to chat.");
            MainMenu.TypeWriter("Next up is Sheila, shes our Engineering Lead and has been here an eternity.");
            MainMenu.TypeWriter("Finally, you'll meet Galgomel, harbinger of souls. He's a PM");
            MainMenu.TypeWriter("Excited?");
            Console.ForegroundColor = ConsoleColor.Red;
            MainMenu.TypeWriter("Please enter Yes or No");
            string excitedAnswer = Console.ReadLine();

            if (excitedAnswer == "Yes" | excitedAnswer == "Y" | excitedAnswer == "yes")
            {
                MainMenu.TypeWriter("Hmm...you really don't look it.");


            }
            else
            {
                MainMenu.TypeWriter("Oh wow. Honesty the best policy eh?");
                MainMenu.TypeWriter("Well how aboiut I shoot you in the face? How is that huh?");
                Console.ForegroundColor = ConsoleColor.Magenta;
                MainMenu.TypeWriter("");
            }




            return null; 
        
            }
    }
}

    
    

    



