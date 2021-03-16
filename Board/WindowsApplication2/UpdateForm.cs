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
    public partial class UpdateForm : Form
    {
        MainForm pForm;
        string boardId;
        private string strConn = "Data Source=xe;User Id=scott;Password=tiger;";
        public UpdateForm(MainForm form,string bId)
        {
            boardId = bId;
            pForm = form;
            InitializeComponent();
            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM board WHERE boardId = '" + bId + "'";

            OracleDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                textBox_Subject.Text = rdr["subjectName"].ToString();
                textBox_ProName.Text = rdr["professorName"].ToString();
                textBox_Title.Text = rdr["subjectTitle"].ToString();
                comboBox_Year.Text = rdr["subjectYear"].ToString();
                comboBox_Semester.Text = rdr["semesterDivide"].ToString();
                textBox_Content.Text = rdr["subjectContent"].ToString();

                string content = rdr["subjectContent"].ToString();
                int len = content.Length / 30;
                while (len > 0)
                {
                    content = content.Insert((len * 30) - 1, Environment.NewLine);
                    len -= 1;
                }
            }
            rdr.Close();
            conn.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE board SET subjectName='" + textBox_Subject.Text + "', professorName='" + textBox_ProName.Text + "', subjectYear='" + comboBox_Year.Text + "', semesterDivide='" + comboBox_Semester.Text + "', subjectTitle='" + textBox_Title.Text + "', subjectContent='" + textBox_Content.Text + "' WHERE boardId='"+boardId+"'";

            cmd.ExecuteNonQuery();

            MessageBox.Show("수정 완료");
            this.Close();
            pForm.refresh();
            conn.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}