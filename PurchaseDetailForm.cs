using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVLXD {
    public partial class PurchaseDetailForm : Form {
        int purchaseID;
        public PurchaseDetailForm(int purchaseID) {
            InitializeComponent();
            this.purchaseID = purchaseID;
            loadDataPurchase();
            loadDataPurchaseDetail();
            loadMaterialName();
        }

        private void loadDataPurchase() {
            using (var db = new QuanLyDBVLXDDataContext()) {
                var purchase = db.Purchases.FirstOrDefault(m => m.PurchaseID == purchaseID);
                if (purchase != null) {
                    var supplier = db.Suppliers.FirstOrDefault(c => c.SupplierID == purchase.SupplierID);
                    if (supplier != null) {
                        tbSupplierName.Text = supplier.SupplierName;
                    }
                    tbPurchaseDate.Text = purchase.PurchaseDate.ToString();
                }
            }
        }

        public void loadMaterialName() {
            using (var db = new QuanLyDBVLXDDataContext()) {
                var materials = db.Materials.Select(m => new { m.MaterialID, m.MaterialName }).ToList();
                cbMaterial.DataSource = materials;
                cbMaterial.DisplayMember = "MaterialName";
                cbMaterial.ValueMember = "MaterialID";
            }
        }

        private void loadDataPurchaseDetail() {
            using (QuanLyDBVLXDDataContext db = new QuanLyDBVLXDDataContext()) {
                var purchaseDetailList = (from purchaseDetail in db.PurchaseDetails
                                       join material in db.Materials
                                       on purchaseDetail.MaterialID equals material.MaterialID
                                       where purchaseDetail.PurchaseID == purchaseID
                                       select new {
                                           PurchaseDetailID = purchaseDetail.PurchaseDetailID,
                                           MaterialName = material.MaterialName,
                                           Quantity = purchaseDetail.Quantity,
                                           UnitPrice = purchaseDetail.UnitPrice,
                                           TotalPrice = purchaseDetail.TotalPrice
                                       }).ToList();
                dataGVPurchaseDetails.DataSource = purchaseDetailList;
            }
        }
        private void dataGVMaterials_SelectionChanged(object sender, EventArgs e) {

            if (dataGVPurchaseDetails.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVPurchaseDetails.SelectedRows[0];
                var purchaseDetailID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var purchaseDetail = db.PurchaseDetails.FirstOrDefault(m => m.PurchaseDetailID == purchaseDetailID);
                    if (purchaseDetail != null) {
                        cbMaterial.SelectedValue = purchaseDetail.MaterialID;
                        tbQuantity.Text = purchaseDetail.Quantity.ToString();
                        /*
                        cbCutomer.SelectedItem = purchase.Supplier.SupplierName;
                        cbStatus.SelectedItem = purchase.Status;*/
                        /* tbMaterialName.Text = material.MaterialName.ToString();
                         tbQuantity.Text = material.Quantity.ToString();
                         tbUnit.Text = material.Unit.ToString();
                         tbPrice.Text = material.Price.ToString();*/
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            using (var db = new QuanLyDBVLXDDataContext()) {
                var purchaseDetail = new PurchaseDetail();
                purchaseDetail.PurchaseID = purchaseID;
                purchaseDetail.MaterialID = (int)cbMaterial.SelectedValue;
                if (!int.TryParse(tbQuantity.Text, out int quantity)) {
                    MessageBox.Show("Giá trị số lượng không hợp lệ. Vui lòng nhập một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbQuantity.Focus();
                    return;
                }
                purchaseDetail.Quantity = int.Parse(tbQuantity.Text);
                purchaseDetail.UnitPrice = db.Materials.FirstOrDefault(m => m.MaterialID == (int)cbMaterial.SelectedValue).Price;
                purchaseDetail.TotalPrice = purchaseDetail.UnitPrice * purchaseDetail.Quantity;
                db.PurchaseDetails.InsertOnSubmit(purchaseDetail);
                db.SubmitChanges();
            }
            loadDataPurchaseDetail();
        }

        private decimal? CalculateTotalAmount(int purchaseId) {
            using (var context = new QuanLyDBVLXDDataContext()) {
                var totalAmount = context.PurchaseDetails
                    .Where(od => od.PurchaseID == purchaseId)
                    .Sum(od => od.TotalPrice);
                return totalAmount;
            }
        }

        private void btnExit_Click(object sender, EventArgs e) {
            using (var db = new QuanLyDBVLXDDataContext()) {
                var purchase = db.Purchases.FirstOrDefault(o => o.PurchaseID == purchaseID);
                if (purchase != null) {
                    purchase.TotalAmount = CalculateTotalAmount(purchaseID);

                    db.SubmitChanges();
                    this.Close();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (dataGVPurchaseDetails.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVPurchaseDetails.SelectedRows[0];
                int materialID = Convert.ToInt32(dataGridViewRow.Cells["PurchaseDetailID"].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var purchaseDetail = db.PurchaseDetails.FirstOrDefault(m => m.MaterialID == materialID);
                    if (purchaseDetail != null) {
                        purchaseDetail.MaterialID = (int)cbMaterial.SelectedValue;
                        if (!int.TryParse(tbQuantity.Text, out int quantity)) {
                            MessageBox.Show("Giá trị số lượng không hợp lệ. Vui lòng nhập một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbQuantity.Focus();
                            return;
                        }
                        purchaseDetail.Quantity = int.Parse(tbQuantity.Text);
                        /*
                        material.MaterialName = tbMaterialName.Text;
                        material.Unit = tbUnit.Text;
                        material.Price = Convert.ToDecimal(tbPrice.Text);
                        material.Quantity = Convert.ToInt32(tbQuantity.Text);
                        material.UpdatedAt = DateTime.Now;*/

                        db.SubmitChanges();
                    }
                }
                loadDataPurchaseDetail();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No) {
                return;
            }
            if (dataGVPurchaseDetails.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVPurchaseDetails.SelectedRows[0];
                int purchaseDetailID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var purchaseDetail = db.PurchaseDetails.SingleOrDefault(o => o.PurchaseDetailID == purchaseDetailID);
                    if (purchaseDetailID != null) {
                        db.PurchaseDetails.DeleteOnSubmit(purchaseDetail);
                        db.SubmitChanges();
                    }
                }
            }
            loadDataPurchaseDetail();
        }

        private void cbMaterial_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
