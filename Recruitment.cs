namespace TextRPG
{
    class Recruitment : Player
    {
        public void Recruiter()
        {
            Title = "Recruiter";
            Health = "100";
        }
        public override void Attack()
        {
            Console.WriteLine("You launch into a LifeStory!");
        }

        public static void RecruiterPath()
        {
            Console.WriteLine("You chose Recruiter!");
            Console.WriteLine("This is like the equivalant of choosing Bulbasar but thats okay!");
            Console.WriteLine("Alright then, lets hear about some of your skills then.");
            Console.WriteLine("You have 100 attribute points. Please assign them to these 3 skills.");
            Console.WriteLine("1.Interviewing 2.Admin 3.Grit");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("How many points would you like to assign to Interviewing?");
        }
    }
}
