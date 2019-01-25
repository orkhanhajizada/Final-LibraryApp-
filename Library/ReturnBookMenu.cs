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
            SumFine();
        }

        //Qaytarilan kitablari datagridview`a doldurmaq
        private void FillReturnBooks()
        {
            DgvGivenBooksList.Rows.Clear();

            foreach (Models.ReservedBook table in db.ReservedBooks.ToList())
            {
                if (table.ReturnTime != null)
                {
                    DgvGivenBooksList.Rows.Add(table.Id.ToString(), table.Member.MemberName, table.Member.MemberNumber, table.BookList.Name, table.StartTime.ToString("dd/MM/yyyy"), table.EndTime.ToString("dd/MM/yyyy"), table.ReturnTime?.ToString("dd/MM/yyyy"), table.BookStatu.Status,table.FinePrice.ToString("0.00" + " " + "AZN"), table.User.UserName);
                    SumFine();
                }
            }
        }

        //Axtarish etmek
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //Ada gore axtarmaq
            if (CheckName.Checked == true)
            {
                DgvGivenBooksList.Rows.Clear();

                var members = db.ReservedBooks.Where(m => m.Member.MemberName.Contains(TxtName.Text));

                if (!string.IsNullOrEmpty(TxtName.Text))
                {
                    if (members != null)
                    {
                        foreach (var search in members)
                        {
                            if(search.ReturnTime != null)
                            {
                                DgvGivenBooksList.Rows.Add(search.Id.ToString(), search.Member.MemberName, search.Member.MemberNumber, search.BookList.Name, search.StartTime.ToString("dd/MM/yyyy"), search.EndTime.ToString("dd/MM/yyyy"), search.ReturnTime?.ToString("dd/MM/yyyy"), search.BookStatu.Status, search.FinePrice.ToString("0.00" + " " + "AZN"), search.User.UserName);
                                SumFine();
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

            //Kitab adina gore axtarish
            if (checkBookName.Checked == true)
            {

                DgvGivenBooksList.Rows.Clear();

                var members = db.ReservedBooks.Where(m => m.BookList.Name.Contains(TxtSearchBook.Text));

                if (!string.IsNullOrEmpty(TxtSearchBook.Text))
                {
                    if (members != null)
                    {
                        foreach (var search in members)
                        {
                            if (search.ReturnTime != null)
                            {
                                DgvGivenBooksList.Rows.Add(search.Id.ToString(), search.Member.MemberName, search.Member.MemberNumber, search.BookList.Name, search.StartTime.ToString("dd/MM/yyyy"), search.EndTime.ToString("dd/MM/yyyy"), search.ReturnTime?.ToString("dd/MM/yyyy"), search.BookStatu.Status, search.FinePrice.ToString("0.00" + " " + "AZN"), search.User.UserName);
                                SumFine();
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
                    MessageBox.Show("Axtardığınız kitabın adını yazın!");
                }


            }

            //Verilme tarixine gore axtarmaq
            if (checkGivenFrom.Checked == true)
            {
                DgvGivenBooksList.Rows.Clear();

                var startTime = db.ReservedBooks.Where(m => m.StartTime >= DtpGivenTimeFrom.Value.Date && m.StartTime <= DtpGivenTimeTo.Value.Date);
                if (startTime != null)
                {
                    foreach (var giveTime in startTime)
                    {
                        if (giveTime.ReturnTime != null)
                        {
                            DgvGivenBooksList.Rows.Add(giveTime.Id.ToString(), giveTime.Member.MemberName, giveTime.Member.MemberNumber, giveTime.BookList.Name, giveTime.StartTime.ToString("dd/MM/yyyy"), giveTime.EndTime.ToString("dd/MM/yyyy"), giveTime.ReturnTime?.ToString("dd/MM/yyyy"), giveTime.BookStatu.Status, giveTime.FinePrice.ToString("0.00" + " " + "AZN"), giveTime.User.UserName);
                            SumFine();
                        }
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

                var endTime = db.ReservedBooks.Where(m =>  m.EndTime >= DtpReturnTimeFrom.Value.Date && m.EndTime <= DtpReturnTimeTo.Value.Date);
                if (endTime != null)
                {
                    foreach (var returnTime in endTime)
                    {
                        if (returnTime.ReturnTime != null)
                        {
                            DgvGivenBooksList.Rows.Add(returnTime.Id.ToString(), returnTime.Member.MemberName, returnTime.Member.MemberNumber, returnTime.BookList.Name, returnTime.StartTime.ToString("dd/MM/yyyy"), returnTime.EndTime.ToString("dd/MM/yyyy"), returnTime.ReturnTime?.ToString("dd/MM/yyyy"), returnTime.BookStatu.Status, returnTime.FinePrice.ToString("0.00" + " " + "AZN"), returnTime.User.UserName);
                            SumFine();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Axtardığınız tarixə uyğun nəticə tapılmadı!");
                }
            }

            //Qaytarilan tarixine gore axtarmaq
            if (CheckEnd.Checked == true)
            {
                DgvGivenBooksList.Rows.Clear();

                var returnedTime = db.ReservedBooks.Where(m => m.ReturnTime >= DtpEndTimeFrom.Value.Date && m.ReturnTime <= DtpEndTimeTo.Value.Date);
                if (returnedTime != null)
                {
                    foreach (var ReturnBookTime in returnedTime)
                    {
                        if (ReturnBookTime.ReturnTime != null)
                        {
                            DgvGivenBooksList.Rows.Add(ReturnBookTime.Id.ToString(), ReturnBookTime.Member.MemberName, ReturnBookTime.Member.MemberNumber, ReturnBookTime.BookList.Name, ReturnBookTime.StartTime.ToString("dd/MM/yyyy"), ReturnBookTime.EndTime.ToString("dd/MM/yyyy"), ReturnBookTime.ReturnTime?.ToString("dd/MM/yyyy"), ReturnBookTime.BookStatu.Status, ReturnBookTime.FinePrice.ToString("0.00" + " " + "AZN"), ReturnBookTime.User.UserName);
                            SumFine();
                        }
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

                var memberNumber = db.ReservedBooks.Where(m => m.Member.MemberNumber.Contains(TxtMemberNumber.Text));

                if (!string.IsNullOrEmpty(TxtMemberNumber.Text))
                {
                    if (memberNumber != null)
                    {
                        foreach (var numbers in memberNumber)
                        {
                            if (numbers.ReturnTime != null)
                            {
                                DgvGivenBooksList.Rows.Add(numbers.Id.ToString(), numbers.Member.MemberName, numbers.Member.MemberNumber, numbers.BookList.Name, numbers.StartTime.ToString("dd/MM/yyyy"), numbers.EndTime.ToString("dd/MM/yyyy"), numbers.ReturnTime?.ToString("dd/MM/yyyy"), numbers.BookStatu.Status, numbers.FinePrice.ToString("0.00" + " " + "AZN"), numbers.User.UserName);
                                SumFine();
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
            checkGivenFrom.Checked = false;
            checkReturn.Checked = false;
            checkId.Checked = false;
            checkBookName.Checked = false;
            CheckEnd.Checked = false;
        }

        private void checkBookName_CheckedChanged(object sender, EventArgs e)
        {
            CheckName.Checked = false;
            checkGivenFrom.Checked = false;
            checkReturn.Checked = false;
            checkId.Checked = false;
            CheckEnd.Checked = false;
        }

        private void checkGiven_CheckedChanged(object sender, EventArgs e)
        {
            CheckName.Checked = false;
            checkReturn.Checked = false;
            checkId.Checked = false;
            checkBookName.Checked = false;
            CheckEnd.Checked = false;
        }

        private void checkReturn_CheckedChanged(object sender, EventArgs e)
        {
            CheckName.Checked = false;
            checkGivenFrom.Checked = false;
            checkId.Checked = false;
            checkBookName.Checked = false;
            CheckEnd.Checked = false;
        }

        private void checkId_CheckedChanged(object sender, EventArgs e)
        {
            CheckName.Checked = false;
            checkGivenFrom.Checked = false;
            checkReturn.Checked = false;
            checkBookName.Checked = false;
            CheckEnd.Checked = false;
        }

        private void CheckEnd_CheckedChanged(object sender, EventArgs e)
        {
            CheckName.Checked = false;
            checkGivenFrom.Checked = false;
            checkReturn.Checked = false;
            checkBookName.Checked = false;
            checkId.Checked = false;
        }

        #endregion

        //Axtarishi Refresh etmek
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            //Inputlarin ve checkboxlarin ichini temizlemek
            TxtName.Clear();
            TxtMemberNumber.Clear();
            TxtSearchBook.Clear();
            CheckName.Checked = false;
            checkBookName.Checked = false;
            checkReturn.Checked = false;
            checkGivenFrom.Checked = false;
            checkId.Checked = false;
            FillReturnBooks();
            SumFine();
        }

        //Cerime mebleginin cemlenmesi
        private void SumFine()
        {
            decimal sum = 0;
            for (int i = 0; i < DgvGivenBooksList.Rows.Count-1; ++i)
            {
                sum += Convert.ToDecimal(DgvGivenBooksList.Rows[i].Cells[8].Value.ToString().Split(' ')[0]);
            }

            LblTotal.Text = sum.ToString("0.00")+" "+"AZN";
        }
    }
}
