namespace LibraryManagementSystem
{
    partial class StopUseSeat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.seatNumlabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seatNumlabel
            // 
            this.seatNumlabel.AutoSize = true;
            this.seatNumlabel.ForeColor = System.Drawing.Color.Silver;
            this.seatNumlabel.Location = new System.Drawing.Point(92, 32);
            this.seatNumlabel.Name = "seatNumlabel";
            this.seatNumlabel.Size = new System.Drawing.Size(17, 12);
            this.seatNumlabel.TabIndex = 15;
            this.seatNumlabel.Text = "00";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.Color.Silver;
            this.NameLabel.Location = new System.Drawing.Point(176, 91);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(70, 12);
            this.NameLabel.TabIndex = 14;
            this.NameLabel.Text = "NameLabel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(106, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "이름 :";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.ForeColor = System.Drawing.Color.Silver;
            this.TimeLabel.Location = new System.Drawing.Point(176, 121);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(65, 12);
            this.TimeLabel.TabIndex = 12;
            this.TimeLabel.Text = "TimeLabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(50, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "사용 시작시간 : ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(115, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "번 자리이용을 중단하시겟습니까?";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.ForeColor = System.Drawing.Color.Silver;
            this.endTimeLabel.Location = new System.Drawing.Point(176, 151);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(86, 12);
            this.endTimeLabel.TabIndex = 17;
            this.endTimeLabel.Text = "endTimeLabel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(50, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "사용 종료시간 : ";
            // 
            // StopUseSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(367, 269);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.seatNumlabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "StopUseSeat";
            this.Text = "StopUseSeat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StopUseSeat_FormClosed);
            this.Load += new System.EventHandler(this.StopUseSeat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label seatNumlabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label label4;
    }
}