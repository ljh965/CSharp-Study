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
    public partial class IndexForm : Form
    {
        int pageNumber = 0;
        int totalPage = 1;
        Cities city = new Cities();
        CreateCode code = new CreateCode();
        private string strConn = "Data Source=solution;User id=mighty_ems;Password=mighty_ems;";
        public IndexForm()
        {
            InitializeComponent();
   
        }

        public void IndexForm_Load(object sender, EventArgs e)
        {
            ArrayList citylist = city.getCityCode();
           
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.Clear();
            int index = comboBox1.SelectedIndex;

            string[] cities = (string[])citylist[index];
            for(int i=0; i<cities.Length; i++)
            {
                comboBox2.Items.Add(cities[i]);
            }
            comboBox2.SelectedIndex = 0;
            refresh();
            btn_Previous.Enabled = false;
            totalPage = getTotalPage();
            if (totalPage <= 1)
            {
                btn_Next.Enabled = false;
            }
            else
            {
                btn_Next.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList citylist = city.getCityCode();
            comboBox2.Items.Clear();
            int index = comboBox1.SelectedIndex;
            string[] cities = (string[])citylist[index];
            for (int i = 0; i < cities.Length; i++)
            {
                comboBox2.Items.Add(cities[i]);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            refresh();
        }

        // 컬럼 사이즈 고정
        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            refresh();
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
            string plant = code.getCityCode(comboBox1.SelectedIndex, comboBox2.SelectedIndex);

            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM(SELECT ROWNUM NUM,A.* FROM sys_system_code_jh A WHERE plant ='" + plant + "' AND description LIKE '%" + tb_Search.Text + "%') WHERE NUM BETWEEN " + (1 + (pageNumber * 15)) + " AND " + (15 + (pageNumber * 15));

            OracleDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ListViewItem item = new ListViewItem(comboBox1.Text);
                item.SubItems.Add(comboBox2.Text);
                item.SubItems.Add(rdr["description"].ToString());
                item.SubItems.Add(rdr["format_type"].ToString());
                item.SubItems.Add(rdr["table_name"].ToString());

                listView1.Items.Add(item);
            }
            conn.Close();
            rdr.Close();
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            if (Properties.Settings.Default.Status)
            {
                btn_Add.Visible = true;
                btn_Login.Visible = false;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddLibraryForm addForm = new AddLibraryForm(this);
            addForm.ShowDialog();
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
                refresh();
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
                refresh();       
            }
        }

        private int getTotalPage()
        {
            int total = 0;
            int page = 0;
            string strConn = "Data Source=solution;User id=mighty_ems;Password=mighty_ems;";
            string plant = code.getCityCode(comboBox1.SelectedIndex, comboBox2.SelectedIndex);
            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT count(*) FROM sys_system_code_jh WHERE plant ='" + plant + "'";
            if (!String.IsNullOrEmpty(tb_Search.Text))
            {
                cmd.CommandText += " AND description LIKE '%" + tb_Search.Text + "%'";
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

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView.SelectedListViewItemCollection items = listView1.SelectedItems;
            ListViewItem item = items[0];
            string name = item.SubItems[2].Text;
            string code = item.SubItems[4].Text;

            LibraryForm form = new LibraryForm(this, name, code);
            form.ShowDialog();
        }
    }
}