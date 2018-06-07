namespace Project_WF.Management
{
    partial class frmCustmmer
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
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label postal_codeLabel;
            System.Windows.Forms.Label countryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustmmer));
            this.sell_ManagementDataSet = new Project_WF.Sell_ManagementDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAddress1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            postal_codeLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sell_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.grb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 37);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 19);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(12, 72);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(79, 19);
            last_nameLabel.TabIndex = 3;
            last_nameLabel.Text = "Last Name:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(12, 116);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(80, 19);
            first_nameLabel.TabIndex = 5;
            first_nameLabel.Text = "First Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(282, 37);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(45, 19);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(282, 77);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(71, 19);
            companyLabel.TabIndex = 9;
            companyLabel.Text = "Company:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(282, 120);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(50, 19);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Phone:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(566, 44);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(60, 19);
            address1Label.TabIndex = 13;
            address1Label.Text = "Address";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new System.Drawing.Point(566, 84);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(79, 19);
            address2Label.TabIndex = 15;
            address2Label.Text = "Address_1:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(566, 120);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(37, 19);
            cityLabel.TabIndex = 17;
            cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(871, 41);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(43, 19);
            stateLabel.TabIndex = 19;
            stateLabel.Text = "State:";
            // 
            // postal_codeLabel
            // 
            postal_codeLabel.AutoSize = true;
            postal_codeLabel.Location = new System.Drawing.Point(871, 80);
            postal_codeLabel.Name = "postal_codeLabel";
            postal_codeLabel.Size = new System.Drawing.Size(49, 19);
            postal_codeLabel.TabIndex = 21;
            postal_codeLabel.Text = "Postal:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(871, 116);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(61, 19);
            countryLabel.TabIndex = 23;
            countryLabel.Text = "Country:";
            // 
            // sell_ManagementDataSet
            // 
            this.sell_ManagementDataSet.DataSetName = "Sell_ManagementDataSet";
            this.sell_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.sell_ManagementDataSet;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "id", true));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(95, 34);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(140, 26);
            this.txtId.TabIndex = 2;
            this.txtId.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "last_name", true));
            this.txtLastName.Location = new System.Drawing.Point(95, 72);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(140, 26);
            this.txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "first_name", true));
            this.txtFirstName.Location = new System.Drawing.Point(95, 113);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(140, 26);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "email", true));
            this.txtEmail.Location = new System.Drawing.Point(363, 34);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(142, 26);
            this.txtEmail.TabIndex = 8;
            // 
            // txtCompany
            // 
            this.txtCompany.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "company", true));
            this.txtCompany.Location = new System.Drawing.Point(363, 73);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(142, 26);
            this.txtCompany.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "phone", true));
            this.txtPhone.Location = new System.Drawing.Point(363, 120);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(142, 26);
            this.txtPhone.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "address1", true));
            this.txtAddress.Location = new System.Drawing.Point(656, 41);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(172, 26);
            this.txtAddress.TabIndex = 14;
            // 
            // txtAddress1
            // 
            this.txtAddress1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "address2", true));
            this.txtAddress1.Location = new System.Drawing.Point(656, 80);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(172, 26);
            this.txtAddress1.TabIndex = 16;
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "city", true));
            this.txtCity.Location = new System.Drawing.Point(656, 117);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(172, 26);
            this.txtCity.TabIndex = 18;
            // 
            // txtState
            // 
            this.txtState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "state", true));
            this.txtState.Location = new System.Drawing.Point(973, 44);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(177, 26);
            this.txtState.TabIndex = 20;
            // 
            // txtPostal
            // 
            this.txtPostal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "postal_code", true));
            this.txtPostal.Location = new System.Drawing.Point(973, 77);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(177, 26);
            this.txtPostal.TabIndex = 22;
            // 
            // txtCountry
            // 
            this.txtCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "country", true));
            this.txtCountry.Location = new System.Drawing.Point(973, 109);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(177, 26);
            this.txtCountry.TabIndex = 24;
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AutoGenerateColumns = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtId,
            this.dtLastName,
            this.dtFirstName,
            this.dtEmail,
            this.dtCompany,
            this.dtPhone,
            this.dtAddress,
            this.dtAddress1,
            this.dtCity,
            this.dtState,
            this.dtPostal,
            this.dtCountry});
            this.customersDataGridView.DataSource = this.customersBindingSource;
            this.customersDataGridView.Location = new System.Drawing.Point(12, 161);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.Size = new System.Drawing.Size(1213, 175);
            this.customersDataGridView.TabIndex = 25;
            this.customersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDataGridView_CellClick);
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.btnReload);
            this.grb1.Controls.Add(this.btnExit);
            this.grb1.Controls.Add(this.btnDelete);
            this.grb1.Controls.Add(this.btnEdit);
            this.grb1.Controls.Add(this.btnAdd);
            this.grb1.Location = new System.Drawing.Point(295, 344);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(607, 100);
            this.grb1.TabIndex = 26;
            this.grb1.TabStop = false;
            this.grb1.Text = "Access";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(474, 35);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 44);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Back";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(370, 35);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 44);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(249, 35);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 44);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(135, 35);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 44);
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
            // dtId
            // 
            this.dtId.DataPropertyName = "id";
            this.dtId.HeaderText = "id";
            this.dtId.Name = "dtId";
            this.dtId.ReadOnly = true;
            // 
            // dtLastName
            // 
            this.dtLastName.DataPropertyName = "last_name";
            this.dtLastName.HeaderText = "Last Name";
            this.dtLastName.Name = "dtLastName";
            // 
            // dtFirstName
            // 
            this.dtFirstName.DataPropertyName = "first_name";
            this.dtFirstName.HeaderText = "First Name";
            this.dtFirstName.Name = "dtFirstName";
            // 
            // dtEmail
            // 
            this.dtEmail.DataPropertyName = "email";
            this.dtEmail.HeaderText = "Email";
            this.dtEmail.Name = "dtEmail";
            // 
            // dtCompany
            // 
            this.dtCompany.DataPropertyName = "company";
            this.dtCompany.HeaderText = "Company";
            this.dtCompany.Name = "dtCompany";
            // 
            // dtPhone
            // 
            this.dtPhone.DataPropertyName = "phone";
            this.dtPhone.HeaderText = "Phone";
            this.dtPhone.Name = "dtPhone";
            // 
            // dtAddress
            // 
            this.dtAddress.DataPropertyName = "address1";
            this.dtAddress.HeaderText = "Address_1";
            this.dtAddress.Name = "dtAddress";
            // 
            // dtAddress1
            // 
            this.dtAddress1.DataPropertyName = "address2";
            this.dtAddress1.HeaderText = "Address_2";
            this.dtAddress1.Name = "dtAddress1";
            // 
            // dtCity
            // 
            this.dtCity.DataPropertyName = "city";
            this.dtCity.HeaderText = "City";
            this.dtCity.Name = "dtCity";
            // 
            // dtState
            // 
            this.dtState.DataPropertyName = "state";
            this.dtState.HeaderText = "State";
            this.dtState.Name = "dtState";
            // 
            // dtPostal
            // 
            this.dtPostal.DataPropertyName = "postal_code";
            this.dtPostal.HeaderText = "Postal";
            this.dtPostal.Name = "dtPostal";
            // 
            // dtCountry
            // 
            this.dtCountry.DataPropertyName = "country";
            this.dtCountry.HeaderText = "Country";
            this.dtCountry.Name = "dtCountry";
            // 
            // frmCustmmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 456);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(postal_codeLabel);
            this.Controls.Add(this.txtPostal);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.txtState);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.txtId);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustmmer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Customer";
            this.Load += new System.EventHandler(this.frmCustmmer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sell_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.grb1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sell_ManagementDataSet sell_ManagementDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAddress1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtState;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCountry;
    }
}