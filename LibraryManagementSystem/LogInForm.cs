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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                MessageBox.Show("admin Login");
                this.Visible = false;
                MainForm form = new MainForm();
                form.Passvalue = textBox1.Text;
                form.ShowDialog();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SignUp signForm = new SignUp();
            signForm.ShowDialog();
        }
    }
}
