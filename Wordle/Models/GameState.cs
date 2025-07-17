using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleGame.Models
{
    public class GameState
    {
        public int CurrentAttempt { get; set; }
        public bool IsGameOver { get; set; }
        public bool IsWin { get; set; }


    }
}
