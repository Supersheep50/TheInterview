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
            MainMenu.TypeWriter("");
        }
    }
}