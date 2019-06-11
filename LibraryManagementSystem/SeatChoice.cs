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
    public partial class SeatChoice : Form
    {
        MainForm mf;
        MySqlConnection sqlconn =
                    new MySqlConnection("Server=localhost;Database=lms;Uid=root;Pwd=1234;"); // 다른 컴퓨터에서도 해당 정보를 맞춰놔야함 
        public SeatChoice()
        {
            InitializeComponent();
        }

        public SeatChoice(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }
        private string value;
        public string Passvalue
        {
            get { return this.value; }
            set { this.value = value; }
        }
        private string useValue;
        public string UseSeatValue
        {
            get { return this.useValue; }
            set { this.useValue = value; }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //칼럼에 추가하는 커리문 insertQuery
            string insertQuery = "INSERT INTO seattbl(seatNumber,UserID,startTime)" +
                    "VALUES(" + UseSeatValue + ",'" + NameLabel.Text.ToString() + "','" + TimeLabel.Text.ToString() + "')";

            MessageBox.Show(insertQuery);//쿼리 확인

            sqlconn.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, sqlconn);

            try//예외 처리
            {
                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("정상적으로 갔다");
                    mf.UsingSeatLabel.Text = UseSeatValue;
                }
                else
                {
                    MessageBox.Show("비정상");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            sqlconn.Close();
            this.Visible = false;
        }

        private void SeatChoice_Load(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString();
            NameLabel.Text = Passvalue;
            seatNumlabel.Text = UseSeatValue;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
