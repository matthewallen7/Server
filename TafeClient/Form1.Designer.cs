namespace TafeClient
{
    partial class Form1
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
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.lbl_Host = new System.Windows.Forms.Label();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.txt_Host = new System.Windows.Forms.TextBox();
            this.txt_Convo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Message
            // 
            this.txt_Message.Location = new System.Drawing.Point(64, 47);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(420, 64);
            this.txt_Message.TabIndex = 13;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(409, 117);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 12;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(328, 18);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 11;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // lbl_Host
            // 
            this.lbl_Host.AutoSize = true;
            this.lbl_Host.Location = new System.Drawing.Point(12, 24);
            this.lbl_Host.Name = "lbl_Host";
            this.lbl_Host.Size = new System.Drawing.Size(41, 17);
            this.lbl_Host.TabIndex = 10;
            this.lbl_Host.Text = "Host:";
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Location = new System.Drawing.Point(190, 22);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(38, 17);
            this.lbl_Port.TabIndex = 9;
            this.lbl_Port.Text = "Port:";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(242, 19);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(80, 22);
            this.txt_Port.TabIndex = 8;
            this.txt_Port.Text = "8910";
            // 
            // txt_Host
            // 
            this.txt_Host.Location = new System.Drawing.Point(64, 19);
            this.txt_Host.Name = "txt_Host";
            this.txt_Host.Size = new System.Drawing.Size(100, 22);
            this.txt_Host.TabIndex = 7;
            this.txt_Host.Text = "127.0.0.1";
            // 
            // txt_Convo
            // 
            this.txt_Convo.Location = new System.Drawing.Point(64, 146);
            this.txt_Convo.Multiline = true;
            this.txt_Convo.Name = "txt_Convo";
            this.txt_Convo.Size = new System.Drawing.Size(420, 211);
            this.txt_Convo.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 369);
            this.Controls.Add(this.txt_Convo);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.lbl_Host);
            this.Controls.Add(this.lbl_Port);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_Host);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label lbl_Host;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.TextBox txt_Host;
        private System.Windows.Forms.TextBox txt_Convo;
    }
}

