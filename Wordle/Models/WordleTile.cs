using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleGame.Models
{
   public class WordleTile
    {
        public char Letter { get; set; }
        public string State { get; set; } // Correct, Present, Absent

    }
}
