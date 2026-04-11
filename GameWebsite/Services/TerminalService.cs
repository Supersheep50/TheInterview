namespace GameWebsite.Services
{
    public class TerminalLine
    {
        public string Text { get; set; } = "";
        public string CssClass { get; set; } = "";
        public bool IsPreformatted { get; set; }
    }

    public class TerminalService
    {
        public List<TerminalLine> Lines { get; } = new();
        public bool WaitingForInput { get; private set; }
        public bool GameStarted { get; private set; }

        public event Action? OnStateChanged;

        private TaskCompletionSource<string>? _inputTcs;

        // TypeWriter effect — adds characters one at a time
        public async Task TypeWriteAsync(string text, string cssClass = "", int charDelay = 15)
        {
            var line = new TerminalLine { CssClass = cssClass };
            Lines.Add(line);
            OnStateChanged?.Invoke();

            foreach (char c in text)
            {
                line.Text += c;
                OnStateChanged?.Invoke();
                await Task.Delay(charDelay);
            }
        }

        // Instant write — for ASCII art and fast output
        public void Write(string text, string cssClass = "", bool preformatted = false)
        {
            Lines.Add(new TerminalLine { Text = text, CssClass = cssClass, IsPreformatted = preformatted });
            OnStateChanged?.Invoke();
        }

        public void BlankLine()
        {
            Lines.Add(new TerminalLine());
            OnStateChanged?.Invoke();
        }

        // Pauses the game loop until the user types something and presses Enter
        public async Task<string> ReadLineAsync()
        {
            WaitingForInput = true;
            _inputTcs = new TaskCompletionSource<string>(TaskCreationOptions.RunContinuationsAsynchronously);
            OnStateChanged?.Invoke();

            var result = await _inputTcs.Task;

            WaitingForInput = false;
            Lines.Add(new TerminalLine { Text = $">> {result}", CssClass = "echo" });
            OnStateChanged?.Invoke();

            return result.Trim();
        }

        // Called by the UI when the user hits Enter
        public void SubmitInput(string input)
        {
            _inputTcs?.TrySetResult(input);
        }

        public void StartGame()
        {
            GameStarted = true;
        }

        public void Reset()
        {
            Lines.Clear();
            WaitingForInput = false;
            GameStarted = false;
            _inputTcs?.TrySetCanceled();
            _inputTcs = null;
            OnStateChanged?.Invoke();
        }
    }
}
