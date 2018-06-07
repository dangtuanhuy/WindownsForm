namespace Project_WF
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mntstaplication = new System.Windows.Forms.ToolStripMenuItem();
            this.mntstconfig = new System.Windows.Forms.ToolStripMenuItem();
            this.mntstexit = new System.Windows.Forms.ToolStripMenuItem();
            this.mntstmanagement = new System.Windows.Forms.ToolStripMenuItem();
            this.mntripproducer = new System.Windows.Forms.ToolStripMenuItem();
            this.mntstproducts = new System.Windows.Forms.ToolStripMenuItem();
            this.mntstemployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mntstcustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mntstbuying = new System.Windows.Forms.ToolStripMenuItem();
            this.mntstorderProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mntststatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.mntstlistTheCurrency = new System.Windows.Forms.ToolStripMenuItem();
            this.mntstbestSeller = new System.Windows.Forms.ToolStripMenuItem();
            this.mntstoutOfStockProductTool = new System.Windows.Forms.ToolStripMenuItem();
            this.mntsthelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mntstglobalTree = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntstaplication,
            this.mntstmanagement,
            this.mntstbuying,
            this.mntststatistics,
            this.mntsthelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mntstaplication
            // 
            this.mntstaplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntstconfig,
            this.mntstexit});
            this.mntstaplication.Name = "mntstaplication";
            this.mntstaplication.Size = new System.Drawing.Size(73, 20);
            this.mntstaplication.Text = "Aplication";
            // 
            // mntstconfig
            // 
            this.mntstconfig.Name = "mntstconfig";
            this.mntstconfig.Size = new System.Drawing.Size(180, 22);
            this.mntstconfig.Text = "Config";
            this.mntstconfig.Click += new System.EventHandler(this.mntstconfig_Click);
            // 
            // mntstexit
            // 
            this.mntstexit.Name = "mntstexit";
            this.mntstexit.Size = new System.Drawing.Size(180, 22);
            this.mntstexit.Text = "Exit";
            this.mntstexit.Click += new System.EventHandler(this.mntstexit_Click);
            // 
            // mntstmanagement
            // 
            this.mntstmanagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntripproducer,
            this.mntstproducts,
            this.mntstemployee,
            this.mntstcustomer});
            this.mntstmanagement.Name = "mntstmanagement";
            this.mntstmanagement.Size = new System.Drawing.Size(90, 20);
            this.mntstmanagement.Text = "Management";
            this.mntstmanagement.Click += new System.EventHandler(this.mntstmanagement_Click);
            // 
            // mntripproducer
            // 
            this.mntripproducer.Name = "mntripproducer";
            this.mntripproducer.Size = new System.Drawing.Size(126, 22);
            this.mntripproducer.Text = "Producer";
            this.mntripproducer.Click += new System.EventHandler(this.producerToolStripMenuItem_Click);
            // 
            // mntstproducts
            // 
            this.mntstproducts.Name = "mntstproducts";
            this.mntstproducts.Size = new System.Drawing.Size(126, 22);
            this.mntstproducts.Text = "Products";
            this.mntstproducts.Click += new System.EventHandler(this.mntstproducts_Click);
            // 
            // mntstemployee
            // 
            this.mntstemployee.Name = "mntstemployee";
            this.mntstemployee.Size = new System.Drawing.Size(126, 22);
            this.mntstemployee.Text = "Employee";
            this.mntstemployee.Click += new System.EventHandler(this.mntstemployee_Click);
            // 
            // mntstcustomer
            // 
            this.mntstcustomer.Name = "mntstcustomer";
            this.mntstcustomer.Size = new System.Drawing.Size(126, 22);
            this.mntstcustomer.Text = "Customer";
            this.mntstcustomer.Click += new System.EventHandler(this.mntstcustomer_Click);
            // 
            // mntstbuying
            // 
            this.mntstbuying.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntstorderProduct});
            this.mntstbuying.Name = "mntstbuying";
            this.mntstbuying.Size = new System.Drawing.Size(56, 20);
            this.mntstbuying.Text = "Buying";
            // 
            // mntstorderProduct
            // 
            this.mntstorderProduct.Name = "mntstorderProduct";
            this.mntstorderProduct.Size = new System.Drawing.Size(149, 22);
            this.mntstorderProduct.Text = "Order Product";
            this.mntstorderProduct.Click += new System.EventHandler(this.mntstorderProduct_Click);
            // 
            // mntststatistics
            // 
            this.mntststatistics.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntstlistTheCurrency,
            this.mntstbestSeller,
            this.mntstoutOfStockProductTool});
            this.mntststatistics.Name = "mntststatistics";
            this.mntststatistics.Size = new System.Drawing.Size(65, 20);
            this.mntststatistics.Text = "Statistics";
            // 
            // mntstlistTheCurrency
            // 
            this.mntstlistTheCurrency.Name = "mntstlistTheCurrency";
            this.mntstlistTheCurrency.Size = new System.Drawing.Size(184, 22);
            this.mntstlistTheCurrency.Text = "List the currency";
            // 
            // mntstbestSeller
            // 
            this.mntstbestSeller.Name = "mntstbestSeller";
            this.mntstbestSeller.Size = new System.Drawing.Size(184, 22);
            this.mntstbestSeller.Text = "Best Seller";
            // 
            // mntstoutOfStockProductTool
            // 
            this.mntstoutOfStockProductTool.Name = "mntstoutOfStockProductTool";
            this.mntstoutOfStockProductTool.Size = new System.Drawing.Size(184, 22);
            this.mntstoutOfStockProductTool.Text = "Out of stock product";
            // 
            // mntsthelp
            // 
            this.mntsthelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntstglobalTree});
            this.mntsthelp.Name = "mntsthelp";
            this.mntsthelp.Size = new System.Drawing.Size(44, 20);
            this.mntsthelp.Text = "Help";
            // 
            // mntstglobalTree
            // 
            this.mntstglobalTree.Name = "mntstglobalTree";
            this.mntstglobalTree.Size = new System.Drawing.Size(133, 22);
            this.mntstglobalTree.Text = "Global Tree";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mntstaplication;
        private System.Windows.Forms.ToolStripMenuItem mntstconfig;
        private System.Windows.Forms.ToolStripMenuItem mntstexit;
        private System.Windows.Forms.ToolStripMenuItem mntstmanagement;
        private System.Windows.Forms.ToolStripMenuItem mntstproducts;
        private System.Windows.Forms.ToolStripMenuItem mntstemployee;
        private System.Windows.Forms.ToolStripMenuItem mntstcustomer;
        private System.Windows.Forms.ToolStripMenuItem mntstbuying;
        private System.Windows.Forms.ToolStripMenuItem mntstorderProduct;
        private System.Windows.Forms.ToolStripMenuItem mntststatistics;
        private System.Windows.Forms.ToolStripMenuItem mntstlistTheCurrency;
        private System.Windows.Forms.ToolStripMenuItem mntstbestSeller;
        private System.Windows.Forms.ToolStripMenuItem mntstoutOfStockProductTool;
        private System.Windows.Forms.ToolStripMenuItem mntsthelp;
        private System.Windows.Forms.ToolStripMenuItem mntstglobalTree;
        private System.Windows.Forms.ToolStripMenuItem mntripproducer;
    }
}