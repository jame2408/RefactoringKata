using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGameKata
{
    [TestClass]
    public class UnitTest1
    {
        private readonly TennisGame tennisGame;

        public UnitTest1()
        {
            this.tennisGame = new TennisGame("Joey", "James");
        }

        [TestMethod]
        public void Game_Start_Should_Be_Love_All()
        {
            Assert.AreEqual("Love All", this.tennisGame.Score());
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            this.GivenFirstPlayerScoreTimes(1);
            this.ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            this.GivenFirstPlayerScoreTimes(2);
            this.ScoreShouldBe("Thirty Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            this.GivenFirstPlayerScoreTimes(3);
            this.ScoreShouldBe("Forty Love");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            this.GivenSecondPlayerScoreTimes(1);
            this.ScoreShouldBe("Love Fifteen");
        }

        [TestMethod]
        public void Love_Thirty()
        {
            this.GivenSecondPlayerScoreTimes(2);
            this.ScoreShouldBe("Love Thirty");
        }

        [TestMethod]
        public void Love_Forty()
        {
            this.GivenSecondPlayerScoreTimes(3);
            this.ScoreShouldBe("Love Forty");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            this.GivenFirstPlayerScoreTimes(1);
            this.GivenSecondPlayerScoreTimes(1);
            this.ScoreShouldBe("Fifteen All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            this.GivenFirstPlayerScoreTimes(2);
            this.GivenSecondPlayerScoreTimes(2);
            this.ScoreShouldBe("Thirty All");
        }

        [TestMethod]
        public void Deuce_When_3_3()
        {
            this.GivenFirstPlayerScoreTimes(3);
            this.GivenSecondPlayerScoreTimes(3);
            this.ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void Deuce_When_4_4()
        {
            this.GivenFirstPlayerScoreTimes(4);
            this.GivenSecondPlayerScoreTimes(4);
            this.ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void Deuce_When_4_3()
        {
            this.GivenFirstPlayerScoreTimes(4);
            this.GivenSecondPlayerScoreTimes(3);
            this.ScoreShouldBe("Joey Adv");
        }

        [TestMethod]
        public void Deuce_When_3_4()
        {
            this.GivenFirstPlayerScoreTimes(3);
            this.GivenSecondPlayerScoreTimes(4);
            this.ScoreShouldBe("James Adv");
        }

        [TestMethod]
        public void Win_When_4_0()
        {
            this.GivenFirstPlayerScoreTimes(4);
            this.GivenSecondPlayerScoreTimes(0);
            this.ScoreShouldBe("Joey Win");
        }

        [TestMethod]
        public void Win_When_0_4()
        {
            this.GivenFirstPlayerScoreTimes(0);
            this.GivenSecondPlayerScoreTimes(4);
            this.ScoreShouldBe("James Win");
        }

        [TestMethod]
        public void Win_When_7_5()
        {
            this.GivenFirstPlayerScoreTimes(7);
            this.GivenSecondPlayerScoreTimes(5);
            this.ScoreShouldBe("Joey Win");
        }

        private void GivenFirstPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                this.tennisGame.FirstPlayerScore();
            }
        }

        private void GivenSecondPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                this.tennisGame.SecondPlayerScore();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, this.tennisGame.Score());
        }
    }
}
