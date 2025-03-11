namespace StockPulse.Dialog
{
    partial class CreateUnit
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            UnitNameTextBox = new TextBox();
            CancelUnitButton = new Button();
            CreateUnitButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.4313717F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.56863F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(UnitNameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(CancelUnitButton, 0, 1);
            tableLayoutPanel1.Controls.Add(CreateUnitButton, 1, 1);
            tableLayoutPanel1.Location = new Point(12, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.3333359F));
            tableLayoutPanel1.Size = new Size(408, 150);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "Unit Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UnitNameTextBox
            // 
            UnitNameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UnitNameTextBox.Location = new Point(119, 7);
            UnitNameTextBox.Name = "UnitNameTextBox";
            UnitNameTextBox.Size = new Size(286, 31);
            UnitNameTextBox.TabIndex = 1;
            // 
            // CancelUnitButton
            // 
            CancelUnitButton.Location = new Point(3, 49);
            CancelUnitButton.Name = "CancelUnitButton";
            CancelUnitButton.Size = new Size(110, 98);
            CancelUnitButton.TabIndex = 2;
            CancelUnitButton.Text = "Cancel";
            CancelUnitButton.UseVisualStyleBackColor = true;
            CancelUnitButton.Click += CancelUnitButton_Click;
            // 
            // CreateUnitButton
            // 
            CreateUnitButton.Location = new Point(119, 49);
            CreateUnitButton.Name = "CreateUnitButton";
            CreateUnitButton.Size = new Size(286, 98);
            CreateUnitButton.TabIndex = 3;
            CreateUnitButton.Text = "Create";
            CreateUnitButton.UseVisualStyleBackColor = true;
            CreateUnitButton.Click += CreateUnitButton_Click;
            // 
            // CreateUnit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 172);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CreateUnit";
            Text = "Dialog";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox UnitNameTextBox;
        private Button CancelUnitButton;
        private Button CreateUnitButton;
    }
}