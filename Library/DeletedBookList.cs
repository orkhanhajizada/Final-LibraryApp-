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
    public partial class DeletedBookList : Form
    {
        LibraryEntities db = new LibraryEntities();

        public User SentUser;

        private Models.BookList SelectedDelete;

        public DeletedBookList(User user)
        {
            InitializeComponent();
            FillDeletedBooks();
        }

        //Silinen Kitablarin  doldurulmasi
        private void FillDeletedBooks()
        {
            DgvDeletedBookList.Rows.Clear();

            foreach (Models.BookList table in db.BookLists.ToList())
            {
                if (table.BookDelete == false)
                {
                    DgvDeletedBookList.Rows.Add(table.Id, table.Name, table.Count, table.CreateTime.ToString("dd/MM/yyyy"), table.User.UserName);

                }
            }
        }

        //Kitabi berpa etmek
        private void DgvDeletedBookList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int DeleteBook = Convert.ToInt32(DgvDeletedBookList.Rows[e.RowIndex].Cells[0].Value.ToString());

            LblId.Text = DeleteBook.ToString();
        }

        private void BtnRecoveryBook_Click(object sender, EventArgs e)
        {
            if (LblId.Text != "")
            {
                int BookId = Convert.ToInt32(LblId.Text);

                SelectedDelete = db.BookLists.Find(BookId);
                SelectedDelete.BookDelete = true;

                db.SaveChanges();
               
                MessageBox.Show("Kitab bərpa edildi");
                    if (System.Windows.Forms.Application.OpenForms["AddBooks"] != null)
                    {
                        (System.Windows.Forms.Application.OpenForms["AddBooks"] as AddBooks).DgvBookList.Rows.Clear();

                        foreach (Models.BookList table in db.BookLists.ToList())
                        {
                        if (table.BookDelete == true)
                        {
                        (System.Windows.Forms.Application.OpenForms["AddBooks"] as AddBooks).DgvBookList.Rows.Add(table.Id, table.Name, table.Count, table.CreateTime.ToString("dd/MM/yyyy"), table.User.UserName);
                        }
                    }
                }
                FillDeletedBooks();
                LblId.Text = "";
            }
            else
            {
                MessageBox.Show("Kitabı seçin");
            }
        }

    }
}
