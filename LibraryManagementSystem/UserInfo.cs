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
    }
}
