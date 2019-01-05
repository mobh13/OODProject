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
    public partial class LocationDelete : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;
        List<string> locationsList;
        public LocationDelete()
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
            loadLocations();
        }
        void loadLocations()
        {
            locationsList = new List<string>();
            Program.Connection.Open();
            command = Program.Connection.CreateCommand();
            command.CommandText = "Select * From [Location]";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                locationsList.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString());
            }
            cmbLocations.DataSource = locationsList;
            cmbLocations.SelectedIndex = 0;
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

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string locaitonID = this.cmbLocations.SelectedItem.ToString().Substring(0, this.cmbLocations.SelectedItem.ToString().IndexOf('-'));
            Program.Connection.Open();
            command = Program.Connection.CreateCommand();
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", locaitonID);
            command.CommandText = "Select count(*) From [Property] where Location_Id = @id;";
            reader = command.ExecuteReader();
            reader.Read();
            int propertyCheck = Convert.ToInt32(reader.GetValue(0).ToString());
            reader.Close();
            Program.Connection.Close();
            if (propertyCheck == 0)
            {
                Program.Connection.Open();
                command = Program.Connection.CreateCommand();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", locaitonID);
                command.CommandText = "Select count(*) From [Location] where Sid = @id;";
                reader = command.ExecuteReader();
                reader.Read();
                int subIdCheck = Convert.ToInt32(reader.GetValue(0).ToString());
                reader.Close();
                Program.Connection.Close();
                if (subIdCheck == 0)
                {
                    Program.Connection.Open();
                    command = Program.Connection.CreateCommand();
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@id", locaitonID);
                    command.CommandText = "delete from [Location] where id = @id;";
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Location was deleted successfully!");
                        reader.Close();
                        Program.Connection.Close();
                        loadLocations();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Record was not deleted.\n" + ex);
                        reader.Close();
                        Program.Connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("There are locations that belong to the location you are deleting. Kindly delete all related locations first.");
                }
            }
            else
            {
                MessageBox.Show("Cannot delete this location due to dependent properties.\nPlease delete the proeprties that have this location first.");
            }
        }
    }
}
