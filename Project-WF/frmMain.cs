using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_WF.Management;

namespace Project_WF
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //private void mntstproducer_Click(object sender, EventArgs e)
        //{
        //      = new ();
        //    .MdiParent = this;
        //    .Show();
        //}

        private void mntstemployee_Click(object sender, EventArgs e)
        {
            frmEmployee frmEmployee = new frmEmployee();
            frmEmployee.MdiParent = this;
            frmEmployee.Show();
        }

        private void mntstproducts_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct();
            frmProduct.MdiParent = this;
            frmProduct.Show();
        }
        private void mntstcustomer_Click(object sender, EventArgs e)
        {
            frmCustmmer frmCustmmer = new frmCustmmer();
            frmCustmmer.MdiParent = this;
            frmCustmmer.Show();
        }
        private void producerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producer producer = new Producer();
            producer.MdiParent = this;
            producer.Show();
        }
        private void mntstorderProduct_Click(object sender, EventArgs e)
        {
            frmOrder frmOrder = new frmOrder();
            frmOrder.MdiParent = this;
            frmOrder.Show();
        }
        private void mntstmanagement_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void mntstexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mntstconfig_Click(object sender, EventArgs e)
        {
            FormConfig formConfig = new FormConfig();
            formConfig.MdiParent = this;
            formConfig.Show();
        }
    }
}
