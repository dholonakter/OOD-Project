using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterApp
{

    class AnimalShelter
    {
        //fields
        private string email;
        private string phoneNumber;
        private string address;
        private string name;

        private List<Owner> myOwners;
        private List<Animal> myAnimals;

        //properties

        //constructor
        public AnimalShelter() { }

        //methods
        public void RegisterCat(string rfid, string location, string description) { }
        public void RegisterDog(string rfid, string location, string description) { }
        public void UpdateAnimalDetails(string rfid, string description) { }
        public void RemoveAnimalDetails(string rfid) { }
        public void RegisterOwner(string firstName, string lastName, string phoneNumber, string email) { }
        public void UpdateOwnerDetails(int ownerID, string firstName, string lastName, string phoneNumber, string email) { }
        public void RemoveOwnerDetails(int ownerID) { }
        public bool AdoptAnimal(int ownerID, string rfid) { return false; }
        public double CalculateAdoptionFee(int ownerID, string rfid) { return 0; }
        public string GenerateOverview() { return ""; }
        public Owner GetOwner(int ownerID) { return null; }
        public Animal GetAnimal(string rfid) { return null; }
    }
}
