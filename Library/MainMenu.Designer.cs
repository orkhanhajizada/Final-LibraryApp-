﻿namespace Library
{
    partial class MainMenu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DgvGivenBooksList = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtMemberNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DtpReturnTime = new System.Windows.Forms.DateTimePicker();
            this.DtpGivenTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.PbReturnBook = new System.Windows.Forms.PictureBox();
            this.PbAddBook = new System.Windows.Forms.PictureBox();
            this.PbAddMember = new System.Windows.Forms.PictureBox();
            this.PbAddUser = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGivenBooksList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbReturnBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAddBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAddMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAddUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "İstifadəçilər";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitabxana üzüvləri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kitablar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(611, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Qaytarılan Kitablar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Controls.Add(this.DgvGivenBooksList);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.TxtMemberNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DtpReturnTime);
            this.groupBox1.Controls.Add(this.DtpGivenTime);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1141, 682);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verilmiş Kitablar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ad";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackgroundImage = global::Library.Properties.Resources.edit_find;
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(861, 56);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(71, 64);
            this.BtnSearch.TabIndex = 21;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgvGivenBooksList
            // 
            this.DgvGivenBooksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGivenBooksList.Location = new System.Drawing.Point(24, 158);
            this.DgvGivenBooksList.Name = "DgvGivenBooksList";
            this.DgvGivenBooksList.RowTemplate.Height = 24;
            this.DgvGivenBooksList.Size = new System.Drawing.Size(1093, 459);
            this.DgvGivenBooksList.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(668, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Üzüvlük nömrəsi";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(24, 86);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(155, 26);
            this.TxtName.TabIndex = 12;
            // 
            // TxtMemberNumber
            // 
            this.TxtMemberNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMemberNumber.Location = new System.Drawing.Point(671, 85);
            this.TxtMemberNumber.Name = "TxtMemberNumber";
            this.TxtMemberNumber.Size = new System.Drawing.Size(155, 26);
            this.TxtMemberNumber.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(202, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Verilmə Tarixi";
            // 
            // DtpReturnTime
            // 
            this.DtpReturnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpReturnTime.Location = new System.Drawing.Point(438, 84);
            this.DtpReturnTime.Name = "DtpReturnTime";
            this.DtpReturnTime.Size = new System.Drawing.Size(200, 26);
            this.DtpReturnTime.TabIndex = 18;
            // 
            // DtpGivenTime
            // 
            this.DtpGivenTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpGivenTime.Location = new System.Drawing.Point(206, 84);
            this.DtpGivenTime.Name = "DtpGivenTime";
            this.DtpGivenTime.Size = new System.Drawing.Size(200, 26);
            this.DtpGivenTime.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(434, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Qaytarılma Tarixi";
            // 
            // PbReturnBook
            // 
            this.PbReturnBook.BackgroundImage = global::Library.Properties.Resources.returnbook;
            this.PbReturnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbReturnBook.Location = new System.Drawing.Point(635, 23);
            this.PbReturnBook.Name = "PbReturnBook";
            this.PbReturnBook.Size = new System.Drawing.Size(85, 85);
            this.PbReturnBook.TabIndex = 8;
            this.PbReturnBook.TabStop = false;
            // 
            // PbAddBook
            // 
            this.PbAddBook.BackgroundImage = global::Library.Properties.Resources.addbook;
            this.PbAddBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbAddBook.Location = new System.Drawing.Point(436, 23);
            this.PbAddBook.Name = "PbAddBook";
            this.PbAddBook.Size = new System.Drawing.Size(85, 85);
            this.PbAddBook.TabIndex = 4;
            this.PbAddBook.TabStop = false;
            this.PbAddBook.Click += new System.EventHandler(this.PbAddBook_Click);
            // 
            // PbAddMember
            // 
            this.PbAddMember.BackgroundImage = global::Library.Properties.Resources.addmember;
            this.PbAddMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbAddMember.Location = new System.Drawing.Point(219, 23);
            this.PbAddMember.Name = "PbAddMember";
            this.PbAddMember.Size = new System.Drawing.Size(85, 85);
            this.PbAddMember.TabIndex = 2;
            this.PbAddMember.TabStop = false;
            this.PbAddMember.Click += new System.EventHandler(this.PbAddMember_Click);
            // 
            // PbAddUser
            // 
            this.PbAddUser.BackgroundImage = global::Library.Properties.Resources.adduser;
            this.PbAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbAddUser.Location = new System.Drawing.Point(18, 23);
            this.PbAddUser.Name = "PbAddUser";
            this.PbAddUser.Size = new System.Drawing.Size(85, 85);
            this.PbAddUser.TabIndex = 0;
            this.PbAddUser.TabStop = false;
            this.PbAddUser.Click += new System.EventHandler(this.PbAddUser_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 1055);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PbReturnBook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PbAddBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PbAddMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PbAddUser);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainMenu";
            this.Text = "Kitabxana";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGivenBooksList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbReturnBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAddBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAddMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAddUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbAddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PbAddMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PbAddBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PbReturnBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView DgvGivenBooksList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtMemberNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtpReturnTime;
        private System.Windows.Forms.DateTimePicker DtpGivenTime;
        private System.Windows.Forms.Label label8;
    }
}