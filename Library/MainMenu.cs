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

        public MainMenu(User user)
        {
            sentUser = user;
            InitializeComponent();
            FillBookStatus();
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
    
                Member mem = db.Members.FirstOrDefault(f=> f.MemberNumber ==  TxtMemberId.Text);
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

            List<BookList>   boks = db.BookLists.Where(i => DbFunctions.Like(TxtBookName.Text , "%Name%")).ToList();

            //Inputun yoxlanilmasi
            if (string.IsNullOrEmpty(TxtBookName.Text))
            {
                MessageBox.Show("Kitabın adını yazın");
            }

            if (boks==null)
            {
                MessageBox.Show("Axtardığınız kitab tapılmadı");
            }
            else
            {
                //Tapilan kitab adlarinin comboboxsa doldurulmasi
                foreach (BookList item in bookslists)
                {
                    CmbBookList.Items.Add (item.Id + "-" + item.Name);
                }
            }
        }

        private void FillBookStatus()
        {
            foreach (BookStatu status in db.BookStatus.ToList() )
            {
                CmbBookStatus.Items.Add(status.Id + "-" + status.Status);
            }
        }
    }    
}
