namespace QuanLyVLXD.UserControls {
    partial class UC_Customer {
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
            customerBindingSource = new BindingSource(components);
            lbCustomer = new Label();
            tbCustomerName = new TextBox();
            tbPhoneNumber = new TextBox();
            lbQuantity = new Label();
            tbEmail = new TextBox();
            lbUnit = new Label();
            tbAddress = new TextBox();
            lbPrice = new Label();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            dataGVCustomers = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            btnClear = new Guna.UI2.WinForms.Guna2Button();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            tbSearch = new TextBox();
            cbCriterial = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGVCustomers).BeginInit();
            SuspendLayout();
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Customer);
            // 
            // lbCustomer
            // 
            lbCustomer.AutoSize = true;
            lbCustomer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCustomer.Location = new Point(49, 34);
            lbCustomer.Name = "lbCustomer";
            lbCustomer.Size = new Size(148, 25);
            lbCustomer.TabIndex = 1;
            lbCustomer.Text = "Tên khách hàng:";
            // 
            // tbCustomerName
            // 
            tbCustomerName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCustomerName.Location = new Point(203, 28);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(222, 33);
            tbCustomerName.TabIndex = 1;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPhoneNumber.Location = new Point(557, 28);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(166, 33);
            tbPhoneNumber.TabIndex = 2;
            tbPhoneNumber.TextChanged += tbQuantity_TextChanged;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbQuantity.Location = new Point(431, 34);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(127, 25);
            lbQuantity.TabIndex = 3;
            lbQuantity.Text = "Số điện thoại:";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(117, 74);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(204, 33);
            tbEmail.TabIndex = 4;
            // 
            // lbUnit
            // 
            lbUnit.AutoSize = true;
            lbUnit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUnit.Location = new Point(49, 77);
            lbUnit.Name = "lbUnit";
            lbUnit.Size = new Size(62, 25);
            lbUnit.TabIndex = 5;
            lbUnit.Text = "Email:";
            // 
            // tbAddress
            // 
            tbAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAddress.Location = new Point(417, 74);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(306, 33);
            tbAddress.TabIndex = 6;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPrice.Location = new Point(337, 80);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(74, 25);
            lbPrice.TabIndex = 7;
            lbPrice.Text = "Địa chỉ:";
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
            // dataGVCustomers
            // 
            dataGVCustomers.AutoGenerateColumns = false;
            dataGVCustomers.BorderStyle = BorderStyle.None;
            dataGVCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVCustomers.Columns.AddRange(new DataGridViewColumn[] { CustomerID, CustomerName, Phone, Address, Email });
            dataGVCustomers.DataSource = customerBindingSource;
            dataGVCustomers.Location = new Point(3, 178);
            dataGVCustomers.MultiSelect = false;
            dataGVCustomers.Name = "dataGVCustomers";
            dataGVCustomers.ReadOnly = true;
            dataGVCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGVCustomers.Size = new Size(929, 427);
            dataGVCustomers.TabIndex = 11;
            dataGVCustomers.CellContentClick += dataGVCustomers_CellContentClick;
            // 
            // CustomerID
            // 
            CustomerID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.FillWeight = 70F;
            CustomerID.HeaderText = "Mã khách hàng";
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            CustomerID.Resizable = DataGridViewTriState.False;
            CustomerID.Width = 105;
            // 
            // CustomerName
            // 
            CustomerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CustomerName.DataPropertyName = "CustomerName";
            CustomerName.FillWeight = 200F;
            CustomerName.HeaderText = "Tên khách hàng";
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            CustomerName.Width = 106;
            // 
            // Phone
            // 
            Phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Số điện thoại";
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            Phone.Width = 93;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Địa chỉ";
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 61;
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
            cbCriterial.Items.AddRange(new object[] { "Mã khách hàng", "Tên khách hàng", "Email" });
            cbCriterial.Location = new Point(251, 119);
            cbCriterial.Name = "cbCriterial";
            cbCriterial.Size = new Size(130, 33);
            cbCriterial.TabIndex = 15;
            // 
            // UC_Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbCriterial);
            Controls.Add(tbSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(dataGVCustomers);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(tbAddress);
            Controls.Add(lbPrice);
            Controls.Add(tbEmail);
            Controls.Add(lbUnit);
            Controls.Add(tbPhoneNumber);
            Controls.Add(lbQuantity);
            Controls.Add(tbCustomerName);
            Controls.Add(lbCustomer);
            Name = "UC_Customer";
            Size = new Size(935, 639);
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGVCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource customerBindingSource;
        private Label lbCustomer;
        private TextBox tbCustomerName;
        private TextBox tbPhoneNumber;
        private Label lbQuantity;
        private TextBox tbEmail;
        private Label lbUnit;
        private TextBox tbAddress;
        private Label lbPrice;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private DataGridView dataGVCustomers;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private TextBox tbSearch;
        private ComboBox cbCriterial;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Email;
    }
}
