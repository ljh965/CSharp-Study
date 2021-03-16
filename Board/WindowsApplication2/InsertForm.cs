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
    public partial class InsertForm : Form
    {
        MainForm pForm;
        private string strConn = "Data Source=xe;User Id=scott;Password=tiger;";
        public InsertForm()
        {
            InitializeComponent();
        }
        public InsertForm(MainForm form)
        {
            InitializeComponent();
            pForm = form;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string subName = textBox_Subject.Text.ToString();
            string proName = textBox_ProName.Text.ToString();
            string subTitle = textBox_Title.Text.ToString();
            string subYear = comboBox_Year.Text.ToString();
            string semester = comboBox_Semester.Text.ToString();
            string subContent = textBox_Content.Text.ToString();
            if (String.IsNullOrEmpty(subName) || String.IsNullOrEmpty(proName) || String.IsNullOrEmpty(subTitle) || String.IsNullOrEmpty(subYear) || String.IsNullOrEmpty(semester) || String.IsNullOrEmpty(subContent))
            {
                MessageBox.Show("빈 항목이 있습니다.");
            }
            else
            {
                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO board VALUES(boardId.NEXTVAL,'" + Properties.Settings.Default.LoginIDSave + "','" + subName + "','" + proName + "','" + subYear + "','" + semester + "','" + subTitle + "','" + subContent + "','" + DateTime.Now.ToString("yy-MM-dd HH:mm") + "')";

                cmd.ExecuteNonQuery();

                conn.Close();
                pForm.refresh();
                MessageBox.Show("등록 성공!");
                this.Close();
            }
            
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            comboBox_Semester.SelectedIndex = 0;
            comboBox_Year.SelectedIndex = 0;
        }

    }
}