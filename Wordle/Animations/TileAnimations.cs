using System.Windows.Controls;
using System.Windows.Media.Animation;
using WordleGame.Controls;
using System.Windows;

namespace WordleGame.Animations
{
    public static class TileAnimations
    {
        public static void Bounce(LetterTile tile)
        {
            var animation = new DoubleAnimation(1, 1.2, new Duration(TimeSpan.FromMilliseconds(100)))
            {
                AutoReverse = true
            };
            tile.BeginAnimation(Control.RenderTransformProperty, animation);
        }
    }
}
