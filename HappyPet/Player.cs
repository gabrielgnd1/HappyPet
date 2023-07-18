using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyPet
{
    public class Player
    {
        #region datamember
        private int coins;
        private string name;
        private DateTime lastPlay;
        #endregion

        #region constructor
        public Player(int coins, string name, DateTime lastPlay)
        {
            this.Coins = coins;
            this.Name = name;
            this.LastPlay = lastPlay;
        }
        #endregion

        #region properties
        public int Coins
        {
            get => coins;
            set
            {
                if (value >= 0)
                {
                    coins = value;
                }
                else
                {
                    coins = 0;
                }
            }
        }
        public string Name
        {
            get => name;
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Player name can not be empty");
                }
            }
        }
        public DateTime LastPlay { get => lastPlay; set => lastPlay = value; }

        #endregion


        #region method

        //semua child harus punya method DisplayData
        public string DisplayData()
        {
            string data = this.Name + "\n"
                        + this.Coins;

            return data;
        }

        #endregion
    }
}