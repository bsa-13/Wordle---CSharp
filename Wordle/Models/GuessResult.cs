using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleGame.Models
{
    public class GuessResult
    {
        public string Guess { get; set; }
        public string[] TileStates { get; set; } // e.g., Correct, Present, Absent
    }
}
