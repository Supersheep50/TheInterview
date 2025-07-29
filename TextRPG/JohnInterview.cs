namespace TextRPG
{

    public class JohnInterview
    {

        public static void JohnInterviewLevel(Player currentPlayer)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            MainMenu.TypeWriter("You stand up and walk towards the door.", 10);
            MainMenu.TypeWriter("It's as if the whispering gets louder and louder the closer you get to it.", 10);
            MainMenu.TypeWriter("Reaching your hand out towards the door handle you can already feel the cold eminating from it.", 10);
            MainMenu.TypeWriter("......", 10);
            MainMenu.TypeWriter("Before you can open it the door whooshes open");
            MainMenu.TypeWriter("Standing in the doorway is John.");
            Console.ResetColor();
            Console.WriteLine("\nPress ENTER to open your eyes...");
            Console.ReadLine();
            Console.WriteLine(@"Art by Elissa Potier
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
            Console.WriteLine("");
            Console.WriteLine("");

            MainMenu.TypeWriter($"John: Please, take a seat {Player.Name}");
            MainMenu.TypeWriter("John: Apologies for making you wait.");
            MainMenu.TypeWriter("John: This interview will test your Problem Solving ability.");
            MainMenu.TypeWriter("John: You will be asked 3 questions. For each question right you will gain 10 points for Problem Solving.");
            MainMenu.TypeWriter("John: For every question you get wrong, you will lose 10 points. After that, we shall fight to the death.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            MainMenu.TypeWriter("Excuse me?");
            Console.WriteLine("");

            Console.ResetColor();
            MainMenu.TypeWriter("John: We shall fight to the death.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");

            MainMenu.TypeWriter("John: Yes I heard that bit but what does it mean?");
            Console.ForegroundColor = ConsoleColor.White;
            MainMenu.TypeWriter("John: It means exactly what it means. One of us will perish, you most likely.");
            MainMenu.TypeWriter("John: Now, no more nonsense let us begin.");
            Console.WriteLine("");

            MainMenu.TypeWriter($"Your Problem Solving skill level is currently {currentPlayer.ProblemSolving}");
            Console.WriteLine("");

            MainMenu.TypeWriter("What gets wetter the more you dry it?");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");

            MainMenu.TypeWriter("1. Humour");
            MainMenu.TypeWriter("2. A Towel");
            MainMenu.TypeWriter("3. Your Hair");
            MainMenu.TypeWriter("Please choose an answer.");
            MainMenu.TypeWriter(">>");

            
            string question1 = Console.ReadLine();
            Console.ResetColor();

            if (question1 == "2")
            {
                currentPlayer.ProblemSolving += 10;
                Console.WriteLine("");
                MainMenu.TypeWriter("Wow, I'm impressed. 10 points for Grffindor.");
                MainMenu.TypeWriter($"Your Problem Solving skill level is now {currentPlayer.ProblemSolving}");

            }
            else
            {
                currentPlayer.ProblemSolving -= 10;
                Console.WriteLine("");
                MainMenu.TypeWriter("Oh dear. No. No that's wrong.");
                MainMenu.TypeWriter($"Your Problem Solving skill level is now {currentPlayer.ProblemSolving}");


            }
            Console.WriteLine("");
            MainMenu.TypeWriter($"Alright then, here's Question 2. Listen up {Player.Name}.");
            Console.WriteLine("");

            MainMenu.TypeWriter("What has a neck but no head?");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");

            MainMenu.TypeWriter("1. A Giraffe ");
            MainMenu.TypeWriter("2. A Bottle");
            MainMenu.TypeWriter("3. You");

            MainMenu.TypeWriter("Please choose an answer.");
            string question2 = Console.ReadLine();
            Console.ResetColor();

            if (question2 == "2")
            {
                currentPlayer.ProblemSolving += 10;
                Console.WriteLine("");
                MainMenu.TypeWriter("I guess you only look like an idiot then.");
                MainMenu.TypeWriter($"Your Problem Solving skill level is now {currentPlayer.ProblemSolving}");

            }
            else
            {
                currentPlayer.ProblemSolving -= 10;
                Console.WriteLine("");
                MainMenu.TypeWriter("No.");
                MainMenu.TypeWriter($"Your Problem Solving skill level is now {currentPlayer.ProblemSolving}");


            }

            MainMenu.TypeWriter($"Last question {Player.Name}, don't mess it up. No multiple choice this time.");
            Console.WriteLine("");

            MainMenu.TypeWriter("If 2 is company and 3 is a crowd, what are 4 and 5?");
            Console.ForegroundColor = ConsoleColor.Red;
            MainMenu.TypeWriter("Please choose an answer.");
            Console.WriteLine(">>");
            string question3 = Console.ReadLine();
            Console.ResetColor();

            if (question3 == "9" | question3 == "Nine" | question3 == "nine")
            {
                currentPlayer.ProblemSolving += 10;
                Console.WriteLine("");

                MainMenu.TypeWriter("Damn. Most get that wrong and I shoot them.");
                MainMenu.TypeWriter($"Your Problem Solving skill level is currently {currentPlayer.ProblemSolving}");

            }
            else
            {
                currentPlayer.ProblemSolving -= 10;
                Console.WriteLine("");

                MainMenu.TypeWriter("Yeah that's not right chief.");
                MainMenu.TypeWriter($"Your Problem Solving skill level is currently {currentPlayer.ProblemSolving}");


            }

            MainMenu.TypeWriter("John: Right then. Are you ready to die?");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Yellow;
            MainMenu.TypeWriter("John stood up and backed away from the table. ");
            MainMenu.TypeWriter("Suddenly he started to grow. Everywhere.");
            MainMenu.TypeWriter("He burst out of his shirt and started to grow towards the ceiling like some sort of weird gross HR sunflower.");
            MainMenu.TypeWriter("Within seconds he took up half of the room.");
            Console.ResetColor();
            Console.WriteLine("\nPress ENTER to look up at John...");
            Console.ReadLine();
            Console.WriteLine(@"Troll by lgbeard
                             . `  `. .`  ` .
                        . `     `.  ;  .`     ` .
                     .`           \   /           `.
                   .`     . - .   ( @ )   . - .     `.
                  /    .`      `.  '-'  .'      `.    \
          /\    .`    /   .--.   `-._.-'   .--.   \    `.    /\
        .`  `. /    .'  .`    `. `.   .` .`    `.  `.    \ .`  `.
      .`     .`    /   /        \  \ /  /        \   \    `.     `.
     /      /    .'   /   . ''' .\     /. ''' .   \   `.    \      \
    |    .`(    /    |   /        \   /        \   |    \    )`.    |
     \   | /  .'      \ |   /##\  |   |  /##\   | /      `.  \ |   /
      |  / | /         \\  | ###| /   \ |### |  //         \ | \  |
    .`\  | \/)       _.-'.  \##/ |     | \##/  .'-._       (\/ |  /`.
   /   | |  (      .`     `-.   /       \   .-'     `.      )  | |   \
  |  .`\ \   )               `.'         `.'               (   / /`.  |
  /\/  | |                  .'             `.                  | |  \/\
  \   / /     /            (   .-.     .-.   )            \     \ \   /
   `./ |    .`              `.(   `._.'   ).'              `.    | \ /
   / \ \   /.`\      )._           ) (           _.(      /`.\   / /  \
  /  |  `-'/   \    /  ''--.__    .' '.    __.--''  \    /   \`-'  |   \
  |   `---'/  .`'.  '.       ''--..___..--''       .'  .'`.  \`---'    |
  |    _.-/  /   |'.  '.                         .'  .'|   \  \-._     |
  /\ .`  |  /|  /   '.  ''---....._____.....---''  .'   \  |\ |   `.  /
 |  /     \/ \ |       - . _     _.---._     _ . -       \ /|/      \|
 \ /          \/            ''--._______.--''             \|         \
 .`        \                                                 /        `.
/       ;   |  `.                                       .`  |   ;       \
| (      )  /    \                  ^                  /    \  (      ) |
|  `.      / .`   `.              .` `.              .`   `. \      .`  |
\         \         `-._         /     \         _.-`         /         /
 \         \  _.-`   _  `--.__.-`       `-.__.--`  _   `-._  /         /
 |          `-._    / )   _                   _   ( \    _.-`          |
  \             `-.` (   / )    `-.___.-`    ( \   ) `.-`             /
   \      `.         /.-' / )               ( \ '-.\         .`      /
    `-._     `.     |  .-' / )  `-.___.-`  ( \ '-.  |     .`     _.-`
    /   `--._        \  .-' / )           ( \ '-.  /        _.--`  \
    |   |   \`--.._   |  .-' /  `-.___.-`  \ '-.  |   _..--`/  |    |
     `./     \ .`  `-/.__.--'               '--.__.\-`  `. /    `.  |
      |     / |_           -._            _.-            _| \    |\/
       `.  | /  ''--..__            _            __..--''  \ |  .`
       | \/  |==  ==    ''--..__/\_/ \_/\__..--''    ==  ==|  \/ \
       \     \ _==   ==   ==   / o)|-|(o \   ==   ==   ==_ /     /
       |    /|  ''--..__==  == \ (\) (/) / ==  ==__..--'' ||\    |
        \  / |      |  |''--..__\ )\_/( /__..--''   _.-'\ \\ \  /
         \|  /     /  /          \/___\/     \\ _.-'     \ \\ |/
             |    /  /  :                     \\\    @ .-'  ||
             \_.-`  /          :            : || \_.-'      \\
             /___.-`                          ||       _     \\
             | :                       :       \\     / (    ||
             /               :                  \\    =:_\   \\
             |   :                              ||     )      \\
             |         :                 :      \\          _.//
              \     /\                           \\     _.-'
              |    |  \    |\   :            |\   ||_.-'   |
              | : /   |   /  |      /|      /  |   /|     /
              \  /    \  |   \     | |     | `./  |  \   /
              | / `    |/  `. |    / \  : /    | /    \  |
              \|\ `            \  |   |  | `   \|    ` \ |
                 | `     `.     \ /   / /  `  `.     ` ||/
                 \  `        ,   \|   \ | `          ` /
                  | `.      ,    |    |/            ` |   .    .
                   \             /     \           ,`/     \  /
                    \    . - .   |     |   . - .    /     ( O  )
                     \  .`-._ . /       \ . _.-'.  /       )  (
                     \  : _.-': |       | :`-._ :  /      (    )
                     |   `- -`  \       /  `- -`   |        \ /
          )\         |    ___   |       |   ___    |         |
       )\/ (         /_.-'___'-._\     /_.-'___'-._\        /
      (  @  )       [__.-'   '-._]     [_.-'   '-.__]      |
       \( )/       /|\ _ \   /_  /     \  _\   /_  /   /|  /
           \      | /|`   | |  -_| /\  |_-  | |  ` |  | / /
       |\   |  |\/ | /.-` | |`-._\/ |  /_.-`| |`-. \ /  |/|\       /|
  /\  /  \   \ \ \ \ \-_ /   \.-'/\ \  \'-./   \ _-/ |  / / \ /\  | \
 | / |  / /\ | /  |/ /`-.\ _ /.-'\|  \ /'-.\ _ /.-`\ / | /  / | \ \ |
 \ | \ | |  \\\|  \ .`-_ // \ \ .-\  // -./ / \\ _-`.  \ | |  / / | \
 / \ / \ |  //|\  .`,`__//___\ \__/   \__/ /___\\__`,`. |/ \ / | /  |
 \ |/  |/  |/ |/ /_-_--_--_---,--.`) (`,--.---_--_--_-_\\|  \| \/   \
 / \|  /   /\ /\(_`'_`'_`'_) (____)   (____) (_`'_`'_`'_)/  /\  |LGB/", 5);
            Console.WriteLine("");
            Console.WriteLine("");

            MainMenu.TypeWriter("Monstor John: Ah thats much better. You should always bring your true self to work I say.");
            MainMenu.TypeWriter("Monstor John: Now if you don't mind, I'd love to eat you whole.");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Yellow;
            MainMenu.TypeWriter("You: EAT MY WHAT?!!");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            MainMenu.TypeWriter("Monstor John: No no I said eat YOU WHOLE");
            MainMenu.TypeWriter("Monstor John: Not eat your actual...you know what I mean.");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Yellow;
            MainMenu.TypeWriter("You: Oh. That's not much better really.");
            Console.WriteLine("");
            MainMenu.TypeWriter("Taking a step back I was suddenly against the back wall. John seemed to be gearing up to do something....");
            MainMenu.TypeWriter("Without warning he started firing VHS tapes towards me at lightning speed.");
            Console.ResetColor();
            Console.WriteLine("");

            MainMenu.TypeWriter("Monstor John: These are HR training videos from the 90s....feel the drabness and power overtake you.");
            MainMenu.TypeWriter("Monstor John: No one can stand them muhahahaha!");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("");

            MainMenu.TypeWriter("You entered into battle with John.");
            MainMenu.TypeWriter("What would you like to do?");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Red;
            MainMenu.TypeWriter("1. Player Stats");
            MainMenu.TypeWriter("2. Inventory ");
            MainMenu.TypeWriter("3.Attack");
            MainMenu.TypeWriter("Please choose an answer.");
            Console.WriteLine(">>");
            Console.WriteLine("");
            string playerSelect = Console.ReadLine();

            if (playerSelect == "1")
            {
                MainMenu.TypeWriter($"\nTitle: {currentPlayer.Title}");
                MainMenu.TypeWriter($"Health: {currentPlayer.Health}");
                MainMenu.TypeWriter($"Typing: {currentPlayer.Typing}");
                MainMenu.TypeWriter($"Problem Solving: {currentPlayer.ProblemSolving}");
                MainMenu.TypeWriter($"Smugness: {currentPlayer.Smugness}");
            }
            else if (playerSelect == "2")
            {
                MainMenu.TypeWriter("Inventory is empty.");
                

            }
            else
            {
                currentPlayer.Attack();
            }

            



        }
    }
}