using SnapCardGame.EnumItem;
using SnapCardGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapCardGame.Logic
{
    public class Snap
    {
        private readonly Card[] _topCards = new Card[2];
        private readonly int[] _score = new int[2];
        private readonly Deck _deck;

        public Snap()
        {
            _deck = new Deck();
            IsStarted = false;
        }

        public Card TopCard
        {
            get { return _topCards[1]; }
        }
        public int CardsRemain
        {
            get { return _deck.CardsRemaining; }
        }
        public bool IsStarted { get; private set; } 
        public void StartGame()
        {
            if (!IsStarted)
            {
                IsStarted = true;
                _deck.LoadDeck();
                _deck.Shuffle();
            }
        }
        public void FlipNextCard()
        {
            if (!IsStarted || _deck.CardsRemaining <= 0) return;
            _topCards[0] = _topCards[1];
            _topCards[1] = _deck.TakeTopCard();
            _topCards[1].TurnOver();
        }
        public string TopTwoCardName()
        {
            return string.Format("TopCard: {0} | SecondTopCard: {1}",
                _topCards[1] == null ? "NA" : _topCards[1].ToString(),
                _topCards[0] == null ? "NA" : _topCards[0].ToString());
        }
        public int Score(int playerIndex)
        {
            return playerIndex >= 0 && playerIndex < _score.Length ? _score[playerIndex] : 0;
        }
        public void PlayerHitSnap(int player, string matchcase)
        {
            if (!IsStarted || player < 0) return;
            if (_topCards[0] == null || _topCards[1] == null) return;

            if (matchcase == SnapMatchCase.Rank.ToString())
            {
                ExecuteHitSnap(player, () => { return _topCards[0].Rank == _topCards[1].Rank; });
            }
            else if (matchcase == SnapMatchCase.Suite.ToString())
            {
                ExecuteHitSnap(player, () => { return _topCards[0].Suit == _topCards[1].Suit; });
            }
            else if(matchcase == SnapMatchCase.RankOrSuite.ToString())
            {
                ExecuteHitSnap(player, () => { return _topCards[0].Suit == _topCards[1].Suit || _topCards[0].Rank == _topCards[1].Rank; });
            }
        }
        private void ExecuteHitSnap(int player, System.Func<bool> matchCondition) // Match Rank
        {
            if (matchCondition.Invoke())
                _score[player]++;
            else
                _score[player]--;
        }
    }
}
