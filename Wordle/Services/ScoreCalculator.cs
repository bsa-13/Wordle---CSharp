using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleGame.Services
{
    public static class ScoreCalculator
    {
        public static int CalculateScore(int attempt)
        {
            return (7 - attempt) * 10; // Simple scoring system
        }
    }

}
