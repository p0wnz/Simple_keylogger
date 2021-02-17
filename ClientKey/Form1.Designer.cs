namespace ClientKey
{
    partial class frmKeyLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKeyLog));
            this.grpKeygen = new System.Windows.Forms.GroupBox();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.btnHideWindow = new System.Windows.Forms.Button();
            this.btnStopLog = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSaveLog = new System.Windows.Forms.LinkLabel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.grpConnect = new System.Windows.Forms.GroupBox();
            this.btnConncect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtIpAdress = new System.Windows.Forms.TextBox();
            this.lblIpAdress = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.noTicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpKeygen.SuspendLayout();
            this.grpSettings.SuspendLayout();
            this.grpConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKeygen
            // 
            this.grpKeygen.Controls.Add(this.grpSettings);
            this.grpKeygen.Controls.Add(this.txtLog);
            this.grpKeygen.Controls.Add(this.grpConnect);
            this.grpKeygen.Location = new System.Drawing.Point(12, 12);
            this.grpKeygen.Name = "grpKeygen";
            this.grpKeygen.Size = new System.Drawing.Size(533, 391);
            this.grpKeygen.TabIndex = 0;
            this.grpKeygen.TabStop = false;
            this.grpKeygen.Text = "KeyLog";
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.btnHideWindow);
            this.grpSettings.Controls.Add(this.btnStopLog);
            this.grpSettings.Controls.Add(this.btnStart);
            this.grpSettings.Controls.Add(this.lblSaveLog);
            this.grpSettings.Location = new System.Drawing.Point(265, 316);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(262, 69);
            this.grpSettings.TabIndex = 9;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // btnHideWindow
            // 
            this.btnHideWindow.Location = new System.Drawing.Point(129, 46);
            this.btnHideWindow.Name = "btnHideWindow";
            this.btnHideWindow.Size = new System.Drawing.Size(85, 23);
            this.btnHideWindow.TabIndex = 3;
            this.btnHideWindow.Text = "Hide Window";
            this.btnHideWindow.UseVisualStyleBackColor = true;
            this.btnHideWindow.Click += new System.EventHandler(this.btnHideWindow_Click);
            // 
            // btnStopLog
            // 
            this.btnStopLog.Location = new System.Drawing.Point(129, 18);
            this.btnStopLog.Name = "btnStopLog";
            this.btnStopLog.Size = new System.Drawing.Size(85, 23);
            this.btnStopLog.TabIndex = 2;
            this.btnStopLog.Text = "Stop Logging";
            this.btnStopLog.UseVisualStyleBackColor = true;
            this.btnStopLog.Click += new System.EventHandler(this.btnStopLog_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(25, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Logging";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblSaveLog
            // 
            this.lblSaveLog.AutoSize = true;
            this.lblSaveLog.Location = new System.Drawing.Point(22, 51);
            this.lblSaveLog.Name = "lblSaveLog";
            this.lblSaveLog.Size = new System.Drawing.Size(53, 13);
            this.lblSaveLog.TabIndex = 0;
            this.lblSaveLog.TabStop = true;
            this.lblSaveLog.Text = "Save Log";
            this.lblSaveLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSaveLog_LinkClicked);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(6, 19);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(521, 291);
            this.txtLog.TabIndex = 8;
            // 
            // grpConnect
            // 
            this.grpConnect.Controls.Add(this.btnConncect);
            this.grpConnect.Controls.Add(this.btnConnect);
            this.grpConnect.Controls.Add(this.txtIpAdress);
            this.grpConnect.Controls.Add(this.lblIpAdress);
            this.grpConnect.Controls.Add(this.txtMessage);
            this.grpConnect.Controls.Add(this.lblMessage);
            this.grpConnect.Controls.Add(this.txtPort);
            this.grpConnect.Controls.Add(this.lblPort);
            this.grpConnect.Location = new System.Drawing.Point(6, 316);
            this.grpConnect.Name = "grpConnect";
            this.grpConnect.Size = new System.Drawing.Size(253, 69);
            this.grpConnect.TabIndex = 0;
            this.grpConnect.TabStop = false;
            this.grpConnect.Text = "Connect";
            // 
            // btnConncect
            // 
            this.btnConncect.Location = new System.Drawing.Point(174, 40);
            this.btnConncect.Name = "btnConncect";
            this.btnConncect.Size = new System.Drawing.Size(75, 23);
            this.btnConncect.TabIndex = 8;
            this.btnConncect.Text = "&Connect";
            this.btnConncect.UseVisualStyleBackColor = true;
            this.btnConncect.Click += new System.EventHandler(this.btnConncect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(173, 70);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtIpAdress
            // 
            this.txtIpAdress.Location = new System.Drawing.Point(67, 18);
            this.txtIpAdress.Name = "txtIpAdress";
            this.txtIpAdress.Size = new System.Drawing.Size(100, 20);
            this.txtIpAdress.TabIndex = 5;
            // 
            // lblIpAdress
            // 
            this.lblIpAdress.AutoSize = true;
            this.lblIpAdress.Location = new System.Drawing.Point(9, 21);
            this.lblIpAdress.Name = "lblIpAdress";
            this.lblIpAdress.Size = new System.Drawing.Size(58, 13);
            this.lblIpAdress.TabIndex = 2;
            this.lblIpAdress.Text = "IP Adress :";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(67, 70);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(100, 20);
            this.txtMessage.TabIndex = 6;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(9, 73);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 13);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Message:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(67, 44);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 7;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(9, 47);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port:";
            // 
            // noTicon
            // 
            this.noTicon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.noTicon.BalloonTipText = "Hello there";
            this.noTicon.BalloonTipTitle = "Double click to return form";
            this.noTicon.Icon = ((System.Drawing.Icon)(resources.GetObject("noTicon.Icon")));
            this.noTicon.Text = "KeyLog";
            this.noTicon.Visible = true;
            this.noTicon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.noTicon_MouseDoubleClick);
            // 
            // frmKeyLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 415);
            this.Controls.Add(this.grpKeygen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmKeyLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyLog";
            this.Load += new System.EventHandler(this.frmKeyLog_Load);
            this.grpKeygen.ResumeLayout(false);
            this.grpKeygen.PerformLayout();
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.grpConnect.ResumeLayout(false);
            this.grpConnect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKeygen;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox grpConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtIpAdress;
        private System.Windows.Forms.Label lblIpAdress;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnHideWindow;
        private System.Windows.Forms.Button btnStopLog;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.LinkLabel lblSaveLog;
        private System.Windows.Forms.NotifyIcon noTicon;
        private System.Windows.Forms.Button btnConncect;
    }
}

