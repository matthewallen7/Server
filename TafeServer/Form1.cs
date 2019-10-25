using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;

namespace TafeServer
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        //server class
        SimpleTcpServer server;
        private void Server_Load(object sender, EventArgs e)
        {
            //on load
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;

            //create event
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txt_Chat.Invoke((MethodInvoker)delegate()
            {
                //get incomming message
                string message = e.MessageString;
                Console.WriteLine(message);

                //print to textbox
                txt_Chat.Text += message + "\r\n";
                
                //send reply
                e.ReplyLine(string.Format("You said: {0}", message));
            });
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            txt_Chat.Text += "Server starting....." + "\r\n";

            //ip address for the host
            IPAddress ip = IPAddress.Parse(txt_Host.Text);

            //start server with ip and port number
            server.Start(ip, Convert.ToInt32(txt_Port.Text));
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
            }
        }
    }
}
