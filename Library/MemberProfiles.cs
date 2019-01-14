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
    public partial class MemberProfiles : Form
    {
        LibraryEntities db = new LibraryEntities();

        private Models.Member SelectedMember;
        public User SentUser;

        public MemberProfiles(User user)
        {
            SentUser = user;
            InitializeComponent();
            FillMembers();
        }

        //Uzuvlerin doldurulmasi
        private void FillMembers()
        {
            DgvMembers.Rows.Clear();

            foreach (Models.Member table in db.Members.ToList())
            {
                DgvMembers.Rows.Add(table.Id, table.MemberName, table.Phone, table.MemberNumber.ToString(), table.CreateTime.ToString("dd/MM/yyyy"),table.User.UserName);
            }
        }

        

        //Uzuv elave etmek
        private void BtnAddMember_Click(object sender, EventArgs e)
        {
            //Inputlarin yoxlanilmasi
            if ((string.IsNullOrEmpty(TxtName.Text)) || (string.IsNullOrEmpty(TxtPhone.Text)))
            {
                MessageBox.Show("Boşluqları doldurun!");
                return;
            }

            if (db.Members.FirstOrDefault(t => t.Phone == TxtPhone.Text) != null)
            {
                MessageBox.Show("Bu nömrədən artıq istifadə olunub!");
                return;
            }

            Models.Member mem = new Models.Member
            {
                MemberName = TxtName.Text,
                Phone = TxtPhone.Text,
                CreateTime = DateTime.Now,
                UserId = SentUser.Id,
                MemberNumber = DateTime.Now.ToString("yyMMddHHmmss")

            };
            db.Members.Add(mem);
            db.SaveChanges();


            FillMembers();
            Reset();
        }
        //Inputlari sifirlamaq
        private void Reset()
        {
            TxtName.Clear();
            TxtPhone.Clear();


            FillMembers();

            BtnDeleteMember.Visible = false;
            BtnAddMember.Visible = true;
            BtnUpdateMember.Visible = false;
        }

        //Datagridview`dan user sechmek
        private void DgvMembers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DgvMembers.Rows[e.RowIndex].Cells[0].Value.ToString());

            SelectedMember = db.Members.Find(id);

            TxtName.Text = SelectedMember.MemberName;
            TxtPhone.Text = SelectedMember.Phone;

            BtnDeleteMember.Visible = true;
            BtnAddMember.Visible = false;
            BtnUpdateMember.Visible = true;

        }

        //Useri update etmek
        private void BtnUpdateMember_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(TxtName.Text)) || (string.IsNullOrEmpty(TxtPhone.Text)))
            {
                MessageBox.Show("Boşluqları doldurun!");
                return;
            }

            SelectedMember.MemberName = TxtName.Text;
            SelectedMember.Phone = TxtPhone.Text;

            db.SaveChanges();
            FillMembers();

            Reset();
        }

        private void BtnDeleteMember_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Silməyə əminsiniz mi?", "Silmə", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                db.Members.Remove(SelectedMember);

                db.SaveChanges();

                Reset();
            }
        }

        
    }
}
