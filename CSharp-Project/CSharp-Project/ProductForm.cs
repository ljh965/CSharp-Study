using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace CSharp_Project
{
    public partial class ProductForm : Form
    {
        Home.Product product = new Home.Product();
        private string strConn = "Data Source=solution;User id=mighty_ems;Password=mighty_ems;";
        string link = String.Empty;
        public ProductForm(Home form, Home.Product homeProduct)
        {
            InitializeComponent();
            product = homeProduct;
            pb_Image.ImageLocation = product.Image;
            if (product.Title.Length >= 50)
            {
                lb_Title.Text = product.Title.Substring(0, 49);
            }
            else
            {
                lb_Title.Text = product.Title;
            }
            lb_Price.Text = product.Lprice;
            link = product.Link;
        }
    
        // 상품 구매 페이지로 이동
        private void btn_Buy_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(link);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("장바구니에 담으시겠습니까 ?","장바구니 담기",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO sys_system_code_jh_data VALUES('" + Properties.Settings.Default.LoginIDSave + "','" + product.MallName + "','" + product.ProductID + "','" + product.ProductType + "','" + product.Title + "','" + product.Lprice + "','" + product.Brand + "','" + product.Maker + "','" + product.TypeDetail1 + "','" + product.TypeDetail2 + "','" + product.Link + "','" + product.Category1 + "','" + product.Category2 + "','" + product.Category3 + "','" + product.Category4 + "',NULL)";

                cmd.ExecuteNonQuery();
                MessageBox.Show("장바구니에 담았습니다.");

                conn.Close();
            }
            

        }
        
    }
}