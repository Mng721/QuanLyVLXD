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
    public partial class UC_Materials : UserControl {
        public UC_Materials() {
            InitializeComponent();
            getMaterialsData();
            DeselectDataGridViewRows();
            dataGVMaterials.SelectionChanged += dataGVMaterials_SelectionChanged;
        }

        public void getMaterialsData() {
            using (QuanLyDBVLXDDataContext db = new QuanLyDBVLXDDataContext()) {
                var result = from c in db.Materials
                             select c;
                dataGVMaterials.DataSource = result.ToList();
            }
            DeselectDataGridViewRows();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) {

        }

        private void lb_Click(object sender, EventArgs e) {

        }

        private void guna2Button3_Click(object sender, EventArgs e) {
            if (dataGVMaterials.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVMaterials.SelectedRows[0];
                int materialID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var material = db.Materials.FirstOrDefault(m => m.MaterialID == materialID);
                    if (material != null) {
                        material.MaterialName = tbMaterialName.Text;
                        material.Unit = tbUnit.Text;
                        material.Price = Convert.ToDecimal(tbPrice.Text);
                        material.Quantity = Convert.ToInt32(tbQuantity.Text);
                        material.UpdatedAt = DateTime.Now;

                        db.SubmitChanges();
                    }
                }
                getMaterialsData();
            }
        }

        private void dataGVMaterials_SelectionChanged(object sender, EventArgs e) {
            if (dataGVMaterials.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVMaterials.SelectedRows[0];
                int materialID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var material = db.Materials.FirstOrDefault(m => m.MaterialID == materialID);
                    if (material != null) {
                        tbMaterialName.Text = material.MaterialName.ToString();
                        tbQuantity.Text = material.Quantity.ToString();
                        tbUnit.Text = material.Unit.ToString();
                        tbPrice.Text = material.Price.ToString();
                    }
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e) {

        }

        private void btnAdd_Click(object sender, EventArgs e) {
            using (var db = new QuanLyDBVLXDDataContext()) {
                Material material = new Material();
                material.MaterialName = tbMaterialName.Text;
                material.Unit = tbUnit.Text;
                material.Price = Convert.ToDecimal(tbPrice.Text);
                material.Quantity = Convert.ToInt32(tbQuantity.Text);
                material.CreatedAt = DateTime.Now;

                db.Materials.InsertOnSubmit(material);
                db.SubmitChanges();

            }
            getMaterialsData();
        }

        private void DeselectDataGridViewRows() {
            dataGVMaterials.ClearSelection();
            dataGVMaterials.CurrentCell = null;
        }


        private void guna2Button1_Click_1(object sender, EventArgs e) {
            getMaterialsData();
            dataGVMaterials.ClearSelection();
            tbMaterialName.Text = null;
            tbQuantity.Text = null;
            tbUnit.Text = null;
            tbPrice.Text = null;
            tbSearch.Text = null;
            cbCriterial.SelectedValue = null;
        }

        private void dataGVMaterials_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No) {
                return;
            }
            if (dataGVMaterials.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVMaterials.SelectedRows[0];
                int materialID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var material = db.Materials.SingleOrDefault(m => m.MaterialID == materialID);
                    if (material != null) {
                        if (material.OrderDetails.Any()) {
                            var result = MessageBox.Show("Vật liệu này có những dữ liệu khác liên quan. Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.No) {
                                return;
                            }
                            var orderDetails = db.OrderDetails.Where(od => od.MaterialID == materialID).ToList();
                            foreach (var orderDetail in orderDetails) {
                                db.OrderDetails.DeleteOnSubmit(orderDetail);
                            }
                            var purchaseDetails = db.PurchaseDetails.Where(pc => pc.MaterialID == materialID).ToList();
                            foreach (var puschaseDetail in purchaseDetails) {
                                db.PurchaseDetails.DeleteOnSubmit(puschaseDetail);
                            }
                        }

                        db.Materials.DeleteOnSubmit(material);
                        db.SubmitChanges();
                    }
                }
            }
            getMaterialsData();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            string keyword = tbSearch.Text.Trim().ToLower();
            string selectedCriteria = cbCriterial.SelectedItem.ToString();

            using(var db = new QuanLyDBVLXDDataContext()) {
                IQueryable<Material> query = db.Materials;
                switch (selectedCriteria) {
                    case "Mã vật liệu":
                        if (int.TryParse(keyword, out var materialID)) {
                            query = query.Where(m => m.MaterialID == materialID);
                        }
                        break;
                    case "Tên vật liệu":
                        query = query.Where(m => m.MaterialName.ToLower().Contains(keyword));
                        break;
                    case "Đơn vị":
                        query = query.Where(m => m.Unit.ToLower().Contains(keyword));
                        break;
                    default:
                        break;
                }
                dataGVMaterials.DataSource = query.ToList();
            }
            DeselectDataGridViewRows();
        }
       
    }
}
