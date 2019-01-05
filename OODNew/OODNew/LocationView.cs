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
    public partial class LocationView : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;
        public LocationView()
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
            List<string> locationsList = new List<string>();
            Program.Connection.Open();
            command = Program.Connection.CreateCommand();
            command.CommandText = "Select * From [Location]";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                locationsList.Add(reader.GetValue(0).ToString());
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

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void cmbLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
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

        private void cmbLocations_SelectionChangeCommitted(object sender, EventArgs e)
        {
                string locationID = this.cmbLocations.SelectedItem.ToString();
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
    }
}
