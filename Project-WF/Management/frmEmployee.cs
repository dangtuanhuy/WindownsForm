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
    public partial class frmEmployee : Form
    {
        private int gender;
        public frmEmployee()
        {
            InitializeComponent();
        }
        string conn = @"Data Source=HUY\SQLEXPRESS;Initial Catalog=Sell_Management;User ID=sa;Password=tgbyhnujm";
        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            // this.employeesBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.sell_ManagementDataSet);

        }

        private void employeesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            // this.Validate();
            // this.employeesBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.sell_ManagementDataSet);

        }
        public void loadEmployee()
        {
            string query = "SELECT * FROM employees";
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
                        sell_ManagementDataSet.employees.Clear();
                        sell_ManagementDataSet.employees.AcceptChanges();
                        SqlDataAdapter adapter = new SqlDataAdapter();

                        adapter.SelectCommand = command;
                        //Đổ dữ liệu và dataset
                        adapter.Fill(sell_ManagementDataSet.employees);
                        //Hiển thị dữ liệu
                        //Hiển thị null Khi Delete
                        //customersBindingSource.DataMember = null;
                        //customersBindingSource.DataSource = null;
                        employeesBindingSource.DataSource = sell_ManagementDataSet.employees;
                        employeesDataGridView.Refresh();
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
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sell_ManagementDataSet.employees' table. You can move, or remove it, as needed.
            //this.employeesTableAdapter.Fill(this.sell_ManagementDataSet.employees);
            loadEmployee();
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmMain().Show();
        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = 1;
        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFirstNameEmp.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtLastNamesEmp.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtEmailEmp.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;

            }
            if (String.IsNullOrEmpty(birthdayEmp.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtJob.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtDepartment.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtCountry.Text))
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
            if (String.IsNullOrEmpty(txtPostCode.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            string sqlinsert =
                @"INSERT INTO 
                employees(
               last_name
              ,first_name
              ,email
              ,password
              ,birthday
              ,gender
              ,job_title
              ,department
              ,phone
              ,address1
              ,city
              ,state
              ,postal_code
              ,country) 
                VALUES
               (
                @last_name
              ,@first_name
              ,@email
              ,@password
              ,@birthday
              ,@gender
              ,@job_title
              ,@department
              ,@phone
              ,@address1
              ,@city
              ,@state
              ,@postal_code
              ,@country
                )";
            using (SqlConnection connect = new SqlConnection(conn))
            {
                using (SqlCommand command = new SqlCommand(sqlinsert, connect))

                {
                    try
                    {
                        //Mở CSDL
                        connect.Open();
                        // Truyền dữ liệu vào đúng tham số

                        command.Parameters.AddWithValue("@last_name", txtLastNamesEmp.Text);
                        command.Parameters.AddWithValue("@first_name", txtFirstNameEmp.Text);
                        command.Parameters.AddWithValue("@email", txtEmailEmp.Text);
                        command.Parameters.AddWithValue("@password", txtPassword.Text);
                        command.Parameters.AddWithValue("@birthday", birthdayEmp.Value.ToString("yyyy-mm-dd hh:MM:ss"));
                        command.Parameters.AddWithValue("@gender", grbox.Text);
                        command.Parameters.AddWithValue("@job_title", txtJob.Text);
                        command.Parameters.AddWithValue("@department", txtDepartment.Text);
                        command.Parameters.AddWithValue("@phone", txtPhone.Text);
                        command.Parameters.AddWithValue("@address1", txtAddress.Text);
                        command.Parameters.AddWithValue("@city", txtCity.Text);
                        command.Parameters.AddWithValue("@state", txtState.Text);
                        command.Parameters.AddWithValue("@postal_code", txtPostCode.Text);
                        command.Parameters.AddWithValue("@country", txtCountry.Text);
                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();
                        // Ngắt kết nối đến Database Server
                        connect.Close();
                        //Load lại Form sau khi insert
                        loadEmployee();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Kiểm tra rỗng
            if (String.IsNullOrEmpty(txtFirstNameEmp.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtLastNamesEmp.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtEmailEmp.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;

            }
            if (String.IsNullOrEmpty(birthdayEmp.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtJob.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtDepartment.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtCountry.Text))
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
            if (String.IsNullOrEmpty(txtPostCode.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please! Check Data");
                return;
            }
            //Câu lệnh update SQL
            string sqlUpdate =
                @"UPDATE employees SET
               last_name = @last_name
              ,first_name = @first_name
              ,email = @email
              ,password = @password
              ,birthday = @birthday
              ,gender = @gender
              ,job_title = @job_title
              ,department = @department
              ,phone = @phone
              ,address1 = @address1
              ,city = @city 
              ,state = @state
              ,postal_code = @postal_code
              ,country = @country
                WHERE id = @id";
            using (SqlConnection connect = new SqlConnection(conn))
            {
                using (SqlCommand command = new SqlCommand(sqlUpdate, connect))

                {
                    try
                    {
                        //Mở CSDL
                        connect.Open();
                        // Truyền dữ liệu vào đúng tham số
                        command.Parameters.AddWithValue("@id", txtIdEmp.Text);
                        command.Parameters.AddWithValue("@last_name", txtLastNamesEmp.Text);
                        command.Parameters.AddWithValue("@first_name", txtFirstNameEmp.Text);
                        command.Parameters.AddWithValue("@email", txtEmailEmp.Text);
                        command.Parameters.AddWithValue("@password", txtPassword.Text);
                        command.Parameters.AddWithValue("@birthday", birthdayEmp.Text);
                        command.Parameters.AddWithValue("@gender", grbox.Text);
                        command.Parameters.AddWithValue("@job_title", txtJob.Text);
                        command.Parameters.AddWithValue("@department", txtDepartment.Text);
                        command.Parameters.AddWithValue("@phone", txtPhone.Text);
                        command.Parameters.AddWithValue("@address1", txtAddress.Text);
                        command.Parameters.AddWithValue("@city", txtCity.Text);
                        command.Parameters.AddWithValue("@state", txtState.Text);
                        command.Parameters.AddWithValue("@postal_code", txtPostCode.Text);
                        command.Parameters.AddWithValue("@country", txtCountry.Text);
                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();
                        // Ngắt kết nối đến Database Server
                        connect.Close();
                        //Load lại Form sau khi insert
                        loadEmployee();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void employeesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu của dòng dữ liệu đang chọn
                DataGridViewRow row = this.employeesDataGridView.Rows[e.RowIndex];
                // Binding vào các textbox tương ứng
                txtIdEmp.Text = row.Cells["dtId"].Value.ToString();
                txtLastNamesEmp.Text = row.Cells["dtLastName"].Value.ToString();
                txtFirstNameEmp.Text = row.Cells["dtFirstName"].Value.ToString();
                txtEmailEmp.Text = row.Cells["dtEmail"].Value.ToString();
                txtPassword.Text = row.Cells["dtPass"].Value.ToString();
                birthdayEmp.Text = row.Cells["dtBirthday"].Value.ToString();


                
                if(Convert.ToInt32(row.Cells["dtGender"].Value) == 1)
                {
                    rdMale.Checked = true;
                }
                else
                {
                    rdFemale.Checked = true;
                }

                txtJob.Text = row.Cells["dtJob"].Value.ToString();
                txtDepartment.Text = row.Cells["dtDepartment"].Value.ToString();
                txtPhone.Text = row.Cells["dtPhone"].Value.ToString();
                txtAddress.Text = row.Cells["dtAddress"].Value.ToString();
                txtCity.Text = row.Cells["dtCity"].Value.ToString();
                txtState.Text = row.Cells["dtState"].Value.ToString();
                txtPostCode.Text = row.Cells["dtPostal"].Value.ToString();
                txtCountry.Text = row.Cells["dtCountry"].Value.ToString();
            }
            //dtId
            //dtLastName
            //dtFirstName
            //dtEmail
            //dtGender
            //dtBirthday
            //dtJob
            //dtDepartment
            //dtPhone
            //dtCountry
            //dtCity
            //dtSate
            //dtPostal
            //dtAddress
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
            string queryString = @"DELETE FROM employees WHERE id = @id";
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
                        command.Parameters.AddWithValue("@id", txtIdEmp.Text);
                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();
                        // Ngắt kết nối đến Database Server
                        connection.Close();
                        //Load lại cấu hình
                        loadEmployee();

                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void employeesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
