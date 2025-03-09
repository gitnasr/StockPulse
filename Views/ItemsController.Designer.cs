namespace StockPulse
{
    partial class ItemsController
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
            RefreshButton = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            ItemQunatityTextBox = new TextBox();
            CreateItemButton = new Button();
            label1 = new Label();
            label2 = new Label();
            ItemNameTextBox = new TextBox();
            label4 = new Label();
            ItemPriceTextBox = new TextBox();
            ItemWarehouse = new ComboBox();
            label6 = new Label();
            UnitsListBox = new CheckedListBox();
            CreateNewUnitButton = new Button();
            label3 = new Label();
            ItemCodeTextBox = new TextBox();
            ItemsView = new DataGridView();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsView).BeginInit();
            SuspendLayout();
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(879, 79);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(209, 116);
            RefreshButton.TabIndex = 0;
            RefreshButton.Text = "REFRESH";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(3, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1150, 248);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Manage Stock";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.Controls.Add(label5, 2, 1);
            tableLayoutPanel1.Controls.Add(RefreshButton, 5, 2);
            tableLayoutPanel1.Controls.Add(ItemQunatityTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(CreateItemButton, 3, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(ItemNameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(ItemPriceTextBox, 3, 0);
            tableLayoutPanel1.Controls.Add(ItemWarehouse, 3, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(UnitsListBox, 1, 2);
            tableLayoutPanel1.Controls.Add(CreateNewUnitButton, 2, 2);
            tableLayoutPanel1.Controls.Add(label3, 4, 0);
            tableLayoutPanel1.Controls.Add(ItemCodeTextBox, 5, 0);
            tableLayoutPanel1.Location = new Point(19, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1091, 198);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(388, 44);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 9;
            label5.Text = "Warehouse";
            // 
            // ItemQunatityTextBox
            // 
            ItemQunatityTextBox.Anchor = AnchorStyles.Left;
            ItemQunatityTextBox.Location = new Point(109, 41);
            ItemQunatityTextBox.Name = "ItemQunatityTextBox";
            ItemQunatityTextBox.Size = new Size(273, 31);
            ItemQunatityTextBox.TabIndex = 5;
            ItemQunatityTextBox.TextChanged += ItemQunatityTextBox_TextChanged;
            ItemQunatityTextBox.KeyPress += ItemQunatityTextBox_KeyPress;
            // 
            // CreateItemButton
            // 
            tableLayoutPanel1.SetColumnSpan(CreateItemButton, 2);
            CreateItemButton.Location = new Point(527, 79);
            CreateItemButton.Name = "CreateItemButton";
            CreateItemButton.Size = new Size(346, 116);
            CreateItemButton.TabIndex = 13;
            CreateItemButton.Text = "Create Item";
            CreateItemButton.UseVisualStyleBackColor = true;
            CreateItemButton.Click += CreateItemButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 2;
            label1.Text = "Item Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 3;
            label2.Text = "Quantity";
            // 
            // ItemNameTextBox
            // 
            ItemNameTextBox.Anchor = AnchorStyles.Left;
            ItemNameTextBox.Location = new Point(109, 3);
            ItemNameTextBox.Name = "ItemNameTextBox";
            ItemNameTextBox.Size = new Size(273, 31);
            ItemNameTextBox.TabIndex = 4;
            ItemNameTextBox.TextChanged += ItemNameTextBox_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(388, 6);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 8;
            label4.Text = "Price";
            // 
            // ItemPriceTextBox
            // 
            ItemPriceTextBox.Anchor = AnchorStyles.Left;
            ItemPriceTextBox.Location = new Point(527, 3);
            ItemPriceTextBox.Name = "ItemPriceTextBox";
            ItemPriceTextBox.Size = new Size(273, 31);
            ItemPriceTextBox.TabIndex = 9;
            ItemPriceTextBox.KeyPress += ItemPriceTextBox_KeyPress;
            // 
            // ItemWarehouse
            // 
            ItemWarehouse.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(ItemWarehouse, 3);
            ItemWarehouse.FormattingEnabled = true;
            ItemWarehouse.Location = new Point(527, 40);
            ItemWarehouse.Name = "ItemWarehouse";
            ItemWarehouse.Size = new Size(346, 33);
            ItemWarehouse.TabIndex = 12;
            ItemWarehouse.SelectedIndexChanged += ItemWarehouse_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 124);
            label6.Name = "label6";
            label6.Size = new Size(44, 25);
            label6.TabIndex = 10;
            label6.Text = "Unit";
            // 
            // UnitsListBox
            // 
            UnitsListBox.FormattingEnabled = true;
            UnitsListBox.Location = new Point(109, 79);
            UnitsListBox.Name = "UnitsListBox";
            UnitsListBox.Size = new Size(273, 116);
            UnitsListBox.TabIndex = 2;
            // 
            // CreateNewUnitButton
            // 
            CreateNewUnitButton.Location = new Point(388, 79);
            CreateNewUnitButton.Name = "CreateNewUnitButton";
            CreateNewUnitButton.Size = new Size(133, 116);
            CreateNewUnitButton.TabIndex = 1;
            CreateNewUnitButton.Text = "New Unit";
            CreateNewUnitButton.UseVisualStyleBackColor = true;
            CreateNewUnitButton.Click += CreateNewUnitButton_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(810, 6);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 6;
            label3.Text = "Code";
            // 
            // ItemCodeTextBox
            // 
            ItemCodeTextBox.Anchor = AnchorStyles.Left;
            ItemCodeTextBox.Enabled = false;
            ItemCodeTextBox.Location = new Point(879, 3);
            ItemCodeTextBox.Name = "ItemCodeTextBox";
            ItemCodeTextBox.Size = new Size(195, 31);
            ItemCodeTextBox.TabIndex = 7;
            // 
            // ItemsView
            // 
            ItemsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemsView.Location = new Point(25, 273);
            ItemsView.Name = "ItemsView";
            ItemsView.RowHeadersWidth = 62;
            ItemsView.Size = new Size(1128, 598);
            ItemsView.TabIndex = 2;
            // 
            // ItemsController
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ItemsView);
            Controls.Add(groupBox1);
            Name = "ItemsController";
            Size = new Size(1170, 883);
            Load += ItemsController_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button RefreshButton;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox ItemNameTextBox;
        private TextBox ItemQunatityTextBox;
        private TextBox ItemCodeTextBox;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button CreateNewUnitButton;
        private TextBox ItemPriceTextBox;
        private ComboBox ItemWarehouse;
        private CheckedListBox UnitsListBox;
        private Button CreateItemButton;
        private DataGridView ItemsView;
    }
}
