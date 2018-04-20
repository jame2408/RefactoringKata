namespace TennisGameKata
{
    using System;
    using System.Collections.Generic;

    internal class TennisGame
    {
        private string _firstPlayerName;

        private string _secondPlayerName;

        public TennisGame(string firstPlayerName, string secondPlayerName)
        {
            this._firstPlayerName = firstPlayerName;
            this._secondPlayerName = secondPlayerName;
        }

        private Dictionary<int, string> scoreLookup = new Dictionary<int, string>()
                                                          {
                                                              { 0, "Love" },
                                                              { 1, "Fifteen" },
                                                              { 2, "Thirty" },
                                                              { 3, "Forty" },
                                                          };

        private int _firstPlayerScoreTimes;

        private int _secondPlayerScoreTimes;

        /// <summary>
        /// The score.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string Score()
        {
            if (this._firstPlayerScoreTimes > 3 || this._secondPlayerScoreTimes > 3)
            {
                if (this._firstPlayerScoreTimes - this._secondPlayerScoreTimes >= 2)
                {
                    return this._firstPlayerName + " Win";
                }

                if (this._firstPlayerScoreTimes - this._secondPlayerScoreTimes <= -2)
                {
                    return this._secondPlayerName + " Win";
                }
            }

            if (this._firstPlayerScoreTimes >= 3 && this._secondPlayerScoreTimes >= 3)
            {
                if (this._firstPlayerScoreTimes == this._secondPlayerScoreTimes)
                {
                    return "Deuce";
                }

                if (this._firstPlayerScoreTimes == this._secondPlayerScoreTimes + 1)
                {
                    return this._firstPlayerName + " Adv";
                }

                if (this._firstPlayerScoreTimes + 1 == this._secondPlayerScoreTimes)
                {
                    return this._secondPlayerName + " Adv";
                }
            }

            if (this._firstPlayerScoreTimes == this._secondPlayerScoreTimes)
            {
                return this.scoreLookup[this._firstPlayerScoreTimes] + " All";
            }

            return this.scoreLookup[this._firstPlayerScoreTimes] + " " + this.scoreLookup[this._secondPlayerScoreTimes];
        }

        /// <summary>
        /// The first player score.
        /// </summary>
        public void FirstPlayerScore()
        {
            this._firstPlayerScoreTimes++;
        }

        /// <summary>
        /// The second player score.
        /// </summary>
        public void SecondPlayerScore()
        {
            this._secondPlayerScoreTimes++;
        }
    }
}