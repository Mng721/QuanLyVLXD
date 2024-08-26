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
    public partial class UC_Supplier : UserControl {
        public UC_Supplier() {
            InitializeComponent();
            getSuppliersData();
            DeselectDataGridViewRows();
            dataGVSuppliers.SelectionChanged += dataGVSuppliers_SelectionChanged;
        }

        public void getSuppliersData() {
            using (QuanLyDBVLXDDataContext db = new QuanLyDBVLXDDataContext()) {
                var supplierList = (from supplier in db.Suppliers
                                    select new {
                                        SupplierName = supplier.SupplierName,
                                        SupplierID = supplier.SupplierID,
                                        Phone = supplier.Phone,
                                        Email = supplier.Email,
                                        Address = supplier.Address
                                    }).ToList();
                dataGVSuppliers.DataSource = supplierList;
            }
            DeselectDataGridViewRows();
        }


        private void lb_Click(object sender, EventArgs e) {

        }

        private void guna2Button3_Click(object sender, EventArgs e) {
            if (dataGVSuppliers.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVSuppliers.SelectedRows[0];
                int supplierID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var supplier = db.Suppliers.FirstOrDefault(m => m.SupplierID == supplierID);
                    if (supplier != null) {
                        supplier.SupplierName = tbSupplierName.Text;
                        supplier.Phone = tbPhoneNumber.Text;
                        supplier.Email = tbEmail.Text;
                        supplier.Address = tbAddress.Text;

                        db.SubmitChanges();
                    }
                }
                getSuppliersData();
            }
        }

        private void dataGVSuppliers_SelectionChanged(object sender, EventArgs e) {
            if (dataGVSuppliers.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVSuppliers.SelectedRows[0];
                int supplierID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var supplier = db.Suppliers.FirstOrDefault(m => m.SupplierID == supplierID);
                    if (supplier != null) {
                        tbSupplierName.Text = supplier.SupplierName.ToString();
                        tbPhoneNumber.Text = supplier.Phone.ToString();
                        tbEmail.Text = supplier.Email.ToString();
                        tbAddress.Text = supplier.Address.ToString();
                    }
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e) {

        }

        private void btnAdd_Click(object sender, EventArgs e) {
            using (var db = new QuanLyDBVLXDDataContext()) {
                Supplier supplier = new Supplier();
                supplier.SupplierName = tbSupplierName.Text;
                supplier.Email = tbEmail.Text;
                supplier.Address = tbAddress.Text;
                supplier.Phone = tbPhoneNumber.Text;
                supplier.CreatedAt = DateTime.Now;

                db.Suppliers.InsertOnSubmit(supplier);
                db.SubmitChanges();

            }
            getSuppliersData();
        }

        private void DeselectDataGridViewRows() {
            dataGVSuppliers.ClearSelection();
            dataGVSuppliers.CurrentCell = null;
        }


        private void guna2Button1_Click_1(object sender, EventArgs e) {
            getSuppliersData();
            dataGVSuppliers.ClearSelection();
            tbSupplierName.Text = null;
            tbPhoneNumber.Text = null;
            tbEmail.Text = null;
            tbAddress.Text = null;
            tbSearch.Text = null;
            cbCriterial.SelectedValue = null;
        }

        private void dataGVSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No) {
                return;
            }
            if (dataGVSuppliers.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVSuppliers.SelectedRows[0];
                int supplierID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var supplier = db.Suppliers.SingleOrDefault(m => m.SupplierID == supplierID);
                    if (supplier != null) {
                        if (supplier.Purchases.Any()) {
                            var result = MessageBox.Show("Vật liệu này có những dữ liệu khác liên quan. Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.No) {
                                return;
                            }
                            var purchases = db.Purchases.Where(pc => pc.SupplierID == supplierID).ToList();
                            foreach (var purchase in purchases) {
                                db.Purchases.DeleteOnSubmit(purchase);
                            }
                        }

                        db.Suppliers.DeleteOnSubmit(supplier);
                        db.SubmitChanges();
                    }
                }
            }
            getSuppliersData();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            string keyword = tbSearch.Text.Trim().ToLower();
            string selectedCriteria = cbCriterial.SelectedItem.ToString();

            using (var db = new QuanLyDBVLXDDataContext()) {
                IQueryable<Supplier> query = db.Suppliers;
                switch (selectedCriteria) {
                    case "Mã nhà cung cấp":
                        if (int.TryParse(keyword, out var supplierID)) {
                            query = query.Where(m => m.SupplierID == supplierID);
                        }
                        break;
                    case "Tên nhà cung cấp":
                        query = query.Where(m => m.SupplierName.ToLower().Contains(keyword));
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
                dataGVSuppliers.DataSource = query.ToList();
            }
            DeselectDataGridViewRows();
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e) {

        }
    }
}
