using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Collections;

namespace Library
{
    public partial class AddBook : Form
    {
        private string strConn = "Data Source=solution;User Id=mighty_ems;Password=mighty_ems;";
        LibraryForm form;
        BookCategory book = new BookCategory();
        string table_name = null;
        public AddBook(LibraryForm pForm, string code)
        {
            form = pForm;
            InitializeComponent();
            table_name = code;
        }

        private void AddBook_Load(object sender, EventArgs e)
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string num = comboBox2.Text.Substring(0, 3);
            if (String.IsNullOrEmpty(tb_Name.Text))
            {
                tb_Name.Focus();
                label_Error.Text = "책 제목을 입력하세요";
            }
            else if (String.IsNullOrEmpty(tb_ISBN.Text))
            {
                tb_ISBN.Focus();
                label_Error.Text = "고유번호를 입력하세요";
            }
            else if (String.IsNullOrEmpty(tb_Count.Text) || tb_Count.Text.Equals("0"))
            {
                tb_Count.Focus();
                label_Error.Text = "수량을 입력하세요";
            }
            else if (String.IsNullOrEmpty(tb_Publish.Text))
            {
                tb_Publish.Focus();
                label_Error.Text= "출판사를 입력하세요";
            }
            else if (String.IsNullOrEmpty(tb_PbNumber.Text))
            {
                tb_PbNumber.Focus();
                label_Error.Text = "발행자 번호를 입력하세요";
            }

            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into sys_system_code_jh_data(plant,table_name,code_name,code_seq,description,code_group1,code_group2,exp_description,exp_code_group1) select plant, table_name, '" + tb_ISBN.Text + "', '" + num + "','" + tb_Name.Text + "','" + tb_Count.Text + "','Y','" + tb_Publish.Text + "','" + tb_PbNumber.Text + "' from sys_system_code_jh where table_name='" + table_name + "'";

            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("등록이 완료되었습니다.");
            form.showAllData();
            this.Close();
        }

        


    }
}