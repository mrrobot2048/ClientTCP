using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Threading;
using System.Linq;

namespace Client
{
    public partial class MainClient : Form
    {

        Socket server = null;
        public static int numlines = 0;

        public MainClient()
        {
            InitializeComponent();

            Socket client = null;
            try
            {


                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server.Bind(new IPEndPoint(IPAddress.Any, 8888));
                server.Listen(100);
                txtServerResult.Text = "Esperando conexión del servidor... ";
                client = server.Accept();
                txtServerResult.Text = "Nueva conexión de servidor aceptada ... ";
                txtServerResult.Text = "Datos Server........................." + client.LocalEndPoint;
                txtServerResult.Text = "Datos Cliente........................" + client.RemoteEndPoint;
            }



            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (server != null)
                {
                    server.Close();
                }

            }
            Console.Read();
        }
        private void txtServerResult_TextChanged(object sender, EventArgs e)
        {
            numlines = txtServerResult.Lines.Count();
            int lines = 1;
            while (lines <= numlines)
            {
                listBox1.Items.Add(txtServerResult.Lines[lines - 1]);
                lines++;
            }
        }
    }
}
