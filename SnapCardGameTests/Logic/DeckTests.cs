using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnapCardGame.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapCardGame.Logic.Tests
{
    [TestClass()]
    public class DeckTests
    {

        [TestMethod()]
        public void LoadDeckTest()
        {
            Deck dk = new Deck();
            dk.LoadDeck();
            Assert.AreEqual(52, dk.CardsRemaining);
        }

        [TestMethod()]
        public void ShuffleTest()
        {
            Deck dk = new Deck();
            dk.LoadDeck();
            dk.Shuffle();
            var firstTopCard = dk.TakeTopCard();
            var secondTopCard = dk.TakeTopCard();
            Assert.AreNotEqual(firstTopCard.Rank, secondTopCard.Rank);
        }

        [TestMethod()]
        public void TakeTopCardTest()
        {
            Deck dk = new Deck();
            dk.LoadDeck();
            var firstTopCard = dk.TakeTopCard();
            Assert.IsNotNull(firstTopCard);
        }
    }
}