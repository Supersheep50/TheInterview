

using System.Reflection.Metadata.Ecma335;

namespace TextRPG
{
    class SoftwareDev : Player
    {
        public void Dev()
        {
            Name = "Software Developer";
            Health = "100";
        }
        public override void Attack()
        {
            Console.WriteLine("You launch a stack overflow attack!");
        }

        public static void SoftwareDevPath()
        {

            Console.WriteLine("Software Dev Path has been chosen!");
            Console.WriteLine("Alright then, lets hear about some of your skills then.");
            Console.WriteLine("You have 100 attribute points. Please assign to these 3 skills.");
            Console.WriteLine("1.Typing 2.Problem Solving 3.Smugness");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("How many points woul you like to assing to Typing?");


        }

    }
    

    
}


