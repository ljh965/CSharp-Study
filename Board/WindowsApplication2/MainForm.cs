using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsApplication2
{
    public partial class MainForm : Form
    {
        private string strConn = "Data Source=xe;User Id=scott;Password=tiger;";

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            textBox_Search.ForeColor = Color.DarkGray;
            textBox_Search.Text = "과목명";

            DialogResult result = loginForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                MessageBox.Show("로그인 성공");
            }
            refresh();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            InsertForm insertForm = new InsertForm(this);
            insertForm.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LoginIDSave = String.Empty;
            Application.Exit();
        }

        // 컬럼 사이즈 조정 불가
        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = listView1.SelectedItems;
                ListViewItem Ivitem = items[0];
                string subName = Ivitem.SubItems[1].Text;
                string subTitle = Ivitem.SubItems[2].Text;
                string date = Ivitem.SubItems[3].Text;

                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT boardId FROM board WHERE (subjectName='"+subName+"' and day='"+date+"')";

                OracleDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    string bId = rdr["boardId"].ToString();
                    showBoard board = new showBoard(this, bId);
                    board.ShowDialog();
                }
            }
        }

        public void refresh()
        {
            listView1.Items.Clear();
            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT ROW_NUMBER() OVER(ORDER BY boardId) row_num ,subjectName,subjectTitle,day FROM BOARD ORDER BY row_num DESC";

            OracleDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string boardId = rdr["row_num"].ToString();
                string subName = rdr["subjectName"].ToString();
                string subTitle = rdr["subjectTitle"].ToString();
                string date = rdr["day"].ToString();

                ListViewItem item = new ListViewItem(boardId);
                item.SubItems.Add(subName);
                item.SubItems.Add(subTitle);
                item.SubItems.Add(date);

                listView1.Items.Add(item);
            }
            rdr.Close();
            conn.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT ROW_NUMBER() OVER(ORDER BY boardId) row_num ,subjectName,subjectTitle,day FROM board WHERE subjectName LIKE '%"+textBox_Search.Text+"%' ORDER BY row_num DESC";

            OracleDataReader rdr = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (rdr.Read())
            {
                string boardId = rdr["row_num"].ToString();
                string subName = rdr["subjectName"].ToString();
                string subTitle = rdr["subjectTitle"].ToString();
                string date = rdr["day"].ToString();

                ListViewItem item = new ListViewItem(boardId);
                item.SubItems.Add(subName);
                item.SubItems.Add(subTitle);
                item.SubItems.Add(date);

                listView1.Items.Add(item);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void textBox_Search_MouseLeave(object sender, EventArgs e)
        {
            textBox_Search.ForeColor = Color.DarkGray;
            textBox_Search.Text = "과목명";
        }

        private void textBox_Search_MouseDown(object sender, MouseEventArgs e)
        {
            textBox_Search.ForeColor = Color.Black;
            textBox_Search.Text = "";
        }


        private void textBox_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.Enter))
            {
                btn_Search_Click(sender, e);
                btn_Search.Select();
            }
        }


    }
}