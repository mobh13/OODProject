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
namespace OOD_Forms_Application
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
                command.CommandText = "Select Count(*) From User where Username = @username";
                 reader = command.ExecuteReader();
                 reader.Read();
                if (Convert.ToInt32(reader.GetValue(0)) == 1)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@username", username);
                    command.CommandText = "Select * From User where Username = @username";
                    reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.GetValue(7).ToString() == password)
                    {
                        ControlPanel controlPanel = new ControlPanel();
                        controlPanel.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error password is wrong");

                    }
                }
                reader.Close();
                Program.Connection.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
