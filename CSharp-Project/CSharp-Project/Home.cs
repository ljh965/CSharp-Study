using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Net;
using Newtonsoft.Json.Linq;
using System.IO;


namespace CSharp_Project
{
    public partial class Home : Form
    {
        Product pd = new Product();
        ArrayList arrlist = new ArrayList();
        int currentPage = 0;
        int lastPage = 0;
        int start = 1;
        int total = 0;
        public Home()
        {
            InitializeComponent();
        }

        // �α����� ���ϸ� �̿�Ұ�
        private void Home_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            DialogResult result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("�α��� ����");
            }
            else
            {
                Application.Exit();
            }

            cb_sort.SelectedIndex = 0;
            btn_Previous.Enabled = false;
            lb_ID.Text = Properties.Settings.Default.LoginIDSave + "�� �ȳ��ϼ���!";
        }

        private void search(string query,int pageNumber)
        {
            
            if(String.IsNullOrEmpty(tb_Search.Text))
            {
                MessageBox.Show("�˻�� �Է����ּ���");
            }
            else if (tb_Search.Text.Trim().Length < 2)
            {
                MessageBox.Show("�˻���� �α��� �̻� �Է����ּ���");
            }
            else
            {
                if (currentPage == 0)
                {
                    btn_Previous.Enabled = false;
                }
                else
                {
                    btn_Previous.Enabled = true;
                }

                listView1.Items.Clear();
                
                string text = String.Empty;
                string sort = String.Empty;
                start = pageNumber * 25 + 1;
                
                if (cb_sort.Text.Equals("��Ȯ����"))
                {
                    sort = "sim";
                }
                else if (cb_sort.Text.Equals("��¥��"))
                {
                    sort = "date";
                }
                else if (cb_sort.Text.Equals("���ݳ�����"))
                {
                    sort = "asc";
                }
                else if (cb_sort.Text.Equals("���ݳ�����"))
                {
                    sort = "dsc";
                }
                string url = "https://openapi.naver.com/v1/search/shop?query=" + query + "&sort=" + sort + "&display=25&start=" + start; // ����� JSON ����
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Headers.Add("X-Naver-Client-Id", "H6hxrOHL_SSjrfBcUmqs"); // Ŭ���̾�Ʈ ���̵�
                request.Headers.Add("X-Naver-Client-Secret", "4qBNJ7iE1m");       // Ŭ���̾�Ʈ ��ũ��
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string status = response.StatusCode.ToString();
                if (status == "OK")
                {
                    Stream stream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    text = reader.ReadToEnd();
                }

                JObject obj = JObject.Parse(text);
                JArray items = JArray.Parse(obj["items"].ToString());
                foreach (JObject item in items)
                {
                    Product product = new Product();
                    product.MallName = item["mallName"].ToString();
                    product.ProductID = item["productId"].ToString();
                    product.ProductType = item["productType"].ToString();
                    product.Title = item["title"].ToString().Replace("<b>", "").Replace("</b>", "");
                    product.Lprice = String.Format("{0:#,0}",Int32.Parse(item["lprice"].ToString()))+"��";
                    product.Brand = item["brand"].ToString();
                    product.Maker = item["maker"].ToString();
                    product.Type = item["productType"].ToString();
                    type(product);
                    product.Link = item["link"].ToString();
                    product.Image = item["image"].ToString();
                    product.Category1 = item["category1"].ToString();
                    product.Category1 = item["category2"].ToString();
                    product.Category1 = item["category3"].ToString();
                    product.Category1 = item["category4"].ToString();

                    arrlist.Add(product);
                }
            }
        }

        // �˻��� ���� ��������
        private void getTotal(string query)
        {
            string text = String.Empty;
            string url = "https://openapi.naver.com/v1/search/shop?query=" + query; // ����� JSON ����
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", "H6hxrOHL_SSjrfBcUmqs"); // Ŭ���̾�Ʈ ���̵�
            request.Headers.Add("X-Naver-Client-Secret", "4qBNJ7iE1m");       // Ŭ���̾�Ʈ ��ũ��
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string status = response.StatusCode.ToString();
            if (status == "OK")
            {
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                text = reader.ReadToEnd();
            }

            JObject obj = JObject.Parse(text);
            total = Int32.Parse(obj["total"].ToString());
        }

        // ��ǰ Ÿ�� �з�
        private void type(Product product)
        {

            if (product.Type.Equals("1") || product.Type.Equals("2") || product.Type.Equals("3"))
            {
                product.TypeDetail1 = "�Ϲݻ�ǰ";
                if (product.Type.Equals("1"))
                {
                    product.TypeDetail2 = "���ݺ񱳻�ǰ";
                }
                else if (product.Type.Equals("2"))
                {
                    product.TypeDetail2 = "���Ī��ǰ";
                }
                else if (product.Type.Equals("3"))
                {
                    product.TypeDetail2 = "��Ī��ǰ";
                }
            }
            else if (product.Type.Equals("4") || product.Type.Equals("5") || product.Type.Equals("6"))
            {
                product.TypeDetail1 = "�߰��ǰ";
                if (product.Type.Equals("4"))
                {
                    product.TypeDetail2 = "���ݺ� ��ǰ";
                }
                else if (product.Type.Equals("5"))
                {
                    product.TypeDetail2 = "���Ī��ǰ";
                }
                else if (product.Type.Equals("6"))
                {
                    product.TypeDetail2 = "��Ī��ǰ";
                }
            }
            else if (product.Type.Equals("7") || product.Type.Equals("8") || product.Type.Equals("9"))
            {
                product.TypeDetail1 = "������ǰ";
                if (product.Type.Equals("7"))
                {
                    product.TypeDetail2 = "���ݺ񱳻�ǰ";
                }
                else if (product.Type.Equals("8"))
                {
                    product.TypeDetail2 = "���Ī��ǰ";
                }
                else if (product.Type.Equals("9"))
                {
                    product.TypeDetail2 = "��Ī��ǰ";
                }
            }
            else if (product.Type.Equals("10") || product.Type.Equals("11") || product.Type.Equals("12"))
            {
                product.TypeDetail1 = "�Ǹſ�����ǰ";
                if (product.Type.Equals("10"))
                {
                    product.TypeDetail2 = "���ݺ񱳻�ǰ";
                }
                else if (product.Type.Equals("11"))
                {
                    product.TypeDetail2 = "���Ī��ǰ";
                }
                else if (product.Type.Equals("12"))
                {
                    product.TypeDetail2 = "��Ī��ǰ";
                }
            }

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            getTotal(tb_Search.Text);
            if(total % 25 == 0)
            {
                lastPage = total / 25;
            }
            else
            {
                lastPage = (total/25)+1;
            }
            search(tb_Search.Text,currentPage);
            try
            {
                if (currentPage != lastPage-1)
                {
                    for (int i = currentPage * 25; i < currentPage * 25 + 25; i++)
                    {
                        Product product = (Product)arrlist[i];
                        ListViewItem item = new ListViewItem(product.MallName);
                        item.SubItems.Add(product.Title);
                        item.SubItems.Add(product.Lprice);
                        item.SubItems.Add(product.Link);
                        item.SubItems.Add(product.Image);

                        listView1.Items.Add(item);
                    }
                }
                else
                {
                    btn_Next.Enabled = false;
                    for (int i = currentPage * 25; i < currentPage*25 + (total%25); i++)
                    {
                        Product product = (Product)arrlist[i];
                        ListViewItem item = new ListViewItem(product.MallName);
                        item.SubItems.Add(product.Title);
                        item.SubItems.Add(product.Lprice);
                        item.SubItems.Add(product.Link);
                        item.SubItems.Add(product.Image);

                        listView1.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("�˻������ �����ϴ�.");
            }
            
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            currentPage--;
            btn_Search_Click(sender, e);
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            currentPage++;
            btn_Search_Click(sender, e);
        }

        // ������ �����ϸ� ó������ �ٽð˻�
        private void cb_sort_TextChanged(object sender, EventArgs e)
        {
            currentPage = 0;
            arrlist.Clear();
        }
        
        // �˻�� �����ϸ� ó������ �ٽð˻�
        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            currentPage = 0;
            arrlist.Clear();
        }

        
        // �÷� ������ ����
        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        // �˻��� �Է��� ���� ������ �˻�
        private void tb_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btn_Search_Click(sender, e);
                btn_Search.Select();
            }
        }
        
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listView1.SelectedIndices[0] + start - 1 ;
            Product product = (Product)arrlist[index];
            ProductForm form = new ProductForm(this, product);
            form.ShowDialog();
        }


        // �˻� ��� ������ Ŭ����
        public class Product
        {
            private string mallName;
            private string productID;
            private string productType;
            private string title;
            private string lprice;
            private string brand;
            private string maker;
            private string type;
            private string typeDetail1;
            private string typeDetail2;
            private string link;
            private string image;
            private string category1;
            private string category2;
            private string category3;
            private string category4;

            public string MallName
            {
                get { return mallName; }
                set { mallName = value; }
            }

            public string ProductID
            {
                get { return productID; }
                set { productID = value; }
            }

            public string ProductType
            {
                get { return productType; }
                set { productType = value; }
            }

            public string Title
            {
                get { return title; }
                set { title = value; }
            }

            public string Lprice
            {
                get { return lprice; }
                set { lprice = value; }
            }

            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }

            public string Maker
            {
                get { return maker; }
                set { maker = value; }
            }
            public string Type
            {
                get { return type; }
                set { type = value; }
            }
            public string TypeDetail1
            {
                get { return typeDetail1; }
                set { typeDetail1 = value; }
            }

            public string TypeDetail2
            {
                get { return typeDetail2; }
                set { typeDetail2 = value; }
            }
            public string Link
            {
                get { return link; }
                set { link = value; }
            }
            public string Image
            {
                get { return image; }
                set { image = value; }
            }
            public string Category1
            {
                get { return category1; }
                set { category1 = value; }
            }
            public string Category2
            {
                get { return category2; }
                set { category2 = value; }
            }
            public string Category3
            {
                get { return category3; }
                set { category3 = value; }
            }
            public string Category4
            {
                get { return category4; }
                set { category4 = value; }
            }

        }

        private void btn_Basket_Click(object sender, EventArgs e)
        {
            BasketForm form = new BasketForm();
            form.ShowDialog();
        }
    }
}