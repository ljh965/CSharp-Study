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
    
    public partial class LoginForm : Form
    {
        private string strConn = "Data Source=xe;User Id=scott;Password=tiger;";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox_Pw_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.Enter))
            {
                btn_Login_Click(sender, e);
                btn_Login.Select();
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string id = textBox_Id.Text;
            string pw = textBox_Pw.Text;

            if (EmptyCheck())
            {
                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT userId,userPw FROM b_user where userId='" + id + "'";
                OracleDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (id == rdr["userId"].ToString() && pw == rdr["userPw"].ToString())
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        label_Error.Text = "입력하신 정보가 올바르지 않습니다,";
                    }
                }
                label_Error.Text = "입력하신 정보가 올바르지 않습니다,";
                
            }

            Properties.Settings.Default.LoginIDSave = textBox_Id.Text;
            Properties.Settings.Default.Save();
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
            return true;
        }

        private void btn_Join_Click(object sender, EventArgs e)
        {
            JoinForm JoinForm = new JoinForm();
            JoinForm.ShowDialog();
        }
    }
}