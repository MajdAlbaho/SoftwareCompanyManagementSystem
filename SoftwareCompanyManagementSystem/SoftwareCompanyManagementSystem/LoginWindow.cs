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

namespace SoftwareCompanyManagementSystem
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(userNameBox.Text) ||
                string.IsNullOrWhiteSpace(passwordBox.Text))
                {
                    MessageBox.Show("الرجاء ادخال اسم المستخدم وكلمة المرور");
                    return;
                }

                using (var db = new SqlConnection(ConnectionManager.ConnectionString))
                {
                    var cmd = new SqlCommand("SELECT Users.Id,UserName,RoleId,EnName as RoleName FROM dbo.Users " +
                        "INNER JOIN dbo.Roles ON Roles.Id = Users.RoleId " +
                        "WHERE UserName = '" + userNameBox.Text
                        + "' AND Password = '" + passwordBox.Text + "'");
                    cmd.Connection = db;
                    db.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        StaticData.LoggedUser = new Model.UserModel()
                        {
                            Id = (Guid)reader["Id"],
                            UserName = (string)reader["UserName"],
                            RoleId = (int)reader["RoleId"],
                            RoleName = (string)reader["RoleName"]
                        };

                        this.Visible = false;
                        new HomeWindow().Show();
                        return;
                    }
                }

                MessageBox.Show("خطأ في اسم المستخدم او كلمة المرور");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
