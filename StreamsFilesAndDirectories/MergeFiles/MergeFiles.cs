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
            using var writerOutputFile = new StreamWriter(outputFilePath);

            while (!readerFirstFile.EndOfStream || !readerSecondFile.EndOfStream)
            {
                if (!readerFirstFile.EndOfStream)
                {
                    writerOutputFile.WriteLine(readerFirstFile.ReadLine());
                }

                if (!readerSecondFile.EndOfStream)
                {
                    writerOutputFile.WriteLine(readerSecondFile.ReadLine());
                }
            }
        }
    }
}
