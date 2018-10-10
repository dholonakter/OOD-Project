namespace AnimalShelterApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbRFIDforRegistration = new System.Windows.Forms.TextBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAddAnimal = new System.Windows.Forms.Button();
            this.rbCat = new System.Windows.Forms.RadioButton();
            this.rbDog = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ownerRegGrpBox = new System.Windows.Forms.GroupBox();
            this.btAddOwner = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.emailLb = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.fNameLb = new System.Windows.Forms.Label();
            this.lNameLb = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.phoneNumberLb = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbAnimals = new System.Windows.Forms.ListBox();
            this.btDeleteAnimal = new System.Windows.Forms.Button();
            this.tbSearchAnimal = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tbownerId = new System.Windows.Forms.TextBox();
            this.OwnerIdAnimal = new System.Windows.Forms.Label();
            this.tbNewRFID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btUpdateAnimal = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNewLocation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNewDescription = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSearchAnimal = new System.Windows.Forms.Button();
            this.btShowAnimals = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ownerCrudPanel = new System.Windows.Forms.Panel();
            this.showOwnersBtn = new System.Windows.Forms.Button();
            this.btSearchOwner = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btUpdateOwner = new System.Windows.Forms.Button();
            this.btDeleteOwner = new System.Windows.Forms.Button();
            this.tbNewEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbNewFirstName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbNewLastName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbNewPhoneNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbOwners = new System.Windows.Forms.ListBox();
            this.ownerSearchTb = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnClaim = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_AdoptOwnerID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_adoptRFID = new System.Windows.Forms.TextBox();
            this.lbOverview = new System.Windows.Forms.ListBox();
            this.btOverview = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.ownerRegGrpBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ownerCrudPanel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRFIDforRegistration
            // 
            this.tbRFIDforRegistration.Location = new System.Drawing.Point(113, 38);
            this.tbRFIDforRegistration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRFIDforRegistration.Name = "tbRFIDforRegistration";
            this.tbRFIDforRegistration.Size = new System.Drawing.Size(201, 22);
            this.tbRFIDforRegistration.TabIndex = 0;
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(113, 85);
            this.tbLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(201, 22);
            this.tbLocation.TabIndex = 1;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(115, 133);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(201, 22);
            this.tbDescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "RFID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // btAddAnimal
            // 
            this.btAddAnimal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btAddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddAnimal.Location = new System.Drawing.Point(119, 252);
            this.btAddAnimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddAnimal.Name = "btAddAnimal";
            this.btAddAnimal.Size = new System.Drawing.Size(116, 36);
            this.btAddAnimal.TabIndex = 6;
            this.btAddAnimal.Text = "Add";
            this.btAddAnimal.UseVisualStyleBackColor = false;
            this.btAddAnimal.Click += new System.EventHandler(this.btnAddAnimal);
            // 
            // rbCat
            // 
            this.rbCat.AutoSize = true;
            this.rbCat.Location = new System.Drawing.Point(61, 188);
            this.rbCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCat.Name = "rbCat";
            this.rbCat.Size = new System.Drawing.Size(50, 21);
            this.rbCat.TabIndex = 9;
            this.rbCat.TabStop = true;
            this.rbCat.Text = "Cat";
            this.rbCat.UseVisualStyleBackColor = true;
            // 
            // rbDog
            // 
            this.rbDog.AutoSize = true;
            this.rbDog.Location = new System.Drawing.Point(187, 188);
            this.rbDog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbDog.Name = "rbDog";
            this.rbDog.Size = new System.Drawing.Size(55, 21);
            this.rbDog.TabIndex = 10;
            this.rbDog.TabStop = true;
            this.rbDog.Text = "Dog";
            this.rbDog.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.tbRFIDforRegistration);
            this.groupBox1.Controls.Add(this.rbDog);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btAddAnimal);
            this.groupBox1.Controls.Add(this.rbCat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbLocation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbDescription);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(348, 332);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal Registration";
            // 
            // ownerRegGrpBox
            // 
            this.ownerRegGrpBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ownerRegGrpBox.Controls.Add(this.btAddOwner);
            this.ownerRegGrpBox.Controls.Add(this.tbEmail);
            this.ownerRegGrpBox.Controls.Add(this.emailLb);
            this.ownerRegGrpBox.Controls.Add(this.tbFirstName);
            this.ownerRegGrpBox.Controls.Add(this.fNameLb);
            this.ownerRegGrpBox.Controls.Add(this.lNameLb);
            this.ownerRegGrpBox.Controls.Add(this.tbLastName);
            this.ownerRegGrpBox.Controls.Add(this.phoneNumberLb);
            this.ownerRegGrpBox.Controls.Add(this.tbPhoneNumber);
            this.ownerRegGrpBox.Location = new System.Drawing.Point(12, 429);
            this.ownerRegGrpBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ownerRegGrpBox.Name = "ownerRegGrpBox";
            this.ownerRegGrpBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ownerRegGrpBox.Size = new System.Drawing.Size(355, 315);
            this.ownerRegGrpBox.TabIndex = 12;
            this.ownerRegGrpBox.TabStop = false;
            this.ownerRegGrpBox.Text = "Owner registartion";
            // 
            // btAddOwner
            // 
            this.btAddOwner.BackColor = System.Drawing.Color.PowderBlue;
            this.btAddOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddOwner.Location = new System.Drawing.Point(107, 265);
            this.btAddOwner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddOwner.Name = "btAddOwner";
            this.btAddOwner.Size = new System.Drawing.Size(128, 36);
            this.btAddOwner.TabIndex = 11;
            this.btAddOwner.Text = "Add";
            this.btAddOwner.UseVisualStyleBackColor = false;
            this.btAddOwner.Click += new System.EventHandler(this.button9_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(117, 176);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(201, 22);
            this.tbEmail.TabIndex = 10;
            // 
            // emailLb
            // 
            this.emailLb.AutoSize = true;
            this.emailLb.Location = new System.Drawing.Point(15, 176);
            this.emailLb.Name = "emailLb";
            this.emailLb.Size = new System.Drawing.Size(42, 17);
            this.emailLb.TabIndex = 9;
            this.emailLb.Text = "Email";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(117, 38);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(201, 22);
            this.tbFirstName.TabIndex = 0;
            // 
            // fNameLb
            // 
            this.fNameLb.AutoSize = true;
            this.fNameLb.Location = new System.Drawing.Point(15, 42);
            this.fNameLb.Name = "fNameLb";
            this.fNameLb.Size = new System.Drawing.Size(72, 17);
            this.fNameLb.TabIndex = 3;
            this.fNameLb.Text = "FirstName";
            // 
            // lNameLb
            // 
            this.lNameLb.AutoSize = true;
            this.lNameLb.Location = new System.Drawing.Point(15, 85);
            this.lNameLb.Name = "lNameLb";
            this.lNameLb.Size = new System.Drawing.Size(72, 17);
            this.lNameLb.TabIndex = 4;
            this.lNameLb.Text = "LastName";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(117, 85);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(201, 22);
            this.tbLastName.TabIndex = 1;
            // 
            // phoneNumberLb
            // 
            this.phoneNumberLb.AutoSize = true;
            this.phoneNumberLb.Location = new System.Drawing.Point(12, 133);
            this.phoneNumberLb.Name = "phoneNumberLb";
            this.phoneNumberLb.Size = new System.Drawing.Size(99, 17);
            this.phoneNumberLb.TabIndex = 5;
            this.phoneNumberLb.Text = "PhoneNumber";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(117, 129);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPhoneNumber.MaxLength = 10;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(201, 22);
            this.tbPhoneNumber.TabIndex = 2;
            this.tbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhoneNumber_KeyPress);
            // 
            // lbAnimals
            // 
            this.lbAnimals.FormattingEnabled = true;
            this.lbAnimals.ItemHeight = 16;
            this.lbAnimals.Location = new System.Drawing.Point(16, 60);
            this.lbAnimals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAnimals.Name = "lbAnimals";
            this.lbAnimals.Size = new System.Drawing.Size(328, 212);
            this.lbAnimals.TabIndex = 13;
            this.lbAnimals.SelectedIndexChanged += new System.EventHandler(this.lbAnimals_SelectedIndexChanged);
            // 
            // btDeleteAnimal
            // 
            this.btDeleteAnimal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btDeleteAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteAnimal.Location = new System.Drawing.Point(176, 239);
            this.btDeleteAnimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDeleteAnimal.Name = "btDeleteAnimal";
            this.btDeleteAnimal.Size = new System.Drawing.Size(96, 33);
            this.btDeleteAnimal.TabIndex = 15;
            this.btDeleteAnimal.Text = "Delete";
            this.btDeleteAnimal.UseVisualStyleBackColor = false;
            this.btDeleteAnimal.Click += new System.EventHandler(this.btnDeleteAnimal);
            // 
            // tbSearchAnimal
            // 
            this.tbSearchAnimal.Location = new System.Drawing.Point(203, 27);
            this.tbSearchAnimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearchAnimal.Name = "tbSearchAnimal";
            this.tbSearchAnimal.Size = new System.Drawing.Size(301, 22);
            this.tbSearchAnimal.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.tbownerId);
            this.groupBox3.Controls.Add(this.OwnerIdAnimal);
            this.groupBox3.Controls.Add(this.tbNewRFID);
            this.groupBox3.Controls.Add(this.btDeleteAnimal);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btUpdateAnimal);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbNewLocation);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbNewDescription);
            this.groupBox3.Location = new System.Drawing.Point(379, 60);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(325, 284);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Animal";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(90, 207);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(141, 21);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "UnlinktotheOwner";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tbownerId
            // 
            this.tbownerId.Enabled = false;
            this.tbownerId.Location = new System.Drawing.Point(113, 170);
            this.tbownerId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbownerId.Name = "tbownerId";
            this.tbownerId.Size = new System.Drawing.Size(201, 22);
            this.tbownerId.TabIndex = 17;
            // 
            // OwnerIdAnimal
            // 
            this.OwnerIdAnimal.AutoSize = true;
            this.OwnerIdAnimal.Location = new System.Drawing.Point(17, 170);
            this.OwnerIdAnimal.Name = "OwnerIdAnimal";
            this.OwnerIdAnimal.Size = new System.Drawing.Size(64, 17);
            this.OwnerIdAnimal.TabIndex = 16;
            this.OwnerIdAnimal.Text = "Owner Id";
            // 
            // tbNewRFID
            // 
            this.tbNewRFID.Location = new System.Drawing.Point(113, 38);
            this.tbNewRFID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNewRFID.Name = "tbNewRFID";
            this.tbNewRFID.Size = new System.Drawing.Size(201, 22);
            this.tbNewRFID.TabIndex = 0;
            this.tbNewRFID.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "RFID";
            // 
            // btUpdateAnimal
            // 
            this.btUpdateAnimal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btUpdateAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateAnimal.Location = new System.Drawing.Point(22, 241);
            this.btUpdateAnimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUpdateAnimal.Name = "btUpdateAnimal";
            this.btUpdateAnimal.Size = new System.Drawing.Size(88, 31);
            this.btUpdateAnimal.TabIndex = 6;
            this.btUpdateAnimal.Text = "Update";
            this.btUpdateAnimal.UseVisualStyleBackColor = false;
            this.btUpdateAnimal.Click += new System.EventHandler(this.btnUpdateAnimal);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Location";
            // 
            // tbNewLocation
            // 
            this.tbNewLocation.Location = new System.Drawing.Point(113, 85);
            this.tbNewLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNewLocation.Name = "tbNewLocation";
            this.tbNewLocation.Size = new System.Drawing.Size(201, 22);
            this.tbNewLocation.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Description";
            // 
            // tbNewDescription
            // 
            this.tbNewDescription.Location = new System.Drawing.Point(113, 132);
            this.tbNewDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNewDescription.Name = "tbNewDescription";
            this.tbNewDescription.Size = new System.Drawing.Size(201, 22);
            this.tbNewDescription.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btSearchAnimal);
            this.panel1.Controls.Add(this.btShowAnimals);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lbAnimals);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.tbSearchAnimal);
            this.panel1.Location = new System.Drawing.Point(395, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 360);
            this.panel1.TabIndex = 17;
            // 
            // btSearchAnimal
            // 
            this.btSearchAnimal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btSearchAnimal.Location = new System.Drawing.Point(551, 27);
            this.btSearchAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.btSearchAnimal.Name = "btSearchAnimal";
            this.btSearchAnimal.Size = new System.Drawing.Size(100, 28);
            this.btSearchAnimal.TabIndex = 18;
            this.btSearchAnimal.Text = "Search";
            this.btSearchAnimal.UseVisualStyleBackColor = false;
            this.btSearchAnimal.Click += new System.EventHandler(this.btSearchAnimal_Click);
            // 
            // btShowAnimals
            // 
            this.btShowAnimals.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btShowAnimals.Location = new System.Drawing.Point(43, 316);
            this.btShowAnimals.Margin = new System.Windows.Forms.Padding(4);
            this.btShowAnimals.Name = "btShowAnimals";
            this.btShowAnimals.Size = new System.Drawing.Size(165, 28);
            this.btShowAnimals.TabIndex = 17;
            this.btShowAnimals.Text = "Show animals";
            this.btShowAnimals.UseVisualStyleBackColor = false;
            this.btShowAnimals.Click += new System.EventHandler(this.btShowAnimals_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Serach Animal By RFID";
            // 
            // ownerCrudPanel
            // 
            this.ownerCrudPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ownerCrudPanel.Controls.Add(this.showOwnersBtn);
            this.ownerCrudPanel.Controls.Add(this.btSearchOwner);
            this.ownerCrudPanel.Controls.Add(this.groupBox4);
            this.ownerCrudPanel.Controls.Add(this.label12);
            this.ownerCrudPanel.Controls.Add(this.lbOwners);
            this.ownerCrudPanel.Controls.Add(this.ownerSearchTb);
            this.ownerCrudPanel.Location = new System.Drawing.Point(395, 429);
            this.ownerCrudPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ownerCrudPanel.Name = "ownerCrudPanel";
            this.ownerCrudPanel.Size = new System.Drawing.Size(727, 315);
            this.ownerCrudPanel.TabIndex = 18;
            // 
            // showOwnersBtn
            // 
            this.showOwnersBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.showOwnersBtn.Location = new System.Drawing.Point(97, 278);
            this.showOwnersBtn.Margin = new System.Windows.Forms.Padding(4);
            this.showOwnersBtn.Name = "showOwnersBtn";
            this.showOwnersBtn.Size = new System.Drawing.Size(165, 28);
            this.showOwnersBtn.TabIndex = 20;
            this.showOwnersBtn.Text = "Show owners";
            this.showOwnersBtn.UseVisualStyleBackColor = false;
            this.showOwnersBtn.Click += new System.EventHandler(this.showOwnersBtn_Click);
            // 
            // btSearchOwner
            // 
            this.btSearchOwner.BackColor = System.Drawing.Color.PowderBlue;
            this.btSearchOwner.Location = new System.Drawing.Point(551, 30);
            this.btSearchOwner.Margin = new System.Windows.Forms.Padding(4);
            this.btSearchOwner.Name = "btSearchOwner";
            this.btSearchOwner.Size = new System.Drawing.Size(100, 28);
            this.btSearchOwner.TabIndex = 19;
            this.btSearchOwner.Text = "Search";
            this.btSearchOwner.UseVisualStyleBackColor = false;
            this.btSearchOwner.Click += new System.EventHandler(this.btSearchOwner_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btUpdateOwner);
            this.groupBox4.Controls.Add(this.btDeleteOwner);
            this.groupBox4.Controls.Add(this.tbNewEmail);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.tbNewFirstName);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.tbNewLastName);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.tbNewPhoneNumber);
            this.groupBox4.Location = new System.Drawing.Point(363, 60);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(355, 246);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Owner registartion";
            // 
            // btUpdateOwner
            // 
            this.btUpdateOwner.BackColor = System.Drawing.Color.PowderBlue;
            this.btUpdateOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateOwner.Location = new System.Drawing.Point(51, 210);
            this.btUpdateOwner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUpdateOwner.Name = "btUpdateOwner";
            this.btUpdateOwner.Size = new System.Drawing.Size(88, 30);
            this.btUpdateOwner.TabIndex = 12;
            this.btUpdateOwner.Text = "Update";
            this.btUpdateOwner.UseVisualStyleBackColor = false;
            this.btUpdateOwner.Click += new System.EventHandler(this.btUpdateOwner_Click);
            // 
            // btDeleteOwner
            // 
            this.btDeleteOwner.BackColor = System.Drawing.Color.PowderBlue;
            this.btDeleteOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteOwner.Location = new System.Drawing.Point(205, 210);
            this.btDeleteOwner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDeleteOwner.Name = "btDeleteOwner";
            this.btDeleteOwner.Size = new System.Drawing.Size(100, 30);
            this.btDeleteOwner.TabIndex = 11;
            this.btDeleteOwner.Text = "Delete";
            this.btDeleteOwner.UseVisualStyleBackColor = false;
            this.btDeleteOwner.Click += new System.EventHandler(this.btDeleteOwner_Click);
            // 
            // tbNewEmail
            // 
            this.tbNewEmail.Location = new System.Drawing.Point(117, 172);
            this.tbNewEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNewEmail.Name = "tbNewEmail";
            this.tbNewEmail.Size = new System.Drawing.Size(201, 22);
            this.tbNewEmail.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "Email";
            // 
            // tbNewFirstName
            // 
            this.tbNewFirstName.Location = new System.Drawing.Point(117, 38);
            this.tbNewFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNewFirstName.Name = "tbNewFirstName";
            this.tbNewFirstName.Size = new System.Drawing.Size(201, 22);
            this.tbNewFirstName.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "FirstName";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "LastName";
            // 
            // tbNewLastName
            // 
            this.tbNewLastName.Location = new System.Drawing.Point(117, 85);
            this.tbNewLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNewLastName.Name = "tbNewLastName";
            this.tbNewLastName.Size = new System.Drawing.Size(201, 22);
            this.tbNewLastName.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "PhoneNumber";
            // 
            // tbNewPhoneNumber
            // 
            this.tbNewPhoneNumber.Location = new System.Drawing.Point(117, 129);
            this.tbNewPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNewPhoneNumber.Name = "tbNewPhoneNumber";
            this.tbNewPhoneNumber.Size = new System.Drawing.Size(201, 22);
            this.tbNewPhoneNumber.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Search Owner";
            // 
            // lbOwners
            // 
            this.lbOwners.FormattingEnabled = true;
            this.lbOwners.ItemHeight = 16;
            this.lbOwners.Location = new System.Drawing.Point(16, 60);
            this.lbOwners.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbOwners.Name = "lbOwners";
            this.lbOwners.ScrollAlwaysVisible = true;
            this.lbOwners.Size = new System.Drawing.Size(328, 212);
            this.lbOwners.TabIndex = 13;
            this.lbOwners.SelectedIndexChanged += new System.EventHandler(this.lbOwners_SelectedIndexChanged);
            // 
            // ownerSearchTb
            // 
            this.ownerSearchTb.Location = new System.Drawing.Point(203, 30);
            this.ownerSearchTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ownerSearchTb.Name = "ownerSearchTb";
            this.ownerSearchTb.Size = new System.Drawing.Size(301, 22);
            this.ownerSearchTb.TabIndex = 16;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.btnClaim);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.tb_AdoptOwnerID);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.tb_adoptRFID);
            this.groupBox5.Location = new System.Drawing.Point(1141, 429);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(397, 315);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Adopt Animal";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(31, 128);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 17);
            this.label19.TabIndex = 18;
            this.label19.Text = "Owner";
            // 
            // btnClaim
            // 
            this.btnClaim.BackColor = System.Drawing.Color.PowderBlue;
            this.btnClaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClaim.Location = new System.Drawing.Point(161, 236);
            this.btnClaim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClaim.Name = "btnClaim";
            this.btnClaim.Size = new System.Drawing.Size(99, 41);
            this.btnClaim.TabIndex = 17;
            this.btnClaim.Text = "Claim";
            this.btnClaim.UseVisualStyleBackColor = false;
            this.btnClaim.Click += new System.EventHandler(this.btnClaim_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(31, 124);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 17);
            this.label18.TabIndex = 12;
            // 
            // tb_AdoptOwnerID
            // 
            this.tb_AdoptOwnerID.Location = new System.Drawing.Point(109, 124);
            this.tb_AdoptOwnerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_AdoptOwnerID.Name = "tb_AdoptOwnerID";
            this.tb_AdoptOwnerID.Size = new System.Drawing.Size(201, 22);
            this.tb_AdoptOwnerID.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 17);
            this.label17.TabIndex = 4;
            this.label17.Text = "RFID";
            // 
            // tb_adoptRFID
            // 
            this.tb_adoptRFID.Location = new System.Drawing.Point(109, 73);
            this.tb_adoptRFID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_adoptRFID.Name = "tb_adoptRFID";
            this.tb_adoptRFID.Size = new System.Drawing.Size(201, 22);
            this.tb_adoptRFID.TabIndex = 1;
            // 
            // lbOverview
            // 
            this.lbOverview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbOverview.FormattingEnabled = true;
            this.lbOverview.ItemHeight = 16;
            this.lbOverview.Location = new System.Drawing.Point(1141, 25);
            this.lbOverview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbOverview.Name = "lbOverview";
            this.lbOverview.Size = new System.Drawing.Size(396, 260);
            this.lbOverview.TabIndex = 20;
            // 
            // btOverview
            // 
            this.btOverview.BackColor = System.Drawing.Color.PowderBlue;
            this.btOverview.Location = new System.Drawing.Point(1251, 305);
            this.btOverview.Margin = new System.Windows.Forms.Padding(4);
            this.btOverview.Name = "btOverview";
            this.btOverview.Size = new System.Drawing.Size(179, 28);
            this.btOverview.TabIndex = 21;
            this.btOverview.Text = "Generate overview";
            this.btOverview.UseVisualStyleBackColor = false;
            this.btOverview.Click += new System.EventHandler(this.btOverview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1595, 802);
            this.Controls.Add(this.btOverview);
            this.Controls.Add(this.lbOverview);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.ownerCrudPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ownerRegGrpBox);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "AnimalShelterApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ownerRegGrpBox.ResumeLayout(false);
            this.ownerRegGrpBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ownerCrudPanel.ResumeLayout(false);
            this.ownerCrudPanel.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbRFIDforRegistration;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAddAnimal;
        private System.Windows.Forms.RadioButton rbCat;
        private System.Windows.Forms.RadioButton rbDog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox ownerRegGrpBox;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label fNameLb;
        private System.Windows.Forms.Label lNameLb;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label phoneNumberLb;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label emailLb;
        private System.Windows.Forms.ListBox lbAnimals;
        private System.Windows.Forms.Button btDeleteAnimal;
        private System.Windows.Forms.TextBox tbSearchAnimal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbNewRFID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btUpdateAnimal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNewLocation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNewDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel ownerCrudPanel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btDeleteOwner;
        private System.Windows.Forms.TextBox tbNewEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbNewFirstName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbNewLastName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbNewPhoneNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lbOwners;
        private System.Windows.Forms.TextBox ownerSearchTb;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_AdoptOwnerID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_adoptRFID;
        private System.Windows.Forms.Button btAddOwner;
        private System.Windows.Forms.Button btUpdateOwner;
        private System.Windows.Forms.Button btnClaim;
        private System.Windows.Forms.ListBox lbOverview;
        private System.Windows.Forms.Button btShowAnimals;
        private System.Windows.Forms.Button btSearchAnimal;
        private System.Windows.Forms.Button btSearchOwner;
        private System.Windows.Forms.Button btOverview;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button showOwnersBtn;
        private System.Windows.Forms.TextBox tbownerId;
        private System.Windows.Forms.Label OwnerIdAnimal;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

