namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            var reader = new StreamReader(inputFilePath);
            var writer = new StreamWriter(outputFilePath);

            int lineNum = 1;

            while (true)
            {
                var currentLine= reader.ReadLine(); 

                if (currentLine == null)
                {
                    break;
                }

                writer.WriteLine($"{lineNum}. {currentLine}");

                lineNum++;
            }
        }
    }
}
