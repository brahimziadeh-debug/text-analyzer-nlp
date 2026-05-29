using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TextAnalyzer
{
    /// <summary>
    /// Provides NLP analysis methods for text processing.
    /// </summary>
    public class NLPAnalyzer
    {
        /// <summary>
        /// Gets the total character count including spaces.
        /// </summary>
        /// <param name="text">The text to analyze</param>
        /// <returns>Total character count</returns>
        public static int GetCharacterCount(string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0;
            return text.Length;
        }

        /// <summary>
        /// Gets the total word count.
        /// </summary>
        /// <param name="text">The text to analyze</param>
        /// <returns>Total word count</returns>
        public static int GetWordCount(string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0;

            // Split by whitespace and remove empty entries
            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        /// <summary>
        /// Gets the sentence count based on sentence terminators (. ! ?).
        /// </summary>
        /// <param name="text">The text to analyze</param>
        /// <returns>Total sentence count</returns>
        public static int GetSentenceCount(string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0;

            // Count sentences ending with . ! or ?
            int sentenceCount = 0;
            foreach (char c in text)
            {
                if (c == '.' || c == '!' || c == '?')
                    sentenceCount++;
            }

            return sentenceCount > 0 ? sentenceCount : 0;
        }

        /// <summary>
        /// Gets the total vowel count (case-insensitive).
        /// </summary>
        /// <param name="text">The text to analyze</param>
        /// <returns>Total vowel count</returns>
        public static int GetVowelCount(string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0;

            int vowelCount = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in text)
            {
                if (vowels.Contains(c))
                    vowelCount++;
            }

            return vowelCount;
        }

        /// <summary>
        /// Gets the most frequent word in the text.
        /// </summary>
        /// <param name="text">The text to analyze</param>
        /// <returns>The most frequent word, or empty string if no words found</returns>
        public static string GetMostFrequentWord(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";

            // Extract words and convert to lowercase
            string[] words = Regex.Split(text.ToLower(), @"\W+")
                .Where(w => !string.IsNullOrEmpty(w) && w.Length > 1) // Filter out empty and single char
                .ToArray();

            if (words.Length == 0)
                return "";

            // Count word frequencies
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (wordFrequency.ContainsKey(word))
                    wordFrequency[word]++;
                else
                    wordFrequency[word] = 1;
            }

            // Find the most frequent word
            string mostFrequent = wordFrequency.OrderByDescending(x => x.Value).First().Key;
            return mostFrequent;
        }

        /// <summary>
        /// Searches for a word in the text and returns the count.
        /// </summary>
        /// <param name="text">The text to search in</param>
        /// <param name="searchWord">The word to search for</param>
        /// <returns>Number of occurrences</returns>
        public static int SearchWord(string text, string searchWord)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(searchWord))
                return 0;

            // Case-insensitive search
            string textLower = text.ToLower();
            string searchLower = searchWord.ToLower();

            int count = 0;
            int index = 0;
            while ((index = textLower.IndexOf(searchLower, index)) != -1)
            {
                count++;
                index += searchLower.Length;
            }

            return count;
        }

        /// <summary>
        /// Gets word frequency as a dictionary.
        /// </summary>
        /// <param name="text">The text to analyze</param>
        /// <returns>Dictionary with words and their frequencies</returns>
        public static Dictionary<string, int> GetWordFrequency(string text)
        {
            if (string.IsNullOrEmpty(text))
                return new Dictionary<string, int>();

            string[] words = Regex.Split(text.ToLower(), @"\W+")
                .Where(w => !string.IsNullOrEmpty(w) && w.Length > 1)
                .ToArray();

            Dictionary<string, int> frequency = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (frequency.ContainsKey(word))
                    frequency[word]++;
                else
                    frequency[word] = 1;
            }

            return frequency;
        }

        /// <summary>
        /// Gets a list of stop words to be filtered out.
        /// </summary>
        /// <returns>List of common stop words</returns>
        public static List<string> GetStopWords()
        {
            return new List<string>
            {
                "a", "an", "and", "are", "as", "at", "be", "by", "for", "from",
                "has", "he", "in", "is", "it", "its", "of", "on", "or", "that",
                "the", "to", "was", "will", "with", "i", "me", "my", "we", "you"
            };
        }

        /// <summary>
        /// Removes stop words from the text.
        /// </summary>
        /// <param name="text">The text to process</param>
        /// <returns>Text with stop words removed</returns>
        public static string RemoveStopWords(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";

            List<string> stopWords = GetStopWords();
            string[] words = Regex.Split(text.ToLower(), @"\W+")
                .Where(w => !string.IsNullOrEmpty(w))
                .ToArray();

            var filteredWords = words.Where(w => !stopWords.Contains(w)).ToList();
            return string.Join(" ", filteredWords);
        }
    }
}
