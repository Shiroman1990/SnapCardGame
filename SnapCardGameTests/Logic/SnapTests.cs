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
    public class SnapTests
    {

        [TestMethod()]
        public void StartGameTest()
        {
            Snap snp = new Snap();
            snp.StartGame();
            Assert.IsTrue(snp.IsStarted);
        }

        [TestMethod()]
        public void FlipNextCardTest()
        {
            Snap snp = new Snap();
            snp.StartGame();
            var remaningCardBeforeFlip = snp.CardsRemain;
            snp.FlipNextCard();
            var remaningCardAfterFlip = snp.CardsRemain;
            Assert.IsTrue(remaningCardAfterFlip < remaningCardBeforeFlip);
        }

        [TestMethod()]
        public void TopTwoCardNameTest()
        {
            Snap snp = new Snap();
            snp.StartGame();
            Assert.IsNotNull(snp.TopTwoCardName());
        }

        [TestMethod()]
        public void ScoreTest()
        {
            Snap snp = new Snap();
            snp.StartGame();
            int currentScore = snp.Score(0);
            Assert.IsTrue(currentScore == 0);
        }

        [TestMethod()]
        public void PlayerHitSnapTest()
        {
            Snap snp = new Snap();
            snp.StartGame();
            var previousScore = snp.Score(0);
            snp.FlipNextCard();
            snp.FlipNextCard();
            snp.PlayerHitSnap(0, "Rank");
            var currentScore = snp.Score(0);
            Assert.AreNotEqual(previousScore, currentScore);
        }
    }
}