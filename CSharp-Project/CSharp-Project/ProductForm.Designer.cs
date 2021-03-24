namespace CSharp_Project
{
    partial class ProductForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.lb_Title = new System.Windows.Forms.Label();
            this.lb_Price = new System.Windows.Forms.Label();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Image
            // 
            this.pb_Image.Location = new System.Drawing.Point(12, 12);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(395, 351);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Image.TabIndex = 0;
            this.pb_Image.TabStop = false;
            // 
            // lb_Title
            // 
            this.lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_Title.AutoEllipsis = true;
            this.lb_Title.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lb_Title, 2);
            this.lb_Title.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Title.Location = new System.Drawing.Point(55, 0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(324, 27);
            this.lb_Title.TabIndex = 1;
            this.lb_Title.Text = "TitleTitleTitleTitleTitleTitle";
            // 
            // lb_Price
            // 
            this.lb_Price.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_Price.AutoSize = true;
            this.lb_Price.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Price.Location = new System.Drawing.Point(387, 248);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(44, 16);
            this.lb_Price.TabIndex = 2;
            this.lb_Price.Text = "Price";
            // 
            // btn_Buy
            // 
            this.btn_Buy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Buy.Location = new System.Drawing.Point(3, 292);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(211, 56);
            this.btn_Buy.TabIndex = 3;
            this.btn_Buy.Text = "구매하기";
            this.btn_Buy.UseVisualStyleBackColor = true;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Save.Location = new System.Drawing.Point(220, 292);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(211, 56);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "장바구니에 담기";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Buy, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Price, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Save, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Title, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(413, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 351);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 389);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pb_Image);
            this.Name = "ProductForm";
            this.Text = "상품정보";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}