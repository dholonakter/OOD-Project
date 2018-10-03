using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterApp
{
    class Cat : Animal
    {
        //fields
        private List<string> characteristic;

        //properties
        public List<string> Characteristic { get { return this.characteristic; } }

        //constructor
        public Cat(string rfid, string location, string description) 
            : base(rfid, location, description)
        {

        }

        //methods
        public void AddCharacteristic(string characteristic) { }

    }
}
