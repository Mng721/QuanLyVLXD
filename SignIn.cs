namespace QuanLyVLXD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            using (var db = new QuanLyDBVLXDDataContext())
            {
                var user = db.Users.SingleOrDefault(u => u.UserName == username && u.PasswordHash == password);
                if (user != null)
                {
                    MainForm main = new MainForm(user.UserName);
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản mật khẩu không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
