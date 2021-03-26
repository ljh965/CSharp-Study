using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Oracle.DataAccess.Client;
namespace Library
{
    public partial class LibraryForm : Form
    {
        int pageNumber = 0;
        int totalPage = 1;
        IndexForm form;
        BookCategory book = new BookCategory();
        private string strConn = "Data Source=solution;User id=mighty_ems;Password=mighty_ems;";
        string lbCode = null;
        public LibraryForm(IndexForm pfrom, string name, string code)
        {
            InitializeComponent();
            form = pfrom;
            lbCode = code;
            lb_Name.Text = name;
            if (Properties.Settings.Default.Status)
            {
                btn_Add.Text = "책 등록";
                btn_Delete.Visible = true;
            }
            else
            {
                btn_Add.Text = "관리자로그인";
            }
            showAllData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList bookList = book.getBookCategory();
            comboBox2.Items.Clear();
            int index = comboBox1.SelectedIndex;
            string[] books = (string[])bookList[index];
            for (int i = 0; i < books.Length; i++)
            {
                int code2 = i * 10;
                comboBox2.Items.Add(index.ToString() + code2.ToString("D2") + " " + books[i]);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            ArrayList bookList = book.getBookCategory();


            comboBox1.SelectedIndex = 0;
            comboBox2.Items.Clear();
            int index = comboBox1.SelectedIndex;

            string[] books = (string[])bookList[index];
            for (int i = 0; i < books.Length; i++)
            {
                int code1 = i * 10;
                comboBox2.Items.Add(index.ToString() + code1.ToString("D2") + " " + books[i]);
            }
            comboBox2.SelectedIndex = 0;
        }

        public void refresh()
        {
            totalPage = getTotalPage();
            if (pageNumber == 0)
            {
                btn_Previous.Enabled = false;
            }
            else
            {
                btn_Previous.Enabled = true;
            }
            if (pageNumber >= totalPage - 1)
            {
                btn_Next.Enabled = false;
            }
            else
            {
                btn_Next.Enabled = true;
            }
            listView1.Items.Clear();

            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM(SELECT ROWNUM NUM,A.*, LPAD(A.code_seq,3,'0') AS code FROM sys_system_code_jh_data A WHERE table_name ='" + lbCode + "'AND code_seq='"+ comboBox2.Text.Substring(0,3) +"') WHERE NUM BETWEEN " + (1 + (pageNumber * 15)) + " AND " + (15 + (pageNumber * 15));
            if (!String.IsNullOrEmpty(tb_Search.Text))
            {
                cmd.CommandText = "SELECT * FROM(SELECT ROWNUM NUM,A.*, LPAD(A.code_seq,3,'0') AS code FROM sys_system_code_jh_data A WHERE table_name ='" + lbCode + "' AND description LIKE '%" + tb_Search.Text + "%') WHERE NUM BETWEEN " + (1 + (pageNumber * 15)) + " AND " + (15 + (pageNumber * 15));
            }
            

            OracleDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                ListViewItem item = new ListViewItem(rdr["description"].ToString());
                item.SubItems.Add(rdr["code"].ToString());
                item.SubItems.Add(rdr["code_group1"].ToString());
                item.SubItems.Add(rdr["code_group2"].ToString());
                item.SubItems.Add(rdr["exp_description"].ToString());
                item.SubItems.Add(rdr["exp_code_group1"].ToString());

                listView1.Items.Add(item);
            }
            conn.Close();
            rdr.Close();

        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (pageNumber == 0)
            {
                btn_Previous.Enabled = false;
            }
            else
            {
                btn_Previous.Enabled = true;
                pageNumber--;
                showAllData();
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (pageNumber == totalPage - 1)
            {
                btn_Next.Enabled = false;
            }
            else
            {
                btn_Next.Enabled = true;
                pageNumber++;
                showAllData();
            }
        }

        private int getTotalPage()
        {
            int total = 0;
            int page = 0;
            string strConn = "Data Source=solution;User id=mighty_ems;Password=mighty_ems;";
            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT count(*) FROM sys_system_code_jh_data WHERE table_name ='" + lbCode + "' AND code_seq='"+ comboBox2.Text.Substring(0,3) +"'";
            if (!String.IsNullOrEmpty(tb_Search.Text))
            {
                cmd.CommandText = "SELECT count(*) FROM sys_system_code_jh_data WHERE table_name ='" + lbCode + "' AND description LIKE '%" + tb_Search.Text + "%'";
            }

            OracleDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                total = Int32.Parse(rdr["count(*)"].ToString());
            }
            conn.Close();
            rdr.Close();


            if (total % 15 == 0)
            {
                page = total / 15;
            }
            else
            {
                page = (total / 15) + 1;
            }

            return page;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_Search.Text))
            {
                showAllData();
            }
            else
            {
                refresh();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Status)
            {
                AddBook bookForm = new AddBook(this,lbCode);
                bookForm.ShowDialog();
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }
            showAllData();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제하면 모든 정보가 사라집니다.\r정말 삭제하시겠습니까 ?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM sys_system_code_jh WHERE table_name='" + lbCode + "'";

                cmd.ExecuteNonQuery();

                cmd.CommandText = "DELETE FROM sys_system_code_jh_data WHERE table_name='" + lbCode +"'";

                cmd.ExecuteNonQuery();

                conn.Close();
                this.Close();
                form.refresh();
            }
        }

        public void showAllData()
        {
            totalPage = getAllData();

            if (Properties.Settings.Default.Status)
            {
                btn_Add.Text = "책 등록";
                btn_Delete.Visible = true;
            }
            else
            {
                btn_Add.Text = "관리자로그인";
            }

            if (pageNumber == 0)
            {
                btn_Previous.Enabled = false;
            }
            else
            {
                btn_Previous.Enabled = true;
            }
            if (pageNumber >= totalPage - 1)
            {
                btn_Next.Enabled = false;
            }
            else
            {
                btn_Next.Enabled = true;
            }
            listView1.Items.Clear();

            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM(SELECT ROWNUM NUM,A.*, LPAD(A.code_seq,3,'0') AS code FROM sys_system_code_jh_data A WHERE table_name ='" + lbCode + "') WHERE NUM BETWEEN " + (1 + (pageNumber * 15)) + " AND " + (15 + (pageNumber * 15));


            OracleDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                ListViewItem item = new ListViewItem(rdr["description"].ToString());
                item.SubItems.Add(rdr["code"].ToString());
                item.SubItems.Add(rdr["code_group1"].ToString());
                item.SubItems.Add(rdr["code_group2"].ToString());
                item.SubItems.Add(rdr["exp_description"].ToString());
                item.SubItems.Add(rdr["exp_code_group1"].ToString());

                listView1.Items.Add(item);
            }
            conn.Close();
            rdr.Close();
        }

        private int getAllData()
        {
            int total = 0;
            int page = 0;
            string strConn = "Data Source=solution;User id=mighty_ems;Password=mighty_ems;";
            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT count(*) FROM sys_system_code_jh_data WHERE table_name ='" + lbCode + "'";
            OracleDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                total = Int32.Parse(rdr["count(*)"].ToString());
            }
            conn.Close();
            rdr.Close();


            if (total % 15 == 0)
            {
                page = total / 15;
            }
            else
            {
                page = (total / 15) + 1;
            }

            return page;
        }

        // 컬럼 사이즈 고정
        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
    }

}