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
    public partial class LocationAdd : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;
        public LocationAdd()
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
            List<string> locationsList = new List<string>();
            Program.Connection.Open();
            command = Program.Connection.CreateCommand();
            command.CommandText = "Select * From [Location]";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                locationsList.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString());
            }
            cmbLocationID.DataSource = locationsList;
            cmbLocationID.SelectedIndex = -1;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            txtLocationName.Text = "";
            cmbLocationID.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isEmpty = false;
            foreach (Control controls in this.Controls)
            {
                if (controls.Name == "TextBox" || controls.Name == "ComboBox")
                {
                    if (controls.Text == "" || controls.Text == null)
                    {
                        isEmpty = true;
                    }
                }
            }
            if (isEmpty == false)
            {
                string locationName = this.txtLocationName.Text.ToString();
                string locationSubID = this.cmbLocationID.SelectedItem.ToString().Substring(0, this.cmbLocationID.SelectedItem.ToString().IndexOf('-'));
                Program.Connection.Open();
                command = Program.Connection.CreateCommand();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@name", locationName);
                command.Parameters.AddWithValue("@subID", locationSubID);
                command.CommandText = "insert into [Location]( Name, Sid) values(@name,@subID);";
                try
                {
                    command.ExecuteNonQuery();
                    command.CommandText = "Select max(id) from location;";
                    reader = command.ExecuteReader();
                    reader.Read();
                    MessageBox.Show("Location was added Successfully. Location ID = " + reader.GetValue(0).ToString());
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Record was not added.\n" + ex);
                }
                Program.Connection.Close();
                clear();
                loadLocations();
            }
            else
            {
                MessageBox.Show("There are empty fields.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
