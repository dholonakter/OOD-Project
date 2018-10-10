using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterApp
{
    abstract class Animal
    {
        private static int idCountOfAnimal = 0;
        private DateTime dateBroughtIn;
        private string location;
        // Properties
        public string RfidNumber { get; set; } // Removed the setter as it's set only once upon registration (thus construction which is allowed).
        public string Location { get; set; }
        public DateTime DateBroughtIn { get { return this.dateBroughtIn; } }

        public string Description { get; set; } // Depending on if it will ever change

        public Owner AnimalsOwner { get; set; }

        public bool IsClaimAble { get; set; }
        public int ID { get; }

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
            idCountOfAnimal++;
            ID = idCountOfAnimal;
            RfidNumber = rfid;
            Location = location;
            Description = description;
            dateBroughtIn = DateTime.Now;
            IsClaimAble = true;
        }
        /*
          public Animal(Owner owner)
           {
             
            owner=ge
           

            // Create another constructor with owner object.

            // Obtain the owner object from your form logic based on the input id.
            // then pass it into the constructor
            // update your list
          }
          */
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
        public void reRegister(string Location)
        {
            IsClaimAble = true;
            dateBroughtIn = DateTime.Now;
            location = Location;
        }
        public override string ToString()
        {
            string info = "";

            if (AnimalsOwner != null)
            {
                info = "(ID)-" + ID + " (RFID)  - " + RfidNumber + "  (ownerid) - " + AnimalsOwner.ID + " (Location)-" + location + " (Description) -" + Description;
            }
            else
            {
                info = "(ID) -" + ID + "  (RFID)  - " + RfidNumber + "  (ownerid) - No Owner "+ "()Location" + location + " (Description) -" + Description;
            }

            return info;


        }

    }
}
