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
    public partial class ControlPanel : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;
        Bitmap[] images = new Bitmap[6];
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
          
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
         
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private int imgCount = 1;

        private void loadNextImage()
        {
            if (imgCount > 5)
            {
                imgCount = 1;
            }
            slidShow.Image = images[imgCount];
            imgCount++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileView pView = new ProfileView();
            pView.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.UserInfo.Role_id == "1")
            {
                ProfileAdd pAdd = new ProfileAdd();
                pAdd.Show();

            }
            else
            {
                MessageBox.Show("Error you are not authorised to do this operation");
            }
            
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.UserInfo.Role_id == "1")
            {
                ProfileSearch pSearch = new ProfileSearch();
                pSearch.Show();

            }
            else if (Program.UserInfo.Role_id == "2")
            {
                AgentSearchProfile aPSearch = new AgentSearchProfile();
            aPSearch.Show();
                }
            else
            {
                MessageBox.Show("Error you are not authorised to do this operation");
            }
           
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileDelete pDelete = new ProfileDelete();
            pDelete.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileEdit pEdit = new ProfileEdit();
            pEdit.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PropertView pView = new PropertView();
            pView.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PropertyAdd pAdd = new PropertyAdd();
            pAdd.Show();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PropertySearch pSearch = new PropertySearch();
            pSearch.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PropertyDelete pDelete = new PropertyDelete();
            pDelete.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PropertyEdit pEdit = new PropertyEdit();
            pEdit.Show();
        }

        private void buySellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropertyBuySell pBuySell = new PropertyBuySell();
            pBuySell.Show();
        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Program.UserInfo.Role_id) == 1)
            {
                LocationView lView = new LocationView();
                lView.Show();
            }
            else
            {
                MessageBox.Show("Only admins have permissions for this funstionality.");
            }
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Program.UserInfo.Role_id) == 1)
            {
                LocationAdd lAdd = new LocationAdd();
                lAdd.Show();
            }
            else
            {
                MessageBox.Show("Only admins have permissions for this funstionality.");
            }
        }

        private void searchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Program.UserInfo.Role_id) == 1)
            {
                LocationSearch lSearch = new LocationSearch();
                lSearch.Show();
            }
            else
            {
                MessageBox.Show("Only admins have permissions for this funstionality.");
            }
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Program.UserInfo.Role_id) == 1)
            {
                LocationDelete lDelete = new LocationDelete();
                lDelete.Show();
            }
            else
            {
                MessageBox.Show("Only admins have permissions for this funstionality.");
            }
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Program.UserInfo.Role_id) == 1)
            {
                LocationEdit lEdit = new LocationEdit();
                lEdit.Show();
            }
            else
            {
                MessageBox.Show("Only admins have permissions for this funstionality.");
            }
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            images[0] = OODNew.Properties.Resources.image1;
            images[1] = OODNew.Properties.Resources.image2;
            images[2] = OODNew.Properties.Resources.image3;
            images[3] = OODNew.Properties.Resources.image4;
            images[4] = OODNew.Properties.Resources.image5;
            images[5] = OODNew.Properties.Resources.image6;
            string userName = Program.UserInfo.Name;
            string userRoleID = Program.UserInfo.Role_id;
            Program.Connection.Open();
            command = Program.Connection.CreateCommand();
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@roleId", userRoleID);
            command.CommandText = "Select role_name From [Role] where role_id = @roleId";
            reader = command.ExecuteReader();
            reader.Read();
            string userRole = reader.GetValue(0).ToString();
            this.lblNameRole.Text = "User: " + userName + ", Role: " + userRole;
            reader.Close();
            Program.Connection.Close(); 
        }

        private void subMenuLocation_Click(object sender, EventArgs e)
        {
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Logincs login = new Logincs();
            this.Close();
            login.Show();
        }
    }
}
