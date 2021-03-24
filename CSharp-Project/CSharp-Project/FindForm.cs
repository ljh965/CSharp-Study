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

        // ���̵� ã��
        private void btn_FindID_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(findID_Name.Text))
            {
                lb_Error1.Text = "�̸��� �Է��ϼ���";
                findID_Name.Focus();
            }
            else if (String.IsNullOrEmpty(findID_Number1.Text))
            {
                lb_Error1.Text = "�ֹι�ȣ�� �Է��ϼ���";
                findID_Number1.Focus();
            }
            else if (String.IsNullOrEmpty(findID_Number2.Text))
            {
                lb_Error1.Text = "�ֹι�ȣ�� �Է��ϼ���";
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
                    MessageBox.Show("�Է��Ͻ� ������ �������� �ʽ��ϴ�.");
                }
                rdr.Close();
                conn.Close();
            }  
        }

        // �н����� ã��
        private void btn_FindPW_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(findPW_Name.Text))
            {
                lb_Error2.Text = "�̸��� �Է��ϼ���";
                findPW_Name.Focus();
            }
            else if (String.IsNullOrEmpty(findPW_ID.Text))
            {
                lb_Error2.Text = "���̵� �Է��ϼ���";
                findPW_ID.Focus();
            }
            else if (String.IsNullOrEmpty(findPW_Number1.Text))
            {
                lb_Error2.Text = "�ֹι�ȣ�� �Է��ϼ���";
                findPW_Number1.Focus();
            }
            else if (String.IsNullOrEmpty(findPW_Number2.Text))
            {
                lb_Error2.Text = "�ֹι�ȣ�� �Է��ϼ���";
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
                    MessageBox.Show("��й�ȣ�� �������ּ���");
                    UpdateForm form = new UpdateForm(id);
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("�Է��Ͻ� ������ �������� �ʽ��ϴ�.");
                }
                rdr.Close();
                conn.Close();
            }
        }

    }
}