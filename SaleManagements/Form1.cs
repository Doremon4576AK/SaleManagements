using Microsoft.Data.SqlClient;



namespace SaleManagements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection ConnectToDatabase()
        {
            string connectionString = "Data Source=LAK\\LAK;Initial Catalog=SaleManagement;Integrated Security=True";
            return new SqlConnection(connectionString);
        }
        private bool CheckLogin(string username, string password)
        {
            using (SqlConnection conn = ConnectToDatabase())
            {
                conn.Open();
                string query = "SELECT * FROM USERNAME WHERE name = @Name AND pass = @Pass";
                using ( SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", username);
                    cmd.Parameters.AddWithValue("@Pass", password);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPass.Text.Trim();

            if (CheckLogin(username, password))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Mở form frmMain khi đăng nhập thành công
                frmMain mainForm = new frmMain(); 
                mainForm.Show();

                // Ẩn form đăng nhập (LoginForm)
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
