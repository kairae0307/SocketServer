using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.Configuration;
//using Excel = Microsoft.Office.Interop.Excel;
namespace SocketServer
{
    public partial class Form1 : Form
    {

        public bool ServerOpen = false;
        private Socket ServerSocket = null;
        private Thread ServerThread = null;

        public string TACHO2_path = "";
        public Socket TCPListnerAcceptSocket;

        private byte[] byteSendMsg = new byte[1024];
        private bool bSocketEnd = false;
        private int intPortNum = 3333;
        public int intCientID = 0;
        private string strLog = "";
        private string strErr = "";
        private string strCurTime = "";
        private string strClientID = "";
        private int intSize = 0;
        public string xValue = "";
        public int ClientCnt = 0;
        static public TcpServerSocket svr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            if (ServerSocket != null)
            {
                //strErr = string.Format("[서버] : 현재 서버 가동중입니다.!!");
                //   Add_Log(strErr);
                return;
            }
            ServerThread = new Thread(new ThreadStart(Thread_Server_Run));
            ServerThread.IsBackground = true;
            ServerThread.Start();
        }
        public void Thread_Server_Run()
        {

            svr = new TcpServerSocket(true);
            svr.Bind();
            svr.Listen();

            svr.AcceptStart();
           label32.Text = "SERVER OPEN";
            while (true)
            {
                //svr.Update();

                if (svr.rcvList.Count != 0)
                {

                    for (int i = 0; i < svr.rcvList.Count; i++)
                    {
                        string txt = String.Format("{0:X2} ", svr.rcvList[i]);
                      //  string  strReceiveMsg = Encoding.Default.GetString(bytes, 0, intSize);
                        richTextBox1.AppendText(txt);
                     
                     
                    }
                    richTextBox1.AppendText("\r\n");
                    svr.rcvList.Clear();
                    richTextBox1.ScrollToCaret();

                }
                Thread.Sleep(50);
            }

            /*
            ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            ServerSocket.Bind(new IPEndPoint(IPAddress.Any, intPortNum));
            ServerSocket.Listen(9);

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddr = host.AddressList[0];
      

            label32.Text = "SERVER OPEN";
     
            button10.Visible = true;

          

            while (bSocketEnd == false)
            {


                try
                {
                    //  Socket socClient = (Socket)ServerSocket.Accept();
                    ClientSocket = (Socket)ServerSocket.Accept();

                    ClientMessage_Process(ClientSocket);



                    byte[] Sendbuff = new byte[4096];

                    Sendbuff[0] = (byte)Int32.Parse(strClientID);
                    Sendbuff[1] = 0x00;


                    ClientCnt++;
                    strLog = string.Format("[{0}]?묒냽", strClientID);
                    //     Add_Log(strLog);
                    // label8.Text = strLog;

                    if (strClientID == "1")
                    {
                        client1_Visible(true);
                        //  Client1_Icon.Visible = true;
                        //   label8.Text = strLog;
                    }
                    else if (strClientID == "2")
                    {
                        client2_Visible(true);
                        // Client2_Icon.Visible = true;
                        //    label9.Text = strLog;
                    }
                    else if (strClientID == "3")
                    {
                        client3_Visible(true);
                        // Client3_Icon.Visible = true;
                        //   label10.Text = strLog;
                    }
                    else if (strClientID == "4")
                    {
                        client4_Visible(true);
                        // Client4_Icon.Visible = true;

                        //   label11.Text = strLog;
                    }
                    else if (strClientID == "0")
                    {
                        Sendbuff[0] = 0xFD;
                    }
                    else if (strClientID == "@")
                    {
                        Sendbuff[0] = 0xFE;
                    }

                    ClientSocket.BeginSend(Sendbuff, 0, byteSendMsg.Length, SocketFlags.None, new AsyncCallback(CallBack_SendMsg), ClientSocket);
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
               

                }


            }*/
        }

        private void spTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            Client_label.Text = "Client : " + svr.ClientCnt.ToString();


        }

        private void btnSendMsg_Click(object sender, EventArgs e)  // 데이터 보내기 
        {
            svr.TachoStr = txtSendMsg.Text;
            svr.TachoPacket();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
