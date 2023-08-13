namespace Kards
{
    public class KardPlayer
    {
        public String Name { get; set; }
        public Kard[] Hand;
        public KardPlayer(string name, KardGame game)
        {
            Name = name;
            Hand = new Kard[game.MaxHandSize];
        }
    }
}
