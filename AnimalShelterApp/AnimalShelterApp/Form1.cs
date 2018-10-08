using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelterApp
{
    public partial class animalshelterAPP : Form
    {
        AnimalShelter animalShelter = null;
        public animalshelterAPP()
        {
            InitializeComponent();
            animalShelter = new AnimalShelter("EindhovenAnimalShelter", "Eindhoven", "068734567", "animalshelter@gmail.com");
            Text = animalShelter.Name;
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            string rfid = tbanimalRfid.Text;
            string location = tblocation.Text;
            string description = tbdescription.Text;
            if (animalShelter != null)
            {
                if (rbCat.Checked)
                {
                   Cat cat = new Cat(rfid, location, description);
                   animalShelter.RegisterCat(rfid, location, description);
                    MessageBox.Show("successfully added the cat");
                   ListOfAnimals.Items.Add(cat);
                }
                else
                {
                    Dog dog = new Dog(rfid, location, description);
                    animalShelter.RegisterDog(rfid, location, description);
                    MessageBox.Show("successfully added the dog");
                    ListOfAnimals.Items.Add(dog);
                }

            }
  

        }

        private void locationUpdate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
