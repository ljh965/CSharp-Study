using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Translator
{
    public partial class Form1 : Form
    {
        string flang = "";
        string tlang = "";
        public Form1()
        {
            InitializeComponent();
            cb_from.SelectedIndex = 0;
            cb_To.SelectedIndex = 1;
        }

        //���İ� ���� �Լ�
        public string translate()
        {
            confirmLang();
            string url = "https://openapi.naver.com/v1/papago/n2mt";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", "u7rbm1QXKT4xnFi_vQ4H");
            request.Headers.Add("X-Naver-Client-Secret", "JOiA9XrQRG");
            request.Method = "POST";

            string query = tb_FromText.Text;
            byte[] byteDataParams = Encoding.UTF8.GetBytes("source=" + flang + "&target=" + tlang + "&text=" + query);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteDataParams.Length;

            Stream st = request.GetRequestStream();
            st.Write(byteDataParams, 0, byteDataParams.Length);
            st.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string text = reader.ReadToEnd();
            stream.Close();
            response.Close();
            reader.Close();

            return text;
        }
        
        // ������ ��� Ȯ��
        public void confirmLang()
        {
            switch (cb_from.Text)
            {
                case "�ѱ���":
                    flang = "ko";
                    break;
                case "����":
                    flang = "en";
                    break;
                case "�Ϻ���":
                    flang = "ja";
                    break;
                case "�߱��� ��ü":
                    flang = "zh-CN";
                    break;
                case "�߱��� ��ü":
                    flang = "zh-TW";
                    break;
                case "��Ʈ����":
                    flang = "vi";
                    break;
                case "�ε��׽þƾ�":
                    flang = "id";
                    break;
                case "�±���":
                    flang = "th";
                    break;
                case "���Ͼ�":
                    flang = "de";
                    break;
                case "���þƾ�":
                    flang = "ru";
                    break;
                case "�����ξ�":
                    flang = "es";
                    break;
                case "��Ż���ƾ�":
                    flang = "it";
                    break;
                case "��������":
                    flang = "fr";
                    break;
            }
            switch (cb_To.Text)
            {
                case "�ѱ���":
                    tlang = "ko";
                    break;
                case "����":
                    tlang = "en";
                    break;
                case "�Ϻ���":
                    tlang = "ja";
                    break;
                case "�߱��� ��ü":
                    tlang = "zh-CN";
                    break;
                case "�߱��� ��ü":
                    tlang = "zh-TW";
                    break;
                case "��Ʈ����":
                    tlang = "vi";
                    break;
                case "�ε��׽þƾ�":
                    tlang = "id";
                    break;
                case "�±���":
                    tlang = "th";
                    break;
                case "���Ͼ�":
                    tlang = "de";
                    break;
                case "���þƾ�":
                    tlang = "ru";
                    break;
                case "�����ξ�":
                    tlang = "es";
                    break;
                case "��Ż���ƾ�":
                    tlang = "it";
                    break;
                case "��������":
                    tlang = "fr";
                    break;
            }
        }

        // �����ϱ� ��ư Ŭ�� �̺�Ʈ
        private void btn_Translate_Click(object sender, EventArgs e)
        {
            tb_ToText.Text = getTranslatedText();
            MessageBox.Show(getLanguageCode());
        }
        
        // �����Լ��� ��ȯ������ ������ ���븸 ����
        public string getTranslatedText()
        {
            string text = translate();
            JObject obj = JObject.Parse(text);
            JObject message = JObject.Parse(obj["message"].ToString());
            JObject result = JObject.Parse(message["result"].ToString());
            string translatedText = result["translatedText"].ToString();

            return translatedText;
        }
        
        // ���� �Լ�
        public string sensingLanguage()
        {
            string url = "https://openapi.naver.com/v1/papago/detectLangs";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", "__dBWBV50517by2a_XhD");
            request.Headers.Add("X-Naver-Client-Secret", "Qqd_aKo3O6");
            request.Method = "POST";
            string query = tb_FromText.Text;
            byte[] byteDataParams = Encoding.UTF8.GetBytes("query=" + query);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteDataParams.Length;
            Stream st = request.GetRequestStream();
            st.Write(byteDataParams, 0, byteDataParams.Length);
            st.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string text = reader.ReadToEnd();
            stream.Close();
            response.Close();
            reader.Close();

            return text;
        }

        // ���� �Լ��� ��ȯ������ ����ڵ常 ����
        public string getLanguageCode()
        {
            string text = sensingLanguage();
            JObject obj = JObject.Parse(text);
            string result = obj["langCode"].ToString();

            return result;
        }

        private void tb_FromText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}