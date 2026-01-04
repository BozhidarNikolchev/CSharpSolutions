namespace ExtractSpecialBytes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            string textFileContent = File.ReadAllText(bytesFilePath);

            string[] textFileElements = textFileContent.Split(new[] { "\r\n", "\r", "\n", " " },
                StringSplitOptions.RemoveEmptyEntries);

            HashSet<byte> targetBytes = new();

            foreach (string element in textFileElements)
            {
                if (byte.TryParse(element, out byte b))
                {
                    targetBytes.Add(b);
                }
            }

            byte[] pngFileInBytes = File.ReadAllBytes(binaryFilePath);

            List<byte> resultBytes = new();

            foreach (byte currentByte in pngFileInBytes)
            {
                if (targetBytes.Contains(currentByte))
                {
                    resultBytes.Add(currentByte);
                }
            }

            File.WriteAllBytes(outputPath, resultBytes.ToArray());
        }
    }
}
