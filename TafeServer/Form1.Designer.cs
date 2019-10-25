namespace TafeServer
{
    partial class Server
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
            this.txt_Host = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.lbl_Host = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.txt_Chat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Host
            // 
            this.txt_Host.Location = new System.Drawing.Point(74, 46);
            this.txt_Host.Name = "txt_Host";
            this.txt_Host.Size = new System.Drawing.Size(100, 22);
            this.txt_Host.TabIndex = 0;
            this.txt_Host.Text = "127.0.0.1";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(252, 46);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(80, 22);
            this.txt_Port.TabIndex = 1;
            this.txt_Port.Text = "8910";
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Location = new System.Drawing.Point(200, 49);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(38, 17);
            this.lbl_Port.TabIndex = 2;
            this.lbl_Port.Text = "Port:";
            // 
            // lbl_Host
            // 
            this.lbl_Host.AutoSize = true;
            this.lbl_Host.Location = new System.Drawing.Point(22, 51);
            this.lbl_Host.Name = "lbl_Host";
            this.lbl_Host.Size = new System.Drawing.Size(41, 17);
            this.lbl_Host.TabIndex = 3;
            this.lbl_Host.Text = "Host:";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(338, 45);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(419, 45);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 5;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // txt_Chat
            // 
            this.txt_Chat.Location = new System.Drawing.Point(74, 74);
            this.txt_Chat.Multiline = true;
            this.txt_Chat.Name = "txt_Chat";
            this.txt_Chat.Size = new System.Drawing.Size(420, 299);
            this.txt_Chat.TabIndex = 6;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 383);
            this.Controls.Add(this.txt_Chat);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lbl_Host);
            this.Controls.Add(this.lbl_Port);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_Host);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Host;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.Label lbl_Host;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.TextBox txt_Chat;
    }
}

