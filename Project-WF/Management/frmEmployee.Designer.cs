namespace Project_WF.Management
{
    partial class frmEmployee
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
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label job_titleLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label postal_codeLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label address1Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.sell_ManagementDataSet = new Project_WF.Sell_ManagementDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtFirstNameEmp = new System.Windows.Forms.TextBox();
            this.txtLastNamesEmp = new System.Windows.Forms.TextBox();
            this.txtEmailEmp = new System.Windows.Forms.TextBox();
            this.birthdayEmp = new System.Windows.Forms.DateTimePicker();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.dtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbox = new System.Windows.Forms.GroupBox();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtIdEmp = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.ptxPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            last_nameLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            job_titleLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            postal_codeLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sell_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.grb1.SuspendLayout();
            this.grbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(33, 34);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(79, 19);
            last_nameLabel.TabIndex = 1;
            last_nameLabel.Text = "Last Name:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(33, 73);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(80, 19);
            first_nameLabel.TabIndex = 3;
            first_nameLabel.Text = "First Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(33, 146);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(45, 19);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(346, 41);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(63, 19);
            birthdayLabel.TabIndex = 7;
            birthdayLabel.Text = "Birthday:";
            // 
            // job_titleLabel
            // 
            job_titleLabel.AutoSize = true;
            job_titleLabel.Location = new System.Drawing.Point(346, 80);
            job_titleLabel.Name = "job_titleLabel";
            job_titleLabel.Size = new System.Drawing.Size(34, 19);
            job_titleLabel.TabIndex = 9;
            job_titleLabel.Text = "Job:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(346, 117);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(83, 19);
            departmentLabel.TabIndex = 11;
            departmentLabel.Text = "Department:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(670, 69);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(37, 19);
            cityLabel.TabIndex = 13;
            cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(670, 109);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(43, 19);
            stateLabel.TabIndex = 15;
            stateLabel.Text = "State:";
            // 
            // postal_codeLabel
            // 
            postal_codeLabel.AutoSize = true;
            postal_codeLabel.Location = new System.Drawing.Point(670, 155);
            postal_codeLabel.Name = "postal_codeLabel";
            postal_codeLabel.Size = new System.Drawing.Size(87, 19);
            postal_codeLabel.TabIndex = 17;
            postal_codeLabel.Text = "Postal Code:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(29, 187);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(57, 19);
            genderLabel.TabIndex = 20;
            genderLabel.Text = "Gender:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(346, 152);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(50, 19);
            phoneLabel.TabIndex = 22;
            phoneLabel.Text = "Phone:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(33, 113);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(72, 19);
            passwordLabel.TabIndex = 28;
            passwordLabel.Text = "Password:";
            passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(346, 201);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(61, 19);
            countryLabel.TabIndex = 29;
            countryLabel.Text = "Country:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(670, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(25, 19);
            idLabel.TabIndex = 30;
            idLabel.Text = "Id:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(670, 205);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(63, 19);
            address1Label.TabIndex = 31;
            address1Label.Text = "Address:";
            // 
            // sell_ManagementDataSet
            // 
            this.sell_ManagementDataSet.DataSetName = "Sell_ManagementDataSet";
            this.sell_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.sell_ManagementDataSet;
            // 
            // txtFirstNameEmp
            // 
            this.txtFirstNameEmp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "last_name", true));
            this.txtFirstNameEmp.Location = new System.Drawing.Point(118, 34);
            this.txtFirstNameEmp.Name = "txtFirstNameEmp";
            this.txtFirstNameEmp.Size = new System.Drawing.Size(176, 26);
            this.txtFirstNameEmp.TabIndex = 2;
            // 
            // txtLastNamesEmp
            // 
            this.txtLastNamesEmp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "first_name", true));
            this.txtLastNamesEmp.Location = new System.Drawing.Point(119, 73);
            this.txtLastNamesEmp.Name = "txtLastNamesEmp";
            this.txtLastNamesEmp.Size = new System.Drawing.Size(176, 26);
            this.txtLastNamesEmp.TabIndex = 4;
            // 
            // txtEmailEmp
            // 
            this.txtEmailEmp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "email", true));
            this.txtEmailEmp.Location = new System.Drawing.Point(118, 143);
            this.txtEmailEmp.Name = "txtEmailEmp";
            this.txtEmailEmp.Size = new System.Drawing.Size(176, 26);
            this.txtEmailEmp.TabIndex = 6;
            // 
            // birthdayEmp
            // 
            this.birthdayEmp.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "birthday", true));
            this.birthdayEmp.Location = new System.Drawing.Point(435, 41);
            this.birthdayEmp.Name = "birthdayEmp";
            this.birthdayEmp.Size = new System.Drawing.Size(200, 26);
            this.birthdayEmp.TabIndex = 8;
            // 
            // txtJob
            // 
            this.txtJob.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "job_title", true));
            this.txtJob.Location = new System.Drawing.Point(435, 80);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(200, 26);
            this.txtJob.TabIndex = 10;
            // 
            // txtDepartment
            // 
            this.txtDepartment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "department", true));
            this.txtDepartment.Location = new System.Drawing.Point(435, 117);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(200, 26);
            this.txtDepartment.TabIndex = 12;
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "city", true));
            this.txtCity.Location = new System.Drawing.Point(768, 66);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(140, 26);
            this.txtCity.TabIndex = 14;
            // 
            // txtState
            // 
            this.txtState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "state", true));
            this.txtState.Location = new System.Drawing.Point(768, 106);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(140, 26);
            this.txtState.TabIndex = 16;
            // 
            // txtPostCode
            // 
            this.txtPostCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "postal_code", true));
            this.txtPostCode.Location = new System.Drawing.Point(768, 145);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(140, 26);
            this.txtPostCode.TabIndex = 18;
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AutoGenerateColumns = false;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtId,
            this.dtLastName,
            this.dtFirstName,
            this.dtEmail,
            this.dtPass,
            this.dtGender,
            this.dtBirthday,
            this.dtJob,
            this.dtDepartment,
            this.dtPhone,
            this.dtCountry,
            this.dtCity,
            this.dtState,
            this.dtPostal,
            this.dtAddress});
            this.employeesDataGridView.DataSource = this.employeesBindingSource;
            this.employeesDataGridView.Location = new System.Drawing.Point(33, 251);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.Size = new System.Drawing.Size(1134, 220);
            this.employeesDataGridView.TabIndex = 19;
            this.employeesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeesDataGridView_CellClick);
            this.employeesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeesDataGridView_CellContentClick);
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
            // dtPass
            // 
            this.dtPass.DataPropertyName = "password";
            this.dtPass.HeaderText = "Password";
            this.dtPass.Name = "dtPass";
            // 
            // dtGender
            // 
            this.dtGender.DataPropertyName = "gender";
            this.dtGender.HeaderText = "Gender";
            this.dtGender.Name = "dtGender";
            // 
            // dtBirthday
            // 
            this.dtBirthday.DataPropertyName = "birthday";
            this.dtBirthday.HeaderText = "Birthday";
            this.dtBirthday.Name = "dtBirthday";
            // 
            // dtJob
            // 
            this.dtJob.DataPropertyName = "job_title";
            this.dtJob.HeaderText = "Job";
            this.dtJob.Name = "dtJob";
            // 
            // dtDepartment
            // 
            this.dtDepartment.DataPropertyName = "department";
            this.dtDepartment.HeaderText = "Department";
            this.dtDepartment.Name = "dtDepartment";
            // 
            // dtPhone
            // 
            this.dtPhone.DataPropertyName = "phone";
            this.dtPhone.HeaderText = "Phone";
            this.dtPhone.Name = "dtPhone";
            // 
            // dtCountry
            // 
            this.dtCountry.DataPropertyName = "country";
            this.dtCountry.HeaderText = "Country";
            this.dtCountry.Name = "dtCountry";
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
            // dtAddress
            // 
            this.dtAddress.DataPropertyName = "address1";
            this.dtAddress.HeaderText = "Address";
            this.dtAddress.Name = "dtAddress";
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "phone", true));
            this.txtPhone.Location = new System.Drawing.Point(435, 152);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 26);
            this.txtPhone.TabIndex = 23;
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.btnBack);
            this.grb1.Controls.Add(this.btnExit);
            this.grb1.Controls.Add(this.btnDelete);
            this.grb1.Controls.Add(this.btnEdit);
            this.grb1.Controls.Add(this.btnAdd);
            this.grb1.Location = new System.Drawing.Point(283, 495);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(607, 100);
            this.grb1.TabIndex = 27;
            this.grb1.TabStop = false;
            this.grb1.Text = "Access";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(470, 35);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 44);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(370, 35);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 44);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grbox
            // 
            this.grbox.Controls.Add(this.rdFemale);
            this.grbox.Controls.Add(this.rdMale);
            this.grbox.Location = new System.Drawing.Point(118, 174);
            this.grbox.Name = "grbox";
            this.grbox.Size = new System.Drawing.Size(176, 71);
            this.grbox.TabIndex = 28;
            this.grbox.TabStop = false;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(7, 44);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(71, 23);
            this.rdFemale.TabIndex = 1;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            this.rdFemale.CheckedChanged += new System.EventHandler(this.rdFemale_CheckedChanged);
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.Location = new System.Drawing.Point(7, 14);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(58, 23);
            this.rdMale.TabIndex = 0;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            this.rdMale.CheckedChanged += new System.EventHandler(this.rdMale_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "password", true));
            this.txtPassword.Location = new System.Drawing.Point(119, 110);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(175, 26);
            this.txtPassword.TabIndex = 29;
            // 
            // txtCountry
            // 
            this.txtCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "country", true));
            this.txtCountry.Location = new System.Drawing.Point(435, 198);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(200, 26);
            this.txtCountry.TabIndex = 30;
            // 
            // txtIdEmp
            // 
            this.txtIdEmp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "id", true));
            this.txtIdEmp.Enabled = false;
            this.txtIdEmp.Location = new System.Drawing.Point(768, 34);
            this.txtIdEmp.Name = "txtIdEmp";
            this.txtIdEmp.Size = new System.Drawing.Size(140, 26);
            this.txtIdEmp.TabIndex = 31;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "address1", true));
            this.txtAddress.Location = new System.Drawing.Point(768, 194);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(140, 26);
            this.txtAddress.TabIndex = 32;
            // 
            // ptxPicture
            // 
            this.ptxPicture.Location = new System.Drawing.Point(997, 37);
            this.ptxPicture.Name = "ptxPicture";
            this.ptxPicture.Size = new System.Drawing.Size(146, 137);
            this.ptxPicture.TabIndex = 33;
            this.ptxPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(937, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Avartar";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(997, 192);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(146, 36);
            this.btnUpload.TabIndex = 35;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 640);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptxPicture);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.txtIdEmp);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.grbox);
            this.Controls.Add(this.grb1);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.employeesDataGridView);
            this.Controls.Add(postal_codeLabel);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.txtState);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(job_titleLabel);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayEmp);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.txtEmailEmp);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.txtLastNamesEmp);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(this.txtFirstNameEmp);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Employee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sell_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.grb1.ResumeLayout(false);
            this.grbox.ResumeLayout(false);
            this.grbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sell_ManagementDataSet sell_ManagementDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.TextBox txtFirstNameEmp;
        private System.Windows.Forms.TextBox txtLastNamesEmp;
        private System.Windows.Forms.TextBox txtEmailEmp;
        private System.Windows.Forms.DateTimePicker birthdayEmp;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grbox;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtIdEmp;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.PictureBox ptxPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtState;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAddress;
    }
}