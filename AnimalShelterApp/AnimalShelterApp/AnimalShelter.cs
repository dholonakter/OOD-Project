using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public AnimalShelter(string name, string address, string phoneNumber, string email)
        {
            myOwners = new List<Owner>();
            myAnimals = new List<Animal>();

            this.email = email;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.name = name;
        }

        //methods
        public void RegisterCat(string rfid, string location, string description,int? ownerId)
        {
            if (GetAnimal(rfid) == null)
            {
                
                if (ownerId.HasValue)
                {
                    Owner owner = GetOwner(ownerId.Value);
                    if(owner!=null)
                    {
                        Animal animal = new Cat(rfid, location, description);
                        animal.AnimalsOwner = owner;
                        animal.AnimalsOwner.Animals.Add(animal);
                        animal.IsClaimAble = false;
                        myAnimals.Add(animal);
                    }
          
                }
                else
                {
                    Animal animal = new Cat(rfid, location, description);
                    animal.IsClaimAble = true;
                    myAnimals.Add(animal);
                }
            }
            else
            {
                if (MessageBox.Show("This rfid has already been used. If you want to re-register (description and previous owner won't be lost) this animal press yes", "ANIMAL EXISTS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Animal animal = GetAnimal(rfid);
                    animal.reRegister(location);
                }
            }
        }

        public void RegisterDog(string rfid, string location, string description, int? ownerId) {
            if (GetAnimal(rfid) == null)
            {
                if (ownerId.HasValue)
                {
                    Owner owner = GetOwner(ownerId.Value);
                    if (owner != null)
                    {
                        Animal animal = new Dog(rfid, location, description);
                        animal.AnimalsOwner = owner;
                        animal.AnimalsOwner.Animals.Add(animal);
                        animal.IsClaimAble = false;
                        myAnimals.Add(animal);
                    }

                }
                else
                {
                    Animal animal =new Dog(rfid, location, description);
                    animal.IsClaimAble = true;
                    myAnimals.Add(animal);
                }
            }
            else
            {
                if(MessageBox.Show("This rfid has already been used. If you want to re-register (description and previous owner won't be lost) this animal press yes", "ANIMAL EXISTS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Animal animal = GetAnimal(rfid);
                    animal.reRegister(location);
                }
            }
        }

        public void UpdateAnimalDetails(string oldRFID,string newRFID, string location, string description,string newOwnerId)
        {
            Animal animal = GetAnimal(oldRFID);

            if (animal != null)
            {
                animal.RfidNumber = newRFID;
                animal.Location = location;
                animal.Description = description;
                if(animal.AnimalsOwner==null)
                {
                    if(!string.IsNullOrEmpty(newOwnerId))
                    {
                        Owner newOwner = GetOwner(Convert.ToInt32(newOwnerId));
                        if(newOwner!=null)
                        {
                            animal.AnimalsOwner =newOwner;
                            animal.IsClaimAble = false;
                            animal.AnimalsOwner.Animals.Add(animal);
                        }
                        
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(newOwnerId))
                    {
                        if(animal.AnimalsOwner.ID!=Convert.ToInt32(newOwnerId))
                        {
                            Owner newOwner = GetOwner(Convert.ToInt32(newOwnerId));
                            if (newOwner != null)
                            {
                                animal.AnimalsOwner = newOwner;
                                animal.IsClaimAble = false;
                                animal.AnimalsOwner.Animals.Add(animal);
                            }
                        }
                    }
                    else
                    {
                        animal.AnimalsOwner.Animals.Remove(animal);
                        animal.IsClaimAble = true;
                        animal.AnimalsOwner = null;
                    }
                }
            }
        }

        public void RemoveAnimalDetails(string rfid)
        {//should the animal be removed from owner's ownersAnimals list?
            Animal animal = GetAnimal(rfid);
            if (animal != null)
            {
                if (animal.AnimalsOwner == null)
                {
                    myAnimals.Remove(animal);
                }
                else if (animal.AnimalsOwner != null)
                {
                    animal.AnimalsOwner.Animals.Remove(animal);
                    myAnimals.Remove(animal);
                }
            }
        }

        public void RegisterOwner(string firstName, string lastName, string phoneNumber, string email)
        {
            //there is no way to check if owner already exists
            // There is if you check on email or phonenumber, those are unique.
            // Unless it's couples that perhaps use shared e-mail address for certain business.
            Owner temp = new Owner(firstName, lastName, phoneNumber, email);
            myOwners.Add(temp);
        }

        public void UpdateOwnerDetails(int ownerID, string firstName, string lastName, string phoneNumber, string email)
        {
            Owner temp = GetOwner(ownerID);
            if (temp != null)
            {

                temp.UpdateAllDetails(firstName, lastName, phoneNumber, email);
            }
        }

        public void RemoveOwnerDetails(int ownerID)
        { //should the owner's animal's animalsOwner be set to null?
            Owner temp = GetOwner(ownerID);
            if (temp != null)
            {

                myOwners.Remove(temp);
            }
        }

        public bool AdoptAnimal(int ownerID, string rfid)
        {
            Owner owner = GetOwner(ownerID);
            Animal animal = GetAnimal(rfid);
                if (owner != null && animal != null)
                {
                    animal.AnimalsOwner = owner;
                    animal.IsClaimAble = false;
                    owner.Animals.Add(animal);
                    return true;
                }
            return false;
        }

        public double CalculateAdoptionFee(int ownerID, string rfid)
        {
            Owner owner = GetOwner(ownerID);
            Animal animal = GetAnimal(rfid);
            return animal.GetFee(owner);
        }

        public string GenerateOverview() { return ""; } //This still needs to be implemented!

        public Owner GetOwner(int ownerID)
        {
            foreach (Owner owner in myOwners)
            {
                if (owner.ID == ownerID)
                {
                    return owner;
                }
            }
            return null;
        }

        public Animal GetAnimal(string rfid)
        {
            foreach (Animal animal in myAnimals)
            {
                if (animal.RfidNumber == rfid)
                {
                    return animal;
                }
            }
            return null;
        }

        public List<Owner> SearchOwnerByLastName(string lastName)
        {
            List<Owner> temp = new List<Owner>();

            foreach (Owner currentOwner in myOwners)
            {
                if (currentOwner.LastName.ToLower().Contains(lastName.ToLower()))
                {
                    temp.Add(currentOwner);
                }
            }
            return temp;
        }

        public Owner SearchOwnerByEmail(string email)
        {
            foreach (Owner currentOwner in myOwners)
            {
                if (currentOwner.Email == email)
                {
                    return currentOwner;
                }
            }
            return null;
        }

        public Owner SearchOwnerByPhone(string phoneNumber)
        {
            foreach (Owner currentOwner in myOwners)
            {
                if (currentOwner.PhoneNumber == phoneNumber)
                {
                    return currentOwner;
                }
            }
            return null;
        }

        public Animal SearchAnimalByRfidNumber(string rfidNumber)
        {
            foreach (Animal currentAnimal in myAnimals)
            {
                if (currentAnimal.RfidNumber == rfidNumber)
                {
                    return currentAnimal;
                }
            }
            return null;
        }

        public List<Animal> GetAllAnimals()
        {
            return this.myAnimals;
        }
        public List<Owner> GetAllOwners()
        {
            return this.myOwners;
        }
    }
}
