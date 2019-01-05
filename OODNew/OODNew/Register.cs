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
    public partial class Register : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;
        private string oldUsername;
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Program.Connection.Open();
            command = Program.Connection.CreateCommand();
               bool isEmpty = false;
            bool isChecked = false;
            
            foreach (Control ctr in Controls)
            {
                if (ctr is TextBox && ctr.Text =="")
                {
                    Program.Connection.Close();
                    isEmpty = true;
                }
            }
            if (cmbRole.SelectedIndex == -1)
            {
                Program.Connection.Close();
                isEmpty = true;
            }
            double resDouble = 0.0;
            if (!double.TryParse(txtCommission.Text, out  resDouble)){

                MessageBox.Show("Error Please Enter a valid commision");
                Program.Connection.Close();
                isChecked = false;
            }
            else
            {
                isChecked = true;
            }
            int resInt = 0;
              if (!int.TryParse(txtCPR.Text, out resInt)){

                MessageBox.Show("Error Please Enter a valid CPR");
                Program.Connection.Close();
                isChecked = false;
            } else
            {
                isChecked = true;
            }

            

                  command.Parameters.Clear();
                  command.Parameters.AddWithValue("username", txtUsername.Text);
                  command.CommandText = "select Count(Id) from [User] where Username = @username";
                  reader = command.ExecuteReader();
                  reader.Read();
                  if (Convert.ToInt32(reader.GetValue(0).ToString()) != 0)
                  {
                      MessageBox.Show("Error Username already exist");
                      Program.Connection.Close();
                      isChecked = false;
                  }
                  reader.Close();
              
            if (isEmpty)
            {
                MessageBox.Show("Error Please Fill all information");
            }
            else if (!isEmpty && isChecked)
            {
                
                command.Parameters.Clear();
                command.Parameters.AddWithValue("name", txtName.Text);
                command.Parameters.AddWithValue("email", txtEmail.Text);
                command.Parameters.AddWithValue("username", txtUsername.Text);
                command.Parameters.AddWithValue("password", txtPassword.Text);
                command.Parameters.AddWithValue("cpr", txtCPR.Text);
                command.Parameters.AddWithValue("address", txtAddress.Text);
                command.Parameters.AddWithValue("phone", txtPhone.Text);
                command.Parameters.AddWithValue("commission", txtCommission.Text);
                command.Parameters.AddWithValue("role", cmbRole.SelectedIndex + 2);
                command.Parameters.AddWithValue("dob", dtpBirthdate.Value.ToString("d/MMM/yyyy"));



                command.CommandText = "Insert into [User] values(@name,@dob,@email,@phone,@address,@username,@password,@role,@commission,@cpr)";
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
                    MessageBox.Show("You Registerd Sucssfully");
                }
                Program.Connection.Close();
                
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            Program.Connection.Open();
            command = Program.Connection.CreateCommand();
            command.CommandText = "Select * From [Role]";
            reader = command.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {
                list.Add(reader.GetValue(1).ToString());
            }
            cmbRole.DataSource = list;
            cmbRole.SelectedIndex = -1;
            reader.Close();
            Program.Connection.Close();
        }
    }
}
