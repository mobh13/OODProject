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
            /* for each element in the controls list clear the text if the controller is a textbox*/
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
            /*  if one of the filed is empty show error message*/
            if (txtboxUsername.Text == "" || txtboxPassword.Text == "")
            {
                MessageBox.Show("Error Please Fill the username and the password");
            }
            else
            {
                /* else */
                /* get the username and the password and store them in vars*/
                string username = txtboxUsername.Text;
                string password = txtboxPassword.Text;

                Program.Connection.Open(); // open connection
                 command = Program.Connection.CreateCommand(); //create command
                command.Parameters.Clear(); // clear previous parameters just for safety
                command.Parameters.AddWithValue("@username", username); // add the username as a variable
                command.CommandText = "Select Count(*) From [User] where Username = @username"; // assign the command text
                 reader = command.ExecuteReader(); // execute the reader and assign it to reader var
                 reader.Read(); // read the first row
                if (Convert.ToInt32(reader.GetValue(0)) == 1) // get the value of the count and convert it to int and if the count = 1 then
                {
                    reader.Close(); // close the reader 
                    command.Parameters.Clear(); // clear previous parameters just for safety
                    command.Parameters.AddWithValue("@username", username);// add the username as a variable
                    command.CommandText = "Select * From [User] where Username = @username";// assign the command text
                    reader = command.ExecuteReader();// execute the reader and assign it to reader var
                    reader.Read();// read the first row
                    if (reader.GetValue(7).ToString() == password) // if the password from the user matchs the password in the database
                    {
                        /* Assign the values of the user in the database to the user object properties*/
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
                        reader.Close(); // close the reader
                        Program.Connection.Close(); // close the connection
                        /* Create new Control panel object and show it */
                        ControlPanel controlPanel = new ControlPanel();
                        controlPanel.Show();
                        this.Hide();
                    }
                    else
                    {
                        // if the password dos not match the password in the database then
                        MessageBox.Show("Error password is wrong"); // show error message
                        reader.Close(); // close reader
                        Program.Connection.Close(); // close connection
                    }
                }
                else // if no user is found then
                {
                    MessageBox.Show("Error no user was found"); // show error message
                    reader.Close(); // close reader
                    Program.Connection.Close(); // close connection
                }
               
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //close the application
        }
        private void Logincs_Load(object sender, EventArgs e)
        {
          
        }

        private void Logincs_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* create new Register form object and show it*/
            Register reg = new Register();
            reg.Show();
        }
    }
}
