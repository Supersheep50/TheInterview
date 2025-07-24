namespace TextRPG
{
    class Sales : Player
    {
        public void AccountManager()
        {
            Title = "Sales";
            Health = "100";
        }
        public override void Attack()
        {
            Console.WriteLine("You launch into a pitch!");
        }

        public static void SalesPath()
        {
            Console.WriteLine("You chose Sales!");
            Console.WriteLine("Wow, you really hate yourself don't you?");
            Console.WriteLine("Alright then, lets hear about some of your skills then.");
            Console.WriteLine("You have 100 attribute points. Please assign them to these 3 skills.");
            Console.WriteLine("1.Pitching 2.Lying 3.Sadness");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("How many points would you like to assign to Pitching?");
        }
    }
}
