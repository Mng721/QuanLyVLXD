namespace QuanLyVLXD {
    partial class OrderDetailForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dataGVOrderDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            OrderDetailID = new DataGridViewTextBoxColumn();
            MaterialID = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            orderDetailBindingSource = new BindingSource(components);
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            tbOrderDate = new TextBox();
            lbOrderDate = new Label();
            cbMaterial = new ComboBox();
            lbMaterialName = new Label();
            tbQuantity = new TextBox();
            label1 = new Label();
            lbCustomerName = new Label();
            tbCustomerName = new TextBox();
            btnExit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dataGVOrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGVOrderDetails
            // 
            dataGVOrderDetails.AllowUserToDeleteRows = false;
            dataGVOrderDetails.AllowUserToResizeColumns = false;
            dataGVOrderDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGVOrderDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGVOrderDetails.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGVOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGVOrderDetails.ColumnHeadersHeight = 17;
            dataGVOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGVOrderDetails.Columns.AddRange(new DataGridViewColumn[] { OrderDetailID, MaterialID, Quantity, UnitPrice, TotalPrice });
            dataGVOrderDetails.DataSource = orderDetailBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGVOrderDetails.DefaultCellStyle = dataGridViewCellStyle3;
            dataGVOrderDetails.GridColor = Color.FromArgb(231, 229, 255);
            dataGVOrderDetails.Location = new Point(12, 144);
            dataGVOrderDetails.Name = "dataGVOrderDetails";
            dataGVOrderDetails.ReadOnly = true;
            dataGVOrderDetails.RowHeadersVisible = false;
            dataGVOrderDetails.Size = new Size(776, 262);
            dataGVOrderDetails.TabIndex = 0;
            dataGVOrderDetails.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGVOrderDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGVOrderDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGVOrderDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGVOrderDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGVOrderDetails.ThemeStyle.BackColor = Color.White;
            dataGVOrderDetails.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGVOrderDetails.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGVOrderDetails.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGVOrderDetails.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataGVOrderDetails.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGVOrderDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGVOrderDetails.ThemeStyle.HeaderStyle.Height = 17;
            dataGVOrderDetails.ThemeStyle.ReadOnly = true;
            dataGVOrderDetails.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGVOrderDetails.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGVOrderDetails.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGVOrderDetails.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGVOrderDetails.ThemeStyle.RowsStyle.Height = 25;
            dataGVOrderDetails.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGVOrderDetails.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // OrderDetailID
            // 
            OrderDetailID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            OrderDetailID.DataPropertyName = "OrderDetailID";
            OrderDetailID.HeaderText = "OrderDetailID";
            OrderDetailID.Name = "OrderDetailID";
            OrderDetailID.ReadOnly = true;
            OrderDetailID.Width = 101;
            // 
            // MaterialID
            // 
            MaterialID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaterialID.DataPropertyName = "MaterialName";
            MaterialID.HeaderText = "Tên vật liệu";
            MaterialID.Name = "MaterialID";
            MaterialID.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Số lượng";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 77;
            // 
            // UnitPrice
            // 
            UnitPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            UnitPrice.DataPropertyName = "UnitPrice";
            UnitPrice.HeaderText = "Giá vật liệu";
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            UnitPrice.Width = 88;
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TotalPrice.DataPropertyName = "TotalPrice";
            TotalPrice.HeaderText = "Tổng";
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            TotalPrice.Width = 57;
            // 
            // orderDetailBindingSource
            // 
            orderDetailBindingSource.DataSource = typeof(OrderDetail);
            // 
            // btnEdit
            // 
            btnEdit.BorderRadius = 5;
            btnEdit.CustomizableEdges = customizableEdges1;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(410, 107);
            btnEdit.Name = "btnEdit";
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEdit.Size = new Size(122, 31);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BorderRadius = 5;
            btnDelete.CustomizableEdges = customizableEdges3;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(538, 107);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDelete.Size = new Size(122, 31);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 5;
            btnAdd.CustomizableEdges = customizableEdges5;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(282, 107);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAdd.Size = new Size(122, 31);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // tbOrderDate
            // 
            tbOrderDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbOrderDate.Location = new Point(538, 13);
            tbOrderDate.Name = "tbOrderDate";
            tbOrderDate.ReadOnly = true;
            tbOrderDate.Size = new Size(250, 33);
            tbOrderDate.TabIndex = 21;
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbOrderDate.Location = new Point(438, 16);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(102, 25);
            lbOrderDate.TabIndex = 22;
            lbOrderDate.Text = "Ngày mua:";
            // 
            // cbMaterial
            // 
            cbMaterial.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMaterial.FormattingEnabled = true;
            cbMaterial.Items.AddRange(new object[] { "Pending", "Completed" });
            cbMaterial.Location = new Point(131, 60);
            cbMaterial.Name = "cbMaterial";
            cbMaterial.Size = new Size(264, 33);
            cbMaterial.TabIndex = 1;
            cbMaterial.SelectedIndexChanged += cbMaterial_SelectedIndexChanged;
            // 
            // lbMaterialName
            // 
            lbMaterialName.AutoSize = true;
            lbMaterialName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMaterialName.Location = new Point(14, 63);
            lbMaterialName.Name = "lbMaterialName";
            lbMaterialName.Size = new Size(111, 25);
            lbMaterialName.TabIndex = 24;
            lbMaterialName.Text = "Tên vật liệu:";
            // 
            // tbQuantity
            // 
            tbQuantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbQuantity.Location = new Point(511, 60);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(277, 33);
            tbQuantity.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(414, 63);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 27;
            label1.Text = "Số lượng:";
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCustomerName.Location = new Point(14, 16);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(148, 25);
            lbCustomerName.TabIndex = 19;
            lbCustomerName.Text = "Tên khách hàng:";
            // 
            // tbCustomerName
            // 
            tbCustomerName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCustomerName.Location = new Point(168, 13);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.ReadOnly = true;
            tbCustomerName.Size = new Size(264, 33);
            tbCustomerName.TabIndex = 23;
            // 
            // btnExit
            // 
            btnExit.BorderRadius = 5;
            btnExit.CustomizableEdges = customizableEdges7;
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(666, 107);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnExit.Size = new Size(122, 31);
            btnExit.TabIndex = 28;
            btnExit.Text = "Thoát";
            btnExit.Click += btnExit_Click;
            // 
            // OrderDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 420);
            Controls.Add(btnExit);
            Controls.Add(tbQuantity);
            Controls.Add(label1);
            Controls.Add(cbMaterial);
            Controls.Add(lbMaterialName);
            Controls.Add(tbCustomerName);
            Controls.Add(tbOrderDate);
            Controls.Add(lbOrderDate);
            Controls.Add(lbCustomerName);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGVOrderDetails);
            Name = "OrderDetailForm";
            Text = "OrderDetailForm";
            ((System.ComponentModel.ISupportInitialize)dataGVOrderDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGVOrderDetails;
        private BindingSource orderDetailBindingSource;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private TextBox tbOrderDate;
        private Label lbOrderDate;
        private ComboBox cbMaterial;
        private Label lbMaterialName;
        private TextBox tbQuantity;
        private Label label1;
        private Label lbCustomerName;
        private TextBox tbCustomerName;
        private DataGridViewTextBoxColumn MaterialName;
        private DataGridViewTextBoxColumn OrderDetailID;
        private DataGridViewTextBoxColumn MaterialID;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn TotalPrice;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}