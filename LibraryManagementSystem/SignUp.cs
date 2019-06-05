using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    public partial class SignUp : Form
    {
        MySqlConnection connection =
            new MySqlConnection("Server=localhost;Database=lms;Uid=root;Pwd=1234;"); // 다른 컴퓨터에서도 해당 정보를 맞춰놔야함

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String logintime = System.DateTime.Now.ToString("yyyy년MM월dd일hh시mm분ss초");
            MessageBox.Show(logintime);
            //칼럼에 추가하는 커리문 insertQuery
            string insertQuery = "INSERT INTO membertbl(UserID,UserPW,UserName,UserBitrhday,UserPhoneNumber,UserSubject,UserAddress,UserLoginDate) VALUES('"
                + ID_textBox.Text + "' ,'" + PW_textBox.Text + "','" + Name_textBox.Text + "','" + Birth_textBox.Text + "','" + Phone_textBox.Text + "','" + job_textBox.Text + "','" + Address_textBox.Text + "','" + logintime +"')";

            MessageBox.Show(insertQuery);//쿼리 확인

            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try//예외 처리
            {
                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("정상적으로 갔다");
                }
                else
                {
                    MessageBox.Show("비정상 이당");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            connection.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
