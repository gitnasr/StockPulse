﻿namespace StockPulse
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SidePanel = new FlowLayoutPanel();
            WarehouseButton = new Button();
            StockManageButton = new Button();
            SupplyPremitButton = new Button();
            MainPanel = new Panel();
            button1 = new Button();
            SidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // SidePanel
            // 
            SidePanel.AutoSize = true;
            SidePanel.Controls.Add(WarehouseButton);
            SidePanel.Controls.Add(StockManageButton);
            SidePanel.Controls.Add(SupplyPremitButton);
            SidePanel.Controls.Add(button1);
            SidePanel.Dock = DockStyle.Left;
            SidePanel.FlowDirection = FlowDirection.TopDown;
            SidePanel.Location = new Point(0, 0);
            SidePanel.Name = "SidePanel";
            SidePanel.Padding = new Padding(0, 15, 0, 0);
            SidePanel.Size = new Size(226, 569);
            SidePanel.TabIndex = 0;
            // 
            // WarehouseButton
            // 
            WarehouseButton.AutoSize = true;
            WarehouseButton.Location = new Point(3, 18);
            WarehouseButton.Name = "WarehouseButton";
            WarehouseButton.Size = new Size(220, 35);
            WarehouseButton.TabIndex = 0;
            WarehouseButton.Text = "Warehouse Management";
            WarehouseButton.UseVisualStyleBackColor = true;
            WarehouseButton.Click += WarehouseButton_Click;
            // 
            // StockManageButton
            // 
            StockManageButton.AutoSize = true;
            StockManageButton.Dock = DockStyle.Top;
            StockManageButton.Location = new Point(3, 59);
            StockManageButton.Name = "StockManageButton";
            StockManageButton.Size = new Size(220, 35);
            StockManageButton.TabIndex = 1;
            StockManageButton.Text = "Stock Management";
            StockManageButton.UseVisualStyleBackColor = true;
            StockManageButton.Click += button2_Click;
            // 
            // SupplyPremitButton
            // 
            SupplyPremitButton.AutoSize = true;
            SupplyPremitButton.Dock = DockStyle.Top;
            SupplyPremitButton.Location = new Point(3, 100);
            SupplyPremitButton.Name = "SupplyPremitButton";
            SupplyPremitButton.Size = new Size(220, 35);
            SupplyPremitButton.TabIndex = 2;
            SupplyPremitButton.Text = "New Supply Premit";
            SupplyPremitButton.UseVisualStyleBackColor = true;
            SupplyPremitButton.Click += SupplyPremitButton_Click;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(226, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Padding = new Padding(0, 15, 0, 0);
            MainPanel.Size = new Size(774, 569);
            MainPanel.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(3, 141);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1000, 569);
            Controls.Add(MainPanel);
            Controls.Add(SidePanel);
            Name = "Welcome";
            Text = "StockPulse";
            Load += Welcome_Load;
            SidePanel.ResumeLayout(false);
            SidePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel SidePanel;
        private Button WarehouseButton;
        private Button StockManageButton;
        private Panel MainPanel;
        private Button SupplyPremitButton;
        private Button button1;
    }
}
