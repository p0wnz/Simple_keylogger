using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
namespace ClientKey
{

    public class Client
    {
        public bool blLog = false;
        public string strEOL = "H(#HRJ(DOE#";
        public string strDataTaken = "";
        public Socket senderPub;
        public string consent = "ok";
        public TextBox text = new TextBox();
        public void startLog()
        {
            strDataTaken = "";
           
            
                byte[] bytes = new byte[204800];
                byte[] msg = Encoding.ASCII.GetBytes(consent + strEOL);
              
                senderPub.Send(msg);

              
                int bytesRec = senderPub.Receive(bytes);

                strDataTaken = Encoding.ASCII.GetString(bytes, 0, bytesRec);
            

        }

        public void StartClient(string strIpAddress, int intPort, string strMessage) {
        byte[] bytes = new byte[1024];
        try 
            {

                IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
                IPAddress ipAddress = IPAddress.Parse(strIpAddress);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress,intPort);
                Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp );
                    try 
                    {
                        sender.Connect(remoteEP);
                        byte[] msg = Encoding.ASCII.GetBytes(strMessage+strEOL);
                        int bytesSent = sender.Send(msg);
                        if (strMessage == "log")
                            blLog = true;
                        int bytesRec = sender.Receive(bytes);
                        strDataTaken= Encoding.ASCII.GetString(bytes,0,bytesRec);
                        if (blLog)
                        {
                            consent = "ok";
                            senderPub = sender;
                            return;
                        }
                        sender.Shutdown(SocketShutdown.Both);
                        sender.Close();
                
                    }
                catch (ArgumentNullException ane)
                {
                    strDataTaken = ane.ToString();
                }
                catch (SocketException se) 
                {
                    strDataTaken=se.ToString();
                }
                catch (Exception e) 
                {
                    strDataTaken= e.ToString();
                }

            }
            catch (Exception e)
            {
                strDataTaken=( e.ToString());
            }
        }
    }
}
