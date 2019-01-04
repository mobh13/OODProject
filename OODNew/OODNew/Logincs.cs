using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace OODNew
{
    public partial class Logincs : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;
        public Logincs()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtboxUsername.Text == "" || txtboxPassword.Text == "")
            {
                MessageBox.Show("Error Please Fill the username and the password");
            }
            else
            {
                string username = txtboxUsername.Text;
                string password = txtboxPassword.Text;

                Program.Connection.Open();
                 command = Program.Connection.CreateCommand();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@username", username);
                command.CommandText = "Select Count(*) From [User] where Username = @username";
                 reader = command.ExecuteReader();
                 reader.Read();
                if (Convert.ToInt32(reader.GetValue(0)) == 1)
                {
                    reader.Close();
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@username", username);
                    command.CommandText = "Select * From [User] where Username = @username";
                    reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.GetValue(7).ToString() == password)
                    {
                        Program.UserInfo.Id = reader.GetValue(0).ToString();
                        Program.UserInfo.Name = reader.GetValue(1).ToString();
                        Program.UserInfo.Username = reader.GetValue(6).ToString(); ;
                        Program.UserInfo.Password = reader.GetValue(7).ToString();
                        Program.UserInfo.Email = reader.GetValue(3).ToString(); ;
                        Program.UserInfo.CPR = reader.GetValue(10).ToString(); ;
                        Program.UserInfo.Dob = reader.GetValue(2).ToString(); ;
                        Program.UserInfo.Role_id = reader.GetValue(8).ToString(); ;
                        Program.UserInfo.Phone = reader.GetValue(4).ToString(); ;
                        Program.UserInfo.Address = reader.GetValue(5).ToString(); ;
                        Program.UserInfo.Commision = reader.GetValue(9).ToString(); ;
                        reader.Close();
                        Program.Connection.Close();
                        ControlPanel controlPanel = new ControlPanel();
                        controlPanel.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error password is wrong");
                        reader.Close();
                        Program.Connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Error no iser was found");
                    MessageBox.Show("Error no user was found");
                    reader.Close();
                    Program.Connection.Close();
                }
               
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Logincs_Load(object sender, EventArgs e)
        {
          
        }
    }
}
