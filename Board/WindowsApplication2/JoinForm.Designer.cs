namespace WindowsApplication2
{
    partial class JoinForm
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
            this.btn_Join = new System.Windows.Forms.Button();
            this.textBox_Pw = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_PwConfirm = new System.Windows.Forms.TextBox();
            this.label_Error = new System.Windows.Forms.Label();
            this.label_PwConfirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Join
            // 
            this.btn_Join.Location = new System.Drawing.Point(109, 164);
            this.btn_Join.Name = "btn_Join";
            this.btn_Join.Size = new System.Drawing.Size(77, 21);
            this.btn_Join.TabIndex = 8;
            this.btn_Join.Text = "회원가입";
            this.btn_Join.UseVisualStyleBackColor = true;
            this.btn_Join.Click += new System.EventHandler(this.btn_Join_Click);
            // 
            // textBox_Pw
            // 
            this.textBox_Pw.Location = new System.Drawing.Point(109, 61);
            this.textBox_Pw.Name = "textBox_Pw";
            this.textBox_Pw.PasswordChar = '*';
            this.textBox_Pw.Size = new System.Drawing.Size(172, 21);
            this.textBox_Pw.TabIndex = 1;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(109, 31);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(172, 21);
            this.textBox_Id.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "PW :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "I D  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "이름:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(109, 116);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(172, 21);
            this.textBox_Name.TabIndex = 3;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(204, 164);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(77, 21);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "취소";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(288, 31);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 21);
            this.btn_Confirm.TabIndex = 9;
            this.btn_Confirm.Text = "중복확인";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "PW확인 :";
            // 
            // textBox_PwConfirm
            // 
            this.textBox_PwConfirm.Location = new System.Drawing.Point(109, 89);
            this.textBox_PwConfirm.Name = "textBox_PwConfirm";
            this.textBox_PwConfirm.PasswordChar = '*';
            this.textBox_PwConfirm.Size = new System.Drawing.Size(172, 21);
            this.textBox_PwConfirm.TabIndex = 2;
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(113, 145);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(0, 12);
            this.label_Error.TabIndex = 10;
            // 
            // label_PwConfirm
            // 
            this.label_PwConfirm.AutoSize = true;
            this.label_PwConfirm.ForeColor = System.Drawing.Color.Red;
            this.label_PwConfirm.Location = new System.Drawing.Point(288, 94);
            this.label_PwConfirm.Name = "label_PwConfirm";
            this.label_PwConfirm.Size = new System.Drawing.Size(0, 12);
            this.label_PwConfirm.TabIndex = 11;
            // 
            // JoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 195);
            this.Controls.Add(this.label_PwConfirm);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Join);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_PwConfirm);
            this.Controls.Add(this.textBox_Pw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JoinForm";
            this.Text = "Join";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Join;
        private System.Windows.Forms.TextBox textBox_Pw;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_PwConfirm;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.Label label_PwConfirm;
    }
}