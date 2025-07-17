namespace WordleGame.Services
{
    public static class InputHandler
    {
        public static bool IsLetter(char c)
        {
            return char.IsLetter(c);
        }

        public static bool IsEnterKey(string key)
        {
            return key == "Enter";
        }

        public static bool IsBackspaceKey(string key)
        {
            return key == "Backspace";
        }
    }
}
