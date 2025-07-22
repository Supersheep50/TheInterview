namespace TextRPG
{

    class NewGame
    {
        public static void PlayerSelection()
        {

            MainMenu.TypeWriter("Hey there Candidate! Welcome to NotMeta, lets head to the interview room.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            MainMenu.TypeWriter("You sit down on an old plastic chair in a room that has windows on all sides.");
            MainMenu.TypeWriter("Across from the steel metallic desk is Gene, the coordinator.");
            Console.ResetColor();
            Console.WriteLine(@"    
  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
 XXXXXXXXXXXXXXXXXX         XXXXXXXX
XXXXXXXXXXXXXXXX              XXXXXXX
XXXXXXXXXXXXX                   XXXXX
 XXX     _________ _________     XXX      THE
  XX    I  _xxxxx I xxxxx_  I    XX        LOCKER
 ( X----I         I         I----X )           GNOME
( +I    I      00 I 00      I    I+ )
 ( I    I    __0  I  0__    I    I )
  (I    I______ /   \_______I    I)
   I           ( ___ )           I
   I    _  :::::::::::::::  _    i
    \    \___ ::::::::: ___/    /
     \_      \_________/      _/
       \        \___,        /
         \                 /
          |\             /|
          |  \_________/  |");
            Console.ForegroundColor = ConsoleColor.Yellow;
            MainMenu.TypeWriter("He hasn't stopped smiling since you met him. He hasn't blinked either come to think of it.");
            MainMenu.TypeWriter("He starts to arrange the pieces of paper he's brought with him. You get a quick glance, they're all blank.");
            MainMenu.TypeWriter("He turns to face you and takes a breath. The room smells like chlorine.");
            Console.ResetColor();
            MainMenu.TypeWriter("My name is Gene. I'm the Interview Coordinator here at NotMeta and a pyscopath.");
            MainMenu.TypeWriter("Haha thats just one of my jokes. You'll get used to them. Probably.");
            MainMenu.TypeWriter("Lets take a look at this CV....");
            Player.PlayerName();
            MainMenu.TypeWriter($"Alright, I'll call you {Player.Name} if you insist");
            MainMenu.TypeWriter($"Now {Player.Name}, what role are you here to interview for?");
            MainMenu.TypeWriter("1.Software Development 2.Recruitment 3.Sales 4.CEO");
            Console.ForegroundColor = ConsoleColor.Red;
            MainMenu.TypeWriter("Please choose an option");
            string jobChoice = Console.ReadLine();
            Console.ResetColor();

            Player player;

            switch (jobChoice)
            {

                case "1":
                    player = new SoftwareDev();
                    GameState.CurrentProgress = new GameProgress
                    {
                        Player = player,
                        CurrentStage = "Intro"
                    };

                    SoftwareDev.SoftwareDevPath();
                    break;
                case "2":
                    player = new Recruiter();
                    GameState.CurrentProgress = new GameProgress
                    {
                        Player = player,
                        CurrentStage = "Intro"
                    };

                    Recruiter.RecruiterPath();
                    break;
                case "3":
                    player = new Sales();
                    GameState.CurrentProgress = new GameProgress
                    {
                        Player = player,
                        CurrentStage = "Intro"
                    };

                    Sales.SalesPath();
                    break;
                case "4":
                    player = new CEO();
                    GameState.CurrentProgress = new GameProgress
                    {
                        Player = player,
                        CurrentStage = "Intro"
                    };

                    CEO.CEOPath();
                    break;
                
            }

        }
    }
}