using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_WF.Management
{
    public partial class frmCustmmer : Form
    {
        public frmCustmmer()
        {
            InitializeComponent();
        }
        string conn = @"Data Source=HUY\SQLEXPRESS;Initial Catalog=Sell_Management;User ID=sa;Password=tgbyhnujm";
        
        public void loadCustomer()
        {
            string query = "SELECT * FROM customers";
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
                        sell_ManagementDataSet.customers.Clear();
                        sell_ManagementDataSet.customers.AcceptChanges();
                        SqlDataAdapter adapter = new SqlDataAdapter();

                        adapter.SelectCommand = command;
                        //Đổ dữ liệu và dataset
                        adapter.Fill(sell_ManagementDataSet.customers);
                        //Hiển thị dữ liệu
                        //Hiển thị null Khi Delete
                        //customersBindingSource.DataMember = null;
                        //customersBindingSource.DataSource = null;
                        customersBindingSource.DataSource = sell_ManagementDataSet.customers;
                        customersDataGridView.Refresh();
                        // configDataGridView.DataSource = sell_ManagementDataSet1.config;

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
        private void frmCustmmer_Load(object sender, EventArgs e)
        {
            
            loadCustomer();
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtAddress1.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;

            }
            if (String.IsNullOrEmpty(txtCity.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtState.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtPostal.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtCountry.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtCompany.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            string insert =

            @"INSERT INTO customers(last_name,first_name,email,company,phone,address1,address2,city,state,postal_code,country) 
                VALUES (@last_name,@first_name,@email,@company,@phone,@address1,@address2,@city,@state,@postal_code,@country)";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(insert, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();
                        // Truyền dữ liệu vào đúng tham số
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@last_name", txtLastName.Text);
                        command.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                        command.Parameters.AddWithValue("@email", txtEmail.Text);
                        command.Parameters.AddWithValue("@company", txtCompany.Text);
                        command.Parameters.AddWithValue("@phone", txtPhone.Text);
                        command.Parameters.AddWithValue("@address1", txtAddress.Text);
                        command.Parameters.AddWithValue("@address2", txtAddress1.Text);
                        command.Parameters.AddWithValue("@city", txtCity.Text);
                        command.Parameters.AddWithValue("@state", txtState.Text);
                        command.Parameters.AddWithValue("@postal_code", txtPostal.Text);
                        command.Parameters.AddWithValue("@country", txtCountry.Text);
                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();
                        // Ngắt kết nối đến Database Server
                        connection.Close();
                        //Load lại Form sau khi insert
                        loadCustomer();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtAddress1.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;

            }
            if (String.IsNullOrEmpty(txtCity.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtState.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtPostal.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtCountry.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtCompany.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            // Tạo câu lệnh để thực thi đến database
            string queryString =
                @"UPDATE customers 
                SET last_name = @last_name, 
                first_name = @first_name,
                email = @email,
                company = @company,
                phone = @phone,
                address1 = @address1,
                address2 = @address2,
                city = @city,
                state = @state,
                postal_code = @postal_code,
                country = @country
                WHERE id = @id";
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
                        command.Parameters.AddWithValue("@id", txtId.Text);
                        command.Parameters.AddWithValue("@last_name", txtLastName.Text);
                        command.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                        command.Parameters.AddWithValue("@email", txtEmail.Text);
                        command.Parameters.AddWithValue("@company", txtCompany.Text);
                        command.Parameters.AddWithValue("@phone", txtPhone.Text);
                        command.Parameters.AddWithValue("@address1", txtAddress.Text);
                        command.Parameters.AddWithValue("@address2", txtAddress1.Text);
                        command.Parameters.AddWithValue("@city", txtCity.Text);
                        command.Parameters.AddWithValue("@state", txtState.Text);
                        command.Parameters.AddWithValue("@postal_code", txtPostal.Text);
                        command.Parameters.AddWithValue("@country", txtCountry.Text);

                        int effect = command.ExecuteNonQuery();
                        // Ngắt kết nối đến Database Server
                        connection.Close();
                        //Load lại dữ liệu
                        loadCustomer();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void customersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu của dòng dữ liệu đang chọn
                DataGridViewRow row = this.customersDataGridView.Rows[e.RowIndex];
                // Binding vào các textbox tương ứng
                txtId.Text = row.Cells["dtId"].Value.ToString();
                txtLastName.Text = row.Cells["dtLastName"].Value.ToString();
                txtFirstName.Text = row.Cells["dtFirstName"].Value.ToString();
                txtEmail.Text = row.Cells["dtEmail"].Value.ToString();
                txtCompany.Text = row.Cells["dtCompany"].Value.ToString();
                txtPhone.Text = row.Cells["dtPhone"].Value.ToString();
                txtAddress.Text = row.Cells["dtAddress"].Value.ToString();
                txtAddress1.Text = row.Cells["dtAddress1"].Value.ToString();
                txtCity.Text = row.Cells["dtCity"].Value.ToString();
                txtState.Text = row.Cells["dtState"].Value.ToString();
                txtPostal.Text = row.Cells["dtPostal"].Value.ToString();
                txtCountry.Text = row.Cells["dtCountry"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại để xác nhận có chắc chắn muốn xóa hay không?
            DialogResult confirmDelete = MessageBox.Show("Are you sure Delete?");
            if (confirmDelete != DialogResult.OK)
            {
                return;
            }
            // Tạo câu lệnh để thực thi đến database
            string queryString = @"DELETE FROM customers WHERE id = @id";
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
                        command.Parameters.AddWithValue("@id", txtId.Text);
                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();
                        // Ngắt kết nối đến Database Server
                        connection.Close();
                        //Load lại cấu hình
                        loadCustomer();

                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        public void ClearnCustomer()
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtEmail.Text = "";
            txtCompany.Text = "";
            txtCountry.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtAddress1.Text = "";
            txtState.Text = "";
            txtId.Text = "";
            txtPostal.Text = "";
            txtCity.Text = "";
            sell_ManagementDataSet.customers.Clear();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            ClearnCustomer();
        }
    }
}










