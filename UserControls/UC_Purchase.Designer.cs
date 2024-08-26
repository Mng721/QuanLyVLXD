namespace QuanLyVLXD.UserControls {
    partial class UC_Purchase {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            materialBindingSource = new BindingSource(components);
            lbMaterial = new Label();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            dataGVPurchases = new DataGridView();
            PurchaseID = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            PurchaseDate = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            orderBindingSource = new BindingSource(components);
            btnClear = new Guna.UI2.WinForms.Guna2Button();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            tbSearch = new TextBox();
            cbCriterial = new ComboBox();
            btnPurchaseDetail = new Guna.UI2.WinForms.Guna2Button();
            cbSupplier = new ComboBox();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            btnComplete = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGVPurchases).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // materialBindingSource
            // 
            materialBindingSource.DataSource = typeof(Material);
            // 
            // lbMaterial
            // 
            lbMaterial.AutoSize = true;
            lbMaterial.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMaterial.Location = new Point(49, 31);
            lbMaterial.Name = "lbMaterial";
            lbMaterial.Size = new Size(164, 25);
            lbMaterial.TabIndex = 1;
            lbMaterial.Text = "Tên nhà cung cấp:";
            lbMaterial.Click += label1_Click;
            // 
            // btnDelete
            // 
            btnDelete.BorderRadius = 5;
            btnDelete.CustomizableEdges = customizableEdges1;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.Enabled = false;
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(744, 71);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDelete.Size = new Size(153, 35);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BorderRadius = 5;
            btnEdit.CustomizableEdges = customizableEdges3;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.Enabled = false;
            btnEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(570, 71);
            btnEdit.Name = "btnEdit";
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEdit.Size = new Size(153, 35);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // dataGVPurchases
            // 
            dataGVPurchases.AutoGenerateColumns = false;
            dataGVPurchases.BorderStyle = BorderStyle.None;
            dataGVPurchases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVPurchases.Columns.AddRange(new DataGridViewColumn[] { PurchaseID, SupplierName, PurchaseDate, TotalAmount, Status });
            dataGVPurchases.DataSource = orderBindingSource;
            dataGVPurchases.Location = new Point(3, 178);
            dataGVPurchases.MultiSelect = false;
            dataGVPurchases.Name = "dataGVPurchases";
            dataGVPurchases.ReadOnly = true;
            dataGVPurchases.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGVPurchases.Size = new Size(929, 427);
            dataGVPurchases.TabIndex = 11;
            dataGVPurchases.CellContentClick += dataGVMaterials_CellContentClick;
            // 
            // PurchaseID
            // 
            PurchaseID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            PurchaseID.DataPropertyName = "PurchaseID";
            PurchaseID.HeaderText = "PurchaseID";
            PurchaseID.Name = "PurchaseID";
            PurchaseID.ReadOnly = true;
            PurchaseID.Width = 91;
            // 
            // SupplierName
            // 
            SupplierName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SupplierName.DataPropertyName = "SupplierName";
            SupplierName.HeaderText = "Tên nhà cung cấp";
            SupplierName.Name = "SupplierName";
            SupplierName.ReadOnly = true;
            // 
            // PurchaseDate
            // 
            PurchaseDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            PurchaseDate.DataPropertyName = "PurchaseDate";
            PurchaseDate.HeaderText = "Ngày nhập";
            PurchaseDate.Name = "PurchaseDate";
            PurchaseDate.ReadOnly = true;
            PurchaseDate.Width = 90;
            // 
            // TotalAmount
            // 
            TotalAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TotalAmount.DataPropertyName = "TotalAmount";
            TotalAmount.HeaderText = "Tổng tiền";
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            TotalAmount.Width = 82;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Trạng thái";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 84;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Purchase);
            // 
            // btnClear
            // 
            btnClear.BorderRadius = 5;
            btnClear.CustomizableEdges = customizableEdges5;
            btnClear.DisabledState.BorderColor = Color.DarkGray;
            btnClear.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClear.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClear.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(744, 119);
            btnClear.Name = "btnClear";
            btnClear.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnClear.Size = new Size(153, 35);
            btnClear.TabIndex = 12;
            btnClear.Text = "Làm mới";
            btnClear.Click += guna2Button1_Click_1;
            // 
            // btnSearch
            // 
            btnSearch.BorderRadius = 5;
            btnSearch.CustomizableEdges = customizableEdges7;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(396, 119);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSearch.Size = new Size(153, 35);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(49, 119);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(196, 33);
            tbSearch.TabIndex = 14;
            // 
            // cbCriterial
            // 
            cbCriterial.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCriterial.FormattingEnabled = true;
            cbCriterial.Items.AddRange(new object[] { "PurchaseID", "Tên nhà cung cấp" });
            cbCriterial.Location = new Point(251, 119);
            cbCriterial.Name = "cbCriterial";
            cbCriterial.Size = new Size(130, 33);
            cbCriterial.TabIndex = 15;
            // 
            // btnPurchaseDetail
            // 
            btnPurchaseDetail.BorderRadius = 5;
            btnPurchaseDetail.CustomizableEdges = customizableEdges9;
            btnPurchaseDetail.DisabledState.BorderColor = Color.DarkGray;
            btnPurchaseDetail.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPurchaseDetail.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPurchaseDetail.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPurchaseDetail.Enabled = false;
            btnPurchaseDetail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPurchaseDetail.ForeColor = Color.White;
            btnPurchaseDetail.Location = new Point(570, 119);
            btnPurchaseDetail.Name = "btnPurchaseDetail";
            btnPurchaseDetail.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnPurchaseDetail.Size = new Size(153, 35);
            btnPurchaseDetail.TabIndex = 16;
            btnPurchaseDetail.Text = "Chi tiết";
            btnPurchaseDetail.Click += btnPurchaseDetail_Click;
            // 
            // cbSupplier
            // 
            cbSupplier.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Items.AddRange(new object[] { "Pending", "Completed" });
            cbSupplier.Location = new Point(219, 27);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(330, 33);
            cbSupplier.TabIndex = 18;
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 5;
            btnAdd.CustomizableEdges = customizableEdges11;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(396, 71);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnAdd.Size = new Size(153, 35);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnComplete
            // 
            btnComplete.BorderRadius = 5;
            btnComplete.CustomizableEdges = customizableEdges13;
            btnComplete.DisabledState.BorderColor = Color.DarkGray;
            btnComplete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnComplete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnComplete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnComplete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComplete.ForeColor = Color.White;
            btnComplete.Location = new Point(570, 27);
            btnComplete.Name = "btnComplete";
            btnComplete.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnComplete.Size = new Size(327, 35);
            btnComplete.TabIndex = 19;
            btnComplete.Text = "Xác nhận hoàn thành đơn";
            btnComplete.Click += btnComplete_Click;
            // 
            // UC_Purchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnComplete);
            Controls.Add(cbSupplier);
            Controls.Add(btnPurchaseDetail);
            Controls.Add(cbCriterial);
            Controls.Add(tbSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(dataGVPurchases);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lbMaterial);
            Name = "UC_Purchase";
            Size = new Size(935, 639);
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGVPurchases).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource materialBindingSource;
        private Label lbMaterial;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private DataGridView dataGVPurchases;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private TextBox tbSearch;
        private ComboBox cbCriterial;
        private DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private BindingSource orderBindingSource;
        private Guna.UI2.WinForms.Guna2Button btnPurchaseDetail;
        private ComboBox cbSupplier;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private DataGridViewTextBoxColumn PurchaseID;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn PurchaseDate;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn Status;
        private Guna.UI2.WinForms.Guna2Button btnComplete;
    }
}
