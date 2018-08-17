namespace _4G记录仪北斗平台位置推送
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_ServerIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_logon = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_UseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_FtpObjectivePath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.te_Port = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.te_IP = new System.Windows.Forms.TextBox();
            this.te_Password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.te_username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_OpenPath = new System.Windows.Forms.Button();
            this.te_path = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_StartSend = new System.Windows.Forms.Button();
            this.btn_StopSend = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_ServerIP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_logout);
            this.groupBox2.Controls.Add(this.btn_logon);
            this.groupBox2.Controls.Add(this.tb_Password);
            this.groupBox2.Controls.Add(this.tb_UseName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(196, 151);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "系统登录";
            // 
            // tb_ServerIP
            // 
            this.tb_ServerIP.Location = new System.Drawing.Point(64, 18);
            this.tb_ServerIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_ServerIP.Name = "tb_ServerIP";
            this.tb_ServerIP.Size = new System.Drawing.Size(107, 21);
            this.tb_ServerIP.TabIndex = 8;
            this.tb_ServerIP.Text = "119.23.161.197";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "服务器IP";
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(90, 108);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(50, 28);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "退出";
            this.btn_logout.UseVisualStyleBackColor = true;
            // 
            // btn_logon
            // 
            this.btn_logon.Location = new System.Drawing.Point(11, 108);
            this.btn_logon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_logon.Name = "btn_logon";
            this.btn_logon.Size = new System.Drawing.Size(50, 28);
            this.btn_logon.TabIndex = 5;
            this.btn_logon.Text = "登录";
            this.btn_logon.UseVisualStyleBackColor = true;
            this.btn_logon.Click += new System.EventHandler(this.btn_logon_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(64, 79);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(107, 21);
            this.tb_Password.TabIndex = 3;
            this.tb_Password.Text = "000000";
            // 
            // tb_UseName
            // 
            this.tb_UseName.Location = new System.Drawing.Point(64, 46);
            this.tb_UseName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_UseName.Name = "tb_UseName";
            this.tb_UseName.PasswordChar = '*';
            this.tb_UseName.Size = new System.Drawing.Size(107, 21);
            this.tb_UseName.TabIndex = 2;
            this.tb_UseName.Text = "hengan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(9, 184);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1036, 238);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "状态命令框";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 10;
            this.listBox1.Location = new System.Drawing.Point(14, 18);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1006, 214);
            this.listBox1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_FtpObjectivePath);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.te_Port);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.te_IP);
            this.groupBox3.Controls.Add(this.te_Password);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.te_username);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btn_OpenPath);
            this.groupBox3.Controls.Add(this.te_path);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(271, 22);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(775, 151);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参数设置";
            // 
            // tb_FtpObjectivePath
            // 
            this.tb_FtpObjectivePath.Location = new System.Drawing.Point(535, 82);
            this.tb_FtpObjectivePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_FtpObjectivePath.Name = "tb_FtpObjectivePath";
            this.tb_FtpObjectivePath.PasswordChar = '*';
            this.tb_FtpObjectivePath.Size = new System.Drawing.Size(223, 21);
            this.tb_FtpObjectivePath.TabIndex = 24;
            this.tb_FtpObjectivePath.Text = "/home/beidou/ftp/";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(462, 84);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "FTP推送路径";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 111);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "FTP登录端口";
            // 
            // te_Port
            // 
            this.te_Port.Location = new System.Drawing.Point(316, 109);
            this.te_Port.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.te_Port.Name = "te_Port";
            this.te_Port.PasswordChar = '*';
            this.te_Port.Size = new System.Drawing.Size(104, 21);
            this.te_Port.TabIndex = 21;
            this.te_Port.Text = "22";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "FTP登录地址";
            // 
            // te_IP
            // 
            this.te_IP.Location = new System.Drawing.Point(316, 82);
            this.te_IP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.te_IP.Name = "te_IP";
            this.te_IP.PasswordChar = '*';
            this.te_IP.Size = new System.Drawing.Size(104, 21);
            this.te_IP.TabIndex = 19;
            this.te_IP.Text = "118.122.207.186";
            // 
            // te_Password
            // 
            this.te_Password.Location = new System.Drawing.Point(99, 109);
            this.te_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.te_Password.Name = "te_Password";
            this.te_Password.PasswordChar = '*';
            this.te_Password.Size = new System.Drawing.Size(78, 21);
            this.te_Password.TabIndex = 18;
            this.te_Password.Text = "bzbd0827";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "FTP登录密码";
            // 
            // te_username
            // 
            this.te_username.Location = new System.Drawing.Point(99, 82);
            this.te_username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.te_username.Name = "te_username";
            this.te_username.PasswordChar = '*';
            this.te_username.Size = new System.Drawing.Size(78, 21);
            this.te_username.TabIndex = 16;
            this.te_username.Text = "cdha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "FTP登录账号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 105);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "秒/次";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "25",
            "20",
            "15",
            "10",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(99, 59);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 20);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "15";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "推送频率";
            // 
            // btn_OpenPath
            // 
            this.btn_OpenPath.Location = new System.Drawing.Point(629, 18);
            this.btn_OpenPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_OpenPath.Name = "btn_OpenPath";
            this.btn_OpenPath.Size = new System.Drawing.Size(50, 28);
            this.btn_OpenPath.TabIndex = 9;
            this.btn_OpenPath.Text = "浏览";
            this.btn_OpenPath.UseVisualStyleBackColor = true;
            this.btn_OpenPath.Click += new System.EventHandler(this.btn_OpenPath_Click);
            // 
            // te_path
            // 
            this.te_path.Location = new System.Drawing.Point(99, 25);
            this.te_path.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.te_path.Name = "te_path";
            this.te_path.Size = new System.Drawing.Size(527, 21);
            this.te_path.TabIndex = 10;
            this.te_path.Text = "D:\\HengAn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "本地文件路径";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_StartSend
            // 
            this.btn_StartSend.Location = new System.Drawing.Point(210, 95);
            this.btn_StartSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_StartSend.Name = "btn_StartSend";
            this.btn_StartSend.Size = new System.Drawing.Size(56, 28);
            this.btn_StartSend.TabIndex = 9;
            this.btn_StartSend.Text = "开始推送";
            this.btn_StartSend.UseVisualStyleBackColor = true;
            this.btn_StartSend.Click += new System.EventHandler(this.btn_StartSend_Click);
            // 
            // btn_StopSend
            // 
            this.btn_StopSend.Location = new System.Drawing.Point(210, 130);
            this.btn_StopSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_StopSend.Name = "btn_StopSend";
            this.btn_StopSend.Size = new System.Drawing.Size(56, 28);
            this.btn_StopSend.TabIndex = 10;
            this.btn_StopSend.Text = "停止推送";
            this.btn_StopSend.UseVisualStyleBackColor = true;
            this.btn_StopSend.Click += new System.EventHandler(this.btn_StopSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 506);
            this.Controls.Add(this.btn_StopSend);
            this.Controls.Add(this.btn_StartSend);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_logon;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_UseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tb_ServerIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_OpenPath;
        private System.Windows.Forms.TextBox te_path;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_StartSend;
        private System.Windows.Forms.Button btn_StopSend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox te_Port;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox te_IP;
        private System.Windows.Forms.TextBox te_Password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox te_username;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_FtpObjectivePath;
        private System.Windows.Forms.Label label11;
    }
}

