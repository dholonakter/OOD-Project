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

        private int id;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string email;

        private List<Animal> ownersAnimals;

        //properties
        public int ID { get { return this.id; } }

        //constructor
        public Owner(string firstName, string lastName, string phoneNumber, string email) {
            idCount++;
            this.id = idCount;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;            
        }

        //methods
        public void AddPet(Animal animal) {
            if(animal != null)
            {
                ownersAnimals.Add(animal);
            }           
        }
        public bool Owns(Animal animal) {
            if(animal != null)
            {
                foreach(Animal ownerAnimal in ownersAnimals)
                {
                    if(ownerAnimal == animal)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void UpdateDetails(string firstName, string lastName, string phoneNumber, string email) //new method for UpdateOwnerDetails
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

    }
}
