using System.Data.SqlClient;

namespace QuanLyVLXD
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        SqlConnection conn = new SqlConnection("data source=MSI\\SQLEXPRESS;initial catalog=master;trusted_connection=true");

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lbUserName = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            btnMuonSach = new Guna.UI2.WinForms.Guna2Button();
            panelContainer = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelContainer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lbUserName);
            panel1.Controls.Add(guna2Button1);
            panel1.Controls.Add(btnCustomer);
            panel1.Controls.Add(guna2Button7);
            panel1.Controls.Add(guna2Button6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(guna2Button5);
            panel1.Controls.Add(btnMuonSach);
            panel1.Location = new Point(-23, -25);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 693);
            panel1.TabIndex = 0;
            // 
            // lbUserName
            // 
            lbUserName.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbUserName.ForeColor = Color.Red;
            lbUserName.Location = new Point(23, 155);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(220, 44);
            lbUserName.TabIndex = 12;
            lbUserName.Text = "Quản lý Vật liệu XD";
            lbUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Button1
            // 
            guna2Button1.CheckedState.BorderColor = Color.LightSteelBlue;
            guna2Button1.CheckedState.FillColor = Color.LightSteelBlue;
            guna2Button1.CheckedState.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = SystemColors.ActiveCaption;
            guna2Button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.HoverState.FillColor = Color.FromArgb(0, 192, 192);
            guna2Button1.Location = new Point(23, 466);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(223, 60);
            guna2Button1.TabIndex = 11;
            guna2Button1.Text = "Nhà cung cấp";
            guna2Button1.Click += guna2Button1_Click_1;
            // 
            // btnCustomer
            // 
            btnCustomer.CheckedState.BorderColor = Color.LightSteelBlue;
            btnCustomer.CheckedState.FillColor = Color.LightSteelBlue;
            btnCustomer.CheckedState.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.CustomizableEdges = customizableEdges3;
            btnCustomer.DisabledState.BorderColor = Color.DarkGray;
            btnCustomer.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCustomer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCustomer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCustomer.FillColor = SystemColors.ActiveCaption;
            btnCustomer.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomer.ForeColor = Color.Black;
            btnCustomer.HoverState.FillColor = Color.FromArgb(0, 192, 192);
            btnCustomer.Location = new Point(20, 400);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCustomer.Size = new Size(223, 60);
            btnCustomer.TabIndex = 10;
            btnCustomer.Text = "Khách hàng";
            btnCustomer.Click += btnCustomer_Click;
            // 
            // guna2Button7
            // 
            guna2Button7.CheckedState.BorderColor = Color.LightSteelBlue;
            guna2Button7.CheckedState.FillColor = Color.LightSteelBlue;
            guna2Button7.CheckedState.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button7.CustomizableEdges = customizableEdges5;
            guna2Button7.DisabledState.BorderColor = Color.DarkGray;
            guna2Button7.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button7.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button7.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button7.FillColor = SystemColors.ActiveCaption;
            guna2Button7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button7.ForeColor = Color.Black;
            guna2Button7.HoverState.FillColor = Color.FromArgb(0, 192, 192);
            guna2Button7.Location = new Point(20, 334);
            guna2Button7.Name = "guna2Button7";
            guna2Button7.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button7.Size = new Size(223, 60);
            guna2Button7.TabIndex = 9;
            guna2Button7.Text = "Đơn mua";
            guna2Button7.Click += guna2Button7_Click;
            // 
            // guna2Button6
            // 
            guna2Button6.CheckedState.BorderColor = Color.LightSteelBlue;
            guna2Button6.CheckedState.FillColor = Color.LightSteelBlue;
            guna2Button6.CheckedState.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button6.CustomizableEdges = customizableEdges7;
            guna2Button6.DisabledState.BorderColor = Color.DarkGray;
            guna2Button6.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button6.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button6.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button6.FillColor = SystemColors.ActiveCaption;
            guna2Button6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button6.ForeColor = Color.Black;
            guna2Button6.HoverState.FillColor = Color.FromArgb(0, 192, 192);
            guna2Button6.Location = new Point(20, 268);
            guna2Button6.Name = "guna2Button6";
            guna2Button6.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button6.Size = new Size(223, 60);
            guna2Button6.TabIndex = 8;
            guna2Button6.Text = "Đơn bán";
            guna2Button6.Click += guna2Button6_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 37);
            label1.Name = "label1";
            label1.Size = new Size(220, 102);
            label1.TabIndex = 7;
            label1.Text = "Quản lý Vật liệu XD";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // guna2Button5
            // 
            guna2Button5.CheckedState.BorderColor = Color.LightSteelBlue;
            guna2Button5.CheckedState.FillColor = Color.LightSteelBlue;
            guna2Button5.CheckedState.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button5.CustomizableEdges = customizableEdges9;
            guna2Button5.DisabledState.BorderColor = Color.DarkGray;
            guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button5.FillColor = SystemColors.ActiveCaption;
            guna2Button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button5.ForeColor = Color.Black;
            guna2Button5.HoverState.FillColor = Color.FromArgb(0, 192, 192);
            guna2Button5.Location = new Point(23, 587);
            guna2Button5.Name = "guna2Button5";
            guna2Button5.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Button5.Size = new Size(223, 45);
            guna2Button5.TabIndex = 6;
            guna2Button5.Text = "Đăng xuất";
            guna2Button5.Click += guna2Button5_Click;
            // 
            // btnMuonSach
            // 
            btnMuonSach.CheckedState.BorderColor = Color.LightSteelBlue;
            btnMuonSach.CheckedState.FillColor = Color.LightSteelBlue;
            btnMuonSach.CheckedState.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMuonSach.CustomizableEdges = customizableEdges11;
            btnMuonSach.DisabledState.BorderColor = Color.DarkGray;
            btnMuonSach.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMuonSach.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMuonSach.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMuonSach.FillColor = SystemColors.ActiveCaption;
            btnMuonSach.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMuonSach.ForeColor = Color.Black;
            btnMuonSach.HoverState.FillColor = Color.FromArgb(0, 192, 192);
            btnMuonSach.Location = new Point(20, 202);
            btnMuonSach.Name = "btnMuonSach";
            btnMuonSach.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnMuonSach.Size = new Size(223, 60);
            btnMuonSach.TabIndex = 2;
            btnMuonSach.Text = "Vật liệu xây dựng";
            btnMuonSach.Click += guna2Button1_Click;
            // 
            // panelContainer
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            panelContainer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            panelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            panelContainer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            panelContainer.ColumnHeadersHeight = 4;
            panelContainer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            panelContainer.DefaultCellStyle = dataGridViewCellStyle3;
            panelContainer.GridColor = Color.FromArgb(231, 229, 255);
            panelContainer.Location = new Point(221, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.RowHeadersVisible = false;
            panelContainer.Size = new Size(935, 639);
            panelContainer.TabIndex = 1;
            panelContainer.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            panelContainer.ThemeStyle.AlternatingRowsStyle.Font = null;
            panelContainer.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            panelContainer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            panelContainer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            panelContainer.ThemeStyle.BackColor = Color.White;
            panelContainer.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            panelContainer.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            panelContainer.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            panelContainer.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            panelContainer.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            panelContainer.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            panelContainer.ThemeStyle.HeaderStyle.Height = 4;
            panelContainer.ThemeStyle.ReadOnly = false;
            panelContainer.ThemeStyle.RowsStyle.BackColor = Color.White;
            panelContainer.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            panelContainer.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            panelContainer.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            panelContainer.ThemeStyle.RowsStyle.Height = 25;
            panelContainer.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            panelContainer.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            panelContainer.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 636);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelContainer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnMuonSach;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2DataGridView panelContainer;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Label lbUserName;
    }
}