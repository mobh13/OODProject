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
    public partial class UsersCount : Form
    {
        public UsersCount()
        {
            InitializeComponent();
        }

        private void UsersCount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RealEstateDataSet.User' table. You can move, or remove it, as needed.
            this.UserTableAdapter.Fill(this.RealEstateDataSet.User);

            this.reportViewer1.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
