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
    public partial class PropertyDelete : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;

        public PropertyDelete()
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
            LoadProperties();
        }

        private void LoadProperties()
        {
            List<string> propertiesList = new List<string>();
            Program.Connection.Open();
            command = Program.Connection.CreateCommand();
            command.CommandText = "Select * From [Property]";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                propertiesList.Add(reader.GetValue(0).ToString());
            }
            cmbProperties.DataSource = propertiesList;
            cmbProperties.SelectedIndex = -1;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.cmbProperties.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Program.Connection.Open();
            command = Program.Connection.CreateCommand();


            command.CommandText = "Select Id From [Application] where Property_Id = " + cmbProperties.SelectedItem.ToString();
            reader = command.ExecuteReader();
            reader.Read();
            string applicationId = reader.GetValue(0).ToString();
            reader.Close();

            command.CommandText = "Select Id From [Bid] where Application_Id = " + applicationId;
            reader = command.ExecuteReader();
            reader.Read();
            string bidId = reader.GetValue(0).ToString();
            reader.Close();

            command.CommandText = "Delete From [Payment] where Bid_Id = " + bidId;
            command.ExecuteNonQuery();
            command.CommandText = "Delete From [Bid] where Application_Id = " + applicationId;
            command.ExecuteNonQuery();
            command.CommandText = "Delete From [Application] where Property_Id = " + applicationId;
            command.ExecuteNonQuery();
            command.CommandText = "Delete From [Property] where Id = " + cmbProperties.SelectedItem.ToString();
            command.ExecuteNonQuery();
            MessageBox.Show("Delete Succeeded");
            cmbProperties.SelectedIndex = -1;
            Program.Connection.Close();
            LoadProperties();
        }
    }
}
