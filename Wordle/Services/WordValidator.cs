using System;

public enum LetterState
{
    Absent,
    Present,
    Correct
}


namespace WordleGame.Services
{
    public static class WordValidator
    {
        public static LetterState[] ValidateGuess(string guess, string target)
        {
            var result = new LetterState[5];
            var targetChars = target.ToCharArray();
            var guessChars = guess.ToCharArray();
            for (int i = 0; i < 5; i++)
            {
                if (guessChars[i] == targetChars[i])
                {
                    result[i] = LetterState.Correct;
                    targetChars[i] = '*';
                    guessChars[i] = '#'; 
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (result[i] != LetterState.Correct)
                {
                    int idx = Array.IndexOf(targetChars, guessChars[i]);
                    if (idx != -1)
                    {
                        result[i] = LetterState.Present;
                        targetChars[idx] = '*'; 
                    }
                    else
                    {
                        result[i] = LetterState.Absent;
                    }
                }
            }

            return result;
        }
    }
}
