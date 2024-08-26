namespace QuanLyVLXD.UserControls {
    partial class UC_Materials {
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
            materialBindingSource = new BindingSource(components);
            lbMaterial = new Label();
            tbMaterialName = new TextBox();
            tbQuantity = new TextBox();
            lbQuantity = new Label();
            tbUnit = new TextBox();
            lbUnit = new Label();
            tbPrice = new TextBox();
            lbPrice = new Label();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            dataGVMaterials = new DataGridView();
            materialIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            materialNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btnClear = new Guna.UI2.WinForms.Guna2Button();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            tbSearch = new TextBox();
            cbCriterial = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGVMaterials).BeginInit();
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
            lbMaterial.Location = new Point(49, 34);
            lbMaterial.Name = "lbMaterial";
            lbMaterial.Size = new Size(111, 25);
            lbMaterial.TabIndex = 1;
            lbMaterial.Text = "Tên vật liệu:";
            lbMaterial.Click += label1_Click;
            // 
            // tbMaterialName
            // 
            tbMaterialName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbMaterialName.Location = new Point(166, 28);
            tbMaterialName.Name = "tbMaterialName";
            tbMaterialName.Size = new Size(301, 33);
            tbMaterialName.TabIndex = 1;
            tbMaterialName.TextChanged += textBox1_TextChanged;
            // 
            // tbQuantity
            // 
            tbQuantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbQuantity.Location = new Point(570, 26);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(153, 33);
            tbQuantity.TabIndex = 2;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbQuantity.Location = new Point(473, 34);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(91, 25);
            lbQuantity.TabIndex = 3;
            lbQuantity.Text = "Số lượng:";
            // 
            // tbUnit
            // 
            tbUnit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUnit.Location = new Point(125, 71);
            tbUnit.Name = "tbUnit";
            tbUnit.Size = new Size(196, 33);
            tbUnit.TabIndex = 4;
            tbUnit.TextChanged += textBox1_TextChanged_1;
            // 
            // lbUnit
            // 
            lbUnit.AutoSize = true;
            lbUnit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUnit.Location = new Point(49, 77);
            lbUnit.Name = "lbUnit";
            lbUnit.Size = new Size(70, 25);
            lbUnit.TabIndex = 5;
            lbUnit.Text = "Đơn vị:";
            // 
            // tbPrice
            // 
            tbPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPrice.Location = new Point(387, 74);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(336, 33);
            tbPrice.TabIndex = 6;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPrice.Location = new Point(337, 80);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(44, 25);
            lbPrice.TabIndex = 7;
            lbPrice.Text = "Giá:";
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 5;
            btnAdd.CustomizableEdges = customizableEdges1;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(744, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAdd.Size = new Size(153, 35);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
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
            btnDelete.Location = new Point(744, 117);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDelete.Size = new Size(153, 35);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BorderRadius = 5;
            btnEdit.CustomizableEdges = customizableEdges5;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(744, 71);
            btnEdit.Name = "btnEdit";
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnEdit.Size = new Size(153, 35);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Sửa";
            btnEdit.Click += guna2Button3_Click;
            // 
            // dataGVMaterials
            // 
            dataGVMaterials.AutoGenerateColumns = false;
            dataGVMaterials.BorderStyle = BorderStyle.None;
            dataGVMaterials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVMaterials.Columns.AddRange(new DataGridViewColumn[] { materialIDDataGridViewTextBoxColumn, materialNameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, createdAtDataGridViewTextBoxColumn, updatedAtDataGridViewTextBoxColumn });
            dataGVMaterials.DataSource = materialBindingSource;
            dataGVMaterials.Location = new Point(3, 178);
            dataGVMaterials.MultiSelect = false;
            dataGVMaterials.Name = "dataGVMaterials";
            dataGVMaterials.ReadOnly = true;
            dataGVMaterials.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGVMaterials.Size = new Size(929, 427);
            dataGVMaterials.TabIndex = 11;
            dataGVMaterials.CellContentClick += dataGVMaterials_CellContentClick;
            // 
            // materialIDDataGridViewTextBoxColumn
            // 
            materialIDDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            materialIDDataGridViewTextBoxColumn.FillWeight = 70F;
            materialIDDataGridViewTextBoxColumn.HeaderText = "Mã vật liệu";
            materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            materialIDDataGridViewTextBoxColumn.ReadOnly = true;
            materialIDDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            materialIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // materialNameDataGridViewTextBoxColumn
            // 
            materialNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            materialNameDataGridViewTextBoxColumn.DataPropertyName = "MaterialName";
            materialNameDataGridViewTextBoxColumn.FillWeight = 200F;
            materialNameDataGridViewTextBoxColumn.HeaderText = "Tên vật liệu";
            materialNameDataGridViewTextBoxColumn.Name = "materialNameDataGridViewTextBoxColumn";
            materialNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.FillWeight = 60F;
            quantityDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Width = 73;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            unitDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn.HeaderText = "Đơn vị";
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            unitDataGridViewTextBoxColumn.ReadOnly = true;
            unitDataGridViewTextBoxColumn.Width = 61;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Giá thành";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 77;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            createdAtDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            createdAtDataGridViewTextBoxColumn.HeaderText = "Ngày tạo";
            createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            createdAtDataGridViewTextBoxColumn.Width = 74;
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            updatedAtDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            updatedAtDataGridViewTextBoxColumn.DataPropertyName = "UpdatedAt";
            updatedAtDataGridViewTextBoxColumn.HeaderText = "Ngày cập nhật";
            updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            updatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            updatedAtDataGridViewTextBoxColumn.Width = 79;
            // 
            // btnClear
            // 
            btnClear.BorderRadius = 5;
            btnClear.CustomizableEdges = customizableEdges7;
            btnClear.DisabledState.BorderColor = Color.DarkGray;
            btnClear.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClear.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClear.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(570, 117);
            btnClear.Name = "btnClear";
            btnClear.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnClear.Size = new Size(153, 35);
            btnClear.TabIndex = 12;
            btnClear.Text = "Làm mới";
            btnClear.Click += guna2Button1_Click_1;
            // 
            // btnSearch
            // 
            btnSearch.BorderRadius = 5;
            btnSearch.CustomizableEdges = customizableEdges9;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(396, 117);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges10;
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
            cbCriterial.Items.AddRange(new object[] { "Mã vật liệu", "Tên vật liệu", "Đơn vị" });
            cbCriterial.Location = new Point(251, 119);
            cbCriterial.Name = "cbCriterial";
            cbCriterial.Size = new Size(130, 33);
            cbCriterial.TabIndex = 15;
            // 
            // UC_Materials
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbCriterial);
            Controls.Add(tbSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(dataGVMaterials);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(tbPrice);
            Controls.Add(lbPrice);
            Controls.Add(tbUnit);
            Controls.Add(lbUnit);
            Controls.Add(tbQuantity);
            Controls.Add(lbQuantity);
            Controls.Add(tbMaterialName);
            Controls.Add(lbMaterial);
            Name = "UC_Materials";
            Size = new Size(935, 639);
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGVMaterials).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource materialBindingSource;
        private Label lbMaterial;
        private TextBox tbMaterialName;
        private TextBox tbQuantity;
        private Label lbQuantity;
        private TextBox tbUnit;
        private Label lbUnit;
        private TextBox tbPrice;
        private Label lbPrice;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private DataGridView dataGVMaterials;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private TextBox tbSearch;
        private ComboBox cbCriterial;
        private DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
    }
}
