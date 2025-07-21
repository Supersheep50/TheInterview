using System.Text;
using System.Text.Json;

namespace TextRPG
{

    public static class SaveSystem
    {
        private const string SaveFilePath = "savegame.json";


        public static void Save()
        {
            if (GameState.CurrentProgress == null || GameState.CurrentProgress.Player == null)
            {
                MainMenu.TypeWriter("Nothing to save yet silly.");
                return;
            }

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IncludeFields = true
            };
        }
    }
}