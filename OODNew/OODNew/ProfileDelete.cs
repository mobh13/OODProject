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

        private void cmbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<string> bidIdList = new List<string>();
            List<string> applicationIdList = new List<string>();

               DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Profile ? \n Warning: All Profile Related records is going to be deleted For Example: Application , bids.",
               "Delete Notice", MessageBoxButtons.YesNo);
               if (dialogResult == DialogResult.Yes)
               {
                   string id = cmbProfiles.SelectedValue.ToString();
                   Program.Connection.Open();
                   command = Program.Connection.CreateCommand();
                    command.Parameters.Clear();
                command.Parameters.AddWithValue("id", id);
                   command.CommandText = "Select Count(Id) from [Property] where Agent_Id = @id)";
                reader = command.ExecuteReader();
                   reader.Read();
                   if(Convert.ToInt32(reader.GetValue(0).ToString() ) != 0 ){
                       MessageBox.Show("Error this user has properties, you cannot delete a profile that has a property linked with.");
                       reader.Close();

                   }else{
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
                command.CommandText = "select Id from [Application] where User_Id = @id";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    applicationIdList.Add(reader.GetValue(0).ToString());
                }
                reader.Close();

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
                foreach (string applicationID in applicationIdList)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("id", applicationID);
                    command.CommandText = "Delete From [Application] where Id=@id";
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
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
              
                command.Parameters.Clear();
                command.Parameters.AddWithValue("id", id);
                command.CommandText = "Delete From [User] where Id=@id";
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                   }
              

                Program.Connection.Close();
                LoadCmb();


               
               }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadCmb();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
