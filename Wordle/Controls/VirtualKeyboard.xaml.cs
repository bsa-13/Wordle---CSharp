using System.Windows.Controls;
using System.Windows;

namespace WordleGame.Controls
{
    public partial class VirtualKeyboard : UserControl
    {
        public VirtualKeyboard()
        {
            InitializeComponent();
            CreateKeyboard();
        }

        private void CreateKeyboard()
        {
            string keys = "QWERTYUIOPASDFGHJKLZXCVBNM";
            foreach (char key in keys)
            {
                Button button = new Button
                {
                    Content = key.ToString(),
                    Width = 35,
                    Height = 35,
                    Margin = new Thickness(2)
                };
                KeyboardPanel.Children.Add(button);
            }
        }
    }
}


