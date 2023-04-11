using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BowlingGame.Tests
{
    [TestClass]
    public class BowlingGameTests
    {
        private IBowlingGame _bowlingGame;
        public BowlingGameTests()
        {
            _bowlingGame = new BowlingGame();
        }
        [TestMethod]
        public void Bowling_Score_Should_Be_GreaterThan_Zero()
        {
            _bowlingGame.Roll(4);
            _bowlingGame.Roll(5);
            var score = _bowlingGame.Score();
            Assert.IsTrue(score > 0);
        }
        [TestMethod]
        public void Bowling_Score_Should_Be_Spare()
        {
            _bowlingGame.Roll(4);
            _bowlingGame.Roll(6);
            _bowlingGame.Roll(5);
            _bowlingGame.Roll(0);
            var score = _bowlingGame.Score();
            Assert.IsTrue(score==20);
        }
        [TestMethod]
        public void Bowling_Score_Should_Be_Strike()
        {
            _bowlingGame.Roll(10);
            _bowlingGame.Roll(5);
            _bowlingGame.Roll(4);
            var score = _bowlingGame.Score();
            Assert.IsTrue(score == 28);
        }
    }
}
