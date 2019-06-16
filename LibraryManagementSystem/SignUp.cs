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

        int IDFlag = 0;
        int PWFlag = 0;

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (IDFlag == 0)
            {
                MessageBox.Show("ID확인버튼을 눌러주세요");
            }
            if (PWFlag == 0)
            {
                MessageBox.Show("PW확인버튼을 눌러주세요");
            }
            if (IDFlag == 2 || PWFlag == 2)
            {
                MessageBox.Show("입력한 정보를 다시한번 확인해주세요");
            }

            if (IDFlag == 1 && PWFlag == 1)
            {

                String logintime = System.DateTime.Now.ToString("yyyy년MM월dd일hh시mm분ss초");
                MessageBox.Show(logintime);
                //칼럼에 추가하는 커리문 insertQuery
                string insertQuery = "INSERT INTO membertbl(UserID,UserPW,UserName,UserBirthday,UserPhoneNumber,UserSubject,UserAddress,UserLoginDate) VALUES('"
                    + ID_textBox.Text + "' ,'" + PW_textBox.Text + "','" + Name_textBox.Text + "','" + Birth_textBox.Text + "','" + Phone_textBox.Text + "','" + job_textBox.Text + "','" + Address_textBox.Text + "','" + logintime + "')";

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
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlconn =
            new MySqlConnection("Server=localhost;Database=lms;Uid=root;Pwd=1234;"); // 다른 컴퓨터에서도 해당 정보를 맞춰놔야함

            MySqlCommand selectCommand = new MySqlCommand();
            selectCommand.Connection = sqlconn;
            DataSet ds = new DataSet();
            Console.WriteLine(ID_textBox.Text);
            MySqlDataAdapter da = new MySqlDataAdapter("select UserID FROM membertbl where UserID='"+ ID_textBox.Text+ "';", sqlconn);
            da.Fill(ds);
            //string[] num;
            int seatindex = 0;
            IDFlag = 1;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine("ID 이미 있음");
                IDFlag = 2;
                MessageBox.Show("아이디가 이미 존재합니다");
            }
            if (IDFlag == 1)
            {
                ID_textBox.Enabled = false;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            PWFlag = 1;
            if (!PW_textBox.Text.Equals(PWCK_textBox.Text))
            {
                PWFlag = 2;
                Console.WriteLine("PW가 이미 있음");
                MessageBox.Show("PW가 일치하지 않습니다");
            }
            if (PWFlag == 1)
            {
                PW_textBox.Enabled = false;
                PWCK_textBox.Enabled = false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ID_textBox.Text = "";
            PW_textBox.Text = "";
            PWCK_textBox.Text = "";
            Name_textBox.Text = "";
            Birth_textBox.Text = "";
            Phone_textBox.Text = "";
            job_textBox.Text = "";
            Address_textBox.Text = "";
        }
    }
}
