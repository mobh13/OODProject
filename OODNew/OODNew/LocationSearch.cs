﻿using System;
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
    public partial class LocationSearch : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;
        public LocationSearch()
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

        private void LocationSearch_Load(object sender, EventArgs e)
        {
            List<string> locationsIDList = new List<string>();
            List<string> locationsSubIDList = new List<string>();
            Program.Connection.Open();
            command = Program.Connection.CreateCommand();
            command.CommandText = "Select * From [Location]";
            reader = command.ExecuteReader();
            locationsSubIDList.Add("0");
            string locationInfo;
            while (reader.Read())
            {
                locationInfo = reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString();
                locationsIDList.Add(locationInfo);
                locationsSubIDList.Add(locationInfo.Substring(0, locationInfo.IndexOf('-')));
            }
            this.cmbLocationID.DataSource = locationsIDList;
            cmbLocationID.SelectedIndex = -1;
            cmbLocationSubID.DataSource = locationsSubIDList;
            cmbLocationSubID.SelectedIndex = -1;
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
            foreach (TextBox control in Controls.OfType<TextBox>())
            {
                control.Text = "";
            }
            foreach (ComboBox control in Controls.OfType<ComboBox>())
            {
                control.SelectedIndex = -1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.cmbLocationSubID.SelectedIndex == -1 && this.cmbLocationID.SelectedIndex == -1 
                && this.txtLocationName.Text == null)
            {
                MessageBox.Show("Please enter search criteria.");
            }
            else
            {
                Program.Connection.Open();
                command = Program.Connection.CreateCommand();
                command.CommandText = "Select * From [Location] where 1=1 ";
                command.Parameters.Clear();
                if(this.cmbLocationID.SelectedIndex != -1){
                    command.Parameters.AddWithValue("@id",this.cmbLocationID.SelectedItem.ToString().Substring(0,this.cmbLocationID.SelectedItem.ToString().IndexOf('-')));
                    command.CommandText += " and id = @id ";
                }
                if (this.cmbLocationSubID.SelectedIndex != -1)
                {
                    command.Parameters.AddWithValue("@subId", this.cmbLocationSubID.SelectedItem.ToString());
                    command.CommandText += " and Sid = @subId ";
                }
                if (this.txtLocationName.Text.ToString() != "")
                {
                    command.Parameters.AddWithValue("@name", this.txtLocationName.Text.ToString());
                    command.CommandText += " and name = @name ";
                } 
                reader = command.ExecuteReader();
                this.txtBoxResults.Text = "ID\t\tName\t\tSubID\r\n";
                while (reader.Read())
                {
                    this.txtBoxResults.Text += reader.GetValue(0).ToString() + "\t\t" + reader.GetValue(1).ToString() + "\t\t" + reader.GetValue(2).ToString() + "\r\n";
                }
                reader.Close();
                Program.Connection.Close();
            }
        }

        private void cmbLocationID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
