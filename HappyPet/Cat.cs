using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPet
{
    public class Cat : Pet
    {
        #region datamember
        private bool vaccinationStatus;
        #endregion

        #region constructor
        public Cat(string name, Image picture, Player owner) : base(name, picture, owner)
        {
            this.VaccinationStatus = false;
        }
        #endregion

        #region properties
        public bool VaccinationStatus { get => vaccinationStatus; set => vaccinationStatus = value; }
        #endregion


        #region method


        public override string DisplayData()
        {

            string status = "No";
            if (this.VaccinationStatus == true)
            {
                status = "Yes";
            }
            string data = base.DisplayPet() +
                          "\nVaccination Status : " + status;

            return data;
        }

        #endregion
    }
}