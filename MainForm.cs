using QuanLyVLXD.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVLXD
{
    public partial class MainForm : Form {
        public MainForm(string? username) {
            InitializeComponent();
            UC_Materials uC_Materials = new UC_Materials();
            addUserControl(uC_Materials);

            lbUserName.Text = $"Xin chào {username}";
        }

        private void addUserControl(UserControl userControl) {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void guna2Button6_Click(object sender, EventArgs e) {
            UC_Order uC_Order = new UC_Order();
            addUserControl(uC_Order);
        }

        private void guna2Button1_Click(object sender, EventArgs e) {
            UC_Materials uC = new UC_Materials();
            addUserControl(uC);
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void guna2Button8_Click(object sender, EventArgs e) {
        }

        private void guna2Button7_Click(object sender, EventArgs e) {
            UC_Purchase uC = new UC_Purchase();
            addUserControl(uC);
        }

        private void guna2Button9_Click(object sender, EventArgs e) {
        }

        private void guna2Button5_Click(object sender, EventArgs e) {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e) {
        }

        private void guna2Button2_Click(object sender, EventArgs e) {
        }

        private void guna2Button4_Click(object sender, EventArgs e) {
        }

        private void btnCustomer_Click(object sender, EventArgs e) {
            UC_Customer uC = new UC_Customer();
            addUserControl(uC);
        }

        private void guna2Button1_Click_1(object sender, EventArgs e) {
            UC_Supplier uC = new UC_Supplier();
            addUserControl(uC);
        }
    }
}
