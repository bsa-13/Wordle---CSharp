using System.Windows;
using System.Windows.Controls;
using WordleGame.Services;

namespace WordleGame.Views
{
    public partial class StatisticsWindow : Window
    {
        public StatisticsWindow(StatisticsService statsService)
        {
            InitializeComponent();
            LoadStats(statsService);
        }

        private void LoadStats(StatisticsService service)
        {
            var stats = service.Stats;

            TotalGamesText.Text = $"Total Games: {stats.TotalGames}";
            GamesWonText.Text = $"Games Won: {stats.GamesWon}";
            WinRateText.Text = $"Win Rate: {stats.WinRate:F1}%";
            CurrentStreakText.Text = $"Current Streak: {stats.CurrentStreak}";
            MaxStreakText.Text = $"Max Streak: {stats.MaxStreak}";

            GuessDistributionList.Items.Clear();
            for (int i = 0; i < stats.GuessDistribution.Length; i++)
            {
                GuessDistributionList.Items.Add(new TextBlock
                {
                    Text = $"{i + 1} tries: {stats.GuessDistribution[i]}",
                    Margin = new Thickness(2)
                });
            }
        }
    }
}
