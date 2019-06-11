using MySql.Data.MySqlClient;
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
        MySqlConnection LoginConn =
            new MySqlConnection("Server=localhost;Database=lms;Uid=root;Pwd=1234;"); // 다른 컴퓨터에서도 해당 정보를 맞춰놔야함
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
                MainForm mainform = new MainForm();
                mainform.Passvalue = textBox1.Text;
                mainform.ShowDialog();
            }
            else
            {
                string Query = "update membertbl set UserLoginDate='" + DateTime.Now.ToString() + "' where UserID='" + textBox1.Text + "'&&UserPW='" + textBox2.Text + "';";

                MessageBox.Show(Query);//쿼리 확인

                LoginConn.Open();
                MySqlCommand command = new MySqlCommand(Query, LoginConn);


                try//예외 처리
                {
                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("로그인 완료");
                        this.Visible = false;
                        MainForm form = new MainForm();
                        form.Passvalue = textBox1.Text;
                        form.ShowDialog();
                        SeatChoice scform = new SeatChoice();
                        scform.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("로그인 실패");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (LoginConn.State == ConnectionState.Open)
                {
                    LoginConn.Close();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SignUp signForm = new SignUp();
            signForm.ShowDialog();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
        }
    }
}
