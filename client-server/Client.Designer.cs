namespace client_server
{
    partial class Client
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxConnect = new System.Windows.Forms.PictureBox();
            this.btn_back_connect = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHill = new System.Windows.Forms.Button();
            this.btnPlayFair = new System.Windows.Forms.Button();
            this.btnSimpleKey = new System.Windows.Forms.Button();
            this.btncaesear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.pbxConnect);
            this.panel1.Controls.Add(this.btn_back_connect);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHill);
            this.panel1.Controls.Add(this.btnPlayFair);
            this.panel1.Controls.Add(this.btnSimpleKey);
            this.panel1.Controls.Add(this.btncaesear);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 491);
            this.panel1.TabIndex = 0;
            // 
            // pbxConnect
            // 
            this.pbxConnect.Image = global::client_server.Properties.Resources.disconnect;
            this.pbxConnect.Location = new System.Drawing.Point(12, 407);
            this.pbxConnect.Name = "pbxConnect";
            this.pbxConnect.Size = new System.Drawing.Size(40, 34);
            this.pbxConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxConnect.TabIndex = 76;
            this.pbxConnect.TabStop = false;
            this.pbxConnect.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pbxConnect_LoadCompleted);
            // 
            // btn_back_connect
            // 
            this.btn_back_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(150)))));
            this.btn_back_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back_connect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_connect.ForeColor = System.Drawing.Color.White;
            this.btn_back_connect.Location = new System.Drawing.Point(-2, 398);
            this.btn_back_connect.Name = "btn_back_connect";
            this.btn_back_connect.Size = new System.Drawing.Size(202, 50);
            this.btn_back_connect.TabIndex = 43;
            this.btn_back_connect.Text = "Connect";
            this.btn_back_connect.UseVisualStyleBackColor = false;
            this.btn_back_connect.Click += new System.EventHandler(this.btn_back_connect_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(150)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 40);
            this.panel7.TabIndex = 42;
            this.panel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel7_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Algorithm";
            // 
            // btnHill
            // 
            this.btnHill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHill.ForeColor = System.Drawing.Color.White;
            this.btnHill.Location = new System.Drawing.Point(-2, 358);
            this.btnHill.Name = "btnHill";
            this.btnHill.Size = new System.Drawing.Size(202, 43);
            this.btnHill.TabIndex = 23;
            this.btnHill.Text = "Hill Cipher";
            this.btnHill.UseVisualStyleBackColor = true;
            this.btnHill.Click += new System.EventHandler(this.btnHill_Click);
            // 
            // btnPlayFair
            // 
            this.btnPlayFair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayFair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayFair.ForeColor = System.Drawing.Color.White;
            this.btnPlayFair.Location = new System.Drawing.Point(-2, 315);
            this.btnPlayFair.Name = "btnPlayFair";
            this.btnPlayFair.Size = new System.Drawing.Size(202, 45);
            this.btnPlayFair.TabIndex = 22;
            this.btnPlayFair.Text = "Play Fair ";
            this.btnPlayFair.UseVisualStyleBackColor = true;
            this.btnPlayFair.Click += new System.EventHandler(this.btnPlayFair_Click);
            // 
            // btnSimpleKey
            // 
            this.btnSimpleKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpleKey.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpleKey.ForeColor = System.Drawing.Color.White;
            this.btnSimpleKey.Location = new System.Drawing.Point(-2, 270);
            this.btnSimpleKey.Name = "btnSimpleKey";
            this.btnSimpleKey.Size = new System.Drawing.Size(202, 49);
            this.btnSimpleKey.TabIndex = 21;
            this.btnSimpleKey.Text = "Simple KeyWord";
            this.btnSimpleKey.UseVisualStyleBackColor = true;
            this.btnSimpleKey.Click += new System.EventHandler(this.btnSimpleKey_Click);
            // 
            // btncaesear
            // 
            this.btncaesear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncaesear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncaesear.ForeColor = System.Drawing.Color.White;
            this.btncaesear.Location = new System.Drawing.Point(-2, 223);
            this.btncaesear.Name = "btncaesear";
            this.btncaesear.Size = new System.Drawing.Size(202, 50);
            this.btncaesear.TabIndex = 20;
            this.btncaesear.Text = "Caesear Cipher";
            this.btncaesear.UseVisualStyleBackColor = true;
            this.btncaesear.Click += new System.EventHandler(this.btncaesear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::client_server.Properties.Resources.icons8_client_server_66;
            this.pictureBox1.Location = new System.Drawing.Point(40, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pnlClient
            // 
            this.pnlClient.Controls.Add(this.pictureBox2);
            this.pnlClient.Controls.Add(this.pictureBox3);
            this.pnlClient.Controls.Add(this.btnConnect);
            this.pnlClient.Controls.Add(this.btnDisconnect);
            this.pnlClient.Controls.Add(this.txtPort);
            this.pnlClient.Controls.Add(this.txtIPAddress);
            this.pnlClient.Controls.Add(this.label2);
            this.pnlClient.Controls.Add(this.label3);
            this.pnlClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClient.Location = new System.Drawing.Point(197, 150);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(537, 348);
            this.pnlClient.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::client_server.Properties.Resources.dis_conn;
            this.pictureBox2.Location = new System.Drawing.Point(283, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::client_server.Properties.Resources.connect_btn;
            this.pictureBox3.Location = new System.Drawing.Point(111, 88);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 78;
            this.pictureBox3.TabStop = false;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(150)))));
            this.btnConnect.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(162, 81);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(97, 52);
            this.btnConnect.TabIndex = 75;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.White;
            this.btnDisconnect.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(150)))));
            this.btnDisconnect.Location = new System.Drawing.Point(334, 81);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(97, 52);
            this.btnDisconnect.TabIndex = 74;
            this.btnDisconnect.Text = "Dis Connect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(337, 43);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(136, 21);
            this.txtPort.TabIndex = 68;
            this.txtPort.Text = "5000";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPAddress.Location = new System.Drawing.Point(123, 41);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(136, 21);
            this.txtIPAddress.TabIndex = 67;
            this.txtIPAddress.Text = "127.0.0.1";
            this.txtIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(285, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(150)))));
            this.label3.Location = new System.Drawing.Point(49, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "IP Address";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(150)))));
            this.btnClose.Location = new System.Drawing.Point(494, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(197, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 50);
            this.panel2.TabIndex = 47;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // txtStatus
            // 
            this.txtStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtStatus.Location = new System.Drawing.Point(197, 50);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(537, 100);
            this.txtStatus.TabIndex = 57;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 491);
            this.ControlBox = false;
            this.Controls.Add(this.pnlClient);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlClient.ResumeLayout(false);
            this.pnlClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.Button btnHill;
        private System.Windows.Forms.Button btnPlayFair;
        private System.Windows.Forms.Button btnSimpleKey;
        private System.Windows.Forms.Button btncaesear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btn_back_connect;
        private System.Windows.Forms.PictureBox pbxConnect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}