﻿using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Threading;
using System.Linq;
using System.Text;

namespace Client
{
    public partial class MainClient : Form
    {

        Socket server = null;
        Socket client = null;
        public static int numlines = 0;

        public MainClient()
        {
            InitializeComponent();
            ConnectClient();

        }

        private void ConnectClient()
        {
            try
            {


                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server.Bind(new IPEndPoint(IPAddress.Any, 8888));
                server.Listen(100);
                txtServerResult.Text = "Esperando conexión del servidor... ";
                client = server.Accept();

                byte[] bytes = new byte[1024];
                int bytesRec = client.Receive(bytes);
                String decoded = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                txtServerResult.Text = "Nueva conexión de servidor aceptada ... ";                
                txtServerResult.Text = "Date Client........................." + client.RemoteEndPoint;
                txtServerResult.Text = "Date Client........................." + client.LocalEndPoint;
                txtServerResult.Text = "Name Client........................." + decoded;


                

                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.FullRowSelect = true;

                //Add items in the listview
                string[] arr = new string[4];
                ListViewItem itm;

                //Add first item
                arr[0] = decoded;
                arr[1] = client.RemoteEndPoint.ToString().Split(':')[0]; 
                arr[2] = client.LocalEndPoint.ToString().Split(':')[1];
                arr[3] = "";
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);

                /*Add second item
                arr[0] = "ella";
                arr[1] = "perro";
                arr[2] = "ppp";
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
                */


            }

            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                    
                    
                }

            }
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
