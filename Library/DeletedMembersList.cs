using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;

namespace Library
{
    public partial class DeletedMembersList : Form
    {
        LibraryEntities db = new LibraryEntities();

        public User SentUser;

        private Models.Member SelectedDelete;

        
        public DeletedMembersList(User user)
        {
            InitializeComponent();
            FillDeleted();
        }

        //Silinen uzuvlerin doldurulmasi
        private void FillDeleted()
        {
            DgvDeletedMembers.Rows.Clear();

            foreach (Models.Member table in db.Members.ToList())
            {
                if (table.MemberStatus == false)
                {
                    DgvDeletedMembers.Rows.Add(table.Id, table.MemberName, table.Phone, table.MemberNumber.ToString(), table.CreateTime.ToString("dd/MM/yyyy"), table.User.UserName);

                }
            }
        }

        //Uzvu berpa etmek
        #region
        private void DgvDeletedMembers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int DeletedMember = Convert.ToInt32(DgvDeletedMembers.Rows[e.RowIndex].Cells[0].Value.ToString());

            LblId.Text = DeletedMember.ToString();
        }

        private void BtnRecovery_Click(object sender, EventArgs e)
        {
            if (LblId.Text != "")
            {
                int MemberId = Convert.ToInt32(LblId.Text);

                SelectedDelete = db.Members.Find(MemberId);
                SelectedDelete.MemberStatus = true;

                db.SaveChanges();

                MessageBox.Show("Üzv bərpa edildi");
                if (System.Windows.Forms.Application.OpenForms["MemberProfiles"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["MemberProfiles"] as MemberProfiles).DgvMembers.Rows.Clear();
                    (System.Windows.Forms.Application.OpenForms["MemberProfiles"] as MemberProfiles).db = db;
                    foreach (Models.Member table in db.Members.ToList())
                    {
                        if (table.MemberStatus == true)
                        {
                            (System.Windows.Forms.Application.OpenForms["MemberProfiles"] as MemberProfiles).DgvMembers.Rows.Add(table.Id, table.MemberName, table.Phone, table.MemberNumber.ToString(), table.CreateTime.ToString("dd/MM/yyyy"), table.User.UserName);
                        }
                    }
                }
                FillDeleted();
                LblId.Text = "";
            }
            else
            {
                MessageBox.Show("Üzvü seçin");
            }
        }
        #endregion
    }

}
