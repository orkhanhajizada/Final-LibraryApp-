namespace Library
{
    partial class DeletedBookList
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
            this.DgvDeletedBookList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRecoveryBook = new System.Windows.Forms.Button();
            this.LblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDeletedBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDeletedBookList
            // 
            this.DgvDeletedBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDeletedBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDeletedBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.DgvDeletedBookList.Location = new System.Drawing.Point(12, 65);
            this.DgvDeletedBookList.Name = "DgvDeletedBookList";
            this.DgvDeletedBookList.RowTemplate.Height = 24;
            this.DgvDeletedBookList.Size = new System.Drawing.Size(875, 373);
            this.DgvDeletedBookList.TabIndex = 7;
            this.DgvDeletedBookList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvDeletedBookList_RowHeaderMouseDoubleClick);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Silinən kitablar";
            // 
            // BtnRecoveryBook
            // 
            this.BtnRecoveryBook.Location = new System.Drawing.Point(708, 13);
            this.BtnRecoveryBook.Name = "BtnRecoveryBook";
            this.BtnRecoveryBook.Size = new System.Drawing.Size(179, 39);
            this.BtnRecoveryBook.TabIndex = 10;
            this.BtnRecoveryBook.Text = "Bərpa et";
            this.BtnRecoveryBook.UseVisualStyleBackColor = true;
            this.BtnRecoveryBook.Click += new System.EventHandler(this.BtnRecoveryBook_Click);
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(523, 21);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(0, 17);
            this.LblId.TabIndex = 11;
            this.LblId.Visible = false;
            // 
            // DeletedBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.BtnRecoveryBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvDeletedBookList);
            this.Name = "DeletedBookList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DeletedBookList";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDeletedBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDeletedBookList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRecoveryBook;
        private System.Windows.Forms.Label LblId;
    }
}