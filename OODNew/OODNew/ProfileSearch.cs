using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            this.DOB.CustomFormat = "d/MMM/yyyy";
            List<string> list = new List<string>();
            Program.Connection.Open();
            command = Program.Connection.CreateCommand();
            command.CommandText = "Select * From [Role]";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetValue(1).ToString());
            }
            
            Role_Id.DataSource = list;
            
            Role_Id.SelectedIndex = -1;
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
            Program.Connection.Open();
            command = Program.Connection.CreateCommand();
            command.Parameters.Clear();
           
            command.CommandText = "Select * From [User] where 1 = 1";
          

            foreach (Control ctr in Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Text != "")
                    {
                        command.Parameters.AddWithValue(ctr.Name, ctr.Text);
                        command.CommandText = command.CommandText + " and " + ctr.Name.ToString() + " Like( '%' + @" + ctr.Name.ToString() + " + '%' ) ";

                    }
                }
            }
            if (Role_Id.SelectedIndex != -1)
            {
                command.Parameters.AddWithValue(Role_Id.Name, Role_Id.SelectedIndex + 1);
                command.CommandText = command.CommandText + " and " + Role_Id.Name.ToString() + " Like( @" + Role_Id.Name.ToString() + " ) ";
            }

            if (DOB.Value.ToString("d/MMM/yyyy") != DateTime.Today.ToString("d/MMM/yyyy"))
            {
                command.Parameters.AddWithValue(DOB.Name.ToString(), DOB.Value.ToString("d/MMM/yyyy"));
                command.CommandText = command.CommandText + " and " + DOB.Name.ToString() + " Like( @" + DOB.Name.ToString() +" ) ";
            }
            reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("UserID");
            table.Columns.Add("Name");
            table.Columns.Add("Username");
            while (reader.Read())
            {
                table.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(6).ToString());
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = table;

            reader.Close();
            Program.Connection.Close();
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
            dataGridView1.DataSource = null;
            Role_Id.SelectedIndex = -1;
            DOB.Value = DateTime.Now;
        }
    }
}
