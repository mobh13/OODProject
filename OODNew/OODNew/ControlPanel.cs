using System;
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
    public partial class ControlPanel : Form
    {
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
            if (imgCount == 6)
            {
                imgCount = 1;
            }
            slidShow.ImageLocation = string.Format(@"My.Resources.image{0}.jpg", imgCount);
=======
            slidShow.ImageLocation = string.Format("Resources\\1546524291810.jpg");
>>>>>>> e40b2eb9536561e9b1830a596eaf92f16b2d5316
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
            ProfileAdd pAdd = new ProfileAdd();
            pAdd.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileSearch pSearch = new ProfileSearch();
            pSearch.Show();
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
            LocationView lView = new LocationView();
            lView.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LocationAdd lAdd = new LocationAdd();
            lAdd.Show();
        }

        private void searchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LocationSearch lSearch = new LocationSearch();
            lSearch.Show();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocationDelete lDelete = new LocationDelete();
            lDelete.Show();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LocationEdit lEdit = new LocationEdit();
            lEdit.Show();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
