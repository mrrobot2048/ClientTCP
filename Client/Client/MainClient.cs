using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Threading;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace Client
{
    public partial class MainClient : Form
    {

        public Socket server;
        public static int numlines = 0;
        public byte[] bytes = new byte[1024];
      

        public MainClient()
        {
            InitializeComponent();

            Socket client = null;
            try
            {
                
                

                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server.Bind(new IPEndPoint(IPAddress.Parse("192.168.2.31"), 8888));
                string hostName = Dns.GetHostName();
                server.Listen(100);
                txtServerResult.Text = "Esperando conexión del servidor... ";
                client = server.Accept();

                bytes = new byte[1024];
                int bytesRec = client.Receive(bytes);
                


                txtServerResult.Text = "Nueva conexión de servidor aceptada ... ";
                
                txtServerResult.Text = "Datos Cliente........................" + client.RemoteEndPoint;
                txtServerResult.Text = "Datos Cliente........................" + Encoding.ASCII.GetString(bytes, 0, bytesRec);

                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.FullRowSelect = true;

                //Add column header
                listView1.Columns.Add("Name PC");
                listView1.Columns.Add("IP/PC");
                listView1.Columns.Add("Port");

                //Add items in the listview
                string[] arr = new string[4];
                ListViewItem itm;

                //Add first item
                arr[0] = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                arr[1] = "hola";
                arr[2] = "esto";
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);

                //Add second item
                arr[0] = "ella";
                arr[1] = "perro";
                arr[2] = "ppp";
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);





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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void MainClient_Load(object sender, EventArgs e)
        {
            
        }
    }
}
