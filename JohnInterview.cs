namespace TextRPG
{

    public class JohnInterview
    {

        public static void JohnInterviewLevel(Player currentPlayer)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            MainMenu.TypeWriter("You stand up and walk towards the door.");
            MainMenu.TypeWriter("It's as if the whispering gets louder and louder the closer you get to it.");
            MainMenu.TypeWriter("Reaching your hand out towards the door handle you can already feel the cold eminating from it.");
            MainMenu.TypeWriter("......");
            MainMenu.TypeWriter("Before you can open it the door whooshes open");
            MainMenu.TypeWriter("Standing in the doorway is John.");
            Console.ResetColor();
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
            MainMenu.TypeWriter($"Please, take a seat {Player.Name}");
            MainMenu.TypeWriter("Apologies for making you wait.");
            MainMenu.TypeWriter("This interview will test your Problem Solving ability.");
            MainMenu.TypeWriter("You will be asked 3 questions. For each question right you will gain 10 points for Problem Solving.");
            MainMenu.TypeWriter("For every question you get wrong, you will lose 10 points. After that, we shall fight to the death.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            MainMenu.TypeWriter("Excuse me?");
            Console.ResetColor();
            MainMenu.TypeWriter("We shall fight to the death.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            MainMenu.TypeWriter("Yes I heard that bit but what does it mean?");
            Console.ForegroundColor = ConsoleColor.White;
            MainMenu.TypeWriter("It means exactly what it means. One of us will perish, you most likely.");
            MainMenu.TypeWriter("Now, no more nonsense let us begin.");
            MainMenu.TypeWriter($"Your Problem Solving skill level is currently {currentPlayer.ProblemSolving}");
            MainMenu.TypeWriter("What gets wetter the more you dry it?");
            Console.ForegroundColor = ConsoleColor.Red;
            MainMenu.TypeWriter("1. Humour 2. A Towel 3. Your Hair");
            MainMenu.TypeWriter("Please choose an answer.");
            string question1 = Console.ReadLine();
            Console.ResetColor();

            if (question1 == "2")
            {
                currentPlayer.ProblemSolving += 10;
                MainMenu.TypeWriter("Wow, I'm impressed. 10 points for Grffindor.");
                MainMenu.TypeWriter($"Your Problem Solving skill level is now {currentPlayer.ProblemSolving}");

            }
            else
            {
                currentPlayer.ProblemSolving -= 10;
                MainMenu.TypeWriter("Oh dear. No. No that's wrong.");
                MainMenu.TypeWriter($"Your Problem Solving skill level is now {currentPlayer.ProblemSolving}");


            }

            MainMenu.TypeWriter($"Alright then, here's Question 2. Listen up {Player.Name}.");
            MainMenu.TypeWriter("What has a neck but no head?");
            Console.ForegroundColor = ConsoleColor.Red;
            MainMenu.TypeWriter("1. A Giraffe 2. A Bottle 3. You");
            MainMenu.TypeWriter("Please choose an answer.");
            string question2 = Console.ReadLine();
            Console.ResetColor();

            if (question2 == "2")
            {
                currentPlayer.ProblemSolving += 10;
                MainMenu.TypeWriter("I guess you only look like an idiot then.");
                MainMenu.TypeWriter($"Your Problem Solving skill level is now {currentPlayer.ProblemSolving}");

            }
            else
            {
                currentPlayer.ProblemSolving -= 10;
                MainMenu.TypeWriter("No.");
                MainMenu.TypeWriter($"Your Problem Solving skill level is now {currentPlayer.ProblemSolving}");


            }

            MainMenu.TypeWriter($"Last question {Player.Name}, don't mess it up. No multiple choice this time.");
            MainMenu.TypeWriter("If 2 is company and 3 is a crowd, what are 4 and 5?");
            Console.ForegroundColor = ConsoleColor.Red;
            MainMenu.TypeWriter("Please choose an answer.");
            string question3 = Console.ReadLine();
            Console.ResetColor();

            if (question3 == "9" | question3 == "Nine" | question3 == "nine")
            {
                currentPlayer.ProblemSolving += 10;
                MainMenu.TypeWriter("Damn. Most get that wrong and I shoot them.");
                MainMenu.TypeWriter($"Your Problem Solving skill level is currently {currentPlayer.ProblemSolving}");

            }
            else
            {
                currentPlayer.ProblemSolving -= 10;
                MainMenu.TypeWriter("Yeah that's not right chief.");
                MainMenu.TypeWriter($"Your Problem Solving skill level is currently {currentPlayer.ProblemSolving}");


            }

            MainMenu.TypeWriter("Right then. Are you ready to die?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            MainMenu.TypeWriter("John stood up and backed away from the table. ");
            MainMenu.TypeWriter("Suddenly he started to grow. Everywhere.");
            MainMenu.TypeWriter("He burst out of his shirt and started to grow towards the ceiling like some sort of weird gross HR sunflower.");
            MainMenu.TypeWriter("Within seconds he took up half of the room.");
            Console.ResetColor();
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
 / \|  /   /\ /\(_`'_`'_`'_) (____)   (____) (_`'_`'_`'_)/  /\  |LGB/");

            MainMenu.TypeWriter("Ah thats much better. You should always bring your true self to work I say.");
            MainMenu.TypeWriter("Now if you don't mind, I'd love to eat you whole.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            MainMenu.TypeWriter("EAT MY WHAT?!!");
            Console.ForegroundColor = ConsoleColor.White;
            MainMenu.TypeWriter("No no I said eat YOU WHOLE");
            MainMenu.TypeWriter("Not eat your actual...you know what I mean.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            MainMenu.TypeWriter("Oh. That's not much better really.");
            MainMenu.TypeWriter("Taking a step back I was suddenly against the back wall. John seemed to be gearing up to do something, what I was wasn't sure.");
            MainMenu.TypeWriter("Without warning he started firing VHS tapes towards me at lightning speed.");
            Console.ResetColor();
            MainMenu.TypeWriter("These are HR training videos from the 90s....feel the drabness and power overtake you.");
            MainMenu.TypeWriter("No one can stand them muhahahaha!");
            Console.ForegroundColor = ConsoleColor.Magenta;
            MainMenu.TypeWriter("You entered into battle with John.");
            MainMenu.TypeWriter("What would you like to do?");
            Console.ForegroundColor = ConsoleColor.Red;
            MainMenu.TypeWriter("1. Player Stats 2. Inventory 3.Attack");
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