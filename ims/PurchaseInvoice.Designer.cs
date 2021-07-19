
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
            this.label7 = new System.Windows.Forms.Label();
            this.totLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pupGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.grossTotalLbl = new System.Windows.Forms.Label();
            this.suppErrorLbl = new System.Windows.Forms.Label();
            this.barcodeErrorLbl = new System.Windows.Forms.Label();
            this.quantErrorLbl = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(3, 21);
            this.searchTxt.Size = new System.Drawing.Size(173, 25);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.totLbl);
            this.leftPanel.Controls.Add(this.label7);
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
            this.leftPanel.Controls.Add(this.suppErrorLbl);
            this.leftPanel.Controls.Add(this.barcodeErrorLbl);
            this.leftPanel.Controls.Add(this.quantErrorLbl);
            this.leftPanel.Size = new System.Drawing.Size(250, 706);
            this.leftPanel.Controls.SetChildIndex(this.quantErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.suppErrorLbl, 0);
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
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.totLbl, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 51);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panel5);
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightPanel.Size = new System.Drawing.Size(1080, 706);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel5, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1080, 40);
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
            this.quanTxt.TextChanged += new System.EventHandler(this.quanTxt_TextChanged);
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
            this.barcodeTxt.TextChanged += new System.EventHandler(this.barcodeTxt_TextChanged);
            this.barcodeTxt.Validated += new System.EventHandler(this.barcodeTxt_Validated);
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
            this.cartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartBtn.FlatAppearance.BorderSize = 2;
            this.cartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cartBtn.Location = new System.Drawing.Point(8, 322);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(216, 38);
            this.cartBtn.TabIndex = 5;
            this.cartBtn.Text = "ADD TO CART";
            this.cartBtn.UseVisualStyleBackColor = true;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total Amount";
            // 
            // totLbl
            // 
            this.totLbl.AutoSize = true;
            this.totLbl.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.totLbl.Location = new System.Drawing.Point(71, 378);
            this.totLbl.Name = "totLbl";
            this.totLbl.Size = new System.Drawing.Size(81, 46);
            this.totLbl.TabIndex = 12;
            this.totLbl.Text = "0.00";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proIDGV,
            this.proGV,
            this.quantGV,
            this.pupGV,
            this.totGV,
            this.deleteGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 449);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // proIDGV
            // 
            this.proIDGV.HeaderText = "proID";
            this.proIDGV.Name = "proIDGV";
            this.proIDGV.ReadOnly = true;
            this.proIDGV.Visible = false;
            // 
            // proGV
            // 
            this.proGV.HeaderText = "Product";
            this.proGV.Name = "proGV";
            this.proGV.ReadOnly = true;
            // 
            // quantGV
            // 
            this.quantGV.HeaderText = "Quantity";
            this.quantGV.Name = "quantGV";
            this.quantGV.ReadOnly = true;
            // 
            // pupGV
            // 
            this.pupGV.HeaderText = "Per Unit Price";
            this.pupGV.Name = "pupGV";
            this.pupGV.ReadOnly = true;
            // 
            // totGV
            // 
            this.totGV.HeaderText = "Total Amount";
            this.totGV.Name = "totGV";
            this.totGV.ReadOnly = true;
            // 
            // deleteGV
            // 
            this.deleteGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deleteGV.HeaderText = "Action";
            this.deleteGV.Name = "deleteGV";
            this.deleteGV.ReadOnly = true;
            this.deleteGV.Text = "DELETE";
            this.deleteGV.UseColumnTextForButtonValue = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 540);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1080, 166);
            this.panel5.TabIndex = 5;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.grossTotalLbl, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 44);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1080, 122);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(534, 122);
            this.label9.TabIndex = 13;
            this.label9.Text = "Gross Total";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // grossTotalLbl
            // 
            this.grossTotalLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grossTotalLbl.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.grossTotalLbl.Location = new System.Drawing.Point(543, 0);
            this.grossTotalLbl.Name = "grossTotalLbl";
            this.grossTotalLbl.Size = new System.Drawing.Size(534, 122);
            this.grossTotalLbl.TabIndex = 14;
            this.grossTotalLbl.Text = "0.00";
            this.grossTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // suppErrorLbl
            // 
            this.suppErrorLbl.AutoSize = true;
            this.suppErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.suppErrorLbl.Location = new System.Drawing.Point(205, 91);
            this.suppErrorLbl.Name = "suppErrorLbl";
            this.suppErrorLbl.Size = new System.Drawing.Size(20, 28);
            this.suppErrorLbl.TabIndex = 16;
            this.suppErrorLbl.Text = "*";
            this.suppErrorLbl.Visible = false;
            // 
            // barcodeErrorLbl
            // 
            this.barcodeErrorLbl.AutoSize = true;
            this.barcodeErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.barcodeErrorLbl.Location = new System.Drawing.Point(205, 138);
            this.barcodeErrorLbl.Name = "barcodeErrorLbl";
            this.barcodeErrorLbl.Size = new System.Drawing.Size(20, 28);
            this.barcodeErrorLbl.TabIndex = 17;
            this.barcodeErrorLbl.Text = "*";
            this.barcodeErrorLbl.Visible = false;
            // 
            // quantErrorLbl
            // 
            this.quantErrorLbl.AutoSize = true;
            this.quantErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.quantErrorLbl.Location = new System.Drawing.Point(205, 269);
            this.quantErrorLbl.Name = "quantErrorLbl";
            this.quantErrorLbl.Size = new System.Drawing.Size(20, 28);
            this.quantErrorLbl.TabIndex = 18;
            this.quantErrorLbl.Text = "*";
            this.quantErrorLbl.Visible = false;
            // 
            // PurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 706);
            this.Name = "PurchaseInvoice";
            this.Text = "PurchaseInvoice";
            this.Load += new System.EventHandler(this.PurchaseInvoice_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.Label totLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label grossTotalLbl;
        private System.Windows.Forms.Label suppErrorLbl;
        private System.Windows.Forms.Label barcodeErrorLbl;
        private System.Windows.Forms.Label quantErrorLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
    }
}