using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_WF.Management
{
    public partial class Producer : Form
    {
        string conn = @"Data Source=HUY\SQLEXPRESS;Initial Catalog=Sell_Management;User ID=sa;Password=tgbyhnujm";
        public Producer()
        {
            InitializeComponent();
        }

        private void Producer_Load(object sender, EventArgs e)
        {

            loadProducer();
        }
        public void loadProducer()
        {
            string query = "SELECT * FROM producer";

            using (SqlConnection connect = new SqlConnection(conn))
            {
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    try
                    {
                        connect.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter();

                        adapter.SelectCommand = command;
                        //Đổ dữ liệu và dataset
                        adapter.Fill(sell_ManagementDataSet.config);
                        //Hiển thị dữ liệu
                        producerBindingSource.DataSource = sell_ManagementDataSet.config;

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

        private void producerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.producerBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.sell_ManagementDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProducer.Text) || String.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            string insert = @"INSERT INTO producer(producer_name,producer_description) VALUES (@Producer,@Description)";
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
                        command.Parameters.AddWithValue("@Producer", txtProducer.Text);
                        command.Parameters.AddWithValue("@Description", txtDescription.Text);
                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();
                        // Ngắt kết nối đến Database Server
                        connection.Close();
                        //Load lại Form sau khi insert
                        loadProducer();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void producer_idLabel_Click(object sender, EventArgs e)
        {

        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu của dòng dữ liệu đang chọn
                DataGridViewRow row = this.procederDataGridView.Rows[e.RowIndex];
                // Binding vào các textbox tương ứng
                txtIdProceder.Text = row.Cells["produceridDataGridViewTextBoxColumn"].Value.ToString();
                txtProducer.Text = row.Cells["producernameDataGridViewTextBoxColumn"].Value.ToString();
                txtDescription.Text = row.Cells["producerdescriptionDataGridViewTextBoxColumn"].Value.ToString();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
        private void procederDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (String.IsNullOrEmpty(txtIdProceder.Text) || String.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            // Tạo câu lệnh để thực thi đến database
            string queryString = @"UPDATE producer SET producer_name = @Producer, producer_description = @Description WHERE producer_id = @id";
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
                        command.Parameters.AddWithValue("@id", txtIdProceder.Text);
                        command.Parameters.AddWithValue("@Producer", txtProducer.Text);
                        command.Parameters.AddWithValue("@Description", txtDescription.Text);

                        int effect = command.ExecuteNonQuery();
                        // Ngắt kết nối đến Database Server
                        connection.Close();
                        //Load lại dữ liệu
                        loadProducer();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
