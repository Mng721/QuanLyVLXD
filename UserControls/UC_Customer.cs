using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVLXD.UserControls {
    public partial class UC_Customer : UserControl {
        public UC_Customer() {
            InitializeComponent();
            getCustomersData();
            DeselectDataGridViewRows();
            dataGVCustomers.SelectionChanged += dataGVCustomers_SelectionChanged;
        }

        public void getCustomersData() {
            using (QuanLyDBVLXDDataContext db = new QuanLyDBVLXDDataContext()) {
                var customerList = (from customer in db.Customers
                                    select new {
                                        CustomerName = customer.CustomerName,
                                        CustomerID = customer.CustomerID,
                                        Phone = customer.Phone,
                                        Email = customer.Email,
                                        Address = customer.Address
                                    }).ToList();
                dataGVCustomers.DataSource = customerList;
            }
            DeselectDataGridViewRows();
        }


        private void lb_Click(object sender, EventArgs e) {

        }

        private void guna2Button3_Click(object sender, EventArgs e) {
            if (dataGVCustomers.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVCustomers.SelectedRows[0];
                int customerID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var customer = db.Customers.FirstOrDefault(m => m.CustomerID == customerID);
                    if (customer != null) {
                        customer.CustomerName = tbCustomerName.Text;
                        customer.Phone = tbPhoneNumber.Text;
                        customer.Email = tbEmail.Text;
                        customer.Address = tbAddress.Text;

                        db.SubmitChanges();
                    }
                }
                getCustomersData();
            }
        }

        private void dataGVCustomers_SelectionChanged(object sender, EventArgs e) {
            if (dataGVCustomers.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVCustomers.SelectedRows[0];
                int customerID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var customer = db.Customers.FirstOrDefault(m => m.CustomerID == customerID);
                    if (customer != null) {
                        tbCustomerName.Text = customer.CustomerName.ToString();
                        tbPhoneNumber.Text = customer.Phone.ToString();
                        tbEmail.Text = customer.Email.ToString();
                        tbAddress.Text = customer.Address.ToString();
                    }
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e) {

        }

        private void btnAdd_Click(object sender, EventArgs e) {
            using (var db = new QuanLyDBVLXDDataContext()) {
                Customer customer = new Customer();
                customer.CustomerName = tbCustomerName.Text;
                customer.Email = tbEmail.Text;
                customer.Address = tbAddress.Text;
                customer.Phone = tbPhoneNumber.Text;
                customer.CreatedAt = DateTime.Now;

                db.Customers.InsertOnSubmit(customer);
                db.SubmitChanges();

            }
            getCustomersData();
        }

        private void DeselectDataGridViewRows() {
            dataGVCustomers.ClearSelection();
            dataGVCustomers.CurrentCell = null;
        }


        private void guna2Button1_Click_1(object sender, EventArgs e) {
            getCustomersData();
            dataGVCustomers.ClearSelection();
            tbCustomerName.Text = null;
            tbPhoneNumber.Text = null;
            tbEmail.Text = null;
            tbAddress.Text = null;
            tbSearch.Text = null;
            cbCriterial.SelectedValue = null;
        }

        private void dataGVCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No) {
                return;
            }
            if (dataGVCustomers.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVCustomers.SelectedRows[0];
                int customerID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var customer = db.Customers.SingleOrDefault(m => m.CustomerID == customerID);
                    if (customer != null) {
                        if (customer.Orders.Any()) {
                            var result = MessageBox.Show("Vật liệu này có những dữ liệu khác liên quan. Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.No) {
                                return;
                            }
                            var orders = db.Orders.Where(od => od.CustomerID == customerID).ToList();
                            foreach (var order in orders) {
                                db.Orders.DeleteOnSubmit(order);
                            }
                        }

                        db.Customers.DeleteOnSubmit(customer);
                        db.SubmitChanges();
                    }
                }
            }
            getCustomersData();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            string keyword = tbSearch.Text.Trim().ToLower();
            string selectedCriteria = cbCriterial.SelectedItem.ToString();

            using (var db = new QuanLyDBVLXDDataContext()) {
                IQueryable<Customer> query = db.Customers;
                switch (selectedCriteria) {
                    case "Mã khách hàng":
                        if (int.TryParse(keyword, out var customerID)) {
                            query = query.Where(m => m.CustomerID == customerID);
                        }
                        break;
                    case "Tên khách hàng":
                        query = query.Where(m => m.CustomerName.ToLower().Contains(keyword));
                        break;
                    case "Email":
                        query = query.Where(m => m.Email.ToLower().Contains(keyword));
                        break;
                    default:
                        break;
                }
                if(query.ToList() == null) {
                    MessageBox.Show("không tìm thấy", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dataGVCustomers.DataSource = query.ToList();
            }
            DeselectDataGridViewRows();
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e) {

        }
    }
}
