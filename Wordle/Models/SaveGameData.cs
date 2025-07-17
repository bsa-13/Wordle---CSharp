namespace WordleGame.Models
{
    public class SaveGameData
    {
        public List<string> Guesses { get; set; }
        public bool IsGameOver { get; set; }
        public string TargetWord { get; set; }
    }
}
