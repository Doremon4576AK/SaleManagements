using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SaleManagements
{
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
            lvViewBill.Columns.Add("ID Bill", 100);
            lvViewBill.Columns.Add("Name Bill", 150);
            lvViewBill.Columns.Add("ID User", 100);
            lvViewBill.View = View.Details;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAK\\LAK;Initial Catalog=SaleManagement;Integrated Security=True";
            // Câu lệnh SQL để lấy dữ liệu
            string query = "SELECT IDBill, NameBill, IDUser FROM Bill";

            // Xóa các mục cũ trong ListView
            lvViewBill.Items.Clear();

            // Chuỗi kết nối tới cơ sở dữ liệu

            SqlConnection con = new SqlConnection(connectionString);
            {
                SqlCommand command = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Tạo một ListViewItem mới
                        ListViewItem item = new ListViewItem(reader["IDBill"].ToString());
                        item.SubItems.Add(reader["NameBill"].ToString());
                        item.SubItems.Add(reader["IDUser"].ToString());

                        // Thêm item vào ListView
                        lvViewBill.Items.Add(item);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            if (lvViewBill.SelectedItems.Count > 0)
            {
                // Lấy mục được chọn
                var selectedItem = lvViewBill.SelectedItems[0];

                // Hiển thị dữ liệu lên các TextBox
                txtIDBill.Text = selectedItem.SubItems[0].Text;
                txtNameBill.Text = selectedItem.SubItems[1].Text;
                txtIDUser.Text = selectedItem.SubItems[2].Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAK\\LAK;Initial Catalog=SaleManagement;Integrated Security=True";

            string query = "INSERT INTO Bill (IDBill, NameBill, IDUser) VALUES (@IDBill, @NameBill, @IDUser)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, con);

                // Thêm tham số
                command.Parameters.AddWithValue("@IDBill", txtIDBill.Text);
                command.Parameters.AddWithValue("@NameBill", txtNameBill.Text);
                command.Parameters.AddWithValue("@IDUser", txtIDUser.Text);

                try
                {
                    con.Open();
                    command.ExecuteNonQuery();

                    // Thêm vào ListView
                    ListViewItem newItem = new ListViewItem(txtIDBill.Text);
                    newItem.SubItems.Add(txtNameBill.Text);
                    newItem.SubItems.Add(txtIDUser.Text);
                    lvViewBill.Items.Add(newItem);

                    MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa các TextBox sau khi thêm
                    txtIDBill.Clear();
                    txtNameBill.Clear();
                    txtIDUser.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Lấy từ khóa tìm kiếm
            string searchKeyword = txtSearch.Text.Trim();

            // Chuỗi kết nối
            string connectionString = "Data Source=LAK\\LAK;Initial Catalog=SaleManagement;Integrated Security=True";

            // Câu lệnh SQL để tìm kiếm theo tên Bill
            string query = "SELECT IDBill, NameBill, IDUser FROM Bill WHERE NameBill LIKE @SearchKeyword";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, con);

                // Thêm tham số với ký tự đại diện %
                command.Parameters.AddWithValue("@SearchKeyword", "%" + searchKeyword + "%");

                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Xóa các mục cũ trong ListView
                    lvViewBill.Items.Clear();

                    while (reader.Read())
                    {
                        // Tạo một ListViewItem mới
                        ListViewItem item = new ListViewItem(reader["IDBill"].ToString());
                        item.SubItems.Add(reader["NameBill"].ToString());
                        item.SubItems.Add(reader["IDUser"].ToString());

                        // Thêm item vào ListView
                        lvViewBill.Items.Add(item);
                    }

                    reader.Close();

                    // Hiển thị thông báo nếu không tìm thấy kết quả
                    if (lvViewBill.Items.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvViewBill.SelectedItems.Count > 0)
            {
                // Lấy mục được chọn
                var selectedItem = lvViewBill.SelectedItems[0];
                string selectedIDBill = selectedItem.SubItems[0].Text;

                // Chuỗi kết nối
                string connectionString = @"Data Source=LAK\LAK;Initial Catalog=ManageProduct;User ID=sa;Password=123456";

                // Câu lệnh SQL để xóa
                string query = "DELETE FROM Bill WHERE IDBill = @IDBill";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, con);

                    // Thêm tham số
                    command.Parameters.AddWithValue("@IDBill", selectedIDBill);

                    try
                    {
                        con.Open();
                        command.ExecuteNonQuery();

                        // Xóa khỏi ListView
                        lvViewBill.Items.Remove(selectedItem);

                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
