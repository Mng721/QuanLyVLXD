namespace QuanLyVLXD {
    partial class PurchaseDetailForm {
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dataGVPurchaseDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            PurchaseDetailID = new DataGridViewTextBoxColumn();
            MaterialID = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            orderDetailBindingSource = new BindingSource(components);
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            tbPurchaseDate = new TextBox();
            lbPurchaseDate = new Label();
            cbMaterial = new ComboBox();
            lbMaterialName = new Label();
            tbQuantity = new TextBox();
            label1 = new Label();
            lbSupplierName = new Label();
            tbSupplierName = new TextBox();
            btnExit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dataGVPurchaseDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGVPurchaseDetails
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGVPurchaseDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGVPurchaseDetails.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGVPurchaseDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGVPurchaseDetails.ColumnHeadersHeight = 17;
            dataGVPurchaseDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGVPurchaseDetails.Columns.AddRange(new DataGridViewColumn[] { PurchaseDetailID, MaterialID, Quantity, UnitPrice, TotalPrice });
            dataGVPurchaseDetails.DataSource = orderDetailBindingSource;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGVPurchaseDetails.DefaultCellStyle = dataGridViewCellStyle6;
            dataGVPurchaseDetails.GridColor = Color.FromArgb(231, 229, 255);
            dataGVPurchaseDetails.Location = new Point(12, 144);
            dataGVPurchaseDetails.Name = "dataGVPurchaseDetails";
            dataGVPurchaseDetails.RowHeadersVisible = false;
            dataGVPurchaseDetails.Size = new Size(776, 262);
            dataGVPurchaseDetails.TabIndex = 0;
            dataGVPurchaseDetails.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGVPurchaseDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGVPurchaseDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGVPurchaseDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGVPurchaseDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGVPurchaseDetails.ThemeStyle.BackColor = Color.White;
            dataGVPurchaseDetails.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGVPurchaseDetails.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGVPurchaseDetails.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGVPurchaseDetails.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataGVPurchaseDetails.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGVPurchaseDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGVPurchaseDetails.ThemeStyle.HeaderStyle.Height = 17;
            dataGVPurchaseDetails.ThemeStyle.ReadOnly = false;
            dataGVPurchaseDetails.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGVPurchaseDetails.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGVPurchaseDetails.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGVPurchaseDetails.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGVPurchaseDetails.ThemeStyle.RowsStyle.Height = 25;
            dataGVPurchaseDetails.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGVPurchaseDetails.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // PurchaseDetailID
            // 
            PurchaseDetailID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            PurchaseDetailID.DataPropertyName = "PurchaseDetailID";
            PurchaseDetailID.HeaderText = "PurchaseDetailID";
            PurchaseDetailID.Name = "PurchaseDetailID";
            PurchaseDetailID.Width = 101;
            // 
            // MaterialID
            // 
            MaterialID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaterialID.DataPropertyName = "MaterialName";
            MaterialID.HeaderText = "Tên vật liệu";
            MaterialID.Name = "MaterialID";
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Số lượng";
            Quantity.Name = "Quantity";
            Quantity.Width = 77;
            // 
            // UnitPrice
            // 
            UnitPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            UnitPrice.DataPropertyName = "UnitPrice";
            UnitPrice.HeaderText = "Giá vật liệu";
            UnitPrice.Name = "UnitPrice";
            UnitPrice.Width = 88;
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TotalPrice.DataPropertyName = "TotalPrice";
            TotalPrice.HeaderText = "Tổng";
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Width = 57;
            // 
            // orderDetailBindingSource
            // 
            orderDetailBindingSource.DataSource = typeof(PurchaseDetail);
            // 
            // btnEdit
            // 
            btnEdit.BorderRadius = 5;
            btnEdit.CustomizableEdges = customizableEdges9;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(410, 107);
            btnEdit.Name = "btnEdit";
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnEdit.Size = new Size(122, 31);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BorderRadius = 5;
            btnDelete.CustomizableEdges = customizableEdges11;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(538, 107);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnDelete.Size = new Size(122, 31);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 5;
            btnAdd.CustomizableEdges = customizableEdges13;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(282, 107);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnAdd.Size = new Size(122, 31);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // tbPurchaseDate
            // 
            tbPurchaseDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPurchaseDate.Location = new Point(538, 13);
            tbPurchaseDate.Name = "tbPurchaseDate";
            tbPurchaseDate.ReadOnly = true;
            tbPurchaseDate.Size = new Size(250, 33);
            tbPurchaseDate.TabIndex = 21;
            // 
            // lbPurchaseDate
            // 
            lbPurchaseDate.AutoSize = true;
            lbPurchaseDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPurchaseDate.Location = new Point(438, 16);
            lbPurchaseDate.Name = "lbPurchaseDate";
            lbPurchaseDate.Size = new Size(102, 25);
            lbPurchaseDate.TabIndex = 22;
            lbPurchaseDate.Text = "Ngày mua:";
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
            // lbSupplierName
            // 
            lbSupplierName.AutoSize = true;
            lbSupplierName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSupplierName.Location = new Point(14, 16);
            lbSupplierName.Name = "lbSupplierName";
            lbSupplierName.Size = new Size(148, 25);
            lbSupplierName.TabIndex = 19;
            lbSupplierName.Text = "Tên khách hàng:";
            // 
            // tbSupplierName
            // 
            tbSupplierName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSupplierName.Location = new Point(168, 13);
            tbSupplierName.Name = "tbSupplierName";
            tbSupplierName.ReadOnly = true;
            tbSupplierName.Size = new Size(264, 33);
            tbSupplierName.TabIndex = 23;
            // 
            // btnExit
            // 
            btnExit.BorderRadius = 5;
            btnExit.CustomizableEdges = customizableEdges15;
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(666, 107);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnExit.Size = new Size(122, 31);
            btnExit.TabIndex = 28;
            btnExit.Text = "Thoát";
            btnExit.Click += btnExit_Click;
            // 
            // PurchaseDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 420);
            Controls.Add(btnExit);
            Controls.Add(tbQuantity);
            Controls.Add(label1);
            Controls.Add(cbMaterial);
            Controls.Add(lbMaterialName);
            Controls.Add(tbSupplierName);
            Controls.Add(tbPurchaseDate);
            Controls.Add(lbPurchaseDate);
            Controls.Add(lbSupplierName);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGVPurchaseDetails);
            Name = "PurchaseDetailForm";
            Text = "PurchaseDetailForm";
            ((System.ComponentModel.ISupportInitialize)dataGVPurchaseDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGVPurchaseDetails;
        private BindingSource orderDetailBindingSource;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private TextBox tbPurchaseDate;
        private Label lbPurchaseDate;
        private ComboBox cbMaterial;
        private Label lbMaterialName;
        private TextBox tbQuantity;
        private Label label1;
        private Label lbSupplierName;
        private TextBox tbSupplierName;
        private DataGridViewTextBoxColumn MaterialName;
        private DataGridViewTextBoxColumn PurchaseDetailID;
        private DataGridViewTextBoxColumn MaterialID;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn TotalPrice;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}