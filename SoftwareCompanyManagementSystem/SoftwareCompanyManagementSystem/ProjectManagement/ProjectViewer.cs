using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SoftwareCompanyManagementSystem.Connection;
using SoftwareCompanyManagementSystem.Model;

namespace SoftwareCompanyManagementSystem.ProjectManagement
{
    public partial class ProjectViewer : Form
    {
        public ProjectViewer()
        {
            InitializeComponent();
        }

        public OperaionType Operation { get; set; }
        public Guid projectId { get; set; }

        public void Initialize(List<EmployeeModel> employees)
        {
            foreach (var employee in employees)
            {
                CollobratorComboBox.Items.Add(employee);
            }

            using (var db = new SqlConnection(ConnectionManager.ConnectionString))
            {
                var cmd = new SqlCommand("SELECT * FROM dbo.ProgrammingLanguages");
                cmd.Connection = db;
                db.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ProgLanguagesComboBox.Items.Add(new ProgrammingLanguageModel()
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"]
                    });
                }
                reader.Close();

                cmd = new SqlCommand("SELECT * FROM dbo.ProjectTypes");
                cmd.Connection = db;
                var projects = cmd.ExecuteReader();
                while (projects.Read())
                {
                    TypesComboBox.Items.Add(new ProjectTypeModel()
                    {
                        Id = (int)projects["Id"],
                        Type = (string)projects["Type"]
                    });
                }
                projects.Close();
            }
        }

        private void AssignEmployeeToProjectButton_Click(object sender, EventArgs e)
        {
            if (CollobratorComboBox.SelectedItem == null)
                return;

            ProjectEmployeesList.Items.Add(CollobratorComboBox.SelectedItem);
        }

        private void SaveProject_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ProjectNameBox.Text) || ProgLanguagesComboBox.SelectedItem == null ||
                TypesComboBox.SelectedItem == null)
                {
                    MessageBox.Show("الرجاء ملئ الحقول المطلوبة");
                    return;
                }

                if (Operation == OperaionType.Add)
                {
                    using (var db = new SqlConnection(ConnectionManager.ConnectionString))
                    {
                        db.Open();
                        var projectId = Guid.NewGuid();
                        var cmd = new SqlCommand("INSERT INTO dbo.Projects values ('" + projectId + "','" + ProjectNameBox.Text + "'," +
                            ((ProgrammingLanguageModel)ProgLanguagesComboBox.SelectedItem).Id + "," +
                            ((ProjectTypeModel)TypesComboBox.SelectedItem).Id + ",'" + customerName.Text +
                            "',@startDate,@DeliverDate)");
                        cmd.Parameters.Add("@startDate", SqlDbType.Date).Value = startDatePicker.Value.Date;
                        cmd.Parameters.Add("@DeliverDate", SqlDbType.Date).Value = deliverDatePicker.Value.Date;
                        cmd.Connection = db;
                        cmd.ExecuteNonQuery();

                        if (ProjectEmployeesList.Items.Count > 0)
                        {
                            foreach (var employee in ProjectEmployeesList.Items)
                            {
                                cmd = new SqlCommand("INSERT INTO dbo.EmployeeProjects values ('" + ((EmployeeModel)employee).Id
                                    + "','" + projectId + "')");
                                cmd.Connection = db;
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("تمت اضافة المشروع بنجاح");
                        this.Close();
                    }
                }
                else
                {
                    using (var db = new SqlConnection(ConnectionManager.ConnectionString))
                    {
                        db.Open();
                        var cmd = new SqlCommand("Update dbo.Projects set ProjectName = '" + ProjectNameBox.Text + "', ProgrammingLanguageId = " +
                            ((ProgrammingLanguageModel)ProgLanguagesComboBox.SelectedItem).Id + ", ProjectTypeId = '" +
                            ((ProjectTypeModel)TypesComboBox.SelectedItem).Id + "',CustomerName = '" + customerName.Text +
                            "',StartDate = @startDate,DeliverDate = @DeliverDate where Id = '" + projectId + "'");
                        cmd.Parameters.Add("@startDate", SqlDbType.Date).Value = startDatePicker.Value.Date;
                        cmd.Parameters.Add("@DeliverDate", SqlDbType.Date).Value = deliverDatePicker.Value.Date;
                        cmd.Connection = db;
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("Delete from dbo.EmployeeProjects where ProjectId = '" + projectId + "'");
                        cmd.Connection = db;
                        cmd.ExecuteNonQuery();

                        if (ProjectEmployeesList.Items.Count > 0)
                        {
                            foreach (var employee in ProjectEmployeesList.Items)
                            {
                                cmd = new SqlCommand("INSERT INTO dbo.EmployeeProjects values ('" + ((EmployeeModel)employee).Id
                                    + "','" + projectId + "')");
                                cmd.Connection = db;
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("تم تعديل المشروع بنجاح");
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Fill(ProjectModel project)
        {
            this.projectId = project.Id;
            this.ProjectNameBox.Text = project.ProjectName;
            this.ProgLanguagesComboBox.SelectedItem =
                ProgLanguagesComboBox.Items[project.ProgrammingLanguageId];
            this.TypesComboBox.SelectedItem =
                TypesComboBox.Items[project.ProjectTypeId];
            this.customerName.Text = project.CustomerName;
            this.deliverDatePicker.Text = project.DeliverDate.ToShortDateString();
            this.startDatePicker.Text = project.StartDate.ToShortDateString();

            using (var db = new SqlConnection(ConnectionManager.ConnectionString))
            {
                var cmd = new SqlCommand("SELECT * FROM dbo.EmployeeProjects INNER JOIN dbo.Employees ON Employees.Id = EmployeeProjects.EmployeeId WHERE ProjectId = '" + project.Id + "'");
                cmd.Connection = db;
                db.Open();
                var reader = cmd.ExecuteReader();
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

    }
}
