
namespace ims
{
    partial class HomeScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.salesBtn = new System.Windows.Forms.Button();
            this.purchaseInvoiceBtn = new System.Windows.Forms.Button();
            this.stockBtn = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.userBtn = new System.Windows.Forms.Button();
            this.catBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(250, 726);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Size = new System.Drawing.Size(954, 726);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(954, 40);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.salesBtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.purchaseInvoiceBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.stockBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.productsBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.userBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.catBtn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(954, 686);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // salesBtn
            // 
            this.salesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salesBtn.FlatAppearance.BorderSize = 2;
            this.salesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesBtn.Location = new System.Drawing.Point(763, 3);
            this.salesBtn.Name = "salesBtn";
            this.salesBtn.Size = new System.Drawing.Size(188, 131);
            this.salesBtn.TabIndex = 4;
            this.salesBtn.Text = "Sales";
            this.salesBtn.UseVisualStyleBackColor = true;
            // 
            // purchaseInvoiceBtn
            // 
            this.purchaseInvoiceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseInvoiceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseInvoiceBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchaseInvoiceBtn.FlatAppearance.BorderSize = 2;
            this.purchaseInvoiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseInvoiceBtn.Location = new System.Drawing.Point(573, 3);
            this.purchaseInvoiceBtn.Name = "purchaseInvoiceBtn";
            this.purchaseInvoiceBtn.Size = new System.Drawing.Size(184, 131);
            this.purchaseInvoiceBtn.TabIndex = 3;
            this.purchaseInvoiceBtn.Text = "Purchase Invoice";
            this.purchaseInvoiceBtn.UseVisualStyleBackColor = true;
            // 
            // stockBtn
            // 
            this.stockBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stockBtn.FlatAppearance.BorderSize = 2;
            this.stockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockBtn.Location = new System.Drawing.Point(383, 3);
            this.stockBtn.Name = "stockBtn";
            this.stockBtn.Size = new System.Drawing.Size(184, 131);
            this.stockBtn.TabIndex = 2;
            this.stockBtn.Text = "Stock";
            this.stockBtn.UseVisualStyleBackColor = true;
            // 
            // productsBtn
            // 
            this.productsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productsBtn.FlatAppearance.BorderSize = 2;
            this.productsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsBtn.Location = new System.Drawing.Point(193, 3);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(184, 131);
            this.productsBtn.TabIndex = 1;
            this.productsBtn.Text = "Products";
            this.productsBtn.UseVisualStyleBackColor = true;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // userBtn
            // 
            this.userBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userBtn.FlatAppearance.BorderSize = 2;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Location = new System.Drawing.Point(3, 3);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(184, 131);
            this.userBtn.TabIndex = 0;
            this.userBtn.Text = "Users";
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // catBtn
            // 
            this.catBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.catBtn.FlatAppearance.BorderSize = 2;
            this.catBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catBtn.Location = new System.Drawing.Point(3, 140);
            this.catBtn.Name = "catBtn";
            this.catBtn.Size = new System.Drawing.Size(184, 131);
            this.catBtn.TabIndex = 5;
            this.catBtn.Text = "Categories";
            this.catBtn.UseVisualStyleBackColor = true;
            this.catBtn.Click += new System.EventHandler(this.catBtn_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 726);
            this.Name = "HomeScreen";
            this.Text = "Home Screen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button salesBtn;
        private System.Windows.Forms.Button purchaseInvoiceBtn;
        private System.Windows.Forms.Button stockBtn;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button catBtn;
    }
}