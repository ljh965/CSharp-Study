using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Weather.cs
{
    public partial class Form1 : Form
    {
        string strURL = "https://www.weather.go.kr/weather/forecast/mid-term-rss3.jsp";
        string strCity = "";
        public Form1()
        {
            InitializeComponent();

            comboBox_Region.SelectedIndex = 0;
            label_Date.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void comboBox_Region_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                XmlReader xr = XmlReader.Create(strURL);
                string strMsg = "";
                bool flag = false;
                int iCount = 0;
                strCity = comboBox_Region.Text;

                while (xr.Read())
                {
                    if(xr.NodeType.Equals(XmlNodeType.CDATA))
                    {
                        textBox_Weather.Text = xr.Value.ToString().Replace("<br />", Environment.NewLine).Replace("\t","");
                    }
                    else if(xr.NodeType.Equals(XmlNodeType.Text))
                    {
                        if (xr.Value.Equals(strCity))
                        {
                            flag = true;
                        }
                        if (flag)
                        {
                            
                            DateTime dt;
                            bool b = DateTime.TryParse(xr.Value.ToString(), out dt);
                            if (b)
                            {
                                strMsg += "/";
                            }
                            strMsg += xr.Value + ",";
                            iCount += 1;
                            if (iCount > 66)
                            {
                                flag = false;
                            }
                        }
                    }
                }
                string[] strTmp = strMsg.Split('/');

                string[] strWh1 = strTmp[1].Split(',');
                date1_Date.Text = strWh1[0].Substring(0, 10);
                date1_LowTemp.Text = strWh1[2] + "กษ";
                date1_HighTemp.Text = strWh1[3] + "กษ";
                date1_State.Text = strWh1[1];

                string[] strWh2 = strTmp[3].Split(',');
                date2_Date.Text = strWh2[0].Substring(0, 10); ;
                date2_LowTemp.Text = strWh2[2] + "กษ";
                date2_HighTemp.Text = strWh2[3] + "กษ";
                date2_State.Text = strWh2[1];

                string[] strWh3 = strTmp[5].Split(',');
                date3_Date.Text = strWh3[0].Substring(0, 10); ;
                date3_LowTemp.Text = strWh3[2] + "กษ";
                date3_HighTemp.Text = strWh3[3] + "กษ";
                date3_State.Text = strWh3[1];

                string[] strWh4 = strTmp[7].Split(',');
                date4_Date.Text = strWh4[0].Substring(0, 10); ;
                date4_LowTemp.Text = strWh4[2] + "กษ";
                date4_HighTemp.Text = strWh4[3] + "กษ";
                date4_State.Text = strWh4[1];

                string[] strWh5 = strTmp[9].Split(',');
                date5_Date.Text = strWh5[0].Substring(0, 10); ;
                date5_LowTemp.Text = strWh5[2] + "กษ";
                date5_HighTemp.Text = strWh5[3] + "กษ";
                date5_State.Text = strWh5[1];

                string[] strWh6 = strTmp[11].Split(',');
                date6_Date.Text = strWh6[0].Substring(0, 10); ;
                date6_LowTemp.Text = strWh6[2] + "กษ";
                date6_HighTemp.Text = strWh6[3] + "กษ";
                date6_State.Text = strWh6[1];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

    }
}
            