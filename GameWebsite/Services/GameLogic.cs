using Microsoft.JSInterop;

namespace GameWebsite.Services
{
    public class GameLogic
    {
        private readonly TerminalService _t;
        private readonly IJSRuntime _js;

        private string _playerName = "Candidate";
        private int _typing;
        private int _problemSolving;
        private int _smugness;

        public GameLogic(TerminalService terminal, IJSRuntime js)
        {
            _t = terminal;
            _js = js;
        }

        public async Task RunAsync()
        {
            try
            {
                await _js.InvokeVoidAsync("playAudio", "bgMusic");
            }
            catch { }

            while (true)
            {
                await ShowMainMenu();
            }
        }

        // ── Main Menu ──────────────────────────────────────────────────────────────

        private async Task ShowMainMenu()
        {
            _t.Write(@"
     ______                        ______
  .-'      '-.                  .-'      '-.
 /            \  THE INTERVIEW  /            \
|              |               |              |
|,  .-.  .-.  ,|               |,  .-.  .-.  ,|
| )(_o/  \o_)( |               | )(_o/  \o_)( |
|/     /\     \|               |/     /\     \|
(_     ^^     _)               (_     ^^     _)
 \__|IIIIII|__/                 \__|IIIIII|__/
  | \IIIIII/ |                   | \IIIIII/ |
  \          /                   \          /
   `--------`                     `--------`", "text-red", preformatted: true);

            _t.BlankLine();
            _t.Write("─────────────────────────────────");
            _t.Write("        THE INTERVIEW", "text-red");
            _t.Write("─────────────────────────────────");
            _t.BlankLine();
            _t.Write("  1. New Game");
            _t.Write("  2. About");
            _t.BlankLine();
            _t.Write("─────────────────────────────────");
            _t.BlankLine();

            await _t.TypeWriteAsync("Welcome to The Interview!");
            await _t.TypeWriteAsync("A Text Based RPG adventure where you play a poor lowly candidate.");
            await _t.TypeWriteAsync("Your goal is to get the job of your dreams at NotMeta Corp.");
            await _t.TypeWriteAsync("But proceed with caution....");
            await _t.TypeWriteAsync("Good luck!");
            _t.BlankLine();
            await _t.TypeWriteAsync("Please choose an option from the menu.", "text-red");

            string choice;
            while (true)
            {
                choice = await _t.ReadLineAsync();
                if (choice is "1" or "2") break;
                await _t.TypeWriteAsync("Please enter 1 or 2.", "text-red");
            }

            if (choice == "1")
                await RunNewGame();
            else
                await ShowAbout();
        }

        private async Task ShowAbout()
        {
            _t.BlankLine();
            await _t.TypeWriteAsync("Thanks for taking the time to play my wee game!", "text-cyan");
            await _t.TypeWriteAsync("My name is Jonathan and I am a Software Developer and huge videogame fan!");
            await _t.TypeWriteAsync("This game is a little passion project designed to make fun of the ridiculous Tech interview process.");
            await _t.TypeWriteAsync("I hope by the time you're reading this that it might be available on Steam.");
            await _t.TypeWriteAsync("If not, and you're a friend/family member being polite and playing it over my shoulder, I thank you.");
            await _t.TypeWriteAsync("Anywho, enjoy the game and all feedback is welcome!");
            _t.BlankLine();
            await _t.TypeWriteAsync("Press ENTER to return to the menu.", "text-red");
            await _t.ReadLineAsync();
        }

        // ── New Game / Intro ───────────────────────────────────────────────────────

        private async Task RunNewGame()
        {
            _t.BlankLine();
            _t.Write(@"
                              d8888888888888888888888
                                888888888888888888PYP'
                               d88888888888888888D
                               8888888888888888P'
                                Y8888888888888b
                               C8888888Y888888P
                                Y88888'd88888
                                8888P d8888P
                               d8888D 88888
                              d888P'  Y88dP
                             nY88Pn    Y88            8""-----....._____
                             N   +N    88'            8              NNNNNN8
                             N   +N  nd88n            P              NNNNNNP
                             N   +N  N  +N           d  dNN   ...   dNNNNNN
     __...---""Nn.            N   +N  N  +N           8  NNP  dNNP  NNNNNNN
  8""         NNNNn          N   +N  N  +N           8       ""'    NNNNNNN
  8      oo  NNNNN          N   +N  N  +N           8              NNNNNNP
  Y  dN  NN  NNNNN          N   +N  N  +N          d       ooo    dNNNNNN
   b NY  ""   YNNNN          N   +N  N  +N          8       dNN'   NNNNNNN
   8        _  bNNNb         N   +N  N  +N          8       ""     NNNNNNN
   8  o8   88  NNNNN         N   +N  N  +N          8              NNNNNNN
   Y  BP   ""   NNNNN         N   +N  N  +N          8              NNNNNNP
    b          NNNNN         N   +N  N  +N          P              NNNNNNN
    8          YNNNN                                              NNNNNNP

                          N O T M E T A", "text-gray", preformatted: true);

            _t.BlankLine();
            _t.Write("─────────────────────────────────────────────────────");
            _t.BlankLine();

            await _t.TypeWriteAsync("Standing in front of the building it seems to go up forever.", "text-yellow");
            await _t.TypeWriteAsync("Wait...why does it have a smokestack? Nevermind...", "text-yellow");
            await _t.TypeWriteAsync("This is why you went through 4 years of University. To finally get to this point.", "text-yellow");
            await _t.TypeWriteAsync("To be able to work 40 hours a week until you're dead. What an honour.", "text-yellow");
            await _t.TypeWriteAsync("To have your own cubicle, potlucks, pizza days and company offsites.", "text-yellow");
            _t.BlankLine();
            await _t.TypeWriteAsync("Everything you've dreamed of. The grey shade of the building reflects in your eyes.", "text-yellow");
            await _t.TypeWriteAsync("The words NotMeta shimmer from the sign. It makes you smile.", "text-yellow");
            await _t.TypeWriteAsync("Who cares if the CEO is a convicted sex offender and right wing supporter.", "text-yellow");
            await _t.TypeWriteAsync("He's built the best damn {insert company industry here} the world has ever known.", "text-yellow");
            await _t.TypeWriteAsync("You arrive at the large double doors. Should you go in and do the interview?", "text-yellow");
            _t.BlankLine();
            await _t.TypeWriteAsync("Enter Yes or No:", "text-red");

            string startChoice;
            while (true)
            {
                startChoice = await _t.ReadLineAsync();
                var l = startChoice.ToLower();
                if (l is "yes" or "y" or "no" or "n") break;
                await _t.TypeWriteAsync("Please enter Yes or No.", "text-red");
            }

            if (startChoice.ToLower() is "no" or "n")
            {
                _t.BlankLine();
                await _t.TypeWriteAsync("Well if you're not going to even do the interview it makes the game pretty pointless.");
                await _t.TypeWriteAsync("Here, you can go here instead.", "text-yellow");
                _t.Write("[ <a href='https://www.google.com/search?q=bin+image&udm=2' target='_blank' style='color:#00ffcc'>Google: bin images</a> ]", preformatted: true);
                _t.BlankLine();
                await _t.TypeWriteAsync("Press ENTER to return to the main menu.", "text-red");
                await _t.ReadLineAsync();
                return;
            }

            _t.BlankLine();
            await _t.TypeWriteAsync("The door pushes open very slowly. It feels heavy and weirdly warm.");
            await _t.TypeWriteAsync("Standing in the large very empty lobby, you hear Machine Gun Kelly playing on the speakers.");
            await _t.TypeWriteAsync("You start to have regrets. Before you can leave a man sitting behind the desk spots you and walks towards you.");

            _t.BlankLine();
            _t.Write(@"                     _________________
                    /                /|
                    /                / |
                    /________________/ /|
                ###|      ____      |//|
                #   |     /   /|     |/.|
                #  __|___ /   /.|     |  |_______________
            #  /      /   //||     |  /              /|
            #  /      /___// ||     | /              / |
            # /______/!   || ||_____|/              /  |
            #| . . .  !   || ||                    /  _|
            #|  . .   !   || //      ________     /  /\
            /|   .    !   ||//~~~~~~/   0000/    /  / /
            / |        !   |'/      /9  0000/    /  / /
            / #\________!___|/      /9  0000/    /  / / /
        / #     /_____\/        /9  0000/    /  / / _/
        / #                      ``^^^^^^    /   \ \. /
        +=#==================================/     \ \/
        |#                                   |      \/", "text-gray", preformatted: true);

            _t.BlankLine();
            await _t.TypeWriteAsync("Press ENTER to continue...", "text-red");
            await _t.ReadLineAsync();

            await _t.TypeWriteAsync("Weird dude: Hey there Candidate! Welcome to NotMeta, lets head to the interview room.");
            await _t.TypeWriteAsync("Weird dude: I hope you don't mind taking the stairs. The elevator is out of order due to an incident.");
            await _t.TypeWriteAsync("Weird dude: No one died if that's what you're thinking.");
            _t.BlankLine();
            await _t.TypeWriteAsync("You finally stop climbing the stairs after what feels like an eternity.", "text-yellow");
            await _t.TypeWriteAsync("Gene brings you out into an open floor with identical cubicle after identical cubicle. You squint your eyes.", "text-yellow");
            await _t.TypeWriteAsync("It looks like they go on forever and ever. But that doesn't make sense?", "text-yellow");
            await _t.TypeWriteAsync("You finally arrive at the interview room.", "text-yellow");
            await _t.TypeWriteAsync("You sit down on an old plastic chair in a room that has windows on all sides.", "text-yellow");
            await _t.TypeWriteAsync("Across from the steel metallic desk is Gene, the coordinator.", "text-yellow");

            _t.BlankLine();
            _t.Write(@"
  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
 XXXXXXXXXXXXXXXXXX         XXXXXXXX
XXXXXXXXXXXXXXXX              XXXXXXX
XXXXXXXXXXXXX                   XXXXX
 XXX     _________ _________     XXX
  XX    I  _xxxxx I xxxxx_  I    XX
 ( X----I         I         I----X )
( +I    I      00 I 00      I    I+ )
 ( I    I    __0  I  0__    I    I )
  (I    I______ /   \_______I    I)
   I           ( ___ )           I
   I    _  :::::::::::::::  _    I
    \    \___ ::::::::: ___/    /
     \_      \_________/      _/
       \        \___,        /
         \                 /
          |\             /|
          |  \_________/  |", "text-gray", preformatted: true);

            _t.BlankLine();
            await _t.TypeWriteAsync("He hasn't stopped smiling since you met him. He hasn't blinked either come to think of it.", "text-yellow");
            await _t.TypeWriteAsync("He starts to arrange pieces of paper he's brought with him. You get a quick glance — they're all blank.", "text-yellow");
            await _t.TypeWriteAsync("He turns to face you and takes a breath. The room smells like chlorine.", "text-yellow");
            _t.BlankLine();
            await _t.TypeWriteAsync("Gene: My name is Gene. I'm the Interview Coordinator here at NotMeta and a psychopath.");
            await _t.TypeWriteAsync("Gene: Haha! That's just one of my jokes. You'll get used to them. Probably.", "text-cyan");
            await _t.TypeWriteAsync("Gene: Lets take a look at this CV....");

            // Player name
            _t.BlankLine();
            await _t.TypeWriteAsync("What's your name?", "text-red");
            _playerName = await _t.ReadLineAsync();
            if (string.IsNullOrWhiteSpace(_playerName)) _playerName = "Candidate";

            await _t.TypeWriteAsync($"Gene: Alright, I'll call you {_playerName} if you insist.");
            _t.BlankLine();
            await _t.TypeWriteAsync($"Gene: Now {_playerName}, what role are you here to interview for?");
            _t.BlankLine();
            _t.Write("  1. Software Development");
            _t.Write("  2. Recruitment        (coming soon)");
            _t.Write("  3. Sales              (coming soon)");
            _t.Write("  4. CEO                (coming soon)");
            _t.BlankLine();
            await _t.TypeWriteAsync("Please choose an option:", "text-red");

            string jobChoice;
            while (true)
            {
                jobChoice = await _t.ReadLineAsync();
                if (jobChoice == "1") break;
                if (jobChoice is "2" or "3" or "4")
                {
                    await _t.TypeWriteAsync("That path is coming soon! Choose Software Development for now.", "text-yellow");
                    continue;
                }
                await _t.TypeWriteAsync("Please enter a number from 1–4.", "text-red");
            }

            await RunSoftwareDevPath();
        }

        // ── Software Dev Path ─────────────────────────────────────────────────────

        private async Task RunSoftwareDevPath()
        {
            _t.BlankLine();
            await _t.TypeWriteAsync("Gene: Software Dev Path has been chosen! Sorry that was a bit dramatic...");
            await _t.TypeWriteAsync("Gene: So you like Anime eh? Have you ever showered? Sorry I can't think of any other stereotypes....");
            await _t.TypeWriteAsync("Gene: I'm in HR, we're allowed to say that. We can also sleep with the CEO.");
            await _t.TypeWriteAsync("Gene: Actually are you a Coldplay fan? Nevermind.");
            _t.BlankLine();
            await _t.TypeWriteAsync("Gene: Alright then, lets hear about some of your skills.");
            await _t.TypeWriteAsync("Gene: You have 100 attribute points. Please assign them to these 3 skills:");
            _t.BlankLine();
            _t.Write("  1. Typing");
            _t.Write("  2. Problem Solving");
            _t.Write("  3. Smugness");
            _t.BlankLine();

            while (true)
            {
                await _t.TypeWriteAsync("Typing points (0–100):", "text-red");
                var typingStr = await _t.ReadLineAsync();
                if (!int.TryParse(typingStr, out _typing) || _typing < 0 || _typing > 100)
                {
                    await _t.TypeWriteAsync("Please enter a number between 0 and 100.", "text-yellow");
                    continue;
                }

                await _t.TypeWriteAsync("Problem Solving points:", "text-red");
                var psStr = await _t.ReadLineAsync();
                if (!int.TryParse(psStr, out _problemSolving) || _problemSolving < 0)
                {
                    await _t.TypeWriteAsync("Please enter a valid number.", "text-yellow");
                    continue;
                }

                await _t.TypeWriteAsync("Smugness points:", "text-red");
                var smStr = await _t.ReadLineAsync();
                if (!int.TryParse(smStr, out _smugness) || _smugness < 0)
                {
                    await _t.TypeWriteAsync("Please enter a valid number.", "text-yellow");
                    continue;
                }

                int total = _typing + _problemSolving + _smugness;
                if (total != 100)
                {
                    await _t.TypeWriteAsync($"Invalid total: you assigned {total} but need exactly 100. Try again.", "text-yellow");
                    continue;
                }

                break;
            }

            _t.BlankLine();
            _t.Write(@"
+----------------------+
|  🧙 Player Created!  |
+----------------------+", "text-cyan", preformatted: true);
            _t.BlankLine();

            await _t.TypeWriteAsync("Mysterious Voice: Go forth young candidate and save the universe. We need you.", "text-green");
            _t.BlankLine();
            await _t.TypeWriteAsync("You: What do you mean save the universe? I'm just here for a job interview. Who's speaking?", "text-yellow");
            await _t.TypeWriteAsync("You: This has been a super weird experience so far.", "text-yellow");
            _t.BlankLine();
            await _t.TypeWriteAsync("Mysterious Voice: Oh uhh...nevermind me. Off you pop... 💨", "text-green");
            _t.BlankLine();

            // Show stats with progress bars
            string typingBar = new string('█', _typing / 10).PadRight(10, '░');
            string psBar = new string('█', _problemSolving / 10).PadRight(10, '░');
            string smBar = new string('█', _smugness / 10).PadRight(10, '░');

            await _t.TypeWriteAsync("── Your Stats ──────────────────────");
            await _t.TypeWriteAsync($"  Title:           Software Developer");
            await _t.TypeWriteAsync($"  Health:          100");
            await _t.TypeWriteAsync($"  ⌨  Typing         [{typingBar}] {_typing}/100");
            await _t.TypeWriteAsync($"  🧠 Problem Solving [{psBar}] {_problemSolving}/100");
            await _t.TypeWriteAsync($"  😏 Smugness        [{smBar}] {_smugness}/100");
            await _t.TypeWriteAsync("────────────────────────────────────");
            _t.BlankLine();

            await _t.TypeWriteAsync("Press ENTER to continue...", "text-red");
            await _t.ReadLineAsync();

            await RunSWERoundOne();
        }

        // ── SWE Round 1 (Gene intro + waiting room) ────────────────────────────────

        private async Task RunSWERoundOne()
        {
            _t.BlankLine();
            await _t.TypeWriteAsync("Gene: Wow you look like a strong candidate.");
            await _t.TypeWriteAsync("Gene: You might last longer than the last candidate, god rest her soul.");
            await _t.TypeWriteAsync("Gene: Anyway, lets get into it. There will be 3 Rounds of interviews.");
            await _t.TypeWriteAsync("Gene: Round 1 is with John, he's our HR guy. Loves to chat.");
            await _t.TypeWriteAsync("Gene: Next up is Sheila, she's our Engineering Lead and has been here an eternity.");
            await _t.TypeWriteAsync("Gene: Finally, you'll meet Galgomel, harbinger of souls. He's a PM.");
            await _t.TypeWriteAsync("Gene: Excited?");
            _t.BlankLine();
            await _t.TypeWriteAsync("Yes or No?", "text-red");

            string excitedAnswer;
            while (true)
            {
                excitedAnswer = await _t.ReadLineAsync();
                var l = excitedAnswer.ToLower();
                if (l is "yes" or "y" or "no" or "n") break;
                await _t.TypeWriteAsync("Yes or No?", "text-red");
            }

            if (excitedAnswer.ToLower() is "no" or "n")
            {
                await _t.TypeWriteAsync("Gene: Oh wow. Honesty the best policy eh?");
                await _t.TypeWriteAsync("Gene: Well how about I shoot you in the face? How is that huh?");
                _t.BlankLine();
                await _t.TypeWriteAsync("Gene shot you in the face. You Died.", "text-magenta");
                await ShowGameOver();
                return;
            }

            _t.BlankLine();
            await _t.TypeWriteAsync("Gene: Hmm...you really don't look it.");
            await _t.TypeWriteAsync("Gene: Nevermind, not like you can leave any time you want. Which of course you can.");
            _t.BlankLine();
            await _t.TypeWriteAsync("Gene was still smiling. It was as if he had been staring past me the entire time.", "text-yellow");
            await _t.TypeWriteAsync("I could feel sweat start to gather on my brow. I didn't want to wipe it away and hoped he couldn't see it.", "text-yellow");
            await _t.TypeWriteAsync("So far this process has been quite different than when I interviewed at Intercom.", "text-yellow");
            await _t.TypeWriteAsync("As long as you were a white man you had no issues getting into Intercom, this felt like it might be quite different.", "text-yellow");
            _t.BlankLine();

            await _t.TypeWriteAsync($"Gene: Alright {_playerName}, I think it's time for you to meet with John. Please wait here.");
            await _t.TypeWriteAsync("Gene: If I were you I wouldn't go anywhere. Although if I were you I wouldn't be here in the first place.");
            _t.BlankLine();
            await _t.TypeWriteAsync("Press ENTER to wait...", "text-red");
            await _t.ReadLineAsync();
            _t.BlankLine();

            await _t.TypeWriteAsync("Finally I could be alone for a few minutes.", "text-yellow");
            await _t.TypeWriteAsync("Maybe it's just this Gene guy that's throwing me off?", "text-yellow");
            await _t.TypeWriteAsync("Strange though, I feel like I can hear whispering coming from inside the room. Or someone looking at me?", "text-yellow", charDelay: 30);
            await _t.TypeWriteAsync("Or wait...is someone standing awfully close to me? Scanning the room, I see nothing.", "text-yellow", charDelay: 30);
            await _t.TypeWriteAsync("..........", "text-yellow", charDelay: 80);
            await _t.TypeWriteAsync("Maybe I should try the door? Just so I know in my own mind I can leave. I could be really quiet.", "text-yellow", charDelay: 30);
            _t.BlankLine();
            await _t.TypeWriteAsync("Open the door? Yes or No?", "text-red");

            string doorChoice;
            while (true)
            {
                doorChoice = await _t.ReadLineAsync();
                var l = doorChoice.ToLower();
                if (l is "yes" or "y" or "no" or "n") break;
                await _t.TypeWriteAsync("Yes or No?", "text-red");
            }

            if (doorChoice.ToLower() is "no" or "n")
            {
                _t.BlankLine();
                await _t.TypeWriteAsync("You go and sit back down on the seat. Shaking your head at the ridiculousness of your feelings and anxiety.", "text-yellow");
                await _t.TypeWriteAsync("How silly you think, this is just an interview and my nerves are getting to me.", "text-yellow");
                await _t.TypeWriteAsync("Glancing back at the door you think you notice some vapour coming in at the bottom.", "text-yellow");
                await _t.TypeWriteAsync("Hmm. There's that smell of chlorine again....", "text-yellow");
                _t.BlankLine();
                await _t.TypeWriteAsync("You suddenly realize what's happening. But it's too late.", "text-yellow");
                await _t.TypeWriteAsync("You died of poisoning.", "text-yellow");
                await ShowGameOver();
                return;
            }

            await RunJohnInterview();
        }

        // ── John's Interview ──────────────────────────────────────────────────────

        private async Task RunJohnInterview()
        {
            _t.BlankLine();
            await _t.TypeWriteAsync("You stand up and walk towards the door.", "text-yellow", charDelay: 30);
            await _t.TypeWriteAsync("It's as if the whispering gets louder and louder the closer you get to it.", "text-yellow", charDelay: 30);
            await _t.TypeWriteAsync("Reaching your hand out towards the door handle you can already feel the cold emanating from it.", "text-yellow", charDelay: 30);
            await _t.TypeWriteAsync("......", "text-yellow", charDelay: 80);
            await _t.TypeWriteAsync("Before you can pull down on the handle, the door whooshes open.");
            await _t.TypeWriteAsync("Standing in the doorway is John.");

            _t.BlankLine();
            await _t.TypeWriteAsync("Press ENTER to open your eyes...", "text-red");
            await _t.ReadLineAsync();

            _t.Write(@"
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
   \ \|", "text-gray", preformatted: true);

            _t.BlankLine();
            await _t.TypeWriteAsync("He has a blank expression on his face. Like he's not surprised you tried to open the door.", "text-yellow");
            _t.BlankLine();

            await _t.TypeWriteAsync($"John: Please, take a seat {_playerName}.");
            await _t.TypeWriteAsync("John: Apologies for making you wait.");
            await _t.TypeWriteAsync("John: This interview will test your Problem Solving ability.");
            await _t.TypeWriteAsync("John: You will be asked 3 questions. For each question right you gain 10 points. For each wrong, you lose 10.");
            await _t.TypeWriteAsync("John: After that, we shall fight to the death.");
            _t.BlankLine();
            await _t.TypeWriteAsync("You: Excuse me?", "text-yellow");
            _t.BlankLine();
            await _t.TypeWriteAsync("John: We shall fight to the death.");
            _t.BlankLine();
            await _t.TypeWriteAsync("You: Yes I heard that bit but what does it mean?", "text-yellow");
            _t.BlankLine();
            await _t.TypeWriteAsync("John: It means exactly what it means. One of us will perish, you most likely.");
            await _t.TypeWriteAsync("John: Now, no more nonsense — let us begin.");
            _t.BlankLine();

            // Show starting problem solving bar
            ShowPsBar();
            _t.BlankLine();

            // Question 1
            await _t.TypeWriteAsync("John: Question 1.");
            _t.BlankLine();
            await _t.TypeWriteAsync("What gets wetter the more you dry it?");
            _t.BlankLine();
            _t.Write("  1. Humour");
            _t.Write("  2. A Towel");
            _t.Write("  3. Your Hair");
            _t.BlankLine();
            await _t.TypeWriteAsync("Choose your answer:", "text-red");

            string q1;
            while (true)
            {
                q1 = await _t.ReadLineAsync();
                if (q1 is "1" or "2" or "3") break;
                await _t.TypeWriteAsync("Please enter 1, 2, or 3.", "text-red");
            }

            if (q1 == "2")
            {
                _problemSolving += 10;
                await _t.TypeWriteAsync("John: Wow, I'm impressed. 10 points for Gryffindor.", "text-green");
            }
            else
            {
                _problemSolving -= 10;
                await _t.TypeWriteAsync("John: Oh dear. No. No that's wrong.", "text-magenta");
            }
            ShowPsBar();
            _t.BlankLine();

            // Question 2
            await _t.TypeWriteAsync($"John: Alright then, here's Question 2. Listen up {_playerName}.");
            _t.BlankLine();
            await _t.TypeWriteAsync("What has a neck but no head?");
            _t.BlankLine();
            _t.Write("  1. A Giraffe");
            _t.Write("  2. A Bottle");
            _t.Write("  3. You");
            _t.BlankLine();
            await _t.TypeWriteAsync("Choose your answer:", "text-red");

            string q2;
            while (true)
            {
                q2 = await _t.ReadLineAsync();
                if (q2 is "1" or "2" or "3") break;
                await _t.TypeWriteAsync("Please enter 1, 2, or 3.", "text-red");
            }

            if (q2 == "2")
            {
                _problemSolving += 10;
                await _t.TypeWriteAsync("John: I guess you only look like an idiot then.", "text-green");
            }
            else
            {
                _problemSolving -= 10;
                await _t.TypeWriteAsync("John: No.", "text-magenta");
            }
            ShowPsBar();
            _t.BlankLine();

            // Question 3 (open answer)
            await _t.TypeWriteAsync($"John: Last question {_playerName}. Don't mess it up. No multiple choice this time.");
            _t.BlankLine();
            await _t.TypeWriteAsync("If 2 is company and 3 is a crowd, what are 4 and 5?");
            _t.BlankLine();
            await _t.TypeWriteAsync("Your answer:", "text-red");

            string q3 = await _t.ReadLineAsync();
            if (q3.ToLower() is "9" or "nine")
            {
                _problemSolving += 10;
                await _t.TypeWriteAsync("John: Damn. Most get that wrong and I shoot them.", "text-green");
            }
            else
            {
                _problemSolving -= 10;
                await _t.TypeWriteAsync("John: Yeah that's not right chief.", "text-magenta");
            }
            ShowPsBar();
            _t.BlankLine();

            // Boss fight intro
            await _t.TypeWriteAsync("John: Right then. Are you ready to die?");
            _t.BlankLine();
            await _t.TypeWriteAsync("John stood up and backed away from the table.", "text-yellow");
            await _t.TypeWriteAsync("Suddenly he started to grow. Everywhere.", "text-yellow");
            await _t.TypeWriteAsync("He burst out of his shirt and started to shape towards the ceiling like some sort of weird gross HR sunflower.", "text-yellow");
            await _t.TypeWriteAsync("Within seconds he took up half of the room.", "text-yellow");
            _t.BlankLine();
            await _t.TypeWriteAsync("Press ENTER to look up at John...", "text-red");
            await _t.ReadLineAsync();

            _t.Write(@"
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
   / \ \   /.`\      )._           ) (           _.(      /`.\   / /  \", "text-gray", preformatted: true);

            _t.BlankLine();
            await _t.TypeWriteAsync("Monster John: Ah that's much better. You should always bring your true self to work I say.", "text-magenta");
            await _t.TypeWriteAsync("Monster John: Now if you don't mind, I'd love to eat you whole.", "text-magenta");
            _t.BlankLine();
            await _t.TypeWriteAsync("You: EAT MY WHAT?!!", "text-yellow");
            _t.BlankLine();
            await _t.TypeWriteAsync("Monster John: No no I said eat YOU WHOLE!", "text-magenta");
            await _t.TypeWriteAsync("Monster John: Not eat your actual...you know what I mean.", "text-magenta");
            _t.BlankLine();
            await _t.TypeWriteAsync("You: Oh. That's not much better really.", "text-yellow");
            _t.BlankLine();
            await _t.TypeWriteAsync("Taking a step back you were suddenly against the back wall. John seemed to be gearing up to do something....", "text-yellow");
            await _t.TypeWriteAsync("Without warning he started firing VHS tapes towards you at lightning speed.", "text-yellow");
            _t.BlankLine();
            await _t.TypeWriteAsync("Monster John: These are HR training videos from the 90s....feel the drabness and power overtake you.", "text-magenta");
            await _t.TypeWriteAsync("Monster John: No one can stand them muhahahaha!", "text-magenta");
            _t.BlankLine();

            await RunBattle();
        }

        private async Task RunBattle()
        {
            _t.BlankLine();
            await _t.TypeWriteAsync("You have entered into battle with John!", "text-cyan");
            _t.BlankLine();

            bool playerAlive = true;
            int johnHp = 100;
            int playerHp = 100;

            while (playerAlive && johnHp > 0)
            {
                _t.BlankLine();
                ShowBattleHud(playerHp, johnHp);
                _t.BlankLine();

                _t.Write("  1. Player Stats");
                _t.Write("  2. Attack");
                _t.Write("  3. Attempt to escape");
                _t.BlankLine();
                await _t.TypeWriteAsync("What will you do?", "text-red");

                string action;
                while (true)
                {
                    action = await _t.ReadLineAsync();
                    if (action is "1" or "2" or "3") break;
                    await _t.TypeWriteAsync("Choose 1, 2, or 3.", "text-red");
                }

                if (action == "1")
                {
                    _t.BlankLine();
                    string typingBar = new string('█', _typing / 10).PadRight(10, '░');
                    string psBar = new string('█', Math.Max(0, _problemSolving) / 10).PadRight(10, '░');
                    string smBar = new string('█', _smugness / 10).PadRight(10, '░');
                    await _t.TypeWriteAsync("── Your Stats ──────────────────────");
                    await _t.TypeWriteAsync($"  Title:            Software Developer");
                    await _t.TypeWriteAsync($"  HP:               {playerHp}/100");
                    await _t.TypeWriteAsync($"  ⌨  Typing          [{typingBar}] {_typing}/100");
                    await _t.TypeWriteAsync($"  🧠 Problem Solving  [{psBar}] {Math.Max(0, _problemSolving)}/100");
                    await _t.TypeWriteAsync($"  😏 Smugness         [{smBar}] {_smugness}/100");
                    await _t.TypeWriteAsync("────────────────────────────────────");
                    continue;
                }

                if (action == "3")
                {
                    _t.BlankLine();
                    await _t.TypeWriteAsync("You bolt for the door... but it's locked from the outside.", "text-yellow");
                    await _t.TypeWriteAsync("Monster John: Where are you going? We're just getting started!", "text-magenta");
                    continue;
                }

                // Attack
                int dmg = new Random().Next(15, 25) + (_typing / 10);
                johnHp -= dmg;
                _t.BlankLine();
                await _t.TypeWriteAsync("You launch a Stack Overflow attack!", "text-cyan");
                await _t.TypeWriteAsync($"You dealt {dmg} damage to John!", "text-green");

                if (johnHp <= 0)
                {
                    await _t.TypeWriteAsync("John crumples to the floor in a heap of HR paperwork.", "text-yellow");
                    break;
                }

                // John attacks back
                int johnDmg = new Random().Next(10, 20);
                playerHp -= johnDmg;
                await _t.TypeWriteAsync($"Monster John hurls a 1997 Sexual Harassment Training VHS at you for {johnDmg} damage!", "text-magenta");

                if (playerHp <= 0)
                {
                    playerAlive = false;
                }
            }

            if (!playerAlive)
            {
                _t.BlankLine();
                await _t.TypeWriteAsync("You died in battle with John from HR.", "text-magenta");
                await ShowGameOver();
                return;
            }

            // Victory
            _t.BlankLine();
            await _t.TypeWriteAsync("You defeated Monster John!", "text-green");
            await _t.TypeWriteAsync("The room falls silent. A door on the far side slowly opens.", "text-yellow");
            await _t.TypeWriteAsync("A small post-it note drifts from John's collapsed form. It reads:", "text-yellow");
            _t.BlankLine();
            _t.Write(@"
+-------------------------------------------+
|  ""Well done. Round 1 complete.            |
|   Sheila is waiting.                       |
|   She has been here since 1987.            |
|   Good luck.        - The Management""     |
+-------------------------------------------+", "text-cyan", preformatted: true);

            _t.BlankLine();
            await _t.TypeWriteAsync("Round 2 and beyond — coming soon!", "text-green");
            _t.BlankLine();
            await _t.TypeWriteAsync("Thanks for playing The Interview! 🎉", "text-cyan");
            _t.BlankLine();
            await _t.TypeWriteAsync("Press ENTER to return to the main menu.", "text-red");
            await _t.ReadLineAsync();
        }

        // ── Helpers ───────────────────────────────────────────────────────────────

        private void ShowPsBar()
        {
            int level = Math.Max(0, _problemSolving);
            string bar = new string('█', level / 10).PadRight(10, '░');
            _t.Write($"  🧠 Problem Solving [{bar}] {level}/100", "text-cyan");
        }

        private void ShowBattleHud(int playerHp, int johnHp)
        {
            string pBar = new string('█', playerHp / 10).PadRight(10, '░');
            string jBar = new string('█', Math.Max(0, johnHp) / 10).PadRight(10, '░');
            _t.Write($"  You        HP [{pBar}] {playerHp}/100", "text-green");
            _t.Write($"  Monster John HP [{jBar}] {Math.Max(0, johnHp)}/100", "text-magenta");
        }

        private async Task ShowGameOver()
        {
            _t.BlankLine();
            _t.Write(@"
   ____    _    __  __ _____    _____   _______ ____
  / ___|  / \  |  \/  | ____|  / _ \ \ / / ____|  _ \
 | |  _  / _ \ | |\/| |  _|   | | | \ V /|  _| | |_) |
 | |_| |/ ___ \| |  | | |___  | |_| || | | |___|  _ <
  \____/_/   \_\_|  |_|_____|  \___/ |_| |_____|_| \_\", "text-red", preformatted: true);

            _t.BlankLine();
            await _t.TypeWriteAsync("Play again? (Y/N)", "text-red");

            while (true)
            {
                var answer = await _t.ReadLineAsync();
                if (answer.ToLower() is "y" or "yes")
                {
                    _t.Reset();
                    _t.StartGame();
                    return;
                }
                if (answer.ToLower() is "n" or "no")
                {
                    _t.BlankLine();
                    await _t.TypeWriteAsync("Thanks for playing. Click 'Home' in the menu to go back.", "text-cyan");
                    return;
                }
                await _t.TypeWriteAsync("Y or N?", "text-red");
            }
        }
    }
}
