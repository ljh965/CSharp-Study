namespace WindowsApplication2
{
    partial class showBoard
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
            this.label_SubName = new System.Windows.Forms.Label();
            this.label_ProName = new System.Windows.Forms.Label();
            this.label_SubTitle = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Content = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_SubName
            // 
            this.label_SubName.AutoSize = true;
            this.label_SubName.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_SubName.Location = new System.Drawing.Point(29, 31);
            this.label_SubName.Name = "label_SubName";
            this.label_SubName.Size = new System.Drawing.Size(75, 24);
            this.label_SubName.TabIndex = 0;
            this.label_SubName.Text = "label1";
            // 
            // label_ProName
            // 
            this.label_ProName.AutoSize = true;
            this.label_ProName.Location = new System.Drawing.Point(340, 43);
            this.label_ProName.Name = "label_ProName";
            this.label_ProName.Size = new System.Drawing.Size(38, 12);
            this.label_ProName.TabIndex = 1;
            this.label_ProName.Text = "label1";
            // 
            // label_SubTitle
            // 
            this.label_SubTitle.AutoSize = true;
            this.label_SubTitle.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_SubTitle.Location = new System.Drawing.Point(30, 88);
            this.label_SubTitle.Name = "label_SubTitle";
            this.label_SubTitle.Size = new System.Drawing.Size(55, 16);
            this.label_SubTitle.TabIndex = 2;
            this.label_SubTitle.Text = "label1";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(340, 92);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(38, 12);
            this.label_Date.TabIndex = 3;
            this.label_Date.Text = "label1";
            // 
            // label_Content
            // 
            this.label_Content.AutoSize = true;
            this.label_Content.Location = new System.Drawing.Point(44, 152);
            this.label_Content.Name = "label_Content";
            this.label_Content.Size = new System.Drawing.Size(38, 12);
            this.label_Content.TabIndex = 4;
            this.label_Content.Text = "label1";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(438, 368);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Visible = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.Location = new System.Drawing.Point(357, 368);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(75, 23);
            this.btn_Modify.TabIndex = 5;
            this.btn_Modify.Text = "수정";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Visible = false;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // showBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 403);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label_Content);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_SubTitle);
            this.Controls.Add(this.label_ProName);
            this.Controls.Add(this.label_SubName);
            this.Name = "showBoard";
            this.Text = "showBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SubName;
        private System.Windows.Forms.Label label_ProName;
        private System.Windows.Forms.Label label_SubTitle;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Content;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Modify;
    }
}