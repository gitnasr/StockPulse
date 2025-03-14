﻿namespace StockPulse.Views
{
    partial class SupplyPremitController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CreateSupplierButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SupplierNameTextBox = new TextBox();
            SupplierPhoneTextBox = new TextBox();
            SupplierFaxTextBox = new TextBox();
            SupplierEmailTextBox = new TextBox();
            SupplierWebsiteTextBox = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            SuppliersView = new DataGridView();
            tabPage2 = new TabPage();
            SupplyPremitView = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            CreatePremitButton = new Button();
            label6 = new Label();
            ItemList = new CheckedListBox();
            ExpiresAtPick = new DateTimePicker();
            ManufacturedAtPicker = new DateTimePicker();
            SupplierComboBox = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SuppliersView).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SupplyPremitView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // CreateSupplierButton
            // 
            CreateSupplierButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CreateSupplierButton.Location = new Point(320, 28);
            CreateSupplierButton.Name = "CreateSupplierButton";
            CreateSupplierButton.Size = new Size(147, 193);
            CreateSupplierButton.TabIndex = 0;
            CreateSupplierButton.Text = "Create Supplier";
            CreateSupplierButton.UseVisualStyleBackColor = true;
            CreateSupplierButton.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 6);
            tableLayoutPanel1.Controls.Add(SupplierNameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(SupplierPhoneTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(SupplierFaxTextBox, 1, 4);
            tableLayoutPanel1.Controls.Add(SupplierEmailTextBox, 1, 5);
            tableLayoutPanel1.Controls.Add(SupplierWebsiteTextBox, 1, 6);
            tableLayoutPanel1.Location = new Point(16, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(298, 189);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Supplier Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 43);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 1;
            label2.Text = "Phone";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 80);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 2;
            label3.Text = "Fax";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 117);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 156);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 4;
            label5.Text = "Website";
            // 
            // SupplierNameTextBox
            // 
            SupplierNameTextBox.Anchor = AnchorStyles.Left;
            SupplierNameTextBox.Location = new Point(138, 3);
            SupplierNameTextBox.Name = "SupplierNameTextBox";
            SupplierNameTextBox.Size = new Size(150, 31);
            SupplierNameTextBox.TabIndex = 5;
            // 
            // SupplierPhoneTextBox
            // 
            SupplierPhoneTextBox.Anchor = AnchorStyles.Left;
            SupplierPhoneTextBox.Location = new Point(138, 40);
            SupplierPhoneTextBox.Name = "SupplierPhoneTextBox";
            SupplierPhoneTextBox.Size = new Size(150, 31);
            SupplierPhoneTextBox.TabIndex = 6;
            // 
            // SupplierFaxTextBox
            // 
            SupplierFaxTextBox.Anchor = AnchorStyles.Left;
            SupplierFaxTextBox.Location = new Point(138, 77);
            SupplierFaxTextBox.Name = "SupplierFaxTextBox";
            SupplierFaxTextBox.Size = new Size(150, 31);
            SupplierFaxTextBox.TabIndex = 7;
            // 
            // SupplierEmailTextBox
            // 
            SupplierEmailTextBox.Anchor = AnchorStyles.Left;
            SupplierEmailTextBox.Location = new Point(138, 114);
            SupplierEmailTextBox.Name = "SupplierEmailTextBox";
            SupplierEmailTextBox.Size = new Size(150, 31);
            SupplierEmailTextBox.TabIndex = 8;
            // 
            // SupplierWebsiteTextBox
            // 
            SupplierWebsiteTextBox.Anchor = AnchorStyles.Left;
            SupplierWebsiteTextBox.Location = new Point(138, 153);
            SupplierWebsiteTextBox.Name = "SupplierWebsiteTextBox";
            SupplierWebsiteTextBox.Size = new Size(150, 31);
            SupplierWebsiteTextBox.TabIndex = 9;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 291);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1275, 816);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(SuppliersView);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1267, 778);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Manager Suppliers";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            tabPage1.Enter += tabPage1_Enter;
            // 
            // SuppliersView
            // 
            SuppliersView.AllowUserToAddRows = false;
            SuppliersView.AllowUserToDeleteRows = false;
            SuppliersView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SuppliersView.Dock = DockStyle.Fill;
            SuppliersView.Location = new Point(3, 3);
            SuppliersView.Name = "SuppliersView";
            SuppliersView.ReadOnly = true;
            SuppliersView.RowHeadersWidth = 62;
            SuppliersView.Size = new Size(1261, 772);
            SuppliersView.TabIndex = 0;
            SuppliersView.CellContentClick += SuppliersView_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(SupplyPremitView);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1267, 778);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Manage Supply Premits";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // SupplyPremitView
            // 
            SupplyPremitView.AllowUserToAddRows = false;
            SupplyPremitView.AllowUserToDeleteRows = false;
            SupplyPremitView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SupplyPremitView.Dock = DockStyle.Fill;
            SupplyPremitView.Location = new Point(3, 3);
            SupplyPremitView.Name = "SupplyPremitView";
            SupplyPremitView.ReadOnly = true;
            SupplyPremitView.RowHeadersWidth = 62;
            SupplyPremitView.Size = new Size(1261, 772);
            SupplyPremitView.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(CreateSupplierButton);
            panel1.Location = new Point(3, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 248);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(CreatePremitButton);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(ItemList);
            panel2.Controls.Add(ExpiresAtPick);
            panel2.Controls.Add(ManufacturedAtPicker);
            panel2.Controls.Add(SupplierComboBox);
            panel2.Location = new Point(492, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(782, 248);
            panel2.TabIndex = 4;
            // 
            // CreatePremitButton
            // 
            CreatePremitButton.Location = new Point(642, 28);
            CreatePremitButton.Name = "CreatePremitButton";
            CreatePremitButton.Size = new Size(122, 207);
            CreatePremitButton.TabIndex = 5;
            CreatePremitButton.Text = "Premit";
            CreatePremitButton.UseVisualStyleBackColor = true;
            CreatePremitButton.Click += CreatePremitButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 12);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 4;
            label6.Text = "Supplier";
            // 
            // ItemList
            // 
            ItemList.FormattingEnabled = true;
            ItemList.Location = new Point(19, 119);
            ItemList.Name = "ItemList";
            ItemList.Size = new Size(615, 116);
            ItemList.TabIndex = 3;
            // 
            // ExpiresAtPick
            // 
            ExpiresAtPick.Location = new Point(325, 79);
            ExpiresAtPick.Name = "ExpiresAtPick";
            ExpiresAtPick.Size = new Size(309, 31);
            ExpiresAtPick.TabIndex = 2;
            // 
            // ManufacturedAtPicker
            // 
            ManufacturedAtPicker.Location = new Point(19, 79);
            ManufacturedAtPicker.Name = "ManufacturedAtPicker";
            ManufacturedAtPicker.Size = new Size(300, 31);
            ManufacturedAtPicker.TabIndex = 1;
            // 
            // SupplierComboBox
            // 
            SupplierComboBox.FormattingEnabled = true;
            SupplierComboBox.Location = new Point(19, 40);
            SupplierComboBox.Name = "SupplierComboBox";
            SupplierComboBox.Size = new Size(615, 33);
            SupplierComboBox.TabIndex = 0;
            // 
            // SupplyPremitController
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Name = "SupplyPremitController";
            Size = new Size(1292, 1110);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SuppliersView).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SupplyPremitView).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button CreateSupplierButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox SupplierNameTextBox;
        private TextBox SupplierPhoneTextBox;
        private TextBox SupplierFaxTextBox;
        private TextBox SupplierEmailTextBox;
        private TextBox SupplierWebsiteTextBox;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private DataGridView SuppliersView;
        private Panel panel2;
        private DateTimePicker ExpiresAtPick;
        private DateTimePicker ManufacturedAtPicker;
        private ComboBox SupplierComboBox;
        private CheckedListBox ItemList;
        private Label label6;
        private Button CreatePremitButton;
        private DataGridView SupplyPremitView;
    }
}
