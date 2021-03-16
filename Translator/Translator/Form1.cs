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

        //파파고 번역 함수
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
        
        // 선택한 언어 확인
        public void confirmLang()
        {
            switch (cb_from.Text)
            {
                case "한국어":
                    flang = "ko";
                    break;
                case "영어":
                    flang = "en";
                    break;
                case "일본어":
                    flang = "ja";
                    break;
                case "중국어 간체":
                    flang = "zh-CN";
                    break;
                case "중국어 번체":
                    flang = "zh-TW";
                    break;
                case "베트남어":
                    flang = "vi";
                    break;
                case "인도네시아어":
                    flang = "id";
                    break;
                case "태국어":
                    flang = "th";
                    break;
                case "독일어":
                    flang = "de";
                    break;
                case "러시아어":
                    flang = "ru";
                    break;
                case "스페인어":
                    flang = "es";
                    break;
                case "이탈리아어":
                    flang = "it";
                    break;
                case "프랑스어":
                    flang = "fr";
                    break;
            }
            switch (cb_To.Text)
            {
                case "한국어":
                    tlang = "ko";
                    break;
                case "영어":
                    tlang = "en";
                    break;
                case "일본어":
                    tlang = "ja";
                    break;
                case "중국어 간체":
                    tlang = "zh-CN";
                    break;
                case "중국어 번체":
                    tlang = "zh-TW";
                    break;
                case "베트남어":
                    tlang = "vi";
                    break;
                case "인도네시아어":
                    tlang = "id";
                    break;
                case "태국어":
                    tlang = "th";
                    break;
                case "독일어":
                    tlang = "de";
                    break;
                case "러시아어":
                    tlang = "ru";
                    break;
                case "스페인어":
                    tlang = "es";
                    break;
                case "이탈리아어":
                    tlang = "it";
                    break;
                case "프랑스어":
                    tlang = "fr";
                    break;
            }
        }

        // 번역하기 버튼 클릭 이벤트
        private void btn_Translate_Click(object sender, EventArgs e)
        {
            tb_ToText.Text = getTranslatedText();
            MessageBox.Show(getLanguageCode());
        }
        
        // 번역함수의 반환값에서 번역한 내용만 추출
        public string getTranslatedText()
        {
            string text = translate();
            JObject obj = JObject.Parse(text);
            JObject message = JObject.Parse(obj["message"].ToString());
            JObject result = JObject.Parse(message["result"].ToString());
            string translatedText = result["translatedText"].ToString();

            return translatedText;
        }
        
        // 언어감지 함수
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

        // 언어감지 함수의 반환값에서 언어코드만 추출
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