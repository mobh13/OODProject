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
    public partial class countProperties : Form
    {
        public countProperties()
        {
            InitializeComponent();
        }

        private void countProperties_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RealEstateDataSet.Property' table. You can move, or remove it, as needed.
            this.PropertyTableAdapter.Fill(this.RealEstateDataSet.Property);

            this.reportViewer1.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
