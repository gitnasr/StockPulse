namespace StockPulse.Views
{
    partial class TransferView
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
            button1 = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            FromItem = new ComboBox();
            FromWarehouse = new ComboBox();
            groupBox2 = new GroupBox();
            ToWarehouse = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(18, 300);
            button1.Name = "button1";
            button1.Size = new Size(387, 95);
            button1.TabIndex = 0;
            button1.Text = "TRANSFER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(FromItem);
            groupBox1.Controls.Add(FromWarehouse);
            groupBox1.Location = new Point(10, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 172);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 89);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 4;
            label2.Text = "Item";
            // 
            // FromItem
            // 
            FromItem.Enabled = false;
            FromItem.FormattingEnabled = true;
            FromItem.Location = new Point(6, 117);
            FromItem.Name = "FromItem";
            FromItem.Size = new Size(381, 33);
            FromItem.TabIndex = 3;
            // 
            // FromWarehouse
            // 
            FromWarehouse.FormattingEnabled = true;
            FromWarehouse.Location = new Point(6, 45);
            FromWarehouse.Name = "FromWarehouse";
            FromWarehouse.Size = new Size(375, 33);
            FromWarehouse.TabIndex = 0;
            FromWarehouse.SelectedValueChanged += FromWarehouse_SelectedValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ToWarehouse);
            groupBox2.Location = new Point(18, 194);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(387, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "To";
            // 
            // ToWarehouse
            // 
            ToWarehouse.Enabled = false;
            ToWarehouse.FormattingEnabled = true;
            ToWarehouse.Location = new Point(6, 45);
            ToWarehouse.Name = "ToWarehouse";
            ToWarehouse.Size = new Size(375, 33);
            ToWarehouse.TabIndex = 1;
            // 
            // TransferView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "TransferView";
            Size = new Size(440, 700);
            Load += TransferView_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private ComboBox FromItem;
        private ComboBox FromWarehouse;
        private GroupBox groupBox2;
        private ComboBox ToWarehouse;
        private Label label2;
    }
}
