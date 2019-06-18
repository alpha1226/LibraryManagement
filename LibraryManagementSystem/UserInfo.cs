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
    public partial class UserInfo : Form
    {
        String FirstPassword = "";
        MySqlConnection UIconnection =
        new MySqlConnection("Server=localhost;Database=lms;Uid=root;Pwd=1234;"); // 다른 컴퓨터에서도 해당 정보를 맞춰놔야함

        string uID;
        public UserInfo()
        {
            InitializeComponent();
        }
        public UserInfo(string user)
        {
            InitializeComponent();
            uID = user;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            MySqlCommand selectCommand = new MySqlCommand();
            selectCommand.Connection = UIconnection;
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from membertbl where UserID='"+uID+"' ", UIconnection);
            da.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine(string.Format("UserID : {0}, UserPW : {1}, UserName : {2}, UserBirthday : {3}, UserPhoneNumber : {4}, UserSubject : {5}, UserAddress : {6}, UserLoginDate : {7}",
                    row["UserID"], row["UserPW"], row["UserName"], row["UserBirthday"], row["UserPhoneNumber"], row["UserSubject"], row["UserAddress"], row["UserLoginDate"]));
                ID_textBox.Text = row["UserID"].ToString();
                PW_textBox.Text = row["UserPW"].ToString();
                FirstPassword = row["UserPW"].ToString();
                PWCK_textBox.Text = row["UserPW"].ToString();
                Name_textBox.Text = row["UserName"].ToString();
                Birth_textBox.Text = row["UserBirthday"].ToString();
                Phone_textBox.Text = row["UserPhoneNumber"].ToString();
                job_textBox.Text = row["UserSubject"].ToString();
                Address_textBox.Text = row["UserAddress"].ToString();
            }

            DataSet bookds = new DataSet();
            MySqlDataAdapter bookda = new MySqlDataAdapter("select BookName from booktbl where BookUserID='" + uID + "' ", UIconnection);
            bookda.Fill(bookds);
            listBox1.Items.Clear();

            foreach (DataRow row in bookds.Tables[0].Rows)
            {
                Console.WriteLine(string.Format("BookName : {0}", row["BookName"]));
                listBox1.Items.Add(row["BookName"].ToString());
            }

            DataSet bookhids = new DataSet();
            MySqlDataAdapter bookhida = new MySqlDataAdapter("select BookName from booktbl where BookIndex IN(select BookIndex from bookhistorytbl where UserID='"+uID+"');", UIconnection);
            bookhida.Fill(bookhids);
            listBox2.Items.Clear();

            foreach (DataRow row in bookhids.Tables[0].Rows)
            {
                Console.WriteLine(string.Format("BookName : {0}", row["BookName"]));
                listBox2.Items.Add(row["BookName"].ToString());
            }




            UIconnection.Close();



        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int pwFlag = 0;

        private void Button3_Click(object sender, EventArgs e)
        {
            pwFlag = 1;
            PW_textBox.Enabled = true;
            PWCK_textBox.Enabled = true;
        }

        
        private void Button6_Click(object sender, EventArgs e)
        {
            pwFlag = 1;

            if (PW_textBox.Text.Equals(PWCK_textBox.Text) && !(PW_textBox.Text.Equals(""))){
                PW_textBox.Enabled = false;
                PWCK_textBox.Enabled = false;
                pwFlag = 2;
            } else
            {
                pwFlag = 3;
                MessageBox.Show("PW를 다시한번 확인해주세요");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //update membertbl set UserName='admin',UserBirthday='1997.12.31',UserPhoneNumber='01011111111',UserSubject='학생2',UserAddress='gou1997recover' where UserID='gou1226';
            string insertQuery = "update membertbl set UserName='"+Name_textBox.Text+ "', UserBirthday='"+Birth_textBox.Text+"', UserPhoneNumber='"+Phone_textBox.Text+"',UserSubject='"+job_textBox.Text+"',UserAddress='"+Address_textBox.Text+"' " +
                " where UserID='" + ID_textBox.Text + "'";

            //string PWinsertQuery = "update membertbl set USerPW='"+PWCK_textBox.Text+"' where UserID='" + ID_textBox.Text + "'";

            //MessageBox.Show(insertQuery);//쿼리 확인

            UIconnection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, UIconnection);


            if (pwFlag == 1 || pwFlag == 3)
            {
                MessageBox.Show("PW를 다시한번 확인해주세요");
            } else if (pwFlag == 2)
            {
                string PWinsertQuery = "update membertbl set USerPW='" + PWCK_textBox.Text + "' where UserID='" + ID_textBox.Text + "'";

                MessageBox.Show(PWinsertQuery);//쿼리 확인

                command = new MySqlCommand(PWinsertQuery, UIconnection);


                try//예외 처리
                {
                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("PW가 수정되었습니다");
                        //mf.UsingSeatLabel.Text = "없음";
                    }
                    else
                    {
                        //MessageBox.Show("비정상 이당");
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
            try//예외 처리
            {
                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                if (command.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("정상적으로 갔다");
                    //mf.UsingSeatLabel.Text = "없음";
                    MessageBox.Show("개인정보가 수정되었습니다");
                }
                else
                {
                    //MessageBox.Show("비정상 이당");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }


            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from membertbl where UserID='" + uID + "' ", UIconnection);
            da.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine(string.Format("UserID : {0}, UserPW : {1}, UserName : {2}, UserBirthday : {3}, UserPhoneNumber : {4}, UserSubject : {5}, UserAddress : {6}, UserLoginDate : {7}",
                    row["UserID"], row["UserPW"], row["UserName"], row["UserBirthday"], row["UserPhoneNumber"], row["UserSubject"], row["UserAddress"], row["UserLoginDate"]));
                ID_textBox.Text = row["UserID"].ToString();
                PW_textBox.Text = row["UserPW"].ToString();
                FirstPassword = row["UserPW"].ToString();
                PWCK_textBox.Text = row["UserPW"].ToString();
                Name_textBox.Text = row["UserName"].ToString();
                Birth_textBox.Text = row["UserBirthday"].ToString();
                Phone_textBox.Text = row["UserPhoneNumber"].ToString();
                job_textBox.Text = row["UserSubject"].ToString();
                Address_textBox.Text = row["UserAddress"].ToString();
            }

            UIconnection.Close();

        }
    }
}
