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
    public partial class MainForm : Form
    {
        MySqlConnection sqlconn =
            new MySqlConnection("Server=localhost;Database=lms;Uid=root;Pwd=1234;"); // 다른 컴퓨터에서도 해당 정보를 맞춰놔야함

        private string value;
        public string Passvalue
        {
            get { return this.value; }
            set { this.value = value; }
        }

        
        public MainForm()
        {
            InitializeComponent();
        }
        //int enableArr = new int();
        string startTime = "";
        string seatIndex="";
        private void MainForm_Load(object sender, EventArgs e)
        {
            userlabel.Text = Passvalue;

            
            //public Label l = ;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            SeatPassenger(sender);
        }

        private void SeatPassenger(object mysender)
        {
            int seatNum = int.Parse(mysender.ToString().Substring(35));

            if (UsingSeatLabel.Text.Equals("없음") == true)
            {
                SeatChoice sh = new SeatChoice(this);
                sh.Passvalue = userlabel.Text;
                sh.UseSeatValue = seatNum.ToString();
                MessageBox.Show(seatNum + "번 자리 사용");
                sh.Visible = true;
            }
            else if (UsingSeatLabel.Text.Equals(seatNum.ToString()))
            {
                StopUseSeat sus = new StopUseSeat(this);
                sus.PassName = userlabel.Text;
                sus.PassSeatNumber = seatNum.ToString();
                sus.PassStartTime = startTime;
                sus.PassSeatIndex = seatIndex;
                MessageBox.Show(seatNum + "번 자리 사용 종료");
                sus.Visible = true;
            }
            else
            {
                MessageBox.Show("잘못된 번호의 좌석을 클릭하셧습니다.\n 사용중인 좌석을 사용종료 해주세요");
            }
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LogInForm lif = new LogInForm();
            lif.Visible = true;
        }

        private void Button37_Click(object sender, EventArgs e)
        {
            if (userlabel.Text.Equals("admin"))
            {
                AddBook ab = new AddBook();
                ab.Visible = true;
            }
            else
            {
                UserInfo ui = new UserInfo();
                ui.Visible = true;
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            BookSearch bs = new BookSearch(userlabel.Text.ToString());
            bs.PassBookname = textBox1.Text;
            bs.PassUserID = userlabel.Text;
            bs.Visible = true;
        }
    }
}
