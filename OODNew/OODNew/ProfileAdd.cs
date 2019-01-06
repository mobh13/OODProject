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
            List<string> list = new List<string>(); //create new string list
            Program.Connection.Open(); // open connection
            command = Program.Connection.CreateCommand(); // create connection
            command.CommandText = "Select * From [Role]"; // get the roles
            reader = command.ExecuteReader(); // execute reader
            while (reader.Read()) // while reader have records left
            {
                list.Add(reader.GetValue(1).ToString()); // add the name of the role to the list
            }
            cmbRole.DataSource = list; // set the list as the data Source
            cmbRole.SelectedIndex = -1; // change the selected index to -1 to reset the comboBox
            reader.Close(); // close reader
            Program.Connection.Close(); // close connection
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
            
            //check if one of the text boxes is empty then change the var isEmpty to true
            foreach (Control ctr in Controls)
            {
                if (ctr is TextBox && ctr.Text =="")
                {
                    isEmpty = true;
                }
            }
            // check if the selected index of the ComboBox = -1 then change the var isEmpty to true
            if (cmbRole.SelectedIndex == -1)
            {
                isEmpty = true;
            }
            // check if the value of the enterd commision is correct
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
            // check if the value of the enterd CPR is correct

              if (!int.TryParse(txtCPR.Text, out resInt)){

                MessageBox.Show("Error Please Enter a valid CPR");

                isChecked = false;
            } else
            {
                isChecked = true;
            }

              /* check if the enterd user already exists in the database or not */

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

            
            if (isEmpty)
            {
                MessageBox.Show("Error Please Fill all information");
            }
            else if(!isEmpty && isChecked) 
            {
                /* if all the validation above is valid then open connection and insert to the database these information*/
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
              int rowEffected = 0; // to get the effected rows of the query above
                /* Try and catch is to get the exception and show it to the user and prevent the application from crashing*/
                try{            
                    rowEffected= command.ExecuteNonQuery();
                }
                catch(Exception ex){
                    MessageBox.Show(ex.ToString());
                }
            if(rowEffected == 1){ // if the number of rows effected  = 1 then the user was added and show message
                MessageBox.Show("User added");
            }
            Program.Connection.Close(); // close connection
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            /* for each element in the controls list clear the text if the controller is a textbox*/

            foreach (Control ctr in Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
            cmbRole.SelectedIndex = -1; // change the selected index to -1 to reset the comboBox selection
            dtpBirthdate.Value = DateTime.Now; // set the date and time picker to todays date
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // close this form

        }
    }
}
