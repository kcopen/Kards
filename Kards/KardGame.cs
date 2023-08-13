namespace Kards
{
    public enum GameState
    { 
        Unready = 0,    //game not started and not ready to be started
        Ready = 1,      //game not started but is ready to be started
        Playing = 2,    //the game is being played
        Finished = 3,   //the game has been finished
    }

    public abstract class KardGame
    {
        public GameState State = GameState.Unready;
        public KardPlayer[] Players;
        public readonly int MaxHandSize;

        public KardGame(KardPlayer[] players)
        {
            this.Players = players;
        }

    }
}
