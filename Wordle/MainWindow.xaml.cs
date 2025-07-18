using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using WordleGame.Services;

namespace WordleGame
{
    public partial class MainWindow : Window
    {
        private string currentGuess = "";
        private int currentRow = 0;
        private GameEngine engine;
        private Button[,] letterTiles = new Button[6, 5];


        public MainWindow()
        {
            InitializeComponent();

            var repo = new WordRepository("Data/WordList.txt");
            engine = new GameEngine(repo.GetRandomWord());

            this.KeyDown += MainWindow_KeyDown;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (currentRow >= 6) return;

            // Handle A-Z key input
            if (e.Key >= Key.A && e.Key <= Key.Z)
            {
                if (currentGuess.Length < 5)
                {
                    string letter = e.Key.ToString();
                    if (letter.Length == 2 && letter.StartsWith("D")) letter = letter[1].ToString();

                    currentGuess += letter;
                    UpdateTile(currentRow, currentGuess.Length - 1, letter);
                }
                else
                {
                    MessageBox.Show("Word must be exactly 5 letters.");
                }
            }
            // Handle Backspace
            else if (e.Key == Key.Back && currentGuess.Length > 0)
            {
                currentGuess = currentGuess.Substring(0, currentGuess.Length - 1);
                UpdateTile(currentRow, currentGuess.Length, "");
            }
            // Handle Enter
            else if (e.Key == Key.Enter)
            {
                if (currentGuess.Length != 5)
                {
                    MessageBox.Show("Word must be exactly 5 letters.");
                    return;
                }

                var result = WordValidator.ValidateGuess(currentGuess.ToLower(), engine.TargetWord.ToLower());

                for (int i = 0; i < 5; i++)
                {
                    UpdateTileState(currentRow, i, result[i]);
                }

                if (engine.IsCorrect(currentGuess))
                {
                    MessageBox.Show("You win!");
                    currentRow = 6;
                }
                else
                {
                    currentRow++;
                    currentGuess = "";

                    if (currentRow >= 6)
                    {
                        MessageBox.Show("Out of tries! Word was: " + engine.TargetWord);
                    }
                }
            }

        }

        private void UpdateTile(int row, int col, string letter)
        {
            int index = row * 5 + col;
            if (GameBoardControl.BoardGrid.Children[index] is Border border &&
                border.Child is TextBlock tb)
            {
                tb.Text = letter.ToUpper();
            }
        }

        private void UpdateTileState(int row, int col, LetterState state)
        {
            int index = row * 5 + col;
            if (GameBoardControl.BoardGrid.Children[index] is Border border)
            {
                switch (state)
                {
                    case LetterState.Correct:
                        border.Background = Brushes.Green;
                        break;
                    case LetterState.Present:
                        border.Background = Brushes.Goldenrod;
                        break;
                    case LetterState.Absent:
                        border.Background = Brushes.Gray;
                        break;
                }
            }
        }
       
    }
}
