using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertPro
{
    public static class EmbeddedToolsExtractor
    {
        public static void EnsureYtDlp()
        {
            string appDir = AppDomain.CurrentDomain.BaseDirectory;
            string ytDlpPath = Path.Combine(appDir, "yt-dlp.exe");

            if (!File.Exists(ytDlpPath))
            {
                throw new FileNotFoundException(
                    "yt-dlp.exe não encontrado na pasta do aplicativo."
                );
            }
        }

        public static void EnsureFfmpeg()
        {
            string appDir = AppDomain.CurrentDomain.BaseDirectory;
            string ffmpegPath = Path.Combine(appDir, "ffmpeg.exe");

            if (!File.Exists(ffmpegPath))
            {
                throw new FileNotFoundException(
                    "ffmpeg.exe não encontrado na pasta do aplicativo."
                );
            }
        }
    }
}
