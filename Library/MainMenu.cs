using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;

namespace Library
{
    public partial class MainMenu : Form
    {
        LibraryEntities db = new LibraryEntities();
        public User sentUser;
        private Models.ReservedBook SelectedReserve;
        public MainMenu(User user)
        {
            sentUser = user;
            InitializeComponent();
            FillBookStatus();
            FillGivenBooks();
        }

        //User menu`sunun achilmagi
        private void PbAddUser_Click(object sender, EventArgs e)
        {
            WorkerProfiles wkprofiles = new WorkerProfiles();

            wkprofiles.ShowDialog();
        }

        //Uzv menusunun achilmagi
        private void PbAddMember_Click(object sender, EventArgs e)
        {
            MemberProfiles memberProfile = new MemberProfiles(sentUser);

            memberProfile.ShowDialog();

        }

        //Kitablar menusunun achilmagi
        private void PbAddBook_Click(object sender, EventArgs e)
        {
            AddBooks BooksMenu = new AddBooks(sentUser);

            BooksMenu.ShowDialog();
        }

        //Qaytarilan kitablar menusunu achmaq
        private void PbReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBookMenu returnMenu = new ReturnBookMenu(sentUser);

            returnMenu.ShowDialog();
        }

        //Uzv nomresine gore uzvun ad soyadinin tapmag
        private void BtnSearchMember_Click(object sender, EventArgs e)
        {
            //Inputu yoxlamag
            if (string.IsNullOrEmpty(TxtMemberId.Text))
            {
                MessageBox.Show("Üzüvlük nömrəsini yazın");

            }
            if (!string.IsNullOrEmpty(TxtMemberId.Text))
            {
                var Member = db.Members.Where(m => m.MemberNumber.Contains(TxtMemberId.Text));

                Member mem = db.Members.FirstOrDefault(f => f.MemberNumber == TxtMemberId.Text);
                if (mem == null)
                {
                    MessageBox.Show("Axtardığınız üzv tapılmadı!");
                    TxtMemberFullName.Clear();
                    TxtMemberId.Clear();

                }else if(mem.MemberStatus == false)
                {
                    MessageBox.Show("Axtardığınız üzv silinmişdir!");
                    TxtMemberFullName.Clear();
                    TxtMemberId.Clear();
                }
                else
                {
                    foreach (Member names in Member)
                    {
                        TxtMemberFullName.Text = names.Id + "-" + names.MemberName;
                    }
                }

            }
        }

        //Kitablarin ada gore axtarilmasi 
        private void BtnSearchBook_Click(object sender, EventArgs e)
        {
            CmbBookList.Items.Clear();

            var bookslists = db.BookLists.Where(m => m.Name.Contains(TxtBookName.Text) && m.BookDelete == true);

            List<BookList> books = db.BookLists.Where(i => DbFunctions.Like(TxtBookName.Text, "%Name%")).ToList();

            //Inputun yoxlanilmasi
            if (string.IsNullOrEmpty(TxtBookName.Text))
            {
                MessageBox.Show("Kitabın adını yazın");
            }

            if (books == null)
            {
                MessageBox.Show("Axtardığınız kitab tapılmadı");
            }
            else
            {
                //Tapilan kitab adlarinin comboboxsa doldurulmasi
                foreach (BookList item in bookslists)
                {
                    CmbBookList.Items.Add(item.Id + "-" + item.Name);
                }
            }
        }

        //Kitabin veziyyetinin combobox`a doldurulmasi
        private void FillBookStatus()
        {
            foreach (BookStatu status in db.BookStatus.ToList())
            {
                CmbBookStatus.Items.Add(status.Id + "-" + status.Status);
            }
        }

        //Tehvil verilen kitablarin Dgv`ya doldurulmasi
        private void FillGivenBooks()
        {
            DgvGivenBooksList.Rows.Clear();

            foreach (Models.ReservedBook table in db.ReservedBooks.ToList())
            {
                if(table.ReturnTime == null)
                {
                    DgvGivenBooksList.Rows.Add(table.Id.ToString(), table.Member.MemberName, table.Member.MemberNumber, table.BookList.Name, table.StartTime.ToString("dd/MM/yyyy"), table.EndTime.ToString("dd/MM/yyyy"), table.BookStatu.Status, table.User.UserName);

                }
            }

        }

        //Uzuvlere kitabi tehvil vermek
        private void BtnGetBook_Click(object sender, EventArgs e)
        {
            int memId = Convert.ToInt32(TxtMemberFullName.Text.ToString().Split('-')[0]);
            int bookId = Convert.ToInt32(CmbBookList.SelectedItem.ToString().Split('-')[0]);
            int statusId = Convert.ToInt32(CmbBookStatus.SelectedItem.ToString().Split('-')[0]);
            int bookCount = db.ReservedBooks.Where(b => bookId == b.BookList.Id && b.ReturnTime == null).ToList().Count();

            //Qaytarilmamish kitabin sayinin 3den boyuk olub olmadigini yoxlamaq
            var result = db.ReservedBooks.Where(b => memId == b.MemberId && b.ReturnTime == null).ToList().Count();
            if (result <= 2)
            {
                //Inputlarin yoxlanilmasi
                if ((string.IsNullOrEmpty(TxtMemberFullName.Text)) || (string.IsNullOrEmpty(CmbBookList.Text)) || (string.IsNullOrEmpty(CmbBookStatus.Text)))
                {
                    MessageBox.Show("Boşluqları doldurun!");
                    return;
                }

                //Kitabin hazirda olub olmamagini yoxlamaq
                if(db.BookLists.Find(bookId).Count - bookCount <= 0)
                {
                    MessageBox.Show("Bu kitab hal-hazırda bitmişdir!");
                    return;
                }



                //database`e elave etmek
                Models.ReservedBook res = new Models.ReservedBook
                    {
                        MemberId = memId,
                        BooksId = bookId,
                        StatusId = statusId,
                        UserId = sentUser.Id,
                        StartTime = DateTime.Now,
                        EndTime = DateTime.Now.AddMonths(1),

                    };

                    db.ReservedBooks.Add(res);
                    db.SaveChanges();

                    FillGivenBooks();
                }
                else
                {
                    MessageBox.Show("Seçilən üzv artıq 3 kitab götürmüşdür!");
                }
        }

        //Axtarish etmek
        private void BtnSearch_Click(object sender, EventArgs e)
        {
         //Ada gore axtarmaq
         if (CheckName.Checked == true)
            {
                
                DgvGivenBooksList.Rows.Clear();

                var members = db.ReservedBooks.Where(m => m.Member.MemberName.Contains(TxtName.Text) && m.ReturnTime == null);

                if (!string.IsNullOrEmpty(TxtName.Text))
                {
                    if (members != null)
                    {
                        foreach (var search in members)
                        {
                            DgvGivenBooksList.Rows.Add(search.Id.ToString(), search.Member.MemberName, search.Member.MemberNumber, search.BookList.Name, search.StartTime.ToString("dd/MM/yyyy"), search.EndTime.ToString("dd/MM/yyyy"), search.BookStatu.Status, search.User.UserName);
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
            
         //Kitab adina gore axtarmaq
            if (checkBookName.Checked == true)
            {

                DgvGivenBooksList.Rows.Clear();

                var members = db.ReservedBooks.Where(m => m.BookList.Name.Contains(TxtSearchBook.Text) && m.ReturnTime == null);

                if (!string.IsNullOrEmpty(TxtSearchBook.Text))
                {
                    if (members != null)
                    {
                        foreach (var search in members)
                        {
                            DgvGivenBooksList.Rows.Add(search.Id.ToString(), search.Member.MemberName, search.Member.MemberNumber, search.BookList.Name, search.StartTime.ToString("dd/MM/yyyy"), search.EndTime.ToString("dd/MM/yyyy"), search.BookStatu.Status, search.User.UserName);
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

            //Verilme tarixine gore axtarmaq
            if (checkGiven.Checked == true)
            {
                DgvGivenBooksList.Rows.Clear();

                var startTime = db.ReservedBooks.Where(m => m.StartTime == DtpGivenTime.Value.Date && m.ReturnTime == null);
                if (startTime != null)
                {
                    foreach (var giveTime in startTime)
                    {
                        DgvGivenBooksList.Rows.Add(giveTime.Id.ToString(), giveTime.Member.MemberName, giveTime.Member.MemberNumber, giveTime.BookList.Name, giveTime.StartTime.ToString("dd/MM/yyyy"), giveTime.EndTime.ToString("dd/MM/yyyy"), giveTime.BookStatu.Status, giveTime.User.UserName);
                    }
                }
                else
                {
                    MessageBox.Show("Axtardığınız tarixə uyğun nəticə tapılmadı!");
                }
            }

         //Qaytarilma tarixine gore axtarmaq
         if (checkReturn.Checked == true)
            {
                DgvGivenBooksList.Rows.Clear();

                var endTime = db.ReservedBooks.Where(m => m.EndTime == DtpReturnTime.Value.Date && m.ReturnTime == null);
                if (endTime != null)
                {
                    foreach (var returnTime in endTime)
                    {
                        DgvGivenBooksList.Rows.Add(returnTime.Id.ToString(), returnTime.Member.MemberName, returnTime.Member.MemberNumber, returnTime.BookList.Name, returnTime.StartTime.ToString("dd/MM/yyyy"), returnTime.EndTime.ToString("dd/MM/yyyy"), returnTime.BookStatu.Status, returnTime.User.UserName);
                    }
                }
                else
                {
                    MessageBox.Show("Axtardığınız tarixə uyğun nəticə tapılmadı!");
                }
            }

         //Uzv nomresine gore axtarmaq
         if (checkId.Checked == true)
            {
                DgvGivenBooksList.Rows.Clear();

                var memberNumber = db.ReservedBooks.Where(m => m.Member.MemberNumber.Contains(TxtMemberNumber.Text) && m.ReturnTime == null);

                if (!string.IsNullOrEmpty(TxtMemberNumber.Text))
                {
                    if (memberNumber != null)
                    {
                        foreach (var numbers in memberNumber)
                        {
                            DgvGivenBooksList.Rows.Add(numbers.Id.ToString(), numbers.Member.MemberName, numbers.Member.MemberNumber, numbers.BookList.Name, numbers.StartTime.ToString("dd/MM/yyyy"), numbers.EndTime.ToString("dd/MM/yyyy"), numbers.BookStatu.Status, numbers.User.UserName);
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

        //Axtarışı yalnız 1 inputa görə axtarmaq/yalniz 1 checkbox seche bilmek
        #region
        private void CheckName_CheckedChanged(object sender, EventArgs e)
        {
            checkGiven.Checked = false;
            checkReturn.Checked = false;
            checkId.Checked = false;
            checkBookName.Checked = false;
        }

        private void checkBookName_CheckedChanged(object sender, EventArgs e)
        {
            CheckName.Checked = false;
            checkGiven.Checked = false;
            checkReturn.Checked = false;
            checkId.Checked = false;
        }

        private void checkGiven_CheckedChanged(object sender, EventArgs e)
        {
            CheckName.Checked = false;
            checkReturn.Checked = false;
            checkId.Checked = false;
            checkBookName.Checked = false;
        }

        private void checkReturn_CheckedChanged(object sender, EventArgs e)
        {
            CheckName.Checked = false;
            checkGiven.Checked = false;
            checkId.Checked = false;
            checkBookName.Checked = false;
        }

        private void checkId_CheckedChanged(object sender, EventArgs e)
        {
            CheckName.Checked = false;
            checkGiven.Checked = false;
            checkReturn.Checked = false;
            checkBookName.Checked = false;
        }
        #endregion

        //Axtarishi refresh etmek
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            //Inputlarin ve checkboxlarin ichini temizlemek
            TxtName.Clear();
            TxtMemberNumber.Clear();
            CheckName.Checked = false;
            checkReturn.Checked = false;
            checkGiven.Checked = false;
            checkId.Checked = false;
            FillGivenBooks();
        }

        //Kitabi tehvil vermek
        private void DgvGivenBooksList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DgvGivenBooksList.Rows[e.RowIndex].Cells[0].Value.ToString());
            SelectedReserve = db.ReservedBooks.Find(id);

            TxtMemberFullName.Text = SelectedReserve.Member.Id+ "-" +SelectedReserve.Member.MemberName;
            TxtMemberId.Text = SelectedReserve.Member.MemberNumber;
            CmbBookList.Text = SelectedReserve.BookList.Id+ "-" +SelectedReserve.BookList.Name;
            CmbBookStatus.Text = SelectedReserve.BookStatu.Id + "-" + SelectedReserve.BookStatu.Status;
            DateTime td = DateTime.Now.Date;
            DateTime dt = SelectedReserve.EndTime.Date;
            int a = (td - dt).Days;

            if(a < 0)
            {
                TxtDelayedDays.Text =Convert.ToString(0);
            }
            else
            {
                TxtDelayedDays.Text = a.ToString();
            }
            LblId.Text = id.ToString();

            LblDayCount.Visible = true;
            TxtDelayedDays.Visible = true;
            LblFinePrice.Visible = true;
            NumFinePrice.Visible = true;
            BtnTakeBook.Visible = true;
            BtnDeleteReserve.Visible = true;
            BtnGetBook.Visible = false;


        }

        //Kitabi tehvil almaq
        private void BtnTakeBook_Click(object sender, EventArgs e)
        {
            int ReservedId = Convert.ToInt32(LblId.Text);
            int statusId = Convert.ToInt32(CmbBookStatus.SelectedItem.ToString().Split('-')[0]);
            SelectedReserve = db.ReservedBooks.Find(ReservedId);

            SelectedReserve.ReturnTime = DateTime.Now;
            SelectedReserve.FinePrice = NumFinePrice.Value;
            SelectedReserve.StatusId = statusId;
        
            db.SaveChanges();

            MessageBox.Show("Kitab təhvil alındı");
            FillGivenBooks();

        }

        //Inputlari sifirlamaq
        private void Reset()
        {
            LblDayCount.Visible = false;
            TxtDelayedDays.Visible = false;
            LblFinePrice.Visible = false;
            NumFinePrice.Visible = false;
            BtnTakeBook.Visible = false;
            BtnDeleteReserve.Visible = false;
            BtnGetBook.Visible = true;
            TxtMemberId.Clear();
            TxtMemberFullName.Clear();
            TxtBookName.Clear();
            CmbBookList.Text = "";
            CmbBookStatus.SelectedIndex = -1;
            CmbBookList.Items.Clear();
        }

        //Forma klik edende yeniden bezi button ve inputlarin visible`i true veya false olmagi
        private void MainMenu_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Tehvil verilen kitabi silmek
        private void BtnDeleteReserve_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Silməyə əminsiniz mi?", "Silmə", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                var id = db.ReservedBooks.FirstOrDefault(m => m.Id == SelectedReserve.Id);

                db.ReservedBooks.Remove(id);
                db.SaveChanges();

                FillGivenBooks();
                Reset();
            }
        }
    };
}

 
        

