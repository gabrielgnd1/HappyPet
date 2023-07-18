using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyPet
{
    public class Toy
    {
        #region datamember
        private int benefit;
        private string name;
        private int price;
        #endregion


        #region constructor
        public Toy(int benefit, string name, int price)
        {
            this.Benefit = benefit;
            this.Name = name;
            this.Price = price;
        }
        #endregion

        #region properties
        public int Benefit
        {
            get => benefit;
            set
            {
                if (value > 0)
                {
                    benefit = value;
                }
                else
                {
                    benefit = 1;
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
                    name = "Toy 1";
                }
            }
        }
        public int Price
        {
            get => price;
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    price = 0;
                }
            }
        }

        #endregion

        #region method

        public string DisplayData()
        {
            string data = this.Name +
                           "\n" + this.Price + " coins" +
                           "\n+" + this.Benefit + " %";
            return data;
        }

        #endregion
    }
}