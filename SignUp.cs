using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVLXD
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void LoadRoles()
        {
        }
        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 signIn = new Form1();
            signIn.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (var db = new QuanLyDBVLXDDataContext())
            {
                if (db.Users.Any(u => u.UserName == username))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng nhập lại", "Tên đăng nhập đã tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Focus();
                } else if (tbRePassword.Text != txtPassword.Text){
                    MessageBox.Show("Mật khẩu không khớp, xin vui lòng nhập lại", "Nhập lại mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var user = new User();
                    user.FullName = name;
                    user.UserName = username;
                    user.Email = email;
                    user.PasswordHash = password;
                    user.CreatedAt = DateTime.Now;
    
                    db.Users.InsertOnSubmit(user);
                    db.SubmitChanges();
                    MessageBox.Show("Đăng ký thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    Form1 signIn = new Form1();
                    signIn.Show();
                    this.Close();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
