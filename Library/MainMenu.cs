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
    public partial class MainMenu : Form
    {
        LibraryEntities db = new LibraryEntities();
        public User sentUser;
        public MainMenu(User user)
        {
            sentUser = user;
            InitializeComponent();
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

        private void PbAddBook_Click(object sender, EventArgs e)
        {
            AddBooks BooksMenu = new AddBooks(sentUser);

            BooksMenu.ShowDialog();
        }

        
    }    
}
