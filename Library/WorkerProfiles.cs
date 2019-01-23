using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;

namespace Library
{
    public partial class WorkerProfiles : Form
    {

        LibraryEntities db = new LibraryEntities();
        private Models.User SelectedUser;

        public WorkerProfiles()
        {
            InitializeComponent();
            FillUsers();
        }


        //Email`in yazilishini yoxlamaq uchun metod
        public static bool isEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        //Userlerin doldurulmasi
        private void FillUsers()
        {
            DgvWorkers.Rows.Clear();

            
            foreach (Models.User table in db.Users.ToList())
            {
                if(table.UserStatus == true)
                {
                    DgvWorkers.Rows.Add(table.Id, table.UserName, table.Email, table.Password);
                }
                
            }
        }

        //User elave etmek
        private void BtnAddWorker_Click(object sender, EventArgs e)
        {
            //Inputlarin yoxlanilmasi
            if ((string.IsNullOrEmpty(TxtEmail.Text)) || (string.IsNullOrEmpty(TxtPassword.Text)) || (string.IsNullOrEmpty(TxtPassword.Text)))
            {
                MessageBox.Show("Boşluqları doldurun!");
                return;
            }

            if (db.Users.FirstOrDefault(t => t.Email == TxtEmail.Text) != null)
            {
                MessageBox.Show("Bu e-poçt artıq istifadə olunub!");
                return;
            }

            //Email`i yoxlamaq
            if (isEmail(TxtEmail.Text))
            {
                Models.User worker = new Models.User
                {

                    UserName = TxtName.Text,
                    Email = TxtEmail.Text,
                    Password = Extensions.hasher(TxtPassword.Text),
                    UserStatus = true

                };
                db.Users.Add(worker);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("E-poçt ünvanınız düzgün deyil!");
            }

            FillUsers();
            Reset();
        }

        //Inputlari sifirlamaq
        private void Reset()
        {
            TxtName.Clear();
            TxtEmail.Clear();
            TxtPassword.Clear();


            FillUsers();

            BtnDeleteWorker.Visible = false;
            BtnAddWorker.Visible = true;
            BtnUpdateWorker.Visible = false;
        }

        //Datagridview`dan user sechmek
        private void DgvWorkers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DgvWorkers.Rows[e.RowIndex].Cells[0].Value.ToString());

            SelectedUser = db.Users.Find(id);

            TxtName.Text = SelectedUser.UserName;
            TxtEmail.Text = SelectedUser.Email;
            TxtPassword.Text = SelectedUser.Password;

            BtnDeleteWorker.Visible = true;
            BtnAddWorker.Visible = false;
            BtnUpdateWorker.Visible = true;

            
        }

        //Useri update etmek
        private void BtnUpdateWorker_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(TxtEmail.Text)) || (string.IsNullOrEmpty(TxtPassword.Text)) || (string.IsNullOrEmpty(TxtPassword.Text)))
            {
                MessageBox.Show("Boşluqları doldurun!");
                return;
            }

            SelectedUser.UserName = TxtName.Text;
            SelectedUser.Email = TxtEmail.Text;
            SelectedUser.Password = Extensions.hasher(TxtPassword.Text);

            db.SaveChanges();
            FillUsers();

            Reset();
        }

        //Useri silmek
        private void BtnDeleteWorker_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Silməyə əminsiniz mi?", "Silmə", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                SelectedUser.UserStatus = false;

                db.SaveChanges();

                Reset();
            }
        }

        
    }
    
}
