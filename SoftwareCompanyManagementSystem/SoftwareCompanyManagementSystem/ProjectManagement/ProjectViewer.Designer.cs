namespace SoftwareCompanyManagementSystem.ProjectManagement
{
    partial class ProjectViewer
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
            this.AssignEmployeeToProjectButton = new System.Windows.Forms.Button();
            this.CollobratorComboBox = new System.Windows.Forms.ComboBox();
            this.ProjectEmployeesList = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TypesComboBox = new System.Windows.Forms.ComboBox();
            this.ProgLanguagesComboBox = new System.Windows.Forms.ComboBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.SaveProject = new System.Windows.Forms.Button();
            this.deliverDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.ProjectNameBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AssignEmployeeToProjectButton
            // 
            this.AssignEmployeeToProjectButton.Location = new System.Drawing.Point(313, 176);
            this.AssignEmployeeToProjectButton.Name = "AssignEmployeeToProjectButton";
            this.AssignEmployeeToProjectButton.Size = new System.Drawing.Size(64, 23);
            this.AssignEmployeeToProjectButton.TabIndex = 7;
            this.AssignEmployeeToProjectButton.Text = "Assign";
            this.AssignEmployeeToProjectButton.UseVisualStyleBackColor = true;
            this.AssignEmployeeToProjectButton.Click += new System.EventHandler(this.AssignEmployeeToProjectButton_Click);
            // 
            // CollobratorComboBox
            // 
            this.CollobratorComboBox.DisplayMember = "FirstName";
            this.CollobratorComboBox.FormattingEnabled = true;
            this.CollobratorComboBox.Location = new System.Drawing.Point(155, 177);
            this.CollobratorComboBox.Name = "CollobratorComboBox";
            this.CollobratorComboBox.Size = new System.Drawing.Size(152, 21);
            this.CollobratorComboBox.TabIndex = 6;
            // 
            // ProjectEmployeesList
            // 
            this.ProjectEmployeesList.DisplayMember = "FirstName";
            this.ProjectEmployeesList.FormattingEnabled = true;
            this.ProjectEmployeesList.Location = new System.Drawing.Point(155, 205);
            this.ProjectEmployeesList.Name = "ProjectEmployeesList";
            this.ProjectEmployeesList.Size = new System.Drawing.Size(222, 108);
            this.ProjectEmployeesList.TabIndex = 99;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(78, 181);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 78;
            this.label19.Text = "Collobrator";
            // 
            // TypesComboBox
            // 
            this.TypesComboBox.DisplayMember = "Type";
            this.TypesComboBox.FormattingEnabled = true;
            this.TypesComboBox.Location = new System.Drawing.Point(155, 66);
            this.TypesComboBox.Name = "TypesComboBox";
            this.TypesComboBox.Size = new System.Drawing.Size(222, 21);
            this.TypesComboBox.TabIndex = 2;
            // 
            // ProgLanguagesComboBox
            // 
            this.ProgLanguagesComboBox.DisplayMember = "Name";
            this.ProgLanguagesComboBox.FormattingEnabled = true;
            this.ProgLanguagesComboBox.Location = new System.Drawing.Point(155, 38);
            this.ProgLanguagesComboBox.Name = "ProgLanguagesComboBox";
            this.ProgLanguagesComboBox.Size = new System.Drawing.Size(222, 21);
            this.ProgLanguagesComboBox.TabIndex = 1;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(391, 323);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SaveProject
            // 
            this.SaveProject.Location = new System.Drawing.Point(310, 323);
            this.SaveProject.Name = "SaveProject";
            this.SaveProject.Size = new System.Drawing.Size(75, 23);
            this.SaveProject.TabIndex = 8;
            this.SaveProject.Text = "Save";
            this.SaveProject.UseVisualStyleBackColor = true;
            this.SaveProject.Click += new System.EventHandler(this.SaveProject_Click);
            // 
            // deliverDatePicker
            // 
            this.deliverDatePicker.CustomFormat = "dd/MM/yyyy";
            this.deliverDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deliverDatePicker.Location = new System.Drawing.Point(155, 147);
            this.deliverDatePicker.Name = "deliverDatePicker";
            this.deliverDatePicker.Size = new System.Drawing.Size(222, 20);
            this.deliverDatePicker.TabIndex = 5;
            // 
            // startDatePicker
            // 
            this.startDatePicker.CustomFormat = "dd/MM/yyyy";
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(155, 120);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(222, 20);
            this.startDatePicker.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(73, 150);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 71;
            this.label18.Text = "Deliver date";
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(155, 93);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(222, 20);
            this.customerName.TabIndex = 3;
            // 
            // ProjectNameBox
            // 
            this.ProjectNameBox.Location = new System.Drawing.Point(155, 12);
            this.ProjectNameBox.Name = "ProjectNameBox";
            this.ProjectNameBox.Size = new System.Drawing.Size(222, 20);
            this.ProjectNameBox.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(82, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 68;
            this.label13.Text = "Start date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(56, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 67;
            this.label14.Text = "Customer name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(107, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 66;
            this.label15.Text = "Type";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 13);
            this.label16.TabIndex = 65;
            this.label16.Text = "Programming language";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(68, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 64;
            this.label17.Text = "Project name";
            // 
            // ProjectViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 354);
            this.Controls.Add(this.AssignEmployeeToProjectButton);
            this.Controls.Add(this.CollobratorComboBox);
            this.Controls.Add(this.ProjectEmployeesList);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.TypesComboBox);
            this.Controls.Add(this.ProgLanguagesComboBox);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SaveProject);
            this.Controls.Add(this.deliverDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.ProjectNameBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Name = "ProjectViewer";
            this.Text = "ProjectViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AssignEmployeeToProjectButton;
        private System.Windows.Forms.ComboBox CollobratorComboBox;
        private System.Windows.Forms.ListBox ProjectEmployeesList;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox TypesComboBox;
        private System.Windows.Forms.ComboBox ProgLanguagesComboBox;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button SaveProject;
        private System.Windows.Forms.DateTimePicker deliverDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.TextBox ProjectNameBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}