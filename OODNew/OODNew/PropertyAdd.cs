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
    public partial class PropertyAdd : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;

        public PropertyAdd()
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
            LoadComboBoxes();
            LoadFeatures();
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
                string locationId = cmbLocations.SelectedItem.ToString().Substring(0, cmbLocations.SelectedItem.ToString().IndexOf(' '));
                string agentId = cmbAgents.SelectedItem.ToString().Substring(0, cmbAgents.SelectedItem.ToString().IndexOf(' '));
                string statusId = cmbStatus.SelectedItem.ToString().Substring(0, cmbStatus.SelectedItem.ToString().IndexOf(' '));
                string name = txtName.Text.ToString();
                string description = txtDescription.Text.ToString();
                string price = txtPrice.Text.ToString();

                Program.Connection.Open();
                command = Program.Connection.CreateCommand();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@locationId", locationId);
                command.Parameters.AddWithValue("@agentId", agentId);
                command.Parameters.AddWithValue("@statusId", statusId);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@price", price);
                command.CommandText = "insert into [Property](location_Id, name, Agent_Id, Price, Descreption, PropertyStatusId) " + 
                "values(@locationId, @name, @agentId, @price, @description, @statusId);";

                try
                {
                    command.ExecuteNonQuery();
                    command.CommandText = "Select max(id) from Property;";
                    reader = command.ExecuteReader();
                    reader.Read();
                    string maxId = reader.GetValue(0).ToString();
                    reader.Close();

                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@maxId", maxId);
                    foreach (int i in clbFeatues.CheckedIndices)
                    {
                        command.CommandText = "insert into [FeatureProperty](PropertyId, FeatureId) values(@maxId, " +
                            clbFeatues.Items[i].ToString().Substring(0, clbFeatues.Items[i].ToString().IndexOf(' ')) + ")";
                        command.ExecuteNonQuery();
                    }


                    MessageBox.Show("Property was added Successfully. Property ID = " + maxId);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Record was not added.\n" + ex);
                }
                Program.Connection.Close();
                Clear();
            }
            else
            {
                MessageBox.Show("There are empty fields.");
            }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
