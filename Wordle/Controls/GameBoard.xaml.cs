using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WordleGame.Controls
{
    public partial class GameBoard : UserControl
    {
        private const int Rows = 6;
        private const int Columns = 5;

        public GameBoard()
        {
            InitializeComponent();
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            BoardGrid.RowDefinitions.Clear();
            BoardGrid.ColumnDefinitions.Clear();

            for (int i = 0; i < Rows; i++)
                BoardGrid.RowDefinitions.Add(new RowDefinition());

            for (int j = 0; j < Columns; j++)
                BoardGrid.ColumnDefinitions.Add(new ColumnDefinition());

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Border tile = new Border
                    {
                        BorderBrush = Brushes.Black,
                        BorderThickness = new Thickness(1),
                        Margin = new Thickness(5),
                        Width = 50,
                        Height = 50,
                        Background = Brushes.White,
                        Child = new TextBlock
                        {
                            Text = "",
                            HorizontalAlignment = HorizontalAlignment.Center,
                            VerticalAlignment = VerticalAlignment.Center,
                            FontSize = 20,
                            FontWeight = FontWeights.Bold
                        }
                    };

                    Grid.SetRow(tile, i);
                    Grid.SetColumn(tile, j);
                    BoardGrid.Children.Add(tile);
                }
            }
        }
    }
}
