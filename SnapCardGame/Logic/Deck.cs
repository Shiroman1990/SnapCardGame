using SnapCardGame.EnumItem;
using SnapCardGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapCardGame.Logic
{
    public class Deck
    {
        private Card[] _cards = new Card[52];
        private int _topCard;
        public int CardsRemaining { get { return 52 - _topCard; } }

        public Deck()
        {

        }

        public void LoadDeck()
        {
            int i = 0;
            foreach (object suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (object rank in Enum.GetValues(typeof(Rank)))
                {
                    _cards[i] = new Card((Rank)rank, (Suit)suit); 
                    i++;
                }
            }
            _topCard = 0;
        }
        public void Shuffle()
        {
            Card[] currentDeck = _cards;
            _cards = new Card[currentDeck.Length];
            List<int> freeIndices = new List<int>(currentDeck.Length);
            Random rand = new Random();

            for (int idx = 0; idx < currentDeck.Length; idx++)
                freeIndices.Add(idx);

            foreach (Card card in currentDeck)
            {
                int indexOfNewIdx = rand.Next(freeIndices.Count);
                int newIdxOfCard = freeIndices[indexOfNewIdx];

                _cards[newIdxOfCard] = card;
                freeIndices.Remove(newIdxOfCard);
            }
        }
        public Card TakeTopCard()
        {
            if (_topCard >= 52) return null;
            Card result = _cards[_topCard];
            _topCard++;
            return result;
        }
    }
}
