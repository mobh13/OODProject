using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Forms_Application
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }
        void ExpandPath(TreeNode SelectedNode)
        {
            while (SelectedNode.Parent != null)
            {
                SelectedNode.Parent.Expand();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeView1.CollapseAll();
            ExpandPath(e.Node);
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            treeView1.CollapseAll();
            ExpandPath(e.Node);
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            treeView1.CollapseAll();
            ExpandPath(e.Node);
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private int imgCount = 6;

        private void loadNextImage()
        {
            if (imgCount == 6)
            {
                imgCount = 1;
            }
            slidShow.ImageLocation = string.Format(@"images\image{0}.jpg",imgCount);
            imgCount++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                if (e.Node.Parent.Text == "Profile")
                {
                    if (e.Node.Text == "View")
                    {
                        ProfileView pView = new ProfileView();
                        pView.Show();
                    }
                    else if (e.Node.Text == "Search")
                    {
                        ProfileSearch pSearch = new ProfileSearch();
                        pSearch.Show();
                    }
                    else if (e.Node.Text == "Add")
                    {
                        ProfileAdd pAdd = new ProfileAdd();
                        pAdd.Show();
                    }
                    else if (e.Node.Text == "Edit")
                    {
                        ProfileEdit pEdit = new ProfileEdit();
                        pEdit.Show();
                    }
                    else if (e.Node.Text == "Delete")
                    {
                        ProfileDelete pDelete = new ProfileDelete();
                        pDelete.Show();
                    }
                }else if (e.Node.Parent.Text == "Location")
                {
                    if (e.Node.Text == "View")
                    {
                        LocationView lView = new LocationView();
                        lView.Show();
                    }
                    else if (e.Node.Text == "Search")
                    {
                        LocationSearch lSearch = new LocationSearch();
                        lSearch.Show();
                    }
                    else if (e.Node.Text == "Add")
                    {
                        LocationAdd lAdd = new LocationAdd();
                        lAdd.Show();
                    }
                    else if (e.Node.Text == "Edit")
                    {
                        LocationEdit lEdit = new LocationEdit();
                        lEdit.Show();
                    }
                    else if (e.Node.Text == "Delete")
                    {
                        LocationDelete lDelete = new LocationDelete();
                        lDelete.Show();
                    }
                }
                else if (e.Node.Parent.Text == "Property")
                {
                    if (e.Node.Text == "View")
                    {
                        PropertView pView = new PropertView();
                        pView.Show();
                    }
                    else if (e.Node.Text == "Search")
                    {
                        PropertySearch pSearch = new PropertySearch();
                        pSearch.Show();
                    }
                    else if (e.Node.Text == "Add")
                    {
                        PropertyAdd pAdd = new PropertyAdd();
                        pAdd.Show();
                    }
                    else if (e.Node.Text == "Edit")
                    {
                        PropertyEdit pEdit = new PropertyEdit();
                        pEdit.Show();
                    }
                    else if (e.Node.Text == "Delete")
                    {
                        PropertyDelete pDelete = new PropertyDelete();
                        pDelete.Show();
                    }
                    else if (e.Node.Text == "Sell & Buy")
                    {
                        PropertyBuySell pBuySell = new PropertyBuySell();
                        pBuySell.Show();
                    }
                }
            }
        }
    }
}
