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

    public partial class PropertySearch : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;
        private DataTable dataTable;

        public PropertySearch()
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
            dataTable = new DataTable();
            string[] columns = { "ID", "Location ID", "Name", "Agent ID", "Price", "Description", "Status ID" };
            foreach (string columnName in columns)
            {
                dataTable.Columns.Add(columnName);
            }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Clear();
            dataTable.Clear();
            try
            {
                command = Program.Connection.CreateCommand();
                command.CommandText = "Select * from [Property] where 1 = 1 ";
                if (txtId.Text != "")
                {
                    command.Parameters.AddWithValue("@Id", txtId.Text.ToString());
                    command.CommandText += "and [Property].Id = @Id ";
                }

                if (txtName.Text != "")
                {
                    command.Parameters.AddWithValue("@Name", txtName.Text.ToString());
                    command.CommandText += "and [Property].Name = @Name ";
                }

                if (txtPrice.Text != "")
                {
                    command.Parameters.AddWithValue("@Price", txtPrice.Text.ToString());
                    command.CommandText += "and [Property].Price > @Price ";
                }

                if (txtPriceTo.Text != "")
                {
                    command.Parameters.AddWithValue("@PriceTo", txtPriceTo.Text.ToString());
                    command.CommandText += "and [Property].Price < @PriceTo ";
                }

                if (cmbLocations.SelectedIndex != -1)
                {
                    command.Parameters.AddWithValue("@Location_Id",
                        cmbLocations.SelectedItem.ToString().Substring(0, cmbLocations.SelectedItem.ToString().IndexOf(' ')));
                    command.CommandText += "and [Property].Location_Id = @Location_Id ";
                }

                if (cmbAgents.SelectedIndex != -1)
                {
                    command.Parameters.AddWithValue("@Agent_Id",
                        cmbAgents.SelectedItem.ToString().Substring(0, cmbAgents.SelectedItem.ToString().IndexOf(' ')));
                    command.CommandText += "and [Property].Agent_Id = @Agent_Id ";
                }

                if (cmbStatus.SelectedIndex != -1)
                {
                    command.Parameters.AddWithValue("@PropertyStatusId",
                        cmbStatus.SelectedItem.ToString().Substring(0, cmbStatus.SelectedItem.ToString().IndexOf(' ')));
                    command.CommandText += "and [Property].PropertyStatusId = @PropertyStatusId ";
                }

                if (clbFeatues.CheckedIndices.Count > 0)
                {
                    command.CommandText += "and [Property].Id in ( select PropertyId from [FeatureProperty] where FeatureId in (";
                    int x = 1;
                    foreach (int i in clbFeatues.CheckedIndices)
                    {
                        command.CommandText += clbFeatues.Items[i].ToString().Substring(0, clbFeatues.Items[i].ToString().IndexOf(' '));
                        if (x < clbFeatues.CheckedIndices.Count)
                        {
                            command.CommandText +=  ", ";
                        }

                        x++;
                    }

                    command.CommandText += "))";
                }


                Program.Connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dataTable.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(),
                        reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), reader.GetValue(5).ToString(), reader.GetValue(6).ToString());
                }
                dgvPropertiesSearch.DataSource = dataTable;
                reader.Close();
                Program.Connection.Close();
            } catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
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

            dataTable.Rows.Clear();
        }
    }
}
