using System;
using System.IO;
using System.Windows.Forms;

namespace TOEIC_Practice.Helpers
{
    public static class MediaPathHelper
    {
        public static string GetAbsoluteAudioPath(string relativeAudioPath)
        {
            if (string.IsNullOrWhiteSpace(relativeAudioPath))
                return null;

            string clean = NormalizeRelativePath(relativeAudioPath);

            return Path.Combine(
                Application.StartupPath,
                "Assets",
                "Audio",
                clean.Replace("/", "\\"));
        }

        public static string GetAbsoluteImagePath(string relativeImagePath)
        {
            if (string.IsNullOrWhiteSpace(relativeImagePath))
                return null;

            string clean = NormalizeRelativePath(relativeImagePath);

            return Path.Combine(
                Application.StartupPath,
                "Assets",
                "Images",
                clean.Replace("/", "\\"));
        }

        private static string NormalizeRelativePath(string path)
        {
            string clean = path.Trim().Replace("\\", "/");

            if (clean.StartsWith("Audio/", StringComparison.OrdinalIgnoreCase))
                clean = clean.Substring("Audio/".Length);

            if (clean.StartsWith("Image/", StringComparison.OrdinalIgnoreCase))
                clean = clean.Substring("Image/".Length);

            if (clean.StartsWith("Images/", StringComparison.OrdinalIgnoreCase))
                clean = clean.Substring("Images/".Length);

            return clean;
        }
    }
}