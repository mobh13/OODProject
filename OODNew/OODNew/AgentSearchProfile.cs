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
    public partial class AgentSearchProfile : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;
        public AgentSearchProfile()
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
            List<string> list = new List<string>();
            Program.Connection.Open();
            command = Program.Connection.CreateCommand();
            command.Parameters.Clear();

            command.Parameters.AddWithValue("id", Program.UserInfo.Id);
            command.CommandText = "Select ID from [Property] where Agent_Id = @id";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetValue(0).ToString());
            }
            cmbProperty.DataSource = list;
            cmbProperty.SelectedIndex = -1;
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


            List<string> list = new List<string>();
            string id = cmbProperty.SelectedValue.ToString();
            Program.Connection.Open();
            command = Program.Connection.CreateCommand();
            command.Parameters.Clear();

            command.Parameters.AddWithValue("id", id);
            command.CommandText = "Select * From [Application] where Property_Id = @id";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetValue(3).ToString());
            }
            reader.Close();
            DataTable table = new DataTable();
            table.Columns.Add("UserID");
            table.Columns.Add("Name");
            table.Columns.Add("Username");
            table.Columns.Add("Email");
            table.Columns.Add("Phone");
            foreach (string element in list)
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("id", element);
                command.CommandText = "Select * From [User] where Id = @id";
                reader = command.ExecuteReader();
                reader.Read();
                table.Rows.Add(reader.GetValue(0).ToString() , reader.GetValue(1).ToString() , reader.GetValue(6).ToString() ,reader.GetValue(3).ToString()  ,  reader.GetValue(4).ToString());
                reader.Close();
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = table;
            Program.Connection.Close();

          

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbProperty.SelectedIndex = -1;
            dataGridView1.DataSource = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
