namespace WordleGame.Models
{
    public class GameStatistics
    {
        public int TotalGames { get; set; } = 0;
        public int GamesWon { get; set; } = 0;
        public int CurrentStreak { get; set; } = 0;
        public int MaxStreak { get; set; } = 0;
        public int[] GuessDistribution { get; set; } = new int[6]; // index 0 = 1 try, index 5 = 6 tries

        public double WinRate => TotalGames == 0 ? 0 : (GamesWon * 100.0 / TotalGames);
    }
}
