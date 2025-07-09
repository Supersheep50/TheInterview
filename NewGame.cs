namespace TextRPG
{

    class NewGame
    {
        public static void PlayerCreation()
        {

            Console.WriteLine("Hey there Candidate! Lets take a look at this CV....");
            Console.WriteLine("Wow, that is a pretty terrible name");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter your name");
            string userName = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine($"Alright, I'll call you {userName} if you insist");
        }
    }
}