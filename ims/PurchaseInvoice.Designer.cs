
namespace ims
{
    partial class PurchaseInvoice
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
            this.label2 = new System.Windows.Forms.Label();
            this.supplierDD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productTxt = new System.Windows.Forms.TextBox();
            this.quanTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.barcodeTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pupTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cartBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(3, 21);
            this.searchTxt.Size = new System.Drawing.Size(179, 25);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.cartBtn);
            this.leftPanel.Controls.Add(this.pupTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.barcodeTxt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.quanTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.productTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.supplierDD);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Size = new System.Drawing.Size(250, 813);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.supplierDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.productTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.quanTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.pupTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.cartBtn, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 51);
            // 
            // rightPanel
            // 
            this.rightPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightPanel.Size = new System.Drawing.Size(1141, 813);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1141, 40);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Supplier";
            // 
            // supplierDD
            // 
            this.supplierDD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.supplierDD.FormattingEnabled = true;
            this.supplierDD.Location = new System.Drawing.Point(8, 115);
            this.supplierDD.Name = "supplierDD";
            this.supplierDD.Size = new System.Drawing.Size(217, 23);
            this.supplierDD.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Product";
            // 
            // productTxt
            // 
            this.productTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productTxt.Location = new System.Drawing.Point(8, 205);
            this.productTxt.Name = "productTxt";
            this.productTxt.Size = new System.Drawing.Size(217, 23);
            this.productTxt.TabIndex = 2;
            // 
            // quanTxt
            // 
            this.quanTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quanTxt.Location = new System.Drawing.Point(8, 292);
            this.quanTxt.Name = "quanTxt";
            this.quanTxt.Size = new System.Drawing.Size(217, 23);
            this.quanTxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Quantity";
            // 
            // barcodeTxt
            // 
            this.barcodeTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.barcodeTxt.Location = new System.Drawing.Point(8, 160);
            this.barcodeTxt.Name = "barcodeTxt";
            this.barcodeTxt.Size = new System.Drawing.Size(217, 23);
            this.barcodeTxt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Barcode";
            // 
            // pupTxt
            // 
            this.pupTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pupTxt.Location = new System.Drawing.Point(8, 247);
            this.pupTxt.Name = "pupTxt";
            this.pupTxt.Size = new System.Drawing.Size(217, 23);
            this.pupTxt.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Per Unit Price";
            // 
            // cartBtn
            // 
            this.cartBtn.FlatAppearance.BorderSize = 2;
            this.cartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cartBtn.Location = new System.Drawing.Point(8, 322);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(216, 38);
            this.cartBtn.TabIndex = 5;
            this.cartBtn.Text = "ADD TO CART";
            this.cartBtn.UseVisualStyleBackColor = true;
            // 
            // PurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 813);
            this.Name = "PurchaseInvoice";
            this.Text = "PurchaseInvoice";
            this.Load += new System.EventHandler(this.PurchaseInvoice_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox supplierDD;
        private System.Windows.Forms.Button cartBtn;
        private System.Windows.Forms.TextBox pupTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox barcodeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quanTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productTxt;
        private System.Windows.Forms.Label label3;
    }
}