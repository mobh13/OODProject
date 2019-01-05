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
    public partial class LocationEdit : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;
        List<string> locationsList;
        public LocationEdit()
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
            cmbLocations.SelectedIndex = -1;
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

      
        private void cmbLocations_SelectionChangeCommitted(object sender, EventArgs e)
        {
            locationsLoad();
        }
        void locationsLoad()
        {
            string locationID = this.cmbLocations.SelectedItem.ToString().Substring(0, this.cmbLocations.SelectedItem.ToString().IndexOf('-'));
            Program.Connection.Open();
            command = Program.Connection.CreateCommand();
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", locationID);
            command.CommandText = "Select * From [Location] where id = @id";
            reader = command.ExecuteReader();
            reader.Read();
            this.txtLocationName.Text = reader.GetValue(1).ToString();
            this.txtSubID.Text = reader.GetValue(2).ToString();
            reader.Close();
            Program.Connection.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            foreach (TextBox control in Controls.OfType<TextBox>())
            {
                control.Text = "";
            }
            foreach (ComboBox control in Controls.OfType<ComboBox>())
            {
                control.SelectedIndex = -1;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool isEmpty = false;
            foreach (Control controls in this.Controls)
            {
                if (controls is TextBox || controls is ComboBox)
                {
                    if (controls.Text == "" || controls.Text == null)
                    {
                        isEmpty = true;
                    }
                }
            }
            if (isEmpty == false)
            {
                string locationID = this.cmbLocations.SelectedItem.ToString().Substring(0, this.cmbLocations.SelectedItem.ToString().IndexOf('-'));
                string locationName = this.txtLocationName.Text.ToString();
                string locationSubID = this.txtSubID.Text.ToString();
                Program.Connection.Open();
                command = Program.Connection.CreateCommand();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", locationID);
                command.Parameters.AddWithValue("@name", locationName);
                command.Parameters.AddWithValue("@sub", locationSubID);
                command.CommandText = "Update [Location] set Name = @name, Sid = @sub where id = @id";
                try
                {
                    command.ExecuteNonQuery();
                    Program.Connection.Close();
                    locationsLoad();
                    clear();
                    MessageBox.Show("Records have been updated successfully.");
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("There have been an error while updating the record.\n"+ex);
                    Program.Connection.Close();
                }
                
            }
            else
            {
                MessageBox.Show("There are empty feilds, please enter all information.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
