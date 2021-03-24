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
    public partial class JoinForm : Form
    {
        private string strConn = "Data Source=solution;User Id=mighty_ems;Password=mighty_ems;";
        bool flag = false;

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
            string gender = "";
            if(rb_Man.Checked)
            {
                gender = "M";
            }
            else if(rb_Woman.Checked)
            {
                gender = "W";
            }
            // 중복확인을 하지 않으면 가입 불가
            if (flag)
            {
                if (EmptyCheck())
                {
                    OracleConnection conn = new OracleConnection(strConn);
                    conn.Open();

                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO sys_system_code_jh(plant,table_name,description,format_type,group_desc) VALUES('" + textBox_Id.Text + "','" + textBox_Name.Text + "','" + textBox_Pw.Text + "','" + gender + "','"+tb_Number1.Text+"-"+tb_Number2.Text+"')";

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("회원가입 완료!");
                    conn.Close();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("중복확인을 해주세요");
            }


        }

        // 중복확인
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Id.Text))
            {
                MessageBox.Show("아이디를 입력하세요");
            }
            
            else
            {
                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT plant FROM sys_system_code_jh WHERE plant='" + textBox_Id.Text + "'";

                OracleDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("이미 존재하는 아이디입니다.");
                }
                else
                {
                    MessageBox.Show("회원가입이 가능한 아이디입니다.");
                    flag = true;
                }
                conn.Close();
            }

        }

        // 비어있는 값 확인
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
                label_Error.Text = "PW가 서로 다릅니다";
                textBox_Pw.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(textBox_Name.Text))
            {
                label_Error.Text = "이름을 입력하세요";
                textBox_Name.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(tb_Number1.Text))
            {
                label_Error.Text = "주민번호를 입력하세요";
                tb_Number1.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(tb_Number2.Text))
            {
                label_Error.Text = "주민번호를 입력하세요";
                tb_Number2.Focus();
                return false;
            }
            return true;
        }
    }
}