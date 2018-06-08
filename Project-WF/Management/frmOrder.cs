using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_WF.Management
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }
        string conn = @"Data Source=HUY\SQLEXPRESS;Initial Catalog=Sell_Management;User ID=sa;Password=tgbyhnujm";
        SortedDictionary<int, string> listEmployee = new SortedDictionary<int, string>();
        SortedDictionary<int, string> listCustomer = new SortedDictionary<int, string>();
        SortedDictionary<int, string> listProduct = new SortedDictionary<int, string>();
        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }
        //Load dữ liệu từ bảng có khóa ngoại
        public void loadEmployee()
        {
            string sqlselect = String.Format("SELECT * FROM employees");
            using (SqlConnection connect = new SqlConnection(conn))

            {
                using (SqlCommand command = new SqlCommand(sqlselect, connect))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connect.Open();
                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;
                        // Đổ dữ liệu vào dataset
                        adapter.Fill(sell_ManagementDataSet.employees);
                        // Hiển thị dữ liệu
                        foreach (DataRow row in sell_ManagementDataSet.employees.Rows)
                        {
                            int key = Convert.ToInt32(row["id"]);
                            string value = row["first_name"].ToString();
                            listEmployee.Add(key, value);
                        }
                        cboEmployee.DataSource = new BindingSource(listEmployee, null);
                        cboEmployee.DisplayMember = "Value";
                        cboEmployee.ValueMember = "Key";
                        // Ngắt kết nối đến Database Server
                        connect.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        public void loadCustomer()
        {
            string sqlselect = String.Format("SELECT * FROM customers");
            using (SqlConnection connect = new SqlConnection(conn))

            {
                using (SqlCommand command = new SqlCommand(sqlselect, connect))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connect.Open();
                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;
                        // Đổ dữ liệu vào dataset
                        adapter.Fill(sell_ManagementDataSet.customers);
                        // Hiển thị dữ liệu
                        foreach (DataRow row in sell_ManagementDataSet.customers.Rows)
                        {
                            int key =  Convert.ToInt32(row["id"]);
                            string value = row["first_name"].ToString();
                            listCustomer.Add(key, value);
                        }
                        cboCustomer.DataSource = new BindingSource(listCustomer, null);
                        cboCustomer.DisplayMember = "Value";
                        cboCustomer.ValueMember = "Key";
                        // Ngắt kết nối đến Database Server
                        connect.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        public void loadOrder()
        {
            string tungay = dtpfromdate.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string denngay = dtptoDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string query = String.Format("SELECT * FROM orders WHERE order_date BETWEEN '{0}' AND '{1}'", tungay, denngay);
            //string query = String.Format("SELECT * FROM orders");
            using (SqlConnection connect = new SqlConnection(conn))
            {
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    try
                    {
                        connect.Open();
                        //Hiểu chỉnh cho delete
                        sell_ManagementDataSet.Clear();
                        sell_ManagementDataSet.Reset();
                        sell_ManagementDataSet.orders.Clear();
                        sell_ManagementDataSet.orders.AcceptChanges();
                        SqlDataAdapter adapter = new SqlDataAdapter();

                        adapter.SelectCommand = command;
                        //Đổ dữ liệu và dataset
                        adapter.Fill(sell_ManagementDataSet.orders);
                        //Hiển thị dữ liệu
                        //Hiển thị null Khi Delete
                        ordersBindingSource.DataSource = null;
                        ordersBindingSource.DataSource = sell_ManagementDataSet.orders;
                        ordersDataGridView.Refresh();
                       

                        //Đóng kết nối 
                        connect.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
        public void LoadChiTietDonHang(int idDonHang)
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM order_details WHERE order_id = {0}", idDonHang);
            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(conn))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();
                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;
                        // Đổ dữ liệu vào dataset
                        sell_ManagementDataSet.order_details.Clear();
                        adapter.Fill(sell_ManagementDataSet.order_details);
                        // Hiển thị dữ liệu

                        //orderdetailsBindingSource.DataSource = sell_ManagementDataSet.order_details;
                        idData.DataSource = sell_ManagementDataSet.order_details;
                        idData.Refresh();
                        // Ngắt kết nối đến Database Server
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void frmOrder_Load(object sender, EventArgs e)
        {

            //Lấy danh sách khách hàng và nhân viên
            loadCustomer();
            //Lấy danh sách nhân viên
            loadEmployee();
            //Lấy danh sách đơn hàng
            loadOrder();
            //Lấy danh sách sản phẩm
            loadListProduct();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            loadOrder();
        }
        private void ordersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void ordersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            

        }
        private void ordersDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu của dòng dữ liệu đang chọn
                DataGridViewRow row = this.ordersDataGridView.Rows[e.RowIndex];
                // Binding vào các textbox tương ứng
                //cboEmployee.Text = row.Cells["dtEmployee"].Value.ToString();
                var idEmployee = Convert.ToInt32(row.Cells["dtEmployee"].Value);

                cboEmployee.SelectedItem = cboEmployee.Items.Cast<KeyValuePair<int,string>>().First(item=>item.Key == idEmployee);

                var idCustommer = Convert.ToInt32(row.Cells["dtCustomer"].Value);

                cboCustomer.SelectedItem = cboCustomer.Items.Cast<KeyValuePair<int,string>>().First(item => item.Key == idCustommer);
                
                orderDate.Text = row.Cells["dtOrder"].Value.ToString();
                shipperDate.Text = row.Cells["dtShipDate"].Value.ToString();
                txtShipName.Text = row.Cells["dtShipName"].Value.ToString();
                txtShipAddress.Text = row.Cells["dtShipAddress"].Value.ToString();
                txtShipAddress2.Text = row.Cells["dtShipAddress2"].Value.ToString();
                txtShipCity.Text = row.Cells["dtShipCity"].Value.ToString();
                txtState.Text = row.Cells["dtShipState"].Value.ToString();
                txtPostal.Text = row.Cells["dtPostCode"].Value.ToString();
                txtShipCountry.Text = row.Cells["dtCountry"].Value.ToString();
                txtShipFee.Text = row.Cells["dtShipFee"].Value.ToString();
                txtPayment.Text = row.Cells["dtPayment"].Value.ToString();
                dpkPaid.Text = row.Cells["dtPaidDate"].Value.ToString();
                txtStatus.Text = row.Cells["dtStatus"].Value.ToString();
                var idDonHang = Convert.ToInt32(row.Cells["dtId"].Value);
                LoadChiTietDonHang(idDonHang);
            }
        }
        
        private void grboxOrder_Enter(object sender, EventArgs e)
        {

        }
        public void loadListProduct()
        {
            string sqlSelect = String.Format("SELECT * FROM products");
            using (SqlConnection connect = new SqlConnection(conn))

            {
                using (SqlCommand command = new SqlCommand(sqlSelect, connect))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connect.Open();
                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;
                        // Đổ dữ liệu vào dataset
                        adapter.Fill(sell_ManagementDataSet.products);
                        // Hiển thị dữ liệu
                        foreach (DataRow row in sell_ManagementDataSet.products.Rows)
                        {
                            int key = Convert.ToInt32(row["id"]);
                            string value = row["product_name"].ToString();
                            listProduct.Add(key, value);
                        }
                        cbbProduct.DataSource = new BindingSource(listProduct, null);
                        cbbProduct.DisplayMember = "Value";
                        cbbProduct .ValueMember = "Key";
                        // Ngắt kết nối đến Database Server
                        connect.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void ordersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void clearData()
        {
            cboCustomer.Text = "";
            cboEmployee.Text = "";
            orderDate.Value = DateTime.Now;
            shipperDate.Value = DateTime.Now;
            txtShipName.Text = "";
            txtShipAddress.Text = "";
            txtShipAddress2.Text = "";
            txtShipCity.Text = "";
            txtState.Text = "";
            txtPostal.Text = "";
            txtShipCountry.Text = "";
            txtShipFee.Text = "";
            txtPayment.Text = "";
            dpkPaid.Value = DateTime.Now;
            txtStatus.Text = "";
            //Product
            cbbProduct.Text = "";
            sell_ManagementDataSet.order_details.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Lam sach du lieu
            clearData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int OrderId = 0;
            int ProductId = ((KeyValuePair<int, string>)cbbProduct.SelectedItem).Key;
            decimal Quantity = numQuantity.Value;
            decimal UnitPrice = numPrice.Value;
            decimal Discount = numDiscount.Value;
            string Status = "On Order";
            string dataAllocatecd = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            sell_ManagementDataSet.order_details.Rows.Add(OrderId, ProductId, Quantity, UnitPrice, Discount, Status, dataAllocatecd);

            //Clearn
            cbbProduct.Text = "";
            numDiscount.Value = 0;
            numPrice.Value = 0;
            numQuantity.Value = 0;
            dpkAllocated.Value = DateTime.Now;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            //this.Close();
            //new frmMain().Show();
            // Tạo câu lệnh để thực thi đến database
            string queryString = @"INSERT INTO orders(employee_id, customer_id, order_date, shipped_date, ship_name, ship_address1, ship_address2, ship_city, ship_state, ship_postal_code, ship_country, shipping_fee, payment_type, paid_date, order_status)"
                               + " VALUES(@employee_id, @customer_id, @order_date, @shipped_date, @ship_name, @ship_address1, @ship_address2, @ship_city, @ship_state, @ship_postal_code, @ship_country, @shipping_fee, @payment_type, @paid_date, @order_status);"
                               + " SELECT CAST(scope_identity() AS int)";
            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(conn))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();
                        // Truyền dữ liệu vào đúng tham số
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@employee_id", ((KeyValuePair<int, string>)cboEmployee.SelectedItem).Key);
                        command.Parameters.AddWithValue("@customer_id", ((KeyValuePair<int, string>)cboCustomer.SelectedItem).Key);
                        command.Parameters.AddWithValue("@order_date", orderDate.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.Parameters.AddWithValue("@shipped_date", shipperDate.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.Parameters.AddWithValue("@ship_name", txtShipName.Text);
                        command.Parameters.AddWithValue("@ship_address1", txtShipAddress.Text);
                        command.Parameters.AddWithValue("@ship_address2", txtShipAddress2.Text);
                        command.Parameters.AddWithValue("@ship_city", txtShipCity.Text);
                        command.Parameters.AddWithValue("@ship_state", txtState.Text);
                        command.Parameters.AddWithValue("@ship_postal_code", txtPostal.Text);
                        command.Parameters.AddWithValue("@ship_country", txtShipCountry.Text);
                        command.Parameters.AddWithValue("@shipping_fee", txtShipFee.Text);
                        command.Parameters.AddWithValue("@payment_type", txtPayment.Text);
                        command.Parameters.AddWithValue("@paid_date", dpkPaid.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.Parameters.AddWithValue("@order_status", txtStatus.Text);
                        // Thực thi câu lệnh INSERT order và lấy ORDER_ID
                        int orderIdInserted = (int)command.ExecuteScalar();
                        // Insert table Order_details
                        foreach (DataRow row in sell_ManagementDataSet.order_details.Rows)
                        {
                            int orderId = orderIdInserted;
                            int productId = Convert.ToInt32(row["product_id"]);
                            decimal soLuong = Convert.ToInt32(row["quantity"]);
                            decimal donGia = Convert.ToInt32(row["unit_price"]);
                            decimal giamGia = Convert.ToInt32(row["discount"]);
                            string status = row["order_detail_status"].ToString();
                            string dateAllocated = row["date_allocated"].ToString();
                            string subQueryString = @"INSERT INTO order_details(order_id, product_id, quantity, unit_price, discount, order_detail_status, date_allocated)"
                               + " VALUES(@order_id, @product_id, @quantity, @unit_price, @discount, @order_detail_status, @date_allocated)";
                            // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                            using (SqlCommand subCommand = new SqlCommand(subQueryString, connection))
                            {
                                // Truyền dữ liệu vào đúng tham số
                                subCommand.CommandType = CommandType.Text;
                                subCommand.Parameters.AddWithValue("@order_id", orderId);
                                subCommand.Parameters.AddWithValue("@product_id", productId);
                                subCommand.Parameters.AddWithValue("@quantity", soLuong);
                                subCommand.Parameters.AddWithValue("@unit_price", donGia);
                                subCommand.Parameters.AddWithValue("@discount", giamGia);
                                subCommand.Parameters.AddWithValue("@order_detail_status", status);
                                subCommand.Parameters.AddWithValue("@date_allocated", dateAllocated);
                                subCommand.ExecuteNonQuery();
                            }
                        }
                        // Ngắt kết nối đến Database Server
                        connection.Close();
                        // Load lại danh sách cấu hình
                        //LoadDanhMucCauHinh();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmReports frm = new frmReports();
            frm.DataOrder = sell_ManagementDataSet.order_details;
            frm.ShowDialog();
        }
    }

}
    

