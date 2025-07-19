# Wordle---CSharp

# C# Wordle Game

A fully functional Wordle clone built with WPF (Windows Presentation Foundation) in C#. This desktop application recreates the popular word-guessing game with all core mechanics and features.

## Team
Salvador
Bhupinder
Samuel
Michael


## Overview

This Wordle implementation provides the authentic Wordle experience:

- **6 attempts** to guess a 5-letter word
- **Color-coded feedback** system (Green/Yellow/Gray)
- **Statistics tracking** (win rate, streaks, guess distribution)
- **Accept any 5-letter word** as input (no dictionary validation for guesses)
- **Random target words** selected from a curated word list

### Game Rules

- Guess any 5-letter word
- **Green tiles**: Correct letter in correct position
- **Yellow tiles**: Correct letter in wrong position
- **Gray tiles**: Letter not in the target word
- Win by guessing the word within 6 attempts

## 🚀 Setup Instructions

### Prerequisites

- **Visual Studio 2022** (Community, Professional, or Enterprise)
- **.NET 8.0** or later
- **Windows 10/11** (WPF requirement)

### Installation Steps

1. **Clone or Download** the project files to your local machine
1. **Open the Solution**
   
   ```
   Open Visual Studio → File → Open → Project/Solution
   Navigate to: Wordle/Wordle.sln
   ```
1. **Restore NuGet Packages**
- Right-click the solution in Solution Explorer
- Select “Restore NuGet Packages”
- Or use: `Tools → NuGet Package Manager → Package Manager Console`
   
   ```
   Update-Package -reinstall
   ```
1. **Build the Solution**
   
   ```
   Build → Build Solution (Ctrl+Shift+B)
   ```
1. **Run the Application**
   
   ```
   Debug → Start Debugging (F5)
   ```

## 🎯 Usage Guide

### Basic Gameplay

1. **Starting the Game**
- Launch the application
- A random 5-letter word is automatically selected as the target
- The game board shows 6 rows of 5 empty tiles
1. **Making Guesses**
- **Keyboard Input**: Type letters using your keyboard (A-Z)
- **Virtual Keyboard**: Click letters on the on-screen keyboard
- **Submit**: Press Enter or click “ENTER” button
- **Delete**: Press Backspace or click “DEL” button
1. **Understanding Feedback**
- **Green**: Right letter, right position ✅
- **Yellow**: Right letter, wrong position ⚠️
- **Gray**: Letter not in target word ❌
1. **Winning/Losing**
- **Win**: Guess the word within 6 attempts
- **Lose**: Use all 6 attempts without finding the word
- **New Game**: Press F5 or Esc after game ends

### Controls

|Input      |Action            |
|-----------|------------------|
|`A-Z`      |Enter letter      |
|`Enter`    |Submit guess      |
|`Backspace`|Delete last letter|
|`F5`       |New game          |
|`Esc`      |New game          |

### Features

- **Real-time Visual Feedback**: Tiles update as you type
- **Keyboard State Tracking**: Virtual keyboard shows used letters
- **Statistics Tracking**: Win rate, streaks, and guess distribution
- **Error Handling**: Validates input and provides helpful messages
- **Responsive UI**: Clean, modern interface following Wordle design

## Project Structure

```
Wordle/
├── Animations/           # Tile and board animations
├── Commands/            # MVVM command implementations
├── Controls/            # Custom UI controls
│   ├── GameBoard.xaml   # 6x5 grid of game tiles
│   ├── LetterTile.xaml  # Individual letter tile
│   └── VirtualKeyboard.xaml # On-screen keyboard
├── Converters/          # WPF value converters
├── Data/
│   └── WordList.txt     # Target words (50+ words)
├── Models/              # Data models and game state
├── Services/            # Game logic and data services
│   ├── GameEngine.cs    # Core game mechanics
│   ├── WordRepository.cs # Word management
│   ├── WordValidator.cs  # Letter state validation
│   └── StatisticsService.cs # Game statistics
├── Styles/              # WPF styling resources
├── Utils/               # Helper utilities and constants
├── ViewModels/          # MVVM view models
│   └── MainViewModel.cs # Primary game logic
├── Views/               # Additional windows
└── MainWindow.xaml      # Main application window
```

##  Key Components

### MainViewModel

- Manages game state and logic
- Handles guess processing and validation
- Implements INotifyPropertyChanged for UI binding
- Coordinates between services and UI

### GameBoard Control

- Displays 6x5 grid of tiles
- Updates tile colors based on guess results
- Shows current guess in real-time

### WordValidator Service

- Implements correct Wordle letter-checking algorithm
- Handles duplicate letters properly
- Returns Correct/Present/Absent states

### WordRepository

- Manages word list loading
- Provides random word selection
- Validates target words (5-letter requirement)

## Customization

### Adding New Words

Edit `Data/WordList.txt`:

```
apple
grape
stone
...
```

### Changing Colors

Modify `Styles/Colors.xaml`:

```xml
<Color x:Key="TileCorrectColor">#6aaa64</Color>    <!-- Green -->
<Color x:Key="TilePresentColor">#c9b458</Color>    <!-- Yellow -->
<Color x:Key="TileAbsentColor">#787c7e</Color>     <!-- Gray -->
```

### Game Settings

Adjust constants in `Utils/Constants.cs`:

```csharp
public const int WordLength = 5;     // Letters per word
public const int MaxAttempts = 6;    // Maximum guesses
```

## Troubleshooting

### Common Issues

**Application won’t start:**

- Ensure .NET 8.0 is installed
- Check that all NuGet packages are restored
- Verify WordList.txt is being copied to output directory

**Words not loading:**

- Check `Data/WordList.txt` exists and contains valid 5-letter words
- Ensure file is set to “Copy to Output Directory: Copy always”

**UI not updating:**

- Verify DataContext is set correctly in MainWindow
- Check PropertyChanged notifications in ViewModels


View → Output → Show output from: Debug
```

##  Game Statistics

The application tracks:

- **Total Games Played**
- **Win Percentage**
- **Current Win Streak**
- **Maximum Win Streak**
- **Guess Distribution** (how many attempts each win took)

Statistics are automatically saved between sessions.

## Technical Notes

- **Framework**: .NET 8.0 with WPF
- **Pattern**: MVVM (Model-View-ViewModel)
- **Dependencies**: Newtonsoft.Json for settings/statistics
- **Architecture**: Service-oriented with dependency injection
- **Data Persistence**: JSON files for statistics and settings

-----

*Enjoy playing Wordle!