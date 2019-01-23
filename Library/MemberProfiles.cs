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
        public void FillMembers()
        {
            DgvMembers.Rows.Clear();

            foreach (Models.Member table in db.Members.ToList())
            {
                if (table.MemberStatus == true)
                {
                    DgvMembers.Rows.Add(table.Id, table.MemberName, table.Phone, table.MemberNumber.ToString(), table.CreateTime.ToString("dd/MM/yyyy"), table.User.UserName);

                }
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
                MemberNumber = DateTime.Now.ToString("yyMMddHHmmss"),
                MemberStatus = true

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

        //Useri silmek
        private void BtnDeleteMember_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Silməyə əminsiniz mi?", "Silmə", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                SelectedMember.MemberStatus = false;

                db.SaveChanges();

                Reset();
            }
        }

        //Uzv axtarmaq
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //Ada gore axtarmaq
            if (CheckName.Checked == true)
            {
                DgvMembers.Rows.Clear();

                var members = db.Members.Where(m => m.MemberName.Contains(TxtSerachName.Text));

                if (!string.IsNullOrEmpty(TxtSerachName.Text))
                {
                    if (members != null)
                    {
                        foreach (var search in members)
                        {
                            if (search.MemberStatus == true)
                            {
                                DgvMembers.Rows.Add(search.Id, search.MemberName, search.Phone, search.MemberNumber.ToString(), search.CreateTime.ToString("dd/MM/yyyy"), search.User.UserName);

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Axtarışınıza uyğun nəticə tapılmadı!");
                    }

                }
                else
                {
                    MessageBox.Show("Axtardığınız üzvün adını yazın!");
                }

            }

            //Uzv nomresine gore axtarmaq
            if (checkId.Checked == true)
            {
                DgvMembers.Rows.Clear();

                var memberNumber = db.Members.Where(m => m.MemberNumber.Contains(TxtMemberNumber.Text));

                if (!string.IsNullOrEmpty(TxtMemberNumber.Text))
                {
                    if (memberNumber != null)
                    {
                        foreach (var numbers in memberNumber)
                        {
                            if (numbers.MemberStatus == true)
                            {
                                DgvMembers.Rows.Add(numbers.Id, numbers.MemberName, numbers.Phone, numbers.MemberNumber.ToString(), numbers.CreateTime.ToString("dd/MM/yyyy"), numbers.User.UserName);

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Axtarışınıza uyğun nəticə tapılmadı!");
                    }
                }
                else
                {
                    MessageBox.Show("Axtardığınız üzvün üzüvlük nomrəsini yazın!");
                }
            }
        }

        //Axtarışı yalnız 1 inputa görə axtarmaq
        #region
        private void CheckName_CheckedChanged(object sender, EventArgs e)
        {
            checkId.Checked = false;
        }

        private void checkId_CheckedChanged(object sender, EventArgs e)
        {
            CheckName.Checked = false;
        }
        #endregion

        //Axtarishi refresh etmek
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            TxtSerachName.Clear();
            TxtMemberNumber.Clear();
            checkId.Checked = false;
            CheckName.Checked = false;
            FillMembers();
        }

        //Silinen uzvler menusunu achmaq
        private void BtnDeleted_Click(object sender, EventArgs e)
        {
            DeletedMembersList DeletedMember = new DeletedMembersList(SentUser);

            DeletedMember.ShowDialog();
        }

        private void DeletedMembersList_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillMembers();
        }
    }
}
