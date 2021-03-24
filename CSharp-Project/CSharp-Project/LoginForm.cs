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
    public partial class LoginForm : Form
    {
        private string strConn = "Data Source=solution;User Id=mighty_ems;Password=mighty_ems;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox_Pw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btn_Login_Click(sender, e);
                btn_Login.Select();
            }
        }

        // 로그인 버튼 클릭 시 아이디와 비밀번호 확인
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
                cmd.CommandText = "SELECT plant FROM sys_system_code_jh WHERE plant='" + id + "' AND description='" + pw + "'";
                OracleDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    this.DialogResult = DialogResult.OK;
                    Properties.Settings.Default.LoginIDSave = id;
                    Properties.Settings.Default.Save();
                    this.Close();
                }
                else
                {
                    label_Error.Text = "입력하신 정보가 올바르지 않습니다.";
                }
                rdr.Close();
                conn.Close();
            }
        }

        // 로그인창 텍스트 확인
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

        // 회원가입 클릭
        private void btn_Join_Click(object sender, EventArgs e)
        {
            JoinForm JoinForm = new JoinForm();
            JoinForm.ShowDialog();
        }

        private void lb_Info_Click(object sender, EventArgs e)
        {
            FindForm form = new FindForm();
            form.ShowDialog();
        }

        private void lb_Info_MouseEnter(object sender, EventArgs e)
        {
            lb_Info.Cursor = Cursors.Hand;
        }
    }
}