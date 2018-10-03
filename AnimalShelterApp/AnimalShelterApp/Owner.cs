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
        private int id;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string email;

        private List<Animal> ownersAnimals;

        //properties
        public int ID { get { return this.id; } }

        //constructor
        public Owner(string firstName, string lastName, string phoneNumber, string email) { }

        //methods
        public void AddPet(Animal animal) { }
        public bool Owns(Animal animal) { return false; }

        public void UpdateDetails(string firstName, string lastName, string phoneNumber, string email) //new method for UpdateOwnerDetails
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

    }
}
