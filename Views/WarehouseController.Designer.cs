namespace StockPulse
{
    partial class WarehouseController
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
            CreateUpdateWarehouseButton = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            WarehouseNameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            WarehouseAddressTextbox = new TextBox();
            ChooseManagerCombobox = new ComboBox();
            groupBox2 = new GroupBox();
            CreateManagerButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label6 = new Label();
            ManagerNameTextbox = new TextBox();
            WarehouseTableView = new DataGridView();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WarehouseTableView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CreateUpdateWarehouseButton
            // 
            CreateUpdateWarehouseButton.Dock = DockStyle.Bottom;
            CreateUpdateWarehouseButton.Enabled = false;
            CreateUpdateWarehouseButton.Location = new Point(3, 162);
            CreateUpdateWarehouseButton.Name = "CreateUpdateWarehouseButton";
            CreateUpdateWarehouseButton.Size = new Size(550, 34);
            CreateUpdateWarehouseButton.TabIndex = 0;
            CreateUpdateWarehouseButton.Text = "Create Warehouse";
            CreateUpdateWarehouseButton.UseVisualStyleBackColor = true;
            CreateUpdateWarehouseButton.Click += CreateWarehouseButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(CreateUpdateWarehouseButton);
            groupBox1.Location = new Point(3, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 199);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create a New Warehouse";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(WarehouseNameTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(WarehouseAddressTextbox, 1, 0);
            tableLayoutPanel1.Controls.Add(ChooseManagerCombobox, 1, 2);
            tableLayoutPanel1.Location = new Point(3, 27);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(550, 127);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(4, 89);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 4;
            label3.Text = "Warehouse Manager";
            // 
            // WarehouseNameTextBox
            // 
            WarehouseNameTextBox.Anchor = AnchorStyles.Left;
            WarehouseNameTextBox.Location = new Point(186, 42);
            WarehouseNameTextBox.Name = "WarehouseNameTextBox";
            WarehouseNameTextBox.Size = new Size(360, 31);
            WarehouseNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(4, 45);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 2;
            label2.Text = "Warehouse Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(4, 7);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 1;
            label1.Text = "Warehouse Address";
            // 
            // WarehouseAddressTextbox
            // 
            WarehouseAddressTextbox.Anchor = AnchorStyles.Left;
            WarehouseAddressTextbox.Location = new Point(186, 4);
            WarehouseAddressTextbox.Name = "WarehouseAddressTextbox";
            WarehouseAddressTextbox.Size = new Size(360, 31);
            WarehouseAddressTextbox.TabIndex = 0;
            // 
            // ChooseManagerCombobox
            // 
            ChooseManagerCombobox.Anchor = AnchorStyles.Left;
            ChooseManagerCombobox.FormattingEnabled = true;
            ChooseManagerCombobox.Items.AddRange(new object[] { "Choose a Manager" });
            ChooseManagerCombobox.Location = new Point(186, 85);
            ChooseManagerCombobox.Name = "ChooseManagerCombobox";
            ChooseManagerCombobox.Size = new Size(360, 33);
            ChooseManagerCombobox.TabIndex = 5;
            ChooseManagerCombobox.SelectedIndexChanged += ChooseManagerCombobox_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CreateManagerButton);
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Location = new Point(565, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(740, 121);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Create a New Manager";
            // 
            // CreateManagerButton
            // 
            CreateManagerButton.Dock = DockStyle.Bottom;
            CreateManagerButton.Location = new Point(3, 84);
            CreateManagerButton.Name = "CreateManagerButton";
            CreateManagerButton.Size = new Size(734, 34);
            CreateManagerButton.TabIndex = 5;
            CreateManagerButton.Text = "Create a New Manager";
            CreateManagerButton.UseVisualStyleBackColor = true;
            CreateManagerButton.Click += CreateManagerButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(label6, 0, 0);
            tableLayoutPanel2.Controls.Add(ManagerNameTextbox, 1, 0);
            tableLayoutPanel2.Location = new Point(16, 33);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(718, 43);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(4, 9);
            label6.Name = "label6";
            label6.Size = new Size(134, 25);
            label6.TabIndex = 1;
            label6.Text = "Manager Name";
            // 
            // ManagerNameTextbox
            // 
            ManagerNameTextbox.Anchor = AnchorStyles.Left;
            ManagerNameTextbox.Location = new Point(145, 6);
            ManagerNameTextbox.Name = "ManagerNameTextbox";
            ManagerNameTextbox.Size = new Size(561, 31);
            ManagerNameTextbox.TabIndex = 0;
            // 
            // WarehouseTableView
            // 
            WarehouseTableView.AllowUserToAddRows = false;
            WarehouseTableView.AllowUserToDeleteRows = false;
            WarehouseTableView.AllowUserToOrderColumns = true;
            WarehouseTableView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WarehouseTableView.Dock = DockStyle.Bottom;
            WarehouseTableView.Location = new Point(15, 0);
            WarehouseTableView.Name = "WarehouseTableView";
            WarehouseTableView.ReadOnly = true;
            WarehouseTableView.RowHeadersWidth = 62;
            WarehouseTableView.Size = new Size(1278, 654);
            WarehouseTableView.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(WarehouseTableView);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 235);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15, 0, 15, 0);
            panel1.Size = new Size(1308, 654);
            panel1.TabIndex = 6;
            // 
            // WarehouseController
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "WarehouseController";
            Size = new Size(1308, 889);
            Load += WarehouseController_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WarehouseTableView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateUpdateWarehouseButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TextBox WarehouseAddressTextbox;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox WarehouseNameTextBox;
        private Label label3;
        private ComboBox ChooseManagerCombobox;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label6;
        private TextBox ManagerNameTextbox;
        private Button CreateManagerButton;
        private DataGridView WarehouseTableView;
        private Panel panel1;
    }
}
