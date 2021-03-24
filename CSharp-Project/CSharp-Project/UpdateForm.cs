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
    public partial class UpdateForm : Form
    {
        private string strConn = "Data Source=solution;User Id=mighty_ems;Password=mighty_ems;";
        OracleConnection conn = null;
        OracleCommand cmd = null;
        private string id = null;
        public UpdateForm(string userid)
        {
            InitializeComponent();
            id = userid;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Pw.Text) || String.IsNullOrEmpty(textBox_PwConfirm.Text))
            {
                label_Error.Text = "���� �Է��ϼ���";
            }
            else if (textBox_Pw.Text != textBox_PwConfirm.Text)
            {
                label_Error.Text = "�н����尡 ���� �ٸ��ϴ�.";
                textBox_Pw.Focus();
            }
            else
            {
                conn = new OracleConnection(strConn);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE sys_system_code_jh SET description='"+ textBox_Pw.Text +"' WHERE plant='"+ id +"'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("��й�ȣ�� ����Ǿ����ϴ�.");
                this.Close();
                conn.Close();
            }
        }

        
    }
}