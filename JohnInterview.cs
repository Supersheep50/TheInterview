namespace TextRPG
{

    public class JohnInterview
    {

        public static void JohnInterviewLevel()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            MainMenu.TypeWriter("You stand up and walk towards the door.");
            MainMenu.TypeWriter("It's as if the whispering gets louder and louder the closer you get to it.");
            MainMenu.TypeWriter("Reaching your hand out towards the door handle you can already feel the cold eminating from it.");
            MainMenu.TypeWriter("......");
            MainMenu.TypeWriter("Before you can open it the door whooshes open");
            MainMenu.TypeWriter("Standing in the doorway is John.");
            Console.ResetColor();
            MainMenu.TypeWriter(@"Art by Elissa Potier
      ////^\\\\
      | ^   ^ |
     @ (o) (o) @
      |   <   |
      |  ___  |
       \_____/
     ____|  |____
    /    \__/    \
   /              \
  /\_/|        |\_/\
 / /  |        |  \ \
( <   |        |   > )
 \ \  |        |  / /
  \ \ |________| / /
   \ \|");
            Console.ForegroundColor = ConsoleColor.Yellow;
            MainMenu.TypeWriter("He has a blank expression on his face. Like he's not suprised you tried to open the door.");
            Console.ResetColor();
            MainMenu.TypeWriter($"Please, take a seat {Player.Name}");
            MainMenu.TypeWriter("Apologies for making you wait.");
            MainMenu.TypeWriter("This interview will test your Problem Solving ability.");
            MainMenu.TypeWriter("You will be asked 3 questions. For each question right you will gain 10 points for Problem Solving.");
            MainMenu.TypeWriter("For every question you get wrong, you will lose 10 points. Aftert that, we shall fight to the death.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            MainMenu.TypeWriter("Excuse me?");
            Console.ResetColor();
            MainMenu.TypeWriter("We shall fight to the death.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            MainMenu.TypeWriter("Yes I heard that but bit but what does it mean?");
            Console.ForegroundColor = ConsoleColor.White;
            MainMenu.TypeWriter("It means exactly what it means. One of us will perish, you most likely.");
            MainMenu.TypeWriter("Now, no more nonsense let us begin.");
            MainMenu.TypeWriter("What gets wetter the more you dry it?");
            Console.ForegroundColor = ConsoleColor.Red;
            MainMenu.TypeWriter("1. Humour 2. A Towel 3. Your Hair");
            MainMenu.TypeWriter("Please choose an answer.");

        }
    }
}