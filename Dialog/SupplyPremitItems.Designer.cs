namespace StockPulse.Dialog
{
    partial class SupplyPremitItems
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
            Cancel = new Button();
            SupplyPremitView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)SupplyPremitView).BeginInit();
            SuspendLayout();
            // 
            // Cancel
            // 
            Cancel.Location = new Point(12, 789);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(729, 53);
            Cancel.TabIndex = 3;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            // 
            // SupplyPremitView
            // 
            SupplyPremitView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SupplyPremitView.Location = new Point(0, 12);
            SupplyPremitView.Name = "SupplyPremitView";
            SupplyPremitView.RowHeadersWidth = 62;
            SupplyPremitView.Size = new Size(741, 771);
            SupplyPremitView.TabIndex = 2;
            // 
            // SupplyPremitItems
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 854);
            Controls.Add(Cancel);
            Controls.Add(SupplyPremitView);
            Name = "SupplyPremitItems";
            Text = "SupplyPremitItems";
            ((System.ComponentModel.ISupportInitialize)SupplyPremitView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Cancel;
        private DataGridView SupplyPremitView;
    }
}