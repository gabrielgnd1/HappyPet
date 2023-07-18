using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HappyPet
{
    public class Fish : Pet
    {
        #region datamember
        private string environment;
        #endregion

        #region constructor
        public Fish(string name, Image picture, Player owner, string environment) : base(name, picture, owner)
        {
            this.Environment = environment;
        }
        #endregion

        #region properties
        public string Environment { get => environment; set => environment = value; }
        #endregion


        #region method

        public override string DisplayData()
        {
            string data = base.DisplayPet() + "\nEnvironment : " + this.Environment;
            return data;
        }

        #endregion
    }
}