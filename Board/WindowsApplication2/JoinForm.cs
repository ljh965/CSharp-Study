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
    public partial class JoinForm : Form
    {
        private string strConn = "Data Source=xe;User Id=scott;Password=tiger;";
        public JoinForm()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Join_Click(object sender, EventArgs e)
        {
            if (EmptyCheck())
            {
                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO b_user VALUES('" + textBox_Id.Text + "','" + textBox_Pw.Text + "','" + textBox_Name.Text + "')";

                cmd.ExecuteNonQuery();

                MessageBox.Show("회원가입 완료!");
                conn.Close();
                this.Close();
            }
    

        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT userId FROM b_user WHERE userId='"+textBox_Id.Text+"'";

            OracleDataReader rdr = cmd.ExecuteReader();
            if (String.IsNullOrEmpty(textBox_Id.Text))
            {
                MessageBox.Show("아이디를 입력하세요");
            }
            else
            {
                if (rdr.Read() == false)
                {
                    MessageBox.Show("회원가입이 가능한 아이디입니다.");
                }
                while (rdr.Read())
                {
                    if (textBox_Id.Text.Equals(rdr["userId"].ToString()))
                    {
                        MessageBox.Show("이미 존재하는 아이디입니다.");
                    }
                }
            }
           
        }

        private bool EmptyCheck()
        {
            if (String.IsNullOrEmpty(textBox_Id.Text))
            {
                label_Error.Text = "ID를 입력해주세요";
                textBox_Id.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(textBox_Pw.Text))
            {
                label_Error.Text = "PW를 입력해주세요";
                textBox_Pw.Focus();
                return false;
            }
            else if (textBox_Pw.Text != textBox_PwConfirm.Text)
            {
                label_Error.Text = "PW를 확인하세요";
                textBox_Pw.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(textBox_Name.Text))
            {
                label_Error.Text = "이름을 입력하세요";
                textBox_Name.Focus();
                return false;
            }
            return true;
        }
    }
}