namespace WordleGame.Services
{
    public class GameEngine
    {
        public string TargetWord { get; private set; }

        public GameEngine(string word)
        {
            TargetWord = word.ToLower();
        }

        public bool IsCorrect(string guess)
        {
            return guess.ToLower() == TargetWord;
        }
        
        
        public bool CheckGuess(string guess, string solution)
        {
         return guess.Equals(solution, StringComparison.OrdinalIgnoreCase);
        }
        


        public bool ValidateGuess(string guess)
{
    return guess.Length == 5;
}
    }
}
