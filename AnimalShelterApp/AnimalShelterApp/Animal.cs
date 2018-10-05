using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterApp
{
    abstract class Animal
    {
        // Properties
        public string RfidNumber { get; } // Removed the setter as it's set only once upon registration (thus construction which is allowed).
        public string Location { get; }
        public DateTime DateBroughtIn { get; }

        public string Description { get; private set; } // Depending on if it will ever change

        public Owner AnimalsOwner { get; }

        public TimeSpan Difference
        {
            get
            {
                return DateTime.Now - DateBroughtIn;
            }
        } // Added difference as read only private property such that it can be reused where needed.

        //constructor
        public Animal(string rfid, string location, string description)
        {
            RfidNumber = rfid;
            Location = location;
            Description = description;
            DateBroughtIn = DateTime.Now;
        }

        //methods
        // Made abstract as will be overridden by the concrete classes themselves
        // to make proper use of polymorphism.
        public abstract double GetFee(Owner adoptingOwner);

        public bool IsAdoptable() //needed for AdoptAnimal & GetFee method
        {
            // Can instantly return the value of the test.
            // Could also have been a read only property as it's derived 
            // From other properties.
            return Difference.Days > 20; // Changed to > 20 (Case states more than 20 days)
        }
    }
}
