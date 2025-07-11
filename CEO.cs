namespace TextRPG
{
    class CEO : Player
    {
        public void Asshole()
        {
            Name = "CEO";
            Health = "1";
        }
        public override void Attack()
        {
            Console.WriteLine("You layoff half of your employees!");
        }

        public static void CEOPath()
        {
            Console.WriteLine("You chose CEO!");
            Console.WriteLine("Oh.");
            Console.WriteLine("Well...that's a choice.");
            Console.WriteLine("Alright then, lets hear about some of your skills then.");
            Console.WriteLine("You have 100 attribute points. Please assign them to these 3 skills.");
            Console.WriteLine("1.Waffle 2.Core Values 3.Redundancy");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("How many points would you like to assign to Waffle?");
        }
    }
}
