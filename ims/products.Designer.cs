
namespace ims
{
    partial class products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.proTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.proErrorLabel = new System.Windows.Forms.Label();
            this.barcodeTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.barcodeErrorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.expiryPicker = new System.Windows.Forms.DateTimePicker();
            this.expiryErrorLabel = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.priceErrorLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.categoryDD = new System.Windows.Forms.ComboBox();
            this.catErrorLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTxt
            // 
            this.searchTxt.Size = new System.Drawing.Size(129, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.categoryDD);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.priceTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.priceErrorLabel);
            this.leftPanel.Controls.Add(this.expiryPicker);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.barcodeTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.barcodeErrorLabel);
            this.leftPanel.Controls.Add(this.proTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.proErrorLabel);
            this.leftPanel.Controls.Add(this.expiryErrorLabel);
            this.leftPanel.Controls.Add(this.catErrorLabel);
            this.leftPanel.Size = new System.Drawing.Size(250, 632);
            this.leftPanel.Controls.SetChildIndex(this.catErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.expiryErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.proErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.proTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.expiryPicker, 0);
            this.leftPanel.Controls.SetChildIndex(this.priceErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.priceTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.categoryDD, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 51);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(826, 632);
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanel_Paint_1);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(826, 40);
            // 
            // proTxt
            // 
            this.proTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proTxt.Location = new System.Drawing.Point(15, 125);
            this.proTxt.MaxLength = 30;
            this.proTxt.Name = "proTxt";
            this.proTxt.Size = new System.Drawing.Size(229, 23);
            this.proTxt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Product Name";
            // 
            // proErrorLabel
            // 
            this.proErrorLabel.AutoSize = true;
            this.proErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.proErrorLabel.Location = new System.Drawing.Point(92, 103);
            this.proErrorLabel.Name = "proErrorLabel";
            this.proErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.proErrorLabel.TabIndex = 15;
            this.proErrorLabel.Text = "*";
            this.proErrorLabel.Visible = false;
            // 
            // barcodeTxt
            // 
            this.barcodeTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeTxt.Location = new System.Drawing.Point(15, 172);
            this.barcodeTxt.MaxLength = 30;
            this.barcodeTxt.Name = "barcodeTxt";
            this.barcodeTxt.Size = new System.Drawing.Size(229, 23);
            this.barcodeTxt.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Barcode";
            // 
            // barcodeErrorLabel
            // 
            this.barcodeErrorLabel.AutoSize = true;
            this.barcodeErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.barcodeErrorLabel.Location = new System.Drawing.Point(57, 150);
            this.barcodeErrorLabel.Name = "barcodeErrorLabel";
            this.barcodeErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.barcodeErrorLabel.TabIndex = 18;
            this.barcodeErrorLabel.Text = "*";
            this.barcodeErrorLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Expire Date";
            // 
            // expiryPicker
            // 
            this.expiryPicker.CustomFormat = "dd-MMM-yyyy";
            this.expiryPicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expiryPicker.Location = new System.Drawing.Point(15, 217);
            this.expiryPicker.Name = "expiryPicker";
            this.expiryPicker.Size = new System.Drawing.Size(229, 23);
            this.expiryPicker.TabIndex = 20;
            // 
            // expiryErrorLabel
            // 
            this.expiryErrorLabel.AutoSize = true;
            this.expiryErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.expiryErrorLabel.Location = new System.Drawing.Point(74, 194);
            this.expiryErrorLabel.Name = "expiryErrorLabel";
            this.expiryErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.expiryErrorLabel.TabIndex = 21;
            this.expiryErrorLabel.Text = "*";
            this.expiryErrorLabel.Visible = false;
            // 
            // priceTxt
            // 
            this.priceTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxt.Location = new System.Drawing.Point(15, 265);
            this.priceTxt.MaxLength = 30;
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(229, 23);
            this.priceTxt.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Price";
            // 
            // priceErrorLabel
            // 
            this.priceErrorLabel.AutoSize = true;
            this.priceErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.priceErrorLabel.Location = new System.Drawing.Point(42, 243);
            this.priceErrorLabel.Name = "priceErrorLabel";
            this.priceErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.priceErrorLabel.TabIndex = 24;
            this.priceErrorLabel.Text = "*";
            this.priceErrorLabel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Category";
            // 
            // categoryDD
            // 
            this.categoryDD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categoryDD.FormattingEnabled = true;
            this.categoryDD.Location = new System.Drawing.Point(15, 310);
            this.categoryDD.Name = "categoryDD";
            this.categoryDD.Size = new System.Drawing.Size(229, 23);
            this.categoryDD.TabIndex = 26;
            this.categoryDD.SelectedIndexChanged += new System.EventHandler(this.categoryDD_SelectedIndexChanged);
            // 
            // catErrorLabel
            // 
            this.catErrorLabel.AutoSize = true;
            this.catErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.catErrorLabel.Location = new System.Drawing.Point(63, 288);
            this.catErrorLabel.Name = "catErrorLabel";
            this.catErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.catErrorLabel.TabIndex = 27;
            this.catErrorLabel.Text = "*";
            this.catErrorLabel.Visible = false;
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
            this.barcodeGV,
            this.expiryGV,
            this.priceGV,
            this.catIDGV,
            this.catGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(826, 541);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // barcodeGV
            // 
            this.barcodeGV.HeaderText = "Barcode";
            this.barcodeGV.Name = "barcodeGV";
            this.barcodeGV.ReadOnly = true;
            // 
            // expiryGV
            // 
            this.expiryGV.HeaderText = "Expiry Date";
            this.expiryGV.Name = "expiryGV";
            this.expiryGV.ReadOnly = true;
            this.expiryGV.Visible = false;
            // 
            // priceGV
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.priceGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.priceGV.HeaderText = "Price";
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // catIDGV
            // 
            this.catIDGV.HeaderText = "CatIDGV";
            this.catIDGV.Name = "catIDGV";
            this.catIDGV.ReadOnly = true;
            this.catIDGV.Visible = false;
            // 
            // catGV
            // 
            this.catGV.HeaderText = "Category";
            this.catGV.Name = "catGV";
            this.catGV.ReadOnly = true;
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 632);
            this.Name = "products";
            this.Text = "products";
            this.Load += new System.EventHandler(this.products_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox proTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label proErrorLabel;
        private System.Windows.Forms.ComboBox categoryDD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label priceErrorLabel;
        private System.Windows.Forms.DateTimePicker expiryPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox barcodeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label barcodeErrorLabel;
        private System.Windows.Forms.Label expiryErrorLabel;
        private System.Windows.Forms.Label catErrorLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catGV;
    }
}