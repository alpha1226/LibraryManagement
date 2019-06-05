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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string MainForm_value;
        public string Passvalue
        {
            get { return this.MainForm_value; }
            set { this.MainForm_value = value; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            userlabel.Text = Passvalue;
        }
    }
}
