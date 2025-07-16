using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace WordleGame.Animations
{
    public static class TileAnimations
    {
        public static void Bounce(Tile tile)
        {
            var animation = new DoubleAnimation(1, 1.2, new Duration(TimeSpan.FromMilliseconds(100)))
            {
                AutoReverse = true
            };
            tile.BeginAnimation(Control.RenderTransformProperty, animation);
        }
    }
}
