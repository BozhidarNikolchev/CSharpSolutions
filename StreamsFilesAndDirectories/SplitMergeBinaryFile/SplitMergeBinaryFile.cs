namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using var sourceFileStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read);
            long sourceFileLength = sourceFileStream.Length;

            long lengthOne = sourceFileLength / 2;
            if (sourceFileLength % 2 != 0)
            {
                lengthOne = (sourceFileLength / 2) + 1;
            }

            long lengthTwo = sourceFileLength - lengthOne;

            byte[] bufferOne = new byte[lengthOne];
            sourceFileStream.Read(bufferOne, 0, bufferOne.Length);
            File.WriteAllBytes(partOneFilePath, bufferOne);

            byte[] bufferTwo = new byte[lengthTwo];
            sourceFileStream.Read(bufferTwo, 0, bufferTwo.Length);
            File.WriteAllBytes(partTwoFilePath, bufferTwo);
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using var joinedFileStream = new FileStream(joinedFilePath, FileMode.Create, FileAccess.Write);

            string[] sourceFiles = { partOneFilePath, partTwoFilePath };

            foreach (var file in sourceFiles)
            {
                using var currentFile = new FileStream(file, FileMode.Open, FileAccess.Read);
                currentFile.CopyTo(joinedFileStream);
            }
        }
    }
}