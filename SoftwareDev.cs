namespace TextRPG
{
    class SoftwareDev : Player
    {
        public SoftwareDev()
        {
            Name = "Software Developer";
            Health = "100";
        }
        public override void Attack()
        {
            Console.WriteLine("You launch a stack overflow attack!");
        }

        public static SoftwareDev SoftwareDevPath()
        {
            SoftwareDev dev = new SoftwareDev();

            Console.WriteLine("Software Dev Path has been chosen! Sorry that was a bit dramatic...");
            Console.WriteLine("Alright then, lets hear about some of your skills then.");
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

              if (total != 100)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nInvalid total. You assigned {total}, but need exactly 100 points.");
                Console.ResetColor();
                return null;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPlayer Created!");
            Console.ResetColor();

            Console.WriteLine($"\nName: {dev.Title}");
            Console.WriteLine($"Health: {dev.Health}");
            Console.WriteLine($"Typing: {dev.Typing}");
            Console.WriteLine($"Problem Solving: {dev.ProblemSolving}");
            Console.WriteLine($"Smugness: {dev.Smugness}");

            return dev;
        }

            

        }

    }
    

    



