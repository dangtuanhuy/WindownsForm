namespace Project_WF
{
    partial class FormConfig
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label keyLabel1;
            System.Windows.Forms.Label valuesLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDeleteConfig = new System.Windows.Forms.Button();
            this.btnEditConfig = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.configDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valuesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.configBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sell_ManagementDataSet1 = new Project_WF.Sell_ManagementDataSet();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtValues = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            keyLabel1 = new System.Windows.Forms.Label();
            valuesLabel1 = new System.Windows.Forms.Label();
            this.grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sell_ManagementDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 27;
            idLabel.Text = "Id:";
            // 
            // keyLabel1
            // 
            keyLabel1.AutoSize = true;
            keyLabel1.Location = new System.Drawing.Point(275, 9);
            keyLabel1.Name = "keyLabel1";
            keyLabel1.Size = new System.Drawing.Size(28, 13);
            keyLabel1.TabIndex = 28;
            keyLabel1.Text = "Key:";
            // 
            // valuesLabel1
            // 
            valuesLabel1.AutoSize = true;
            valuesLabel1.Location = new System.Drawing.Point(261, 44);
            valuesLabel1.Name = "valuesLabel1";
            valuesLabel1.Size = new System.Drawing.Size(42, 13);
            valuesLabel1.TabIndex = 29;
            valuesLabel1.Text = "Values:";
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.button5);
            this.grb1.Controls.Add(this.button4);
            this.grb1.Controls.Add(this.btnDeleteConfig);
            this.grb1.Controls.Add(this.btnEditConfig);
            this.grb1.Controls.Add(this.button1);
            this.grb1.Location = new System.Drawing.Point(27, 205);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(540, 69);
            this.grb1.TabIndex = 27;
            this.grb1.TabStop = false;
            this.grb1.Text = "Access";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(474, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 36);
            this.button5.TabIndex = 4;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(370, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDeleteConfig
            // 
            this.btnDeleteConfig.Location = new System.Drawing.Point(249, 19);
            this.btnDeleteConfig.Name = "btnDeleteConfig";
            this.btnDeleteConfig.Size = new System.Drawing.Size(63, 36);
            this.btnDeleteConfig.TabIndex = 2;
            this.btnDeleteConfig.Text = "Delete";
            this.btnDeleteConfig.UseVisualStyleBackColor = true;
            this.btnDeleteConfig.Click += new System.EventHandler(this.btnDeleteConfig_Click);
            // 
            // btnEditConfig
            // 
            this.btnEditConfig.Location = new System.Drawing.Point(135, 19);
            this.btnEditConfig.Name = "btnEditConfig";
            this.btnEditConfig.Size = new System.Drawing.Size(61, 36);
            this.btnEditConfig.TabIndex = 1;
            this.btnEditConfig.Text = "Edit";
            this.btnEditConfig.UseVisualStyleBackColor = true;
            this.btnEditConfig.Click += new System.EventHandler(this.btnEditConfig_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // configDataGridView
            // 
            this.configDataGridView.AutoGenerateColumns = false;
            this.configDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.configDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.keyDataGridViewTextBoxColumn,
            this.valuesDataGridViewTextBoxColumn});
            this.configDataGridView.DataSource = this.configBindingSource;
            this.configDataGridView.Location = new System.Drawing.Point(64, 76);
            this.configDataGridView.Name = "configDataGridView";
            this.configDataGridView.Size = new System.Drawing.Size(418, 108);
            this.configDataGridView.TabIndex = 27;
            this.configDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.configDataGridView_CellClick);
            this.configDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.configDataGridView_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keyDataGridViewTextBoxColumn
            // 
            this.keyDataGridViewTextBoxColumn.DataPropertyName = "Key";
            this.keyDataGridViewTextBoxColumn.HeaderText = "Key";
            this.keyDataGridViewTextBoxColumn.Name = "keyDataGridViewTextBoxColumn";
            // 
            // valuesDataGridViewTextBoxColumn
            // 
            this.valuesDataGridViewTextBoxColumn.DataPropertyName = "Values";
            this.valuesDataGridViewTextBoxColumn.HeaderText = "Values";
            this.valuesDataGridViewTextBoxColumn.Name = "valuesDataGridViewTextBoxColumn";
            // 
            // configBindingSource
            // 
            this.configBindingSource.DataMember = "config";
            this.configBindingSource.DataSource = this.sell_ManagementDataSet1;
            // 
            // sell_ManagementDataSet1
            // 
            this.sell_ManagementDataSet1.DataSetName = "Sell_ManagementDataSet";
            this.sell_ManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(66, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(171, 20);
            this.txtId.TabIndex = 28;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(309, 6);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(173, 20);
            this.txtKey.TabIndex = 29;
            // 
            // txtValues
            // 
            this.txtValues.Location = new System.Drawing.Point(309, 41);
            this.txtValues.Name = "txtValues";
            this.txtValues.Size = new System.Drawing.Size(173, 20);
            this.txtValues.TabIndex = 30;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 294);
            this.Controls.Add(valuesLabel1);
            this.Controls.Add(this.txtValues);
            this.Controls.Add(keyLabel1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.configDataGridView);
            this.Controls.Add(this.grb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FormConfig";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.grb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.configDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sell_ManagementDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDeleteConfig;
        private System.Windows.Forms.Button btnEditConfig;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView configDataGridView;
        private Sell_ManagementDataSet sell_ManagementDataSet1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtValues;
        private System.Windows.Forms.BindingSource configBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valuesDataGridViewTextBoxColumn;
    }
}