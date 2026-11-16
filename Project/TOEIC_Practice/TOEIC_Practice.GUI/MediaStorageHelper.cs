using System;
using System.IO;
using System.Windows.Forms;

namespace TOEIC_Practice.Helpers
{
    public static class MediaStorageHelper
    {
        public static string SaveAudioToAssets(string sourceFilePath, string partFolder)
        {
            return SaveMediaToAssets(sourceFilePath, "Audio", partFolder);
        }

        public static string SaveImageToAssets(string sourceFilePath, string partFolder)
        {
            return SaveMediaToAssets(sourceFilePath, "Images", partFolder);
        }

        private static string SaveMediaToAssets(string sourceFilePath, string mediaRootFolder, string partFolder)
        {
            if (string.IsNullOrWhiteSpace(sourceFilePath))
                throw new Exception("Đường dẫn file nguồn đang rỗng.");

            if (!File.Exists(sourceFilePath))
                throw new Exception("File nguồn không tồn tại.");

            if (string.IsNullOrWhiteSpace(partFolder))
                throw new Exception("Không xác định được Part folder.");

            string fileName = Path.GetFileName(sourceFilePath);

            string destFolder = Path.Combine(
                Application.StartupPath,
                "Assets",
                mediaRootFolder,
                partFolder);

            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);

            string destFilePath = Path.Combine(destFolder, fileName);

            File.Copy(sourceFilePath, destFilePath, true);

            return partFolder.Replace("\\", "/") + "/" + fileName;
        }
    }
}