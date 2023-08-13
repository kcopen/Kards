

namespace Kards
{
    public enum KardRank
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    public enum KardSuit
    {
        Club = 1,
        Diamond = 2,
        Heart = 3,
        Spade = 4
    }

    public enum KardColor
    { 
        Black,
        Red
    }
    public class Kard
    {
        public KardSuit Suit { get; set; }
        public KardRank Rank { get; set; }

        public int KardID { get; }
       
        public Kard(int suit, int rank)
        {
            this.Suit = (KardSuit)suit;
            this.Rank = (KardRank)suit;
            this.KardID = ((int)suit - 1) * 13 + (int)rank;
        }
    

        public KardColor Color() 
        {
            if (Suit == KardSuit.Club || Suit == KardSuit.Spade) return KardColor.Black;
            else return KardColor.Red; 
        }

        override
        public String ToString() 
        {
            String suit, rank;
            switch (this.Suit)
            {
                case KardSuit.Club:
                    suit = "Club";
                    break;
                case KardSuit.Spade:
                    suit = "Spade";
                    break;
                case KardSuit.Heart:
                    suit = "Heart";
                    break;
                case KardSuit.Diamond:
                    suit = "Diamond";
                    break;
                default:
                    return "Invalid Card";
            }
            switch (this.Rank)
            {
                case KardRank.Ace:
                    rank = "Ace";
                    break;
                case KardRank.Two:
                    rank = "Two";
                    break;
                case KardRank.Three:
                    rank = "Three";
                    break;
                case KardRank.Four:
                    rank = "Four";
                    break;
                case KardRank.Five:
                    rank = "Five";
                    break;
                case KardRank.Six:
                    rank = "Six";
                    break;
                case KardRank.Seven:
                    rank = "Seven";
                    break;
                case KardRank.Eight:
                    rank = "Eight";
                    break;
                case KardRank.Nine:
                    rank = "Nine";
                    break;
                case KardRank.Ten:
                    rank = "Ten";
                    break;
                case KardRank.Jack:
                    rank = "Jack";
                    break;
                case KardRank.Queen:
                    rank = "Queen";
                    break;
                case KardRank.King:
                    rank = "King";
                    break;
                default:
                    return "Invalid Card";
            }

            return ("[" + this.KardID + "] " + rank + " of " + suit + "s."); 
        }

    }
}
