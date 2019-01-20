﻿using System;
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
                    MessageBox.Show("yoxdu");
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

            var bookslists = db.BookLists.Where(m => m.Name.Contains(TxtBookName.Text));

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

                //databasee elave etmek
                Models.ReservedBook res = new Models.ReservedBook
                {
                    MemberId = memId,
                    BooksId = bookId,
                    StatusId = statusId,
                    UserId = sentUser.Id,
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(30)
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
            if(CheckName.Checked == true)
            {
                if (!string.IsNullOrEmpty(TxtName.Text))
                {
                    DgvGivenBooksList.Rows.Clear();
                    var members = db.ReservedBooks.Where(m => m.Member.MemberName.Contains(TxtName.Text));

                    foreach (var search in members)
                    {
                        DgvGivenBooksList.Rows.Add(search.Id.ToString(), search.Member.MemberName, search.Member.MemberNumber, search.BookList.Name, search.StartTime.ToString("dd/MM/yyyy"), search.EndTime.ToString("dd/MM/yyyy"), search.BookStatu.Status, search.User.UserName);

                    }
                }
                else
                {
                    MessageBox.Show("Axtardığınız üzvün adını yazın!");
                }
               
            }

            //Verilme tarixine gore axtarmaq
            //if (checkGiven.Checked == true)
            //{
            //    DgvGivenBooksList.Rows.Clear();
            //    DateTime timeStart = DtpGivenTime.Value;
            //    var startTime = db.ReservedBooks.Where(m => timeStart = m.StartTime);

            //    foreach (var search in startTime)
            //    {
            //        DgvGivenBooksList.Rows.Add(search.Id.ToString(), search.Member.MemberName, search.Member.MemberNumber, search.BookList.Name, search.StartTime.ToString("dd/MM/yyyy"), search.EndTime.ToString("dd/MM/yyyy"), search.BookStatu.Status, search.User.UserName);

            //    }

            //}
        }
    };
}

 
        

