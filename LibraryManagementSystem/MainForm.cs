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
            for (int i = 1; i <= 32; i++)
            {
                seatNumcheckerToFalse(i);
            }
            seatUpdater();
            MainFormSeatLoad();
            


            //public Label l = ;

        }

        public void MainFormSeatLoad()
        {
            for (int i = 1; i <= 32; i++)
            {
                seatNumcheckerToFalse(i);
            }
            seatUpdater();
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
                UserInfo ui = new UserInfo(userlabel.Text.ToString());
                ui.Visible = true;
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            BookSearch bs = new BookSearch(userlabel.Text.ToString(), textBox1.Text.ToString()) ;
            bs.PassBookname = textBox1.Text;
            bs.PassUserID = userlabel.Text;
            bs.Visible = true;
        }

        public void seatUpdater()
        {
            MySqlCommand selectCommand = new MySqlCommand();
            selectCommand.Connection = sqlconn;
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from seattbl", sqlconn);
            da.Fill(ds);
            //string[] num;
            int seatindex=0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine(string.Format("seatIndex : {0}, UserID : {1}", row["seatIndex"], row["UserID"]));
                if (userlabel.Text.Equals(row["UserID"]))
                {
                    seatindex = int.Parse(row["seatIndex"].ToString());

                }
                Console.WriteLine(seatindex);
                if (seatindex != 0)
                {
                    UsingSeatLabel.Text = seatindex.ToString();
                }
            }

            if (!UsingSeatLabel.Text.Equals("없음"))
            {
                MySqlCommand inselectCommand = new MySqlCommand();
                inselectCommand.Connection = sqlconn;
                DataSet inds = new DataSet();
                MySqlDataAdapter inda = new MySqlDataAdapter("select * from seattbl where UserID='"+userlabel.Text.ToString()+"'", sqlconn);
                inda.Fill(inds);
                int usingseatindex;

                foreach (DataRow inrow in inds.Tables[0].Rows)
                {
                    Console.WriteLine(string.Format("사용중 seatIndex : {0}", inrow["seatIndex"]));
                    usingseatindex = int.Parse(inrow["seatIndex"].ToString());
                    
                    Console.WriteLine("useingseatindex : "+usingseatindex);
                    seatNumCheckerToTrue(usingseatindex);
                }

            } else if (UsingSeatLabel.Text.Equals("없음"))
            {
                MySqlCommand inselectCommand = new MySqlCommand();
                inselectCommand.Connection = sqlconn;
                DataSet inds = new DataSet();
                MySqlDataAdapter inda = new MySqlDataAdapter("select * from seattbl where UserID IS NULL", sqlconn);
                inda.Fill(inds);
                int nullseatindex;
                foreach (DataRow inrow in inds.Tables[0].Rows)
                {
                    Console.WriteLine(string.Format("사용중 seatIndex : {0}", inrow["seatIndex"]));
                    nullseatindex = int.Parse(inrow["seatIndex"].ToString());

                    Console.WriteLine("useingseatindex : " + nullseatindex);
                    seatNumCheckerToTrue(nullseatindex);
                }
            }


            sqlconn.Close();
        }

        public void seatNumcheckerToFalse(int seatindex)
        {
            switch (seatindex)
            {
                case 1:
                    button1.Enabled = false;
                    break;
                case 2:
                    button2.Enabled = false;
                    break;
                case 3:
                    button3.Enabled = false;
                    break;
                case 4:
                    button4.Enabled = false;
                    break;
                case 5:
                    button5.Enabled = false;
                    break;
                case 6:
                    button6.Enabled = false;
                    break;
                case 7:
                    button7.Enabled = false;
                    break;
                case 8:
                    button8.Enabled = false;
                    break;
                case 9:
                    button9.Enabled = false;
                    break;
                case 10:
                    button10.Enabled = false;
                    break;
                case 11:
                    button11.Enabled = false;
                    break;
                case 12:
                    button12.Enabled = false;
                    break;
                case 13:
                    button13.Enabled = false;
                    break;
                case 14:
                    button14.Enabled = false;
                    break;
                case 15:
                    button15.Enabled = false;
                    break;
                case 16:
                    button16.Enabled = false;
                    break;
                case 17:
                    button17.Enabled = false;
                    break;
                case 18:
                    button18.Enabled = false;
                    break;
                case 19:
                    button19.Enabled = false;
                    break;
                case 20:
                    button20.Enabled = false;
                    break;
                case 21:
                    button21.Enabled = false;
                    break;
                case 22:
                    button22.Enabled = false;
                    break;
                case 23:
                    button23.Enabled = false;
                    break;
                case 24:
                    button24.Enabled = false;
                    break;
                case 25:
                    button25.Enabled = false;
                    break;
                case 26:
                    button26.Enabled = false;
                    break;
                case 27:
                    button27.Enabled = false;
                    break;
                case 28:
                    button28.Enabled = false;
                    break;
                case 29:
                    button29.Enabled = false;
                    break;
                case 30:
                    button30.Enabled = false;
                    break;
                case 31:
                    button31.Enabled = false;
                    break;
                case 32:
                    button32.Enabled = false;
                    break;
            }
        }

        public void seatNumCheckerToTrue(int seatindex)
        {
            switch (seatindex)
            {
                case 1:
                    button1.Enabled = true;
                    break;
                case 2:
                    button2.Enabled = true;
                    break;
                case 3:
                    button3.Enabled = true;
                    break;
                case 4:
                    button4.Enabled = true;
                    break;
                case 5:
                    button5.Enabled = true;
                    break;
                case 6:
                    button6.Enabled = true;
                    break;
                case 7:
                    button7.Enabled = true;
                    break;
                case 8:
                    button8.Enabled = true;
                    break;
                case 9:
                    button9.Enabled = true;
                    break;
                case 10:
                    button10.Enabled = true;
                    break;
                case 11:
                    button11.Enabled = true;
                    break;
                case 12:
                    button12.Enabled = true;
                    break;
                case 13:
                    button13.Enabled = true;
                    break;
                case 14:
                    button14.Enabled = true;
                    break;
                case 15:
                    button15.Enabled = true;
                    break;
                case 16:
                    button16.Enabled = true;
                    break;
                case 17:
                    button17.Enabled = true;
                    break;
                case 18:
                    button18.Enabled = true;
                    break;
                case 19:
                    button19.Enabled = true;
                    break;
                case 20:
                    button20.Enabled = true;
                    break;
                case 21:
                    button21.Enabled = true;
                    break;
                case 22:
                    button22.Enabled = true;
                    break;
                case 23:
                    button23.Enabled = true;
                    break;
                case 24:
                    button24.Enabled = true;
                    break;
                case 25:
                    button25.Enabled = true;
                    break;
                case 26:
                    button26.Enabled = true;
                    break;
                case 27:
                    button27.Enabled = true;
                    break;
                case 28:
                    button28.Enabled = true;
                    break;
                case 29:
                    button29.Enabled = true;
                    break;
                case 30:
                    button30.Enabled = true;
                    break;
                case 31:
                    button31.Enabled = true;
                    break;
                case 32:
                    button32.Enabled = true;
                    break;
            }
        }
    }
}
