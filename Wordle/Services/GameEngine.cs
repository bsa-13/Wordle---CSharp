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
    }
}
