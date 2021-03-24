namespace CSharp_Project
{
    partial class UpdateForm
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
            this.label_PwConfirm = new System.Windows.Forms.Label();
            this.textBox_PwConfirm = new System.Windows.Forms.TextBox();
            this.textBox_Pw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label_Error = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_PwConfirm
            // 
            this.label_PwConfirm.AutoSize = true;
            this.label_PwConfirm.ForeColor = System.Drawing.Color.Red;
            this.label_PwConfirm.Location = new System.Drawing.Point(298, 116);
            this.label_PwConfirm.Name = "label_PwConfirm";
            this.label_PwConfirm.Size = new System.Drawing.Size(0, 12);
            this.label_PwConfirm.TabIndex = 29;
            // 
            // textBox_PwConfirm
            // 
            this.textBox_PwConfirm.Location = new System.Drawing.Point(84, 61);
            this.textBox_PwConfirm.Name = "textBox_PwConfirm";
            this.textBox_PwConfirm.PasswordChar = '*';
            this.textBox_PwConfirm.Size = new System.Drawing.Size(172, 21);
            this.textBox_PwConfirm.TabIndex = 26;
            // 
            // textBox_Pw
            // 
            this.textBox_Pw.Location = new System.Drawing.Point(84, 33);
            this.textBox_Pw.Name = "textBox_Pw";
            this.textBox_Pw.PasswordChar = '*';
            this.textBox_Pw.Size = new System.Drawing.Size(172, 21);
            this.textBox_Pw.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "PW확인 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "PW :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Error);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_PwConfirm);
            this.groupBox1.Controls.Add(this.textBox_Pw);
            this.groupBox1.Location = new System.Drawing.Point(40, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 124);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "비밀번호 변경";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(181, 88);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 29;
            this.btn_Update.Text = "변경";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(30, 92);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(0, 12);
            this.label_Error.TabIndex = 30;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 290);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_PwConfirm);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_PwConfirm;
        private System.Windows.Forms.TextBox textBox_PwConfirm;
        private System.Windows.Forms.TextBox textBox_Pw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label_Error;
    }
}