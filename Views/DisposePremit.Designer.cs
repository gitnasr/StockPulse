namespace StockPulse.Views
{
    partial class DisposePremit
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
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            CustomerName = new TextBox();
            CustomerPhone = new TextBox();
            CustomerFax = new TextBox();
            CustomerEmail = new TextBox();
            CustomerWebsite = new TextBox();
            CreateCustomerButton = new Button();
            panel1 = new Panel();
            FetchItemsButton = new Button();
            SupplierComboBox = new ComboBox();
            CreatePremitButton = new Button();
            label7 = new Label();
            label6 = new Label();
            ItemList = new CheckedListBox();
            CustomerComboBox = new ComboBox();
            DisposePremitView = new DataGridView();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DisposePremitView).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(CreateCustomerButton);
            panel2.Location = new Point(13, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(467, 248);
            panel2.TabIndex = 4;
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
            tableLayoutPanel1.Controls.Add(CustomerName, 1, 0);
            tableLayoutPanel1.Controls.Add(CustomerPhone, 1, 1);
            tableLayoutPanel1.Controls.Add(CustomerFax, 1, 4);
            tableLayoutPanel1.Controls.Add(CustomerEmail, 1, 5);
            tableLayoutPanel1.Controls.Add(CustomerWebsite, 1, 6);
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
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
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
            // CustomerName
            // 
            CustomerName.Anchor = AnchorStyles.Left;
            CustomerName.Location = new Point(84, 3);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(214, 31);
            CustomerName.TabIndex = 5;
            // 
            // CustomerPhone
            // 
            CustomerPhone.Anchor = AnchorStyles.Left;
            CustomerPhone.Location = new Point(84, 40);
            CustomerPhone.Name = "CustomerPhone";
            CustomerPhone.Size = new Size(214, 31);
            CustomerPhone.TabIndex = 6;
            // 
            // CustomerFax
            // 
            CustomerFax.Anchor = AnchorStyles.Left;
            CustomerFax.Location = new Point(84, 77);
            CustomerFax.Name = "CustomerFax";
            CustomerFax.Size = new Size(214, 31);
            CustomerFax.TabIndex = 7;
            // 
            // CustomerEmail
            // 
            CustomerEmail.Anchor = AnchorStyles.Left;
            CustomerEmail.Location = new Point(84, 114);
            CustomerEmail.Name = "CustomerEmail";
            CustomerEmail.Size = new Size(214, 31);
            CustomerEmail.TabIndex = 8;
            // 
            // CustomerWebsite
            // 
            CustomerWebsite.Anchor = AnchorStyles.Left;
            CustomerWebsite.Location = new Point(84, 153);
            CustomerWebsite.Name = "CustomerWebsite";
            CustomerWebsite.Size = new Size(214, 31);
            CustomerWebsite.TabIndex = 9;
            // 
            // CreateCustomerButton
            // 
            CreateCustomerButton.Location = new Point(320, 28);
            CreateCustomerButton.Name = "CreateCustomerButton";
            CreateCustomerButton.Size = new Size(111, 193);
            CreateCustomerButton.TabIndex = 0;
            CreateCustomerButton.Text = "Create Customer";
            CreateCustomerButton.UseVisualStyleBackColor = true;
            CreateCustomerButton.Click += CreateCustomerButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(FetchItemsButton);
            panel1.Controls.Add(SupplierComboBox);
            panel1.Controls.Add(CreatePremitButton);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(ItemList);
            panel1.Controls.Add(CustomerComboBox);
            panel1.Location = new Point(506, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(768, 248);
            panel1.TabIndex = 5;
            // 
            // FetchItemsButton
            // 
            FetchItemsButton.Location = new Point(640, 201);
            FetchItemsButton.Name = "FetchItemsButton";
            FetchItemsButton.Size = new Size(112, 34);
            FetchItemsButton.TabIndex = 8;
            FetchItemsButton.Text = "Fetch";
            FetchItemsButton.UseVisualStyleBackColor = true;
            FetchItemsButton.Click += FetchItemsButton_Click;
            // 
            // SupplierComboBox
            // 
            SupplierComboBox.FormattingEnabled = true;
            SupplierComboBox.Location = new Point(21, 103);
            SupplierComboBox.Name = "SupplierComboBox";
            SupplierComboBox.Size = new Size(615, 33);
            SupplierComboBox.TabIndex = 7;
            // 
            // CreatePremitButton
            // 
            CreatePremitButton.Location = new Point(640, 40);
            CreatePremitButton.Name = "CreatePremitButton";
            CreatePremitButton.Size = new Size(112, 155);
            CreatePremitButton.TabIndex = 5;
            CreatePremitButton.Text = "Premit";
            CreatePremitButton.UseVisualStyleBackColor = true;
            CreatePremitButton.Click += CreatePremitButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 76);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 6;
            label7.Text = "Supplier";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 12);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 4;
            label6.Text = "Customer";
            // 
            // ItemList
            // 
            ItemList.FormattingEnabled = true;
            ItemList.Location = new Point(19, 147);
            ItemList.Name = "ItemList";
            ItemList.Size = new Size(615, 88);
            ItemList.TabIndex = 3;
            ItemList.MouseHover += ItemList_MouseHover;
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(19, 40);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(615, 33);
            CustomerComboBox.TabIndex = 0;
            // 
            // DisposePremitView
            // 
            DisposePremitView.AllowUserToAddRows = false;
            DisposePremitView.AllowUserToDeleteRows = false;
            DisposePremitView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DisposePremitView.Location = new Point(13, 274);
            DisposePremitView.Name = "DisposePremitView";
            DisposePremitView.ReadOnly = true;
            DisposePremitView.RowHeadersWidth = 62;
            DisposePremitView.Size = new Size(1261, 656);
            DisposePremitView.TabIndex = 6;
            // 
            // DisposePremit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DisposePremitView);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "DisposePremit";
            Size = new Size(1305, 962);
            Load += DisposePremit_Load;
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DisposePremitView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox CustomerName;
        private TextBox CustomerPhone;
        private TextBox CustomerFax;
        private TextBox CustomerEmail;
        private TextBox CustomerWebsite;
        private Button CreateCustomerButton;
        private Panel panel1;
        private Button CreatePremitButton;
        private Label label6;
        private CheckedListBox ItemList;
        private ComboBox CustomerComboBox;
        private ComboBox SupplierComboBox;
        private Label label7;
        private Button FetchItemsButton;
        private DataGridView DisposePremitView;
    }
}
