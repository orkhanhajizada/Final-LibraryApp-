namespace Library
{
    partial class AddBooks
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
            this.label1 = new System.Windows.Forms.Label();
            this.DgvBookList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumCount = new System.Windows.Forms.NumericUpDown();
            this.BtnDeleteBook = new System.Windows.Forms.Button();
            this.BtnUpdateBook = new System.Windows.Forms.Button();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kitabların siyahısı";
            // 
            // DgvBookList
            // 
            this.DgvBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.DgvBookList.Location = new System.Drawing.Point(17, 75);
            this.DgvBookList.Name = "DgvBookList";
            this.DgvBookList.RowTemplate.Height = 24;
            this.DgvBookList.Size = new System.Drawing.Size(711, 386);
            this.DgvBookList.TabIndex = 6;
            this.DgvBookList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvBookList_RowHeaderMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kitabın adı";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Say";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Yaradılma tarixi";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Əlavə edən şəxs";
            this.Column4.Name = "Column4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumCount);
            this.groupBox1.Controls.Add(this.BtnDeleteBook);
            this.groupBox1.Controls.Add(this.BtnUpdateBook);
            this.groupBox1.Controls.Add(this.BtnAddBook);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(783, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 330);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni kitab əlavə et";
            // 
            // NumCount
            // 
            this.NumCount.Location = new System.Drawing.Point(42, 141);
            this.NumCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumCount.Name = "NumCount";
            this.NumCount.Size = new System.Drawing.Size(184, 22);
            this.NumCount.TabIndex = 9;
            this.NumCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnDeleteBook
            // 
            this.BtnDeleteBook.Location = new System.Drawing.Point(137, 261);
            this.BtnDeleteBook.Name = "BtnDeleteBook";
            this.BtnDeleteBook.Size = new System.Drawing.Size(89, 42);
            this.BtnDeleteBook.TabIndex = 8;
            this.BtnDeleteBook.Text = "Sil";
            this.BtnDeleteBook.UseVisualStyleBackColor = true;
            this.BtnDeleteBook.Visible = false;
            this.BtnDeleteBook.Click += new System.EventHandler(this.BtnDeleteBook_Click);
            // 
            // BtnUpdateBook
            // 
            this.BtnUpdateBook.Location = new System.Drawing.Point(42, 261);
            this.BtnUpdateBook.Name = "BtnUpdateBook";
            this.BtnUpdateBook.Size = new System.Drawing.Size(89, 42);
            this.BtnUpdateBook.TabIndex = 7;
            this.BtnUpdateBook.Text = "Yenilə";
            this.BtnUpdateBook.UseVisualStyleBackColor = true;
            this.BtnUpdateBook.Visible = false;
            this.BtnUpdateBook.Click += new System.EventHandler(this.BtnUpdateBook_Click);
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.Location = new System.Drawing.Point(42, 210);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(184, 42);
            this.BtnAddBook.TabIndex = 6;
            this.BtnAddBook.Text = "Əlavə et";
            this.BtnAddBook.UseVisualStyleBackColor = true;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Say";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(42, 72);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(184, 24);
            this.TxtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kitabın adı";
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 731);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvBookList);
            this.Controls.Add(this.label1);
            this.Name = "AddBooks";
            this.Text = "AddBooks";
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvBookList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnDeleteBook;
        private System.Windows.Forms.Button BtnUpdateBook;
        private System.Windows.Forms.Button BtnAddBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.NumericUpDown NumCount;
    }
}