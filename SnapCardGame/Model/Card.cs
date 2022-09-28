using SnapCardGame.EnumItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapCardGame.Model
{
    public class Card
    {
        public Card(Rank rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
            FaceUp = false;
        }
        public Rank Rank { get; private set; }
        public Suit Suit { get; private set; }
        public bool FaceUp { get; private set; }
        public void TurnOver()
        {
            FaceUp = !FaceUp;
        }
        public override string ToString()
        {
            string rankText = (int)Rank < 10 ? ((int)Rank).ToString() : Rank.ToString();
            string suitText = Suit.ToString();
            return string.Format("Rank = {0} & Suite = {1}", rankText, suitText);
        }
    }


}
