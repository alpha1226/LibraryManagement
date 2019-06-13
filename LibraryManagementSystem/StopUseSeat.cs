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
        MainForm mf;
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

        public StopUseSeat(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void StopUseSeat_Load(object sender, EventArgs e)
        {
            NameLabel.Text=PassName;
            endTimeLabel.Text = DateTime.Now.ToString();
            seatNumlabel.Text = PassSeatNumber;

            MySqlCommand selectCommand = new MySqlCommand();
            selectCommand.Connection = SUSconnection;
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("select startTime from seathistorytbl where UserID='" + NameLabel.Text.ToString()+"' AND seatNumber="+int.Parse(seatNumlabel.Text.ToString())+" AND endTime IS NULL", SUSconnection);
            da.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine(string.Format("startTime : {0}", row["startTime"]));
                TimeLabel.Text = row["startTime"].ToString();
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //select* from seathistorytbl where UserID = 'gou1226' AND seatNumber = 25 AND endTime IS NULL;

            string insertQuery = "update seathistorytbl set endTime='" + DateTime.Now.ToString()+"' where UserID='"+NameLabel.Text.ToString()+"' AND seatNumber="
                +seatNumlabel.Text.ToString()+" AND endTime IS NULL;";

            MessageBox.Show(insertQuery);//쿼리 확인

            SUSconnection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, SUSconnection);

            try//예외 처리
            {
                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("정상적으로 갔다");
                    mf.UsingSeatLabel.Text = "없음";
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

            string updateQuery = "UPDATE seattbl SET UserID=null WHERE seatIndex=" + PassSeatNumber + ";";

            MessageBox.Show(updateQuery);//쿼리 확인
            MySqlCommand updatecommand = new MySqlCommand(updateQuery, SUSconnection);

            try//예외 처리
            {
                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                if (updatecommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("정상적으로 갔다");
                    mf.UsingSeatLabel.Text = "없음";
                    mf.MainFormSeatLoad();
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

            SUSconnection.Close();
            this.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        
    }
}
