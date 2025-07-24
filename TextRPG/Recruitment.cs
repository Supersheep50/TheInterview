using System.ComponentModel.DataAnnotations;

namespace TextRPG
{
    class Recruiter : Player
    {
        public Recruiter()
        {
            Title = "Recruiter";
            Health = "100";
        }
        public override void Attack()
        {
            Console.WriteLine("You launch into a LifeStory!");
        }

        public static Recruiter RecruiterPath()

        {
            Recruiter TA = new Recruiter();

            while (true)
            {

                Console.WriteLine("You chose Recruiter!");
                Console.WriteLine("This is like the equivalant of choosing Bulbasar but thats okay!");
                Console.WriteLine("Alright then, lets hear about some of your skills then.");
                Console.WriteLine("You have 100 attribute points. Please assign them to these 3 skills.");
                Console.WriteLine("1.Interviewing 2.Admin 3.Grit");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("How many points would you like to assign to Interviewing?");
                TA.Interviewing = int.Parse(Console.ReadLine());
                Console.WriteLine("How many points would you like to assign to Admin");
                TA.Admin = int.Parse(Console.ReadLine());
                Console.WriteLine("How many points would you like to assign to Grit?");
                TA.Grit = int.Parse(Console.ReadLine());

                Console.ResetColor();

                int total = TA.Typing + TA.ProblemSolving + TA.Smugness;

                if (total == 100)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nPlayer Created!");
                    Console.ResetColor();

                    Console.WriteLine($"\nTitle: {TA.Title}");
                    Console.WriteLine($"Health: {TA.Health}");
                    Console.WriteLine($"Inter: {TA.Interviewing}");
                    Console.WriteLine($"Problem Solving: {TA.Admin}");
                    Console.WriteLine($"Smugness: {TA.Grit}");

                    return TA;
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
        }

            
            
        }
    

