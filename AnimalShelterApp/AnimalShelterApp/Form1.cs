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
            addOwnerTestData();
            AddAnimalTestData();
            updateOwnerListbox(myShelter.GetAllOwners());
        }
        private void btnAddAnimal(object sender, EventArgs e)
        {
            string rfid = tbRFIDforRegistration.Text;
            string location = tbLocation.Text;
            string description = tbDescription.Text;
            Animal a;
            if (this.rbCat.Checked)
            {
                a = new Cat(rfid, location, description);

               

                    myShelter.RegisterCat(rfid, location, description, Convert.ToInt32(tbxOwnerId1.Text));
                

                if (rbhasOwner.Checked)
                {
                
                    //do something
                    
                }
                else if(rbDoesnotHaveOwner.Checked)
                {
                    myShelter.RegisterCat(rfid, location, description, null);
                    //myShelter.RegisterCat(rfid, location, description);
                }
            }
            else
            {
                a = new Dog(rfid, location, description);
                myShelter.RegisterDog(rfid, location, description);
                if (rbhasOwner.Checked)
                {
                    Owner owner = myShelter.GetOwner(Convert.ToInt32(tbownerId.Text));

                    if (owner != null)
                    {
                        a.AnimalsOwner = owner;
                        myShelter.RegisterDog(rfid, location, description);
                    }
                    //do something

                }
                else if (rbDoesnotHaveOwner.Checked)
                {
                    myShelter.RegisterCat(rfid, location, description,null);
                }
            }



        }
        
         
        private void btnUpdateAnimal(object sender, EventArgs e)
        {
            Animal a = (Animal)lbAnimals.SelectedItem;
            if (a != null)
            {
                myShelter.UpdateAnimalDetails(tbNewRFID.Text, tbNewDescription.Text);
            }

        }

        private void btnDeleteAnimal(object sender, EventArgs e)

        {
            Animal a = (Animal)lbAnimals.SelectedItem;
            if (a != null)
            {
                myShelter.RemoveAnimalDetails(tbNewRFID.Text);

            }

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

        private void button9_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string phoneNumber = tbPhoneNumber.Text;
            string email = tbEmail.Text;

            if (tbFirstName.Text == "" || tbLastName.Text == "" || tbPhoneNumber.Text == "" || tbEmail.Text == "")
            {
                MessageBox.Show("Please enter all fields for the owner.");
            }
            else
            {
                if (myShelter.SearchOwnerByPhone(phoneNumber) == null && myShelter.SearchOwnerByEmail(email) == null)
                {
                    myShelter.RegisterOwner(firstName, lastName, phoneNumber, email);
                    foreach (Control currentControl in ownerRegGrpBox.Controls)
                    {
                        if (currentControl is TextBox)
                        {
                            currentControl.Text = "";
                        }
                    }
                    updateOwnerListbox(myShelter.GetAllOwners());
                    lbOwners.SelectedIndex = lbOwners.Items.Count - 1;
                }
                else
                {
                    MessageBox.Show("Owner is already known in the system.");
                }
            }

        }

        private void btSearchOwner_Click(object sender, EventArgs e)
        {
            List<Owner> owners;
            string expression = ownerSearchTb.Text;

            if (expression != "")
            {
                owners = myShelter.SearchOwnerByLastName(expression);
                Owner o = myShelter.SearchOwnerByEmail(expression);
                if (o != null)
                {
                    owners.Add(o);
                }

                o = myShelter.SearchOwnerByPhone(expression);
                if (o != null)
                {
                    owners.Add(o);
                }

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
                int selectedItem = lbOwners.SelectedIndex;

                updateOwnerListbox(myShelter.GetAllOwners());
                lbOwners.SelectedIndex = selectedItem;
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
            if (o != null)
            {
                myShelter.RemoveOwnerDetails(o.ID);
                updateOwnerListbox(myShelter.GetAllOwners());
                foreach (Control currentControl in groupBox4.Controls)
                {
                    if (currentControl is TextBox)
                    {
                        currentControl.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an owner you would like to remove.");
            }
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
            lbOwners.Items.Add("ID:    Name:   Phone:  E-mail:");
            foreach (Owner owner in owners)
            {
                if (owner != null)
                {
                    lbOwners.Items.Add(owner);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.lbOwners.Items.Clear();
            foreach (Owner o in this.myShelter.GetAllOwners())
            {
                this.lbOwners.Items.Add(o);
            }
        }

        private void addOwnerTestData()
        {
            myShelter.RegisterOwner("Barnaby", "Jones", "0612345678", "example1@email.com");
            myShelter.RegisterOwner("Iris", "Bonvillain", "0623456789", "emaple2@email.com");
            myShelter.RegisterOwner("Lilias", "Bond", "0634567890", "emaple3@email.com");
            myShelter.RegisterOwner("Stella", "Groseclose", "0645678901", "emaple4@email.com");
            myShelter.RegisterOwner("Gert", "Ouelette", "0656789012", "emaple5@email.com");
            myShelter.RegisterOwner("Gael", "Holtzlander", "0667890123", "emaple6@email.com");
            myShelter.RegisterOwner("Querida", "Carlee", "0678901234", "example7@email.com");
            myShelter.RegisterOwner("Berthe", "Olcott", "0689012345", "example8@email.com");
            myShelter.RegisterOwner("Lorna", "Javarone", "0690123456", "example9@email.com");
            myShelter.RegisterOwner("Betty", "Chenette", "0601234567", "example10@email.com");
            myShelter.RegisterOwner("Katheryn", "Roal", "0611234567", "example11@email.com");
            myShelter.RegisterOwner("Wilie", "Yarbough", "0611345678", "example12@email.com");
        }
        private void AddAnimalTestData()
        {
            myShelter.RegisterCat("B56", "Eindhoven", "something",null);
            myShelter.RegisterDog("c56", "Eindhoven", "something");
            myShelter.RegisterCat("T56", "Eindhoven", "something",null);
            myShelter.RegisterDog("Y56", "Eindhoven", "something");
            myShelter.RegisterCat("Z56", "Eindhoven", "something",null);
            myShelter.RegisterDog("X56", "Eindhoven", "something");



        }

        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidateInput(e);
        }

        public static bool ValidateInput(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == (char)8))
            {
                return false;
            }
            return true;
        }

        private void lbOwners_SelectedIndexChanged(object sender, EventArgs e)
        {
            Owner o = (Owner)lbOwners.SelectedItem;
            if (o != null)
            {
                tbNewFirstName.Text = o.FirstName;
                tbNewLastName.Text = o.LastName;
                tbNewPhoneNumber.Text = o.PhoneNumber;
                tbNewEmail.Text = o.Email;

                tb_AdoptOwnerID.Text = o.ID.ToString();
            }
        }

        private void btnClaim_Click(object sender, EventArgs e)
        {
            int ownerID;
            string rfid;
            Owner owner = null;
            Animal animal;
            string previousOwnerName;

            rfid = tb_adoptRFID.Text;
            if (!Int32.TryParse(tb_AdoptOwnerID.Text, out ownerID))
            {
                MessageBox.Show("The format for owner id is wrong, please try again");
                return;
            }


            animal = myShelter.GetAnimal(rfid);
            owner = myShelter.GetOwner(ownerID);
            if (animal == null) { MessageBox.Show("There is no animal with this rfid, please try again"); return; }
            if (owner == null) { MessageBox.Show("There is no owner with this rfid, please try again"); return; }
            if (animal.AnimalsOwner != null) { previousOwnerName = animal.AnimalsOwner.FirstName + " " + animal.AnimalsOwner.LastName; } else { previousOwnerName = "unknown"; }

            if (animal.IsClaimAble)
            {
                double price = animal.GetFee(owner);
                if (animal.IsAdoptable())
                {
                    if (price == -1) { MessageBox.Show("Something went wrong while calculating the price"); return; }
                    if (MessageBox.Show("The fee is $" + price + ". press yes to comfirm payment", "PAYMENT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (myShelter.AdoptAnimal(ownerID, rfid))
                        {
                            MessageBox.Show("Owner has succesfully claimed animal");
                        }
                        else
                        {
                            MessageBox.Show("Somethign went wrong while claiming this animal");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Claim has been cancelled");
                    }
                }
                else
                {
                    if (MessageBox.Show("This animal is not adoptable yet. If the owner can prove this animal is his/hers press yes. The previous owner is " + previousOwnerName, "IDENTITY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (price == -1) { MessageBox.Show("Something went wrong while calculating the price"); return; }
                        if (MessageBox.Show("The fee is $" + price + ". press yes to comfirm payment", "PAYMENT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (myShelter.AdoptAnimal(ownerID, rfid))
                            {
                                MessageBox.Show("Owner has succesfully claimed animal");

                                this.lbAnimals.Items.Clear();
                                foreach (Animal a in this.myShelter.GetAllAnimals())
                                {
                                    this.lbAnimals.Items.Add(a);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Somethign went wrong while claiming this animal");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Claim has been cancelled");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Claim has been cancelled");
                    }
                }
            }
            else
            {
                MessageBox.Show("This animal is not claimable. Perhaps because someone already claimed it");
            }
        }

        private void lbAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAnimals.SelectedIndex >= 0)
            {
                Animal animal = (Animal)lbAnimals.SelectedItem;
                tb_adoptRFID.Text = animal.RfidNumber;
                tbNewRFID.Text = animal.RfidNumber;
                tbNewLocation.Text = animal.Location;
                tbNewDescription.Text = animal.Description;

            }


        }

           }
}
