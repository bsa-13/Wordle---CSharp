using System.IO;
using Newtonsoft.Json;
using WordleGame.Models;

namespace WordleGame.Services
{
    public class SaveGameService
    {
        private const string SaveFile = "savegame.json";

        public void Save(GameState state)
        {
            var json = JsonConvert.SerializeObject(state);
            File.WriteAllText(SaveFile, json);
        }

        public GameState Load()
        {
            if (!File.Exists(SaveFile)) return new GameState();
            var json = File.ReadAllText(SaveFile);
            return JsonConvert.DeserializeObject<GameState>(json);
        }
    }
}
