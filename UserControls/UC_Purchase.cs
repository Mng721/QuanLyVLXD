using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace QuanLyVLXD.UserControls {
    public partial class UC_Purchase : UserControl {

        int purchaseID;
        public UC_Purchase() {
            InitializeComponent();
            getPurchase();
            getSupplierName();
            DeselectDataGridViewRows();

            dataGVPurchases.SelectionChanged += dataGVMaterials_SelectionChanged;
        }

        public void getPurchase() {
            using (QuanLyDBVLXDDataContext db = new QuanLyDBVLXDDataContext()) {
                var purchaseList = (from purchase in db.Purchases
                                    join supplier in db.Suppliers
                                    on purchase.SupplierID equals supplier.SupplierID
                                    select new {
                                        PurchaseID = purchase.PurchaseID,
                                        SupplierName = supplier.SupplierName,
                                        PurchaseDate = purchase.PurchaseDate,
                                        TotalAmount = purchase.TotalAmount,
                                        Status = purchase.Status
                                    }).ToList();
                dataGVPurchases.DataSource = purchaseList;
            }
            DeselectDataGridViewRows();
        }
        public void getSupplierName() {
            using (var db = new QuanLyDBVLXDDataContext()) {
                var suppliers = db.Suppliers.Select(c => new { c.SupplierID, c.SupplierName }).ToList();
                cbSupplier.DataSource = suppliers;
                cbSupplier.DisplayMember = "SupplierName";
                cbSupplier.ValueMember = "SupplierID";
            }
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) {

        }

        private void lb_Click(object sender, EventArgs e) {

        }


        private void dataGVMaterials_SelectionChanged(object sender, EventArgs e) {
            if (dataGVPurchases.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVPurchases.SelectedRows[0];
                purchaseID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var purchase = db.Purchases.FirstOrDefault(m => m.PurchaseID == purchaseID);
                    if (purchase != null) {
                        cbSupplier.SelectedValue = purchase.SupplierID;
                        btnPurchaseDetail.Enabled = true;

                        if (purchase.Status.ToLower() == "completed") {
                            btnComplete.Enabled = false;
                            btnEdit.Enabled = false;
                            btnDelete.Enabled = false;
                        } else {
                            btnComplete.Enabled = true;
                            btnEdit.Enabled = true;
                            btnDelete.Enabled = true;
                        }
                        /* tbMaterialName.Text = material.MaterialName.ToString();
                         tbQuantity.Text = material.Quantity.ToString();
                         tbUnit.Text = material.Unit.ToString();
                         tbPrice.Text = material.Price.ToString();*/
                    } else {
                        btnPurchaseDetail.Enabled = false;
                    }
                }

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e) {

        }

        private void btnAdd_Click(object sender, EventArgs e) {
            using (var db = new QuanLyDBVLXDDataContext()) {
                var purchase = new Purchase();
                purchase.SupplierID = (int)cbSupplier.SelectedValue;
                purchase.PurchaseDate = DateTime.Now;
                purchase.Status = "Pending";

                db.Purchases.InsertOnSubmit(purchase);
                db.SubmitChanges();
                /*Material material = new Material();
                material.MaterialName = tbMaterialName.Text;
                material.Unit = tbUnit.Text;
                material.Price = Convert.ToDecimal(tbPrice.Text);
                material.Quantity = Convert.ToInt32(tbQuantity.Text);
                material.CreatedAt = DateTime.Now;

                db.Materials.InsertOnSubmit(material);
                db.SubmitChanges();*/

            }
            getPurchase();
        }

        private void DeselectDataGridViewRows() {
            dataGVPurchases.ClearSelection();
            dataGVPurchases.CurrentCell = null;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e) {
            getPurchase();
            dataGVPurchases.ClearSelection();
            /*dataGVMaterials.ClearSelection();
            tbMaterialName.Text = null;
            tbQuantity.Text = null;*/
        }

        private void dataGVMaterials_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No) {
                return;
            }
            if (dataGVPurchases.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVPurchases.SelectedRows[0];
                int materialID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var purchase = db.Purchases.SingleOrDefault(m => m.PurchaseID == purchaseID);
                    if (purchase != null) {
                        if (purchase.PurchaseDetails.Any()) {
                            var result = MessageBox.Show("Vật liệu này có những dữ liệu khác liên quan. Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.No) {
                                return;
                            }
                            var purchaseDetails = db.PurchaseDetails.Where(od => od.PurchaseID == purchaseID).ToList();
                            foreach (var purchaseDetail in purchaseDetails) {
                                db.PurchaseDetails.DeleteOnSubmit(purchaseDetail);
                            }
                            db.Purchases.DeleteOnSubmit(purchase);
                            db.SubmitChanges();
                        }

                        db.Purchases.DeleteOnSubmit(purchase);
                        db.SubmitChanges();
                    }
                }
            }
            getPurchase();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (tbSearch.Text == null) {
                MessageBox.Show("Xin mời nhập dữ liệu cần tìm", "Nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSearch.Focus();
          
            }
            string keyword = tbSearch.Text.Trim().ToLower();
            string selectedCriteria = cbCriterial.SelectedItem.ToString();

            using (var db = new QuanLyDBVLXDDataContext()) {
                IQueryable<Purchase> query = db.Purchases;
                switch (selectedCriteria) {
                    case "PurchaseID":
                        if (int.TryParse(keyword, out var purchaseID)) {
                            query = query.Where(m => m.PurchaseID == purchaseID);
                        }
                        dataGVPurchases.DataSource = query.ToList();
                        break;
                    case "Tên nhà cung cấp":
                        SearchPurchasesBySupplierName(keyword);
                        break;
                    default:

                        SearchPurchasesBySupplierName(keyword);
                        break;
                }
            }
            DeselectDataGridViewRows();
        }

        private void btnPurchaseDetail_Click(object sender, EventArgs e) {
            PurchaseDetailForm purchaseDetail = new PurchaseDetailForm(purchaseID);
            purchaseDetail.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (dataGVPurchases.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVPurchases.SelectedRows[0];
                int purchaseID = Convert.ToInt32(dataGridViewRow.Cells["PurchaseID"].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var purchase = db.Purchases.FirstOrDefault(o => o.PurchaseID == purchaseID);
                    if (purchase != null) {
                        purchase.SupplierID = (int)cbSupplier.SelectedValue;
                        /*
                        material.MaterialName = tbMaterialName.Text;
                        material.Unit = tbUnit.Text;
                        material.Price = Convert.ToDecimal(tbPrice.Text);
                        material.Quantity = Convert.ToInt32(tbQuantity.Text);
                        material.UpdatedAt = DateTime.Now;*/

                        db.SubmitChanges();
                    }
                }
                getPurchase();
            }
        }

        private void SearchPurchasesBySupplierName(string supplierName) {
            using (var context = new QuanLyDBVLXDDataContext()) {
                var purchaseList = context.Purchases
                    .Join(context.Suppliers,
                          purchase => purchase.SupplierID,
                          supplier => supplier.SupplierID,
                          (purchase, supplier) => new { purchase, supplier })
                    .Where(o => o.supplier.SupplierName.ToLower().Contains(supplierName))
                    .Select(o => new {
                        PurchaseID = o.purchase.PurchaseID,
                        SupplierName = o.supplier.SupplierName,
                        PurchaseDate = o.purchase.PurchaseDate,
                        TotalAmount = o.purchase.TotalAmount,
                        Status = o.purchase.Status
                    })
                    .ToList();

                dataGVPurchases.DataSource = purchaseList;
            }
        }

        private void btnComplete_Click(object sender, EventArgs e) {
            if (dataGVPurchases.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVPurchases.SelectedRows[0];
                int purchaseID = Convert.ToInt32(dataGridViewRow.Cells["PurchaseID"].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var purchase = db.Purchases.FirstOrDefault(o => o.PurchaseID == purchaseID);
                    if (purchase != null) {
                        purchase.Status = "Completed";
                        var purchaseDetailList = db.PurchaseDetails.Where(p => p.PurchaseID == purchase.PurchaseID).ToList();
                        foreach (var purchaseDetail in purchaseDetailList) {
                            var material = db.Materials.FirstOrDefault(m => m.MaterialID == purchaseDetail.MaterialID);
                            if (material.Quantity != null) {
                                material.Quantity += (int)purchaseDetail.Quantity;
                            }
                        }
                        /*
                        material.MaterialName = tbMaterialName.Text;
                        material.Unit = tbUnit.Text;
                        material.Price = Convert.ToDecimal(tbPrice.Text);
                        material.Quantity = Convert.ToInt32(tbQuantity.Text);
                        material.UpdatedAt = DateTime.Now;*/

                        db.SubmitChanges();
                    }
                }
                getPurchase();
            }
        }
    }
}
