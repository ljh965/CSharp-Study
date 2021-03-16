namespace WindowsApplication2
{
    partial class InsertForm
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
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.comboBox_Year = new System.Windows.Forms.ComboBox();
            this.comboBox_Semester = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Subject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Content = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ProName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(62, 86);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(175, 21);
            this.textBox_Title.TabIndex = 2;
            // 
            // comboBox_Year
            // 
            this.comboBox_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Year.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_Year.FormattingEnabled = true;
            this.comboBox_Year.Items.AddRange(new object[] {
            "2020년",
            "2019년",
            "2018년",
            "2017년",
            "2016년",
            "2015년",
            "2014년",
            "2013년",
            "2012년"});
            this.comboBox_Year.Location = new System.Drawing.Point(243, 87);
            this.comboBox_Year.Name = "comboBox_Year";
            this.comboBox_Year.Size = new System.Drawing.Size(77, 20);
            this.comboBox_Year.TabIndex = 3;
            // 
            // comboBox_Semester
            // 
            this.comboBox_Semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Semester.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_Semester.FormattingEnabled = true;
            this.comboBox_Semester.Items.AddRange(new object[] {
            "1학기",
            "2학기"});
            this.comboBox_Semester.Location = new System.Drawing.Point(326, 87);
            this.comboBox_Semester.Name = "comboBox_Semester";
            this.comboBox_Semester.Size = new System.Drawing.Size(77, 20);
            this.comboBox_Semester.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "제  목  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "강의명 :";
            // 
            // textBox_Subject
            // 
            this.textBox_Subject.Location = new System.Drawing.Point(62, 16);
            this.textBox_Subject.Name = "textBox_Subject";
            this.textBox_Subject.Size = new System.Drawing.Size(175, 21);
            this.textBox_Subject.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "내  용  :";
            // 
            // textBox_Content
            // 
            this.textBox_Content.Location = new System.Drawing.Point(62, 124);
            this.textBox_Content.Multiline = true;
            this.textBox_Content.Name = "textBox_Content";
            this.textBox_Content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Content.Size = new System.Drawing.Size(341, 209);
            this.textBox_Content.TabIndex = 5;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(245, 345);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 6;
            this.btn_Insert.Text = "등록";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(328, 345);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "취소";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "교수명 :";
            // 
            // textBox_ProName
            // 
            this.textBox_ProName.Location = new System.Drawing.Point(62, 51);
            this.textBox_ProName.Name = "textBox_ProName";
            this.textBox_ProName.Size = new System.Drawing.Size(100, 21);
            this.textBox_ProName.TabIndex = 1;
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 385);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ProName);
            this.Controls.Add(this.textBox_Subject);
            this.Controls.Add(this.textBox_Content);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.comboBox_Semester);
            this.Controls.Add(this.comboBox_Year);
            this.Name = "InsertForm";
            this.Text = "등록";
            this.Load += new System.EventHandler(this.InsertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.ComboBox comboBox_Year;
        private System.Windows.Forms.ComboBox comboBox_Semester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Subject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Content;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ProName;
    }
}