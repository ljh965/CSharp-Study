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
        public Form1()
        {
            InitializeComponent();
            cb_from.SelectedIndex = 0;
            cb_To.SelectedIndex = 1;
        }

        //���İ� ���� �Լ�
        public string translate()
        {
            string flang = confirmLang(cb_from);
            string tlang = confirmLang(cb_To);
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
        public string confirmLang(ComboBox cb)
        {
            string text = cb.Text;
            switch (text)
            {
                case "�ѱ���":
                    text = "ko";
                    break;
                case "����":
                    text = "en";
                    break;
                case "�Ϻ���":
                    text = "ja";
                    break;
                case "�߱��� ��ü":
                    text = "zh-CN";
                    break;
                case "�߱��� ��ü":
                    text = "zh-TW";
                    break;
                case "��Ʈ����":
                    text = "vi";
                    break;
                case "�ε��׽þƾ�":
                    text = "id";
                    break;
                case "�±���":
                    text = "th";
                    break;
                case "���Ͼ�":
                    text = "de";
                    break;
                case "���þƾ�":
                    text = "ru";
                    break;
                case "�����ξ�":
                    text = "es";
                    break;
                case "��Ż���ƾ�":
                    text = "it";
                    break;
                case "��������":
                    text = "fr";
                    break;
            }
            return text;
        }

        // �����ϱ� ��ư Ŭ�� �̺�Ʈ
        private void btn_Translate_Click(object sender, EventArgs e)
        {
            if (cb_from.Text.Equals(cb_To.Text))
            {
                MessageBox.Show("������ ������ ���� �ٸ��� ���ּ���");
            }
            else if(!String.IsNullOrEmpty(tb_FromText.Text))
            {
                try
                {
                    tb_ToText.Text = getTranslatedText();
                }
                catch (System.Net.WebException)
                {
                    MessageBox.Show(cb_from.Text + "���� " + cb_To.Text + "���� ������ �������� �ʽ��ϴ�.", "ERROR" );
                }
                
            }
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
            string result = null;
            if (!String.IsNullOrEmpty(tb_FromText.Text))
            {
                string text = sensingLanguage();
                JObject obj = JObject.Parse(text);
                result = obj["langCode"].ToString();
            }
            return result;
        }

        // �ؽ�Ʈ ���� �� ����
        private void tb_FromText_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_FromText.Text))
            {
                cb_from.Text = "�ѱ���";
                tb_ToText.Text = null;
            }
            else
            {
                string text = codeToText();
                cb_from.Text = text;
            }
            
        }

        // ����ڵ带 ���� ��ȯ
        public string codeToText()
        {
            string text = getLanguageCode();
            switch (text)
            {
                case "ko":
                    text = "�ѱ���";
                    break;
                case "ja":
                    text = "�Ϻ���";
                    break;
                case "zh-cn":
                    text = "�߱��� ��ü";
                    break;
                case "zh-tw":
                    text = "�߱��� ��ü";
                    break;
                case "en":
                    text = "����";
                    break;
                case "es":
                    text = "�����ξ�";
                    break;
                case "fr":
                    text = "��������";
                    break;
                case "de":
                    text = "���Ͼ�";
                    break;
                case "vi":
                    text = "��Ʈ����";
                    break;
                case "id":
                    text = "�ε��׽þƾ�";
                    break;
                case "th":
                    text = "�±���";
                    break;
                case "ru":
                    text = "���þƾ�";
                    break;
                case "it":
                    text = "��Ż���ƾ�";
                    break;
                default:
                    text = "�˼�����";
                    break;
            }
            return text;

        }
    }
}