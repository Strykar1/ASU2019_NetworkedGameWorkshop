﻿namespace ASU2019_NetworkedGameWorkshop.view {
    partial class ConnectForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbx_connectList = new System.Windows.Forms.ListBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_host = new System.Windows.Forms.Button();
            this.btn_manualConnect = new System.Windows.Forms.Button();
            this.txt_connectIP = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageHost = new System.Windows.Forms.TabPage();
            this.txt_hostIP = new System.Windows.Forms.TextBox();
            this.txt_hostPort = new System.Windows.Forms.TextBox();
            this.lbl_hostPort = new System.Windows.Forms.Label();
            this.lbl_hostIP = new System.Windows.Forms.Label();
            this.tabPageConnect = new System.Windows.Forms.TabPage();
            this.txt_connectPort = new System.Windows.Forms.TextBox();
            this.lbl_connectPort = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageHost.SuspendLayout();
            this.tabPageConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_connectList
            // 
            this.lbx_connectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_connectList.FormattingEnabled = true;
            this.lbx_connectList.ItemHeight = 20;
            this.lbx_connectList.Items.AddRange(new object[] {
            "Device 1",
            "Device 2",
            "Device 3"});
            this.lbx_connectList.Location = new System.Drawing.Point(6, 6);
            this.lbx_connectList.Name = "lbx_connectList";
            this.lbx_connectList.Size = new System.Drawing.Size(274, 124);
            this.lbx_connectList.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(286, 107);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(142, 23);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // btn_host
            // 
            this.btn_host.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_host.Location = new System.Drawing.Point(167, 120);
            this.btn_host.Name = "btn_host";
            this.btn_host.Size = new System.Drawing.Size(280, 28);
            this.btn_host.TabIndex = 3;
            this.btn_host.Text = "Host";
            this.btn_host.UseVisualStyleBackColor = true;
            // 
            // btn_manualConnect
            // 
            this.btn_manualConnect.Location = new System.Drawing.Point(286, 136);
            this.btn_manualConnect.Name = "btn_manualConnect";
            this.btn_manualConnect.Size = new System.Drawing.Size(142, 26);
            this.btn_manualConnect.TabIndex = 4;
            this.btn_manualConnect.Text = "Manual Connect";
            this.btn_manualConnect.UseVisualStyleBackColor = true;
            // 
            // txt_connectIP
            // 
            this.txt_connectIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_connectIP.Location = new System.Drawing.Point(6, 136);
            this.txt_connectIP.MaxLength = 15;
            this.txt_connectIP.Name = "txt_connectIP";
            this.txt_connectIP.Size = new System.Drawing.Size(274, 26);
            this.txt_connectIP.TabIndex = 7;
            this.txt_connectIP.Text = "temp text ?";
            this.txt_connectIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_connectIP_KeyPress);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(286, 38);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(142, 23);
            this.btn_connect.TabIndex = 8;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageHost);
            this.tabControl.Controls.Add(this.tabPageConnect);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(10);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(10, 5);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(461, 261);
            this.tabControl.TabIndex = 11;
            // 
            // tabPageHost
            // 
            this.tabPageHost.Controls.Add(this.txt_hostIP);
            this.tabPageHost.Controls.Add(this.txt_hostPort);
            this.tabPageHost.Controls.Add(this.lbl_hostPort);
            this.tabPageHost.Controls.Add(this.lbl_hostIP);
            this.tabPageHost.Controls.Add(this.btn_host);
            this.tabPageHost.Location = new System.Drawing.Point(4, 26);
            this.tabPageHost.Name = "tabPageHost";
            this.tabPageHost.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHost.Size = new System.Drawing.Size(453, 231);
            this.tabPageHost.TabIndex = 0;
            this.tabPageHost.Text = "Host";
            this.tabPageHost.UseVisualStyleBackColor = true;
            // 
            // txt_hostIP
            // 
            this.txt_hostIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_hostIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hostIP.Location = new System.Drawing.Point(167, 12);
            this.txt_hostIP.Name = "txt_hostIP";
            this.txt_hostIP.ReadOnly = true;
            this.txt_hostIP.Size = new System.Drawing.Size(274, 19);
            this.txt_hostIP.TabIndex = 11;
            this.txt_hostIP.TabStop = false;
            this.txt_hostIP.Text = "192.168.XXX.XXX";
            // 
            // txt_hostPort
            // 
            this.txt_hostPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hostPort.Location = new System.Drawing.Point(167, 48);
            this.txt_hostPort.MaxLength = 5;
            this.txt_hostPort.Name = "txt_hostPort";
            this.txt_hostPort.Size = new System.Drawing.Size(274, 26);
            this.txt_hostPort.TabIndex = 10;
            this.txt_hostPort.Text = "47999";
            this.txt_hostPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_port_KeyPress);
            // 
            // lbl_hostPort
            // 
            this.lbl_hostPort.AutoSize = true;
            this.lbl_hostPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hostPort.Location = new System.Drawing.Point(8, 48);
            this.lbl_hostPort.Name = "lbl_hostPort";
            this.lbl_hostPort.Size = new System.Drawing.Size(53, 24);
            this.lbl_hostPort.TabIndex = 8;
            this.lbl_hostPort.Text = "Port :";
            // 
            // lbl_hostIP
            // 
            this.lbl_hostIP.AutoSize = true;
            this.lbl_hostIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hostIP.Location = new System.Drawing.Point(8, 12);
            this.lbl_hostIP.Name = "lbl_hostIP";
            this.lbl_hostIP.Size = new System.Drawing.Size(86, 24);
            this.lbl_hostIP.TabIndex = 7;
            this.lbl_hostIP.Text = "Local IP :";
            // 
            // tabPageConnect
            // 
            this.tabPageConnect.Controls.Add(this.txt_connectPort);
            this.tabPageConnect.Controls.Add(this.lbl_connectPort);
            this.tabPageConnect.Controls.Add(this.lbx_connectList);
            this.tabPageConnect.Controls.Add(this.btn_connect);
            this.tabPageConnect.Controls.Add(this.btn_refresh);
            this.tabPageConnect.Controls.Add(this.btn_manualConnect);
            this.tabPageConnect.Controls.Add(this.txt_connectIP);
            this.tabPageConnect.Location = new System.Drawing.Point(4, 26);
            this.tabPageConnect.Name = "tabPageConnect";
            this.tabPageConnect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnect.Size = new System.Drawing.Size(453, 231);
            this.tabPageConnect.TabIndex = 1;
            this.tabPageConnect.Text = "Connect";
            this.tabPageConnect.UseVisualStyleBackColor = true;
            // 
            // txt_connectPort
            // 
            this.txt_connectPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_connectPort.Location = new System.Drawing.Point(345, 6);
            this.txt_connectPort.MaxLength = 5;
            this.txt_connectPort.Name = "txt_connectPort";
            this.txt_connectPort.Size = new System.Drawing.Size(83, 26);
            this.txt_connectPort.TabIndex = 12;
            this.txt_connectPort.Text = "47999";
            this.txt_connectPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_connectPort_KeyPress);
            // 
            // lbl_connectPort
            // 
            this.lbl_connectPort.AutoSize = true;
            this.lbl_connectPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_connectPort.Location = new System.Drawing.Point(286, 6);
            this.lbl_connectPort.Name = "lbl_connectPort";
            this.lbl_connectPort.Size = new System.Drawing.Size(53, 24);
            this.lbl_connectPort.TabIndex = 11;
            this.lbl_connectPort.Text = "Port :";
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 261);
            this.Controls.Add(this.tabControl);
            this.Name = "ConnectForm";
            this.Text = "ConnectForm";
            this.Load += new System.EventHandler(this.ConnectForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageHost.ResumeLayout(false);
            this.tabPageHost.PerformLayout();
            this.tabPageConnect.ResumeLayout(false);
            this.tabPageConnect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_connectList;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_host;
        private System.Windows.Forms.Button btn_manualConnect;
        private System.Windows.Forms.TextBox txt_connectIP;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageHost;
        private System.Windows.Forms.TabPage tabPageConnect;
        private System.Windows.Forms.Label lbl_hostIP;
        private System.Windows.Forms.TextBox txt_hostPort;
        private System.Windows.Forms.Label lbl_hostPort;
        private System.Windows.Forms.TextBox txt_connectPort;
        private System.Windows.Forms.Label lbl_connectPort;
        private System.Windows.Forms.TextBox txt_hostIP;
    }
}