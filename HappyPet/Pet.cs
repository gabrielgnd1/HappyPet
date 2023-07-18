using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HappyPet
{
    public abstract class Pet
    {
        private int energy;
        private int happiness;
        private int health;
        private string name;
        private Image picture;
        private Player owner; //1 pet has 1 owner (aggregation)
        private List<Toy> listToys; //1 pet has n toys (composistion)

        protected Pet(string name, Image picture, Player owner)
        {
            this.Energy = 100;
            this.Happiness = 100;
            this.Health = 100;
            this.Name = name;
            this.Picture = picture;
            this.Owner = owner;
            this.ListToys = new List<Toy>();
        }

        public int Energy
        {
            get => energy;
            set
            {
                if (value >= 10 && value <= 100)
                {
                    energy = value;
                }
                else if (value < 10)
                {
                    energy = 10;
                }
                else
                {
                    energy = 100;
                }
            }
        }
        public int Happiness
        {
            get => happiness;
            set
            {
                if (value >= 10 && value <= 100)
                {
                    happiness = value;
                }
                else if (value < 10)
                {
                    happiness = 10;
                }
                else
                {
                    happiness = 100;
                }
            }
        }
        public int Health
        {
            get => health;
            set
            {
                if (value >= 10 && value <= 100)
                {
                    health = value;
                }
                else if (value < 10)
                {
                    health = 10;
                }
                else
                {
                    health = 100;
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
                    throw new Exception("Pet name can not be empty!");
                }
            }
        }
        public Image Picture { get => picture; set => picture = value; }
        public Player Owner { get => owner; set => owner = value; }
        public List<Toy> ListToys { get => listToys; set => listToys = value; }

        #region method

        public abstract string DisplayData();

        protected string DisplayPet()
        {
            string data = this.Name +
                          "\nHealth : " + this.Health + " % Energy : " +
                          this.Energy + " % Happiness : " + this.Happiness +
                          " %";
            return data;
        }

        #endregion
    }
}