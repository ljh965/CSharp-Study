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

                MessageBox.Show("ȸ������ �Ϸ�!");
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
                MessageBox.Show("���̵� �Է��ϼ���");
            }
            else
            {
                if (rdr.Read() == false)
                {
                    MessageBox.Show("ȸ�������� ������ ���̵��Դϴ�.");
                }
                while (rdr.Read())
                {
                    if (textBox_Id.Text.Equals(rdr["userId"].ToString()))
                    {
                        MessageBox.Show("�̹� �����ϴ� ���̵��Դϴ�.");
                    }
                }
            }
           
        }

        private bool EmptyCheck()
        {
            if (String.IsNullOrEmpty(textBox_Id.Text))
            {
                label_Error.Text = "ID�� �Է����ּ���";
                textBox_Id.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(textBox_Pw.Text))
            {
                label_Error.Text = "PW�� �Է����ּ���";
                textBox_Pw.Focus();
                return false;
            }
            else if (textBox_Pw.Text != textBox_PwConfirm.Text)
            {
                label_Error.Text = "PW�� Ȯ���ϼ���";
                textBox_Pw.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(textBox_Name.Text))
            {
                label_Error.Text = "�̸��� �Է��ϼ���";
                textBox_Name.Focus();
                return false;
            }
            return true;
        }
    }
}