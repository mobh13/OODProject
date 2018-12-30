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
    public partial class ProfileView : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;
        public ProfileView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ProfileView_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            Program.Connection.Open();
            command = Program.Connection.CreateCommand();
            command.CommandText = "Select * From User";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetValue(0).ToString());
            }
           cmbProfiles.DataSource = list;
           cmbProfiles.SelectedIndex = -1;
            reader.Close();
            Program.Connection.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void lblCommission_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void cmbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cmbProfiles.SelectedText;
            Program.Connection.Open();
            command = Program.Connection.CreateCommand();
            command.Parameters.Clear();
            command.Parameters.AddWithValue("id", id);
            command.CommandText = "Select * From User where id = @id";
            reader = command.ExecuteReader();
            txtName.Text = reader.GetValue(1).ToString();
            txtEmail.Text = reader.GetValue(3).ToString();
                 txtUsername.Text = reader.GetValue(6).ToString();
                txtPassword.Text = reader.GetValue(7).ToString();
                txtCPR.Text = reader.GetValue(10).ToString();
                txtAddress.Text = reader.GetValue(5).ToString();
                txtPhone.Text = reader.GetValue(4).ToString();
                txtCommission.Text = reader.GetValue(9).ToString();
                txtDOB.Text = reader.GetValue(2).ToString();
                reader.Close();
                string roleID = reader.GetValue(8).ToString();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("id", roleID);
                command.CommandText = "Select * From Role where role_id = @id";
                reader = command.ExecuteReader();
                txtRole.Text = reader.GetValue(1).ToString();
                reader.Close();
                Program.Connection.Close();
               
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
            cmbProfiles.SelectedIndex = -1;
        }
    }
}
