using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OODNew
{
    public partial class ProfileEdit : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;
        private string oldUsername;
        public ProfileEdit()
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
            command.CommandText = "Select * From [User]";
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbProfiles.SelectedIndex != -1)
            {
                List<string> list = new List<string>();
                string id = cmbProfiles.SelectedValue.ToString();
                Program.Connection.Open();
                command = Program.Connection.CreateCommand();
                command.CommandText = "Select * From [Role]";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader.GetValue(1).ToString());
                }
                comboBox1.DataSource = list;
                comboBox1.SelectedIndex = -1;
                reader.Close();
                command = Program.Connection.CreateCommand();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("id", id);
                command.CommandText = "Select * From [User] where Id = @id";
                reader = command.ExecuteReader();
                reader.Read();
                txtName.Text = reader.GetValue(1).ToString();
                txtEmail.Text = reader.GetValue(3).ToString();
                txtUsername.Text = reader.GetValue(6).ToString();
                oldUsername = reader.GetValue(6).ToString(); 
                txtPassword.Text = reader.GetValue(7).ToString();
                txtCPR.Text = reader.GetValue(10).ToString();
                txtAddress.Text = reader.GetValue(5).ToString();
                txtPhone.Text = reader.GetValue(4).ToString();
                txtCommission.Text = reader.GetValue(9).ToString();
                dateTimePicker1.Value = DateTime.Parse(reader.GetValue(2).ToString());

                string roleID = reader.GetValue(8).ToString();
                reader.Close();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("id", roleID);
                command.CommandText = "Select * From [Role] where role_id = @id";
                reader = command.ExecuteReader();
                reader.Read();

                comboBox1.SelectedIndex = comboBox1.FindStringExact(reader.GetValue(1).ToString());
                reader.Close();
                Program.Connection.Close();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = cmbProfiles.SelectedValue.ToString();

            bool isEmpty = false;
            bool isChecked = false;

            foreach (Control ctr in Controls)
            {
                if (ctr is TextBox && ctr.Text == "")
                {
                    isEmpty = true;
                }
            }
            if (comboBox1.SelectedIndex == -1)
            {
                isEmpty = true;
            }
            double resDouble = 0.0;
            if (!double.TryParse(txtCommission.Text, out  resDouble))
            {

                MessageBox.Show("Error Please Enter a valid commision");

                isChecked = false;
            }
            else
            {
                isChecked = true;
            }

            int resInt = 0;
            if (!int.TryParse(txtCPR.Text, out resInt))
            {

                MessageBox.Show("Error Please Enter a valid CPR");

                isChecked = false;
            }
            else
            {
                isChecked = true;
            }

            if (txtUsername.Text != this.oldUsername )
            {
                Program.Connection.Open();
                command = Program.Connection.CreateCommand();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("username", txtUsername.Text);
                command.CommandText = "select Count(Id) from [User] where Username = @username";
                reader = command.ExecuteReader();
                reader.Read();
                if (Convert.ToInt32(reader.GetValue(0).ToString()) != 0)
                {
                    MessageBox.Show("Error Username already exist");

                    isChecked = false;
                }
                reader.Close();
                Program.Connection.Close();


            }
          

            if (isEmpty)
            {
                MessageBox.Show("Error Please Fill all information");
            }
            else if (!isEmpty && isChecked)
            {
                Program.Connection.Open();
                command = Program.Connection.CreateCommand();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("name", txtName.Text);
                command.Parameters.AddWithValue("email", txtEmail.Text);
                command.Parameters.AddWithValue("username", txtUsername.Text);
                command.Parameters.AddWithValue("password", txtPassword.Text);
                command.Parameters.AddWithValue("cpr", txtCPR.Text);
                command.Parameters.AddWithValue("address", txtAddress.Text);
                command.Parameters.AddWithValue("phone", txtPhone.Text);
                command.Parameters.AddWithValue("commission", txtCommission.Text);
                command.Parameters.AddWithValue("role", comboBox1.SelectedIndex + 1);
                command.Parameters.AddWithValue("dob", dateTimePicker1.Value.ToString("d/MMM/yyyy"));



                command.CommandText = "Update [User] set Name = @name, DOB = @dob, Email = @email, Phone = @phone, Address = @address, Username = @username, Password = @password, role_Id = @role, Commission = @commission, CPR = @cpr Where Id = @id";
                int rowEffected = 0;
                try
                {
                    rowEffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                if (rowEffected == 1)
                {
                    MessageBox.Show("User Update");
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
            comboBox1.Items.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
