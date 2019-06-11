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
    public partial class BookInfo : Form
    {

        //MainForm mf;
        //BookSearch bs;
        string user;
        public int bookIndex;
        public BookInfo()
        {
            InitializeComponent();
        }
        public BookInfo(string user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void BookInfo_Load(object sender, EventArgs e)
        {
            Console.WriteLine(user);
            if (label11.Text.Equals("가능")) { label6.Text = "반납일"; label12.Text = DateTime.Now.ToString().Remove(11); } 
            else if (label11.Text.Equals("불가능")) { label6.Text = "대출 가능일"; label12.Text = DateTime.Now.AddDays(7).ToString().Remove(11); ; button1.Enabled = false; }
            MessageBox.Show(user+"/"+bookIndex);

            MySqlConnection BIconn =
            new MySqlConnection("Server=localhost;Database=lms;Uid=root;Pwd=1234;"); // 다른 컴퓨터에서도 해당 정보를 맞춰놔야함

            MySqlCommand mySqlCommand = BIconn.CreateCommand();

            //mySqlCommand.Parameters.Add(new MySqlParameter("input", 10));

            mySqlCommand.CommandText= "select BookUserID from booktbl where bookIndex=" + bookIndex;

            BIconn.Open();
            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show(reader["BookUserID"].ToString());
                if (reader["bookUserID"].ToString().Equals(user))
                {
                    button1.Text = "반납 신청";
                    button1.Enabled = true;
                }
                
                } else
            {
                MessageBox.Show("대출 가능");
                label12.Text = DateTime.Now.ToString();
            }


            if (BIconn.State == ConnectionState.Open)
            {
                BIconn.Close();
            }



        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("대출 신청"))
            {
                string Query = "update booktbl set BookUserID='" + user + "' where BookIndex=" + bookIndex + ";";
                string insertQuery = "insert into bookhistorytbl(BookIndex, UserID, startDate) values(" + bookIndex + ", '" + user + "', '" + DateTime.Now.AddDays(7).ToString().Remove(11) + "');";

                MessageBox.Show(Query);//쿼리 확인

                MySqlConnection BIconn =
                new MySqlConnection("Server=localhost;Database=lms;Uid=root;Pwd=1234;"); // 다른 컴퓨터에서도 해당 정보를 맞춰놔야함

                BIconn.Open();

                MySqlCommand command = new MySqlCommand(Query, BIconn);
                try//예외 처리
                {
                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("대출신청 완료");
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("대출 실패");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MySqlCommand insertcommand = new MySqlCommand(insertQuery, BIconn);


                try//예외 처리
                {
                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                    if (insertcommand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("history 저장 완료");
                    }
                    else
                    {
                        MessageBox.Show("history 저장 실패");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (BIconn.State == ConnectionState.Open)
                {
                    BIconn.Close();
                }
            } else if(button1.Text.Equals("반납 신청")){
                string Query = "update booktbl set BookUserID=null where BookIndex=" + bookIndex + ";";
                string insertQuery = "UPDATE bookhistorytbl set endDate='" + DateTime.Now.ToString().Remove(11).Trim() + "' where UserID='"+user+"' AND BookIndex="+bookIndex+";";

                MessageBox.Show(Query);//쿼리 확인
                MessageBox.Show(insertQuery);

                MySqlConnection BIconn =
                new MySqlConnection("Server=localhost;Database=lms;Uid=root;Pwd=1234;"); // 다른 컴퓨터에서도 해당 정보를 맞춰놔야함

                BIconn.Open();

                MySqlCommand command = new MySqlCommand(Query, BIconn);
                try//예외 처리
                {
                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("반납 완료");
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("반납 실패");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MySqlCommand insertcommand = new MySqlCommand(insertQuery, BIconn);


                try//예외 처리
                {
                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                    if (insertcommand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("history enddate 저장 완료");
                    }
                    else
                    {
                        MessageBox.Show("history enddate 저장 실패");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (BIconn.State == ConnectionState.Open)
                {
                    BIconn.Close();
                }
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
