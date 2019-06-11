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
    public partial class AddBook : Form
    {
        MySqlConnection connection =
            new MySqlConnection("Server=localhost;Database=lms;Uid=root;Pwd=1234;"); // 다른 컴퓨터에서도 해당 정보를 맞춰놔야함
        public AddBook()
        {
            InitializeComponent();
        }


        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BookGroup1.Text = "";
            BookName1.Text = "";
            BookWriter1.Text = "";
            BookPub1.Text = "";
            BookPrice1.Text = "";
            BookNum1.Text = "";
        }

        private void BookPlusBtn_Click(object sender, EventArgs e)
        {

            MessageBox.Show("책 추가");
            if (checkBox1.Checked == true)
            {
                plusBook(BookGroup1.Text.ToString(),BookName1.Text.ToString(),BookWriter1.Text.ToString(),BookPub1.Text.ToString(),int.Parse(BookPrice1.Text.ToString()),int.Parse(BookNum1.Text.ToString()));
            }
            if (checkBox2.Checked == true)
            {
                plusBook(BookGroup2.Text.ToString(), BookName2.Text.ToString(), BookWriter2.Text.ToString(), BookPub2.Text.ToString(), int.Parse(BookPrice2.Text.ToString()), int.Parse(BookNum2.Text.ToString()));
            }
            if (checkBox3.Checked == true)
            {
                plusBook(BookGroup3.Text.ToString(), BookName3.Text.ToString(), BookWriter3.Text.ToString(), BookPub3.Text.ToString(), int.Parse(BookPrice3.Text.ToString()), int.Parse(BookNum3.Text.ToString()));
            }
            if (checkBox4.Checked == true)
            {
                plusBook(BookGroup4.Text.ToString(), BookName4.Text.ToString(), BookWriter4.Text.ToString(), BookPub4.Text.ToString(), int.Parse(BookPrice4.Text.ToString()), int.Parse(BookNum4.Text.ToString()));
            }
            if (checkBox5.Checked == true)
            {
                plusBook(BookGroup5.Text.ToString(), BookName5.Text.ToString(), BookWriter5.Text.ToString(), BookPub5.Text.ToString(), int.Parse(BookPrice5.Text.ToString()), int.Parse(BookNum5.Text.ToString()));
            }
            if (checkBox6.Checked == true)
            {
                plusBook(BookGroup6.Text.ToString(), BookName6.Text.ToString(), BookWriter6.Text.ToString(), BookPub6.Text.ToString(), int.Parse(BookPrice6.Text.ToString()), int.Parse(BookNum6.Text.ToString()));
            }
            if (checkBox7.Checked == true)
            {
                plusBook(BookGroup7.Text.ToString(), BookName7.Text.ToString(), BookWriter7.Text.ToString(), BookPub7.Text.ToString(), int.Parse(BookPrice7.Text.ToString()), int.Parse(BookNum7.Text.ToString()));
            }
            if (checkBox8.Checked == true)
            {
                plusBook(BookGroup8.Text.ToString(), BookName8.Text.ToString(), BookWriter8.Text.ToString(), BookPub8.Text.ToString(), int.Parse(BookPrice8.Text.ToString()), int.Parse(BookNum8.Text.ToString()));
            }
            if (checkBox9.Checked == true)
            {
                plusBook(BookGroup9.Text.ToString(), BookName9.Text.ToString(), BookWriter9.Text.ToString(), BookPub9.Text.ToString(), int.Parse(BookPrice9.Text.ToString()), int.Parse(BookNum9.Text.ToString()));
            }
            if (checkBox10.Checked == true)
            {
                plusBook(BookGroup10.Text.ToString(), BookName10.Text.ToString(), BookWriter10.Text.ToString(), BookPub10.Text.ToString(), int.Parse(BookPrice10.Text.ToString()), int.Parse(BookNum10.Text.ToString()));
            }

        }

        public void plusBook(string group,string bookname,string writer,string pub,int price,int num)
        {
            string bookinsertQuery = "insert into booktbl(BookGroup,BookName,BookWriter,BookPub,BookPrice) values ('"+group+"', '"+bookname+"', '"+writer+"', '"+pub+"', "+price+");";

            MessageBox.Show(bookinsertQuery+"/"+num+"번 실행");//쿼리 확인

            connection.Open();
            for (int i = 1; i < num; i++)
            {
                MySqlCommand command = new MySqlCommand(bookinsertQuery, connection);

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
            }


            connection.Close();
        }
        

        private void Button2_Click(object sender, EventArgs e)
        {
            string PM = sender.ToString().Substring(35);
            if (PM.Equals("+"))
            {
                BookGroup2.Visible = true;
                BookName2.Visible = true;
                BookWriter2.Visible = true;
                BookPub2.Visible = true;
                BookPrice2.Visible = true;
                BookNum2.Visible = true;
                button2.Text = "-";
                button3.Visible = true;
                checkBox2.Visible = true;
            }
            else if (PM.Equals("-"))
            {
                BookGroup2.Text = "";
                BookName2.Text = "";
                BookWriter2.Text = "";
                BookPub2.Text = "";
                BookPrice2.Text = "";
                BookNum2.Text = "";
            }
        }
        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string PM = sender.ToString().Substring(35);
            if (PM.Equals("+"))
            {
                BookGroup3.Visible = true;
                BookName3.Visible = true;
                BookWriter3.Visible = true;
                BookPub3.Visible = true;
                BookPrice3.Visible = true;
                BookNum3.Visible = true;
                button3.Text = "-";
                checkBox3.Visible = true;
                button4.Visible = true;
            }
            else if (PM.Equals("-"))
            {
                BookGroup3.Text = "";
                BookName3.Text = "";
                BookWriter3.Text = "";
                BookPub3.Text = "";
                BookPrice3.Text = "";
                BookNum3.Text = "";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string PM = sender.ToString().Substring(35);
            if (PM.Equals("+"))
            {
                BookGroup4.Visible = true;
                BookName4.Visible = true;
                BookWriter4.Visible = true;
                BookPub4.Visible = true;
                BookPrice4.Visible = true;
                BookNum4.Visible = true;
                button4.Text = "-";
                checkBox4.Visible = true;
                button5.Visible = true;
            }
            else if (PM.Equals("-"))
            {
                BookGroup4.Text = "";
                BookName4.Text = "";
                BookWriter4.Text = "";
                BookPub4.Text = "";
                BookPrice4.Text = "";
                BookNum4.Text = "";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string PM = sender.ToString().Substring(35);
            if (PM.Equals("+"))
            {
                BookGroup5.Visible = true;
                BookName5.Visible = true;
                BookWriter5.Visible = true;
                BookPub5.Visible = true;
                BookPrice5.Visible = true;
                BookNum5.Visible = true;
                button5.Text = "-";
                checkBox5.Visible = true;
                button6.Visible = true;
            }
            else if (PM.Equals("-"))
            {
                BookGroup5.Text = "";
                BookName5.Text = "";
                BookWriter5.Text = "";
                BookPub5.Text = "";
                BookPrice5.Text = "";
                BookNum5.Text = "";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string PM = sender.ToString().Substring(35);
            if (PM.Equals("+"))
            {
                BookGroup6.Visible = true;
                BookName6.Visible = true;
                BookWriter6.Visible = true;
                BookPub6.Visible = true;
                BookPrice6.Visible = true;
                BookNum6.Visible = true;
                button6.Text = "-";
                checkBox6.Visible = true;
                button7.Visible = true;
            }
            else if (PM.Equals("-"))
            {
                BookGroup6.Text = "";
                BookName6.Text = "";
                BookWriter6.Text = "";
                BookPub6.Text = "";
                BookPrice6.Text = "";
                BookNum6.Text = "";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string PM = sender.ToString().Substring(35);
            if (PM.Equals("+"))
            {
                BookGroup7.Visible = true;
                BookName7.Visible = true;
                BookWriter7.Visible = true;
                BookPub7.Visible = true;
                BookPrice7.Visible = true;
                BookNum7.Visible = true;
                button7.Text = "-";
                checkBox7.Visible = true;
                button8.Visible = true;
            }
            else if (PM.Equals("-"))
            {
                BookGroup7.Text = "";
                BookName7.Text = "";
                BookWriter7.Text = "";
                BookPub7.Text = "";
                BookPrice7.Text = "";
                BookNum7.Text = "";
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            string PM = sender.ToString().Substring(35);
            if (PM.Equals("+"))
            {
                BookGroup8.Visible = true;
                BookName8.Visible = true;
                BookWriter8.Visible = true;
                BookPub8.Visible = true;
                BookPrice8.Visible = true;
                BookNum8.Visible = true;
                button8.Text = "-";
                checkBox8.Visible = true;
                button9.Visible = true;
            }
            else if (PM.Equals("-"))
            {
                BookGroup8.Text = "";
                BookName8.Text = "";
                BookWriter8.Text = "";
                BookPub8.Text = "";
                BookPrice8.Text = "";
                BookNum8.Text = "";
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            string PM = sender.ToString().Substring(35);
            if (PM.Equals("+"))
            {
                BookGroup9.Visible = true;
                BookName9.Visible = true;
                BookWriter9.Visible = true;
                BookPub9.Visible = true;
                BookPrice9.Visible = true;
                BookNum9.Visible = true;
                button9.Text = "-";
                checkBox9.Visible = true;
                button10.Visible = true;
            }
            else if (PM.Equals("-"))
            {
                BookGroup9.Text = "";
                BookName9.Text = "";
                BookWriter9.Text = "";
                BookPub9.Text = "";
                BookPrice9.Text = "";
                BookNum9.Text = "";
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            string PM = sender.ToString().Substring(35);
            if (PM.Equals("+"))
            {
                BookGroup10.Visible = true;
                BookName10.Visible = true;
                BookWriter10.Visible = true;
                BookPub10.Visible = true;
                BookPrice10.Visible = true;
                BookNum10.Visible = true;
                button10.Text = "-";
                checkBox10.Visible = true;
            }
            else if (PM.Equals("-"))
            {
                BookGroup10.Text = "";
                BookName10.Text = "";
                BookWriter10.Text = "";
                BookPub10.Text = "";
                BookPrice10.Text = "";
                BookNum10.Text = "";
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {

        }

        
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true && !BookGroup1.Text.Equals("") && !BookName1.Text.Equals("") && !BookWriter1.Text.Equals("") && !BookPub1.Text.Equals("") && !BookPrice1.Text.Equals("") && (int.Parse(BookPrice1.Text) >= 0&&!BookPrice1.Text.Equals("")) && (int.Parse(BookNum1.Text) >= 1&&!BookNum1.Text.Equals("")))
            {
                BookGroup1.Enabled = false;
                BookName1.Enabled = false;
                BookWriter1.Enabled = false;
                BookPub1.Enabled = false;
                BookPrice1.Enabled = false;
                BookNum1.Enabled = false;
            } else if (!checkBox1.Checked)
            {
                BookGroup1.Enabled = true;
                BookName1.Enabled = true;
                BookWriter1.Enabled = true;
                BookPub1.Enabled = true;
                BookPrice1.Enabled = true;
                BookNum1.Enabled = true;
            } else
            {
                checkBox1.Checked = false;
                MessageBox.Show("입력을 정확히 해주세요!");
            }
        }
    }
}