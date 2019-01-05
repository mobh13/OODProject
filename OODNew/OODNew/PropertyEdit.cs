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
    public partial class PropertyEdit : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;

        public PropertyEdit()
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
            LoadComboBoxes();
            LoadFeatures();
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

        private void LoadComboBoxes()
        {
            List<string> locationsList = new List<string>();
            List<string> agentsList = new List<string>();
            List<string> statusList = new List<string>();

            Program.Connection.Open();
            command = Program.Connection.CreateCommand();
            command.CommandText = "Select * From [Location]";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                locationsList.Add(reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString());
            }
            cmbLocations.DataSource = locationsList;
            cmbLocations.SelectedIndex = -1;
            reader.Close();

            command = Program.Connection.CreateCommand();
            command.CommandText = "Select * From [User] where role_Id = 2";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                agentsList.Add(reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString());
            }
            cmbAgents.DataSource = agentsList;
            cmbAgents.SelectedIndex = -1;
            reader.Close();

            command = Program.Connection.CreateCommand();
            command.CommandText = "Select * From [PropertyStatus]";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                statusList.Add(reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString());
            }
            cmbStatus.DataSource = statusList;
            cmbStatus.SelectedIndex = -1;
            reader.Close();

            Program.Connection.Close();
        }

        private void LoadFeatures()
        {
            List<string> featuresList = new List<string>();
            Program.Connection.Open();
            command = Program.Connection.CreateCommand();
            command.CommandText = "Select * From [Feature]";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                clbFeatues.Items.Add(reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString());
            }
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
            if (this.cmbProperties.SelectedIndex != -1)
            {

                foreach (int i in clbFeatues.CheckedIndices)
                {
                    clbFeatues.SetItemCheckState(i, CheckState.Unchecked);
                }


                string propertyID = this.cmbProperties.SelectedItem.ToString();
                Program.Connection.Open();
                command = Program.Connection.CreateCommand();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", propertyID);
                command.CommandText = "Select * From [Property] where id = @id";
                reader = command.ExecuteReader();
                reader.Read();
                txtName.Text = reader.GetValue(2).ToString();
                cmbLocations.SelectedIndex = cmbLocations.FindString(reader.GetValue(1).ToString());
                txtDescription.Text = reader.GetValue(5).ToString();
                cmbAgents.SelectedIndex = cmbAgents.FindString(reader.GetValue(3).ToString());
                txtPrice.Text = reader.GetValue(4).ToString();
                cmbStatus.SelectedIndex = cmbStatus.FindString(reader.GetValue(6).ToString());
                reader.Close();

                List<string> featurePropertyList = new List<string>();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", propertyID);
                command.CommandText = "Select [FeatureProperty].featureId From [FeatureProperty], [Feature] where " +
                "[FeatureProperty].featureId = [Feature].featureId and propertyId = @id";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    featurePropertyList.Add(reader.GetValue(0).ToString());
                }

                for (int i = 1; i < clbFeatues.Items.Count; i++)
                {
                    if (featurePropertyList.Contains(clbFeatues.Items[i].ToString().Substring(0, clbFeatues.Items[i].ToString().IndexOf(" "))))
                    {
                        clbFeatues.SetItemCheckState(i, CheckState.Checked);
                    }
                }

                reader.Close();
                Program.Connection.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Text = "";
            }

            foreach (ComboBox cmb in this.Controls.OfType<ComboBox>())
            {
                cmb.SelectedIndex = -1;
            }

            foreach (int i in clbFeatues.CheckedIndices)
            {
                clbFeatues.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                string locationId = cmbLocations.SelectedItem.ToString().Substring(0, cmbLocations.SelectedItem.ToString().IndexOf(' '));
                string agentId = cmbAgents.SelectedItem.ToString().Substring(0, cmbAgents.SelectedItem.ToString().IndexOf(' '));
                string statusId = cmbStatus.SelectedItem.ToString().Substring(0, cmbStatus.SelectedItem.ToString().IndexOf(' '));
                string name = txtName.Text.ToString();
                string description = txtDescription.Text.ToString();
                string price = txtPrice.Text.ToString();

                Program.Connection.Open();
                command = Program.Connection.CreateCommand();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Id", cmbProperties.SelectedItem.ToString());
                command.Parameters.AddWithValue("@locationId", locationId);
                command.Parameters.AddWithValue("@agentId", agentId);
                command.Parameters.AddWithValue("@statusId", statusId);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@price", price);

                command.CommandText = "Update [Property] set location_Id = @locationId, name = @name, Agent_Id = @agentId, Price = @price, Descreption = @description, PropertyStatusId = @statusId Where Id = @id";

                try
                {
                    command.ExecuteNonQuery();

                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Id", cmbProperties.SelectedItem.ToString());

                    command.CommandText = "Delete from [FeatureProperty] where [FeatureProperty].PropertyId = @Id";
                    command.ExecuteNonQuery();

                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Id", cmbProperties.SelectedItem.ToString());
                    foreach (int i in clbFeatues.CheckedIndices)
                    {
                        command.CommandText = "insert into [FeatureProperty](PropertyId, FeatureId) values(@Id, " +
                            clbFeatues.Items[i].ToString().Substring(0, clbFeatues.Items[i].ToString().IndexOf(' ')) + ")";
                        command.ExecuteNonQuery();
                    }


                    MessageBox.Show("Property was updated Successfully.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Record was not updated.\n" + ex);
                }
                Program.Connection.Close();
                Clear();
                LoadProperties();
            }
            else
            {
                MessageBox.Show("There are empty fields.");
            }
        }
    }
}
