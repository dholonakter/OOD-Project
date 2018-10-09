using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterApp
{
    class Dog : Animal
    {
        //properties
        public DateTime LastDateWalked { get; private set; }

        //constructor
        public Dog(string rfid, string location, string description) 
            : base(rfid, location, description)
        {

        }

        //methods
        public void Walk()
        {
            LastDateWalked = DateTime.Now;
        }

        public override double GetFee(Owner adoptingOwner)
        {
            // Different owners or no owner.
            if (AnimalsOwner != adoptingOwner)
            {
                return 20.0;
            }
            return 10.0 + 2 * Difference.Days;
        }
    }
}
