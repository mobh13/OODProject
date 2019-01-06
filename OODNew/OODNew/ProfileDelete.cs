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
    public partial class ProfileDelete : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;
        public ProfileDelete()
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
            LoadCmb();
        }
        private void LoadCmb(){

            List<string> list = new List<string>(); // declare string list
            /* Open connection and create a command*/
            Program.Connection.Open();
            command = Program.Connection.CreateCommand();
            if (Program.UserInfo.Role_id == "1") // if the role is admin then show all the users
            {
                command.CommandText = "Select * From [User]";
            }
            else
            { // else the role is not admin only show its own profile
                command.Parameters.AddWithValue("id", Program.UserInfo.Id);
                command.CommandText = "Select * From [User] Where Id= @id";
            }
            reader = command.ExecuteReader(); // execute the command and assign the result to the readr
            while (reader.Read()) // while the reader hase a row
            {
                list.Add(reader.GetValue(0).ToString()); // ad the id of the user to the list
            }
            cmbProfiles.DataSource = list; // set the list as the data source
            cmbProfiles.SelectedIndex = -1; // reset the comboBox selection
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

        private void cmbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<string> bidIdList = new List<string>(); // declare string list for bids
            List<string> applicationIdList = new List<string>(); // declare string list for applications

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Profile ? " +
                "\n Warning: All Profile Related records is going to be deleted For Example: Application , bids." +
                "\n Warning: If this is Your profile you will be logged out !!",
            "Delete Notice", MessageBoxButtons.YesNo); // show a confrmation message
            if (dialogResult == DialogResult.Yes) // if thw user clicked yes then
            {
                string id = cmbProfiles.SelectedValue.ToString(); // get the user id
                /* check if the user has properties and if show error message else continue*/
                Program.Connection.Open();
                command = Program.Connection.CreateCommand();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("id", id);
                command.CommandText = "Select Count(Id) from [Property] where Agent_Id = @id)";
                reader = command.ExecuteReader();
                reader.Read();
                if (Convert.ToInt32(reader.GetValue(0).ToString()) != 0)
                {
                    MessageBox.Show("Error this user has properties, you cannot delete a profile that has a property linked with.");
                    reader.Close();

                }
                else
                {
                    /* get the bids of the user  and store then in the bids list*/
                    reader.Close();
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("id", id);
                    command.CommandText = "Select Id from [Bid] where Application_Id in(select Id from [Application] where User_Id = @id)";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        bidIdList.Add(reader.GetValue(0).ToString());
                    }
                    reader.Close();
             
                    

                    /* for each bid the user have delete payment if there is any*/
                    foreach (string bidId in bidIdList)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("id", bidId);
                        command.CommandText = "Delete From [Payment] where Id=@id";
                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    /* delete all the bids that the user has*/
                    foreach (string bidId in bidIdList)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("id", bidId);
                        command.CommandText = "Delete From [Bid] where Id=@id";
                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    /* Delete all the applications that the user did*/
                  
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("id", id);
                        command.CommandText = "Delete From [Application] where User_Id=@id";
                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                   
                    /* Delete all the Backups that the user did*/
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("id", id);
                    command.CommandText = "Delete From [Backup] where User_id=@id";
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    /* Delete all the service records that the user have*/

                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("id", id);
                    command.CommandText = "Delete From [Service_User] where User_Id=@id";
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    /* Delete all the messages records that the user have as a sender*/

                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("id", id);
                    command.CommandText = "Delete From [Message] where Sender_Id=@id";
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    /* Delete all the messages records that the user have as a reciver*/

                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("id", id);
                    command.CommandText = "Delete From [Message] where Reciver_Id=@id";
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    /* Finally delete the user profile*/

                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("id", id);
                    command.CommandText = "Delete From [User] where Id=@id";
                    int rowEffected = 0;
                    try
                    {
                        rowEffected = command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    if (rowEffected == 1) // if the rows effected from the last command  =1 then the user was deleted and then do
                    {
                        if (id == Program.UserInfo.Id) // if the user deleted his profile then close the application and show the login page
                        {
                            this.Close();
                            Logincs loginpnl = new Logincs();
                            loginpnl.Show();
                        }
                        else
                        {
                            // else show user deleted message
                            MessageBox.Show("User Deleted");

                        }


                    }


                    Program.Connection.Close(); // close connection
                    LoadCmb(); // update the comboBox data



                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadCmb(); // call method LoadCmb to update the comboBox data
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // close this form

        }
    }
}
