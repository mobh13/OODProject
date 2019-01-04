﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OODNew
{
    public partial class ProfileSearch : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;
        public ProfileSearch()
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
            this.DOB.CustomFormat = "MM/dd/yyyy";
          
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
            Program.Connection.Open();
            command = Program.Connection.CreateCommand();
            command.Parameters.Clear();
           
            command.CommandText = "Select * From [User] where 1 = 1";
            reader = command.ExecuteReader();
            reader.Read();
            foreach (Control ctr in Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Text != "")
                    {
                        command.Parameters.AddWithValue(ctr.Name, ctr.Text);
                        command.CommandText = command.CommandText + " and "+ ctr.Name.ToString() + " = @" + ctr.Name.ToString ;
                    }
                }
            }
            if (Role_Id.SelectedIndex != -1)
            {
                command.Parameters.AddWithValue(Role_Id.Name, Role_Id.SelectedIndex + 1);
                command.CommandText = command.CommandText + " and " + Role_Id.Name.ToString() + " = @" + Role_Id.Name.ToString;
            }

            if (DOB.Value != DateTime.Today)
            {

            }
          
        }
    }
}
