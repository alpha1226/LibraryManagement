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
    public partial class BookSearch : Form
    {
        public string user;
        string searchvalue;
        MySqlConnection BSconnection =
           new MySqlConnection("Server=localhost;Database=lms;Uid=root;Pwd=1234;"); // 다른 컴퓨터에서도 해당 정보를 맞춰놔야함
        public BookSearch()
        {
            InitializeComponent();
        }

        public BookSearch(string user,string searchvalue)
        {
            this.searchvalue = searchvalue;
            this.user = user;
            InitializeComponent();
        }

        private string bookname;
        public string PassBookname
        {
            get { return this.bookname; }
            set { this.bookname = value; }
        }

        private string UserID;
        public string PassUserID
        {
            get { return this.UserID; }
            set { this.UserID = value; }
        }


        private void BookSearch_Load(object sender, EventArgs e)
        {
            textBox1.Text = searchvalue;

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            //listView1.CheckBoxes = true;
            // listView1.LabelEdit = true; 
            listView1.Columns.Add("관리번호", 78, HorizontalAlignment.Center);
            listView1.Columns.Add("책 분류", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("책 제목", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("저자", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("출판사", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("대출 가능 여부", 100, HorizontalAlignment.Center);

            if (textBox1.Text.Equals(""))
            {
                researchbook();
            } else if (!textBox1.Text.Equals(""))
            {
                researchbook(textBox1.Text.ToString());
            }


        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = listView1.SelectedItems;
                ListViewItem ivItem = items[0];
                string bookIndexnum = ivItem.SubItems[0].Text;
                string bookGroup = ivItem.SubItems[1].Text;
                string bookName = ivItem.SubItems[2].Text;
                string bookWriter = ivItem.SubItems[3].Text;
                string bookPub = ivItem.SubItems[4].Text;
                string deachul = ivItem.SubItems[5].Text;

                Console.WriteLine(user);

                BookInfo bi = new BookInfo(user,this);
                bi.bookIndex = int.Parse(bookIndexnum);
                bi.label7.Text = bookGroup;
                bi.label8.Text = bookName;
                bi.label9.Text = bookWriter;
                bi.label10.Text = bookPub;
                bi.label11.Text = deachul;
                bi.Visible = true;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string searchvalue = "%"+textBox1.Text.ToString()+"%";
            string deachul;
            MySqlCommand selectCommand = new MySqlCommand();
            selectCommand.Connection = BSconnection;
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from booktbl where bookName LIKE '"+searchvalue+"';", BSconnection);
            da.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine(string.Format("BookIndex : {0}, BookGroup : {1}, BookName : {2}, BookWriter : {3}, BookPub : {4}, BookPrice : {5}, BookNum : {6}, BookUserID : {7}",
                    row["Bookindex"], row["BookGroup"], row["BookName"], row["BookWriter"], row["BookPub"], row["BookPrice"], row["BookNum"], row["BookUserID"]));

                if (row["BookUserID"].ToString().Equals("")) { deachul = "가능"; } else { deachul = "불가능"; }
                if (row["BookUserID"].ToString().Equals(user)) { deachul = "반납가능"; }

                String[] aa = { row["Bookindex"].ToString(), row["BookGroup"].ToString(), row["BookName"].ToString(), row["BookWriter"].ToString(), row["BookPub"].ToString(), deachul };
                ListViewItem newitem = new ListViewItem(aa);
                listView1.Items.Add(newitem);
            }
            BSconnection.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void researchbook()
        {
            string deachul;
            MySqlCommand selectCommand = new MySqlCommand();
            selectCommand.Connection = BSconnection;
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from booktbl", BSconnection);
            da.Fill(ds);
            listView1.Items.Clear();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine(string.Format("BookIndex : {0}, BookGroup : {1}, BookName : {2}, BookWriter : {3}, BookPub : {4}, BookPrice : {5}, BookNum : {6}, BookUserID : {7}",
                    row["Bookindex"], row["BookGroup"], row["BookName"], row["BookWriter"], row["BookPub"], row["BookPrice"], row["BookNum"], row["BookUserID"]));

                if (row["BookUserID"].ToString().Equals("")) { deachul = "가능"; } else { deachul = "불가능"; }
                if (row["BookUserID"].ToString().Equals(user)) { deachul = "반납가능"; }

                String[] aa = { row["Bookindex"].ToString(), row["BookGroup"].ToString(), row["BookName"].ToString(), row["BookWriter"].ToString(), row["BookPub"].ToString(), deachul };
                ListViewItem newitem = new ListViewItem(aa);
                listView1.Items.Add(newitem);
            }
            BSconnection.Close();
        }

        public void researchbook(String str) {
            string deachul;
            MySqlCommand selectCommand = new MySqlCommand();
            selectCommand.Connection = BSconnection;
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from booktbl where BookName like '%"+str+"' OR BookName like '%"+ str + "%' OR BookName like '"+ str + "%';", BSconnection);
            da.Fill(ds);
            listView1.Items.Clear();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine(string.Format("BookIndex : {0}, BookGroup : {1}, BookName : {2}, BookWriter : {3}, BookPub : {4}, BookPrice : {5}, BookNum : {6}, BookUserID : {7}",
                    row["Bookindex"], row["BookGroup"], row["BookName"], row["BookWriter"], row["BookPub"], row["BookPrice"], row["BookNum"], row["BookUserID"]));

                if (row["BookUserID"].ToString().Equals("")) { deachul = "가능"; } else { deachul = "불가능"; }
                if (row["BookUserID"].ToString().Equals(user)) { deachul = "반납가능"; }
                String[] aa = { row["Bookindex"].ToString(), row["BookGroup"].ToString(), row["BookName"].ToString(), row["BookWriter"].ToString(), row["BookPub"].ToString(), deachul };
                ListViewItem newitem = new ListViewItem(aa);
                listView1.Items.Add(newitem);
            }
            BSconnection.Close();
        }
    }
}
