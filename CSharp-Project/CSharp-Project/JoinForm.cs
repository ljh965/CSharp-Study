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
            // �ߺ�Ȯ���� ���� ������ ���� �Ұ�
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

                    MessageBox.Show("ȸ������ �Ϸ�!");
                    conn.Close();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("�ߺ�Ȯ���� ���ּ���");
            }


        }

        // �ߺ�Ȯ��
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Id.Text))
            {
                MessageBox.Show("���̵� �Է��ϼ���");
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
                    MessageBox.Show("�̹� �����ϴ� ���̵��Դϴ�.");
                }
                else
                {
                    MessageBox.Show("ȸ�������� ������ ���̵��Դϴ�.");
                    flag = true;
                }
                conn.Close();
            }

        }

        // ����ִ� �� Ȯ��
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
                label_Error.Text = "PW�� ���� �ٸ��ϴ�";
                textBox_Pw.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(textBox_Name.Text))
            {
                label_Error.Text = "�̸��� �Է��ϼ���";
                textBox_Name.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(tb_Number1.Text))
            {
                label_Error.Text = "�ֹι�ȣ�� �Է��ϼ���";
                tb_Number1.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(tb_Number2.Text))
            {
                label_Error.Text = "�ֹι�ȣ�� �Է��ϼ���";
                tb_Number2.Focus();
                return false;
            }
            return true;
        }
    }
}