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

        //properties
        public int ID { get; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }

        // Constructors
        public Owner(string firstName, string lastName, string phoneNumber, string email)
        {
            idCount++;
            ID = idCount;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        //methods
        public void UpdateAllDetails(string firstName, string lastName, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public override string ToString()
        {
            return $"{ID}: {FirstName} {LastName}, {PhoneNumber}, {Email}";
        }

    }
}
