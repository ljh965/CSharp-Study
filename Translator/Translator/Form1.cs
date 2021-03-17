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

        //파파고 번역 함수
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
        
        // 선택한 언어 확인
        public string confirmLang(ComboBox cb)
        {
            string text = cb.Text;
            switch (text)
            {
                case "한국어":
                    text = "ko";
                    break;
                case "영어":
                    text = "en";
                    break;
                case "일본어":
                    text = "ja";
                    break;
                case "중국어 간체":
                    text = "zh-CN";
                    break;
                case "중국어 번체":
                    text = "zh-TW";
                    break;
                case "베트남어":
                    text = "vi";
                    break;
                case "인도네시아어":
                    text = "id";
                    break;
                case "태국어":
                    text = "th";
                    break;
                case "독일어":
                    text = "de";
                    break;
                case "러시아어":
                    text = "ru";
                    break;
                case "스페인어":
                    text = "es";
                    break;
                case "이탈리아어":
                    text = "it";
                    break;
                case "프랑스어":
                    text = "fr";
                    break;
            }
            return text;
        }

        // 번역하기 버튼 클릭 이벤트
        private void btn_Translate_Click(object sender, EventArgs e)
        {
            if (cb_from.Text.Equals(cb_To.Text))
            {
                MessageBox.Show("번역할 언어설정을 서로 다르게 해주세요");
            }
            else if(!String.IsNullOrEmpty(tb_FromText.Text))
            {
                try
                {
                    tb_ToText.Text = getTranslatedText();
                }
                catch (System.Net.WebException)
                {
                    MessageBox.Show(cb_from.Text + "에서 " + cb_To.Text + "로의 번역은 지원하지 않습니다.", "ERROR" );
                }
                
            }
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
            string result = null;
            if (!String.IsNullOrEmpty(tb_FromText.Text))
            {
                string text = sensingLanguage();
                JObject obj = JObject.Parse(text);
                result = obj["langCode"].ToString();
            }
            return result;
        }

        // 텍스트 변경 시 언어감지
        private void tb_FromText_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_FromText.Text))
            {
                cb_from.Text = "한국어";
                tb_ToText.Text = null;
            }
            else
            {
                string text = codeToText();
                cb_from.Text = text;
            }
            
        }

        // 언어코드를 언어로 변환
        public string codeToText()
        {
            string text = getLanguageCode();
            switch (text)
            {
                case "ko":
                    text = "한국어";
                    break;
                case "ja":
                    text = "일본어";
                    break;
                case "zh-cn":
                    text = "중국어 간체";
                    break;
                case "zh-tw":
                    text = "중국어 번체";
                    break;
                case "en":
                    text = "영어";
                    break;
                case "es":
                    text = "스페인어";
                    break;
                case "fr":
                    text = "프랑스어";
                    break;
                case "de":
                    text = "독일어";
                    break;
                case "vi":
                    text = "베트남어";
                    break;
                case "id":
                    text = "인도네시아어";
                    break;
                case "th":
                    text = "태국어";
                    break;
                case "ru":
                    text = "러시아어";
                    break;
                case "it":
                    text = "이탈리아어";
                    break;
                default:
                    text = "알수없음";
                    break;
            }
            return text;

        }
    }
}