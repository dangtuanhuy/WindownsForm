using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_WF.Management
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();

            //List<sss> data;
            //foreach()
            //{
                
            //    comboBox1.Items.Add("{0}-{1}", item.id, item.ten);
            //}
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sell_ManagementDataSet);

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sell_ManagementDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.sell_ManagementDataSet.products);

        }

        private void productsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
        public void addCombobox()
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmMain().Show();
        }
    }
}
