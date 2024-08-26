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
    public partial class UC_Order : UserControl {

        int orderID;
        public UC_Order() {
            InitializeComponent();
            getOrder();
            getCustomerName();
            DeselectDataGridViewRows();

            dataGVOrders.SelectionChanged += dataGVMaterials_SelectionChanged;
        }

        public void getOrder() {
            using (QuanLyDBVLXDDataContext db = new QuanLyDBVLXDDataContext()) {
                var orderList = (from order in db.Orders
                                 join customer in db.Customers
                                 on order.CustomerID equals customer.CustomerID
                                 select new {
                                     OrderID = order.OrderID,
                                     CustomerName = customer.CustomerName,
                                     OrderDate = order.OrderDate,
                                     TotalAmount = order.TotalAmount,
                                     Status = order.Status
                                 }).ToList();
                dataGVOrders.DataSource = orderList;
            }
            DeselectDataGridViewRows();
        }
        public void getCustomerName() {
            using (var db = new QuanLyDBVLXDDataContext()) {
                var customers = db.Customers.Select(c => new { c.CustomerID, c.CustomerName }).ToList();
                cbCutomer.DataSource = customers;
                cbCutomer.DisplayMember = "CustomerName";
                cbCutomer.ValueMember = "CustomerID";
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
            if (dataGVOrders.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVOrders.SelectedRows[0];
                orderID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var order = db.Orders.FirstOrDefault(m => m.OrderID == orderID);
                    if (order != null) {
                        cbCutomer.SelectedItem = order.Customer.CustomerID;
                        btnOrderDetail.Enabled = true;
                        if (order.Status.ToLower() == "completed") {
                            btnComplete.Enabled = false;
                            btnDelete.Enabled = false;
                            btnEdit.Enabled = false;
                        } else {
                            btnComplete.Enabled=true;
                            btnDelete.Enabled=true;
                            btnEdit.Enabled=true;  
                        }
                        /* tbMaterialName.Text = material.MaterialName.ToString();
                         tbQuantity.Text = material.Quantity.ToString();
                         tbUnit.Text = material.Unit.ToString();
                         tbPrice.Text = material.Price.ToString();*/
                    } else {
                        btnOrderDetail.Enabled=false;
                    }

                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e) {

        }

        private void btnAdd_Click(object sender, EventArgs e) {
            using (var db = new QuanLyDBVLXDDataContext()) {
                var order = new Order();
                order.CustomerID = (int)cbCutomer.SelectedValue;
                order.OrderDate = DateTime.Now;
                order.Status = "Pending";
                db.Orders.InsertOnSubmit(order);
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
            getOrder();
        }

        private void DeselectDataGridViewRows() {
            dataGVOrders.ClearSelection();
            dataGVOrders.CurrentCell = null;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e) {
            getOrder();
            dataGVOrders.ClearSelection();
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
            if (dataGVOrders.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVOrders.SelectedRows[0];
                int materialID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var order = db.Orders.SingleOrDefault(m => m.OrderID == orderID);
                    if (order != null) {
                        if (order.OrderDetails.Any()) {
                            var result = MessageBox.Show("Vật liệu này có những dữ liệu khác liên quan. Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.No) {
                                return;
                            }
                            var orderDetails = db.OrderDetails.Where(od => od.OrderID == orderID).ToList();
                            foreach (var orderDetail in orderDetails) {
                                db.OrderDetails.DeleteOnSubmit(orderDetail);
                            }
                            db.Orders.DeleteOnSubmit(order);
                            db.SubmitChanges();
                        }

                        db.Orders.DeleteOnSubmit(order);
                        db.SubmitChanges();
                    }
                }
            }
            getOrder();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            string keyword = tbSearch.Text.Trim().ToLower();
            string selectedCriteria = cbCriterial.SelectedItem.ToString();

            using (var db = new QuanLyDBVLXDDataContext()) {
                IQueryable<Order> query = db.Orders;
                switch (selectedCriteria) {
                    case "OrderID":
                        if (int.TryParse(keyword, out var orderID)) {
                            query = query.Where(m => m.OrderID == orderID);
                            dataGVOrders.DataSource = query.ToList();
                        }
                        break;
                    case "Tên khách hàng":
                        SearchOrdersByCustomerName(keyword);
                        break;
                    default:
                        break;
                }
            }
            DeselectDataGridViewRows();
        }

        private void btnOrderDetail_Click(object sender, EventArgs e) {
            OrderDetailForm orderDetail = new OrderDetailForm(orderID);
            orderDetail.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (dataGVOrders.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVOrders.SelectedRows[0];
                int orderID = Convert.ToInt32(dataGridViewRow.Cells["OrderID"].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var order = db.Orders.FirstOrDefault(o => o.OrderID == orderID);
                    if (order != null) {
                        order.CustomerID = (int)cbCutomer.SelectedValue;
                        /*
                        material.MaterialName = tbMaterialName.Text;
                        material.Unit = tbUnit.Text;
                        material.Price = Convert.ToDecimal(tbPrice.Text);
                        material.Quantity = Convert.ToInt32(tbQuantity.Text);
                        material.UpdatedAt = DateTime.Now;*/

                        db.SubmitChanges();
                    }
                }
                getOrder();
            }
        }
        private void SearchOrdersByCustomerName(string customerName) {
            using (var context = new QuanLyDBVLXDDataContext()) {
                var orderList = context.Orders
                    .Join(context.Customers,
                          order => order.CustomerID,
                          customer => customer.CustomerID,
                          (order, customer) => new { order, customer })
                    .Where(o => o.customer.CustomerName.ToLower().Contains(customerName))
                    .Select(o => new {
                        OrderID = o.order.OrderID,
                        CustomerName = o.customer.CustomerName,
                        OrderDate = o.order.OrderDate,
                        TotalAmount = o.order.TotalAmount,
                        Status = o.order.Status
                    })
                    .ToList();

                dataGVOrders.DataSource = orderList;
            }
        }

        private void guna2Button1_Click_2(object sender, EventArgs e) {
            if (dataGVOrders.SelectedRows.Count > 0) {
                DataGridViewRow dataGridViewRow = dataGVOrders.SelectedRows[0];
                int orderID = Convert.ToInt32(dataGridViewRow.Cells["OrderID"].Value);

                using (var db = new QuanLyDBVLXDDataContext()) {
                    var order = db.Orders.FirstOrDefault(o => o.OrderID == orderID);
                    if (order != null) {
                        order.Status = "Completed";
                        var orderDetailList = db.OrderDetails.Where(o => o.OrderID == order.OrderID).ToList();
                        foreach (var orderDetail in orderDetailList) {
                            var material = db.Materials.FirstOrDefault(m=> m.MaterialID == orderDetail.MaterialID);
                            if (orderDetail.Quantity != null) {
                                material.Quantity -= (int)orderDetail.Quantity;
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
                getOrder();
            }
        }
    }
}
