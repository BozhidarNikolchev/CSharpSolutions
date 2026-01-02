namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using var readerFirstFile = new StreamReader(firstInputFilePath);
            using var readerSecondFile = new StreamReader(secondInputFilePath);

            while (!readerFirstFile.EndOfStream || !readerSecondFile.EndOfStream)
            {
                // Check EACH file individually
                if (!readerFirstFile.EndOfStream)
                {
                    string? line1 = readerFirstFile.ReadLine();
                    if (line1 != null) Console.WriteLine(line1);
                }

                if (!readerSecondFile.EndOfStream)
                {
                    string? line2 = readerSecondFile.ReadLine();
                    if (line2 != null) Console.WriteLine(line2);
                }
            }
        }
    }
}
