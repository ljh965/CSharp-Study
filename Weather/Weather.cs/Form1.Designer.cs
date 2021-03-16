namespace Weather.cs
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
            this.comboBox_Region = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date1_State = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.date1_HighTemp = new System.Windows.Forms.Label();
            this.date1_LowTemp = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.date1_Date = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.date2_State = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.date2_HighTemp = new System.Windows.Forms.Label();
            this.date2_LowTemp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.date2_Date = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.date3_State = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.date3_HighTemp = new System.Windows.Forms.Label();
            this.date3_LowTemp = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.date3_Date = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.date4_State = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.date4_HighTemp = new System.Windows.Forms.Label();
            this.date4_LowTemp = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.date4_Date = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.date5_State = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.date5_HighTemp = new System.Windows.Forms.Label();
            this.date5_LowTemp = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.date5_Date = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.date6_State = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.date6_HighTemp = new System.Windows.Forms.Label();
            this.date6_LowTemp = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.date6_Date = new System.Windows.Forms.Label();
            this.textBox_Weather = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Region
            // 
            this.comboBox_Region.FormattingEnabled = true;
            this.comboBox_Region.Items.AddRange(new object[] {
            "서울",
            "인천",
            "수원",
            "춘천",
            "청주",
            "대전",
            "전주",
            "광주",
            "목포",
            "여수",
            "대구",
            "부산",
            "울산",
            "제주"});
            this.comboBox_Region.Location = new System.Drawing.Point(62, 11);
            this.comboBox_Region.Name = "comboBox_Region";
            this.comboBox_Region.Size = new System.Drawing.Size(111, 20);
            this.comboBox_Region.TabIndex = 0;
            this.comboBox_Region.SelectedIndexChanged += new System.EventHandler(this.comboBox_Region_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "지역 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "날짜 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "내용 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date1_State);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.date1_HighTemp);
            this.groupBox1.Controls.Add(this.date1_LowTemp);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.date1_Date);
            this.groupBox1.Location = new System.Drawing.Point(21, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 107);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // date1_State
            // 
            this.date1_State.AutoSize = true;
            this.date1_State.Location = new System.Drawing.Point(6, 78);
            this.date1_State.Name = "date1_State";
            this.date1_State.Size = new System.Drawing.Size(33, 12);
            this.date1_State.TabIndex = 2;
            this.date1_State.Text = "State";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "최고 :";
            // 
            // date1_HighTemp
            // 
            this.date1_HighTemp.AutoSize = true;
            this.date1_HighTemp.Location = new System.Drawing.Point(49, 57);
            this.date1_HighTemp.Name = "date1_HighTemp";
            this.date1_HighTemp.Size = new System.Drawing.Size(53, 12);
            this.date1_HighTemp.TabIndex = 2;
            this.date1_HighTemp.Text = "최고기온";
            // 
            // date1_LowTemp
            // 
            this.date1_LowTemp.AutoSize = true;
            this.date1_LowTemp.Location = new System.Drawing.Point(49, 36);
            this.date1_LowTemp.Name = "date1_LowTemp";
            this.date1_LowTemp.Size = new System.Drawing.Size(53, 12);
            this.date1_LowTemp.TabIndex = 2;
            this.date1_LowTemp.Text = "최저기온";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "최저 :";
            // 
            // date1_Date
            // 
            this.date1_Date.AutoSize = true;
            this.date1_Date.Location = new System.Drawing.Point(69, 17);
            this.date1_Date.Name = "date1_Date";
            this.date1_Date.Size = new System.Drawing.Size(30, 12);
            this.date1_Date.TabIndex = 1;
            this.date1_Date.Text = "Date";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(62, 40);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(30, 12);
            this.label_Date.TabIndex = 1;
            this.label_Date.Text = "Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.date2_State);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.date2_HighTemp);
            this.groupBox2.Controls.Add(this.date2_LowTemp);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.date2_Date);
            this.groupBox2.Location = new System.Drawing.Point(227, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 107);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // date2_State
            // 
            this.date2_State.AutoSize = true;
            this.date2_State.Location = new System.Drawing.Point(6, 78);
            this.date2_State.Name = "date2_State";
            this.date2_State.Size = new System.Drawing.Size(33, 12);
            this.date2_State.TabIndex = 2;
            this.date2_State.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "최고 :";
            // 
            // date2_HighTemp
            // 
            this.date2_HighTemp.AutoSize = true;
            this.date2_HighTemp.Location = new System.Drawing.Point(49, 57);
            this.date2_HighTemp.Name = "date2_HighTemp";
            this.date2_HighTemp.Size = new System.Drawing.Size(53, 12);
            this.date2_HighTemp.TabIndex = 2;
            this.date2_HighTemp.Text = "최고기온";
            // 
            // date2_LowTemp
            // 
            this.date2_LowTemp.AutoSize = true;
            this.date2_LowTemp.Location = new System.Drawing.Point(49, 36);
            this.date2_LowTemp.Name = "date2_LowTemp";
            this.date2_LowTemp.Size = new System.Drawing.Size(53, 12);
            this.date2_LowTemp.TabIndex = 2;
            this.date2_LowTemp.Text = "최저기온";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "최저 :";
            // 
            // date2_Date
            // 
            this.date2_Date.AutoSize = true;
            this.date2_Date.Location = new System.Drawing.Point(69, 17);
            this.date2_Date.Name = "date2_Date";
            this.date2_Date.Size = new System.Drawing.Size(30, 12);
            this.date2_Date.TabIndex = 1;
            this.date2_Date.Text = "Date";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.date3_State);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.date3_HighTemp);
            this.groupBox3.Controls.Add(this.date3_LowTemp);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.date3_Date);
            this.groupBox3.Location = new System.Drawing.Point(433, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 107);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // date3_State
            // 
            this.date3_State.AutoSize = true;
            this.date3_State.Location = new System.Drawing.Point(6, 78);
            this.date3_State.Name = "date3_State";
            this.date3_State.Size = new System.Drawing.Size(33, 12);
            this.date3_State.TabIndex = 2;
            this.date3_State.Text = "State";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "최고 :";
            // 
            // date3_HighTemp
            // 
            this.date3_HighTemp.AutoSize = true;
            this.date3_HighTemp.Location = new System.Drawing.Point(49, 57);
            this.date3_HighTemp.Name = "date3_HighTemp";
            this.date3_HighTemp.Size = new System.Drawing.Size(53, 12);
            this.date3_HighTemp.TabIndex = 2;
            this.date3_HighTemp.Text = "최고기온";
            // 
            // date3_LowTemp
            // 
            this.date3_LowTemp.AutoSize = true;
            this.date3_LowTemp.Location = new System.Drawing.Point(49, 36);
            this.date3_LowTemp.Name = "date3_LowTemp";
            this.date3_LowTemp.Size = new System.Drawing.Size(53, 12);
            this.date3_LowTemp.TabIndex = 2;
            this.date3_LowTemp.Text = "최저기온";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "최저 :";
            // 
            // date3_Date
            // 
            this.date3_Date.AutoSize = true;
            this.date3_Date.Location = new System.Drawing.Point(69, 17);
            this.date3_Date.Name = "date3_Date";
            this.date3_Date.Size = new System.Drawing.Size(30, 12);
            this.date3_Date.TabIndex = 1;
            this.date3_Date.Text = "Date";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.date4_State);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.date4_HighTemp);
            this.groupBox4.Controls.Add(this.date4_LowTemp);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.date4_Date);
            this.groupBox4.Location = new System.Drawing.Point(21, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 107);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // date4_State
            // 
            this.date4_State.AutoSize = true;
            this.date4_State.Location = new System.Drawing.Point(6, 78);
            this.date4_State.Name = "date4_State";
            this.date4_State.Size = new System.Drawing.Size(33, 12);
            this.date4_State.TabIndex = 2;
            this.date4_State.Text = "State";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "최고 :";
            // 
            // date4_HighTemp
            // 
            this.date4_HighTemp.AutoSize = true;
            this.date4_HighTemp.Location = new System.Drawing.Point(49, 57);
            this.date4_HighTemp.Name = "date4_HighTemp";
            this.date4_HighTemp.Size = new System.Drawing.Size(53, 12);
            this.date4_HighTemp.TabIndex = 2;
            this.date4_HighTemp.Text = "최고기온";
            // 
            // date4_LowTemp
            // 
            this.date4_LowTemp.AutoSize = true;
            this.date4_LowTemp.Location = new System.Drawing.Point(49, 36);
            this.date4_LowTemp.Name = "date4_LowTemp";
            this.date4_LowTemp.Size = new System.Drawing.Size(53, 12);
            this.date4_LowTemp.TabIndex = 2;
            this.date4_LowTemp.Text = "최저기온";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 12);
            this.label17.TabIndex = 2;
            this.label17.Text = "최저 :";
            // 
            // date4_Date
            // 
            this.date4_Date.AutoSize = true;
            this.date4_Date.Location = new System.Drawing.Point(69, 17);
            this.date4_Date.Name = "date4_Date";
            this.date4_Date.Size = new System.Drawing.Size(30, 12);
            this.date4_Date.TabIndex = 1;
            this.date4_Date.Text = "Date";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.date5_State);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.date5_HighTemp);
            this.groupBox5.Controls.Add(this.date5_LowTemp);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.date5_Date);
            this.groupBox5.Location = new System.Drawing.Point(227, 284);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 107);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // date5_State
            // 
            this.date5_State.AutoSize = true;
            this.date5_State.Location = new System.Drawing.Point(6, 78);
            this.date5_State.Name = "date5_State";
            this.date5_State.Size = new System.Drawing.Size(33, 12);
            this.date5_State.TabIndex = 2;
            this.date5_State.Text = "State";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 57);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 12);
            this.label20.TabIndex = 2;
            this.label20.Text = "최고 :";
            // 
            // date5_HighTemp
            // 
            this.date5_HighTemp.AutoSize = true;
            this.date5_HighTemp.Location = new System.Drawing.Point(49, 57);
            this.date5_HighTemp.Name = "date5_HighTemp";
            this.date5_HighTemp.Size = new System.Drawing.Size(53, 12);
            this.date5_HighTemp.TabIndex = 2;
            this.date5_HighTemp.Text = "최고기온";
            // 
            // date5_LowTemp
            // 
            this.date5_LowTemp.AutoSize = true;
            this.date5_LowTemp.Location = new System.Drawing.Point(49, 36);
            this.date5_LowTemp.Name = "date5_LowTemp";
            this.date5_LowTemp.Size = new System.Drawing.Size(53, 12);
            this.date5_LowTemp.TabIndex = 2;
            this.date5_LowTemp.Text = "최저기온";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 12);
            this.label21.TabIndex = 2;
            this.label21.Text = "최저 :";
            // 
            // date5_Date
            // 
            this.date5_Date.AutoSize = true;
            this.date5_Date.Location = new System.Drawing.Point(69, 17);
            this.date5_Date.Name = "date5_Date";
            this.date5_Date.Size = new System.Drawing.Size(30, 12);
            this.date5_Date.TabIndex = 1;
            this.date5_Date.Text = "Date";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.date6_State);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.date6_HighTemp);
            this.groupBox6.Controls.Add(this.date6_LowTemp);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.date6_Date);
            this.groupBox6.Location = new System.Drawing.Point(433, 284);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 107);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            // 
            // date6_State
            // 
            this.date6_State.AutoSize = true;
            this.date6_State.Location = new System.Drawing.Point(6, 78);
            this.date6_State.Name = "date6_State";
            this.date6_State.Size = new System.Drawing.Size(33, 12);
            this.date6_State.TabIndex = 2;
            this.date6_State.Text = "State";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 57);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 12);
            this.label24.TabIndex = 2;
            this.label24.Text = "최고 :";
            // 
            // date6_HighTemp
            // 
            this.date6_HighTemp.AutoSize = true;
            this.date6_HighTemp.Location = new System.Drawing.Point(49, 57);
            this.date6_HighTemp.Name = "date6_HighTemp";
            this.date6_HighTemp.Size = new System.Drawing.Size(53, 12);
            this.date6_HighTemp.TabIndex = 2;
            this.date6_HighTemp.Text = "최고기온";
            // 
            // date6_LowTemp
            // 
            this.date6_LowTemp.AutoSize = true;
            this.date6_LowTemp.Location = new System.Drawing.Point(49, 36);
            this.date6_LowTemp.Name = "date6_LowTemp";
            this.date6_LowTemp.Size = new System.Drawing.Size(53, 12);
            this.date6_LowTemp.TabIndex = 2;
            this.date6_LowTemp.Text = "최저기온";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 36);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(37, 12);
            this.label25.TabIndex = 2;
            this.label25.Text = "최저 :";
            // 
            // date6_Date
            // 
            this.date6_Date.AutoSize = true;
            this.date6_Date.Location = new System.Drawing.Point(69, 17);
            this.date6_Date.Name = "date6_Date";
            this.date6_Date.Size = new System.Drawing.Size(30, 12);
            this.date6_Date.TabIndex = 1;
            this.date6_Date.Text = "Date";
            // 
            // textBox_Weather
            // 
            this.textBox_Weather.Location = new System.Drawing.Point(62, 62);
            this.textBox_Weather.Multiline = true;
            this.textBox_Weather.Name = "textBox_Weather";
            this.textBox_Weather.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Weather.Size = new System.Drawing.Size(571, 103);
            this.textBox_Weather.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 429);
            this.Controls.Add(this.textBox_Weather);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Region);
            this.Name = "Form1";
            this.Text = "WeatherInfo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Region;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label date1_State;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label date1_Date;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label date2_State;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label date2_Date;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label date3_State;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label date3_Date;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label date4_State;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label date4_Date;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label date5_State;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label date5_Date;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label date6_State;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label date6_Date;
        private System.Windows.Forms.Label date1_HighTemp;
        private System.Windows.Forms.Label date1_LowTemp;
        private System.Windows.Forms.Label date2_HighTemp;
        private System.Windows.Forms.Label date2_LowTemp;
        private System.Windows.Forms.Label date3_HighTemp;
        private System.Windows.Forms.Label date3_LowTemp;
        private System.Windows.Forms.Label date4_HighTemp;
        private System.Windows.Forms.Label date4_LowTemp;
        private System.Windows.Forms.Label date5_HighTemp;
        private System.Windows.Forms.Label date5_LowTemp;
        private System.Windows.Forms.Label date6_HighTemp;
        private System.Windows.Forms.Label date6_LowTemp;
        private System.Windows.Forms.TextBox textBox_Weather;
    }
}

