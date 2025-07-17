using System.IO;
using Newtonsoft.Json;
using WordleGame.Models;

namespace WordleGame.Services
{
    public class SettingsService
    {
        private const string SettingsFile = "user_settings.json";

        public void SaveSettings(UserSettings settings)
        {
            var json = JsonConvert.SerializeObject(settings);
            File.WriteAllText(SettingsFile, json);
        }

        public UserSettings LoadSettings()
        {
            if (!File.Exists(SettingsFile))
                return new UserSettings();

            var json = File.ReadAllText(SettingsFile);
            return JsonConvert.DeserializeObject<UserSettings>(json);
        }
    }
