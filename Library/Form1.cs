using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;

namespace Library
{
    
    public partial class Form1 : Form
    {
        LibraryEntities db = new LibraryEntities();

        public Form1()
        {
            InitializeComponent();
        }


        //Login etmek
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            //Inputlarin  bosh olmasini yoxlamaq
            if ((string.IsNullOrEmpty(TxtEmail.Text)) || (string.IsNullOrEmpty(TxtPassword.Text)))
            {
                MessageBox.Show("Boşluq buraxmayın");
                TxtEmail.Clear();
                TxtPassword.Clear();
                return;
            }
            Models.User user = new Models.User();
            user = db.Users.FirstOrDefault(f => f.Email == TxtEmail.Text);

            //eger bu emailde istifadechi yoxdursa
            
            if (user == null)
            {
                MessageBox.Show("Bu adda istifadəçi tapılmadı.Yenidən yoxlayın!");
                TxtEmail.Clear();
                TxtPassword.Clear();
            }

            //if(user.UserStatus == false)
            //{
            //    MessageBox.Show("Bu adda istifadəçi artıq silinmişdir!");
            //    TxtEmail.Clear();
            //    TxtPassword.Clear();
            //}

            //eger bu emailde istifadechi varsa
            else
            {
                //Shifre ve Email duzdur
                if(Extensions.hasher(TxtPassword.Text) == user.Password)
                {
                    MainMenu mainMenu = new MainMenu(user);
                    this.Hide();
                    mainMenu.ShowDialog();
                    this.Close();
                }

                //Shifre yanlisdir
                else
                {
                    MessageBox.Show("E-poçt və ya şifrə yanlışdır");
                    TxtEmail.Clear();
                    TxtPassword.Clear();
                }

            }
        }
    }
}
