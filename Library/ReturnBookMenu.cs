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
    public partial class ReturnBookMenu : Form
    {
        LibraryEntities db = new LibraryEntities();
        public User sentUser;
        private Models.ReservedBook SelectedReserve;

        public ReturnBookMenu(User user)
        {
            sentUser = user;
            InitializeComponent();
            FillReturnBooks();
        }

        private void FillReturnBooks()
        {
            DgvGivenBooksList.Rows.Clear();

            foreach (Models.ReservedBook table in db.ReservedBooks.ToList())
            {
                if (table.ReturnTime != null)
                {
                    DgvGivenBooksList.Rows.Add(table.Id.ToString(), table.Member.MemberName, table.Member.MemberNumber, table.BookList.Name, table.StartTime.ToString("dd/MM/yyyy"), table.EndTime.ToString("dd/MM/yyyy"), table.ReturnTime?.ToString("dd/MM/yyyy"), table.BookStatu.Status,table.FinePrice.ToString("#.##" + " " + "AZN"), table.User.UserName);

                }
            }
            
            //decimal total = DgvGivenBooksList.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[8].Value.ToString().Split(' ')[0]));
            //MessageBox.Show(total.ToString());

        }

    }
}
