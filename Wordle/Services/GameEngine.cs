using WordleGame.Services;

namespace WordleGame.Services
{
    public class GameEngine
    {
        public string TargetWord { get; private set; }
        private WordRepository repository;

        public GameEngine(string word)
        {
            TargetWord = word.ToLower();
            repository = new WordRepository("Data/WordList.txt");
        }

        public bool IsCorrect(string guess)
        {
            return guess.ToLower() == TargetWord;
        }

        public bool ValidateGuess(string guess)
        {
            return guess.Length == 5 && repository.IsValidWord(guess);
        }
    }
}
