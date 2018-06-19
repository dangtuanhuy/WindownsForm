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

namespace Project_WF
{
    public partial class FormConfig : Form
    {
        string conn = @"Data Source=HUY\SQLEXPRESS;Initial Catalog=Sell_Management;User ID=sa;Password=tgbyhnujm";
        public FormConfig()
        {
            InitializeComponent();
        }

        private void configBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();


        }
        public void loadConfig()
        {
            string query = "SELECT * FROM config";

            using (SqlConnection connect = new SqlConnection(conn))
            {
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    try
                    {
                        connect.Open();
                        //Hiểu chỉnh cho delete
                        sell_ManagementDataSet1.Clear();
                        sell_ManagementDataSet1.Reset();
                        sell_ManagementDataSet1.config.Clear();
                        sell_ManagementDataSet1.config.AcceptChanges();
                        SqlDataAdapter adapter = new SqlDataAdapter();

                        adapter.SelectCommand = command;
                        //Đổ dữ liệu và dataset
                        adapter.Fill(sell_ManagementDataSet1.config);
                        //Hiển thị dữ liệu
                        //Hiển thị null Khi Delete
                        configBindingSource.DataMember = null;
                        configBindingSource.DataSource = null;
                        configBindingSource.DataSource = sell_ManagementDataSet1.config;
                        configDataGridView.Refresh();
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
        private void FormConfig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sell_ManagementDataSet.config' table. You can move, or remove it, as needed.
            loadConfig();



        }

        private void configDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtKey.Text) || String.IsNullOrEmpty(txtValues.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            string insert = @"INSERT INTO config([Key],[Values]) VALUES (@key,@values)";
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
                        command.Parameters.AddWithValue("@key", txtKey.Text);
                        command.Parameters.AddWithValue("@values", txtValues.Text);
                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();
                        // Ngắt kết nối đến Database Server
                        connection.Close();
                        //Load lại Form sau khi insert
                        loadConfig();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void configDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu của dòng dữ liệu đang chọn
                DataGridViewRow row = this.configDataGridView.Rows[e.RowIndex];
                // Binding vào các textbox tương ứng
               txtId.Text = row.Cells["idDataGridViewTextBoxColumn"].Value.ToString();
               txtKey.Text = row.Cells["keyDataGridViewTextBoxColumn"].Value.ToString();
               txtValues.Text = row.Cells["valuesDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void btnEditConfig_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtKey.Text) || String.IsNullOrEmpty(txtValues.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            // Tạo câu lệnh để thực thi đến database
            string queryString = @"UPDATE config SET [key] = @key, [Values] = @value WHERE id = @id";
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
                        command.Parameters.AddWithValue("@key", txtKey.Text);
                        command.Parameters.AddWithValue("@value",txtValues.Text);

                        int effect = command.ExecuteNonQuery();
                        // Ngắt kết nối đến Database Server
                        connection.Close();
                        //Load lại dữ liệu
                        loadConfig();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnDeleteConfig_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại để xác nhận có chắc chắn muốn xóa hay không?
            DialogResult confirmDelete = MessageBox.Show("Are you sure Delete?");
            if (confirmDelete != DialogResult.OK)
            {
                return;
            }
            // Tạo câu lệnh để thực thi đến database
            string queryString = @"DELETE FROM config WHERE id = @id";
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
                        loadConfig();

                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
    }

