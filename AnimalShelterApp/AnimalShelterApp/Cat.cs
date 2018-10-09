using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterApp
{
    class Cat : Animal
    {
        //properties
        public List<string> Characteristic { get; private set; }

        //constructor
        public Cat(string rfid, string location, string description) 
            : base(rfid, location, description)
        {
            Characteristic = new List<string>();
        }

        //methods
        public void AddCharacteristic(string characteristic)
        {
            Characteristic.Add(characteristic);
        }

        public override double GetFee(Owner adoptingOwner)
        {
            if (AnimalsOwner != adoptingOwner)
            {
                return 20.0;
            }
            return 15.0;
        }
        public override string ToString()
        {
            string info = "";
            return info = "Cat :" + base.ToString();
        }
    }
}
