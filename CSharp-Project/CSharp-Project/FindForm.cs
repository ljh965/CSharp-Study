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
    public partial class FindForm : Form
    {
        private string strConn = "Data Source=solution;User Id=mighty_ems;Password=mighty_ems;";
        OracleConnection conn = null;
        OracleCommand cmd = null;
        public FindForm()
        {
            InitializeComponent();
        }

        private void findID_Number2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btn_FindID_Click(sender, e);
                btn_FindID.Select();
            }
        }

        private void findPW_Number2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btn_FindPW_Click(sender, e);
                btn_FindPW.Select();
            }
        }

        // 아이디 찾기
        private void btn_FindID_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(findID_Name.Text))
            {
                lb_Error1.Text = "이름을 입력하세요";
                findID_Name.Focus();
            }
            else if (String.IsNullOrEmpty(findID_Number1.Text))
            {
                lb_Error1.Text = "주민번호를 입력하세요";
                findID_Number1.Focus();
            }
            else if (String.IsNullOrEmpty(findID_Number2.Text))
            {
                lb_Error1.Text = "주민번호를 입력하세요";
                findID_Number2.Focus();
            }
            else
            {
                string name = findID_Name.Text;
                string number = findID_Number1.Text + "-" + findID_Number2.Text;

                conn = new OracleConnection(strConn);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT plant FROM sys_system_code_jh WHERE table_name='" + name + "' AND group_desc='" + number + "'";

                OracleDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    MessageBox.Show("ID : " + rdr["plant"].ToString());
                }
                else
                {
                    MessageBox.Show("입력하신 정보가 존재하지 않습니다.");
                }
                rdr.Close();
                conn.Close();
            }  
        }

        // 패스워드 찾기
        private void btn_FindPW_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(findPW_Name.Text))
            {
                lb_Error2.Text = "이름을 입력하세요";
                findPW_Name.Focus();
            }
            else if (String.IsNullOrEmpty(findPW_ID.Text))
            {
                lb_Error2.Text = "아이디를 입력하세요";
                findPW_ID.Focus();
            }
            else if (String.IsNullOrEmpty(findPW_Number1.Text))
            {
                lb_Error2.Text = "주민번호를 입력하세요";
                findPW_Number1.Focus();
            }
            else if (String.IsNullOrEmpty(findPW_Number2.Text))
            {
                lb_Error2.Text = "주민번호를 입력하세요";
                findPW_Number2.Focus();
            }
            else
            {
                string name = findPW_Name.Text;
                string id = findPW_ID.Text;
                string number = findPW_Number1.Text + "-" + findPW_Number2.Text;

                conn = new OracleConnection(strConn);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT description FROM sys_system_code_jh WHERE table_name='" + name + "'AND plant='" + id + "' AND group_desc='" + number + "'";

                OracleDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    MessageBox.Show("비밀번호를 변경해주세요");
                    UpdateForm form = new UpdateForm(id);
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("입력하신 정보가 존재하지 않습니다.");
                }
                rdr.Close();
                conn.Close();
            }
        }

    }
}