namespace WordleGame.Services
{
    public class GameFlowController
    {
        private readonly GameEngine engine;

        public GameFlowController(GameEngine gameEngine)
        {
            engine = gameEngine;
        }

        public bool ProcessGuess(string guess)
        {
            return engine.IsCorrect(guess);
        }
    }
}
