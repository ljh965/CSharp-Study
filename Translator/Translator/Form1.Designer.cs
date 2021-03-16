namespace Translator
{
    partial class Form1
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
            this.cb_from = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_FromText = new System.Windows.Forms.TextBox();
            this.btn_Translate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_ToText = new System.Windows.Forms.TextBox();
            this.cb_To = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_from
            // 
            this.cb_from.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_from.FormattingEnabled = true;
            this.cb_from.Items.AddRange(new object[] {
            "한국어",
            "영어",
            "일본어",
            "중국어 간체",
            "중국어 번체",
            "베트남어",
            "인도네시아어",
            "태국어",
            "독일어",
            "러시아어",
            "스페인어",
            "이탈리아어",
            "프랑스어"});
            this.cb_from.Location = new System.Drawing.Point(6, 20);
            this.cb_from.Name = "cb_from";
            this.cb_from.Size = new System.Drawing.Size(121, 20);
            this.cb_from.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_FromText);
            this.groupBox1.Controls.Add(this.cb_from);
            this.groupBox1.Controls.Add(this.btn_Translate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 298);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tb_FromText
            // 
            this.tb_FromText.Location = new System.Drawing.Point(6, 51);
            this.tb_FromText.Multiline = true;
            this.tb_FromText.Name = "tb_FromText";
            this.tb_FromText.Size = new System.Drawing.Size(329, 206);
            this.tb_FromText.TabIndex = 1;
            this.tb_FromText.TextChanged += new System.EventHandler(this.tb_FromText_TextChanged);
            // 
            // btn_Translate
            // 
            this.btn_Translate.Location = new System.Drawing.Point(247, 260);
            this.btn_Translate.Name = "btn_Translate";
            this.btn_Translate.Size = new System.Drawing.Size(88, 32);
            this.btn_Translate.TabIndex = 2;
            this.btn_Translate.Text = "번역하기";
            this.btn_Translate.UseVisualStyleBackColor = true;
            this.btn_Translate.Click += new System.EventHandler(this.btn_Translate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_ToText);
            this.groupBox2.Controls.Add(this.cb_To);
            this.groupBox2.Location = new System.Drawing.Point(378, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 298);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // tb_ToText
            // 
            this.tb_ToText.Location = new System.Drawing.Point(6, 51);
            this.tb_ToText.Multiline = true;
            this.tb_ToText.Name = "tb_ToText";
            this.tb_ToText.ReadOnly = true;
            this.tb_ToText.Size = new System.Drawing.Size(329, 206);
            this.tb_ToText.TabIndex = 1;
            // 
            // cb_To
            // 
            this.cb_To.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_To.FormattingEnabled = true;
            this.cb_To.Items.AddRange(new object[] {
            "한국어",
            "영어",
            "일본어",
            "중국어 간체",
            "중국어 번체",
            "베트남어",
            "인도네시아어",
            "태국어",
            "독일어",
            "러시아어",
            "스페인어",
            "이탈리아어",
            "프랑스어"});
            this.cb_To.Location = new System.Drawing.Point(6, 20);
            this.cb_To.Name = "cb_To";
            this.cb_To.Size = new System.Drawing.Size(121, 20);
            this.cb_To.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 327);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_from;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Translate;
        private System.Windows.Forms.TextBox tb_FromText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_ToText;
        private System.Windows.Forms.ComboBox cb_To;
    }
}

