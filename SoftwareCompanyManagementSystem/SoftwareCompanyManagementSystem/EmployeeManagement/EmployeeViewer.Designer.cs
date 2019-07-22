namespace SoftwareCompanyManagementSystem.EmployeeManagement
{
    partial class EmployeeViewer
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
            this.RolesCombobox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ExperinceYearsCounter = new System.Windows.Forms.NumericUpDown();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.BirthDatepicker = new System.Windows.Forms.DateTimePicker();
            this.AssignProjectToEmployeeBtn = new System.Windows.Forms.Button();
            this.ProjectsComboBox = new System.Windows.Forms.ComboBox();
            this.EducationalDegreesComboBox = new System.Windows.Forms.ComboBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveEmployeeBtn = new System.Windows.Forms.Button();
            this.EmployeeProfilePicture = new System.Windows.Forms.PictureBox();
            this.EmployeeProjectsList = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.FatherNameBox = new System.Windows.Forms.TextBox();
            this.MotherNameBox = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.EmailAddress = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExperinceYearsCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // RolesCombobox
            // 
            this.RolesCombobox.DisplayMember = "EnName";
            this.RolesCombobox.FormattingEnabled = true;
            this.RolesCombobox.Location = new System.Drawing.Point(425, 305);
            this.RolesCombobox.Name = "RolesCombobox";
            this.RolesCombobox.Size = new System.Drawing.Size(163, 21);
            this.RolesCombobox.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(391, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 101;
            this.label15.Text = "Role";
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(425, 249);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(163, 20);
            this.userNameBox.TabIndex = 13;
            this.userNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userNameBox_KeyDown);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(425, 275);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(163, 20);
            this.PasswordBox.TabIndex = 14;
            this.PasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userNameBox_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(366, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 98;
            this.label13.Text = "Password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(361, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 97;
            this.label14.Text = "User name";
            // 
            // ExperinceYearsCounter
            // 
            this.ExperinceYearsCounter.Location = new System.Drawing.Point(120, 225);
            this.ExperinceYearsCounter.Name = "ExperinceYearsCounter";
            this.ExperinceYearsCounter.Size = new System.Drawing.Size(222, 20);
            this.ExperinceYearsCounter.TabIndex = 8;
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.DisplayMember = "Gender";
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Location = new System.Drawing.Point(120, 144);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(222, 21);
            this.GenderComboBox.TabIndex = 5;
            this.GenderComboBox.ValueMember = "Id";
            // 
            // BirthDatepicker
            // 
            this.BirthDatepicker.CustomFormat = "dd/MM/yyyy";
            this.BirthDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthDatepicker.Location = new System.Drawing.Point(120, 117);
            this.BirthDatepicker.Name = "BirthDatepicker";
            this.BirthDatepicker.Size = new System.Drawing.Size(222, 20);
            this.BirthDatepicker.TabIndex = 4;
            // 
            // AssignProjectToEmployeeBtn
            // 
            this.AssignProjectToEmployeeBtn.Location = new System.Drawing.Point(284, 279);
            this.AssignProjectToEmployeeBtn.Name = "AssignProjectToEmployeeBtn";
            this.AssignProjectToEmployeeBtn.Size = new System.Drawing.Size(58, 23);
            this.AssignProjectToEmployeeBtn.TabIndex = 12;
            this.AssignProjectToEmployeeBtn.Text = "Assign";
            this.AssignProjectToEmployeeBtn.UseVisualStyleBackColor = true;
            this.AssignProjectToEmployeeBtn.Click += new System.EventHandler(this.AssignProjectToEmployeeBtn_Click);
            // 
            // ProjectsComboBox
            // 
            this.ProjectsComboBox.DisplayMember = "ProjectName";
            this.ProjectsComboBox.FormattingEnabled = true;
            this.ProjectsComboBox.Location = new System.Drawing.Point(120, 280);
            this.ProjectsComboBox.Name = "ProjectsComboBox";
            this.ProjectsComboBox.Size = new System.Drawing.Size(158, 21);
            this.ProjectsComboBox.TabIndex = 11;
            // 
            // EducationalDegreesComboBox
            // 
            this.EducationalDegreesComboBox.DisplayMember = "EnName";
            this.EducationalDegreesComboBox.FormattingEnabled = true;
            this.EducationalDegreesComboBox.Location = new System.Drawing.Point(120, 252);
            this.EducationalDegreesComboBox.Name = "EducationalDegreesComboBox";
            this.EducationalDegreesComboBox.Size = new System.Drawing.Size(222, 21);
            this.EducationalDegreesComboBox.TabIndex = 9;
            this.EducationalDegreesComboBox.ValueMember = "Id";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(513, 421);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 17;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // SaveEmployeeBtn
            // 
            this.SaveEmployeeBtn.Location = new System.Drawing.Point(432, 421);
            this.SaveEmployeeBtn.Name = "SaveEmployeeBtn";
            this.SaveEmployeeBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveEmployeeBtn.TabIndex = 16;
            this.SaveEmployeeBtn.Text = "Save";
            this.SaveEmployeeBtn.UseVisualStyleBackColor = true;
            this.SaveEmployeeBtn.Click += new System.EventHandler(this.SaveEmployeeBtn_Click);
            // 
            // EmployeeProfilePicture
            // 
            this.EmployeeProfilePicture.Location = new System.Drawing.Point(360, 9);
            this.EmployeeProfilePicture.Name = "EmployeeProfilePicture";
            this.EmployeeProfilePicture.Size = new System.Drawing.Size(228, 209);
            this.EmployeeProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmployeeProfilePicture.TabIndex = 88;
            this.EmployeeProfilePicture.TabStop = false;
            this.EmployeeProfilePicture.Click += new System.EventHandler(this.EmployeeProfilePicture_Click);
            // 
            // EmployeeProjectsList
            // 
            this.EmployeeProjectsList.DisplayMember = "ProjectName";
            this.EmployeeProjectsList.FormattingEnabled = true;
            this.EmployeeProjectsList.Location = new System.Drawing.Point(120, 312);
            this.EmployeeProjectsList.Name = "EmployeeProjectsList";
            this.EmployeeProjectsList.Size = new System.Drawing.Size(222, 108);
            this.EmployeeProjectsList.TabIndex = 99;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 86;
            this.label12.Text = "Projects";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(120, 36);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(222, 20);
            this.LastNameBox.TabIndex = 1;
            // 
            // FatherNameBox
            // 
            this.FatherNameBox.Location = new System.Drawing.Point(120, 63);
            this.FatherNameBox.Name = "FatherNameBox";
            this.FatherNameBox.Size = new System.Drawing.Size(222, 20);
            this.FatherNameBox.TabIndex = 2;
            // 
            // MotherNameBox
            // 
            this.MotherNameBox.Location = new System.Drawing.Point(120, 90);
            this.MotherNameBox.Name = "MotherNameBox";
            this.MotherNameBox.Size = new System.Drawing.Size(222, 20);
            this.MotherNameBox.TabIndex = 3;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(120, 171);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(222, 20);
            this.PhoneNumber.TabIndex = 6;
            // 
            // EmailAddress
            // 
            this.EmailAddress.Location = new System.Drawing.Point(120, 198);
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Size = new System.Drawing.Size(222, 20);
            this.EmailAddress.TabIndex = 7;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(120, 9);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(222, 20);
            this.FirstNameBox.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = "Education degree";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "Email address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "Experince years";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "PhoneNumber";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "BirthDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Mother name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Father name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "First name";
            // 
            // EmployeeViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 448);
            this.Controls.Add(this.RolesCombobox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ExperinceYearsCounter);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.BirthDatepicker);
            this.Controls.Add(this.AssignProjectToEmployeeBtn);
            this.Controls.Add(this.ProjectsComboBox);
            this.Controls.Add(this.EducationalDegreesComboBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveEmployeeBtn);
            this.Controls.Add(this.EmployeeProfilePicture);
            this.Controls.Add(this.EmployeeProjectsList);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FatherNameBox);
            this.Controls.Add(this.MotherNameBox);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.EmailAddress);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeViewer";
            this.Text = "EmployeeViewer";
            ((System.ComponentModel.ISupportInitialize)(this.ExperinceYearsCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RolesCombobox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown ExperinceYearsCounter;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.DateTimePicker BirthDatepicker;
        private System.Windows.Forms.Button AssignProjectToEmployeeBtn;
        private System.Windows.Forms.ComboBox ProjectsComboBox;
        private System.Windows.Forms.ComboBox EducationalDegreesComboBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveEmployeeBtn;
        private System.Windows.Forms.PictureBox EmployeeProfilePicture;
        private System.Windows.Forms.ListBox EmployeeProjectsList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox FatherNameBox;
        private System.Windows.Forms.TextBox MotherNameBox;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox EmailAddress;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}