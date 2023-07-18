using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPet
{
    public class Chameleon : Pet
    {
        #region datamember
        private Color currentColor;
        #endregion

        #region constructor
        public Chameleon(string name, Image picture, Player owner, Color currentColor) : base(name, picture, owner)
        {
            this.CurrentColor = currentColor;
        }
        #endregion

        #region properties

        public Color CurrentColor { get => currentColor; set => currentColor = value; }
        #endregion


        #region method

        public override string DisplayData()
        {
            string data = base.DisplayPet() + "\nColor : " + this.CurrentColor;
            return data;
        }

        #endregion
    }
}