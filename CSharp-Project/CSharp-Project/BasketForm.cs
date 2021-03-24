using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace CSharp_Project
{
    public partial class BasketForm : Form
    {
        private string strConn = "Data Source=solution;User id=mighty_ems;Password=mighty_ems;";
        public BasketForm()
        {
            InitializeComponent();
            getBasket();
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void getBasket()
        {
            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT table_name,code_name, description, code_group1, exp_description FROM sys_system_code_jh_data WHERE plant ='" + Properties.Settings.Default.LoginIDSave + "'";

            OracleDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                ListViewItem item = new ListViewItem(rdr["table_name"].ToString());
                item.SubItems.Add(rdr["description"].ToString());
                item.SubItems.Add(rdr["code_group1"].ToString());
                item.SubItems.Add(rdr["code_name"].ToString());
                item.SubItems.Add(rdr["exp_description"].ToString());

                listView1.Items.Add(item);
            }
            rdr.Close();
            conn.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("해당 상품을 삭제하시겠습니까?", "상품 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int row = listView1.SelectedIndices[0];

                string code = listView1.Items[row].SubItems[3].Text;
                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM sys_system_code_jh_data WHERE code_name='" + code + "'";

                cmd.ExecuteNonQuery();
                conn.Close();
                listView1.Items.Clear();
                getBasket();
                
            }
        }

        // 더블클릭시 해당 상품페이지로 이동
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int row = listView1.SelectedIndices[0];
            string link = listView1.Items[row].SubItems[4].Text;
            System.Diagnostics.Process.Start(link);
        }
    }

}