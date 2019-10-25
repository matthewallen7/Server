using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TafeClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //client class
        SimpleTcpClient client;
        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            //disable button
            btn_Connect.Enabled = false;

            //connect to client host
            client.Connect(txt_Host.Text, Convert.ToInt32(txt_Port.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //on load
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;

            //create event
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            txt_Convo.Invoke((MethodInvoker)delegate ()
            {
                //print message into the textbox
                txt_Convo.Text += e.MessageString;
            });
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            //get a reply of the message that is sent
            client.WriteLineAndGetReply(txt_Message.Text, TimeSpan.FromSeconds(3));
        }
    }
}
