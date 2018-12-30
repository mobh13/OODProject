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
    public partial class ProfileAdd : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;
        public ProfileAdd()
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
            command.CommandText = "Select * From Role";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetValue(1).ToString());
            }
            cmbRole.DataSource = list;
            cmbRole.SelectedIndex = -1;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isEmpty = false;
            foreach (Control ctr in Controls)
            {
                if (ctr is TextBox && ctr.Text =="")
                {
                    isEmpty = true;
                }
            }
            if (cmbRole.SelectedIndex == -1)
            {
                isEmpty = true;
            }
            if (isEmpty)
            {
                MessageBox.Show("Error Please Fill all information");
            }
            else
            {
                Program.Connection.Open();
                command = Program.Connection.CreateCommand();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("name", txtName.Text);
                command.Parameters.AddWithValue("email", txtEmail.Text);
                command.Parameters.AddWithValue("username", txtUsername.Text);
                command.Parameters.AddWithValue("password", txtPassword.Text);
                command.Parameters.AddWithValue("cpr", txtCPR.Text);
                command.Parameters.AddWithValue("address", txtAddress.Text);
                command.Parameters.AddWithValue("phone", txtPhone.Text);
                command.Parameters.AddWithValue("commission", txtCommission.Text);
                command.Parameters.AddWithValue("role", cmbRole.SelectedIndex.ToString());
                command.Parameters.AddWithValue("dob", dtpBirthdate.Value.ToString("dd-mm-YYY"));

                
              
                command.CommandText = "Insert into User values(@name,@dob,@email,@phone,@address,@username,@password,@role,@commission,@cpr)";
              int rowEffected = 0;
                try{            
                    rowEffected= command.ExecuteNonQuery();
                }
                catch(Exception ex){
                    MessageBox.Show(ex.ToString());
                }
            if(rowEffected == 1){
                MessageBox.Show("User added");
            }
            Program.Connection.Close();
            }

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
            cmbRole.SelectedIndex = -1;
            dtpBirthdate.Value = DateTime.Now;
        }
    }
}
