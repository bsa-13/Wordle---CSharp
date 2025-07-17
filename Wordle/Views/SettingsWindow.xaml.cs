using System.Windows;
using System.Windows.Controls;
using WordleGame.Models;
using WordleGame.Services;

namespace WordleGame.Views
{
    public partial class SettingsWindow : Window
    {
        private readonly SettingsService service = new SettingsService();

        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void OnSaveClicked(object sender, RoutedEventArgs e)
        {
            var settings = new UserSettings
            {
                SoundEnabled = SoundCheckbox.IsChecked == true,
                Theme = ((ComboBoxItem)ThemeSelector.SelectedItem)?.Content.ToString() ?? "Light"
            };

            service.SaveSettings(settings);
            Close();
        }
    }
}



