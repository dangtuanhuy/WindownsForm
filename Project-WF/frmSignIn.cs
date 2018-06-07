using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_WF
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void frmSignIn_FormClosing(object sender, FormClosingEventArgs e)
        {

            MessageBox.Show("Closed Programs");
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            
            string username = txtUsername.Text;
            string pass = txtPassword.Text;
            //check username && pass
            if(username == "adminstrator" && pass =="12345")
            {
                MessageBox.Show("Sign In success");
                this.Hide();
                this.BackColor = Color.Green;
                //Gọi hàm Show
                frmMain frm = new frmMain();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username and password false");
                this.BackColor = Color.Black;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
