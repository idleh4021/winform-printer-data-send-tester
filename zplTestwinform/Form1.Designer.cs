namespace zplTestwinform
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbox_Printer = new System.Windows.Forms.ComboBox();
            this.btn_sendUSB = new System.Windows.Forms.Button();
            this.tbox_Data = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.tbox_filepath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sendfile = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnSocket = new System.Windows.Forms.RadioButton();
            this.btn_macro_stop = new System.Windows.Forms.Button();
            this.rBtnFile = new System.Windows.Forms.RadioButton();
            this.btn_macro_start = new System.Windows.Forms.Button();
            this.rBtnDriver = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tEdit_Interval = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxIPAddress = new System.Windows.Forms.TextBox();
            this.tBoxPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_SocketSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tEdit_Interval)).BeginInit();
            this.SuspendLayout();
            // 
            // cbox_Printer
            // 
            this.cbox_Printer.FormattingEnabled = true;
            this.cbox_Printer.Location = new System.Drawing.Point(112, 49);
            this.cbox_Printer.Name = "cbox_Printer";
            this.cbox_Printer.Size = new System.Drawing.Size(530, 20);
            this.cbox_Printer.TabIndex = 0;
            // 
            // btn_sendUSB
            // 
            this.btn_sendUSB.Location = new System.Drawing.Point(648, 49);
            this.btn_sendUSB.Name = "btn_sendUSB";
            this.btn_sendUSB.Size = new System.Drawing.Size(111, 20);
            this.btn_sendUSB.TabIndex = 1;
            this.btn_sendUSB.Text = "전송";
            this.btn_sendUSB.UseVisualStyleBackColor = true;
            this.btn_sendUSB.Click += new System.EventHandler(this.btn_sendUSB_Click);
            // 
            // tbox_Data
            // 
            this.tbox_Data.Location = new System.Drawing.Point(12, 139);
            this.tbox_Data.Multiline = true;
            this.tbox_Data.Name = "tbox_Data";
            this.tbox_Data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbox_Data.Size = new System.Drawing.Size(747, 355);
            this.tbox_Data.TabIndex = 2;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // tbox_filepath
            // 
            this.tbox_filepath.Location = new System.Drawing.Point(12, 517);
            this.tbox_filepath.Name = "tbox_filepath";
            this.tbox_filepath.Size = new System.Drawing.Size(582, 21);
            this.tbox_filepath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "프린터 드라이브";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "파일 경로";
            // 
            // btn_sendfile
            // 
            this.btn_sendfile.Location = new System.Drawing.Point(648, 517);
            this.btn_sendfile.Name = "btn_sendfile";
            this.btn_sendfile.Size = new System.Drawing.Size(111, 21);
            this.btn_sendfile.TabIndex = 6;
            this.btn_sendfile.Text = "전송";
            this.btn_sendfile.UseVisualStyleBackColor = true;
            this.btn_sendfile.Click += new System.EventHandler(this.btn_sendfile_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(600, 517);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(42, 21);
            this.btn_browse.TabIndex = 7;
            this.btn_browse.Text = "...";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnSocket);
            this.groupBox1.Controls.Add(this.btn_macro_stop);
            this.groupBox1.Controls.Add(this.rBtnFile);
            this.groupBox1.Controls.Add(this.btn_macro_start);
            this.groupBox1.Controls.Add(this.rBtnDriver);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tEdit_Interval);
            this.groupBox1.Location = new System.Drawing.Point(765, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 173);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "매크로";
            // 
            // rBtnSocket
            // 
            this.rBtnSocket.AutoSize = true;
            this.rBtnSocket.Location = new System.Drawing.Point(27, 105);
            this.rBtnSocket.Name = "rBtnSocket";
            this.rBtnSocket.Size = new System.Drawing.Size(96, 16);
            this.rBtnSocket.TabIndex = 16;
            this.rBtnSocket.Text = "IP(소켓) 전송";
            this.rBtnSocket.UseVisualStyleBackColor = true;
            // 
            // btn_macro_stop
            // 
            this.btn_macro_stop.Location = new System.Drawing.Point(102, 132);
            this.btn_macro_stop.Name = "btn_macro_stop";
            this.btn_macro_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_macro_stop.TabIndex = 3;
            this.btn_macro_stop.Text = "정지";
            this.btn_macro_stop.UseVisualStyleBackColor = true;
            this.btn_macro_stop.Click += new System.EventHandler(this.btn_macro_stop_Click);
            // 
            // rBtnFile
            // 
            this.rBtnFile.AutoSize = true;
            this.rBtnFile.Location = new System.Drawing.Point(27, 83);
            this.rBtnFile.Name = "rBtnFile";
            this.rBtnFile.Size = new System.Drawing.Size(75, 16);
            this.rBtnFile.TabIndex = 15;
            this.rBtnFile.Text = "파일 전송";
            this.rBtnFile.UseVisualStyleBackColor = true;
            // 
            // btn_macro_start
            // 
            this.btn_macro_start.Location = new System.Drawing.Point(13, 132);
            this.btn_macro_start.Name = "btn_macro_start";
            this.btn_macro_start.Size = new System.Drawing.Size(75, 23);
            this.btn_macro_start.TabIndex = 2;
            this.btn_macro_start.Text = "시작";
            this.btn_macro_start.UseVisualStyleBackColor = true;
            this.btn_macro_start.Click += new System.EventHandler(this.btn_macro_start_Click);
            // 
            // rBtnDriver
            // 
            this.rBtnDriver.AutoSize = true;
            this.rBtnDriver.Checked = true;
            this.rBtnDriver.Location = new System.Drawing.Point(27, 61);
            this.rBtnDriver.Name = "rBtnDriver";
            this.rBtnDriver.Size = new System.Drawing.Size(99, 16);
            this.rBtnDriver.TabIndex = 14;
            this.rBtnDriver.TabStop = true;
            this.rBtnDriver.Text = "드라이버 전송";
            this.rBtnDriver.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "인터벌(초)";
            // 
            // tEdit_Interval
            // 
            this.tEdit_Interval.Location = new System.Drawing.Point(102, 23);
            this.tEdit_Interval.Name = "tEdit_Interval";
            this.tEdit_Interval.Size = new System.Drawing.Size(52, 21);
            this.tEdit_Interval.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "IP 주소";
            // 
            // tBoxIPAddress
            // 
            this.tBoxIPAddress.Location = new System.Drawing.Point(112, 94);
            this.tBoxIPAddress.Name = "tBoxIPAddress";
            this.tBoxIPAddress.Size = new System.Drawing.Size(259, 21);
            this.tBoxIPAddress.TabIndex = 10;
            // 
            // tBoxPort
            // 
            this.tBoxPort.Location = new System.Drawing.Point(512, 94);
            this.tBoxPort.Name = "tBoxPort";
            this.tBoxPort.Size = new System.Drawing.Size(130, 21);
            this.tBoxPort.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "포트";
            // 
            // btn_SocketSend
            // 
            this.btn_SocketSend.Location = new System.Drawing.Point(648, 95);
            this.btn_SocketSend.Name = "btn_SocketSend";
            this.btn_SocketSend.Size = new System.Drawing.Size(111, 20);
            this.btn_SocketSend.TabIndex = 13;
            this.btn_SocketSend.Text = "전송";
            this.btn_SocketSend.UseVisualStyleBackColor = true;
            this.btn_SocketSend.Click += new System.EventHandler(this.btn_SocketSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 563);
            this.Controls.Add(this.btn_SocketSend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBoxPort);
            this.Controls.Add(this.tBoxIPAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.btn_sendfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_filepath);
            this.Controls.Add(this.tbox_Data);
            this.Controls.Add(this.btn_sendUSB);
            this.Controls.Add(this.cbox_Printer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tEdit_Interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_Printer;
        private System.Windows.Forms.Button btn_sendUSB;
        private System.Windows.Forms.TextBox tbox_Data;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TextBox tbox_filepath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_sendfile;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown tEdit_Interval;
        private System.Windows.Forms.Button btn_macro_stop;
        private System.Windows.Forms.Button btn_macro_start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxIPAddress;
        private System.Windows.Forms.TextBox tBoxPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_SocketSend;
        private System.Windows.Forms.RadioButton rBtnSocket;
        private System.Windows.Forms.RadioButton rBtnFile;
        private System.Windows.Forms.RadioButton rBtnDriver;
    }
}

