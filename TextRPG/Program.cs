using System;

namespace TextRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start music in background
            MusicPlayer.PlayLoopingMusic("music/leavinghome.wav");

            // Launch the main menu
            MainMenu.Menu();

            // Keeps the app alive in case needed
            Console.ReadLine();
        }
    }
}
