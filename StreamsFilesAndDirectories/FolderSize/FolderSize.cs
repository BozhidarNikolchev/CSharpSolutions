namespace FolderSize
{
    using System;
    using System.IO;
    using System.Linq;

    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            long totalBytes = 0;

            foreach (var file in Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories))
            {
                totalBytes += new FileInfo(file).Length;
            }

            double totalKB = totalBytes / 1024.0;

            string result = $"{totalKB.ToString()} KB";
            File.WriteAllText(outputFilePath, result);
        }
    }
}
