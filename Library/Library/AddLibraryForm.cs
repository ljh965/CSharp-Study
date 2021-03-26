using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Oracle.DataAccess.Client;

namespace Library
{
    public partial class AddLibraryForm : Form
    {
        Cities city = new Cities();
        CreateCode code = new CreateCode();

        IndexForm form = new IndexForm();

        private string strConn = "Data Source=solution;User id=mighty_ems;Password=mighty_ems;";

        public AddLibraryForm(IndexForm pForm)
        {
            form = pForm;
            InitializeComponent();
        }

        private void AddLibraryForm_Load(object sender, EventArgs e)
        {
            ArrayList citylist = citylist = city.getCityCode();

            comboBox1.SelectedIndex = 0;
            comboBox2.Items.Clear();
            int index = comboBox1.SelectedIndex;

            string[] cities = (string[])citylist[index];
            for (int i = 0; i < cities.Length; i++)
            {
                comboBox2.Items.Add(cities[i]);
            }
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList citylist = citylist = city.getCityCode();
            comboBox2.Items.Clear();
            int index = comboBox1.SelectedIndex;
            string[] cities = (string[])citylist[index];
            for (int i = 0; i < cities.Length; i++)
            {
                comboBox2.Items.Add(cities[i]);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_Name.Text))
            {
                MessageBox.Show("도서관 이름을 입력해주세요");
            }
            else
            {
                char type = 'A';
                switch (comboBox3.SelectedIndex)
                {
                    case 0:
                        type = 'A';
                        break;
                    case 1:
                        type = 'B';
                        break;
                    case 2:
                        type = 'C';
                        break;
                    case 3:
                        type = 'D';
                        break;
                    case 4:
                        type = 'E';
                        break;
                    case 5:
                        type = 'F';
                        break;
                    case 6:
                        type = 'G';
                        break;
                }
                string cityCode = code.getCityCode(comboBox1.SelectedIndex, comboBox2.SelectedIndex);
                string libraryCode = code.getLibraryCode(comboBox1.SelectedIndex, comboBox2.SelectedIndex);
                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into sys_system_code_jh(plant,table_name,description,format_type) values('" + cityCode + "','" + libraryCode + "','" + tb_Name.Text + "','" + type + "')";

                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("등록이 완료되었습니다.");
                form.refresh();
                this.Close();
            }
        }

    }
}