using System.ComponentModel;

namespace WordleGame.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string currentGuess;
        public string CurrentGuess
        {
            get => currentGuess;
            set
            {
                currentGuess = value;
                OnPropertyChanged(nameof(CurrentGuess));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
