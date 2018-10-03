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
        public string Description { set { this.description = value; } }
        public Owner AnimalsOwner { get { return this.animalsOwner; } set { this.animalsOwner = value; } } //needed because of AdoptAnimal

        //constructor
        public Animal(string rfid, string location, string description) { }

        //methods
        public double GetFee() { return 0; }

    }
}
