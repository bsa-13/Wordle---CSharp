using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace WordleGame.Services
{
    public class WordRepository
    {
        private readonly List<string> validWords;

        public WordRepository(string filePath)
        {
            validWords = new List<string>();
            LoadWords(filePath);
        }

        private bool IsAlpha(string word)
        {
            foreach (char c in word)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }

        private void LoadWords(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Word list file not found", filePath);

            foreach (var line in File.ReadAllLines(filePath))
            {
                string word = line.Trim().ToLower();
                if (word.Length == 5 && IsAlpha(word))
                    validWords.Add(word);

            }
        }

        public bool IsValidWord(string word)
        {
            return validWords.Contains(word.ToLower());
        }

        public string GetRandomWord()
        {
            var random = new Random();
            int index = random.Next(validWords.Count);
            string chosenWord = validWords[index];
            return chosenWord;
        }




    }
}
