namespace Project_WF.Management
{
    partial class frmOrder
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
            System.Windows.Forms.Label employee_idLabel;
            System.Windows.Forms.Label customer_idLabel;
            System.Windows.Forms.Label order_dateLabel;
            System.Windows.Forms.Label shipped_dateLabel;
            System.Windows.Forms.Label ship_nameLabel;
            System.Windows.Forms.Label ship_address1Label;
            System.Windows.Forms.Label ship_address2Label;
            System.Windows.Forms.Label ship_cityLabel;
            System.Windows.Forms.Label ship_stateLabel;
            System.Windows.Forms.Label ship_postal_codeLabel;
            System.Windows.Forms.Label ship_countryLabel;
            System.Windows.Forms.Label shipping_feeLabel;
            System.Windows.Forms.Label payment_typeLabel;
            System.Windows.Forms.Label paid_dateLabel;
            System.Windows.Forms.Label order_statusLabel;
            System.Windows.Forms.Label product_idLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label unit_priceLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label order_detail_statusLabel;
            System.Windows.Forms.Label date_allocatedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.dpkPaid = new System.Windows.Forms.DateTimePicker();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.txtShipFee = new System.Windows.Forms.TextBox();
            this.txtShipCountry = new System.Windows.Forms.TextBox();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtShipCity = new System.Windows.Forms.TextBox();
            this.txtShipAddress2 = new System.Windows.Forms.TextBox();
            this.txtShipAddress = new System.Windows.Forms.TextBox();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.shipperDate = new System.Windows.Forms.DateTimePicker();
            this.orderDate = new System.Windows.Forms.DateTimePicker();
            this.sell_ManagementDataSet = new Project_WF.Sell_ManagementDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.cbbProduct = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dpkAllocated = new System.Windows.Forms.DateTimePicker();
            this.order_detail_statusTextBox = new System.Windows.Forms.TextBox();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grboxOrder = new System.Windows.Forms.GroupBox();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.dtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtShipDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtShipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtShipAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtShipAddress2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtShipCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtShipState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPostCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtShipFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPaidDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.dtptoDate = new System.Windows.Forms.DateTimePicker();
            this.dtpfromdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idData = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            employee_idLabel = new System.Windows.Forms.Label();
            customer_idLabel = new System.Windows.Forms.Label();
            order_dateLabel = new System.Windows.Forms.Label();
            shipped_dateLabel = new System.Windows.Forms.Label();
            ship_nameLabel = new System.Windows.Forms.Label();
            ship_address1Label = new System.Windows.Forms.Label();
            ship_address2Label = new System.Windows.Forms.Label();
            ship_cityLabel = new System.Windows.Forms.Label();
            ship_stateLabel = new System.Windows.Forms.Label();
            ship_postal_codeLabel = new System.Windows.Forms.Label();
            ship_countryLabel = new System.Windows.Forms.Label();
            shipping_feeLabel = new System.Windows.Forms.Label();
            payment_typeLabel = new System.Windows.Forms.Label();
            paid_dateLabel = new System.Windows.Forms.Label();
            order_statusLabel = new System.Windows.Forms.Label();
            product_idLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            unit_priceLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            order_detail_statusLabel = new System.Windows.Forms.Label();
            date_allocatedLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sell_ManagementDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.grb1.SuspendLayout();
            this.grboxOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idData)).BeginInit();
            this.SuspendLayout();
            // 
            // employee_idLabel
            // 
            employee_idLabel.AutoSize = true;
            employee_idLabel.Location = new System.Drawing.Point(27, 32);
            employee_idLabel.Name = "employee_idLabel";
            employee_idLabel.Size = new System.Drawing.Size(62, 15);
            employee_idLabel.TabIndex = 0;
            employee_idLabel.Text = "Employee:";
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.Location = new System.Drawing.Point(27, 69);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(75, 15);
            customer_idLabel.TabIndex = 2;
            customer_idLabel.Text = "Customer Id:";
            // 
            // order_dateLabel
            // 
            order_dateLabel.AutoSize = true;
            order_dateLabel.Location = new System.Drawing.Point(27, 106);
            order_dateLabel.Name = "order_dateLabel";
            order_dateLabel.Size = new System.Drawing.Size(68, 15);
            order_dateLabel.TabIndex = 4;
            order_dateLabel.Text = "Order Date:";
            // 
            // shipped_dateLabel
            // 
            shipped_dateLabel.AutoSize = true;
            shipped_dateLabel.Location = new System.Drawing.Point(27, 138);
            shipped_dateLabel.Name = "shipped_dateLabel";
            shipped_dateLabel.Size = new System.Drawing.Size(82, 15);
            shipped_dateLabel.TabIndex = 6;
            shipped_dateLabel.Text = "Shipped Date:";
            // 
            // ship_nameLabel
            // 
            ship_nameLabel.AutoSize = true;
            ship_nameLabel.Location = new System.Drawing.Point(27, 177);
            ship_nameLabel.Name = "ship_nameLabel";
            ship_nameLabel.Size = new System.Drawing.Size(67, 15);
            ship_nameLabel.TabIndex = 8;
            ship_nameLabel.Text = "Ship Name:";
            // 
            // ship_address1Label
            // 
            ship_address1Label.AutoSize = true;
            ship_address1Label.Location = new System.Drawing.Point(27, 218);
            ship_address1Label.Name = "ship_address1Label";
            ship_address1Label.Size = new System.Drawing.Size(88, 15);
            ship_address1Label.TabIndex = 10;
            ship_address1Label.Text = "Ship Address1:";
            // 
            // ship_address2Label
            // 
            ship_address2Label.AutoSize = true;
            ship_address2Label.Location = new System.Drawing.Point(337, 32);
            ship_address2Label.Name = "ship_address2Label";
            ship_address2Label.Size = new System.Drawing.Size(88, 15);
            ship_address2Label.TabIndex = 12;
            ship_address2Label.Text = "Ship Address2:";
            // 
            // ship_cityLabel
            // 
            ship_cityLabel.AutoSize = true;
            ship_cityLabel.Location = new System.Drawing.Point(337, 69);
            ship_cityLabel.Name = "ship_cityLabel";
            ship_cityLabel.Size = new System.Drawing.Size(57, 15);
            ship_cityLabel.TabIndex = 14;
            ship_cityLabel.Text = "Ship city:";
            // 
            // ship_stateLabel
            // 
            ship_stateLabel.AutoSize = true;
            ship_stateLabel.Location = new System.Drawing.Point(337, 113);
            ship_stateLabel.Name = "ship_stateLabel";
            ship_stateLabel.Size = new System.Drawing.Size(63, 15);
            ship_stateLabel.TabIndex = 16;
            ship_stateLabel.Text = "Ship state:";
            // 
            // ship_postal_codeLabel
            // 
            ship_postal_codeLabel.AutoSize = true;
            ship_postal_codeLabel.Location = new System.Drawing.Point(337, 145);
            ship_postal_codeLabel.Name = "ship_postal_codeLabel";
            ship_postal_codeLabel.Size = new System.Drawing.Size(99, 15);
            ship_postal_codeLabel.TabIndex = 18;
            ship_postal_codeLabel.Text = "Ship postal code:";
            // 
            // ship_countryLabel
            // 
            ship_countryLabel.AutoSize = true;
            ship_countryLabel.Location = new System.Drawing.Point(337, 184);
            ship_countryLabel.Name = "ship_countryLabel";
            ship_countryLabel.Size = new System.Drawing.Size(79, 15);
            ship_countryLabel.TabIndex = 20;
            ship_countryLabel.Text = "Ship country:";
            // 
            // shipping_feeLabel
            // 
            shipping_feeLabel.AutoSize = true;
            shipping_feeLabel.Location = new System.Drawing.Point(337, 225);
            shipping_feeLabel.Name = "shipping_feeLabel";
            shipping_feeLabel.Size = new System.Drawing.Size(77, 15);
            shipping_feeLabel.TabIndex = 22;
            shipping_feeLabel.Text = "Shipping fee:";
            // 
            // payment_typeLabel
            // 
            payment_typeLabel.AutoSize = true;
            payment_typeLabel.Location = new System.Drawing.Point(608, 38);
            payment_typeLabel.Name = "payment_typeLabel";
            payment_typeLabel.Size = new System.Drawing.Size(83, 15);
            payment_typeLabel.TabIndex = 24;
            payment_typeLabel.Text = "Payment type:";
            // 
            // paid_dateLabel
            // 
            paid_dateLabel.AutoSize = true;
            paid_dateLabel.Location = new System.Drawing.Point(608, 84);
            paid_dateLabel.Name = "paid_dateLabel";
            paid_dateLabel.Size = new System.Drawing.Size(59, 15);
            paid_dateLabel.TabIndex = 26;
            paid_dateLabel.Text = "Paid date:";
            // 
            // order_statusLabel
            // 
            order_statusLabel.AutoSize = true;
            order_statusLabel.Location = new System.Drawing.Point(608, 131);
            order_statusLabel.Name = "order_statusLabel";
            order_statusLabel.Size = new System.Drawing.Size(76, 15);
            order_statusLabel.TabIndex = 28;
            order_statusLabel.Text = "Order status:";
            // 
            // product_idLabel
            // 
            product_idLabel.AutoSize = true;
            product_idLabel.Location = new System.Drawing.Point(27, 39);
            product_idLabel.Name = "product_idLabel";
            product_idLabel.Size = new System.Drawing.Size(66, 15);
            product_idLabel.TabIndex = 0;
            product_idLabel.Text = "Product Id:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(27, 86);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(57, 15);
            quantityLabel.TabIndex = 2;
            quantityLabel.Text = "Quantity:";
            // 
            // unit_priceLabel
            // 
            unit_priceLabel.AutoSize = true;
            unit_priceLabel.Location = new System.Drawing.Point(262, 43);
            unit_priceLabel.Name = "unit_priceLabel";
            unit_priceLabel.Size = new System.Drawing.Size(62, 15);
            unit_priceLabel.TabIndex = 4;
            unit_priceLabel.Text = "Unit Price:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(267, 87);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(59, 15);
            discountLabel.TabIndex = 6;
            discountLabel.Text = "Discount:";
            // 
            // order_detail_statusLabel
            // 
            order_detail_statusLabel.AutoSize = true;
            order_detail_statusLabel.Location = new System.Drawing.Point(508, 42);
            order_detail_statusLabel.Name = "order_detail_statusLabel";
            order_detail_statusLabel.Size = new System.Drawing.Size(77, 15);
            order_detail_statusLabel.TabIndex = 8;
            order_detail_statusLabel.Text = "Order Status:";
            // 
            // date_allocatedLabel
            // 
            date_allocatedLabel.AutoSize = true;
            date_allocatedLabel.Location = new System.Drawing.Point(508, 92);
            date_allocatedLabel.Name = "date_allocatedLabel";
            date_allocatedLabel.Size = new System.Drawing.Size(62, 15);
            date_allocatedLabel.TabIndex = 10;
            date_allocatedLabel.Text = "Allocated:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCustomer);
            this.groupBox1.Controls.Add(this.cboEmployee);
            this.groupBox1.Controls.Add(order_statusLabel);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(paid_dateLabel);
            this.groupBox1.Controls.Add(this.dpkPaid);
            this.groupBox1.Controls.Add(payment_typeLabel);
            this.groupBox1.Controls.Add(this.txtPayment);
            this.groupBox1.Controls.Add(shipping_feeLabel);
            this.groupBox1.Controls.Add(this.txtShipFee);
            this.groupBox1.Controls.Add(ship_countryLabel);
            this.groupBox1.Controls.Add(this.txtShipCountry);
            this.groupBox1.Controls.Add(ship_postal_codeLabel);
            this.groupBox1.Controls.Add(this.txtPostal);
            this.groupBox1.Controls.Add(ship_stateLabel);
            this.groupBox1.Controls.Add(this.txtState);
            this.groupBox1.Controls.Add(ship_cityLabel);
            this.groupBox1.Controls.Add(this.txtShipCity);
            this.groupBox1.Controls.Add(ship_address2Label);
            this.groupBox1.Controls.Add(this.txtShipAddress2);
            this.groupBox1.Controls.Add(ship_address1Label);
            this.groupBox1.Controls.Add(this.txtShipAddress);
            this.groupBox1.Controls.Add(ship_nameLabel);
            this.groupBox1.Controls.Add(this.txtShipName);
            this.groupBox1.Controls.Add(shipped_dateLabel);
            this.groupBox1.Controls.Add(this.shipperDate);
            this.groupBox1.Controls.Add(order_dateLabel);
            this.groupBox1.Controls.Add(this.orderDate);
            this.groupBox1.Controls.Add(customer_idLabel);
            this.groupBox1.Controls.Add(employee_idLabel);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(303, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information of Order";
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(118, 66);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(200, 23);
            this.cboCustomer.TabIndex = 31;
            // 
            // cboEmployee
            // 
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(118, 32);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(198, 23);
            this.cboEmployee.TabIndex = 30;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(699, 122);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(159, 22);
            this.txtStatus.TabIndex = 29;
            // 
            // dpkPaid
            // 
            this.dpkPaid.Location = new System.Drawing.Point(699, 76);
            this.dpkPaid.Name = "dpkPaid";
            this.dpkPaid.Size = new System.Drawing.Size(159, 22);
            this.dpkPaid.TabIndex = 27;
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(699, 38);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(159, 22);
            this.txtPayment.TabIndex = 25;
            // 
            // txtShipFee
            // 
            this.txtShipFee.Location = new System.Drawing.Point(438, 225);
            this.txtShipFee.Name = "txtShipFee";
            this.txtShipFee.Size = new System.Drawing.Size(162, 22);
            this.txtShipFee.TabIndex = 23;
            // 
            // txtShipCountry
            // 
            this.txtShipCountry.Location = new System.Drawing.Point(438, 184);
            this.txtShipCountry.Name = "txtShipCountry";
            this.txtShipCountry.Size = new System.Drawing.Size(162, 22);
            this.txtShipCountry.TabIndex = 21;
            // 
            // txtPostal
            // 
            this.txtPostal.Location = new System.Drawing.Point(438, 145);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(162, 22);
            this.txtPostal.TabIndex = 19;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(438, 103);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(162, 22);
            this.txtState.TabIndex = 17;
            // 
            // txtShipCity
            // 
            this.txtShipCity.Location = new System.Drawing.Point(438, 66);
            this.txtShipCity.Name = "txtShipCity";
            this.txtShipCity.Size = new System.Drawing.Size(162, 22);
            this.txtShipCity.TabIndex = 15;
            // 
            // txtShipAddress2
            // 
            this.txtShipAddress2.Location = new System.Drawing.Point(438, 29);
            this.txtShipAddress2.Name = "txtShipAddress2";
            this.txtShipAddress2.Size = new System.Drawing.Size(162, 22);
            this.txtShipAddress2.TabIndex = 13;
            // 
            // txtShipAddress
            // 
            this.txtShipAddress.Location = new System.Drawing.Point(118, 218);
            this.txtShipAddress.Name = "txtShipAddress";
            this.txtShipAddress.Size = new System.Drawing.Size(200, 22);
            this.txtShipAddress.TabIndex = 11;
            // 
            // txtShipName
            // 
            this.txtShipName.Location = new System.Drawing.Point(118, 177);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(200, 22);
            this.txtShipName.TabIndex = 9;
            // 
            // shipperDate
            // 
            this.shipperDate.Location = new System.Drawing.Point(118, 138);
            this.shipperDate.Name = "shipperDate";
            this.shipperDate.Size = new System.Drawing.Size(200, 22);
            this.shipperDate.TabIndex = 7;
            // 
            // orderDate
            // 
            this.orderDate.Location = new System.Drawing.Point(118, 106);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(200, 22);
            this.orderDate.TabIndex = 5;
            // 
            // sell_ManagementDataSet
            // 
            this.sell_ManagementDataSet.DataSetName = "Sell_ManagementDataSet";
            this.sell_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numDiscount);
            this.groupBox2.Controls.Add(this.numQuantity);
            this.groupBox2.Controls.Add(this.numPrice);
            this.groupBox2.Controls.Add(this.cbbProduct);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(date_allocatedLabel);
            this.groupBox2.Controls.Add(this.dpkAllocated);
            this.groupBox2.Controls.Add(order_detail_statusLabel);
            this.groupBox2.Controls.Add(this.order_detail_statusTextBox);
            this.groupBox2.Controls.Add(discountLabel);
            this.groupBox2.Controls.Add(unit_priceLabel);
            this.groupBox2.Controls.Add(quantityLabel);
            this.groupBox2.Controls.Add(product_idLabel);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(303, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(864, 135);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Detail";
            // 
            // numDiscount
            // 
            this.numDiscount.Location = new System.Drawing.Point(342, 80);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(120, 22);
            this.numDiscount.TabIndex = 16;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(100, 80);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(151, 22);
            this.numQuantity.TabIndex = 15;
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(342, 39);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(120, 22);
            this.numPrice.TabIndex = 14;
            // 
            // cbbProduct
            // 
            this.cbbProduct.FormattingEnabled = true;
            this.cbbProduct.Location = new System.Drawing.Point(100, 39);
            this.cbbProduct.Name = "cbbProduct";
            this.cbbProduct.Size = new System.Drawing.Size(151, 23);
            this.cbbProduct.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(769, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 63);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dpkAllocated
            // 
            this.dpkAllocated.Location = new System.Drawing.Point(611, 83);
            this.dpkAllocated.Name = "dpkAllocated";
            this.dpkAllocated.Size = new System.Drawing.Size(102, 22);
            this.dpkAllocated.TabIndex = 11;
            // 
            // order_detail_statusTextBox
            // 
            this.order_detail_statusTextBox.Enabled = false;
            this.order_detail_statusTextBox.Location = new System.Drawing.Point(611, 39);
            this.order_detail_statusTextBox.Name = "order_detail_statusTextBox";
            this.order_detail_statusTextBox.Size = new System.Drawing.Size(102, 22);
            this.order_detail_statusTextBox.TabIndex = 9;
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.button1);
            this.grb1.Controls.Add(this.button5);
            this.grb1.Controls.Add(this.btnSave);
            this.grb1.Controls.Add(this.button3);
            this.grb1.Controls.Add(this.button2);
            this.grb1.Controls.Add(this.btnThem);
            this.grb1.Location = new System.Drawing.Point(272, 669);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(737, 74);
            this.grb1.TabIndex = 27;
            this.grb1.TabStop = false;
            this.grb1.Text = "Access";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(463, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 44);
            this.button5.TabIndex = 4;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(367, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 44);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(27, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Add";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // grboxOrder
            // 
            this.grboxOrder.Controls.Add(this.ordersDataGridView);
            this.grboxOrder.Controls.Add(this.button6);
            this.grboxOrder.Controls.Add(this.dtptoDate);
            this.grboxOrder.Controls.Add(this.dtpfromdate);
            this.grboxOrder.Controls.Add(this.label2);
            this.grboxOrder.Controls.Add(this.label1);
            this.grboxOrder.Location = new System.Drawing.Point(13, 33);
            this.grboxOrder.Name = "grboxOrder";
            this.grboxOrder.Size = new System.Drawing.Size(284, 624);
            this.grboxOrder.TabIndex = 28;
            this.grboxOrder.TabStop = false;
            this.grboxOrder.Text = "List Order";
            this.grboxOrder.Enter += new System.EventHandler(this.grboxOrder_Enter);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtId,
            this.dtEmployee,
            this.dtCustomer,
            this.dtOrder,
            this.dtShipDate,
            this.dtShipName,
            this.dtShipAddress,
            this.dtShipAddress2,
            this.dtShipCity,
            this.dtShipState,
            this.dtPostCode,
            this.dtCountry,
            this.dtShipFee,
            this.dtPayment,
            this.dtPaidDate,
            this.dtStatus});
            this.ordersDataGridView.DataSource = this.ordersBindingSource;
            this.ordersDataGridView.Location = new System.Drawing.Point(10, 198);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.Size = new System.Drawing.Size(260, 408);
            this.ordersDataGridView.TabIndex = 5;
            this.ordersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDataGridView_CellClick_1);
            this.ordersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDataGridView_CellContentClick);
            // 
            // dtId
            // 
            this.dtId.DataPropertyName = "id";
            this.dtId.HeaderText = "id";
            this.dtId.Name = "dtId";
            this.dtId.ReadOnly = true;
            this.dtId.Visible = false;
            // 
            // dtEmployee
            // 
            this.dtEmployee.DataPropertyName = "employee_id";
            this.dtEmployee.HeaderText = "employee_id";
            this.dtEmployee.Name = "dtEmployee";
            this.dtEmployee.Visible = false;
            // 
            // dtCustomer
            // 
            this.dtCustomer.DataPropertyName = "customer_id";
            this.dtCustomer.HeaderText = "customer_id";
            this.dtCustomer.Name = "dtCustomer";
            this.dtCustomer.Visible = false;
            // 
            // dtOrder
            // 
            this.dtOrder.DataPropertyName = "order_date";
            this.dtOrder.HeaderText = "order_date";
            this.dtOrder.Name = "dtOrder";
            // 
            // dtShipDate
            // 
            this.dtShipDate.DataPropertyName = "shipped_date";
            this.dtShipDate.HeaderText = "shipped_date";
            this.dtShipDate.Name = "dtShipDate";
            this.dtShipDate.Visible = false;
            // 
            // dtShipName
            // 
            this.dtShipName.DataPropertyName = "ship_name";
            this.dtShipName.HeaderText = "ship_name";
            this.dtShipName.Name = "dtShipName";
            this.dtShipName.Visible = false;
            // 
            // dtShipAddress
            // 
            this.dtShipAddress.DataPropertyName = "ship_address1";
            this.dtShipAddress.HeaderText = "ship_address1";
            this.dtShipAddress.Name = "dtShipAddress";
            this.dtShipAddress.Visible = false;
            // 
            // dtShipAddress2
            // 
            this.dtShipAddress2.DataPropertyName = "ship_address2";
            this.dtShipAddress2.HeaderText = "ship_address2";
            this.dtShipAddress2.Name = "dtShipAddress2";
            this.dtShipAddress2.Visible = false;
            // 
            // dtShipCity
            // 
            this.dtShipCity.DataPropertyName = "ship_city";
            this.dtShipCity.HeaderText = "ship_city";
            this.dtShipCity.Name = "dtShipCity";
            this.dtShipCity.Visible = false;
            // 
            // dtShipState
            // 
            this.dtShipState.DataPropertyName = "ship_state";
            this.dtShipState.HeaderText = "ship_state";
            this.dtShipState.Name = "dtShipState";
            this.dtShipState.Visible = false;
            // 
            // dtPostCode
            // 
            this.dtPostCode.DataPropertyName = "ship_postal_code";
            this.dtPostCode.HeaderText = "ship_postal_code";
            this.dtPostCode.Name = "dtPostCode";
            this.dtPostCode.Visible = false;
            // 
            // dtCountry
            // 
            this.dtCountry.DataPropertyName = "ship_country";
            this.dtCountry.HeaderText = "ship_country";
            this.dtCountry.Name = "dtCountry";
            this.dtCountry.Visible = false;
            // 
            // dtShipFee
            // 
            this.dtShipFee.DataPropertyName = "shipping_fee";
            this.dtShipFee.HeaderText = "shipping_fee";
            this.dtShipFee.Name = "dtShipFee";
            this.dtShipFee.Visible = false;
            // 
            // dtPayment
            // 
            this.dtPayment.DataPropertyName = "payment_type";
            this.dtPayment.HeaderText = "payment_type";
            this.dtPayment.Name = "dtPayment";
            this.dtPayment.Visible = false;
            // 
            // dtPaidDate
            // 
            this.dtPaidDate.DataPropertyName = "paid_date";
            this.dtPaidDate.HeaderText = "paid_date";
            this.dtPaidDate.Name = "dtPaidDate";
            this.dtPaidDate.Visible = false;
            // 
            // dtStatus
            // 
            this.dtStatus.DataPropertyName = "order_status";
            this.dtStatus.HeaderText = "order_status";
            this.dtStatus.Name = "dtStatus";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.sell_ManagementDataSet;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(10, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(260, 35);
            this.button6.TabIndex = 4;
            this.button6.Text = "Get List Order";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dtptoDate
            // 
            this.dtptoDate.Location = new System.Drawing.Point(91, 103);
            this.dtptoDate.Name = "dtptoDate";
            this.dtptoDate.Size = new System.Drawing.Size(187, 26);
            this.dtptoDate.TabIndex = 3;
            // 
            // dtpfromdate
            // 
            this.dtpfromdate.Location = new System.Drawing.Point(91, 39);
            this.dtpfromdate.Name = "dtpfromdate";
            this.dtpfromdate.Size = new System.Drawing.Size(187, 26);
            this.dtpfromdate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Date:";
            // 
            // idData
            // 
            this.idData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.idData.Location = new System.Drawing.Point(303, 502);
            this.idData.Name = "idData";
            this.idData.Size = new System.Drawing.Size(864, 137);
            this.idData.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1217, 749);
            this.Controls.Add(this.grboxOrder);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.idData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Order";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sell_ManagementDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.grb1.ResumeLayout(false);
            this.grboxOrder.ResumeLayout(false);
            this.grboxOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Sell_ManagementDataSet sell_ManagementDataSet;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.DateTimePicker dpkPaid;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.TextBox txtShipFee;
        private System.Windows.Forms.TextBox txtShipCountry;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtShipCity;
        private System.Windows.Forms.TextBox txtShipAddress2;
        private System.Windows.Forms.TextBox txtShipAddress;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.DateTimePicker shipperDate;
        private System.Windows.Forms.DateTimePicker orderDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dpkAllocated;
        private System.Windows.Forms.TextBox order_detail_statusTextBox;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grboxOrder;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DateTimePicker dtptoDate;
        private System.Windows.Forms.DateTimePicker dtpfromdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView idData;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtShipDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtShipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtShipAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtShipAddress2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtShipCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtShipState;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPostCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtShipFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPaidDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtStatus;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.ComboBox cbbProduct;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Button button1;
    }
}