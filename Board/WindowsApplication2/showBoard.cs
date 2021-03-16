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
    public partial class showBoard : Form
    {
        string boardId;
        MainForm pForm;
        private string strConn = "Data Source=xe;User Id=scott;Password=tiger;";
        public showBoard(MainForm form,string bId)
        {
            boardId = bId;
            pForm = form;
            InitializeComponent();
            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM board WHERE boardId = '" +bId+"'";

            OracleDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                string userId = rdr["userId"].ToString();
                label_SubName.Text = rdr["subjectName"].ToString();
                label_ProName.Text = rdr["professorName"].ToString();
                label_SubTitle.Text = rdr["subjectTitle"].ToString();
                label_Date.Text = rdr["subjectYear"].ToString() + rdr["semesterDivide"].ToString();
                
                string content = rdr["subjectContent"].ToString();
                int len = content.Length / 30;
                while (len > 0)
                {
                    content = content.Insert((len * 30) - 1, Environment.NewLine);
                    len -= 1;
                }
                label_Content.Text = content;

                if(userId.Equals(Properties.Settings.Default.LoginIDSave))
                {
                    btn_Delete.Visible = true;
                    btn_Modify.Visible = true;
                }
            }
            rdr.Close();
            conn.Close();
        }


        private void btn_Modify_Click(object sender, EventArgs e)
        {
            UpdateForm uForm = new UpdateForm(pForm, boardId);
            uForm.ShowDialog();
            this.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM board WHERE boardId='"+ boardId +"'";

            cmd.ExecuteNonQuery();
            MessageBox.Show("삭제 완료");
            pForm.refresh();
            conn.Close();
            this.Close();
        }
    }
}