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
        public static TcpListener TcpListener;
        public static Thread conn = new Thread(waitConnection);

        public static void waitConnection()
        {
            try
            {
                TcpListener = new TcpListener(IPAddress.Any, port);                
                String localHostName = Dns.GetHostName();
                TcpListener.Start();
                TcpListener.AcceptSocket();
                MessageBox.Show("Connection Successfull!! " + localHostName);
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
            conn.Start();
        }
    }
}
