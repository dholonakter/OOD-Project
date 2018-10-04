using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterApp
{
    class Dog : Animal
    {
        //fields
        private DateTime lastDateWalked;

        //properties
        public DateTime LastDateWalked { get { return this.lastDateWalked; } }

        //constructor
        public Dog(string rfid, string location, string description) 
            : base(rfid, location, description)
        {

        }

        //methods
        public void Walk() {
            lastDateWalked = DateTime.Now;
        }
    }
}
