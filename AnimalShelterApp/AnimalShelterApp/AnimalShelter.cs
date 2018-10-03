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
        public void RegisterCat(string rfid, string location, string description) {
            if (GetAnimal(rfid) == null)
            {
                Cat temp = new Cat(rfid, location, description);
                myAnimals.Add(temp);
            }
        }
        public void RegisterDog(string rfid, string location, string description) {
            if (GetAnimal(rfid) == null)
            {
                Dog temp = new Dog(rfid, location, description);
                myAnimals.Add(temp);
            }
        }
        public void UpdateAnimalDetails(string rfid, string description) {
            Animal temp = GetAnimal(rfid);
            if(temp != null)
            {
                temp.Description = description;
            }
        }
        public void RemoveAnimalDetails(string rfid) {
            Animal temp = GetAnimal(rfid);
            if(temp != null)
            {
                myAnimals.Remove(temp);
            }
        }
        public void RegisterOwner(string firstName, string lastName, string phoneNumber, string email) {
            //there is no way to check if owner already exists
            Owner temp = new Owner(firstName, lastName, phoneNumber, email);
            myOwners.Add(temp);
        }
        public void UpdateOwnerDetails(int ownerID, string firstName, string lastName, string phoneNumber, string email) {
            Owner temp = GetOwner(ownerID);
            if(temp != null)
            {
                temp.UpdateDetails(firstName, lastName, phoneNumber, email);
            }
        }
        public void RemoveOwnerDetails(int ownerID) {
            Owner temp = GetOwner(ownerID);
            if(temp != null)
            {
                myOwners.Remove(temp);
            }
        }
        public bool AdoptAnimal(int ownerID, string rfid) {
            Owner temp = GetOwner(ownerID);
            Animal temp2 = GetAnimal(rfid);
            if(temp != null && temp2 != null)
            {
                temp.AddPet(temp2);
                temp2.AnimalsOwner = temp;
                return true;
            }
            return false;
        }
        public double CalculateAdoptionFee(int ownerID, string rfid) { return 0; }
        public string GenerateOverview() { return ""; }
        public Owner GetOwner(int ownerID) {
            foreach(Owner owner in myOwners)
            {
                if(owner.ID == ownerID)
                {
                    return owner;
                }
            }
            return null;
        }
        public Animal GetAnimal(string rfid) {
            foreach (Animal animal in myAnimals)
            {
                if (animal.RfidNumber == rfid)
                {
                    return animal;
                }
            }
            return null;
        }
    }
}
