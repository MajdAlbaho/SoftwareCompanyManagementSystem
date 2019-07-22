using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SoftwareCompanyManagementSystem.Model;
using System.IO;
using System.Data.SqlClient;
using SoftwareCompanyManagementSystem.Connection;

namespace SoftwareCompanyManagementSystem.EmployeeManagement
{
    public partial class EmployeeViewer : Form
    {
        public EmployeeViewer()
        {
            InitializeComponent();
        }

        private List<Genders> genders = StaticData.GetGenders();
        private List<EducationDegreeModel> educationalDegrees { get; set; }

        public OperaionType Operation { get; set; }
        public bool UpdatedUserNameAndPassword { get; set; }

        public Guid userId { get; set; }
        public Guid employeeId { get; set; }

        public void Fill(EmployeeModel employee)
        {
            this.employeeId = employee.Id;
            this.userId = employee.UserId;

            this.FirstNameBox.Text = employee.FirstName;
            this.LastNameBox.Text = employee.LastName;
            this.FatherNameBox.Text = employee.FatherName;
            this.MotherNameBox.Text = employee.MotherName;
            this.BirthDatepicker.Value = employee.BirthDate;
            if (employee.Gender)
                this.GenderComboBox.SelectedValue = 1;
            else
                this.GenderComboBox.SelectedValue = 0;
            this.PhoneNumber.Text = employee.PhoneNumber;
            this.EmailAddress.Text = employee.EmailAddress;
            this.ExperinceYearsCounter.Value = employee.ExperinceYear;
            this.EducationalDegreesComboBox.SelectedItem =
                EducationalDegreesComboBox.Items[employee.EducationDegreeId];
            this.RolesCombobox.SelectedItem =
                RolesCombobox.Items[employee.UserRoleId];

            byte[] image = employee.PersonalPhoto;
            var memoryStream = new MemoryStream(image);
            memoryStream.Seek(0, SeekOrigin.Begin);
            this.EmployeeProfilePicture.Image = Image.FromStream(memoryStream);

            this.userNameBox.Text = "majd";
            this.PasswordBox.Text = "******";

            using (var db = new SqlConnection(ConnectionManager.ConnectionString))
            {
                var cmd = new SqlCommand("SELECT * FROM dbo.Projects INNER JOIN dbo.EmployeeProjects ON EmployeeProjects.ProjectId = Projects.Id WHERE EmployeeId = '" + employee.Id + "'");
                cmd.Connection = db;
                db.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EmployeeProjectsList.Items.Add(new ProjectModel()
                    {
                        Id = (Guid)reader["Id"],
                        ProjectName = (string)reader["ProjectName"]
                    });
                }
            }
        }

        public void Initialize()
        {
            GenderComboBox.DataSource = genders;
            ExperinceYearsCounter.Minimum = 0;

            using (var db = new SqlConnection(ConnectionManager.ConnectionString))
            {
                var cmd = new SqlCommand("SELECT * FROM dbo.EducationDegrees");
                cmd.Connection = db;
                db.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var item = new EducationDegreeModel()
                    {
                        Id = (int)reader["Id"],
                        EnName = (string)reader["EnName"],
                        ArName = (string)reader["ArName"],
                    };

                    EducationalDegreesComboBox.Items.Add(item);
                }
                reader.Close();

                cmd = new SqlCommand("SELECT * FROM dbo.Projects");
                cmd.Connection = db;
                var projects = cmd.ExecuteReader();
                while (projects.Read())
                {
                    ProjectsComboBox.Items.Add(new ProjectModel()
                    {
                        Id = (Guid)projects["Id"],
                        ProjectName = (string)projects["ProjectName"]
                    });
                }
                projects.Close();

                cmd = new SqlCommand("SELECT * FROM dbo.Roles");
                cmd.Connection = db;
                var roles = cmd.ExecuteReader();
                while (roles.Read())
                {
                    RolesCombobox.Items.Add(new RoleModel()
                    {
                        Id = (int)roles["Id"],
                        EnName = (string)roles["EnName"],
                        ArName = (string)roles["ArName"]
                    });
                }
                roles.Close();
            }
        }

        private void AssignProjectToEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (ProjectsComboBox.SelectedItem == null)
            {
                MessageBox.Show("الرجاء اختيار مشروع");
                return;
            }

            EmployeeProjectsList.Items.Add(ProjectsComboBox.SelectedItem);
        }

        private void EmployeeProfilePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "image files|*.jpg;*.png;*.gif;*.icon;.*;";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                EmployeeProfilePicture.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void SaveEmployeeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(FirstNameBox.Text) ||
                            string.IsNullOrWhiteSpace(LastNameBox.Text) ||
                            string.IsNullOrWhiteSpace(MotherNameBox.Text) ||
                            string.IsNullOrWhiteSpace(FatherNameBox.Text) ||
                            GenderComboBox.SelectedItem == null || EducationalDegreesComboBox.SelectedItem == null ||
                            string.IsNullOrWhiteSpace(userNameBox.Text) ||
                            string.IsNullOrWhiteSpace(PasswordBox.Text) || RolesCombobox.SelectedItem == null ||
                    EmployeeProfilePicture.Image == null)
                {
                    MessageBox.Show("الرجاء ملئ الحقول المطلوبة");
                    return;
                }

                if (Operation == OperaionType.Add)
                {
                    using (var db = new SqlConnection(ConnectionManager.ConnectionString))
                    {
                        if (!CheckExistUserName(userNameBox.Text))
                            return;

                        db.Open();
                        Guid userId = Guid.NewGuid();
                        var cmd = new SqlCommand("INSERT INTO dbo.Users (Id,UserName,Password,RoleId) " +
                            "VALUES ('" + userId + "','" + userNameBox.Text + "','" + PasswordBox.Text + "','" + ((RoleModel)RolesCombobox.SelectedItem).Id + "')");
                        cmd.Connection = db;
                        cmd.ExecuteNonQuery();

                        Guid employeeId = Guid.NewGuid();
                        var imageBinary = StaticData.ConvertImageToBinary(EmployeeProfilePicture.Image);
                        cmd = new SqlCommand("INSERT INTO dbo.Employees "
                            + "VALUES('" + employeeId + "','" + FirstNameBox.Text + "','" + LastNameBox.Text + "','" + FatherNameBox.Text + "','" +
                            MotherNameBox.Text + "',@Date,'" + ((Genders)GenderComboBox.SelectedItem).Id + "','" +
                            PhoneNumber.Text + "','" + EmailAddress.Text + "',@image," + ExperinceYearsCounter.Value + ",'" + userId + "'," +
                            ((EducationDegreeModel)EducationalDegreesComboBox.SelectedItem).Id + ")");
                        cmd.Parameters.Add("@Date", SqlDbType.Date).Value = BirthDatepicker.Value.Date;
                        cmd.Parameters.Add("@image", SqlDbType.Image).Value = imageBinary;
                        cmd.Connection = db;
                        cmd.ExecuteNonQuery();

                        if (EmployeeProjectsList.Items.Count > 0)
                        {
                            foreach (ProjectModel item in EmployeeProjectsList.Items)
                            {
                                cmd = new SqlCommand("INSERT INTO dbo.EmployeeProjects values ('" + employeeId + "','" + item.Id + "')");
                                cmd.Connection = db;
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("تمت اضافة الموظف بنجاح");
                    this.Close();
                }
                else
                {
                    using (var db = new SqlConnection(ConnectionManager.ConnectionString))
                    {
                        db.Open();

                        if (UpdatedUserNameAndPassword)
                        {
                            if (!CheckExistUserName(userNameBox.Text))
                                return;

                            var cmd = new SqlCommand("UPDATE dbo.Users SET userName = '"
                                + userNameBox.Text + "', Password = '" + PasswordBox.Text + "', RoleId = " +
                                ((RoleModel)RolesCombobox.SelectedItem).Id + " where Id = '" + userId + "'");
                            cmd.Connection = db;
                            cmd.ExecuteNonQuery();
                        }

                        var imageBinary = StaticData.ConvertImageToBinary(EmployeeProfilePicture.Image);
                        var command = new SqlCommand("UPDATE dbo.Employees "
                            + "SET FirstName = '" + FirstNameBox.Text + "',LastName = '" + LastNameBox.Text + "',FatherName = '" + FatherNameBox.Text + "',MotherName = '" +
                            MotherNameBox.Text + "',BirthDate = @Date,Gender = '" + ((Genders)GenderComboBox.SelectedItem).Id + "',PhoneNumber = '" +
                            PhoneNumber.Text + "',EmailAddress = '" + EmailAddress.Text + "',PersonalPhoto = @image,ExperinceYears = " + ExperinceYearsCounter.Value + ",EducationDegreeId = " +
                            ((EducationDegreeModel)EducationalDegreesComboBox.SelectedItem).Id + " where Id = '" + employeeId + "'");
                        command.Parameters.Add("@Date", SqlDbType.Date).Value = BirthDatepicker.Value.Date;
                        command.Parameters.Add("@image", SqlDbType.Image).Value = imageBinary;
                        command.Connection = db;
                        command.ExecuteNonQuery();

                        command = new SqlCommand("Delete from EmployeeProjects where EmployeeId = '" + employeeId + "'");
                        command.Connection = db;
                        command.ExecuteNonQuery();

                        if (EmployeeProjectsList.Items.Count > 0)
                        {
                            foreach (ProjectModel item in EmployeeProjectsList.Items)
                            {
                                var cmd = new SqlCommand("INSERT INTO dbo.EmployeeProjects values ('" + employeeId + "','" + item.Id + "')");
                                cmd.Connection = db;
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("تمت تعديل الموظف بنجاح");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckExistUserName(string userName)
        {
            using (var db = new SqlConnection(ConnectionManager.ConnectionString))
            {
                var cmd = new SqlCommand("SELECT UserName FROM dbo.Users " +
                                    "WHERE UserName = '" + userName + "'");
                cmd.Connection = db;
                db.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("يوجد مستخدم بهذا الاسم الرجاء اختيار اسم مستخدم اخر");
                    reader.Close();
                    return false;
                }
                reader.Close();
                return true;
            }
        }

        private void userNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            UpdatedUserNameAndPassword = true;
        }
    }
}
