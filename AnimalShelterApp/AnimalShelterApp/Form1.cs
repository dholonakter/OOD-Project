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
    public partial class Form1 : Form
    {
        private AnimalShelter myShelter;
        public Form1()
        {
            InitializeComponent();
            myShelter = new AnimalShelter("Fontys", "Rachelsmolen", "06123456", "Fontys@animalShelter.nl");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rfid = tbRFIDforRegistration.Text;
            string location = tbLocation.Text;
            string description = tbDescription.Text;
            Animal a;
            if(this.rbCat.Checked)
            {
                a = new Cat(rfid, location, description);
                myShelter.RegisterCat(rfid, location, description);
            }
            else
            {
                a = new Dog(rfid, location, description);
                myShelter.RegisterDog(rfid, location, description);
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string phoneNumber = tbPhoneNumber.Text;
            string email = tbEmail.Text;

            myShelter.RegisterOwner(firstName, lastName, phoneNumber, email);
        }

        private void btShowAnimals_Click(object sender, EventArgs e)
        {
            this.lbAnimals.Items.Clear();
            foreach (Animal a in this.myShelter.GetAllAnimals())
            {
                this.lbAnimals.Items.Add(a);
            }
        }

        //to finish ~ get animal by RFID number
        private void btSearchAnimal_Click(object sender, EventArgs e)
        {
            this.lbAnimals.Items.Clear();
            foreach (Animal a in this.myShelter.GetAllAnimals())
            {
               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Animal a = (Animal)lbAnimals.SelectedItem;
            if (a != null)
            {
                myShelter.UpdateAnimalDetails(tbNewRFID.Text, tbNewDescription.Text);
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            Animal a = (Animal)lbAnimals.SelectedItem;
            if (a != null)
            {
                myShelter.RemoveAnimalDetails(tbNewRFID.Text);
            }
        }

        private void btSearchOwner_Click(object sender, EventArgs e)
        {
            List<Owner> owners;
            string expression = textBox15.Text;

            if (expression != "")
            {
                owners = myShelter.SearchOwnerByLastName(expression);
                owners.Add(myShelter.SearchOwnerByEmail(expression));
                owners.Add(myShelter.SearchOwnerByPhone(expression));

                updateOwnerListbox(owners);
            }
            else
            {
                MessageBox.Show("Please enter a string to search");
            }
        }

        private void btUpdateOwner_Click(object sender, EventArgs e)
        {
            Owner o = (Owner)lbOwners.SelectedItem;
            if (o != null)
            {
                string fName = tbNewFirstName.Text == "" ? o.FirstName : tbNewFirstName.Text,
                       lName = tbNewLastName.Text == "" ? o.LastName : tbNewLastName.Text,
                       phoneNumber = tbNewPhoneNumber.Text == "" ? o.PhoneNumber : tbNewPhoneNumber.Text,
                       email = tbNewEmail.Text == "" ? o.Email : tbNewEmail.Text;

                myShelter.UpdateOwnerDetails(o.ID, fName, lName, phoneNumber, email);
            }
            else
            {
                MessageBox.Show("Please select an owner you would like to update.");
            }
        }

        //to finish
        private void btDeleteOwner_Click(object sender, EventArgs e)
        {
            Owner o = (Owner)lbOwners.SelectedItem;
            if(o != null)
            {
                myShelter.RemoveOwnerDetails(o.ID);
            }
            else
            {
                MessageBox.Show("Please select an owner you would like to remove.");
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btOverview_Click(object sender, EventArgs e)
        {
            this.lbOverview.Items.Clear();
            lbOverview.Items.Add("Animals:");
            foreach (Animal a in myShelter.GetAllAnimals())
            {
                this.lbOverview.Items.Add(a);
            }
            lbOverview.Items.Add("Owners:");
            foreach (Owner o in myShelter.GetAllOwners())
            {
                this.lbOverview.Items.Add(o);
            }
        }

        private void showOwnersBtn_Click(object sender, EventArgs e)
        {
            updateOwnerListbox(myShelter.GetAllOwners());
        }

        private void updateOwnerListbox(List<Owner> owners)
        {
            lbOwners.Items.Clear();
            foreach (Owner owner in owners)
            {
                lbOwners.Items.Add(owner);
            }
        }
    }
}
