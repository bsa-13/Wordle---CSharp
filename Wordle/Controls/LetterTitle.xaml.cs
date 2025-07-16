// LetterTile.xaml.cs
using System.Windows.Controls;

namespace WordleGame.Controls
{
    public partial class LetterTile : UserControl
    {
        public LetterTile()
        {
            InitializeComponent();
        }

        public void SetLetter(char letter)
        {
            TileText.Text = letter.ToString();
        }

        public void SetState(string state)
        {
            switch (state)
            {
                case "Correct":
                    TileBorder.Background = System.Windows.Media.Brushes.Green;
                    break;
                case "Present":
                    TileBorder.Background = System.Windows.Media.Brushes.Gold;
                    break;
                case "Absent":
                    TileBorder.Background = System.Windows.Media.Brushes.Gray;
                    break;
            }
        }
    }
}
