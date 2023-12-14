namespace SocketServer
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
            this.Client_label = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.spTimer = new System.Timers.Timer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.txtSendMsg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // Client_label
            // 
            this.Client_label.AutoSize = true;
            this.Client_label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Client_label.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Client_label.ForeColor = System.Drawing.Color.Black;
            this.Client_label.Location = new System.Drawing.Point(213, 28);
            this.Client_label.Name = "Client_label";
            this.Client_label.Size = new System.Drawing.Size(113, 16);
            this.Client_label.TabIndex = 75;
            this.Client_label.Text = "Client Status";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label32.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(33, 27);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(119, 16);
            this.label32.TabIndex = 74;
            this.label32.Text = "Server Status";
            // 
            // spTimer
            // 
            this.spTimer.Enabled = true;
            this.spTimer.Interval = 1000D;
            this.spTimer.SynchronizingObject = this;
            this.spTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.spTimer_Elapsed);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(540, 302);
            this.richTextBox1.TabIndex = 76;
            this.richTextBox1.Text = "";
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSendMsg.Location = new System.Drawing.Point(489, 395);
            this.btnSendMsg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(78, 25);
            this.btnSendMsg.TabIndex = 78;
            this.btnSendMsg.Text = "SEND";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // txtSendMsg
            // 
            this.txtSendMsg.Location = new System.Drawing.Point(27, 395);
            this.txtSendMsg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSendMsg.Name = "txtSendMsg";
            this.txtSendMsg.Size = new System.Drawing.Size(451, 21);
            this.txtSendMsg.TabIndex = 77;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(489, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 25);
            this.button1.TabIndex = 79;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.txtSendMsg);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Client_label);
            this.Controls.Add(this.label32);
            this.Name = "Form1";
            this.Text = "SERVER";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Client_label;
        public System.Windows.Forms.Label label32;
        private System.Timers.Timer spTimer;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox txtSendMsg;
        private System.Windows.Forms.Button button1;
    }
}

