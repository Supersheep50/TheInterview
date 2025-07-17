namespace TextRPG
{
    public static class GameOutput
    {
        public static List<string> OutputLog { get; } = new List<string>();

        public static void W(string message)
        {
            OutputLog.Add(message);
        }

        public static void Clear()
        {
            OutputLog.Clear();
        }
    }
}
