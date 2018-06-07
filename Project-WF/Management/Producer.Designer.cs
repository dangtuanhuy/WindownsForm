namespace Project_WF.Management
{
    partial class Producer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label producer_idLabel;
            System.Windows.Forms.Label producer_nameLabel;
            System.Windows.Forms.Label producer_descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producer));
            this.sell_ManagementDataSet = new Project_WF.Sell_ManagementDataSet();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.procederDataGridView = new System.Windows.Forms.DataGridView();
            this.produceridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producerTableAdapter = new Project_WF.Sell_ManagementDataSetTableAdapters.producerTableAdapter();
            this.tableAdapterManager = new Project_WF.Sell_ManagementDataSetTableAdapters.TableAdapterManager();
            this.txtIdProceder = new System.Windows.Forms.TextBox();
            this.txtProducer = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            producer_idLabel = new System.Windows.Forms.Label();
            producer_nameLabel = new System.Windows.Forms.Label();
            producer_descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sell_ManagementDataSet)).BeginInit();
            this.grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.procederDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sell_ManagementDataSet
            // 
            this.sell_ManagementDataSet.DataSetName = "Sell_ManagementDataSet";
            this.sell_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.btnBack);
            this.grb1.Controls.Add(this.btnExit);
            this.grb1.Controls.Add(this.btnDelete);
            this.grb1.Controls.Add(this.btnEdit);
            this.grb1.Controls.Add(this.btnAdd);
            this.grb1.Location = new System.Drawing.Point(429, 33);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(272, 222);
            this.grb1.TabIndex = 27;
            this.grb1.TabStop = false;
            this.grb1.Text = "Access";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(165, 35);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 44);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(165, 102);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 44);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(20, 162);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 44);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(17, 102);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 44);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 44);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // procederDataGridView
            // 
            this.procederDataGridView.AutoGenerateColumns = false;
            this.procederDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.procederDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produceridDataGridViewTextBoxColumn,
            this.producernameDataGridViewTextBoxColumn,
            this.producerdescriptionDataGridViewTextBoxColumn});
            this.procederDataGridView.DataSource = this.producerBindingSource;
            this.procederDataGridView.Location = new System.Drawing.Point(20, 105);
            this.procederDataGridView.Name = "procederDataGridView";
            this.procederDataGridView.Size = new System.Drawing.Size(354, 150);
            this.procederDataGridView.TabIndex = 28;
            this.procederDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.procederDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.procederDataGridView_CellContentClick);
            // 
            // produceridDataGridViewTextBoxColumn
            // 
            this.produceridDataGridViewTextBoxColumn.DataPropertyName = "producer_id";
            this.produceridDataGridViewTextBoxColumn.HeaderText = "producer_id";
            this.produceridDataGridViewTextBoxColumn.Name = "produceridDataGridViewTextBoxColumn";
            this.produceridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // producernameDataGridViewTextBoxColumn
            // 
            this.producernameDataGridViewTextBoxColumn.DataPropertyName = "producer_name";
            this.producernameDataGridViewTextBoxColumn.HeaderText = "producer_name";
            this.producernameDataGridViewTextBoxColumn.Name = "producernameDataGridViewTextBoxColumn";
            // 
            // producerdescriptionDataGridViewTextBoxColumn
            // 
            this.producerdescriptionDataGridViewTextBoxColumn.DataPropertyName = "producer_description";
            this.producerdescriptionDataGridViewTextBoxColumn.HeaderText = "producer_description";
            this.producerdescriptionDataGridViewTextBoxColumn.Name = "producerdescriptionDataGridViewTextBoxColumn";
            // 
            // producerBindingSource
            // 
            this.producerBindingSource.DataMember = "producer";
            this.producerBindingSource.DataSource = this.sell_ManagementDataSet;
            // 
            // producerTableAdapter
            // 
            this.producerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.configTableAdapter = null;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.employee_roleTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.object_employeeTableAdapter = null;
            this.tableAdapterManager.object_roleTableAdapter = null;
            this.tableAdapterManager.objectTableAdapter = null;
            this.tableAdapterManager.order_detailsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.producerTableAdapter = this.producerTableAdapter;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.roleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project_WF.Sell_ManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // producer_idLabel
            // 
            producer_idLabel.AutoSize = true;
            producer_idLabel.Location = new System.Drawing.Point(17, 13);
            producer_idLabel.Name = "producer_idLabel";
            producer_idLabel.Size = new System.Drawing.Size(64, 13);
            producer_idLabel.TabIndex = 28;
            producer_idLabel.Text = "Producer id:";
            producer_idLabel.Click += new System.EventHandler(this.producer_idLabel_Click);
            // 
            // txtIdProceder
            // 
            this.txtIdProceder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producerBindingSource, "producer_id", true));
            this.txtIdProceder.Enabled = false;
            this.txtIdProceder.Location = new System.Drawing.Point(129, 6);
            this.txtIdProceder.Name = "txtIdProceder";
            this.txtIdProceder.Size = new System.Drawing.Size(139, 20);
            this.txtIdProceder.TabIndex = 29;
            // 
            // producer_nameLabel
            // 
            producer_nameLabel.AutoSize = true;
            producer_nameLabel.Location = new System.Drawing.Point(17, 41);
            producer_nameLabel.Name = "producer_nameLabel";
            producer_nameLabel.Size = new System.Drawing.Size(82, 13);
            producer_nameLabel.TabIndex = 29;
            producer_nameLabel.Text = "Producer name:";
            // 
            // txtProducer
            // 
            this.txtProducer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producerBindingSource, "producer_name", true));
            this.txtProducer.Location = new System.Drawing.Point(129, 33);
            this.txtProducer.Name = "txtProducer";
            this.txtProducer.Size = new System.Drawing.Size(139, 20);
            this.txtProducer.TabIndex = 30;
            // 
            // producer_descriptionLabel
            // 
            producer_descriptionLabel.AutoSize = true;
            producer_descriptionLabel.Location = new System.Drawing.Point(17, 73);
            producer_descriptionLabel.Name = "producer_descriptionLabel";
            producer_descriptionLabel.Size = new System.Drawing.Size(63, 13);
            producer_descriptionLabel.TabIndex = 30;
            producer_descriptionLabel.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producerBindingSource, "producer_description", true));
            this.txtDescription.Location = new System.Drawing.Point(129, 70);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(139, 20);
            this.txtDescription.TabIndex = 31;
            // 
            // Producer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 308);
            this.Controls.Add(producer_descriptionLabel);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(producer_nameLabel);
            this.Controls.Add(this.txtProducer);
            this.Controls.Add(producer_idLabel);
            this.Controls.Add(this.txtIdProceder);
            this.Controls.Add(this.procederDataGridView);
            this.Controls.Add(this.grb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Producer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Producer";
            this.Load += new System.EventHandler(this.Producer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sell_ManagementDataSet)).EndInit();
            this.grb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.procederDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sell_ManagementDataSet sell_ManagementDataSet;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView procederDataGridView;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private Sell_ManagementDataSetTableAdapters.producerTableAdapter producerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn produceridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerdescriptionDataGridViewTextBoxColumn;
        private Sell_ManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtIdProceder;
        private System.Windows.Forms.TextBox txtProducer;
        private System.Windows.Forms.TextBox txtDescription;
    }
}