namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using var wordsReader = new StreamReader(wordsFilePath);

            var checkWords = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            string wordLine = string.Empty;
            while ((wordLine = wordsReader.ReadLine()) != null)
            {
                var currentWordLine = wordLine.Split();
                foreach (var word in currentWordLine)
                {
                    checkWords.Add(word);
                }
            }

            using var textReader = new StreamReader(textFilePath);

            var resultWords = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            string textLine = string.Empty;
            while ((textLine = textReader.ReadLine()) != null)
            {
                var currentTextLine = textLine.Split(
    new[] { "\u2026", "...", "\u0085", "-", " ", ",", ".", "?", "!" },
    StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

                foreach (var word in currentTextLine)
                {
                    if (checkWords.Contains(word))
                    {
                        if (!resultWords.ContainsKey(word))
                            resultWords.Add(word, 1);
                        else
                            resultWords[word]++;
                    }
                }
            }

            using var writer = new StreamWriter(outputFilePath);

            foreach (var kvp in resultWords.OrderByDescending(kvp => kvp.Value))
            {
                writer.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
