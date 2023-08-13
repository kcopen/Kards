using Microsoft.AspNetCore.Authentication.OAuth.Claims;

namespace Kards
{
    public class KardDeck
    {
        public Kard[] Deck = new Kard[52];

        private int CurrentDeckSize { get; set; }
        public KardDeck()
        {
            this.CurrentDeckSize = 52;
            //init cards in deck
            for(int i = 1; i <= 4; i++)
                for (int j = 1; j <= 13; j++)
                {
                    this.Deck[(i-1)*13 + (j - 1)] = new Kard(i, j);
                }
            
        }

        //returns a card from the deck but does not remove it
        //TIME:O(1)
        public Kard PeakKard(int index)
        {
            Kard kard;
            if (index >= this.CurrentDeckSize) kard = this.Deck[this.CurrentDeckSize - 1];
            else if (index < 0) kard = this.Deck[0];
            else kard = this.Deck[index];
            return kard;
        }

        //TIME:O(1)
        public Kard PeakTopKard() 
        {
            return this.Deck[this.CurrentDeckSize - 1];
        }

        //TIME:O(1)
        public Kard PeakBottomKard()
        {
            return this.Deck[0];
        }

        //remove and return a card from the deck 
        //TIME:O(n)
        public Kard DrawKard(int index) 
        {
            Kard kard = PeakKard(index);
            //make sure the stack of cards currently in the deck is at the start of the array
            for (int i = index + 1; i < this.CurrentDeckSize; i++)
            {
                SwapKardPositions(i, i - 1);
            }

            this.CurrentDeckSize -= 1;
            return kard;
        }

        //TIME:O(1)
        public Kard DrawTopKard() 
        {
            return DrawKard(this.CurrentDeckSize);
        }

        //TIME:O(n)
        public Kard DrawBottomKard()
        {
            return DrawKard(0);
        }

        //TIME:O(1)
        public void SwapKardPositions(int index1, int index2)
        {
            (this.Deck[index2], this.Deck[index1]) = (this.Deck[index1], this.Deck[index2]);
        }

        //TIME: O(n) SPACE: O(n)
        public void Shuffle()
        {
            Random rnd = new();
            
            int randIndex;
            for ( int i = 0; i < this.CurrentDeckSize; i++)
            {
                randIndex = rnd.Next(0, this.CurrentDeckSize);
                SwapKardPositions(i, randIndex);
            }
            
        }

        override
        public String ToString()
        {
            String deckstr = "{\n\t";
            for(int i = 0; i < this.CurrentDeckSize; i++)
            {
                deckstr += Deck[i].ToString();
                if(i < this.CurrentDeckSize - 1) deckstr += ",\n\t";
            }
            deckstr += "\n}";
            return deckstr;
        }

    }
}
