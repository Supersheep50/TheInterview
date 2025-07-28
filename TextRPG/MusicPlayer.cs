using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace TextRPG
{
    public static class MusicPlayer
    {
        public static void PlayLoopingMusic(string filepath)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                PlayOnMac(filepath);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                PlayOnWindows(filepath);
            }
            else
            {
                Console.WriteLine("Unsupported OS for music playback.");
            }
        }

        private static void PlayOnMac(string filepath)
        {
            new Thread(() =>
            {
                while (true)
                {
                    var process = Process.Start(new ProcessStartInfo
                    {
                        FileName = "afplay",
                        Arguments = $"\"{filepath}\"",
                        UseShellExecute = false
                    });
                    process.WaitForExit();
                }
            }).Start();
        }

        private static void PlayOnWindows(string filepath)
        {
            new Thread(() =>
            {
                while (true)
                {
                    var process = Process.Start(new ProcessStartInfo
                    {
                        FileName = "powershell",
                        Arguments = $"-c (New-Object Media.SoundPlayer '{filepath}').PlaySync();",
                        UseShellExecute = false,
                        CreateNoWindow = true
                    });
                    process.WaitForExit();
                }
            }).Start();
        }
    }
}
