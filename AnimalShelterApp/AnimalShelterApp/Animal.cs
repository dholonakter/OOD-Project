using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterApp
{
    abstract class Animal
    {
        //fields
        private string rfidNumber;
        private DateTime dateBroughtIn;
        private string location;
        private string description;

        private Owner animalsOwner;

        //properties
        public string RfidNumber { get { return this.rfidNumber; } set { this.rfidNumber = value; } }
        public DateTime DateBroughtIn { get { return this.dateBroughtIn; } }
        public string Description { set { this.description = value; } } //Doesn't this also need a "get"?
        public Owner AnimalsOwner { get { return this.animalsOwner; } set { this.animalsOwner = value; } } //needed because of AdoptAnimal

        //constructor
        public Animal(string rfid, string location, string description) {
            this.rfidNumber = rfid;
            this.location = location;
            this.description = description;
            this.dateBroughtIn = DateTime.Now;
        }

        //methods
        public double GetFee(Owner adoptingOwner) {
            if(animalsOwner != adoptingOwner || animalsOwner == null)
            {
                if (this.IsAdoptable())
                {
                    if (this is Cat)
                    {
                        return 15;
                    }
                    if (this is Dog)
                    {
                        TimeSpan difference = DateTime.Now - dateBroughtIn;
                        return 10 + 2 * difference.Days;
                    }
                }
                return -1;
            }
            else
            {
                if (this is Cat)
                {
                    return 25;
                }
                if (this is Dog)
                {
                    return 20;
                }
            }
            return -1;
        }
        public bool IsAdoptable() //needed for AdoptAnimal & GetFee method
        {
            TimeSpan difference = DateTime.Now - dateBroughtIn;
            if(difference.Days >= 20)
            {
                return true;
            }
            return false;
        }


    }
}
