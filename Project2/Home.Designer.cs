namespace WindowsFormsApplication1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.txtCommPort = new System.Windows.Forms.TextBox();
            this.txtCommKey = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIPAdd = new System.Windows.Forms.TextBox();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblCommPort = new System.Windows.Forms.Label();
            this.lblCommKey = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIPAdd = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.rBtnUSB = new System.Windows.Forms.RadioButton();
            this.rBtnCOM = new System.Windows.Forms.RadioButton();
            this.rBtnIP = new System.Windows.Forms.RadioButton();
            this.List1 = new System.Windows.Forms.ListBox();
            this.axBioBridgeSDKv3lib1 = new AxBioBridgeSDKv3.AxBioBridgeSDKv3lib();
            this.List2 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrev = new System.Windows.Forms.Label();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStatus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axBioBridgeSDKv3lib1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Frame1
            // 
            this.Frame1.Controls.Add(this.txtTimeOut);
            this.Frame1.Controls.Add(this.txtDelay);
            this.Frame1.Controls.Add(this.txtModel);
            this.Frame1.Controls.Add(this.txtBaudRate);
            this.Frame1.Controls.Add(this.txtCommPort);
            this.Frame1.Controls.Add(this.txtCommKey);
            this.Frame1.Controls.Add(this.txtPort);
            this.Frame1.Controls.Add(this.txtIPAdd);
            this.Frame1.Controls.Add(this.lblTimeOut);
            this.Frame1.Controls.Add(this.lblDelay);
            this.Frame1.Controls.Add(this.lblModel);
            this.Frame1.Controls.Add(this.lblBaudRate);
            this.Frame1.Controls.Add(this.lblCommPort);
            this.Frame1.Controls.Add(this.lblCommKey);
            this.Frame1.Controls.Add(this.lblPort);
            this.Frame1.Controls.Add(this.lblIPAdd);
            this.Frame1.Controls.Add(this.btnConnect);
            this.Frame1.Controls.Add(this.rBtnUSB);
            this.Frame1.Controls.Add(this.rBtnCOM);
            this.Frame1.Controls.Add(this.rBtnIP);
            this.Frame1.Location = new System.Drawing.Point(12, 12);
            this.Frame1.Name = "Frame1";
            this.Frame1.Size = new System.Drawing.Size(337, 98);
            this.Frame1.TabIndex = 13;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Device Connector";
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.AcceptsReturn = true;
            this.txtTimeOut.Location = new System.Drawing.Point(80, 213);
            this.txtTimeOut.MaxLength = 0;
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(81, 20);
            this.txtTimeOut.TabIndex = 136;
            this.txtTimeOut.Text = "10";
            // 
            // txtDelay
            // 
            this.txtDelay.AcceptsReturn = true;
            this.txtDelay.Location = new System.Drawing.Point(80, 189);
            this.txtDelay.MaxLength = 0;
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(81, 20);
            this.txtDelay.TabIndex = 16;
            this.txtDelay.Text = "1000";
            // 
            // txtModel
            // 
            this.txtModel.AcceptsReturn = true;
            this.txtModel.Location = new System.Drawing.Point(80, 165);
            this.txtModel.MaxLength = 0;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(81, 20);
            this.txtModel.TabIndex = 2;
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.AcceptsReturn = true;
            this.txtBaudRate.Location = new System.Drawing.Point(80, 141);
            this.txtBaudRate.MaxLength = 0;
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(81, 20);
            this.txtBaudRate.TabIndex = 5;
            this.txtBaudRate.Text = "115200";
            // 
            // txtCommPort
            // 
            this.txtCommPort.AcceptsReturn = true;
            this.txtCommPort.Location = new System.Drawing.Point(80, 117);
            this.txtCommPort.MaxLength = 0;
            this.txtCommPort.Name = "txtCommPort";
            this.txtCommPort.Size = new System.Drawing.Size(81, 20);
            this.txtCommPort.TabIndex = 0;
            this.txtCommPort.Text = "1";
            // 
            // txtCommKey
            // 
            this.txtCommKey.AcceptsReturn = true;
            this.txtCommKey.Location = new System.Drawing.Point(80, 102);
            this.txtCommKey.MaxLength = 0;
            this.txtCommKey.Name = "txtCommKey";
            this.txtCommKey.Size = new System.Drawing.Size(81, 20);
            this.txtCommKey.TabIndex = 4;
            this.txtCommKey.Text = "0";
            // 
            // txtPort
            // 
            this.txtPort.AcceptsReturn = true;
            this.txtPort.Location = new System.Drawing.Point(80, 69);
            this.txtPort.MaxLength = 0;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(81, 20);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "4370";
            // 
            // txtIPAdd
            // 
            this.txtIPAdd.AcceptsReturn = true;
            this.txtIPAdd.Location = new System.Drawing.Point(80, 45);
            this.txtIPAdd.MaxLength = 0;
            this.txtIPAdd.Name = "txtIPAdd";
            this.txtIPAdd.Size = new System.Drawing.Size(81, 20);
            this.txtIPAdd.TabIndex = 7;
            this.txtIPAdd.Text = "192.168.2.118";
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.Location = new System.Drawing.Point(6, 214);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(65, 17);
            this.lblTimeOut.TabIndex = 135;
            this.lblTimeOut.Text = "Time Out (s)";
            // 
            // lblDelay
            // 
            this.lblDelay.Location = new System.Drawing.Point(6, 189);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(65, 17);
            this.lblDelay.TabIndex = 17;
            this.lblDelay.Text = "Delay (ms)";
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(6, 165);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(65, 17);
            this.lblModel.TabIndex = 18;
            this.lblModel.Text = "Model";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.Location = new System.Drawing.Point(6, 141);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(65, 17);
            this.lblBaudRate.TabIndex = 21;
            this.lblBaudRate.Text = "Baud Rate";
            // 
            // lblCommPort
            // 
            this.lblCommPort.Location = new System.Drawing.Point(6, 117);
            this.lblCommPort.Name = "lblCommPort";
            this.lblCommPort.Size = new System.Drawing.Size(65, 17);
            this.lblCommPort.TabIndex = 24;
            this.lblCommPort.Text = "Comm Port";
            // 
            // lblCommKey
            // 
            this.lblCommKey.Location = new System.Drawing.Point(6, 103);
            this.lblCommKey.Name = "lblCommKey";
            this.lblCommKey.Size = new System.Drawing.Size(65, 17);
            this.lblCommKey.TabIndex = 20;
            this.lblCommKey.Text = "Comm Key";
            // 
            // lblPort
            // 
            this.lblPort.Location = new System.Drawing.Point(6, 69);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(65, 17);
            this.lblPort.TabIndex = 22;
            this.lblPort.Text = "Port";
            // 
            // lblIPAdd
            // 
            this.lblIPAdd.Location = new System.Drawing.Point(6, 45);
            this.lblIPAdd.Name = "lblIPAdd";
            this.lblIPAdd.Size = new System.Drawing.Size(65, 17);
            this.lblIPAdd.TabIndex = 23;
            this.lblIPAdd.Text = "IP Address  ";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(244, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(84, 67);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Start";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // rBtnUSB
            // 
            this.rBtnUSB.AutoSize = true;
            this.rBtnUSB.Location = new System.Drawing.Point(126, 16);
            this.rBtnUSB.Name = "rBtnUSB";
            this.rBtnUSB.Size = new System.Drawing.Size(88, 17);
            this.rBtnUSB.TabIndex = 2;
            this.rBtnUSB.Text = "USB Client    ";
            this.rBtnUSB.UseVisualStyleBackColor = true;
            // 
            // rBtnCOM
            // 
            this.rBtnCOM.AutoSize = true;
            this.rBtnCOM.Location = new System.Drawing.Point(60, 16);
            this.rBtnCOM.Name = "rBtnCOM";
            this.rBtnCOM.Size = new System.Drawing.Size(58, 17);
            this.rBtnCOM.TabIndex = 1;
            this.rBtnCOM.Text = "COM   ";
            this.rBtnCOM.UseVisualStyleBackColor = true;
            // 
            // rBtnIP
            // 
            this.rBtnIP.AutoSize = true;
            this.rBtnIP.Checked = true;
            this.rBtnIP.Location = new System.Drawing.Point(8, 16);
            this.rBtnIP.Name = "rBtnIP";
            this.rBtnIP.Size = new System.Drawing.Size(74, 17);
            this.rBtnIP.TabIndex = 0;
            this.rBtnIP.TabStop = true;
            this.rBtnIP.Text = "IP             ";
            this.rBtnIP.UseVisualStyleBackColor = true;
            // 
            // List1
            // 
            this.List1.ForeColor = System.Drawing.Color.Red;
            this.List1.IntegralHeight = false;
            this.List1.Location = new System.Drawing.Point(12, 116);
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(328, 78);
            this.List1.TabIndex = 26;
            this.List1.TabStop = false;
            // 
            // axBioBridgeSDKv3lib1
            // 
            this.axBioBridgeSDKv3lib1.Enabled = true;
            this.axBioBridgeSDKv3lib1.Location = new System.Drawing.Point(12, 160);
            this.axBioBridgeSDKv3lib1.Name = "axBioBridgeSDKv3lib1";
            this.axBioBridgeSDKv3lib1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axBioBridgeSDKv3lib1.OcxState")));
            this.axBioBridgeSDKv3lib1.Size = new System.Drawing.Size(137, 35);
            this.axBioBridgeSDKv3lib1.TabIndex = 101;
            this.axBioBridgeSDKv3lib1.Visible = false;
            // 
            // List2
            // 
            this.List2.ForeColor = System.Drawing.Color.Red;
            this.List2.IntegralHeight = false;
            this.List2.Location = new System.Drawing.Point(12, 201);
            this.List2.Name = "List2";
            this.List2.Size = new System.Drawing.Size(328, 148);
            this.List2.TabIndex = 102;
            this.List2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPrev);
            this.groupBox1.Controls.Add(this.lblNIC);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(373, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 328);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Card Status";
            // 
            // lblPrev
            // 
            this.lblPrev.AutoSize = true;
            this.lblPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrev.Location = new System.Drawing.Point(254, 108);
            this.lblPrev.Name = "lblPrev";
            this.lblPrev.Size = new System.Drawing.Size(110, 25);
            this.lblPrev.TabIndex = 7;
            this.lblPrev.Text = "--------------";
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIC.Location = new System.Drawing.Point(254, 72);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(110, 25);
            this.lblNIC.TabIndex = 6;
            this.lblNIC.Text = "--------------";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(254, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 25);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "--------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "PREVIOUS ENTRY : ";
            // 
            // btnStatus
            // 
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.Location = new System.Drawing.Point(25, 180);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(498, 126);
            this.btnStatus.TabIndex = 3;
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIC : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME : ";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.List2);
            this.Controls.Add(this.List1);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.axBioBridgeSDKv3lib1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WAMCO Gatekeeper";
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axBioBridgeSDKv3lib1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox Frame1;
        public System.Windows.Forms.TextBox txtTimeOut;
        public System.Windows.Forms.TextBox txtDelay;
        public System.Windows.Forms.TextBox txtModel;
        public System.Windows.Forms.TextBox txtBaudRate;
        public System.Windows.Forms.TextBox txtCommPort;
        public System.Windows.Forms.TextBox txtCommKey;
        public System.Windows.Forms.TextBox txtPort;
        public System.Windows.Forms.TextBox txtIPAdd;
        public System.Windows.Forms.Label lblTimeOut;
        public System.Windows.Forms.Label lblDelay;
        public System.Windows.Forms.Label lblModel;
        public System.Windows.Forms.Label lblBaudRate;
        public System.Windows.Forms.Label lblCommPort;
        public System.Windows.Forms.Label lblCommKey;
        public System.Windows.Forms.Label lblPort;
        public System.Windows.Forms.Label lblIPAdd;
        public System.Windows.Forms.Button btnConnect;
        public System.Windows.Forms.RadioButton rBtnUSB;
        public System.Windows.Forms.RadioButton rBtnCOM;
        public System.Windows.Forms.RadioButton rBtnIP;
        public System.Windows.Forms.ListBox List1;
        private AxBioBridgeSDKv3.AxBioBridgeSDKv3lib axBioBridgeSDKv3lib1;
        public System.Windows.Forms.ListBox List2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrev;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblName;
    }
}