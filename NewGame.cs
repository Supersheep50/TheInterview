using System.Net;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TextRPG
{

    class NewGame
    {
        public static void PlayerSelection()
        {


            Console.WriteLine(
"                              d8888888888888888888888\" \n" +
"                                888888888888888888PYP\"' \n" +
"                               d88888888888888888D\n" +
"                               8888888888888888P'\n" +
"                                Y8888888888888b\n" +
"                               C8888888Y888888P\n" +
"                                Y88888'd88888\" \n" +
"                                8888P d8888P\n" +
"                               d8888D 88888\n" +
"                              d888P'  Y88dP\n" +
"                             nY88Pn    Y88            8\"\"\"-----....._____\n" +
"                             N   +N    88'            8                  NNNNNN8\n" +
"                             N   +N  nd88n            P                  NNNNNNP\n" +
"                             N   +N  N  +N           d  dNN   ...       dNNNNNN\n" +
"     __...---\"Nn.            N   +N  N  +N           8  NNP  dNNP  dNN  NNNNNNN\n" +
"  8\"\"         NNNNn          N   +N  N  +N           8       \"\"'   NNP  NNNNNNN\n" +
"  8       oo  NNNNN          N   +N  N  +N           8                  NNNNNNP\n" +
"  Y  dN   NN  NNNNN          N   +N  N  +N           P       ooo       dNNNNNN\n" +
"   b NY   \"\"  YNNNN          N   +N  N  +N          d       dNN'  dNN  NNNNNNN\n" +
"   8        _  bNNNb         N   +N  N  +N          8       \"\"\"   NNP  NNNNNNN\n" +
"   8  o8   88  NNNNN         N   +N  N  +N          8                  NNNNNNN\n" +
"   Y  BP   \"\"  NNNNN         N   +N  N  +N          8            nnn   NNNNNNP\n" +
"    b          NNNNN         N   +N  N  +N          P            NNP  dNNNNNN\n" +
"    8          YNNNN         N   +N  M  +N         d             \"\"   NNNNNNN\n" +
"    8           NNNNb        N   +N  N  +N         8                  NNNNNNN\n" +
"    Y           NNNNN      __N___+N__N  +N         8                  NNNNNNP\n" +
"     b          NNNNNooooodP\"\"\"\"\"\"\"\"YNNNNNNbcgmmnnn8                 dNNNNNN\n" +
"     8          \"\"\"'                         `\"\"\"\"\"8                 NNNNNNN\n" +
"     8                          NOTMETA                     P                 NNNNNNN\n" +
"     Y                          NNNNNNNNN         d                  NNNNNNN\n" +
"      b                         NNNNNNNNN         8                  NNNNNNP\n" +
"      8                         NNNNNNNNP         8                 dNNNNNN\n" +
"      8                         NNNNNNNN;         8                 NNNNNNN\n" +
"      Y                         NNNNNNNN:         P                 NNNNNNN\n" +
"       b                        NNNNNNNN;        d                  NNNNNNP\n" +
"       8                        NNNNNNNN         8                 dNNNNNN\n" +
" ______8__........----------\"\"\"\"\"\"\"\"\"------...8..______         NNNNNNN\n" +
"_________........----------\"\"\"\"\"\"\"\"\"------......_____  \"\"\"\"\"----NNNNNNN\n" +
"                                                         \"\"\"\"\"----....___ \"\"\"--\n" +
"                                                                         \"\"\"---");
            Console.ForegroundColor = ConsoleColor.Yellow;
            MainMenu.TypeWriter("Standing in front of the building it seems to go up forever.");
            MainMenu.TypeWriter("Wait...why does it have a smokestack? Nevermind...");
            MainMenu.TypeWriter("This is why you went through 4 years of University. To finally get to this point.");
            MainMenu.TypeWriter("To be able to work 40 hours a week until you're dead. What an honour.");
            MainMenu.TypeWriter("To have your own cubicle, potlucks, pizza days and company offsites.");
            MainMenu.TypeWriter("Everything you've dreamed of. The grey shade of the building reflects in your eyes.");
            MainMenu.TypeWriter("The words NotMeta shimmer from the sign. It makes you smile.");
            MainMenu.TypeWriter("Who cares if the CEO is a convicted sex offender and right wing supporter.");
            MainMenu.TypeWriter("He's built the best damn {insert company industry here} the world has ever known.");
            MainMenu.TypeWriter("You arrive at the large double doors. Should you go in and do the interview?");
            Console.ForegroundColor = ConsoleColor.Red;
            MainMenu.TypeWriter("Please enter Yes or No");
            string startGame = Console.ReadLine();

            if (startGame == "Yes" | startGame == "yes" | startGame == "y")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                MainMenu.TypeWriter("The door pushes open very slowly. It feels heavy and weirdly warm.");
                MainMenu.TypeWriter("Standing in the large very empty lobby, you hear Machine Gun Kelly playing on the speakers.");
                MainMenu.TypeWriter("You start to have regrets. Before you can leave a man sitting behind the desk spots you and walks towards you.");
            }

            else if (startGame == "No" | startGame == "no" | startGame == "n")
            {
                Console.ResetColor();
                MainMenu.TypeWriter("Well if you're not going to even do the interview it makes the game pretty pointless.");
                MainMenu.TypeWriter("Here, you can go here instead.");
                OpenUrl("https://www.google.com/search?q=bin+image&sca_esv=df549bc08c278101&rlz=1C5CHFA_enIE1117IE1117&udm=2&biw=1633&bih=886&sxsrf=AE3TifNkVqlKAPhW6V1m4K5SzGuMfs7jdA%3A1753353245970&ei=HQyCaIH-Op6QhbIP-IS2KQ&ved=0ahUKEwjBgJHrpdWOAxUeSEEAHXiCLQUQ4dUDCBE&uact=5&oq=bin+image&gs_lp=EgNpbWciCWJpbiBpbWFnZTINEAAYgAQYsQMYQxiKBTIGEAAYBxgeMgYQABgHGB4yBhAAGAcYHjIGEAAYBxgeMgYQABgHGB4yBhAAGAcYHjIMEAAYgAQYQxiKBRgKMhAQABiABBixAxhDGIMBGIoFMg0QABiABBixAxhDGIoFSIIKUJcFWKMJcAF4AJABAJgBAKABAKoBALgBA8gBAPgBAZgCAaACB5gDAIgGAZIHATGgBwCyBwC4BwDCBwMyLTHIBwU&sclient=img");
            }




            MainMenu.TypeWriter("");
            MainMenu.TypeWriter("");
            Console.ResetColor();
            MainMenu.TypeWriter("Weird dude: Hey there Candidate! Welcome to NotMeta, lets head to the interview room.");
            MainMenu.TypeWriter("Weird dude: I hope you don't mind taking the stairs. The elevator is out of order due to an incident.");
            MainMenu.TypeWriter("Weird dude: No one died if that's what you're thinking.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            MainMenu.TypeWriter("You finally stop climbing the stairs after what feels like an enternity.");
            MainMenu.TypeWriter("Gene brings you out into an open floor with cubicle after cublice. You squint your eyes.");
            Console.WriteLine(@"                _________________
                                                    /                /|
                                                    /                / |
                                                    /________________/ /|
                                                ###|      ____      |//|
                                                #   |     /   /|     |/.|
                                                #  __|___ /   /.|     |  |_______________
                                            #  /      /   //||     |  /              /|                  ___
                                            #  /      /___// ||     | /              / |                 / \ \
                                            # /______/!   || ||_____|/              /  |                /   \ \
                                            #| . . .  !   || ||                    /  _________________/     \ \
                                            #|  . .   !   || //      ________     /  /\________________  {   /  }
                                            /|   .    !   ||//~~~~~~/   0000/    /  / / ______________  {   /  /
                                            / |        !   |'/      /9  0000/    /  / / /             / {   /  /
                                            / #\________!___|/      /9  0000/    /  / / /_____________/___  /  /
                                        / #     /_____\/        /9  0000/    /  / / /_  /\_____________\/  /
                                        / #                      ``^^^^^^    /   \ \ . ./ / ____________   /
                                        +=#==================================/     \ \ ./ / /.  .  .  \ /  /
                                        |#                                   |      \ \/ / /___________/  /
                                        #                                    |_______\__/________________/
                                        |                                    |               |  |  / /
                                        |                                    |               |  | / /
                                        |                                    |       ________|  |/ /________
                                        |                                    |      /_______/    \_________/\
                                        |                                    |     /        /  /           \ )
                                        |                                    |    /OO^^^^^^/  / /^^^^^^^^^OO\)
                                        |                                    |            /  / /
                                        |                                    |           /  / /
                                        |                                    |          /___\/
                                        |                            |           oo
                                        |____________________________________|
                                        ------------------------------------------------");
            MainMenu.TypeWriter("It looks like they go on forever and ever. But that doesn't make sense?");
            MainMenu.TypeWriter("You finally arrive at the interview room.");
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
            MainMenu.TypeWriter("Gene: My name is Gene. I'm the Interview Coordinator here at NotMeta and a pyscopath.");
            MainMenu.TypeWriter("Gene: Haha thats just one of my jokes. You'll get used to them. Probably.");
            MainMenu.TypeWriter("Gene: Lets take a look at this CV....");
            Player.PlayerName();
            MainMenu.TypeWriter($"Gene: Alright, I'll call you {Player.Name} if you insist");
            MainMenu.TypeWriter($"Gene: Now {Player.Name}, what role are you here to interview for?");
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
        
        static void OpenUrl(string url)
    {
        try
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Process.Start("open", url);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start("xdg-open", url);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to open link: {ex.Message}");
        }
    }
    }
}