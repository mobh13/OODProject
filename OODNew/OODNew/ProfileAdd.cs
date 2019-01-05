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
    public partial class ProfileAdd : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;
        private string oldUsername;
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
            command.CommandText = "Select * From [Role]";
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
            bool isChecked = false;
            
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
            double resDouble = 0.0;
            if (!double.TryParse(txtCommission.Text, out  resDouble)){

                MessageBox.Show("Error Please Enter a valid commision");

                isChecked = false;
            }
            else
            {
                isChecked = true;
            }
            int resInt = 0;
              if (!int.TryParse(txtCPR.Text, out resInt)){

                MessageBox.Show("Error Please Enter a valid CPR");

                isChecked = false;
            } else
            {
                isChecked = true;
            }

              if (txtUsername.Text != this.oldUsername)
              {

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

              }
            if (isEmpty)
            {
                MessageBox.Show("Error Please Fill all information");
            }
            else if(!isEmpty && isChecked)
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
                command.Parameters.AddWithValue("role", cmbRole.SelectedIndex +1);
                command.Parameters.AddWithValue("dob", dtpBirthdate.Value.ToString("d/MMM/yyyy"));

                
              
                command.CommandText = "Insert into [User] values(@name,@dob,@email,@phone,@address,@username,@password,@role,@commission,@cpr)";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
