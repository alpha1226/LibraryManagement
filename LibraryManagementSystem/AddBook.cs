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

        private void BookPlusBtn_Click(object sender, EventArgs e)
        {
            
             MessageBox.Show("책 추가");
            
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