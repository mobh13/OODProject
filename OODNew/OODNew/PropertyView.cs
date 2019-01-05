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
    public partial class PropertyView : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;

        public PropertyView()
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

        private void cmbProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.cmbProperties.SelectedIndex = -1;
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Text = "";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void cmbProperties_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.cmbProperties.SelectedIndex != -1)
            {
                txtFeatures.Text = "";
                string propertyID = this.cmbProperties.SelectedItem.ToString();
                Program.Connection.Open();
                command = Program.Connection.CreateCommand();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", propertyID);
                command.CommandText = "Select * From [Property] where id = @id";
                reader = command.ExecuteReader();
                reader.Read();
                txtName.Text = reader.GetValue(2).ToString();
                txtLocation.Text = reader.GetValue(1).ToString();
                txtDescription.Text = reader.GetValue(5).ToString();
                txtAgent.Text = reader.GetValue(3).ToString();
                txtPrice.Text = reader.GetValue(4).ToString();
                txtStatus.Text = reader.GetValue(6).ToString();
                reader.Close();
                List<string> featurePropertyList = new List<string>();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", propertyID);
                command.CommandText = "Select featureName From [FeatureProperty], [Feature] where " +
                "[FeatureProperty].featureId = [Feature].featureId and propertyId = @id";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    featurePropertyList.Add(reader.GetValue(0).ToString());
                }

                foreach (string feature in featurePropertyList)
                {
                    txtFeatures.Text += feature + "\r\n";
                }

                reader.Close();
                Program.Connection.Close();
            }
        }
    }
}
