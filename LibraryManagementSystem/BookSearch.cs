using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BookSearch : Form
    {
        public BookSearch()
        {
            InitializeComponent();
        }

        private string bookname;
        public string PassBookname
        {
            get { return this.bookname; }
            set { this.bookname = value; }
        }

        private string UserID;
        public string PassUserID
        {
            get { return this.UserID; }
            set { this.UserID = value; }
        }


        private void BookSearch_Load(object sender, EventArgs e)
        {
            textBox1.Text = bookname;
        }
    }
}
