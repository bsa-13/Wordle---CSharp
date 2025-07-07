using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml;
using WordleGame.Models;

namespace WordleGame.Services
{
    public class StatisticsService
    {
        private const string StatsFilePath = "game_stats.json";
        public GameStatistics Stats { get; private set; }

        public StatisticsService()
        {
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            if (File.Exists(StatsFilePath))
            {
                string json = File.ReadAllText(StatsFilePath);
                Stats = JsonConvert.DeserializeObject<GameStatistics>(json);
            }
            else
            {
                Stats = new GameStatistics();
            }
        }

        public void SaveStatistics()
        {
            string json = JsonConvert.SerializeObject(Stats, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(StatsFilePath, json);
        }

        public void UpdateStats(bool won, int attempts)
        {
            Stats.TotalGames++;

            if (won)
            {
                Stats.GamesWon++;
                Stats.CurrentStreak++;
                if (Stats.CurrentStreak > Stats.MaxStreak)
                    Stats.MaxStreak = Stats.CurrentStreak;

                if (attempts >= 1 && attempts <= 6)
                    Stats.GuessDistribution[attempts - 1]++;
            }
            else
            {
                Stats.CurrentStreak = 0;
            }

            SaveStatistics();
        }
    }
}
