using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterApp
{
    class Owner
    {
        //fields
        private static int idCount = 0; //needed for constructor

        private List<Animal> ownersAnimals;

        //properties
        public int ID { get; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }

        //constructor
        public Owner(string firstName, string lastName, string phoneNumber, string email)
        {
            idCount++;
            ID = idCount;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;

            ownersAnimals = new List<Animal>();
        }

        //methods
        public void AddPet(Animal animal)
        {
            ownersAnimals.Add(animal);
        }

        public bool Owns(Animal animal)
        {
            Animal resultAnimal = GetPet(animal.RfidNumber);
            if (resultAnimal != null)
            {
                return true;
            }
            return false;
        }

        public Animal GetPet(string rfidNumber)
        {
            foreach (Animal ownerAnimal in ownersAnimals)
            {
                if (ownerAnimal.RfidNumber == rfidNumber)
                {
                    return ownerAnimal;
                }
            }
            return null;
        }

        public List<Animal> GetPets()
        {
            return new List<Animal>(ownersAnimals);
        }

        public void UpdatePhoneNumber(string phoneNumber)
        {
            UpdateAllDetails(FirstName, LastName, phoneNumber, Email);
        }

        public void UpdateEmail(string email)
        {
            UpdateAllDetails(FirstName, LastName, PhoneNumber, email);
        }

        public void UpdateFirstName(string firstName)
        {
            UpdateAllDetails(firstName, LastName, PhoneNumber, Email);
        }

        public void UpdateLastName(string lastName)
        {
            UpdateAllDetails(FirstName, lastName, PhoneNumber, Email);
        }

        private void UpdateAllDetails(string firstName, string lastName, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

    }
}
