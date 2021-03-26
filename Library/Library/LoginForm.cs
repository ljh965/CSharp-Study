using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string adminID = Properties.Settings.Default.AdminID;
            string adminPW = Properties.Settings.Default.AdminPW;
            if (textBox_Id.Text.Equals(adminID))
            {
                if (textBox_Pw.Text.Equals(adminPW))
                {
                    Properties.Settings.Default.Status = true;
                    MessageBox.Show("�α��� ����");
                    this.Close();
                }
                else
                {
                    label_Error.Text = "��й�ȣ�� Ʋ���ϴ�.";
                    textBox_Pw.Focus();
                }
            }
            else
            {
                label_Error.Text = "���̵� Ʋ���ϴ�.";
                textBox_Id.Focus();
            }
        }
    }
}