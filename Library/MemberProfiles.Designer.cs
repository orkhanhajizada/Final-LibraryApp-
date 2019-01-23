namespace Library
{
    partial class MemberProfiles
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDeleteMember = new System.Windows.Forms.Button();
            this.BtnUpdateMember = new System.Windows.Forms.Button();
            this.BtnAddMember = new System.Windows.Forms.Button();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvMembers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckName = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSerachName = new System.Windows.Forms.TextBox();
            this.checkId = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtMemberNumber = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnDeleted = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMembers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDeleteMember);
            this.groupBox1.Controls.Add(this.BtnUpdateMember);
            this.groupBox1.Controls.Add(this.BtnAddMember);
            this.groupBox1.Controls.Add(this.TxtPhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(839, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 324);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni üzv əlavə et";
            // 
            // BtnDeleteMember
            // 
            this.BtnDeleteMember.Location = new System.Drawing.Point(137, 242);
            this.BtnDeleteMember.Name = "BtnDeleteMember";
            this.BtnDeleteMember.Size = new System.Drawing.Size(89, 42);
            this.BtnDeleteMember.TabIndex = 8;
            this.BtnDeleteMember.Text = "Sil";
            this.BtnDeleteMember.UseVisualStyleBackColor = true;
            this.BtnDeleteMember.Visible = false;
            this.BtnDeleteMember.Click += new System.EventHandler(this.BtnDeleteMember_Click);
            // 
            // BtnUpdateMember
            // 
            this.BtnUpdateMember.Location = new System.Drawing.Point(42, 242);
            this.BtnUpdateMember.Name = "BtnUpdateMember";
            this.BtnUpdateMember.Size = new System.Drawing.Size(89, 42);
            this.BtnUpdateMember.TabIndex = 7;
            this.BtnUpdateMember.Text = "Yenilə";
            this.BtnUpdateMember.UseVisualStyleBackColor = true;
            this.BtnUpdateMember.Visible = false;
            this.BtnUpdateMember.Click += new System.EventHandler(this.BtnUpdateMember_Click);
            // 
            // BtnAddMember
            // 
            this.BtnAddMember.Location = new System.Drawing.Point(42, 191);
            this.BtnAddMember.Name = "BtnAddMember";
            this.BtnAddMember.Size = new System.Drawing.Size(184, 42);
            this.BtnAddMember.TabIndex = 6;
            this.BtnAddMember.Text = "Əlavə et";
            this.BtnAddMember.UseVisualStyleBackColor = true;
            this.BtnAddMember.Click += new System.EventHandler(this.BtnAddMember_Click);
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(42, 134);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(184, 24);
            this.TxtPhone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
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
            this.label2.Location = new System.Drawing.Point(68, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad,Soyad,Ata adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kitabxana üzüvləri";
            // 
            // DgvMembers
            // 
            this.DgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DgvMembers.Location = new System.Drawing.Point(17, 55);
            this.DgvMembers.Name = "DgvMembers";
            this.DgvMembers.RowTemplate.Height = 24;
            this.DgvMembers.Size = new System.Drawing.Size(793, 650);
            this.DgvMembers.TabIndex = 3;
            this.DgvMembers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvMembers_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ad,Soyad,Ata adı";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefon";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Üzüvlük Nomrəsi";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Yaradılma vaxtı";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Əlavə edən işçi";
            this.Column6.Name = "Column6";
            // 
            // CheckName
            // 
            this.CheckName.AutoSize = true;
            this.CheckName.Location = new System.Drawing.Point(49, 47);
            this.CheckName.Name = "CheckName";
            this.CheckName.Size = new System.Drawing.Size(18, 17);
            this.CheckName.TabIndex = 25;
            this.CheckName.UseVisualStyleBackColor = true;
            this.CheckName.CheckedChanged += new System.EventHandler(this.CheckName_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ad";
            // 
            // TxtSerachName
            // 
            this.TxtSerachName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSerachName.Location = new System.Drawing.Point(6, 75);
            this.TxtSerachName.Name = "TxtSerachName";
            this.TxtSerachName.Size = new System.Drawing.Size(162, 26);
            this.TxtSerachName.TabIndex = 23;
            // 
            // checkId
            // 
            this.checkId.AutoSize = true;
            this.checkId.Location = new System.Drawing.Point(150, 131);
            this.checkId.Name = "checkId";
            this.checkId.Size = new System.Drawing.Size(18, 17);
            this.checkId.TabIndex = 28;
            this.checkId.UseVisualStyleBackColor = true;
            this.checkId.CheckedChanged += new System.EventHandler(this.checkId_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Üzüvlük nömrəsi";
            // 
            // TxtMemberNumber
            // 
            this.TxtMemberNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMemberNumber.Location = new System.Drawing.Point(7, 158);
            this.TxtMemberNumber.Name = "TxtMemberNumber";
            this.TxtMemberNumber.Size = new System.Drawing.Size(161, 26);
            this.TxtMemberNumber.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtSerachName);
            this.groupBox2.Controls.Add(this.BtnRefresh);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.BtnSearch);
            this.groupBox2.Controls.Add(this.CheckName);
            this.groupBox2.Controls.Add(this.checkId);
            this.groupBox2.Controls.Add(this.TxtMemberNumber);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(839, 410);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 208);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Axtar";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackgroundImage = global::Library.Properties.Resources.refresh;
            this.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.Location = new System.Drawing.Point(227, 138);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(60, 46);
            this.BtnRefresh.TabIndex = 30;
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackgroundImage = global::Library.Properties.Resources.edit_find;
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(227, 55);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(60, 46);
            this.BtnSearch.TabIndex = 29;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnDeleted
            // 
            this.BtnDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleted.Location = new System.Drawing.Point(839, 658);
            this.BtnDeleted.Name = "BtnDeleted";
            this.BtnDeleted.Size = new System.Drawing.Size(168, 47);
            this.BtnDeleted.TabIndex = 32;
            this.BtnDeleted.Text = "Silinən üzüvlər";
            this.BtnDeleted.UseVisualStyleBackColor = true;
            this.BtnDeleted.Click += new System.EventHandler(this.BtnDeleted_Click);
            // 
            // MemberProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 727);
            this.Controls.Add(this.BtnDeleted);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvMembers);
            this.Name = "MemberProfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kitabxana üzüvləri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMembers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnDeleteMember;
        private System.Windows.Forms.Button BtnUpdateMember;
        private System.Windows.Forms.Button BtnAddMember;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView DgvMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.CheckBox CheckName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSerachName;
        private System.Windows.Forms.CheckBox checkId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtMemberNumber;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnDeleted;
    }
}