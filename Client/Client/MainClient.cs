using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Threading;

namespace Client
{
    public partial class MainClient : Form
    {
        public static int port = 8888; 
        public static TcpListener TcpListener1;
        public static Thread connect = new Thread(waitConnection);

        public static void waitConnection()
        {
            try
            {
                TcpListener1 = new TcpListener(IPAddress.Any, port);                
                
                TcpListener1.Start();
                TcpListener1.AcceptSocket();
                MessageBox.Show("Connection Successfull!! ");
            }
            catch (Exception err) { return; }
        }
        public MainClient()
        {
            
            InitializeComponent();
            txtServerResult.Text = "My Ipuerto >> " + port;
        }

        private void MainClient_Load(object sender, EventArgs e)
        {
            connect.Start();
        }
    }
}
