﻿using System;
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
    public partial class AddBooks : Form
    {

        public LibraryEntities db = new LibraryEntities();

        private Models.BookList SelectedBook;
        public User SentUser;


        public AddBooks(User user)
        {
            SentUser = user;
            InitializeComponent();
            FillBooks();
        }

        //Kitablarin  doldurulmasi
        private void FillBooks()
        {
            DgvBookList.Rows.Clear();

            foreach (Models.BookList table in db.BookLists.ToList())
            {
                if (table.BookDelete == true)
                {
                    DgvBookList.Rows.Add(table.Id, table.Name, table.Count, table.CreateTime.ToString("dd/MM/yyyy"), table.User.UserName);

                }
            }
        }

        //Kitab elave etmek
        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            //Inputlarin yoxlanilmasi
            if ((string.IsNullOrEmpty(TxtName.Text)))
            {
                MessageBox.Show("Boşluqları doldurun!");
                return;
            }

            if (db.BookLists.FirstOrDefault(t => t.Name == TxtName.Text) != null)
            {
                MessageBox.Show("Bu kitab artıq mövcüddur");
                return;
            }

            Models.BookList ListBook = new Models.BookList
            {
                Name = TxtName.Text,
                Count = Convert.ToInt32(NumCount.Value),
                CreateTime = DateTime.Now,
                UserId = SentUser.Id,
                BookDelete = true


            };
            db.BookLists.Add(ListBook);
            db.SaveChanges();

        }
        
        //Inputlari sifirlamaq
        private void Reset()
        {
            TxtName.Clear();
            NumCount.Value = 1;
            FillBooks();

            BtnDeleteBook.Visible = false;
            BtnAddBook.Visible = true;
            BtnUpdateBook.Visible = false;
        }

        //Datagridview`dan kitab sechmek
        private void DgvBookList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DgvBookList.Rows[e.RowIndex].Cells[0].Value.ToString());

            SelectedBook = db.BookLists.Find(id);

            TxtName.Text = SelectedBook.Name;
            NumCount.Value = SelectedBook.Count;

            BtnDeleteBook.Visible = true;
            BtnAddBook.Visible = false;
            BtnUpdateBook.Visible = true;
        }

        //Kitabi update etmek
        private void BtnUpdateBook_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(TxtName.Text)))
            {
                MessageBox.Show("Boşluqları doldurun!");
                return;
            }

            SelectedBook.Name = TxtName.Text;
            SelectedBook.Count = Convert.ToInt32(NumCount.Value);

            db.SaveChanges();

            if (System.Windows.Forms.Application.OpenForms["MainMenu"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["MainMenu"] as MainMenu).DgvGivenBooksList.Rows.Clear();
                (System.Windows.Forms.Application.OpenForms["MainMenu"] as MainMenu).db = db;

                foreach (Models.ReservedBook table in db.ReservedBooks.ToList())
                {
                    if (table.ReturnTime == null)
                    {
                        (System.Windows.Forms.Application.OpenForms["MainMenu"] as MainMenu).DgvGivenBooksList.Rows.Add(table.Id.ToString(), table.Member.MemberName, table.Member.MemberNumber, table.BookList.Name, table.StartTime.ToString("dd/MM/yyyy"), table.EndTime.ToString("dd/MM/yyyy"), table.BookStatu.Status, table.User.UserName);
                    }
                }

                FillBooks();
                Reset();
            }
            FillBooks();

            Reset();
        }

        //Kitabi silmek
        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            var result = SelectedBook.ReservedBooks.Where(b => SelectedBook.Id == b.BooksId && b.ReturnTime == null).ToList().Count();

            if (result <= 0)
            {
                DialogResult r = MessageBox.Show("Silməyə əminsiniz mi?", "Silmə", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    SelectedBook.BookDelete = false;

                    db.SaveChanges();

                    Reset();
                }
            }
            else
            {
                MessageBox.Show("Bu kitab hazırda qaytarılmadığı üçün silmək mümkün deyil");
            }
            
        }

        //Kitab axtarmaq
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DgvBookList.Rows.Clear();

            var book = db.BookLists.Where(m => m.Name.Contains(TxtSearchBook.Text));

            if (!string.IsNullOrEmpty(TxtSearchBook.Text))
            {
                if (book != null)
                {
                    foreach (var search in book)
                    {
                        if (search.BookDelete == true)
                        {
                            DgvBookList.Rows.Add(search.Id, search.Name, search.Count, search.CreateTime.ToString("dd/MM/yyyy"), search.User.UserName);

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

        //Axtarishi reflesh etmek
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            TxtSearchBook.Clear();
            FillBooks();
        }

        //Silinen kitablar menusunu achmaq
        private void BtnDeletedBooks_Click(object sender, EventArgs e)
        {
            DeletedBookList DeletedBooks = new DeletedBookList(SentUser);

            DeletedBooks.ShowDialog();
        }
    }
}
