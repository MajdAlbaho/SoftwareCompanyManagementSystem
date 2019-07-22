using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SoftwareCompanyManagementSystem.EmployeeManagement;
using System.IO;
using SoftwareCompanyManagementSystem.Model;
using SoftwareCompanyManagementSystem.Connection;
using System.Data.SqlClient;
using SoftwareCompanyManagementSystem.ProjectManagement;

namespace SoftwareCompanyManagementSystem
{
    public partial class HomeWindow : Form
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        List<EmployeeModel> employees = new List<EmployeeModel>();

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var employeeViewer = new EmployeeViewer();
                employeeViewer.Initialize();
                employeeViewer.Operation = OperaionType.Add;
                employeeViewer.ShowDialog();

                HomeWindow_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditEmployeeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var employeeViewer = new EmployeeViewer();
                employeeViewer.Initialize();
                employeeViewer.Fill((EmployeeModel)employeesList.SelectedItem);
                employeeViewer.Operation = OperaionType.Edit;
                employeeViewer.ShowDialog();

                HomeWindow_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (employeesList.SelectedItem == null)
                    return;

                DialogResult dialogResult = MessageBox.Show("Are you sure ?",
                    "Are you sure you want to delete selected employee",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (var db = new SqlConnection(ConnectionManager.ConnectionString))
                    {
                        var cmd = new SqlCommand("Delete from dbo.users where Id = '" +
                            ((EmployeeModel)employeesList.SelectedItem).UserId + "'");
                        cmd.Connection = db;
                        db.Open();
                        cmd.ExecuteNonQuery();

                        HomeWindow_Load(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HomeWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void employeesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (EmployeeModel)employeesList.SelectedItem;
                if (selectedItem == null)
                    return;

                FirstNameBox.Text = selectedItem.FirstName;
                LastNameBox.Text = selectedItem.LastName;
                FatherNameBox.Text = selectedItem.FatherName;
                MotherNameBox.Text = selectedItem.MotherName;
                BirthDateBox.Text = selectedItem.BirthDate.ToShortDateString();
                GenderBox.Text = selectedItem.Gender ? "Male" : "Female";
                PhoneNumber.Text = selectedItem.PhoneNumber;
                EmailAddress.Text = selectedItem.EmailAddress;
                ExperinceYearBox.Text = selectedItem.ExperinceYear.ToString();
                EducationalDegreeBox.Text = selectedItem.EducationDegreeName;

                byte[] imageArray = selectedItem.PersonalPhoto.ToArray();
                MemoryStream stream = new MemoryStream(imageArray);
                stream.Seek(0, SeekOrigin.Begin);
                EmployeeProfilePicture.Image = Image.FromStream(stream);

                EmployeeProjectsList.Items.Clear();
                using (var db = new SqlConnection(ConnectionManager.ConnectionString))
                {
                    var cmd = new SqlCommand("SELECT DISTINCT Projects.Id,Projects.ProjectName FROM dbo.Projects INNER JOIN dbo.EmployeeProjects ON EmployeeProjects.ProjectId = Projects.Id WHERE EmployeeId = '" + selectedItem.Id + "'");
                    cmd.Connection = db;
                    db.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        EmployeeProjectsList.Items.Add((string)reader["ProjectName"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HomeWindow_Load(object sender, EventArgs e)
        {
            try
            {
                if (StaticData.LoggedUser.RoleName == "Employee")
                {
                    BaseTabControl.TabPages.Remove(EmployeeManagementTab);
                    BaseTabControl.TabPages.Remove(ProjectsManagementTab);
                }

                loggedUserName.Text = StaticData.LoggedUser.UserName;

                using (var db = new SqlConnection(ConnectionManager.ConnectionString))
                {
                    var cmd = new SqlCommand("SELECT Employees.Id,FirstName,LastName,FatherName,MotherName,BirthDate,Gender,PhoneNumber,EmailAddress,PersonalPhoto,ExperinceYears,UserId,EducationDegreeId,RoleId,EnName FROM dbo.Employees INNER JOIN dbo.EducationDegrees ON EducationDegrees.Id = Employees.EducationDegreeId INNER JOIN dbo.Users ON Users.Id = Employees.UserId");
                    cmd.Connection = db;
                    db.Open();
                    var reader = cmd.ExecuteReader();
                    employeesList.Items.Clear();
                    employees = new List<EmployeeModel>();
                    while (reader.Read())
                    {
                        var empl = new EmployeeModel()
                        {
                            Id = (Guid)reader["Id"],
                            FirstName = (string)reader["FirstName"],
                            LastName = (string)reader["LastName"],
                            FatherName = (string)reader["FatherName"],
                            MotherName = (string)reader["MotherName"],
                            BirthDate = (DateTime)reader["BirthDate"],
                            Gender = (bool)reader["Gender"],
                            PhoneNumber = (string)reader["PhoneNumber"],
                            EmailAddress = (string)reader["EmailAddress"],
                            PersonalPhoto = (byte[])reader["PersonalPhoto"],
                            ExperinceYear = (int)reader["ExperinceYears"],
                            UserId = (Guid)reader["UserId"],
                            EducationDegreeId = (int)reader["EducationDegreeId"],
                            UserRoleId = (int)reader["RoleId"],
                            EducationDegreeName = (string)reader["EnName"]
                        };

                        employeesList.Items.Add(empl);
                        employees.Add(empl);
                    }
                    reader.Close();

                    cmd = new SqlCommand("SELECT DISTINCT Projects.*,Name,Type FROM dbo.Projects INNER JOIN dbo.ProgrammingLanguages ON ProgrammingLanguages.Id = Projects.ProgrammingLanguageId INNER JOIN dbo.ProjectTypes ON ProjectTypes.Id = Projects.ProjectTypeId");
                    cmd.Connection = db;
                    var projectsReader = cmd.ExecuteReader();
                    ProjectsList.Items.Clear();
                    while (projectsReader.Read())
                    {
                        ProjectsList.Items.Add(new ProjectModel()
                        {
                            Id = (Guid)projectsReader["Id"],
                            ProjectName = (string)projectsReader["ProjectName"],
                            ProgrammingLanguageId = (int)projectsReader["ProgrammingLanguageId"],
                            ProjectTypeId = (int)projectsReader["ProjectTypeId"],
                            CustomerName = (string)projectsReader["CustomerName"],
                            StartDate = (DateTime)projectsReader["StartDate"],
                            DeliverDate = (DateTime)projectsReader["DeliverDate"],
                            ProjectLanguageName = (string)projectsReader["Name"],
                            ProjectTypeName = (string)projectsReader["Type"]
                        });

                    }
                    projectsReader.Close();


                    cmd = new SqlCommand("SELECT Projects.Id,ProjectName FROM dbo.Projects INNER JOIN dbo.EmployeeProjects ON EmployeeProjects.ProjectId = Projects.Id INNER JOIN dbo.Employees ON Employees.Id = EmployeeProjects.EmployeeId WHERE UserId = '" + StaticData.LoggedUser.Id + "'");
                    cmd.Connection = db;
                    var employeeProjectReader = cmd.ExecuteReader();
                    EmployeeProjectList.Items.Clear();
                    while (employeeProjectReader.Read())
                    {
                        EmployeeProjectList.Items.Add(new ProjectModel()
                        {
                            Id = (Guid)employeeProjectReader["Id"],
                            ProjectName = (string)employeeProjectReader["ProjectName"]
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddProjectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var viewer = new ProjectViewer();
                viewer.Initialize(employees);
                viewer.Operation = OperaionType.Add;
                viewer.ShowDialog();

                HomeWindow_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProjectsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (ProjectModel)ProjectsList.SelectedItem;
            if (selectedItem == null)
                return;

            this.ProjectNameBox.Text = selectedItem.ProjectName;
            this.ProjectTypeBox.Text = selectedItem.ProjectTypeName;
            this.ProgLanguageBox.Text = selectedItem.ProjectLanguageName;
            this.CustomerNameBox.Text = selectedItem.CustomerName;
            this.startDatePicker.Text = selectedItem.StartDate.ToShortDateString();
            this.DeliverDatePicker.Text = selectedItem.DeliverDate.ToShortDateString();

            using (var db = new SqlConnection(ConnectionManager.ConnectionString))
            {
                var cmd = new SqlCommand("SELECT * FROM dbo.EmployeeProjects INNER JOIN dbo.Employees ON Employees.Id = EmployeeProjects.EmployeeId WHERE ProjectId = '" + selectedItem.Id + "'");
                cmd.Connection = db;
                db.Open();
                var reader = cmd.ExecuteReader();
                ProjectEmployeesList.Items.Clear();
                while (reader.Read())
                {
                    ProjectEmployeesList.Items.Add(new EmployeeModel()
                    {
                        Id = (Guid)reader["Id"],
                        FirstName = (string)reader["FirstName"]
                    });
                }
            }
        }

        private void EditProjectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (ProjectModel)ProjectsList.SelectedItem;
                if (selectedItem == null)
                    return;

                var projectViewer = new ProjectViewer();
                projectViewer.Initialize(employees);
                projectViewer.Fill(selectedItem);
                projectViewer.Operation = OperaionType.Edit;
                projectViewer.ShowDialog();

                HomeWindow_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteProjectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProjectsList.SelectedItem == null)
                    return;

                DialogResult dialogResult = MessageBox.Show("Are you sure ?",
                    "Are you sure you want to delete selected project",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (var db = new SqlConnection(ConnectionManager.ConnectionString))
                    {
                        var cmd = new SqlCommand("Delete from dbo.projects where Id = '" +
                            ((ProjectModel)ProjectsList.SelectedItem).Id + "'");
                        cmd.Connection = db;
                        db.Open();
                        cmd.ExecuteNonQuery();

                        HomeWindow_Load(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmployeeProjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CommentsListView.Items.Clear();

                var selectedItem = (ProjectModel)EmployeeProjectList.SelectedItem;
                if (selectedItem == null)
                    return;

                using (var db = new SqlConnection(ConnectionManager.ConnectionString))
                {
                    var cmd = new SqlCommand("SELECT Comment,UserName FROM dbo.ProjectComments INNER JOIN dbo.EmployeeProjects ON EmployeeProjects.ProjectId = ProjectComments.ProjectId INNER JOIN dbo.Employees ON Employees.Id = EmployeeProjects.EmployeeId INNER JOIN dbo.Users ON Users.Id = ProjectComments.UserId WHERE Employees.UserId = '" + StaticData.LoggedUser.Id + "' AND ProjectComments.ProjectId = '" + selectedItem.Id + "' order by createdDate desc");
                    cmd.Connection = db;
                    db.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string comment = (string)reader["UserName"] + "  :  " + (string)reader["Comment"];
                        CommentsListView.Items.Add(comment);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SendCommentButton_Click(object sender, EventArgs e)
        {
            var selectedItem = (ProjectModel)EmployeeProjectList.SelectedItem;
            if (selectedItem == null || string.IsNullOrWhiteSpace(CommentBox.Text))
                return;

            using (var db = new SqlConnection(ConnectionManager.ConnectionString))
            {
                var cmd = new SqlCommand("INSERT INTO dbo.ProjectComments (Id,ProjectId,Comment,UserId) values (NEWID(),'" +
                    selectedItem.Id + "','" + CommentBox.Text + "','" +
                    StaticData.LoggedUser.Id + "')");
                cmd.Connection = db;
                db.Open();
                var reader = cmd.ExecuteNonQuery();

                CommentsListView.Items.Insert(0, StaticData.LoggedUser.UserName + " : " + CommentBox.Text);
            }
        }
    }
}
