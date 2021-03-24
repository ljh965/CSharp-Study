namespace CSharp_Project
{
    partial class FindForm
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
            this.btn_FindID = new System.Windows.Forms.Button();
            this.findID_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.findPW_Name = new System.Windows.Forms.TextBox();
            this.btn_FindPW = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.findPW_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Error1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.findID_Number2 = new System.Windows.Forms.TextBox();
            this.findID_Number1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.findPW_Number2 = new System.Windows.Forms.TextBox();
            this.findPW_Number1 = new System.Windows.Forms.TextBox();
            this.lb_Error2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_FindID
            // 
            this.btn_FindID.Location = new System.Drawing.Point(171, 88);
            this.btn_FindID.Name = "btn_FindID";
            this.btn_FindID.Size = new System.Drawing.Size(91, 21);
            this.btn_FindID.TabIndex = 14;
            this.btn_FindID.Text = "ID 찾기";
            this.btn_FindID.UseVisualStyleBackColor = true;
            this.btn_FindID.Click += new System.EventHandler(this.btn_FindID_Click);
            // 
            // findID_Name
            // 
            this.findID_Name.Location = new System.Drawing.Point(89, 30);
            this.findID_Name.Name = "findID_Name";
            this.findID_Name.Size = new System.Drawing.Size(172, 21);
            this.findID_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "주민번호 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "이   름    :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.findID_Number2);
            this.groupBox1.Controls.Add(this.findID_Number1);
            this.groupBox1.Controls.Add(this.lb_Error1);
            this.groupBox1.Controls.Add(this.findID_Name);
            this.groupBox1.Controls.Add(this.btn_FindID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(40, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 119);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "아이디 찾기";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.findPW_Number2);
            this.groupBox2.Controls.Add(this.findPW_Number1);
            this.groupBox2.Controls.Add(this.lb_Error2);
            this.groupBox2.Controls.Add(this.findPW_Name);
            this.groupBox2.Controls.Add(this.btn_FindPW);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.findPW_ID);
            this.groupBox2.Location = new System.Drawing.Point(40, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 153);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "비밀번호 찾기";
            // 
            // findPW_Name
            // 
            this.findPW_Name.Location = new System.Drawing.Point(89, 30);
            this.findPW_Name.Name = "findPW_Name";
            this.findPW_Name.Size = new System.Drawing.Size(172, 21);
            this.findPW_Name.TabIndex = 4;
            // 
            // btn_FindPW
            // 
            this.btn_FindPW.Location = new System.Drawing.Point(171, 117);
            this.btn_FindPW.Name = "btn_FindPW";
            this.btn_FindPW.Size = new System.Drawing.Size(91, 21);
            this.btn_FindPW.TabIndex = 14;
            this.btn_FindPW.Text = "PW 찾기";
            this.btn_FindPW.UseVisualStyleBackColor = true;
            this.btn_FindPW.Click += new System.EventHandler(this.btn_FindPW_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "이   름    :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "아 이 디  :";
            // 
            // findPW_ID
            // 
            this.findPW_ID.Location = new System.Drawing.Point(89, 61);
            this.findPW_ID.Name = "findPW_ID";
            this.findPW_ID.Size = new System.Drawing.Size(172, 21);
            this.findPW_ID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "주민번호 :";
            // 
            // lb_Error1
            // 
            this.lb_Error1.AutoSize = true;
            this.lb_Error1.ForeColor = System.Drawing.Color.Red;
            this.lb_Error1.Location = new System.Drawing.Point(27, 92);
            this.lb_Error1.Name = "lb_Error1";
            this.lb_Error1.Size = new System.Drawing.Size(0, 12);
            this.lb_Error1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 29;
            this.label6.Text = "-";
            // 
            // findID_Number2
            // 
            this.findID_Number2.Location = new System.Drawing.Point(184, 60);
            this.findID_Number2.Name = "findID_Number2";
            this.findID_Number2.Size = new System.Drawing.Size(77, 21);
            this.findID_Number2.TabIndex = 3;
            this.findID_Number2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.findID_Number2_KeyDown);
            // 
            // findID_Number1
            // 
            this.findID_Number1.Location = new System.Drawing.Point(89, 60);
            this.findID_Number1.Name = "findID_Number1";
            this.findID_Number1.Size = new System.Drawing.Size(77, 21);
            this.findID_Number1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 32;
            this.label7.Text = "-";
            // 
            // findPW_Number2
            // 
            this.findPW_Number2.Location = new System.Drawing.Point(184, 90);
            this.findPW_Number2.Name = "findPW_Number2";
            this.findPW_Number2.Size = new System.Drawing.Size(77, 21);
            this.findPW_Number2.TabIndex = 7;
            this.findPW_Number2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.findPW_Number2_KeyDown);
            // 
            // findPW_Number1
            // 
            this.findPW_Number1.Location = new System.Drawing.Point(89, 90);
            this.findPW_Number1.Name = "findPW_Number1";
            this.findPW_Number1.Size = new System.Drawing.Size(77, 21);
            this.findPW_Number1.TabIndex = 6;
            // 
            // lb_Error2
            // 
            this.lb_Error2.AutoSize = true;
            this.lb_Error2.ForeColor = System.Drawing.Color.Red;
            this.lb_Error2.Location = new System.Drawing.Point(27, 121);
            this.lb_Error2.Name = "lb_Error2";
            this.lb_Error2.Size = new System.Drawing.Size(0, 12);
            this.lb_Error2.TabIndex = 15;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FindForm";
            this.Text = "아이디/비밀번호찾기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_FindID;
        private System.Windows.Forms.TextBox findID_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox findPW_Name;
        private System.Windows.Forms.Button btn_FindPW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox findPW_ID;
        private System.Windows.Forms.Label lb_Error1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox findID_Number2;
        private System.Windows.Forms.TextBox findID_Number1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox findPW_Number2;
        private System.Windows.Forms.TextBox findPW_Number1;
        private System.Windows.Forms.Label lb_Error2;
    }
}