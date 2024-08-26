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
    public partial class OrderDetailForm : Form {
        int orderID;
        public OrderDetailForm(int orderID) {
            InitializeComponent();
            this.orderID = orderID;
            loadDataOrder();
            loadDataOrderDetail();
            dataGVOrderDetails.SelectionChanged += dataGVMaterials_SelectionChanged;
            loadMaterialName();
        }

        private void loadDataOrder() {
            using (var db = new QuanLyDBVLXDDataContext()) {
                var order = db.Orders.FirstOrDefault(m => m.OrderID == orderID);
                if (order != null) {
                    var customer = db.Customers.FirstOrDefault(c => c.CustomerID == order.CustomerID);
                    if (customer != null) {
                        tbCustomerName.Text = customer.CustomerName;
                    }
                    tbOrderDate.Text = order.OrderDate.ToString();
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

        private void loadDataOrderDetail() {
            using (QuanLyDBVLXDDataContext db = new QuanLyDBVLXDDataContext()) {
                var orderDetailList = (from orderDetail in db.OrderDetails
                                       join material in db.Materials
                                       on orderDetail.MaterialID equals material.MaterialID
                                       where orderDetail.OrderID == orderID
                                       select new {
                                           OrderDetailID = orderDetail.OrderDetailID,
                                           MaterialName = material.MaterialName,
                                           Quantity = orderDetail.Quantity,
                                           UnitPrice = orderDetail.UnitPrice,
                                           TotalPrice = orderDetail.TotalPrice
                                       }).ToList();
                dataGVOrderDetails.DataSource = orderDetailList;
            }
        }
        private void dataGVMaterials_SelectionChanged(object sender, EventArgs e) {

            if (dataGVOrderDetails.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVOrderDetails.SelectedRows[0];
                var orderDetailID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);
                using (var db = new QuanLyDBVLXDDataContext()) {
                    var orderDetail = db.OrderDetails.FirstOrDefault(m => m.OrderDetailID == orderDetailID);
                    if (orderDetail != null) {
                        cbMaterial.SelectedValue = orderDetail.MaterialID;

                        tbQuantity.Text = orderDetail.Quantity.ToString();
                        /*
                        cbCutomer.SelectedItem = order.Customer.CustomerName;
                        cbStatus.SelectedItem = order.Status;*/
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
                var orderDetail = new OrderDetail();
                orderDetail.OrderID = orderID;
                orderDetail.MaterialID = (int)cbMaterial.SelectedValue;
                /*                if (!int.TryParse(tbQuantity.Text, out int quantity)) {
                                    MessageBox.Show("Giá trị số lượng không hợp lệ. Vui lòng nhập một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    tbQuantity.Focus();
                                    return;
                                }*/
                if (!int.TryParse(tbQuantity.Text, out int quantity)) {
                    MessageBox.Show("Giá trị số lượng không hợp lệ. Vui lòng nhập một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbQuantity.Focus();
                    return;
                } else {
                    var material = db.Materials.FirstOrDefault(m => m.MaterialID == orderDetail.MaterialID);
                    if (tbQuantity.Text != null) {
                        if (int.Parse(tbQuantity.Text) > material.Quantity) {
                            MessageBox.Show($"Số lượng trong kho không đủ, số lượng của {material.MaterialName.ToString()} là: {material.Quantity.ToString()}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbQuantity.Focus();
                            return;
                        }
                    }
                }
                orderDetail.Quantity = int.Parse(tbQuantity.Text);
                orderDetail.UnitPrice = db.Materials.FirstOrDefault(m => m.MaterialID == (int)cbMaterial.SelectedValue).Price;
                orderDetail.TotalPrice = orderDetail.UnitPrice * orderDetail.Quantity;
                db.OrderDetails.InsertOnSubmit(orderDetail);
                db.SubmitChanges();
            }
            loadDataOrderDetail();
        }

        private decimal? CalculateTotalAmount(int orderId) {
            using (var context = new QuanLyDBVLXDDataContext()) {
                var totalAmount = context.OrderDetails
                    .Where(od => od.OrderID == orderId)
                    .Sum(od => od.TotalPrice);
                return totalAmount;
            }
        }

        private void btnExit_Click(object sender, EventArgs e) {
            using (var db = new QuanLyDBVLXDDataContext()) {
                var order = db.Orders.FirstOrDefault(o => o.OrderID == orderID);
                if (order != null) {
                    order.TotalAmount = CalculateTotalAmount(orderID);

                    db.SubmitChanges();
                    this.Close();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (dataGVOrderDetails.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVOrderDetails.SelectedRows[0];
                int materialID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var orderDetail = db.OrderDetails.FirstOrDefault(m => m.MaterialID == materialID);
                    if (orderDetail != null) {
                        orderDetail.MaterialID = (int)cbMaterial.SelectedValue;
                        if (!int.TryParse(tbQuantity.Text, out int quantity)) {
                            MessageBox.Show("Giá trị số lượng không hợp lệ. Vui lòng nhập một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbQuantity.Focus();
                            return;
                        }
                        orderDetail.Quantity = int.Parse(tbQuantity.Text);
                        /*
                        material.MaterialName = tbMaterialName.Text;
                        material.Unit = tbUnit.Text;
                        material.Price = Convert.ToDecimal(tbPrice.Text);
                        material.Quantity = Convert.ToInt32(tbQuantity.Text);
                        material.UpdatedAt = DateTime.Now;*/

                        db.SubmitChanges();
                    }
                }
                loadDataOrderDetail();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No) {
                return;
            }
            if (dataGVOrderDetails.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVOrderDetails.SelectedRows[0];
                int orderDetailID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var orderDetail = db.OrderDetails.SingleOrDefault(o => o.OrderDetailID == orderDetailID);
                    if (orderDetailID != null) {
                        db.OrderDetails.DeleteOnSubmit(orderDetail);
                        db.SubmitChanges();
                    }
                }
            }
            loadDataOrderDetail();
        }

        private void cbMaterial_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
