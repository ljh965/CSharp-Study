namespace CSharp_Project
{
    partial class LoginForm
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
            this.label_Error = new System.Windows.Forms.Label();
            this.btn_Join = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.textBox_Pw = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(78, 123);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(0, 12);
            this.label_Error.TabIndex = 10;
            // 
            // btn_Join
            // 
            this.btn_Join.Location = new System.Drawing.Point(266, 82);
            this.btn_Join.Name = "btn_Join";
            this.btn_Join.Size = new System.Drawing.Size(91, 21);
            this.btn_Join.TabIndex = 8;
            this.btn_Join.Text = "회원가입";
            this.btn_Join.UseVisualStyleBackColor = true;
            this.btn_Join.Click += new System.EventHandler(this.btn_Join_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(266, 52);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(91, 21);
            this.btn_Login.TabIndex = 9;
            this.btn_Login.Text = "로그인";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // textBox_Pw
            // 
            this.textBox_Pw.Location = new System.Drawing.Point(78, 82);
            this.textBox_Pw.Name = "textBox_Pw";
            this.textBox_Pw.PasswordChar = '*';
            this.textBox_Pw.Size = new System.Drawing.Size(172, 21);
            this.textBox_Pw.TabIndex = 7;
            this.textBox_Pw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Pw_KeyDown);
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(78, 52);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(172, 21);
            this.textBox_Id.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "PW :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "I D  :";
            // 
            // lb_Info
            // 
            this.lb_Info.AutoSize = true;
            this.lb_Info.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Info.ForeColor = System.Drawing.Color.Red;
            this.lb_Info.Location = new System.Drawing.Point(280, 123);
            this.lb_Info.Name = "lb_Info";
            this.lb_Info.Size = new System.Drawing.Size(76, 12);
            this.lb_Info.TabIndex = 11;
            this.lb_Info.Text = " ID/PW 찾기 ";
            this.lb_Info.Click += new System.EventHandler(this.lb_Info_Click);
            this.lb_Info.MouseEnter += new System.EventHandler(this.lb_Info_MouseEnter);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 187);
            this.Controls.Add(this.lb_Info);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.btn_Join);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.textBox_Pw);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.Button btn_Join;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox textBox_Pw;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Info;
    }
}