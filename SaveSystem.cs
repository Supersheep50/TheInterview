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

            string json = JsonSerializer.Serialize(GameState.CurrentProgress, options);
            File.WriteAllText(SaveFilePath, json);
            MainMenu.TypeWriter("Game saved successfully");
        }
        public static void Load()
        {
            if (!File.Exists(SaveFilePath))
            {
                MainMenu.TypeWriter("No save file found, LIAR");
                return;
            }
            string json = File.ReadAllText(SaveFilePath);

            // detect which player class to use
            Player loadedPlayer = null;

            if (json.Contains("\"Title\":\"Software Developer\""))
                loadedPlayer = JsonSerializer.Deserialize<SoftwareDev>(json);
            else if (json.Contains("\"Title\":\"Recruiter\""))
                loadedPlayer = JsonSerializer.Deserialize<Recruiter>(json);
            else if (json.Contains("\"Title\":\"Salesperson\""))
                loadedPlayer = JsonSerializer.Deserialize<Sales>(json);
            else if (json.Contains("\"Title\":\"CEO\""))
                loadedPlayer = JsonSerializer.Deserialize<CEO>(json);

            if (loadedPlayer == null)
            {
                MainMenu.TypeWriter("Failed to load player");
                return;
            }
            // Manually restore progress
            GameProgress progress = new GameProgress
            {
                Player = loadedPlayer,
                CurrentStage = ExtractStageFromJson(json)
            };

            GameState.CurrentProgress = progress;
            MainMenu.TypeWriter("Game loaded");
        }

        private static string ExtractStageFromJson(string json)
        {
            int index = json.IndexOf("\"CurrentStage\"");
            if (index == -1) return "Unknown";

            int start = json.IndexOf(':', index) + 2;
            int end = json.IndexOf('"', start);
            return json.Substring(start, end - start);
        }
    }
}