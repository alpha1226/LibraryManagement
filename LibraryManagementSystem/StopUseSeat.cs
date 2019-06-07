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
    
    public partial class StopUseSeat : Form
    {
        MySqlConnection SUSconnection =
           new MySqlConnection("Server=localhost;Database=lms;Uid=root;Pwd=1234;"); // 다른 컴퓨터에서도 해당 정보를 맞춰놔야함
        private string Name;
        public string PassName
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        private string StartTime;
        public string PassStartTime
        {
            get { return this.StartTime; }
            set { this.StartTime = value; }
        }
        private string SeatNumber;
        public string PassSeatNumber
        {
            get { return this.SeatNumber; }
            set { this.SeatNumber = value; }
        }
        private string seatIndex;
        public string PassSeatIndex
        {
            get { return this.seatIndex; }
            set { this.seatIndex = value; }
        }



        public StopUseSeat()
        {
            InitializeComponent();
        }

        private void StopUseSeat_Load(object sender, EventArgs e)
        {
            NameLabel.Text=PassName;
            TimeLabel.Text=PassStartTime;
            endTimeLabel.Text = DateTime.Now.ToString();
            seatNumlabel.Text = PassSeatNumber;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "update seattbl set endTime='"+DateTime.Now.ToString()+"' where seatIndex="+seatIndex+";";

            MessageBox.Show(insertQuery);//쿼리 확인

            SUSconnection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, SUSconnection);

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
            SUSconnection.Close();
            this.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        
    }
}
