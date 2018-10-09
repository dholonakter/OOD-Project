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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btAddOwner = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbAnimals = new System.Windows.Forms.ListBox();
            this.btDeleteAnimal = new System.Windows.Forms.Button();
            this.tbSearchAnimal = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.lbOverview = new System.Windows.Forms.ListBox();
            this.btOverview = new System.Windows.Forms.Button();
            this.btShowOwners = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRFIDforRegistration
            // 
            this.tbRFIDforRegistration.Location = new System.Drawing.Point(85, 31);
            this.tbRFIDforRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.tbRFIDforRegistration.Name = "tbRFIDforRegistration";
            this.tbRFIDforRegistration.Size = new System.Drawing.Size(152, 20);
            this.tbRFIDforRegistration.TabIndex = 0;
            this.tbRFIDforRegistration.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(85, 69);
            this.tbLocation.Margin = new System.Windows.Forms.Padding(2);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(152, 20);
            this.tbLocation.TabIndex = 1;
            this.tbLocation.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(86, 108);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(152, 20);
            this.tbDescription.TabIndex = 2;
            this.tbDescription.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RFID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Location";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btAddAnimal
            // 
            this.btAddAnimal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btAddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddAnimal.Location = new System.Drawing.Point(89, 205);
            this.btAddAnimal.Margin = new System.Windows.Forms.Padding(2);
            this.btAddAnimal.Name = "btAddAnimal";
            this.btAddAnimal.Size = new System.Drawing.Size(87, 29);
            this.btAddAnimal.TabIndex = 6;
            this.btAddAnimal.Text = "Add";
            this.btAddAnimal.UseVisualStyleBackColor = false;
            this.btAddAnimal.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbCat
            // 
            this.rbCat.AutoSize = true;
            this.rbCat.Location = new System.Drawing.Point(46, 153);
            this.rbCat.Margin = new System.Windows.Forms.Padding(2);
            this.rbCat.Name = "rbCat";
            this.rbCat.Size = new System.Drawing.Size(41, 17);
            this.rbCat.TabIndex = 9;
            this.rbCat.TabStop = true;
            this.rbCat.Text = "Cat";
            this.rbCat.UseVisualStyleBackColor = true;
            this.rbCat.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbDog
            // 
            this.rbDog.AutoSize = true;
            this.rbDog.Location = new System.Drawing.Point(140, 153);
            this.rbDog.Margin = new System.Windows.Forms.Padding(2);
            this.rbDog.Name = "rbDog";
            this.rbDog.Size = new System.Drawing.Size(45, 17);
            this.rbDog.TabIndex = 10;
            this.rbDog.TabStop = true;
            this.rbDog.Text = "Dog";
            this.rbDog.UseVisualStyleBackColor = true;
            this.rbDog.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
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
            this.groupBox1.Location = new System.Drawing.Point(9, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(261, 251);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal Registration";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.btAddOwner);
            this.groupBox2.Controls.Add(this.tbEmail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbFirstName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbLastName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbPhoneNumber);
            this.groupBox2.Location = new System.Drawing.Point(9, 329);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(266, 256);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Owner registartion";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btAddOwner
            // 
            this.btAddOwner.BackColor = System.Drawing.Color.PowderBlue;
            this.btAddOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddOwner.Location = new System.Drawing.Point(80, 215);
            this.btAddOwner.Margin = new System.Windows.Forms.Padding(2);
            this.btAddOwner.Name = "btAddOwner";
            this.btAddOwner.Size = new System.Drawing.Size(96, 29);
            this.btAddOwner.TabIndex = 11;
            this.btAddOwner.Text = "Add";
            this.btAddOwner.UseVisualStyleBackColor = false;
            this.btAddOwner.Click += new System.EventHandler(this.button9_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(88, 143);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(152, 20);
            this.tbEmail.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Email";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(88, 31);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(152, 20);
            this.tbFirstName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FirstName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "LastName";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(88, 69);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(152, 20);
            this.tbLastName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "PhoneNumber";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(88, 105);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(152, 20);
            this.tbPhoneNumber.TabIndex = 2;
            this.tbPhoneNumber.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // lbAnimals
            // 
            this.lbAnimals.FormattingEnabled = true;
            this.lbAnimals.Location = new System.Drawing.Point(12, 49);
            this.lbAnimals.Margin = new System.Windows.Forms.Padding(2);
            this.lbAnimals.Name = "lbAnimals";
            this.lbAnimals.Size = new System.Drawing.Size(247, 134);
            this.lbAnimals.TabIndex = 13;
            // 
            // btDeleteAnimal
            // 
            this.btDeleteAnimal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btDeleteAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteAnimal.Location = new System.Drawing.Point(145, 139);
            this.btDeleteAnimal.Margin = new System.Windows.Forms.Padding(2);
            this.btDeleteAnimal.Name = "btDeleteAnimal";
            this.btDeleteAnimal.Size = new System.Drawing.Size(72, 27);
            this.btDeleteAnimal.TabIndex = 15;
            this.btDeleteAnimal.Text = "Delete";
            this.btDeleteAnimal.UseVisualStyleBackColor = false;
            this.btDeleteAnimal.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // tbSearchAnimal
            // 
            this.tbSearchAnimal.Location = new System.Drawing.Point(152, 22);
            this.tbSearchAnimal.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchAnimal.Name = "tbSearchAnimal";
            this.tbSearchAnimal.Size = new System.Drawing.Size(227, 20);
            this.tbSearchAnimal.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbNewRFID);
            this.groupBox3.Controls.Add(this.btDeleteAnimal);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btUpdateAnimal);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbNewLocation);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbNewDescription);
            this.groupBox3.Location = new System.Drawing.Point(284, 49);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(244, 168);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Animal";
            // 
            // tbNewRFID
            // 
            this.tbNewRFID.Location = new System.Drawing.Point(85, 31);
            this.tbNewRFID.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewRFID.Name = "tbNewRFID";
            this.tbNewRFID.Size = new System.Drawing.Size(152, 20);
            this.tbNewRFID.TabIndex = 0;
            this.tbNewRFID.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "RFID";
            // 
            // btUpdateAnimal
            // 
            this.btUpdateAnimal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btUpdateAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateAnimal.Location = new System.Drawing.Point(38, 141);
            this.btUpdateAnimal.Margin = new System.Windows.Forms.Padding(2);
            this.btUpdateAnimal.Name = "btUpdateAnimal";
            this.btUpdateAnimal.Size = new System.Drawing.Size(66, 25);
            this.btUpdateAnimal.TabIndex = 6;
            this.btUpdateAnimal.Text = "Update";
            this.btUpdateAnimal.UseVisualStyleBackColor = false;
            this.btUpdateAnimal.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Location";
            // 
            // tbNewLocation
            // 
            this.tbNewLocation.Location = new System.Drawing.Point(85, 69);
            this.tbNewLocation.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewLocation.Name = "tbNewLocation";
            this.tbNewLocation.Size = new System.Drawing.Size(152, 20);
            this.tbNewLocation.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 110);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Description";
            // 
            // tbNewDescription
            // 
            this.tbNewDescription.Location = new System.Drawing.Point(85, 107);
            this.tbNewDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewDescription.Name = "tbNewDescription";
            this.tbNewDescription.Size = new System.Drawing.Size(152, 20);
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
            this.panel1.Location = new System.Drawing.Point(296, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 251);
            this.panel1.TabIndex = 17;
            // 
            // btSearchAnimal
            // 
            this.btSearchAnimal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btSearchAnimal.Location = new System.Drawing.Point(413, 22);
            this.btSearchAnimal.Name = "btSearchAnimal";
            this.btSearchAnimal.Size = new System.Drawing.Size(75, 23);
            this.btSearchAnimal.TabIndex = 18;
            this.btSearchAnimal.Text = "Search";
            this.btSearchAnimal.UseVisualStyleBackColor = false;
            this.btSearchAnimal.Click += new System.EventHandler(this.btSearchAnimal_Click);
            // 
            // btShowAnimals
            // 
            this.btShowAnimals.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btShowAnimals.Location = new System.Drawing.Point(73, 211);
            this.btShowAnimals.Name = "btShowAnimals";
            this.btShowAnimals.Size = new System.Drawing.Size(124, 23);
            this.btShowAnimals.TabIndex = 17;
            this.btShowAnimals.Text = "Show animals";
            this.btShowAnimals.UseVisualStyleBackColor = false;
            this.btShowAnimals.Click += new System.EventHandler(this.btShowAnimals_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 24);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Serach Animal By RFID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.btShowOwners);
            this.panel2.Controls.Add(this.btSearchOwner);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lbOwners);
            this.panel2.Controls.Add(this.textBox15);
            this.panel2.Location = new System.Drawing.Point(296, 329);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 256);
            this.panel2.TabIndex = 18;
            // 
            // btSearchOwner
            // 
            this.btSearchOwner.BackColor = System.Drawing.Color.PowderBlue;
            this.btSearchOwner.Location = new System.Drawing.Point(413, 24);
            this.btSearchOwner.Name = "btSearchOwner";
            this.btSearchOwner.Size = new System.Drawing.Size(75, 23);
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
            this.groupBox4.Location = new System.Drawing.Point(272, 49);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(266, 200);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Owner registartion";
            // 
            // btUpdateOwner
            // 
            this.btUpdateOwner.BackColor = System.Drawing.Color.PowderBlue;
            this.btUpdateOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateOwner.Location = new System.Drawing.Point(38, 171);
            this.btUpdateOwner.Margin = new System.Windows.Forms.Padding(2);
            this.btUpdateOwner.Name = "btUpdateOwner";
            this.btUpdateOwner.Size = new System.Drawing.Size(66, 24);
            this.btUpdateOwner.TabIndex = 12;
            this.btUpdateOwner.Text = "Update";
            this.btUpdateOwner.UseVisualStyleBackColor = false;
            this.btUpdateOwner.Click += new System.EventHandler(this.btUpdateOwner_Click);
            // 
            // btDeleteOwner
            // 
            this.btDeleteOwner.BackColor = System.Drawing.Color.PowderBlue;
            this.btDeleteOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteOwner.Location = new System.Drawing.Point(154, 171);
            this.btDeleteOwner.Margin = new System.Windows.Forms.Padding(2);
            this.btDeleteOwner.Name = "btDeleteOwner";
            this.btDeleteOwner.Size = new System.Drawing.Size(75, 24);
            this.btDeleteOwner.TabIndex = 11;
            this.btDeleteOwner.Text = "Delete";
            this.btDeleteOwner.UseVisualStyleBackColor = false;
            this.btDeleteOwner.Click += new System.EventHandler(this.btDeleteOwner_Click);
            // 
            // tbNewEmail
            // 
            this.tbNewEmail.Location = new System.Drawing.Point(88, 140);
            this.tbNewEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewEmail.Name = "tbNewEmail";
            this.tbNewEmail.Size = new System.Drawing.Size(152, 20);
            this.tbNewEmail.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 143);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Email";
            // 
            // tbNewFirstName
            // 
            this.tbNewFirstName.Location = new System.Drawing.Point(88, 31);
            this.tbNewFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewFirstName.Name = "tbNewFirstName";
            this.tbNewFirstName.Size = new System.Drawing.Size(152, 20);
            this.tbNewFirstName.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 31);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "FirstName";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 72);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "LastName";
            // 
            // tbNewLastName
            // 
            this.tbNewLastName.Location = new System.Drawing.Point(88, 69);
            this.tbNewLastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewLastName.Name = "tbNewLastName";
            this.tbNewLastName.Size = new System.Drawing.Size(152, 20);
            this.tbNewLastName.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 107);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "PhoneNumber";
            // 
            // tbNewPhoneNumber
            // 
            this.tbNewPhoneNumber.Location = new System.Drawing.Point(88, 105);
            this.tbNewPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewPhoneNumber.Name = "tbNewPhoneNumber";
            this.tbNewPhoneNumber.Size = new System.Drawing.Size(152, 20);
            this.tbNewPhoneNumber.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 24);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Search Owner";
            // 
            // lbOwners
            // 
            this.lbOwners.FormattingEnabled = true;
            this.lbOwners.Location = new System.Drawing.Point(12, 49);
            this.lbOwners.Margin = new System.Windows.Forms.Padding(2);
            this.lbOwners.Name = "lbOwners";
            this.lbOwners.Size = new System.Drawing.Size(247, 147);
            this.lbOwners.TabIndex = 13;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(152, 24);
            this.textBox15.Margin = new System.Windows.Forms.Padding(2);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(227, 20);
            this.textBox15.TabIndex = 16;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.textBox18);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.textBox17);
            this.groupBox5.Location = new System.Drawing.Point(856, 329);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(298, 256);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Adopt Animal";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 104);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "Owner";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.PowderBlue;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(179, 189);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 33);
            this.button8.TabIndex = 17;
            this.button8.Text = "Reclaim";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.PowderBlue;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(53, 189);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 33);
            this.button7.TabIndex = 16;
            this.button7.Text = "Adopt";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 101);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 13);
            this.label18.TabIndex = 12;
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(82, 101);
            this.textBox18.Margin = new System.Windows.Forms.Padding(2);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(152, 20);
            this.textBox18.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 59);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "RFID";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(82, 59);
            this.textBox17.Margin = new System.Windows.Forms.Padding(2);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(152, 20);
            this.textBox17.TabIndex = 1;
            // 
            // lbOverview
            // 
            this.lbOverview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbOverview.FormattingEnabled = true;
            this.lbOverview.Location = new System.Drawing.Point(856, 20);
            this.lbOverview.Margin = new System.Windows.Forms.Padding(2);
            this.lbOverview.Name = "lbOverview";
            this.lbOverview.Size = new System.Drawing.Size(298, 212);
            this.lbOverview.TabIndex = 20;
            // 
            // btOverview
            // 
            this.btOverview.BackColor = System.Drawing.Color.PowderBlue;
            this.btOverview.Location = new System.Drawing.Point(938, 248);
            this.btOverview.Name = "btOverview";
            this.btOverview.Size = new System.Drawing.Size(134, 23);
            this.btOverview.TabIndex = 21;
            this.btOverview.Text = "Generate overview";
            this.btOverview.UseVisualStyleBackColor = false;
            this.btOverview.Click += new System.EventHandler(this.btOverview_Click);
            // 
            // btShowOwners
            // 
            this.btShowOwners.BackColor = System.Drawing.Color.PowderBlue;
            this.btShowOwners.Location = new System.Drawing.Point(98, 220);
            this.btShowOwners.Name = "btShowOwners";
            this.btShowOwners.Size = new System.Drawing.Size(99, 23);
            this.btShowOwners.TabIndex = 20;
            this.btShowOwners.Text = "Show owners";
            this.btShowOwners.UseVisualStyleBackColor = false;
            this.btShowOwners.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1196, 652);
            this.Controls.Add(this.btOverview);
            this.Controls.Add(this.lbOverview);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "AnimalShelterApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Button btAddOwner;
        private System.Windows.Forms.Button btUpdateOwner;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListBox lbOverview;
        private System.Windows.Forms.Button btShowAnimals;
        private System.Windows.Forms.Button btSearchAnimal;
        private System.Windows.Forms.Button btSearchOwner;
        private System.Windows.Forms.Button btOverview;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btShowOwners;
    }
}

