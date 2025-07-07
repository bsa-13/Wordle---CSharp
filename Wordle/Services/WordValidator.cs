using System.Collections.Generic;

namespace WordleGame.Services
{
    public enum LetterState
    {
        Correct,     // Right letter, right place
        Present,     // Right letter, wrong place
        Absent       // Not in word
    }

    public class WordValidator
    {
        public static List<LetterState> ValidateGuess(string guess, string solution)
        {
            guess = guess.ToLower();
            solution = solution.ToLower();

            var result = new List<LetterState>(new LetterState[guess.Length]);
            var solutionCharCount = new Dictionary<char, int>();

            for (int i = 0; i < solution.Length; i++)
            {
                if (!solutionCharCount.ContainsKey(solution[i]))
                    solutionCharCount[solution[i]] = 0;
                solutionCharCount[solution[i]]++;
            }

            // First pass: mark correct letters
            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] == solution[i])
                {
                    result[i] = LetterState.Correct;
                    solutionCharCount[guess[i]]--;
                }
            }

            // Second pass: mark present and absent letters
            for (int i = 0; i < guess.Length; i++)
            {
                if (result[i] == LetterState.Correct)
                    continue;

                if (solutionCharCount.ContainsKey(guess[i]) && solutionCharCount[guess[i]] > 0)
                {
                    result[i] = LetterState.Present;
                    solutionCharCount[guess[i]]--;
                }
                else
                {
                    result[i] = LetterState.Absent;
                }
            }

            return result;
        }
    }
}
