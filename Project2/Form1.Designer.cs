namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConnect = new System.Windows.Forms.Button();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.btnIsTFT = new System.Windows.Forms.Button();
            this.btnDisWithTimeOut = new System.Windows.Forms.Button();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.btnUnlockDoor = new System.Windows.Forms.Button();
            this.txtDeviceNo = new System.Windows.Forms.TextBox();
            this.lblDeviceNo = new System.Windows.Forms.Label();
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
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.btnSetComm = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.rBtnUSB = new System.Windows.Forms.RadioButton();
            this.rBtnCOM = new System.Windows.Forms.RadioButton();
            this.rBtnIP = new System.Windows.Forms.RadioButton();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this.btnSyncTime = new System.Windows.Forms.Button();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.btnGetTime = new System.Windows.Forms.Button();
            this.lblSecond = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.lblMinute = new System.Windows.Forms.Label();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.lblHour = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.Frame3 = new System.Windows.Forms.GroupBox();
            this.txtSetLastCount = new System.Windows.Forms.TextBox();
            this.lblSetLastCount = new System.Windows.Forms.Label();
            this.btnClearAdmin = new System.Windows.Forms.Button();
            this.btnClearAllFields = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnClearUserData = new System.Windows.Forms.Button();
            this.btnReadLog = new System.Windows.Forms.Button();
            this.btnReadUserData = new System.Windows.Forms.Button();
            this.List1 = new System.Windows.Forms.ListBox();
            this.Frame4 = new System.Windows.Forms.GroupBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.btnDeleteUserInfo = new System.Windows.Forms.Button();
            this.btnSetUserInfo = new System.Windows.Forms.Button();
            this.btnGetUserInfo = new System.Windows.Forms.Button();
            this.cmbEnabled = new System.Windows.Forms.ComboBox();
            this.txtPrivilege = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEnrollNo = new System.Windows.Forms.TextBox();
            this.lblEnabled = new System.Windows.Forms.Label();
            this.lblPrivilege = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEnrollNo = new System.Windows.Forms.Label();
            this.Frame5 = new System.Windows.Forms.GroupBox();
            this.txtFingerprintTemplate = new System.Windows.Forms.TextBox();
            this.lblFingerprintTemplate = new System.Windows.Forms.Label();
            this.btnDeleteTemplate = new System.Windows.Forms.Button();
            this.btnSetTemplate = new System.Windows.Forms.Button();
            this.btnGetTemplate = new System.Windows.Forms.Button();
            this.txtFingerIndex = new System.Windows.Forms.TextBox();
            this.txtEnrollNoFinger = new System.Windows.Forms.TextBox();
            this.lblFingerIndex = new System.Windows.Forms.Label();
            this.lblEnrollNoFinger = new System.Windows.Forms.Label();
            this.Frame6 = new System.Windows.Forms.GroupBox();
            this.btnSetUnlockG = new System.Windows.Forms.Button();
            this.btnGetUnlockG = new System.Windows.Forms.Button();
            this.txtUnlockGroup = new System.Windows.Forms.TextBox();
            this.btnSetTimeZoneNo = new System.Windows.Forms.Button();
            this.btnGetTimeZoneNo = new System.Windows.Forms.Button();
            this.txtTimeZoneNo = new System.Windows.Forms.TextBox();
            this.txtTimeZoneStr = new System.Windows.Forms.TextBox();
            this.btnSetGTimeZone = new System.Windows.Forms.Button();
            this.btnGetGTimeZone = new System.Windows.Forms.Button();
            this.btnSetTimeZone = new System.Windows.Forms.Button();
            this.btnGetTimeZone = new System.Windows.Forms.Button();
            this.btnSetUsergroup = new System.Windows.Forms.Button();
            this.btnGetUsergroup = new System.Windows.Forms.Button();
            this.txtTimeZoneInfo = new System.Windows.Forms.TextBox();
            this.txtGroupNo = new System.Windows.Forms.TextBox();
            this.txtEnrollNoTimezone = new System.Windows.Forms.TextBox();
            this.lblUnlockGroup = new System.Windows.Forms.Label();
            this.lblTimeZoneStr = new System.Windows.Forms.Label();
            this.lblTimeZoneNo = new System.Windows.Forms.Label();
            this.lblTimeZoneInfo = new System.Windows.Forms.Label();
            this.lblGroupNo = new System.Windows.Forms.Label();
            this.lblEnrollNoTimezone = new System.Windows.Forms.Label();
            this.Frame7 = new System.Windows.Forms.GroupBox();
            this.btnDecryptAttLog = new System.Windows.Forms.Button();
            this.Frame9 = new System.Windows.Forms.GroupBox();
            this.btnSaveTemplateUSB = new System.Windows.Forms.Button();
            this.btnGetTemplateUSB = new System.Windows.Forms.Button();
            this.txtFingerTemplateUSB = new System.Windows.Forms.TextBox();
            this.lblFingerTemplateUSB = new System.Windows.Forms.Label();
            this.lblFingerIndexUSB = new System.Windows.Forms.Label();
            this.txtFingerIndexUSB = new System.Windows.Forms.TextBox();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnGetUserFileUSB = new System.Windows.Forms.Button();
            this.txtRecordSize = new System.Windows.Forms.TextBox();
            this.lblRecordSize = new System.Windows.Forms.Label();
            this.txtTimeZoneInfoUSB = new System.Windows.Forms.TextBox();
            this.txtTimeZoneGUSB = new System.Windows.Forms.TextBox();
            this.lblTimeZoneInfoUSB = new System.Windows.Forms.Label();
            this.lblTimeZoneGUSB = new System.Windows.Forms.Label();
            this.txtPasswordUSB = new System.Windows.Forms.TextBox();
            this.txtNameUSB = new System.Windows.Forms.TextBox();
            this.lblPasswordUSB = new System.Windows.Forms.Label();
            this.lblNameUSB = new System.Windows.Forms.Label();
            this.txtPriviledgeUSB = new System.Windows.Forms.TextBox();
            this.txtEnrollNoUSB = new System.Windows.Forms.TextBox();
            this.lblPriviledgeUSB = new System.Windows.Forms.Label();
            this.lblEnrollNoUSB = new System.Windows.Forms.Label();
            this.Frame8 = new System.Windows.Forms.GroupBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.axBioBridgeSDKv3lib1 = new AxBioBridgeSDKv3.AxBioBridgeSDKv3lib();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSSRDelUserSMS = new System.Windows.Forms.Button();
            this.btnSSRSetUserSMS = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.optPrivate = new System.Windows.Forms.RadioButton();
            this.optPublic = new System.Windows.Forms.RadioButton();
            this.btnClearUserSMS = new System.Windows.Forms.Button();
            this.btnDeleteUserSMS = new System.Windows.Forms.Button();
            this.btnSetUserSMS = new System.Windows.Forms.Button();
            this.btnClearSMS = new System.Windows.Forms.Button();
            this.btnDeleteSMS = new System.Windows.Forms.Button();
            this.btnSetSMS = new System.Windows.Forms.Button();
            this.btnGetSMS = new System.Windows.Forms.Button();
            this.txtEnrollNoSMS = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtValidTime = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtSMSID = new System.Windows.Forms.TextBox();
            this.lblEnrollNoSMS = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblValidMinutes = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblSMSID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetUserVerType = new System.Windows.Forms.Button();
            this.btnGetUserVerType = new System.Windows.Forms.Button();
            this.txtVerType = new System.Windows.Forms.TextBox();
            this.txtEnrollNoVerType = new System.Windows.Forms.TextBox();
            this.lblVerType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnListBox1Clear = new System.Windows.Forms.Button();
            this.btnDelUserFace = new System.Windows.Forms.Button();
            this.btnSetUserFace = new System.Windows.Forms.Button();
            this.btnGetUserFace = new System.Windows.Forms.Button();
            this.btnSetFaceData = new System.Windows.Forms.Button();
            this.btnGetFaceData = new System.Windows.Forms.Button();
            this.btnSetFP10 = new System.Windows.Forms.Button();
            this.GetFP10 = new System.Windows.Forms.Button();
            this.mmTplT = new System.Windows.Forms.TextBox();
            this.edtFingerT = new System.Windows.Forms.TextBox();
            this.edtEnrollNoT = new System.Windows.Forms.TextBox();
            this.btnSetTemplateFileData = new System.Windows.Forms.Button();
            this.btnGetTemplateFileData = new System.Windows.Forms.Button();
            this.edtTZU = new System.Windows.Forms.TextBox();
            this.edtTZGU = new System.Windows.Forms.TextBox();
            this.edtCardNoU = new System.Windows.Forms.TextBox();
            this.edtPriU = new System.Windows.Forms.TextBox();
            this.edtPwdU = new System.Windows.Forms.TextBox();
            this.edtNameU = new System.Windows.Forms.TextBox();
            this.edtEnrollNoU = new System.Windows.Forms.TextBox();
            this.btnWriteUserFile = new System.Windows.Forms.Button();
            this.btnReadUserFile = new System.Windows.Forms.Button();
            this.edtFile = new System.Windows.Forms.TextBox();
            this.edtED = new System.Windows.Forms.TextBox();
            this.edtEM = new System.Windows.Forms.TextBox();
            this.edtBD = new System.Windows.Forms.TextBox();
            this.edtBM = new System.Windows.Forms.TextBox();
            this.btnSetHoliday = new System.Windows.Forms.Button();
            this.btnGetHoliday = new System.Windows.Forms.Button();
            this.edtTZID = new System.Windows.Forms.TextBox();
            this.edtHolID = new System.Windows.Forms.TextBox();
            this.btnSetGroupTZ = new System.Windows.Forms.Button();
            this.btnGetGroupTZ = new System.Windows.Forms.Button();
            this.edtTZ3 = new System.Windows.Forms.TextBox();
            this.edtTZ2 = new System.Windows.Forms.TextBox();
            this.edtTZ1 = new System.Windows.Forms.TextBox();
            this.edtVerMode = new System.Windows.Forms.TextBox();
            this.edtHol = new System.Windows.Forms.TextBox();
            this.edtTZGID = new System.Windows.Forms.TextBox();
            this.edtG5 = new System.Windows.Forms.TextBox();
            this.edtG4 = new System.Windows.Forms.TextBox();
            this.edtG3 = new System.Windows.Forms.TextBox();
            this.edtG2 = new System.Windows.Forms.TextBox();
            this.edtG1 = new System.Windows.Forms.TextBox();
            this.edtComNo = new System.Windows.Forms.TextBox();
            this.btnSetUnlockGroup = new System.Windows.Forms.Button();
            this.btnGetUnlockGroup = new System.Windows.Forms.Button();
            this.btnClearWC = new System.Windows.Forms.Button();
            this.btnDeleteWC = new System.Windows.Forms.Button();
            this.btnSetWC = new System.Windows.Forms.Button();
            this.btnGetWC = new System.Windows.Forms.Button();
            this.edtWC = new System.Windows.Forms.TextBox();
            this.edtWCID = new System.Windows.Forms.TextBox();
            this.edtFinger = new System.Windows.Forms.TextBox();
            this.edtPwd = new System.Windows.Forms.TextBox();
            this.edtName = new System.Windows.Forms.TextBox();
            this.edtEnrollNo = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this._Frame4_4 = new System.Windows.Forms.GroupBox();
            this.btnFile = new System.Windows.Forms.Button();
            this._Frame4_3 = new System.Windows.Forms.GroupBox();
            this._Frame4_2 = new System.Windows.Forms.GroupBox();
            this._Frame4_1 = new System.Windows.Forms.GroupBox();
            this._Frame4_0 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDelUserTpl = new System.Windows.Forms.Button();
            this.btnSetUserTpl = new System.Windows.Forms.Button();
            this.btnGetUserTpl = new System.Windows.Forms.Button();
            this.btnSSRDelUserInfo = new System.Windows.Forms.Button();
            this.btnSSRSetUserInfo = new System.Windows.Forms.Button();
            this.btnSSRGetUserInfo = new System.Windows.Forms.Button();
            this.mmTpl = new System.Windows.Forms.TextBox();
            this.edtCardNo = new System.Windows.Forms.TextBox();
            this.edtValid = new System.Windows.Forms.TextBox();
            this.edtPri = new System.Windows.Forms.TextBox();
            this._Label1_33 = new System.Windows.Forms.Label();
            this._Label1_32 = new System.Windows.Forms.Label();
            this._Label1_31 = new System.Windows.Forms.Label();
            this._Label1_30 = new System.Windows.Forms.Label();
            this._Label1_29 = new System.Windows.Forms.Label();
            this._Label1_28 = new System.Windows.Forms.Label();
            this._Label1_27 = new System.Windows.Forms.Label();
            this._Label1_26 = new System.Windows.Forms.Label();
            this._Label1_25 = new System.Windows.Forms.Label();
            this._Label1_24 = new System.Windows.Forms.Label();
            this._Label1_23 = new System.Windows.Forms.Label();
            this._Label1_22 = new System.Windows.Forms.Label();
            this._Label1_21 = new System.Windows.Forms.Label();
            this._Label1_20 = new System.Windows.Forms.Label();
            this._Label1_19 = new System.Windows.Forms.Label();
            this._Label1_18 = new System.Windows.Forms.Label();
            this._Label1_17 = new System.Windows.Forms.Label();
            this._Label1_16 = new System.Windows.Forms.Label();
            this._Label1_15 = new System.Windows.Forms.Label();
            this._Label1_14 = new System.Windows.Forms.Label();
            this._Label1_13 = new System.Windows.Forms.Label();
            this._Label1_12 = new System.Windows.Forms.Label();
            this._Label1_11 = new System.Windows.Forms.Label();
            this._Label1_10 = new System.Windows.Forms.Label();
            this._Label1_9 = new System.Windows.Forms.Label();
            this.lblWordCode = new System.Windows.Forms.Label();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValid = new System.Windows.Forms.Label();
            this.lblPriviledge = new System.Windows.Forms.Label();
            this.lblFinger = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSSRGetGeneralLog = new System.Windows.Forms.Button();
            this.btnSSRGetAllUser = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnListBox2Clear = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnGetFail = new System.Windows.Forms.Button();
            this.btnGetSuccess = new System.Windows.Forms.Button();
            this.btnOpenPhoto = new System.Windows.Forms.Button();
            this.btnOpenPicture = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.edtPicPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edtDownloadPicture = new System.Windows.Forms.TextBox();
            this.btnDownloadPicture = new System.Windows.Forms.Button();
            this.edtPhotoPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edtDownloadPhoto = new System.Windows.Forms.TextBox();
            this.btnDownloadPhoto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.edtDelPhoto = new System.Windows.Forms.TextBox();
            this.btnDelPhoto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.edtDelPicture = new System.Windows.Forms.TextBox();
            this.btnDelPicture = new System.Windows.Forms.Button();
            this.edtPhoto = new System.Windows.Forms.TextBox();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.edtPicture = new System.Windows.Forms.TextBox();
            this.btnUploadPicture = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.btnGroupTimezone_Set = new System.Windows.Forms.Button();
            this.txtGroupTimezone_Verify = new System.Windows.Forms.TextBox();
            this.txtGroupTimezone_Timezone = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtGroupTimezone_Group = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnGroupTimezone_Get = new System.Windows.Forms.Button();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.btnSleepSet = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.btnSleepGet = new System.Windows.Forms.Button();
            this.txtSleepM = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtSleepH = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.btnPlatform = new System.Windows.Forms.Button();
            this.txtPlatform = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.btnSubnetSet = new System.Windows.Forms.Button();
            this.btnSubnetGet = new System.Windows.Forms.Button();
            this.txtSubnet = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.btnGatewaySet = new System.Windows.Forms.Button();
            this.btnGatewayGet = new System.Windows.Forms.Button();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.txtBeginCard = new System.Windows.Forms.TextBox();
            this.txtBeginPassword = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBeginEnroll = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnBeginStart = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnGetErrorCard = new System.Windows.Forms.Button();
            this.btnClearErrorCard = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnSetAntipassback = new System.Windows.Forms.Button();
            this.btnGetAntipassback = new System.Windows.Forms.Button();
            this.txtAntipassback = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnListBox3Clear = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnH2iAdminCard_Set = new System.Windows.Forms.Button();
            this.txtH2iAdminCard = new System.Windows.Forms.TextBox();
            this.btnH2iAdminCard_Get = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnH2i_TurnAlarmOff = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnPowerOff = new System.Windows.Forms.Button();
            this.btnPowerOn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPowerMinute = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPowerHour = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.label99 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.txtHolidayParamId = new System.Windows.Forms.TextBox();
            this.label97 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.btnSetHolidayParam = new System.Windows.Forms.Button();
            this.txtStartDay = new System.Windows.Forms.TextBox();
            this.btnGetHolidayParam = new System.Windows.Forms.Button();
            this.txtEndMonth = new System.Windows.Forms.TextBox();
            this.txtEndDay = new System.Windows.Forms.TextBox();
            this.txtTZHolidayParam = new System.Windows.Forms.TextBox();
            this.txtStartMonth = new System.Windows.Forms.TextBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.btnSetEveryWeekTimezone = new System.Windows.Forms.Button();
            this.btnGetEveryWeekTimezone = new System.Windows.Forms.Button();
            this.txtDayOfWeek = new System.Windows.Forms.TextBox();
            this.label92 = new System.Windows.Forms.Label();
            this.txtVc50 = new System.Windows.Forms.TextBox();
            this.txtEt50 = new System.Windows.Forms.TextBox();
            this.txtSt50 = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.txtVc49 = new System.Windows.Forms.TextBox();
            this.txtEt49 = new System.Windows.Forms.TextBox();
            this.txtSt49 = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.txtVc48 = new System.Windows.Forms.TextBox();
            this.txtEt48 = new System.Windows.Forms.TextBox();
            this.txtSt48 = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.txtVc47 = new System.Windows.Forms.TextBox();
            this.txtEt47 = new System.Windows.Forms.TextBox();
            this.txtSt47 = new System.Windows.Forms.TextBox();
            this.label82 = new System.Windows.Forms.Label();
            this.txtVc46 = new System.Windows.Forms.TextBox();
            this.txtEt46 = new System.Windows.Forms.TextBox();
            this.txtSt46 = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.txtVc45 = new System.Windows.Forms.TextBox();
            this.txtEt45 = new System.Windows.Forms.TextBox();
            this.txtSt45 = new System.Windows.Forms.TextBox();
            this.label84 = new System.Windows.Forms.Label();
            this.txtVc44 = new System.Windows.Forms.TextBox();
            this.txtEt44 = new System.Windows.Forms.TextBox();
            this.txtSt44 = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.txtVc43 = new System.Windows.Forms.TextBox();
            this.txtEt43 = new System.Windows.Forms.TextBox();
            this.txtSt43 = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.txtVc42 = new System.Windows.Forms.TextBox();
            this.txtEt42 = new System.Windows.Forms.TextBox();
            this.txtSt42 = new System.Windows.Forms.TextBox();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.txtVc41 = new System.Windows.Forms.TextBox();
            this.txtEt41 = new System.Windows.Forms.TextBox();
            this.txtSt41 = new System.Windows.Forms.TextBox();
            this.label91 = new System.Windows.Forms.Label();
            this.txtVc40 = new System.Windows.Forms.TextBox();
            this.txtEt40 = new System.Windows.Forms.TextBox();
            this.txtSt40 = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.txtVc39 = new System.Windows.Forms.TextBox();
            this.txtEt39 = new System.Windows.Forms.TextBox();
            this.txtSt39 = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.txtVc38 = new System.Windows.Forms.TextBox();
            this.txtEt38 = new System.Windows.Forms.TextBox();
            this.txtSt38 = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.txtVc37 = new System.Windows.Forms.TextBox();
            this.txtEt37 = new System.Windows.Forms.TextBox();
            this.txtSt37 = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.txtVc36 = new System.Windows.Forms.TextBox();
            this.txtEt36 = new System.Windows.Forms.TextBox();
            this.txtSt36 = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.txtVc35 = new System.Windows.Forms.TextBox();
            this.txtEt35 = new System.Windows.Forms.TextBox();
            this.txtSt35 = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.txtVc34 = new System.Windows.Forms.TextBox();
            this.txtEt34 = new System.Windows.Forms.TextBox();
            this.txtSt34 = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.txtVc33 = new System.Windows.Forms.TextBox();
            this.txtEt33 = new System.Windows.Forms.TextBox();
            this.txtSt33 = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.txtVc32 = new System.Windows.Forms.TextBox();
            this.txtEt32 = new System.Windows.Forms.TextBox();
            this.txtSt32 = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.txtVc31 = new System.Windows.Forms.TextBox();
            this.txtEt31 = new System.Windows.Forms.TextBox();
            this.txtSt31 = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.txtVc30 = new System.Windows.Forms.TextBox();
            this.txtEt30 = new System.Windows.Forms.TextBox();
            this.txtSt30 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.txtVc29 = new System.Windows.Forms.TextBox();
            this.txtEt29 = new System.Windows.Forms.TextBox();
            this.txtSt29 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.txtVc28 = new System.Windows.Forms.TextBox();
            this.txtEt28 = new System.Windows.Forms.TextBox();
            this.txtSt28 = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.txtVc27 = new System.Windows.Forms.TextBox();
            this.txtEt27 = new System.Windows.Forms.TextBox();
            this.txtSt27 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.txtVc26 = new System.Windows.Forms.TextBox();
            this.txtEt26 = new System.Windows.Forms.TextBox();
            this.txtSt26 = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.txtVc25 = new System.Windows.Forms.TextBox();
            this.txtEt25 = new System.Windows.Forms.TextBox();
            this.txtSt25 = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.txtVc24 = new System.Windows.Forms.TextBox();
            this.txtEt24 = new System.Windows.Forms.TextBox();
            this.txtSt24 = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.txtVc23 = new System.Windows.Forms.TextBox();
            this.txtEt23 = new System.Windows.Forms.TextBox();
            this.txtSt23 = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.txtVc22 = new System.Windows.Forms.TextBox();
            this.txtEt22 = new System.Windows.Forms.TextBox();
            this.txtSt22 = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.txtVc21 = new System.Windows.Forms.TextBox();
            this.txtEt21 = new System.Windows.Forms.TextBox();
            this.txtSt21 = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.txtVc20 = new System.Windows.Forms.TextBox();
            this.txtEt20 = new System.Windows.Forms.TextBox();
            this.txtSt20 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtVc19 = new System.Windows.Forms.TextBox();
            this.txtEt19 = new System.Windows.Forms.TextBox();
            this.txtSt19 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtVc18 = new System.Windows.Forms.TextBox();
            this.txtEt18 = new System.Windows.Forms.TextBox();
            this.txtSt18 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txtVc17 = new System.Windows.Forms.TextBox();
            this.txtEt17 = new System.Windows.Forms.TextBox();
            this.txtSt17 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.txtVc16 = new System.Windows.Forms.TextBox();
            this.txtEt16 = new System.Windows.Forms.TextBox();
            this.txtSt16 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtVc15 = new System.Windows.Forms.TextBox();
            this.txtEt15 = new System.Windows.Forms.TextBox();
            this.txtSt15 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txtVc14 = new System.Windows.Forms.TextBox();
            this.txtEt14 = new System.Windows.Forms.TextBox();
            this.txtSt14 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txtVc13 = new System.Windows.Forms.TextBox();
            this.txtEt13 = new System.Windows.Forms.TextBox();
            this.txtSt13 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.txtVc12 = new System.Windows.Forms.TextBox();
            this.txtEt12 = new System.Windows.Forms.TextBox();
            this.txtSt12 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.txtVc11 = new System.Windows.Forms.TextBox();
            this.txtEt11 = new System.Windows.Forms.TextBox();
            this.txtSt11 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.txtVc10 = new System.Windows.Forms.TextBox();
            this.txtEt10 = new System.Windows.Forms.TextBox();
            this.txtSt10 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtVc9 = new System.Windows.Forms.TextBox();
            this.txtEt9 = new System.Windows.Forms.TextBox();
            this.txtSt9 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtVc8 = new System.Windows.Forms.TextBox();
            this.txtEt8 = new System.Windows.Forms.TextBox();
            this.txtSt8 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txtVc7 = new System.Windows.Forms.TextBox();
            this.txtEt7 = new System.Windows.Forms.TextBox();
            this.txtSt7 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txtVc6 = new System.Windows.Forms.TextBox();
            this.txtEt6 = new System.Windows.Forms.TextBox();
            this.txtSt6 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txtVc5 = new System.Windows.Forms.TextBox();
            this.txtEt5 = new System.Windows.Forms.TextBox();
            this.txtSt5 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtVc4 = new System.Windows.Forms.TextBox();
            this.txtEt4 = new System.Windows.Forms.TextBox();
            this.txtSt4 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txtVc3 = new System.Windows.Forms.TextBox();
            this.txtEt3 = new System.Windows.Forms.TextBox();
            this.txtSt3 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtVc2 = new System.Windows.Forms.TextBox();
            this.txtEt2 = new System.Windows.Forms.TextBox();
            this.txtSt2 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtVc1 = new System.Windows.Forms.TextBox();
            this.txtEt1 = new System.Windows.Forms.TextBox();
            this.txtSt1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Frame1.SuspendLayout();
            this.Frame2.SuspendLayout();
            this.Frame3.SuspendLayout();
            this.Frame4.SuspendLayout();
            this.Frame5.SuspendLayout();
            this.Frame6.SuspendLayout();
            this.Frame7.SuspendLayout();
            this.Frame9.SuspendLayout();
            this.Frame8.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axBioBridgeSDKv3lib1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(244, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(89, 25);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Frame1
            // 
            this.Frame1.Controls.Add(this.button2);
            this.Frame1.Controls.Add(this.btnIsTFT);
            this.Frame1.Controls.Add(this.btnDisWithTimeOut);
            this.Frame1.Controls.Add(this.chkEnable);
            this.Frame1.Controls.Add(this.btnUnlockDoor);
            this.Frame1.Controls.Add(this.txtDeviceNo);
            this.Frame1.Controls.Add(this.lblDeviceNo);
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
            this.Frame1.Controls.Add(this.btnRestart);
            this.Frame1.Controls.Add(this.btnAdvance);
            this.Frame1.Controls.Add(this.btnSetComm);
            this.Frame1.Controls.Add(this.btnDisconnect);
            this.Frame1.Controls.Add(this.btnConnect);
            this.Frame1.Controls.Add(this.rBtnUSB);
            this.Frame1.Controls.Add(this.rBtnCOM);
            this.Frame1.Controls.Add(this.rBtnIP);
            this.Frame1.Location = new System.Drawing.Point(3, 3);
            this.Frame1.Name = "Frame1";
            this.Frame1.Size = new System.Drawing.Size(337, 241);
            this.Frame1.TabIndex = 12;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Device Connector";
            // 
            // btnIsTFT
            // 
            this.btnIsTFT.Location = new System.Drawing.Point(244, 130);
            this.btnIsTFT.Name = "btnIsTFT";
            this.btnIsTFT.Size = new System.Drawing.Size(89, 25);
            this.btnIsTFT.TabIndex = 138;
            this.btnIsTFT.Text = "Is TFT";
            this.btnIsTFT.UseVisualStyleBackColor = false;
            this.btnIsTFT.Click += new System.EventHandler(this.btnIsTFT_Click);
            // 
            // btnDisWithTimeOut
            // 
            this.btnDisWithTimeOut.Location = new System.Drawing.Point(167, 212);
            this.btnDisWithTimeOut.Name = "btnDisWithTimeOut";
            this.btnDisWithTimeOut.Size = new System.Drawing.Size(162, 25);
            this.btnDisWithTimeOut.TabIndex = 137;
            this.btnDisWithTimeOut.Text = "Disable Device with Timeout";
            this.btnDisWithTimeOut.UseVisualStyleBackColor = false;
            this.btnDisWithTimeOut.Click += new System.EventHandler(this.btnDisWithTimeOut_Click);
            // 
            // chkEnable
            // 
            this.chkEnable.Location = new System.Drawing.Point(260, 181);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(74, 37);
            this.chkEnable.TabIndex = 1;
            this.chkEnable.Text = "Enable / Disable";
            this.chkEnable.UseVisualStyleBackColor = true;
            this.chkEnable.CheckedChanged += new System.EventHandler(this.chkEnable_CheckStateChanged);
            // 
            // btnUnlockDoor
            // 
            this.btnUnlockDoor.Location = new System.Drawing.Point(167, 187);
            this.btnUnlockDoor.Name = "btnUnlockDoor";
            this.btnUnlockDoor.Size = new System.Drawing.Size(89, 25);
            this.btnUnlockDoor.TabIndex = 8;
            this.btnUnlockDoor.Text = "Unlock Door";
            this.btnUnlockDoor.UseVisualStyleBackColor = false;
            this.btnUnlockDoor.Click += new System.EventHandler(this.btnUnlockDoor_Click);
            // 
            // txtDeviceNo
            // 
            this.txtDeviceNo.AcceptsReturn = true;
            this.txtDeviceNo.Location = new System.Drawing.Point(246, 159);
            this.txtDeviceNo.MaxLength = 0;
            this.txtDeviceNo.Name = "txtDeviceNo";
            this.txtDeviceNo.Size = new System.Drawing.Size(81, 20);
            this.txtDeviceNo.TabIndex = 3;
            this.txtDeviceNo.Text = "1";
            // 
            // lblDeviceNo
            // 
            this.lblDeviceNo.Location = new System.Drawing.Point(180, 162);
            this.lblDeviceNo.Name = "lblDeviceNo";
            this.lblDeviceNo.Size = new System.Drawing.Size(65, 17);
            this.lblDeviceNo.TabIndex = 19;
            this.lblDeviceNo.Text = "Device No";
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
            this.txtCommKey.Location = new System.Drawing.Point(80, 93);
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
            this.txtIPAdd.Text = "192.168.1.201";
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
            this.lblCommKey.Location = new System.Drawing.Point(6, 93);
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
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(244, 106);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(89, 25);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnAdvance
            // 
            this.btnAdvance.Location = new System.Drawing.Point(244, 82);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(89, 25);
            this.btnAdvance.TabIndex = 5;
            this.btnAdvance.Text = "Advance";
            this.btnAdvance.UseVisualStyleBackColor = false;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // btnSetComm
            // 
            this.btnSetComm.Location = new System.Drawing.Point(244, 58);
            this.btnSetComm.Name = "btnSetComm";
            this.btnSetComm.Size = new System.Drawing.Size(89, 25);
            this.btnSetComm.TabIndex = 4;
            this.btnSetComm.Text = "Set Comm Key";
            this.btnSetComm.UseVisualStyleBackColor = false;
            this.btnSetComm.Click += new System.EventHandler(this.btnSetComm_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(244, 34);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(89, 25);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // rBtnUSB
            // 
            this.rBtnUSB.AutoSize = true;
            this.rBtnUSB.Location = new System.Drawing.Point(126, 16);
            this.rBtnUSB.Name = "rBtnUSB";
            this.rBtnUSB.Size = new System.Drawing.Size(88, 17);
            this.rBtnUSB.TabIndex = 2;
            this.rBtnUSB.TabStop = true;
            this.rBtnUSB.Text = "USB Client    ";
            this.rBtnUSB.UseVisualStyleBackColor = true;
            this.rBtnUSB.CheckedChanged += new System.EventHandler(this.rBtnUSB_CheckedChanged);
            // 
            // rBtnCOM
            // 
            this.rBtnCOM.AutoSize = true;
            this.rBtnCOM.Location = new System.Drawing.Point(60, 16);
            this.rBtnCOM.Name = "rBtnCOM";
            this.rBtnCOM.Size = new System.Drawing.Size(58, 17);
            this.rBtnCOM.TabIndex = 1;
            this.rBtnCOM.TabStop = true;
            this.rBtnCOM.Text = "COM   ";
            this.rBtnCOM.UseVisualStyleBackColor = true;
            this.rBtnCOM.CheckedChanged += new System.EventHandler(this.rBtnCOM_CheckedChanged);
            // 
            // rBtnIP
            // 
            this.rBtnIP.AutoSize = true;
            this.rBtnIP.Location = new System.Drawing.Point(8, 16);
            this.rBtnIP.Name = "rBtnIP";
            this.rBtnIP.Size = new System.Drawing.Size(74, 17);
            this.rBtnIP.TabIndex = 0;
            this.rBtnIP.TabStop = true;
            this.rBtnIP.Text = "IP             ";
            this.rBtnIP.UseVisualStyleBackColor = true;
            this.rBtnIP.CheckedChanged += new System.EventHandler(this.rBtnIP_CheckedChanged);
            // 
            // Frame2
            // 
            this.Frame2.Controls.Add(this.btnSyncTime);
            this.Frame2.Controls.Add(this.btnSetTime);
            this.Frame2.Controls.Add(this.btnGetTime);
            this.Frame2.Controls.Add(this.lblSecond);
            this.Frame2.Controls.Add(this.txtSecond);
            this.Frame2.Controls.Add(this.lblMinute);
            this.Frame2.Controls.Add(this.txtMinute);
            this.Frame2.Controls.Add(this.lblHour);
            this.Frame2.Controls.Add(this.txtHour);
            this.Frame2.Controls.Add(this.lblTime);
            this.Frame2.Controls.Add(this.lblYear);
            this.Frame2.Controls.Add(this.txtYear);
            this.Frame2.Controls.Add(this.lblMonth);
            this.Frame2.Controls.Add(this.txtMonth);
            this.Frame2.Controls.Add(this.lblDay);
            this.Frame2.Controls.Add(this.txtDay);
            this.Frame2.Controls.Add(this.lblDate);
            this.Frame2.Location = new System.Drawing.Point(3, 245);
            this.Frame2.Name = "Frame2";
            this.Frame2.Size = new System.Drawing.Size(337, 105);
            this.Frame2.TabIndex = 36;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Device Date and Time";
            // 
            // btnSyncTime
            // 
            this.btnSyncTime.Location = new System.Drawing.Point(144, 71);
            this.btnSyncTime.Name = "btnSyncTime";
            this.btnSyncTime.Size = new System.Drawing.Size(57, 25);
            this.btnSyncTime.TabIndex = 33;
            this.btnSyncTime.Text = "Sync";
            this.btnSyncTime.UseVisualStyleBackColor = false;
            this.btnSyncTime.Click += new System.EventHandler(this.btnSyncTime_Click);
            // 
            // btnSetTime
            // 
            this.btnSetTime.Location = new System.Drawing.Point(80, 71);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(57, 25);
            this.btnSetTime.TabIndex = 34;
            this.btnSetTime.Text = "Set";
            this.btnSetTime.UseVisualStyleBackColor = false;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // btnGetTime
            // 
            this.btnGetTime.Location = new System.Drawing.Point(16, 71);
            this.btnGetTime.Name = "btnGetTime";
            this.btnGetTime.Size = new System.Drawing.Size(57, 25);
            this.btnGetTime.TabIndex = 35;
            this.btnGetTime.Text = "Get";
            this.btnGetTime.UseVisualStyleBackColor = false;
            this.btnGetTime.Click += new System.EventHandler(this.btnGetTime_Click);
            // 
            // lblSecond
            // 
            this.lblSecond.Location = new System.Drawing.Point(280, 48);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(49, 17);
            this.lblSecond.TabIndex = 39;
            this.lblSecond.Text = "Second";
            // 
            // txtSecond
            // 
            this.txtSecond.AcceptsReturn = true;
            this.txtSecond.Location = new System.Drawing.Point(238, 45);
            this.txtSecond.MaxLength = 0;
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(41, 20);
            this.txtSecond.TabIndex = 27;
            this.txtSecond.Text = "00";
            // 
            // lblMinute
            // 
            this.lblMinute.Location = new System.Drawing.Point(185, 48);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(41, 17);
            this.lblMinute.TabIndex = 40;
            this.lblMinute.Text = "Minute";
            // 
            // txtMinute
            // 
            this.txtMinute.AcceptsReturn = true;
            this.txtMinute.Location = new System.Drawing.Point(159, 45);
            this.txtMinute.MaxLength = 0;
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(25, 20);
            this.txtMinute.TabIndex = 28;
            this.txtMinute.Text = "00";
            // 
            // lblHour
            // 
            this.lblHour.Location = new System.Drawing.Point(107, 48);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(41, 17);
            this.lblHour.TabIndex = 41;
            this.lblHour.Text = "Hour";
            // 
            // txtHour
            // 
            this.txtHour.AcceptsReturn = true;
            this.txtHour.Location = new System.Drawing.Point(81, 45);
            this.txtHour.MaxLength = 0;
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(25, 20);
            this.txtHour.TabIndex = 29;
            this.txtHour.Text = "00";
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(8, 48);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 17);
            this.lblTime.TabIndex = 38;
            this.lblTime.Text = "Time";
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(280, 24);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(49, 17);
            this.lblYear.TabIndex = 42;
            this.lblYear.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.AcceptsReturn = true;
            this.txtYear.Location = new System.Drawing.Point(238, 21);
            this.txtYear.MaxLength = 0;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(41, 20);
            this.txtYear.TabIndex = 30;
            this.txtYear.Text = "0000";
            // 
            // lblMonth
            // 
            this.lblMonth.Location = new System.Drawing.Point(185, 24);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(41, 17);
            this.lblMonth.TabIndex = 43;
            this.lblMonth.Text = "Month";
            // 
            // txtMonth
            // 
            this.txtMonth.AcceptsReturn = true;
            this.txtMonth.Location = new System.Drawing.Point(159, 21);
            this.txtMonth.MaxLength = 0;
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(25, 20);
            this.txtMonth.TabIndex = 31;
            this.txtMonth.Text = "00";
            // 
            // lblDay
            // 
            this.lblDay.Location = new System.Drawing.Point(107, 24);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(41, 17);
            this.lblDay.TabIndex = 44;
            this.lblDay.Text = "Day";
            // 
            // txtDay
            // 
            this.txtDay.AcceptsReturn = true;
            this.txtDay.Location = new System.Drawing.Point(81, 21);
            this.txtDay.MaxLength = 0;
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(25, 20);
            this.txtDay.TabIndex = 32;
            this.txtDay.Text = "00";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(8, 24);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 17);
            this.lblDate.TabIndex = 37;
            this.lblDate.Text = "Date";
            // 
            // Frame3
            // 
            this.Frame3.Controls.Add(this.txtSetLastCount);
            this.Frame3.Controls.Add(this.lblSetLastCount);
            this.Frame3.Controls.Add(this.btnClearAdmin);
            this.Frame3.Controls.Add(this.btnClearAllFields);
            this.Frame3.Controls.Add(this.btnClearLog);
            this.Frame3.Controls.Add(this.btnClearUserData);
            this.Frame3.Controls.Add(this.btnReadLog);
            this.Frame3.Controls.Add(this.btnReadUserData);
            this.Frame3.Location = new System.Drawing.Point(3, 351);
            this.Frame3.Name = "Frame3";
            this.Frame3.Size = new System.Drawing.Size(217, 161);
            this.Frame3.TabIndex = 50;
            this.Frame3.TabStop = false;
            this.Frame3.Text = "General Data Management";
            // 
            // txtSetLastCount
            // 
            this.txtSetLastCount.AcceptsReturn = true;
            this.txtSetLastCount.Location = new System.Drawing.Point(110, 118);
            this.txtSetLastCount.MaxLength = 0;
            this.txtSetLastCount.Name = "txtSetLastCount";
            this.txtSetLastCount.Size = new System.Drawing.Size(97, 20);
            this.txtSetLastCount.TabIndex = 139;
            this.txtSetLastCount.Text = "0";
            // 
            // lblSetLastCount
            // 
            this.lblSetLastCount.Location = new System.Drawing.Point(24, 121);
            this.lblSetLastCount.Name = "lblSetLastCount";
            this.lblSetLastCount.Size = new System.Drawing.Size(80, 17);
            this.lblSetLastCount.TabIndex = 138;
            this.lblSetLastCount.Text = "Set Last Count";
            // 
            // btnClearAdmin
            // 
            this.btnClearAdmin.Location = new System.Drawing.Point(110, 83);
            this.btnClearAdmin.Name = "btnClearAdmin";
            this.btnClearAdmin.Size = new System.Drawing.Size(97, 25);
            this.btnClearAdmin.TabIndex = 48;
            this.btnClearAdmin.Text = "Clear Admin";
            this.btnClearAdmin.UseVisualStyleBackColor = false;
            this.btnClearAdmin.Click += new System.EventHandler(this.btnClearAdmin_Click);
            // 
            // btnClearAllFields
            // 
            this.btnClearAllFields.Location = new System.Drawing.Point(7, 83);
            this.btnClearAllFields.Name = "btnClearAllFields";
            this.btnClearAllFields.Size = new System.Drawing.Size(97, 25);
            this.btnClearAllFields.TabIndex = 51;
            this.btnClearAllFields.Text = "Clear All Fields";
            this.btnClearAllFields.UseVisualStyleBackColor = false;
            this.btnClearAllFields.Click += new System.EventHandler(this.btnClearAllFields_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(110, 52);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(97, 25);
            this.btnClearLog.TabIndex = 45;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = false;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnClearUserData
            // 
            this.btnClearUserData.Location = new System.Drawing.Point(7, 52);
            this.btnClearUserData.Name = "btnClearUserData";
            this.btnClearUserData.Size = new System.Drawing.Size(97, 25);
            this.btnClearUserData.TabIndex = 49;
            this.btnClearUserData.Text = "Clear All Data";
            this.btnClearUserData.UseVisualStyleBackColor = false;
            this.btnClearUserData.Click += new System.EventHandler(this.btnClearUserData_Click);
            // 
            // btnReadLog
            // 
            this.btnReadLog.Location = new System.Drawing.Point(110, 21);
            this.btnReadLog.Name = "btnReadLog";
            this.btnReadLog.Size = new System.Drawing.Size(97, 25);
            this.btnReadLog.TabIndex = 46;
            this.btnReadLog.Text = "Read Log";
            this.btnReadLog.UseVisualStyleBackColor = false;
            this.btnReadLog.Click += new System.EventHandler(this.btnReadLog_Click);
            // 
            // btnReadUserData
            // 
            this.btnReadUserData.Location = new System.Drawing.Point(7, 21);
            this.btnReadUserData.Name = "btnReadUserData";
            this.btnReadUserData.Size = new System.Drawing.Size(97, 25);
            this.btnReadUserData.TabIndex = 47;
            this.btnReadUserData.Text = "Read User Data";
            this.btnReadUserData.UseVisualStyleBackColor = false;
            this.btnReadUserData.Click += new System.EventHandler(this.btnReadUserData_Click);
            // 
            // List1
            // 
            this.List1.ForeColor = System.Drawing.Color.Red;
            this.List1.IntegralHeight = false;
            this.List1.Location = new System.Drawing.Point(223, 360);
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(625, 151);
            this.List1.TabIndex = 25;
            this.List1.TabStop = false;
            // 
            // Frame4
            // 
            this.Frame4.Controls.Add(this.txtCardNo);
            this.Frame4.Controls.Add(this.lblCardNo);
            this.Frame4.Controls.Add(this.btnDeleteUserInfo);
            this.Frame4.Controls.Add(this.btnSetUserInfo);
            this.Frame4.Controls.Add(this.btnGetUserInfo);
            this.Frame4.Controls.Add(this.cmbEnabled);
            this.Frame4.Controls.Add(this.txtPrivilege);
            this.Frame4.Controls.Add(this.txtPassword);
            this.Frame4.Controls.Add(this.txtName);
            this.Frame4.Controls.Add(this.txtEnrollNo);
            this.Frame4.Controls.Add(this.lblEnabled);
            this.Frame4.Controls.Add(this.lblPrivilege);
            this.Frame4.Controls.Add(this.lblPassword);
            this.Frame4.Controls.Add(this.lblName);
            this.Frame4.Controls.Add(this.lblEnrollNo);
            this.Frame4.Location = new System.Drawing.Point(346, 3);
            this.Frame4.Name = "Frame4";
            this.Frame4.Size = new System.Drawing.Size(281, 145);
            this.Frame4.TabIndex = 54;
            this.Frame4.TabStop = false;
            this.Frame4.Text = "User Information Management";
            // 
            // txtCardNo
            // 
            this.txtCardNo.AcceptsReturn = true;
            this.txtCardNo.Location = new System.Drawing.Point(176, 117);
            this.txtCardNo.MaxLength = 0;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(97, 20);
            this.txtCardNo.TabIndex = 129;
            this.txtCardNo.Text = "0";
            // 
            // lblCardNo
            // 
            this.lblCardNo.Location = new System.Drawing.Point(128, 120);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(57, 17);
            this.lblCardNo.TabIndex = 130;
            this.lblCardNo.Text = "Card No.";
            // 
            // btnDeleteUserInfo
            // 
            this.btnDeleteUserInfo.Location = new System.Drawing.Point(176, 88);
            this.btnDeleteUserInfo.Name = "btnDeleteUserInfo";
            this.btnDeleteUserInfo.Size = new System.Drawing.Size(97, 25);
            this.btnDeleteUserInfo.TabIndex = 55;
            this.btnDeleteUserInfo.Text = "Delete User Info";
            this.btnDeleteUserInfo.UseVisualStyleBackColor = false;
            this.btnDeleteUserInfo.Click += new System.EventHandler(this.btnDeleteUserInfo_Click);
            // 
            // btnSetUserInfo
            // 
            this.btnSetUserInfo.Location = new System.Drawing.Point(176, 56);
            this.btnSetUserInfo.Name = "btnSetUserInfo";
            this.btnSetUserInfo.Size = new System.Drawing.Size(97, 25);
            this.btnSetUserInfo.TabIndex = 52;
            this.btnSetUserInfo.Text = "Set User Info";
            this.btnSetUserInfo.UseVisualStyleBackColor = false;
            this.btnSetUserInfo.Click += new System.EventHandler(this.btnSetUserInfo_Click);
            // 
            // btnGetUserInfo
            // 
            this.btnGetUserInfo.Location = new System.Drawing.Point(176, 24);
            this.btnGetUserInfo.Name = "btnGetUserInfo";
            this.btnGetUserInfo.Size = new System.Drawing.Size(97, 25);
            this.btnGetUserInfo.TabIndex = 53;
            this.btnGetUserInfo.Text = "Get User Info";
            this.btnGetUserInfo.UseVisualStyleBackColor = false;
            this.btnGetUserInfo.Click += new System.EventHandler(this.btnGetUserInfo_Click);
            // 
            // cmbEnabled
            // 
            this.cmbEnabled.DropDownWidth = 57;
            this.cmbEnabled.Location = new System.Drawing.Point(72, 117);
            this.cmbEnabled.Name = "cmbEnabled";
            this.cmbEnabled.Size = new System.Drawing.Size(57, 21);
            this.cmbEnabled.Sorted = true;
            this.cmbEnabled.TabIndex = 56;
            this.cmbEnabled.Text = "True";
            // 
            // txtPrivilege
            // 
            this.txtPrivilege.AcceptsReturn = true;
            this.txtPrivilege.Location = new System.Drawing.Point(72, 93);
            this.txtPrivilege.MaxLength = 0;
            this.txtPrivilege.Name = "txtPrivilege";
            this.txtPrivilege.Size = new System.Drawing.Size(97, 20);
            this.txtPrivilege.TabIndex = 57;
            this.txtPrivilege.Text = "0";
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = true;
            this.txtPassword.Location = new System.Drawing.Point(72, 69);
            this.txtPassword.MaxLength = 0;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(97, 20);
            this.txtPassword.TabIndex = 58;
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = true;
            this.txtName.Location = new System.Drawing.Point(72, 45);
            this.txtName.MaxLength = 0;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(97, 20);
            this.txtName.TabIndex = 59;
            // 
            // txtEnrollNo
            // 
            this.txtEnrollNo.AcceptsReturn = true;
            this.txtEnrollNo.Location = new System.Drawing.Point(72, 21);
            this.txtEnrollNo.MaxLength = 0;
            this.txtEnrollNo.Name = "txtEnrollNo";
            this.txtEnrollNo.Size = new System.Drawing.Size(97, 20);
            this.txtEnrollNo.TabIndex = 60;
            this.txtEnrollNo.Text = "1100";
            // 
            // lblEnabled
            // 
            this.lblEnabled.Location = new System.Drawing.Point(9, 120);
            this.lblEnabled.Name = "lblEnabled";
            this.lblEnabled.Size = new System.Drawing.Size(57, 17);
            this.lblEnabled.TabIndex = 61;
            this.lblEnabled.Text = "Enabled";
            // 
            // lblPrivilege
            // 
            this.lblPrivilege.Location = new System.Drawing.Point(9, 96);
            this.lblPrivilege.Name = "lblPrivilege";
            this.lblPrivilege.Size = new System.Drawing.Size(65, 17);
            this.lblPrivilege.TabIndex = 62;
            this.lblPrivilege.Text = "Privilege";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(9, 72);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(65, 17);
            this.lblPassword.TabIndex = 63;
            this.lblPassword.Text = "Password";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(9, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 17);
            this.lblName.TabIndex = 64;
            this.lblName.Text = "Name";
            // 
            // lblEnrollNo
            // 
            this.lblEnrollNo.Location = new System.Drawing.Point(9, 24);
            this.lblEnrollNo.Name = "lblEnrollNo";
            this.lblEnrollNo.Size = new System.Drawing.Size(65, 17);
            this.lblEnrollNo.TabIndex = 65;
            this.lblEnrollNo.Text = "Enroll No";
            // 
            // Frame5
            // 
            this.Frame5.Controls.Add(this.txtFingerprintTemplate);
            this.Frame5.Controls.Add(this.lblFingerprintTemplate);
            this.Frame5.Controls.Add(this.btnDeleteTemplate);
            this.Frame5.Controls.Add(this.btnSetTemplate);
            this.Frame5.Controls.Add(this.btnGetTemplate);
            this.Frame5.Controls.Add(this.txtFingerIndex);
            this.Frame5.Controls.Add(this.txtEnrollNoFinger);
            this.Frame5.Controls.Add(this.lblFingerIndex);
            this.Frame5.Controls.Add(this.lblEnrollNoFinger);
            this.Frame5.Location = new System.Drawing.Point(346, 154);
            this.Frame5.Name = "Frame5";
            this.Frame5.Size = new System.Drawing.Size(281, 137);
            this.Frame5.TabIndex = 69;
            this.Frame5.TabStop = false;
            this.Frame5.Text = "User Fingerprint Template Management";
            // 
            // txtFingerprintTemplate
            // 
            this.txtFingerprintTemplate.AcceptsReturn = true;
            this.txtFingerprintTemplate.Location = new System.Drawing.Point(8, 112);
            this.txtFingerprintTemplate.MaxLength = 0;
            this.txtFingerprintTemplate.Name = "txtFingerprintTemplate";
            this.txtFingerprintTemplate.Size = new System.Drawing.Size(265, 20);
            this.txtFingerprintTemplate.TabIndex = 70;
            // 
            // lblFingerprintTemplate
            // 
            this.lblFingerprintTemplate.Location = new System.Drawing.Point(8, 88);
            this.lblFingerprintTemplate.Name = "lblFingerprintTemplate";
            this.lblFingerprintTemplate.Size = new System.Drawing.Size(129, 17);
            this.lblFingerprintTemplate.TabIndex = 75;
            this.lblFingerprintTemplate.Text = "Fingerprint Template";
            // 
            // btnDeleteTemplate
            // 
            this.btnDeleteTemplate.Location = new System.Drawing.Point(173, 79);
            this.btnDeleteTemplate.Name = "btnDeleteTemplate";
            this.btnDeleteTemplate.Size = new System.Drawing.Size(102, 25);
            this.btnDeleteTemplate.TabIndex = 66;
            this.btnDeleteTemplate.Text = "Delete Template";
            this.btnDeleteTemplate.UseVisualStyleBackColor = false;
            this.btnDeleteTemplate.Click += new System.EventHandler(this.btnDeleteTemplate_Click);
            // 
            // btnSetTemplate
            // 
            this.btnSetTemplate.Location = new System.Drawing.Point(173, 48);
            this.btnSetTemplate.Name = "btnSetTemplate";
            this.btnSetTemplate.Size = new System.Drawing.Size(100, 25);
            this.btnSetTemplate.TabIndex = 67;
            this.btnSetTemplate.Text = "Set Template";
            this.btnSetTemplate.UseVisualStyleBackColor = false;
            this.btnSetTemplate.Click += new System.EventHandler(this.btnSetTemplate_Click);
            // 
            // btnGetTemplate
            // 
            this.btnGetTemplate.Location = new System.Drawing.Point(173, 16);
            this.btnGetTemplate.Name = "btnGetTemplate";
            this.btnGetTemplate.Size = new System.Drawing.Size(100, 25);
            this.btnGetTemplate.TabIndex = 68;
            this.btnGetTemplate.Text = "Get Template";
            this.btnGetTemplate.UseVisualStyleBackColor = false;
            this.btnGetTemplate.Click += new System.EventHandler(this.btnGetTemplate_Click);
            // 
            // txtFingerIndex
            // 
            this.txtFingerIndex.AcceptsReturn = true;
            this.txtFingerIndex.Location = new System.Drawing.Point(72, 48);
            this.txtFingerIndex.MaxLength = 0;
            this.txtFingerIndex.Name = "txtFingerIndex";
            this.txtFingerIndex.Size = new System.Drawing.Size(97, 20);
            this.txtFingerIndex.TabIndex = 71;
            this.txtFingerIndex.Text = "0";
            // 
            // txtEnrollNoFinger
            // 
            this.txtEnrollNoFinger.AcceptsReturn = true;
            this.txtEnrollNoFinger.Location = new System.Drawing.Point(72, 24);
            this.txtEnrollNoFinger.MaxLength = 0;
            this.txtEnrollNoFinger.Name = "txtEnrollNoFinger";
            this.txtEnrollNoFinger.Size = new System.Drawing.Size(97, 20);
            this.txtEnrollNoFinger.TabIndex = 72;
            this.txtEnrollNoFinger.Text = "1100";
            // 
            // lblFingerIndex
            // 
            this.lblFingerIndex.Location = new System.Drawing.Point(8, 48);
            this.lblFingerIndex.Name = "lblFingerIndex";
            this.lblFingerIndex.Size = new System.Drawing.Size(73, 17);
            this.lblFingerIndex.TabIndex = 73;
            this.lblFingerIndex.Text = "Finger Index";
            // 
            // lblEnrollNoFinger
            // 
            this.lblEnrollNoFinger.Location = new System.Drawing.Point(8, 24);
            this.lblEnrollNoFinger.Name = "lblEnrollNoFinger";
            this.lblEnrollNoFinger.Size = new System.Drawing.Size(65, 17);
            this.lblEnrollNoFinger.TabIndex = 74;
            this.lblEnrollNoFinger.Text = "Enroll No";
            // 
            // Frame6
            // 
            this.Frame6.Controls.Add(this.btnSetUnlockG);
            this.Frame6.Controls.Add(this.btnGetUnlockG);
            this.Frame6.Controls.Add(this.txtUnlockGroup);
            this.Frame6.Controls.Add(this.btnSetTimeZoneNo);
            this.Frame6.Controls.Add(this.btnGetTimeZoneNo);
            this.Frame6.Controls.Add(this.txtTimeZoneNo);
            this.Frame6.Controls.Add(this.txtTimeZoneStr);
            this.Frame6.Controls.Add(this.btnSetGTimeZone);
            this.Frame6.Controls.Add(this.btnGetGTimeZone);
            this.Frame6.Controls.Add(this.btnSetTimeZone);
            this.Frame6.Controls.Add(this.btnGetTimeZone);
            this.Frame6.Controls.Add(this.btnSetUsergroup);
            this.Frame6.Controls.Add(this.btnGetUsergroup);
            this.Frame6.Controls.Add(this.txtTimeZoneInfo);
            this.Frame6.Controls.Add(this.txtGroupNo);
            this.Frame6.Controls.Add(this.txtEnrollNoTimezone);
            this.Frame6.Controls.Add(this.lblUnlockGroup);
            this.Frame6.Controls.Add(this.lblTimeZoneStr);
            this.Frame6.Controls.Add(this.lblTimeZoneNo);
            this.Frame6.Controls.Add(this.lblTimeZoneInfo);
            this.Frame6.Controls.Add(this.lblGroupNo);
            this.Frame6.Controls.Add(this.lblEnrollNoTimezone);
            this.Frame6.Location = new System.Drawing.Point(633, 3);
            this.Frame6.Name = "Frame6";
            this.Frame6.Size = new System.Drawing.Size(217, 345);
            this.Frame6.TabIndex = 76;
            this.Frame6.TabStop = false;
            this.Frame6.Text = "Group Timezone Management";
            // 
            // btnSetUnlockG
            // 
            this.btnSetUnlockG.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetUnlockG.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSetUnlockG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetUnlockG.Location = new System.Drawing.Point(112, 311);
            this.btnSetUnlockG.Name = "btnSetUnlockG";
            this.btnSetUnlockG.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSetUnlockG.Size = new System.Drawing.Size(99, 25);
            this.btnSetUnlockG.TabIndex = 77;
            this.btnSetUnlockG.Text = "Set Unlock G";
            this.btnSetUnlockG.UseVisualStyleBackColor = false;
            this.btnSetUnlockG.Click += new System.EventHandler(this.btnSetUnlockG_Click);
            // 
            // btnGetUnlockG
            // 
            this.btnGetUnlockG.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetUnlockG.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGetUnlockG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetUnlockG.Location = new System.Drawing.Point(6, 311);
            this.btnGetUnlockG.Name = "btnGetUnlockG";
            this.btnGetUnlockG.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetUnlockG.Size = new System.Drawing.Size(99, 25);
            this.btnGetUnlockG.TabIndex = 78;
            this.btnGetUnlockG.Text = "Get Unlock G";
            this.btnGetUnlockG.UseVisualStyleBackColor = false;
            this.btnGetUnlockG.Click += new System.EventHandler(this.btnGetUnlockG_Click);
            // 
            // txtUnlockGroup
            // 
            this.txtUnlockGroup.AcceptsReturn = true;
            this.txtUnlockGroup.BackColor = System.Drawing.SystemColors.Window;
            this.txtUnlockGroup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnlockGroup.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUnlockGroup.Location = new System.Drawing.Point(103, 285);
            this.txtUnlockGroup.MaxLength = 0;
            this.txtUnlockGroup.Name = "txtUnlockGroup";
            this.txtUnlockGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUnlockGroup.Size = new System.Drawing.Size(97, 20);
            this.txtUnlockGroup.TabIndex = 79;
            // 
            // btnSetTimeZoneNo
            // 
            this.btnSetTimeZoneNo.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetTimeZoneNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSetTimeZoneNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetTimeZoneNo.Location = new System.Drawing.Point(111, 250);
            this.btnSetTimeZoneNo.Name = "btnSetTimeZoneNo";
            this.btnSetTimeZoneNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSetTimeZoneNo.Size = new System.Drawing.Size(99, 25);
            this.btnSetTimeZoneNo.TabIndex = 80;
            this.btnSetTimeZoneNo.Text = "Set TimeZone";
            this.btnSetTimeZoneNo.UseVisualStyleBackColor = false;
            this.btnSetTimeZoneNo.Click += new System.EventHandler(this.btnSetTimeZoneNo_Click);
            // 
            // btnGetTimeZoneNo
            // 
            this.btnGetTimeZoneNo.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetTimeZoneNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGetTimeZoneNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetTimeZoneNo.Location = new System.Drawing.Point(8, 250);
            this.btnGetTimeZoneNo.Name = "btnGetTimeZoneNo";
            this.btnGetTimeZoneNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetTimeZoneNo.Size = new System.Drawing.Size(89, 25);
            this.btnGetTimeZoneNo.TabIndex = 81;
            this.btnGetTimeZoneNo.Text = "Get TimeZone";
            this.btnGetTimeZoneNo.UseVisualStyleBackColor = false;
            this.btnGetTimeZoneNo.Click += new System.EventHandler(this.btnGetTimeZoneNo_Click);
            // 
            // txtTimeZoneNo
            // 
            this.txtTimeZoneNo.AcceptsReturn = true;
            this.txtTimeZoneNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimeZoneNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimeZoneNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTimeZoneNo.Location = new System.Drawing.Point(106, 197);
            this.txtTimeZoneNo.MaxLength = 0;
            this.txtTimeZoneNo.Name = "txtTimeZoneNo";
            this.txtTimeZoneNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTimeZoneNo.Size = new System.Drawing.Size(105, 20);
            this.txtTimeZoneNo.TabIndex = 85;
            this.txtTimeZoneNo.Text = "1";
            // 
            // txtTimeZoneStr
            // 
            this.txtTimeZoneStr.AcceptsReturn = true;
            this.txtTimeZoneStr.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimeZoneStr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimeZoneStr.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTimeZoneStr.Location = new System.Drawing.Point(106, 221);
            this.txtTimeZoneStr.MaxLength = 0;
            this.txtTimeZoneStr.Name = "txtTimeZoneStr";
            this.txtTimeZoneStr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTimeZoneStr.Size = new System.Drawing.Size(105, 20);
            this.txtTimeZoneStr.TabIndex = 84;
            // 
            // btnSetGTimeZone
            // 
            this.btnSetGTimeZone.Location = new System.Drawing.Point(112, 158);
            this.btnSetGTimeZone.Name = "btnSetGTimeZone";
            this.btnSetGTimeZone.Size = new System.Drawing.Size(99, 25);
            this.btnSetGTimeZone.TabIndex = 82;
            this.btnSetGTimeZone.Text = "Set G TimeZone";
            this.btnSetGTimeZone.UseVisualStyleBackColor = false;
            this.btnSetGTimeZone.Click += new System.EventHandler(this.btnSetGTimeZone_Click);
            // 
            // btnGetGTimeZone
            // 
            this.btnGetGTimeZone.Location = new System.Drawing.Point(6, 158);
            this.btnGetGTimeZone.Name = "btnGetGTimeZone";
            this.btnGetGTimeZone.Size = new System.Drawing.Size(99, 25);
            this.btnGetGTimeZone.TabIndex = 83;
            this.btnGetGTimeZone.Text = "Get G TimeZone";
            this.btnGetGTimeZone.UseVisualStyleBackColor = false;
            this.btnGetGTimeZone.Click += new System.EventHandler(this.btnGetGTimeZone_Click);
            // 
            // btnSetTimeZone
            // 
            this.btnSetTimeZone.Location = new System.Drawing.Point(112, 128);
            this.btnSetTimeZone.Name = "btnSetTimeZone";
            this.btnSetTimeZone.Size = new System.Drawing.Size(99, 25);
            this.btnSetTimeZone.TabIndex = 89;
            this.btnSetTimeZone.Text = "Set TimeZone";
            this.btnSetTimeZone.UseVisualStyleBackColor = false;
            this.btnSetTimeZone.Click += new System.EventHandler(this.btnSetTimeZone_Click);
            // 
            // btnGetTimeZone
            // 
            this.btnGetTimeZone.Location = new System.Drawing.Point(6, 127);
            this.btnGetTimeZone.Name = "btnGetTimeZone";
            this.btnGetTimeZone.Size = new System.Drawing.Size(99, 25);
            this.btnGetTimeZone.TabIndex = 90;
            this.btnGetTimeZone.Text = "Get TimeZone";
            this.btnGetTimeZone.UseVisualStyleBackColor = false;
            this.btnGetTimeZone.Click += new System.EventHandler(this.btnGetTimeZone_Click);
            // 
            // btnSetUsergroup
            // 
            this.btnSetUsergroup.Location = new System.Drawing.Point(112, 96);
            this.btnSetUsergroup.Name = "btnSetUsergroup";
            this.btnSetUsergroup.Size = new System.Drawing.Size(99, 25);
            this.btnSetUsergroup.TabIndex = 91;
            this.btnSetUsergroup.Text = "Set Usergroup";
            this.btnSetUsergroup.UseVisualStyleBackColor = false;
            this.btnSetUsergroup.Click += new System.EventHandler(this.btnSetUsergroup_Click);
            // 
            // btnGetUsergroup
            // 
            this.btnGetUsergroup.Location = new System.Drawing.Point(6, 96);
            this.btnGetUsergroup.Name = "btnGetUsergroup";
            this.btnGetUsergroup.Size = new System.Drawing.Size(99, 25);
            this.btnGetUsergroup.TabIndex = 92;
            this.btnGetUsergroup.Text = "Get Usergroup";
            this.btnGetUsergroup.UseVisualStyleBackColor = false;
            this.btnGetUsergroup.Click += new System.EventHandler(this.btnGetUsergroup_Click);
            // 
            // txtTimeZoneInfo
            // 
            this.txtTimeZoneInfo.AcceptsReturn = true;
            this.txtTimeZoneInfo.Location = new System.Drawing.Point(96, 72);
            this.txtTimeZoneInfo.MaxLength = 0;
            this.txtTimeZoneInfo.Name = "txtTimeZoneInfo";
            this.txtTimeZoneInfo.Size = new System.Drawing.Size(105, 20);
            this.txtTimeZoneInfo.TabIndex = 86;
            // 
            // txtGroupNo
            // 
            this.txtGroupNo.AcceptsReturn = true;
            this.txtGroupNo.Location = new System.Drawing.Point(96, 48);
            this.txtGroupNo.MaxLength = 0;
            this.txtGroupNo.Name = "txtGroupNo";
            this.txtGroupNo.Size = new System.Drawing.Size(105, 20);
            this.txtGroupNo.TabIndex = 87;
            // 
            // txtEnrollNoTimezone
            // 
            this.txtEnrollNoTimezone.AcceptsReturn = true;
            this.txtEnrollNoTimezone.Location = new System.Drawing.Point(96, 24);
            this.txtEnrollNoTimezone.MaxLength = 0;
            this.txtEnrollNoTimezone.Name = "txtEnrollNoTimezone";
            this.txtEnrollNoTimezone.Size = new System.Drawing.Size(105, 20);
            this.txtEnrollNoTimezone.TabIndex = 88;
            this.txtEnrollNoTimezone.Text = "1100";
            // 
            // lblUnlockGroup
            // 
            this.lblUnlockGroup.Location = new System.Drawing.Point(24, 288);
            this.lblUnlockGroup.Name = "lblUnlockGroup";
            this.lblUnlockGroup.Size = new System.Drawing.Size(73, 17);
            this.lblUnlockGroup.TabIndex = 93;
            this.lblUnlockGroup.Text = "Unlock Group";
            // 
            // lblTimeZoneStr
            // 
            this.lblTimeZoneStr.Location = new System.Drawing.Point(16, 224);
            this.lblTimeZoneStr.Name = "lblTimeZoneStr";
            this.lblTimeZoneStr.Size = new System.Drawing.Size(73, 17);
            this.lblTimeZoneStr.TabIndex = 94;
            this.lblTimeZoneStr.Text = "TimeZone Str";
            // 
            // lblTimeZoneNo
            // 
            this.lblTimeZoneNo.Location = new System.Drawing.Point(16, 200);
            this.lblTimeZoneNo.Name = "lblTimeZoneNo";
            this.lblTimeZoneNo.Size = new System.Drawing.Size(73, 17);
            this.lblTimeZoneNo.TabIndex = 95;
            this.lblTimeZoneNo.Text = "TimeZone No";
            // 
            // lblTimeZoneInfo
            // 
            this.lblTimeZoneInfo.Location = new System.Drawing.Point(16, 72);
            this.lblTimeZoneInfo.Name = "lblTimeZoneInfo";
            this.lblTimeZoneInfo.Size = new System.Drawing.Size(81, 17);
            this.lblTimeZoneInfo.TabIndex = 96;
            this.lblTimeZoneInfo.Text = "TimeZone Info";
            // 
            // lblGroupNo
            // 
            this.lblGroupNo.Location = new System.Drawing.Point(16, 48);
            this.lblGroupNo.Name = "lblGroupNo";
            this.lblGroupNo.Size = new System.Drawing.Size(57, 17);
            this.lblGroupNo.TabIndex = 97;
            this.lblGroupNo.Text = "Group No";
            // 
            // lblEnrollNoTimezone
            // 
            this.lblEnrollNoTimezone.Location = new System.Drawing.Point(16, 24);
            this.lblEnrollNoTimezone.Name = "lblEnrollNoTimezone";
            this.lblEnrollNoTimezone.Size = new System.Drawing.Size(73, 17);
            this.lblEnrollNoTimezone.TabIndex = 98;
            this.lblEnrollNoTimezone.Text = "Enroll No";
            // 
            // Frame7
            // 
            this.Frame7.Controls.Add(this.btnDecryptAttLog);
            this.Frame7.Controls.Add(this.Frame9);
            this.Frame7.Controls.Add(this.btnSaveToFile);
            this.Frame7.Controls.Add(this.btnGetUserFileUSB);
            this.Frame7.Controls.Add(this.txtRecordSize);
            this.Frame7.Controls.Add(this.lblRecordSize);
            this.Frame7.Controls.Add(this.txtTimeZoneInfoUSB);
            this.Frame7.Controls.Add(this.txtTimeZoneGUSB);
            this.Frame7.Controls.Add(this.lblTimeZoneInfoUSB);
            this.Frame7.Controls.Add(this.lblTimeZoneGUSB);
            this.Frame7.Controls.Add(this.txtPasswordUSB);
            this.Frame7.Controls.Add(this.txtNameUSB);
            this.Frame7.Controls.Add(this.lblPasswordUSB);
            this.Frame7.Controls.Add(this.lblNameUSB);
            this.Frame7.Controls.Add(this.txtPriviledgeUSB);
            this.Frame7.Controls.Add(this.txtEnrollNoUSB);
            this.Frame7.Controls.Add(this.lblPriviledgeUSB);
            this.Frame7.Controls.Add(this.lblEnrollNoUSB);
            this.Frame7.Controls.Add(this.Frame8);
            this.Frame7.Location = new System.Drawing.Point(3, 508);
            this.Frame7.Name = "Frame7";
            this.Frame7.Size = new System.Drawing.Size(849, 177);
            this.Frame7.TabIndex = 99;
            this.Frame7.TabStop = false;
            this.Frame7.Text = "External USB Management";
            // 
            // btnDecryptAttLog
            // 
            this.btnDecryptAttLog.BackColor = System.Drawing.SystemColors.Control;
            this.btnDecryptAttLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDecryptAttLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDecryptAttLog.Location = new System.Drawing.Point(517, 96);
            this.btnDecryptAttLog.Name = "btnDecryptAttLog";
            this.btnDecryptAttLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDecryptAttLog.Size = new System.Drawing.Size(121, 25);
            this.btnDecryptAttLog.TabIndex = 131;
            this.btnDecryptAttLog.Text = "Decrypt Att Log";
            this.btnDecryptAttLog.UseVisualStyleBackColor = false;
            this.btnDecryptAttLog.Click += new System.EventHandler(this.btnDecryptAttLog_Click);
            // 
            // Frame9
            // 
            this.Frame9.BackColor = System.Drawing.SystemColors.Control;
            this.Frame9.Controls.Add(this.btnSaveTemplateUSB);
            this.Frame9.Controls.Add(this.btnGetTemplateUSB);
            this.Frame9.Controls.Add(this.txtFingerTemplateUSB);
            this.Frame9.Controls.Add(this.lblFingerTemplateUSB);
            this.Frame9.Controls.Add(this.lblFingerIndexUSB);
            this.Frame9.Controls.Add(this.txtFingerIndexUSB);
            this.Frame9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame9.Location = new System.Drawing.Point(8, 120);
            this.Frame9.Name = "Frame9";
            this.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame9.Size = new System.Drawing.Size(833, 49);
            this.Frame9.TabIndex = 119;
            this.Frame9.TabStop = false;
            // 
            // btnSaveTemplateUSB
            // 
            this.btnSaveTemplateUSB.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveTemplateUSB.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveTemplateUSB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaveTemplateUSB.Location = new System.Drawing.Point(742, 11);
            this.btnSaveTemplateUSB.Name = "btnSaveTemplateUSB";
            this.btnSaveTemplateUSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSaveTemplateUSB.Size = new System.Drawing.Size(89, 25);
            this.btnSaveTemplateUSB.TabIndex = 108;
            this.btnSaveTemplateUSB.Text = "Save Template";
            this.btnSaveTemplateUSB.UseVisualStyleBackColor = false;
            this.btnSaveTemplateUSB.Click += new System.EventHandler(this.btnSaveTemplateUSB_Click);
            // 
            // btnGetTemplateUSB
            // 
            this.btnGetTemplateUSB.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetTemplateUSB.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGetTemplateUSB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetTemplateUSB.Location = new System.Drawing.Point(648, 11);
            this.btnGetTemplateUSB.Name = "btnGetTemplateUSB";
            this.btnGetTemplateUSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetTemplateUSB.Size = new System.Drawing.Size(89, 25);
            this.btnGetTemplateUSB.TabIndex = 109;
            this.btnGetTemplateUSB.Text = "Get Template";
            this.btnGetTemplateUSB.UseVisualStyleBackColor = false;
            this.btnGetTemplateUSB.Click += new System.EventHandler(this.btnGetTemplateUSB_Click);
            // 
            // txtFingerTemplateUSB
            // 
            this.txtFingerTemplateUSB.AcceptsReturn = true;
            this.txtFingerTemplateUSB.BackColor = System.Drawing.SystemColors.Window;
            this.txtFingerTemplateUSB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFingerTemplateUSB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFingerTemplateUSB.Location = new System.Drawing.Point(248, 14);
            this.txtFingerTemplateUSB.MaxLength = 0;
            this.txtFingerTemplateUSB.Name = "txtFingerTemplateUSB";
            this.txtFingerTemplateUSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFingerTemplateUSB.Size = new System.Drawing.Size(393, 20);
            this.txtFingerTemplateUSB.TabIndex = 102;
            // 
            // lblFingerTemplateUSB
            // 
            this.lblFingerTemplateUSB.BackColor = System.Drawing.SystemColors.Control;
            this.lblFingerTemplateUSB.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFingerTemplateUSB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFingerTemplateUSB.Location = new System.Drawing.Point(152, 16);
            this.lblFingerTemplateUSB.Name = "lblFingerTemplateUSB";
            this.lblFingerTemplateUSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFingerTemplateUSB.Size = new System.Drawing.Size(89, 17);
            this.lblFingerTemplateUSB.TabIndex = 121;
            this.lblFingerTemplateUSB.Text = "Finger Template";
            // 
            // lblFingerIndexUSB
            // 
            this.lblFingerIndexUSB.BackColor = System.Drawing.SystemColors.Control;
            this.lblFingerIndexUSB.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFingerIndexUSB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFingerIndexUSB.Location = new System.Drawing.Point(8, 16);
            this.lblFingerIndexUSB.Name = "lblFingerIndexUSB";
            this.lblFingerIndexUSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFingerIndexUSB.Size = new System.Drawing.Size(79, 17);
            this.lblFingerIndexUSB.TabIndex = 120;
            this.lblFingerIndexUSB.Text = "Finger Index";
            // 
            // txtFingerIndexUSB
            // 
            this.txtFingerIndexUSB.AcceptsReturn = true;
            this.txtFingerIndexUSB.BackColor = System.Drawing.SystemColors.Window;
            this.txtFingerIndexUSB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFingerIndexUSB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFingerIndexUSB.Location = new System.Drawing.Point(93, 13);
            this.txtFingerIndexUSB.MaxLength = 0;
            this.txtFingerIndexUSB.Name = "txtFingerIndexUSB";
            this.txtFingerIndexUSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFingerIndexUSB.Size = new System.Drawing.Size(36, 20);
            this.txtFingerIndexUSB.TabIndex = 107;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveToFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveToFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaveToFile.Location = new System.Drawing.Point(744, 72);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSaveToFile.Size = new System.Drawing.Size(89, 25);
            this.btnSaveToFile.TabIndex = 114;
            this.btnSaveToFile.Text = "Save to File";
            this.btnSaveToFile.UseVisualStyleBackColor = false;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnGetUserFileUSB
            // 
            this.btnGetUserFileUSB.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetUserFileUSB.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGetUserFileUSB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetUserFileUSB.Location = new System.Drawing.Point(648, 72);
            this.btnGetUserFileUSB.Name = "btnGetUserFileUSB";
            this.btnGetUserFileUSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetUserFileUSB.Size = new System.Drawing.Size(89, 25);
            this.btnGetUserFileUSB.TabIndex = 115;
            this.btnGetUserFileUSB.Text = "Get User File";
            this.btnGetUserFileUSB.UseVisualStyleBackColor = false;
            this.btnGetUserFileUSB.Click += new System.EventHandler(this.btnGetUserFileUSB_Click);
            // 
            // txtRecordSize
            // 
            this.txtRecordSize.AcceptsReturn = true;
            this.txtRecordSize.BackColor = System.Drawing.SystemColors.Window;
            this.txtRecordSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecordSize.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRecordSize.Location = new System.Drawing.Point(576, 72);
            this.txtRecordSize.MaxLength = 0;
            this.txtRecordSize.Name = "txtRecordSize";
            this.txtRecordSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRecordSize.Size = new System.Drawing.Size(65, 20);
            this.txtRecordSize.TabIndex = 106;
            // 
            // lblRecordSize
            // 
            this.lblRecordSize.BackColor = System.Drawing.SystemColors.Control;
            this.lblRecordSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRecordSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRecordSize.Location = new System.Drawing.Point(497, 73);
            this.lblRecordSize.Name = "lblRecordSize";
            this.lblRecordSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRecordSize.Size = new System.Drawing.Size(74, 17);
            this.lblRecordSize.TabIndex = 123;
            this.lblRecordSize.Text = "Record Size";
            // 
            // txtTimeZoneInfoUSB
            // 
            this.txtTimeZoneInfoUSB.AcceptsReturn = true;
            this.txtTimeZoneInfoUSB.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimeZoneInfoUSB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimeZoneInfoUSB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTimeZoneInfoUSB.Location = new System.Drawing.Point(408, 96);
            this.txtTimeZoneInfoUSB.MaxLength = 0;
            this.txtTimeZoneInfoUSB.Name = "txtTimeZoneInfoUSB";
            this.txtTimeZoneInfoUSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTimeZoneInfoUSB.Size = new System.Drawing.Size(81, 20);
            this.txtTimeZoneInfoUSB.TabIndex = 110;
            // 
            // txtTimeZoneGUSB
            // 
            this.txtTimeZoneGUSB.AcceptsReturn = true;
            this.txtTimeZoneGUSB.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimeZoneGUSB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimeZoneGUSB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTimeZoneGUSB.Location = new System.Drawing.Point(408, 72);
            this.txtTimeZoneGUSB.MaxLength = 0;
            this.txtTimeZoneGUSB.Name = "txtTimeZoneGUSB";
            this.txtTimeZoneGUSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTimeZoneGUSB.Size = new System.Drawing.Size(81, 20);
            this.txtTimeZoneGUSB.TabIndex = 111;
            // 
            // lblTimeZoneInfoUSB
            // 
            this.lblTimeZoneInfoUSB.BackColor = System.Drawing.SystemColors.Control;
            this.lblTimeZoneInfoUSB.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTimeZoneInfoUSB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTimeZoneInfoUSB.Location = new System.Drawing.Point(328, 96);
            this.lblTimeZoneInfoUSB.Name = "lblTimeZoneInfoUSB";
            this.lblTimeZoneInfoUSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTimeZoneInfoUSB.Size = new System.Drawing.Size(81, 17);
            this.lblTimeZoneInfoUSB.TabIndex = 124;
            this.lblTimeZoneInfoUSB.Text = "TimeZone Info";
            // 
            // lblTimeZoneGUSB
            // 
            this.lblTimeZoneGUSB.BackColor = System.Drawing.SystemColors.Control;
            this.lblTimeZoneGUSB.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTimeZoneGUSB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTimeZoneGUSB.Location = new System.Drawing.Point(328, 72);
            this.lblTimeZoneGUSB.Name = "lblTimeZoneGUSB";
            this.lblTimeZoneGUSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTimeZoneGUSB.Size = new System.Drawing.Size(73, 17);
            this.lblTimeZoneGUSB.TabIndex = 125;
            this.lblTimeZoneGUSB.Text = "TimeZone G";
            // 
            // txtPasswordUSB
            // 
            this.txtPasswordUSB.AcceptsReturn = true;
            this.txtPasswordUSB.BackColor = System.Drawing.SystemColors.Window;
            this.txtPasswordUSB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordUSB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPasswordUSB.Location = new System.Drawing.Point(216, 96);
            this.txtPasswordUSB.MaxLength = 0;
            this.txtPasswordUSB.Name = "txtPasswordUSB";
            this.txtPasswordUSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPasswordUSB.Size = new System.Drawing.Size(89, 20);
            this.txtPasswordUSB.TabIndex = 112;
            // 
            // txtNameUSB
            // 
            this.txtNameUSB.AcceptsReturn = true;
            this.txtNameUSB.BackColor = System.Drawing.SystemColors.Window;
            this.txtNameUSB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameUSB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNameUSB.Location = new System.Drawing.Point(216, 72);
            this.txtNameUSB.MaxLength = 0;
            this.txtNameUSB.Name = "txtNameUSB";
            this.txtNameUSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNameUSB.Size = new System.Drawing.Size(89, 20);
            this.txtNameUSB.TabIndex = 113;
            // 
            // lblPasswordUSB
            // 
            this.lblPasswordUSB.BackColor = System.Drawing.SystemColors.Control;
            this.lblPasswordUSB.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPasswordUSB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPasswordUSB.Location = new System.Drawing.Point(160, 96);
            this.lblPasswordUSB.Name = "lblPasswordUSB";
            this.lblPasswordUSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPasswordUSB.Size = new System.Drawing.Size(57, 17);
            this.lblPasswordUSB.TabIndex = 126;
            this.lblPasswordUSB.Text = "Password";
            // 
            // lblNameUSB
            // 
            this.lblNameUSB.BackColor = System.Drawing.SystemColors.Control;
            this.lblNameUSB.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNameUSB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNameUSB.Location = new System.Drawing.Point(160, 72);
            this.lblNameUSB.Name = "lblNameUSB";
            this.lblNameUSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNameUSB.Size = new System.Drawing.Size(41, 17);
            this.lblNameUSB.TabIndex = 127;
            this.lblNameUSB.Text = "Name";
            // 
            // txtPriviledgeUSB
            // 
            this.txtPriviledgeUSB.AcceptsReturn = true;
            this.txtPriviledgeUSB.BackColor = System.Drawing.SystemColors.Window;
            this.txtPriviledgeUSB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriviledgeUSB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPriviledgeUSB.Location = new System.Drawing.Point(80, 96);
            this.txtPriviledgeUSB.MaxLength = 0;
            this.txtPriviledgeUSB.Name = "txtPriviledgeUSB";
            this.txtPriviledgeUSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPriviledgeUSB.Size = new System.Drawing.Size(65, 20);
            this.txtPriviledgeUSB.TabIndex = 105;
            // 
            // txtEnrollNoUSB
            // 
            this.txtEnrollNoUSB.AcceptsReturn = true;
            this.txtEnrollNoUSB.BackColor = System.Drawing.SystemColors.Window;
            this.txtEnrollNoUSB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnrollNoUSB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEnrollNoUSB.Location = new System.Drawing.Point(80, 72);
            this.txtEnrollNoUSB.MaxLength = 0;
            this.txtEnrollNoUSB.Name = "txtEnrollNoUSB";
            this.txtEnrollNoUSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEnrollNoUSB.Size = new System.Drawing.Size(65, 20);
            this.txtEnrollNoUSB.TabIndex = 116;
            this.txtEnrollNoUSB.Text = "1100";
            // 
            // lblPriviledgeUSB
            // 
            this.lblPriviledgeUSB.BackColor = System.Drawing.SystemColors.Control;
            this.lblPriviledgeUSB.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPriviledgeUSB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPriviledgeUSB.Location = new System.Drawing.Point(16, 96);
            this.lblPriviledgeUSB.Name = "lblPriviledgeUSB";
            this.lblPriviledgeUSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPriviledgeUSB.Size = new System.Drawing.Size(65, 17);
            this.lblPriviledgeUSB.TabIndex = 122;
            this.lblPriviledgeUSB.Text = "Privilege";
            // 
            // lblEnrollNoUSB
            // 
            this.lblEnrollNoUSB.BackColor = System.Drawing.SystemColors.Control;
            this.lblEnrollNoUSB.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEnrollNoUSB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnrollNoUSB.Location = new System.Drawing.Point(16, 72);
            this.lblEnrollNoUSB.Name = "lblEnrollNoUSB";
            this.lblEnrollNoUSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEnrollNoUSB.Size = new System.Drawing.Size(57, 17);
            this.lblEnrollNoUSB.TabIndex = 128;
            this.lblEnrollNoUSB.Text = "Enroll No";
            // 
            // Frame8
            // 
            this.Frame8.BackColor = System.Drawing.SystemColors.Control;
            this.Frame8.Controls.Add(this.btnOpenFile);
            this.Frame8.Controls.Add(this.txtFilename);
            this.Frame8.Controls.Add(this.lblFilename);
            this.Frame8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame8.Location = new System.Drawing.Point(8, 16);
            this.Frame8.Name = "Frame8";
            this.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame8.Size = new System.Drawing.Size(833, 49);
            this.Frame8.TabIndex = 117;
            this.Frame8.TabStop = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOpenFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenFile.Location = new System.Drawing.Point(489, 11);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOpenFile.Size = new System.Drawing.Size(90, 25);
            this.btnOpenFile.TabIndex = 103;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.AcceptsReturn = true;
            this.txtFilename.BackColor = System.Drawing.SystemColors.Window;
            this.txtFilename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilename.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFilename.Location = new System.Drawing.Point(58, 14);
            this.txtFilename.MaxLength = 0;
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFilename.Size = new System.Drawing.Size(425, 20);
            this.txtFilename.TabIndex = 104;
            // 
            // lblFilename
            // 
            this.lblFilename.BackColor = System.Drawing.SystemColors.Control;
            this.lblFilename.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFilename.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFilename.Location = new System.Drawing.Point(8, 16);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFilename.Size = new System.Drawing.Size(73, 17);
            this.lblFilename.TabIndex = 118;
            this.lblFilename.Text = "Filename";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(859, 711);
            this.tabControl1.TabIndex = 138;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.axBioBridgeSDKv3lib1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Frame1);
            this.tabPage1.Controls.Add(this.Frame2);
            this.tabPage1.Controls.Add(this.Frame7);
            this.tabPage1.Controls.Add(this.Frame4);
            this.tabPage1.Controls.Add(this.List1);
            this.tabPage1.Controls.Add(this.Frame5);
            this.tabPage1.Controls.Add(this.Frame6);
            this.tabPage1.Controls.Add(this.Frame3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(851, 685);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // axBioBridgeSDKv3lib1
            // 
            this.axBioBridgeSDKv3lib1.Enabled = true;
            this.axBioBridgeSDKv3lib1.Location = new System.Drawing.Point(355, 312);
            this.axBioBridgeSDKv3lib1.Name = "axBioBridgeSDKv3lib1";
            this.axBioBridgeSDKv3lib1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axBioBridgeSDKv3lib1.OcxState")));
            this.axBioBridgeSDKv3lib1.Size = new System.Drawing.Size(137, 35);
            this.axBioBridgeSDKv3lib1.TabIndex = 101;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(773, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 100;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(851, 685);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SMS & GrpVerType Demo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnSSRDelUserSMS);
            this.groupBox2.Controls.Add(this.btnSSRSetUserSMS);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.optPrivate);
            this.groupBox2.Controls.Add(this.optPublic);
            this.groupBox2.Controls.Add(this.btnClearUserSMS);
            this.groupBox2.Controls.Add(this.btnDeleteUserSMS);
            this.groupBox2.Controls.Add(this.btnSetUserSMS);
            this.groupBox2.Controls.Add(this.btnClearSMS);
            this.groupBox2.Controls.Add(this.btnDeleteSMS);
            this.groupBox2.Controls.Add(this.btnSetSMS);
            this.groupBox2.Controls.Add(this.btnGetSMS);
            this.groupBox2.Controls.Add(this.txtEnrollNoSMS);
            this.groupBox2.Controls.Add(this.txtStartTime);
            this.groupBox2.Controls.Add(this.txtValidTime);
            this.groupBox2.Controls.Add(this.txtContent);
            this.groupBox2.Controls.Add(this.txtSMSID);
            this.groupBox2.Controls.Add(this.lblEnrollNoSMS);
            this.groupBox2.Controls.Add(this.lblType);
            this.groupBox2.Controls.Add(this.lblStartTime);
            this.groupBox2.Controls.Add(this.lblValidMinutes);
            this.groupBox2.Controls.Add(this.lblContent);
            this.groupBox2.Controls.Add(this.lblSMSID);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(6, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(842, 241);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SMS";
            // 
            // btnSSRDelUserSMS
            // 
            this.btnSSRDelUserSMS.BackColor = System.Drawing.SystemColors.Control;
            this.btnSSRDelUserSMS.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSSRDelUserSMS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSSRDelUserSMS.Location = new System.Drawing.Point(542, 159);
            this.btnSSRDelUserSMS.Name = "btnSSRDelUserSMS";
            this.btnSSRDelUserSMS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSSRDelUserSMS.Size = new System.Drawing.Size(121, 25);
            this.btnSSRDelUserSMS.TabIndex = 31;
            this.btnSSRDelUserSMS.Text = "SSR_DelUserSMS";
            this.btnSSRDelUserSMS.UseVisualStyleBackColor = false;
            this.btnSSRDelUserSMS.Click += new System.EventHandler(this.btnSSRDelUserSMS_Click);
            // 
            // btnSSRSetUserSMS
            // 
            this.btnSSRSetUserSMS.BackColor = System.Drawing.SystemColors.Control;
            this.btnSSRSetUserSMS.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSSRSetUserSMS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSSRSetUserSMS.Location = new System.Drawing.Point(542, 128);
            this.btnSSRSetUserSMS.Name = "btnSSRSetUserSMS";
            this.btnSSRSetUserSMS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSSRSetUserSMS.Size = new System.Drawing.Size(121, 25);
            this.btnSSRSetUserSMS.TabIndex = 30;
            this.btnSSRSetUserSMS.Text = "SSR_SetUserSMS";
            this.btnSSRSetUserSMS.UseVisualStyleBackColor = false;
            this.btnSSRSetUserSMS.Click += new System.EventHandler(this.btnSSRSetUserSMS_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.lblStatus);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(531, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(304, 41);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStatus.ForeColor = System.Drawing.Color.Blue;
            this.lblStatus.Location = new System.Drawing.Point(8, 16);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(201, 17);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // optPrivate
            // 
            this.optPrivate.BackColor = System.Drawing.SystemColors.Control;
            this.optPrivate.Cursor = System.Windows.Forms.Cursors.Default;
            this.optPrivate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optPrivate.Location = new System.Drawing.Point(183, 104);
            this.optPrivate.Name = "optPrivate";
            this.optPrivate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optPrivate.Size = new System.Drawing.Size(74, 17);
            this.optPrivate.TabIndex = 27;
            this.optPrivate.TabStop = true;
            this.optPrivate.Text = "Private";
            this.optPrivate.UseVisualStyleBackColor = false;
            // 
            // optPublic
            // 
            this.optPublic.BackColor = System.Drawing.SystemColors.Control;
            this.optPublic.Checked = true;
            this.optPublic.Cursor = System.Windows.Forms.Cursors.Default;
            this.optPublic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optPublic.Location = new System.Drawing.Point(64, 104);
            this.optPublic.Name = "optPublic";
            this.optPublic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optPublic.Size = new System.Drawing.Size(57, 17);
            this.optPublic.TabIndex = 26;
            this.optPublic.TabStop = true;
            this.optPublic.Text = "Public";
            this.optPublic.UseVisualStyleBackColor = false;
            // 
            // btnClearUserSMS
            // 
            this.btnClearUserSMS.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearUserSMS.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClearUserSMS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearUserSMS.Location = new System.Drawing.Point(376, 190);
            this.btnClearUserSMS.Name = "btnClearUserSMS";
            this.btnClearUserSMS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClearUserSMS.Size = new System.Drawing.Size(137, 25);
            this.btnClearUserSMS.TabIndex = 25;
            this.btnClearUserSMS.Text = "Clear User SMS";
            this.btnClearUserSMS.UseVisualStyleBackColor = false;
            this.btnClearUserSMS.Click += new System.EventHandler(this.btnClearUserSMS_Click);
            // 
            // btnDeleteUserSMS
            // 
            this.btnDeleteUserSMS.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteUserSMS.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteUserSMS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteUserSMS.Location = new System.Drawing.Point(376, 159);
            this.btnDeleteUserSMS.Name = "btnDeleteUserSMS";
            this.btnDeleteUserSMS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteUserSMS.Size = new System.Drawing.Size(137, 25);
            this.btnDeleteUserSMS.TabIndex = 24;
            this.btnDeleteUserSMS.Text = "Delete User SMS";
            this.btnDeleteUserSMS.UseVisualStyleBackColor = false;
            this.btnDeleteUserSMS.Click += new System.EventHandler(this.btnDeleteUserSMS_Click);
            // 
            // btnSetUserSMS
            // 
            this.btnSetUserSMS.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetUserSMS.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSetUserSMS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetUserSMS.Location = new System.Drawing.Point(376, 128);
            this.btnSetUserSMS.Name = "btnSetUserSMS";
            this.btnSetUserSMS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSetUserSMS.Size = new System.Drawing.Size(137, 25);
            this.btnSetUserSMS.TabIndex = 23;
            this.btnSetUserSMS.Text = "Set User SMS";
            this.btnSetUserSMS.UseVisualStyleBackColor = false;
            this.btnSetUserSMS.Click += new System.EventHandler(this.btnSetUserSMS_Click);
            // 
            // btnClearSMS
            // 
            this.btnClearSMS.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearSMS.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClearSMS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearSMS.Location = new System.Drawing.Point(424, 88);
            this.btnClearSMS.Name = "btnClearSMS";
            this.btnClearSMS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClearSMS.Size = new System.Drawing.Size(89, 25);
            this.btnClearSMS.TabIndex = 22;
            this.btnClearSMS.Text = "Clear SMS";
            this.btnClearSMS.UseVisualStyleBackColor = false;
            this.btnClearSMS.Click += new System.EventHandler(this.btnClearSMS_Click);
            // 
            // btnDeleteSMS
            // 
            this.btnDeleteSMS.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteSMS.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteSMS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteSMS.Location = new System.Drawing.Point(424, 64);
            this.btnDeleteSMS.Name = "btnDeleteSMS";
            this.btnDeleteSMS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteSMS.Size = new System.Drawing.Size(89, 25);
            this.btnDeleteSMS.TabIndex = 21;
            this.btnDeleteSMS.Text = "Delete SMS";
            this.btnDeleteSMS.UseVisualStyleBackColor = false;
            this.btnDeleteSMS.Click += new System.EventHandler(this.btnDeleteSMS_Click);
            // 
            // btnSetSMS
            // 
            this.btnSetSMS.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetSMS.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSetSMS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetSMS.Location = new System.Drawing.Point(424, 40);
            this.btnSetSMS.Name = "btnSetSMS";
            this.btnSetSMS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSetSMS.Size = new System.Drawing.Size(89, 25);
            this.btnSetSMS.TabIndex = 20;
            this.btnSetSMS.Text = "SetSMS";
            this.btnSetSMS.UseVisualStyleBackColor = false;
            this.btnSetSMS.Click += new System.EventHandler(this.btnSetSMS_Click);
            // 
            // btnGetSMS
            // 
            this.btnGetSMS.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetSMS.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGetSMS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetSMS.Location = new System.Drawing.Point(424, 16);
            this.btnGetSMS.Name = "btnGetSMS";
            this.btnGetSMS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetSMS.Size = new System.Drawing.Size(89, 25);
            this.btnGetSMS.TabIndex = 19;
            this.btnGetSMS.Text = "GetSMS";
            this.btnGetSMS.UseVisualStyleBackColor = false;
            this.btnGetSMS.Click += new System.EventHandler(this.btnGetSMS_Click);
            // 
            // txtEnrollNoSMS
            // 
            this.txtEnrollNoSMS.AcceptsReturn = true;
            this.txtEnrollNoSMS.BackColor = System.Drawing.SystemColors.Window;
            this.txtEnrollNoSMS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnrollNoSMS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEnrollNoSMS.Location = new System.Drawing.Point(64, 136);
            this.txtEnrollNoSMS.MaxLength = 0;
            this.txtEnrollNoSMS.Name = "txtEnrollNoSMS";
            this.txtEnrollNoSMS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEnrollNoSMS.Size = new System.Drawing.Size(97, 20);
            this.txtEnrollNoSMS.TabIndex = 17;
            // 
            // txtStartTime
            // 
            this.txtStartTime.AcceptsReturn = true;
            this.txtStartTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartTime.Location = new System.Drawing.Point(272, 56);
            this.txtStartTime.MaxLength = 0;
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartTime.Size = new System.Drawing.Size(121, 20);
            this.txtStartTime.TabIndex = 15;
            // 
            // txtValidTime
            // 
            this.txtValidTime.AcceptsReturn = true;
            this.txtValidTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtValidTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValidTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValidTime.Location = new System.Drawing.Point(272, 30);
            this.txtValidTime.MaxLength = 0;
            this.txtValidTime.Name = "txtValidTime";
            this.txtValidTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtValidTime.Size = new System.Drawing.Size(57, 20);
            this.txtValidTime.TabIndex = 13;
            // 
            // txtContent
            // 
            this.txtContent.AcceptsReturn = true;
            this.txtContent.BackColor = System.Drawing.SystemColors.Window;
            this.txtContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContent.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtContent.Location = new System.Drawing.Point(64, 56);
            this.txtContent.MaxLength = 0;
            this.txtContent.Name = "txtContent";
            this.txtContent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContent.Size = new System.Drawing.Size(129, 20);
            this.txtContent.TabIndex = 11;
            // 
            // txtSMSID
            // 
            this.txtSMSID.AcceptsReturn = true;
            this.txtSMSID.BackColor = System.Drawing.SystemColors.Window;
            this.txtSMSID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSMSID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSMSID.Location = new System.Drawing.Point(64, 29);
            this.txtSMSID.MaxLength = 0;
            this.txtSMSID.Name = "txtSMSID";
            this.txtSMSID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSMSID.Size = new System.Drawing.Size(105, 20);
            this.txtSMSID.TabIndex = 10;
            // 
            // lblEnrollNoSMS
            // 
            this.lblEnrollNoSMS.BackColor = System.Drawing.SystemColors.Control;
            this.lblEnrollNoSMS.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEnrollNoSMS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnrollNoSMS.Location = new System.Drawing.Point(9, 136);
            this.lblEnrollNoSMS.Name = "lblEnrollNoSMS";
            this.lblEnrollNoSMS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEnrollNoSMS.Size = new System.Drawing.Size(62, 17);
            this.lblEnrollNoSMS.TabIndex = 18;
            this.lblEnrollNoSMS.Text = "Enroll No:";
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.SystemColors.Control;
            this.lblType.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblType.Location = new System.Drawing.Point(9, 104);
            this.lblType.Name = "lblType";
            this.lblType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblType.Size = new System.Drawing.Size(33, 17);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "Type:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.BackColor = System.Drawing.SystemColors.Control;
            this.lblStartTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStartTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStartTime.Location = new System.Drawing.Point(200, 56);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStartTime.Size = new System.Drawing.Size(75, 17);
            this.lblStartTime.TabIndex = 14;
            this.lblStartTime.Text = "Start Time:";
            // 
            // lblValidMinutes
            // 
            this.lblValidMinutes.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidMinutes.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblValidMinutes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblValidMinutes.Location = new System.Drawing.Point(200, 32);
            this.lblValidMinutes.Name = "lblValidMinutes";
            this.lblValidMinutes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblValidMinutes.Size = new System.Drawing.Size(83, 17);
            this.lblValidMinutes.TabIndex = 12;
            this.lblValidMinutes.Text = "Valid Minutes:";
            // 
            // lblContent
            // 
            this.lblContent.BackColor = System.Drawing.SystemColors.Control;
            this.lblContent.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblContent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblContent.Location = new System.Drawing.Point(9, 56);
            this.lblContent.Name = "lblContent";
            this.lblContent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblContent.Size = new System.Drawing.Size(59, 17);
            this.lblContent.TabIndex = 9;
            this.lblContent.Text = "Content :";
            // 
            // lblSMSID
            // 
            this.lblSMSID.BackColor = System.Drawing.SystemColors.Control;
            this.lblSMSID.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSMSID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSMSID.Location = new System.Drawing.Point(9, 32);
            this.lblSMSID.Name = "lblSMSID";
            this.lblSMSID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSMSID.Size = new System.Drawing.Size(56, 17);
            this.lblSMSID.TabIndex = 8;
            this.lblSMSID.Text = "SMS ID :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnSetUserVerType);
            this.groupBox1.Controls.Add(this.btnGetUserVerType);
            this.groupBox1.Controls.Add(this.txtVerType);
            this.groupBox1.Controls.Add(this.txtEnrollNoVerType);
            this.groupBox1.Controls.Add(this.lblVerType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(842, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Verify Type";
            // 
            // btnSetUserVerType
            // 
            this.btnSetUserVerType.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetUserVerType.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSetUserVerType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetUserVerType.Location = new System.Drawing.Point(192, 39);
            this.btnSetUserVerType.Name = "btnSetUserVerType";
            this.btnSetUserVerType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSetUserVerType.Size = new System.Drawing.Size(145, 25);
            this.btnSetUserVerType.TabIndex = 6;
            this.btnSetUserVerType.Text = "Set User Ver Type";
            this.btnSetUserVerType.UseVisualStyleBackColor = false;
            this.btnSetUserVerType.Click += new System.EventHandler(this.btnSetUserVerType_Click);
            // 
            // btnGetUserVerType
            // 
            this.btnGetUserVerType.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetUserVerType.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGetUserVerType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetUserVerType.Location = new System.Drawing.Point(192, 13);
            this.btnGetUserVerType.Name = "btnGetUserVerType";
            this.btnGetUserVerType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetUserVerType.Size = new System.Drawing.Size(145, 25);
            this.btnGetUserVerType.TabIndex = 5;
            this.btnGetUserVerType.Text = "Get User Ver Type";
            this.btnGetUserVerType.UseVisualStyleBackColor = false;
            this.btnGetUserVerType.Click += new System.EventHandler(this.btnGetUserVerType_Click);
            // 
            // txtVerType
            // 
            this.txtVerType.AcceptsReturn = true;
            this.txtVerType.BackColor = System.Drawing.SystemColors.Window;
            this.txtVerType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVerType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVerType.Location = new System.Drawing.Point(88, 40);
            this.txtVerType.MaxLength = 0;
            this.txtVerType.Name = "txtVerType";
            this.txtVerType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVerType.Size = new System.Drawing.Size(97, 20);
            this.txtVerType.TabIndex = 4;
            // 
            // txtEnrollNoVerType
            // 
            this.txtEnrollNoVerType.AcceptsReturn = true;
            this.txtEnrollNoVerType.BackColor = System.Drawing.SystemColors.Window;
            this.txtEnrollNoVerType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnrollNoVerType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEnrollNoVerType.Location = new System.Drawing.Point(88, 16);
            this.txtEnrollNoVerType.MaxLength = 0;
            this.txtEnrollNoVerType.Name = "txtEnrollNoVerType";
            this.txtEnrollNoVerType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEnrollNoVerType.Size = new System.Drawing.Size(97, 20);
            this.txtEnrollNoVerType.TabIndex = 3;
            // 
            // lblVerType
            // 
            this.lblVerType.BackColor = System.Drawing.SystemColors.Control;
            this.lblVerType.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblVerType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVerType.Location = new System.Drawing.Point(16, 48);
            this.lblVerType.Name = "lblVerType";
            this.lblVerType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVerType.Size = new System.Drawing.Size(73, 17);
            this.lblVerType.TabIndex = 2;
            this.lblVerType.Text = "Ver Type :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enroll No :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(851, 685);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Color Screen Models Functions Demo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.btnListBox1Clear);
            this.groupBox5.Controls.Add(this.btnDelUserFace);
            this.groupBox5.Controls.Add(this.btnSetUserFace);
            this.groupBox5.Controls.Add(this.btnGetUserFace);
            this.groupBox5.Controls.Add(this.btnSetFaceData);
            this.groupBox5.Controls.Add(this.btnGetFaceData);
            this.groupBox5.Controls.Add(this.btnSetFP10);
            this.groupBox5.Controls.Add(this.GetFP10);
            this.groupBox5.Controls.Add(this.mmTplT);
            this.groupBox5.Controls.Add(this.edtFingerT);
            this.groupBox5.Controls.Add(this.edtEnrollNoT);
            this.groupBox5.Controls.Add(this.btnSetTemplateFileData);
            this.groupBox5.Controls.Add(this.btnGetTemplateFileData);
            this.groupBox5.Controls.Add(this.edtTZU);
            this.groupBox5.Controls.Add(this.edtTZGU);
            this.groupBox5.Controls.Add(this.edtCardNoU);
            this.groupBox5.Controls.Add(this.edtPriU);
            this.groupBox5.Controls.Add(this.edtPwdU);
            this.groupBox5.Controls.Add(this.edtNameU);
            this.groupBox5.Controls.Add(this.edtEnrollNoU);
            this.groupBox5.Controls.Add(this.btnWriteUserFile);
            this.groupBox5.Controls.Add(this.btnReadUserFile);
            this.groupBox5.Controls.Add(this.edtFile);
            this.groupBox5.Controls.Add(this.edtED);
            this.groupBox5.Controls.Add(this.edtEM);
            this.groupBox5.Controls.Add(this.edtBD);
            this.groupBox5.Controls.Add(this.edtBM);
            this.groupBox5.Controls.Add(this.btnSetHoliday);
            this.groupBox5.Controls.Add(this.btnGetHoliday);
            this.groupBox5.Controls.Add(this.edtTZID);
            this.groupBox5.Controls.Add(this.edtHolID);
            this.groupBox5.Controls.Add(this.btnSetGroupTZ);
            this.groupBox5.Controls.Add(this.btnGetGroupTZ);
            this.groupBox5.Controls.Add(this.edtTZ3);
            this.groupBox5.Controls.Add(this.edtTZ2);
            this.groupBox5.Controls.Add(this.edtTZ1);
            this.groupBox5.Controls.Add(this.edtVerMode);
            this.groupBox5.Controls.Add(this.edtHol);
            this.groupBox5.Controls.Add(this.edtTZGID);
            this.groupBox5.Controls.Add(this.edtG5);
            this.groupBox5.Controls.Add(this.edtG4);
            this.groupBox5.Controls.Add(this.edtG3);
            this.groupBox5.Controls.Add(this.edtG2);
            this.groupBox5.Controls.Add(this.edtG1);
            this.groupBox5.Controls.Add(this.edtComNo);
            this.groupBox5.Controls.Add(this.btnSetUnlockGroup);
            this.groupBox5.Controls.Add(this.btnGetUnlockGroup);
            this.groupBox5.Controls.Add(this.btnClearWC);
            this.groupBox5.Controls.Add(this.btnDeleteWC);
            this.groupBox5.Controls.Add(this.btnSetWC);
            this.groupBox5.Controls.Add(this.btnGetWC);
            this.groupBox5.Controls.Add(this.edtWC);
            this.groupBox5.Controls.Add(this.edtWCID);
            this.groupBox5.Controls.Add(this.edtFinger);
            this.groupBox5.Controls.Add(this.edtPwd);
            this.groupBox5.Controls.Add(this.edtName);
            this.groupBox5.Controls.Add(this.edtEnrollNo);
            this.groupBox5.Controls.Add(this.listBox1);
            this.groupBox5.Controls.Add(this._Frame4_4);
            this.groupBox5.Controls.Add(this.btnFile);
            this.groupBox5.Controls.Add(this._Frame4_3);
            this.groupBox5.Controls.Add(this._Frame4_2);
            this.groupBox5.Controls.Add(this._Frame4_1);
            this.groupBox5.Controls.Add(this._Frame4_0);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.btnDelUserTpl);
            this.groupBox5.Controls.Add(this.btnSetUserTpl);
            this.groupBox5.Controls.Add(this.btnGetUserTpl);
            this.groupBox5.Controls.Add(this.btnSSRDelUserInfo);
            this.groupBox5.Controls.Add(this.btnSSRSetUserInfo);
            this.groupBox5.Controls.Add(this.btnSSRGetUserInfo);
            this.groupBox5.Controls.Add(this.mmTpl);
            this.groupBox5.Controls.Add(this.edtCardNo);
            this.groupBox5.Controls.Add(this.edtValid);
            this.groupBox5.Controls.Add(this.edtPri);
            this.groupBox5.Controls.Add(this._Label1_33);
            this.groupBox5.Controls.Add(this._Label1_32);
            this.groupBox5.Controls.Add(this._Label1_31);
            this.groupBox5.Controls.Add(this._Label1_30);
            this.groupBox5.Controls.Add(this._Label1_29);
            this.groupBox5.Controls.Add(this._Label1_28);
            this.groupBox5.Controls.Add(this._Label1_27);
            this.groupBox5.Controls.Add(this._Label1_26);
            this.groupBox5.Controls.Add(this._Label1_25);
            this.groupBox5.Controls.Add(this._Label1_24);
            this.groupBox5.Controls.Add(this._Label1_23);
            this.groupBox5.Controls.Add(this._Label1_22);
            this.groupBox5.Controls.Add(this._Label1_21);
            this.groupBox5.Controls.Add(this._Label1_20);
            this.groupBox5.Controls.Add(this._Label1_19);
            this.groupBox5.Controls.Add(this._Label1_18);
            this.groupBox5.Controls.Add(this._Label1_17);
            this.groupBox5.Controls.Add(this._Label1_16);
            this.groupBox5.Controls.Add(this._Label1_15);
            this.groupBox5.Controls.Add(this._Label1_14);
            this.groupBox5.Controls.Add(this._Label1_13);
            this.groupBox5.Controls.Add(this._Label1_12);
            this.groupBox5.Controls.Add(this._Label1_11);
            this.groupBox5.Controls.Add(this._Label1_10);
            this.groupBox5.Controls.Add(this._Label1_9);
            this.groupBox5.Controls.Add(this.lblWordCode);
            this.groupBox5.Controls.Add(this.lblTemplate);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.lblValid);
            this.groupBox5.Controls.Add(this.lblPriviledge);
            this.groupBox5.Controls.Add(this.lblFinger);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox5.Location = new System.Drawing.Point(0, 45);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(851, 640);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // btnListBox1Clear
            // 
            this.btnListBox1Clear.Location = new System.Drawing.Point(382, 368);
            this.btnListBox1Clear.Name = "btnListBox1Clear";
            this.btnListBox1Clear.Size = new System.Drawing.Size(75, 23);
            this.btnListBox1Clear.TabIndex = 112;
            this.btnListBox1Clear.Text = "Clear";
            this.btnListBox1Clear.UseVisualStyleBackColor = true;
            this.btnListBox1Clear.Click += new System.EventHandler(this.btnListBox1Clear_Click);
            // 
            // btnDelUserFace
            // 
            this.btnDelUserFace.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelUserFace.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelUserFace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelUserFace.Location = new System.Drawing.Point(352, 224);
            this.btnDelUserFace.Name = "btnDelUserFace";
            this.btnDelUserFace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelUserFace.Size = new System.Drawing.Size(105, 25);
            this.btnDelUserFace.TabIndex = 111;
            this.btnDelUserFace.Text = "DelUserFace";
            this.btnDelUserFace.UseVisualStyleBackColor = false;
            this.btnDelUserFace.Click += new System.EventHandler(this.btnDelUserFace_Click);
            // 
            // btnSetUserFace
            // 
            this.btnSetUserFace.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetUserFace.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSetUserFace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetUserFace.Location = new System.Drawing.Point(352, 200);
            this.btnSetUserFace.Name = "btnSetUserFace";
            this.btnSetUserFace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSetUserFace.Size = new System.Drawing.Size(105, 25);
            this.btnSetUserFace.TabIndex = 110;
            this.btnSetUserFace.Text = "SetUserFace";
            this.btnSetUserFace.UseVisualStyleBackColor = false;
            this.btnSetUserFace.Click += new System.EventHandler(this.btnSetUserFace_Click);
            // 
            // btnGetUserFace
            // 
            this.btnGetUserFace.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetUserFace.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGetUserFace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetUserFace.Location = new System.Drawing.Point(352, 176);
            this.btnGetUserFace.Name = "btnGetUserFace";
            this.btnGetUserFace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetUserFace.Size = new System.Drawing.Size(105, 25);
            this.btnGetUserFace.TabIndex = 109;
            this.btnGetUserFace.Text = "GetUserFace";
            this.btnGetUserFace.UseVisualStyleBackColor = false;
            this.btnGetUserFace.Click += new System.EventHandler(this.btnGetUserFace_Click);
            // 
            // btnSetFaceData
            // 
            this.btnSetFaceData.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetFaceData.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSetFaceData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetFaceData.Location = new System.Drawing.Point(738, 536);
            this.btnSetFaceData.Name = "btnSetFaceData";
            this.btnSetFaceData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSetFaceData.Size = new System.Drawing.Size(113, 25);
            this.btnSetFaceData.TabIndex = 108;
            this.btnSetFaceData.Text = "SetFaceTplData";
            this.btnSetFaceData.UseVisualStyleBackColor = false;
            this.btnSetFaceData.Click += new System.EventHandler(this.btnSetFaceData_Click);
            // 
            // btnGetFaceData
            // 
            this.btnGetFaceData.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetFaceData.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGetFaceData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetFaceData.Location = new System.Drawing.Point(618, 536);
            this.btnGetFaceData.Name = "btnGetFaceData";
            this.btnGetFaceData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetFaceData.Size = new System.Drawing.Size(121, 25);
            this.btnGetFaceData.TabIndex = 107;
            this.btnGetFaceData.Text = "GetFaceTplData";
            this.btnGetFaceData.UseVisualStyleBackColor = false;
            this.btnGetFaceData.Click += new System.EventHandler(this.btnGetFaceData_Click);
            // 
            // btnSetFP10
            // 
            this.btnSetFP10.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetFP10.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSetFP10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetFP10.Location = new System.Drawing.Point(738, 507);
            this.btnSetFP10.Name = "btnSetFP10";
            this.btnSetFP10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSetFP10.Size = new System.Drawing.Size(113, 25);
            this.btnSetFP10.TabIndex = 106;
            this.btnSetFP10.Text = "SetFP10FileData";
            this.btnSetFP10.UseVisualStyleBackColor = false;
            this.btnSetFP10.Click += new System.EventHandler(this.btnSetFP10_Click);
            // 
            // GetFP10
            // 
            this.GetFP10.BackColor = System.Drawing.SystemColors.Control;
            this.GetFP10.Cursor = System.Windows.Forms.Cursors.Default;
            this.GetFP10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GetFP10.Location = new System.Drawing.Point(738, 479);
            this.GetFP10.Name = "GetFP10";
            this.GetFP10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GetFP10.Size = new System.Drawing.Size(113, 25);
            this.GetFP10.TabIndex = 105;
            this.GetFP10.Text = "GetFP10FileData";
            this.GetFP10.UseVisualStyleBackColor = false;
            this.GetFP10.Click += new System.EventHandler(this.GetFP10_Click);
            // 
            // mmTplT
            // 
            this.mmTplT.AcceptsReturn = true;
            this.mmTplT.BackColor = System.Drawing.SystemColors.Window;
            this.mmTplT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mmTplT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mmTplT.Location = new System.Drawing.Point(528, 568);
            this.mmTplT.MaxLength = 0;
            this.mmTplT.Multiline = true;
            this.mmTplT.Name = "mmTplT";
            this.mmTplT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmTplT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mmTplT.Size = new System.Drawing.Size(321, 51);
            this.mmTplT.TabIndex = 104;
            // 
            // edtFingerT
            // 
            this.edtFingerT.AcceptsReturn = true;
            this.edtFingerT.BackColor = System.Drawing.SystemColors.Window;
            this.edtFingerT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtFingerT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtFingerT.Location = new System.Drawing.Point(526, 504);
            this.edtFingerT.MaxLength = 0;
            this.edtFingerT.Name = "edtFingerT";
            this.edtFingerT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtFingerT.Size = new System.Drawing.Size(57, 20);
            this.edtFingerT.TabIndex = 103;
            this.edtFingerT.Text = "0";
            // 
            // edtEnrollNoT
            // 
            this.edtEnrollNoT.AcceptsReturn = true;
            this.edtEnrollNoT.BackColor = System.Drawing.SystemColors.Window;
            this.edtEnrollNoT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtEnrollNoT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtEnrollNoT.Location = new System.Drawing.Point(526, 480);
            this.edtEnrollNoT.MaxLength = 0;
            this.edtEnrollNoT.Name = "edtEnrollNoT";
            this.edtEnrollNoT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtEnrollNoT.Size = new System.Drawing.Size(90, 20);
            this.edtEnrollNoT.TabIndex = 102;
            // 
            // btnSetTemplateFileData
            // 
            this.btnSetTemplateFileData.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetTemplateFileData.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSetTemplateFileData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetTemplateFileData.Location = new System.Drawing.Point(618, 507);
            this.btnSetTemplateFileData.Name = "btnSetTemplateFileData";
            this.btnSetTemplateFileData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSetTemplateFileData.Size = new System.Drawing.Size(121, 25);
            this.btnSetTemplateFileData.TabIndex = 101;
            this.btnSetTemplateFileData.Text = "SetTemplateFileData";
            this.btnSetTemplateFileData.UseVisualStyleBackColor = false;
            this.btnSetTemplateFileData.Click += new System.EventHandler(this.btnSetTemplateFileData_Click);
            // 
            // btnGetTemplateFileData
            // 
            this.btnGetTemplateFileData.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetTemplateFileData.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGetTemplateFileData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetTemplateFileData.Location = new System.Drawing.Point(618, 479);
            this.btnGetTemplateFileData.Name = "btnGetTemplateFileData";
            this.btnGetTemplateFileData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetTemplateFileData.Size = new System.Drawing.Size(121, 25);
            this.btnGetTemplateFileData.TabIndex = 100;
            this.btnGetTemplateFileData.Text = "GetTemplateFileData";
            this.btnGetTemplateFileData.UseVisualStyleBackColor = false;
            this.btnGetTemplateFileData.Click += new System.EventHandler(this.btnGetTemplateFileData_Click);
            // 
            // edtTZU
            // 
            this.edtTZU.AcceptsReturn = true;
            this.edtTZU.BackColor = System.Drawing.SystemColors.Window;
            this.edtTZU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtTZU.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtTZU.Location = new System.Drawing.Point(544, 440);
            this.edtTZU.MaxLength = 0;
            this.edtTZU.Name = "edtTZU";
            this.edtTZU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtTZU.Size = new System.Drawing.Size(305, 20);
            this.edtTZU.TabIndex = 99;
            // 
            // edtTZGU
            // 
            this.edtTZGU.AcceptsReturn = true;
            this.edtTZGU.BackColor = System.Drawing.SystemColors.Window;
            this.edtTZGU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtTZGU.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtTZGU.Location = new System.Drawing.Point(544, 416);
            this.edtTZGU.MaxLength = 0;
            this.edtTZGU.Name = "edtTZGU";
            this.edtTZGU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtTZGU.Size = new System.Drawing.Size(41, 20);
            this.edtTZGU.TabIndex = 98;
            // 
            // edtCardNoU
            // 
            this.edtCardNoU.AcceptsReturn = true;
            this.edtCardNoU.BackColor = System.Drawing.SystemColors.Window;
            this.edtCardNoU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtCardNoU.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtCardNoU.Location = new System.Drawing.Point(744, 392);
            this.edtCardNoU.MaxLength = 0;
            this.edtCardNoU.Name = "edtCardNoU";
            this.edtCardNoU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtCardNoU.Size = new System.Drawing.Size(105, 20);
            this.edtCardNoU.TabIndex = 97;
            this.edtCardNoU.Text = "0";
            // 
            // edtPriU
            // 
            this.edtPriU.AcceptsReturn = true;
            this.edtPriU.BackColor = System.Drawing.SystemColors.Window;
            this.edtPriU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtPriU.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtPriU.Location = new System.Drawing.Point(544, 392);
            this.edtPriU.MaxLength = 0;
            this.edtPriU.Name = "edtPriU";
            this.edtPriU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtPriU.Size = new System.Drawing.Size(41, 20);
            this.edtPriU.TabIndex = 96;
            this.edtPriU.Text = "0";
            // 
            // edtPwdU
            // 
            this.edtPwdU.AcceptsReturn = true;
            this.edtPwdU.BackColor = System.Drawing.SystemColors.Window;
            this.edtPwdU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtPwdU.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtPwdU.Location = new System.Drawing.Point(544, 368);
            this.edtPwdU.MaxLength = 0;
            this.edtPwdU.Name = "edtPwdU";
            this.edtPwdU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtPwdU.Size = new System.Drawing.Size(105, 20);
            this.edtPwdU.TabIndex = 95;
            // 
            // edtNameU
            // 
            this.edtNameU.AcceptsReturn = true;
            this.edtNameU.BackColor = System.Drawing.SystemColors.Window;
            this.edtNameU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtNameU.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtNameU.Location = new System.Drawing.Point(544, 344);
            this.edtNameU.MaxLength = 0;
            this.edtNameU.Name = "edtNameU";
            this.edtNameU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtNameU.Size = new System.Drawing.Size(105, 20);
            this.edtNameU.TabIndex = 94;
            // 
            // edtEnrollNoU
            // 
            this.edtEnrollNoU.AcceptsReturn = true;
            this.edtEnrollNoU.BackColor = System.Drawing.SystemColors.Window;
            this.edtEnrollNoU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtEnrollNoU.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtEnrollNoU.Location = new System.Drawing.Point(544, 320);
            this.edtEnrollNoU.MaxLength = 0;
            this.edtEnrollNoU.Name = "edtEnrollNoU";
            this.edtEnrollNoU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtEnrollNoU.Size = new System.Drawing.Size(105, 20);
            this.edtEnrollNoU.TabIndex = 93;
            // 
            // btnWriteUserFile
            // 
            this.btnWriteUserFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnWriteUserFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnWriteUserFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWriteUserFile.Location = new System.Drawing.Point(720, 352);
            this.btnWriteUserFile.Name = "btnWriteUserFile";
            this.btnWriteUserFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnWriteUserFile.Size = new System.Drawing.Size(129, 25);
            this.btnWriteUserFile.TabIndex = 92;
            this.btnWriteUserFile.Text = "SSR_WriteUserFile";
            this.btnWriteUserFile.UseVisualStyleBackColor = false;
            this.btnWriteUserFile.Click += new System.EventHandler(this.btnWriteUserFile_Click);
            // 
            // btnReadUserFile
            // 
            this.btnReadUserFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnReadUserFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReadUserFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReadUserFile.Location = new System.Drawing.Point(720, 328);
            this.btnReadUserFile.Name = "btnReadUserFile";
            this.btnReadUserFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReadUserFile.Size = new System.Drawing.Size(129, 25);
            this.btnReadUserFile.TabIndex = 91;
            this.btnReadUserFile.Text = "SSR_ReadUserFile";
            this.btnReadUserFile.UseVisualStyleBackColor = false;
            this.btnReadUserFile.Click += new System.EventHandler(this.btnReadUserFile_Click);
            // 
            // edtFile
            // 
            this.edtFile.AcceptsReturn = true;
            this.edtFile.BackColor = System.Drawing.SystemColors.Window;
            this.edtFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtFile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtFile.Location = new System.Drawing.Point(504, 288);
            this.edtFile.MaxLength = 0;
            this.edtFile.Name = "edtFile";
            this.edtFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtFile.Size = new System.Drawing.Size(313, 20);
            this.edtFile.TabIndex = 90;
            // 
            // edtED
            // 
            this.edtED.AcceptsReturn = true;
            this.edtED.BackColor = System.Drawing.SystemColors.Window;
            this.edtED.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtED.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtED.Location = new System.Drawing.Point(679, 240);
            this.edtED.MaxLength = 0;
            this.edtED.Name = "edtED";
            this.edtED.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtED.Size = new System.Drawing.Size(42, 20);
            this.edtED.TabIndex = 89;
            this.edtED.Text = "30";
            // 
            // edtEM
            // 
            this.edtEM.AcceptsReturn = true;
            this.edtEM.BackColor = System.Drawing.SystemColors.Window;
            this.edtEM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtEM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtEM.Location = new System.Drawing.Point(679, 216);
            this.edtEM.MaxLength = 0;
            this.edtEM.Name = "edtEM";
            this.edtEM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtEM.Size = new System.Drawing.Size(42, 20);
            this.edtEM.TabIndex = 88;
            this.edtEM.Text = "1";
            // 
            // edtBD
            // 
            this.edtBD.AcceptsReturn = true;
            this.edtBD.BackColor = System.Drawing.SystemColors.Window;
            this.edtBD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtBD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtBD.Location = new System.Drawing.Point(551, 240);
            this.edtBD.MaxLength = 0;
            this.edtBD.Name = "edtBD";
            this.edtBD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtBD.Size = new System.Drawing.Size(42, 20);
            this.edtBD.TabIndex = 87;
            this.edtBD.Text = "1";
            // 
            // edtBM
            // 
            this.edtBM.AcceptsReturn = true;
            this.edtBM.BackColor = System.Drawing.SystemColors.Window;
            this.edtBM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtBM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtBM.Location = new System.Drawing.Point(551, 216);
            this.edtBM.MaxLength = 0;
            this.edtBM.Name = "edtBM";
            this.edtBM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtBM.Size = new System.Drawing.Size(42, 20);
            this.edtBM.TabIndex = 86;
            this.edtBM.Text = "1";
            // 
            // btnSetHoliday
            // 
            this.btnSetHoliday.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetHoliday.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSetHoliday.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetHoliday.Location = new System.Drawing.Point(744, 216);
            this.btnSetHoliday.Name = "btnSetHoliday";
            this.btnSetHoliday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSetHoliday.Size = new System.Drawing.Size(105, 25);
            this.btnSetHoliday.TabIndex = 85;
            this.btnSetHoliday.Text = "SSR_SetHoliday";
            this.btnSetHoliday.UseVisualStyleBackColor = false;
            this.btnSetHoliday.Click += new System.EventHandler(this.btnSetHoliday_Click);
            // 
            // btnGetHoliday
            // 
            this.btnGetHoliday.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetHoliday.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGetHoliday.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetHoliday.Location = new System.Drawing.Point(744, 192);
            this.btnGetHoliday.Name = "btnGetHoliday";
            this.btnGetHoliday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetHoliday.Size = new System.Drawing.Size(105, 25);
            this.btnGetHoliday.TabIndex = 84;
            this.btnGetHoliday.Text = "SSR_GetHoliday";
            this.btnGetHoliday.UseVisualStyleBackColor = false;
            this.btnGetHoliday.Click += new System.EventHandler(this.btnGetHoliday_Click);
            // 
            // edtTZID
            // 
            this.edtTZID.AcceptsReturn = true;
            this.edtTZID.BackColor = System.Drawing.SystemColors.Window;
            this.edtTZID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtTZID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtTZID.Location = new System.Drawing.Point(679, 192);
            this.edtTZID.MaxLength = 0;
            this.edtTZID.Name = "edtTZID";
            this.edtTZID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtTZID.Size = new System.Drawing.Size(42, 20);
            this.edtTZID.TabIndex = 83;
            this.edtTZID.Text = "1";
            // 
            // edtHolID
            // 
            this.edtHolID.AcceptsReturn = true;
            this.edtHolID.BackColor = System.Drawing.SystemColors.Window;
            this.edtHolID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtHolID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtHolID.Location = new System.Drawing.Point(551, 192);
            this.edtHolID.MaxLength = 0;
            this.edtHolID.Name = "edtHolID";
            this.edtHolID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtHolID.Size = new System.Drawing.Size(42, 20);
            this.edtHolID.TabIndex = 82;
            this.edtHolID.Text = "1";
            // 
            // btnSetGroupTZ
            // 
            this.btnSetGroupTZ.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetGroupTZ.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSetGroupTZ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetGroupTZ.Location = new System.Drawing.Point(720, 112);
            this.btnSetGroupTZ.Name = "btnSetGroupTZ";
            this.btnSetGroupTZ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSetGroupTZ.Size = new System.Drawing.Size(129, 25);
            this.btnSetGroupTZ.TabIndex = 81;
            this.btnSetGroupTZ.Text = "SSR_SetGroupTZ";
            this.btnSetGroupTZ.UseVisualStyleBackColor = false;
            this.btnSetGroupTZ.Click += new System.EventHandler(this.btnSetGroupTZ_Click);
            // 
            // btnGetGroupTZ
            // 
            this.btnGetGroupTZ.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetGroupTZ.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGetGroupTZ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetGroupTZ.Location = new System.Drawing.Point(720, 88);
            this.btnGetGroupTZ.Name = "btnGetGroupTZ";
            this.btnGetGroupTZ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetGroupTZ.Size = new System.Drawing.Size(129, 25);
            this.btnGetGroupTZ.TabIndex = 80;
            this.btnGetGroupTZ.Text = "SSR_GetGroupTZ";
            this.btnGetGroupTZ.UseVisualStyleBackColor = false;
            this.btnGetGroupTZ.Click += new System.EventHandler(this.btnGetGroupTZ_Click);
            // 
            // edtTZ3
            // 
            this.edtTZ3.AcceptsReturn = true;
            this.edtTZ3.BackColor = System.Drawing.SystemColors.Window;
            this.edtTZ3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtTZ3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtTZ3.Location = new System.Drawing.Point(640, 136);
            this.edtTZ3.MaxLength = 0;
            this.edtTZ3.Name = "edtTZ3";
            this.edtTZ3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtTZ3.Size = new System.Drawing.Size(57, 20);
            this.edtTZ3.TabIndex = 79;
            this.edtTZ3.Text = "0";
            // 
            // edtTZ2
            // 
            this.edtTZ2.AcceptsReturn = true;
            this.edtTZ2.BackColor = System.Drawing.SystemColors.Window;
            this.edtTZ2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtTZ2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtTZ2.Location = new System.Drawing.Point(640, 112);
            this.edtTZ2.MaxLength = 0;
            this.edtTZ2.Name = "edtTZ2";
            this.edtTZ2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtTZ2.Size = new System.Drawing.Size(57, 20);
            this.edtTZ2.TabIndex = 78;
            this.edtTZ2.Text = "0";
            // 
            // edtTZ1
            // 
            this.edtTZ1.AcceptsReturn = true;
            this.edtTZ1.BackColor = System.Drawing.SystemColors.Window;
            this.edtTZ1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtTZ1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtTZ1.Location = new System.Drawing.Point(640, 88);
            this.edtTZ1.MaxLength = 0;
            this.edtTZ1.Name = "edtTZ1";
            this.edtTZ1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtTZ1.Size = new System.Drawing.Size(57, 20);
            this.edtTZ1.TabIndex = 77;
            this.edtTZ1.Text = "0";
            // 
            // edtVerMode
            // 
            this.edtVerMode.AcceptsReturn = true;
            this.edtVerMode.BackColor = System.Drawing.SystemColors.Window;
            this.edtVerMode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtVerMode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtVerMode.Location = new System.Drawing.Point(544, 136);
            this.edtVerMode.MaxLength = 0;
            this.edtVerMode.Name = "edtVerMode";
            this.edtVerMode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtVerMode.Size = new System.Drawing.Size(57, 20);
            this.edtVerMode.TabIndex = 76;
            this.edtVerMode.Text = "1";
            // 
            // edtHol
            // 
            this.edtHol.AcceptsReturn = true;
            this.edtHol.BackColor = System.Drawing.SystemColors.Window;
            this.edtHol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtHol.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtHol.Location = new System.Drawing.Point(544, 112);
            this.edtHol.MaxLength = 0;
            this.edtHol.Name = "edtHol";
            this.edtHol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtHol.Size = new System.Drawing.Size(57, 20);
            this.edtHol.TabIndex = 75;
            this.edtHol.Text = "1";
            // 
            // edtTZGID
            // 
            this.edtTZGID.AcceptsReturn = true;
            this.edtTZGID.BackColor = System.Drawing.SystemColors.Window;
            this.edtTZGID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtTZGID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtTZGID.Location = new System.Drawing.Point(544, 88);
            this.edtTZGID.MaxLength = 0;
            this.edtTZGID.Name = "edtTZGID";
            this.edtTZGID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtTZGID.Size = new System.Drawing.Size(57, 20);
            this.edtTZGID.TabIndex = 74;
            this.edtTZGID.Text = "1";
            // 
            // edtG5
            // 
            this.edtG5.AcceptsReturn = true;
            this.edtG5.BackColor = System.Drawing.SystemColors.Window;
            this.edtG5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtG5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtG5.Location = new System.Drawing.Point(656, 40);
            this.edtG5.MaxLength = 0;
            this.edtG5.Name = "edtG5";
            this.edtG5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtG5.Size = new System.Drawing.Size(33, 20);
            this.edtG5.TabIndex = 73;
            this.edtG5.Text = "0";
            // 
            // edtG4
            // 
            this.edtG4.AcceptsReturn = true;
            this.edtG4.BackColor = System.Drawing.SystemColors.Window;
            this.edtG4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtG4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtG4.Location = new System.Drawing.Point(624, 40);
            this.edtG4.MaxLength = 0;
            this.edtG4.Name = "edtG4";
            this.edtG4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtG4.Size = new System.Drawing.Size(33, 20);
            this.edtG4.TabIndex = 72;
            this.edtG4.Text = "0";
            // 
            // edtG3
            // 
            this.edtG3.AcceptsReturn = true;
            this.edtG3.BackColor = System.Drawing.SystemColors.Window;
            this.edtG3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtG3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtG3.Location = new System.Drawing.Point(592, 40);
            this.edtG3.MaxLength = 0;
            this.edtG3.Name = "edtG3";
            this.edtG3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtG3.Size = new System.Drawing.Size(33, 20);
            this.edtG3.TabIndex = 71;
            this.edtG3.Text = "0";
            // 
            // edtG2
            // 
            this.edtG2.AcceptsReturn = true;
            this.edtG2.BackColor = System.Drawing.SystemColors.Window;
            this.edtG2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtG2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtG2.Location = new System.Drawing.Point(560, 40);
            this.edtG2.MaxLength = 0;
            this.edtG2.Name = "edtG2";
            this.edtG2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtG2.Size = new System.Drawing.Size(33, 20);
            this.edtG2.TabIndex = 70;
            this.edtG2.Text = "0";
            // 
            // edtG1
            // 
            this.edtG1.AcceptsReturn = true;
            this.edtG1.BackColor = System.Drawing.SystemColors.Window;
            this.edtG1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtG1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtG1.Location = new System.Drawing.Point(528, 40);
            this.edtG1.MaxLength = 0;
            this.edtG1.Name = "edtG1";
            this.edtG1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtG1.Size = new System.Drawing.Size(33, 20);
            this.edtG1.TabIndex = 69;
            this.edtG1.Text = "0";
            // 
            // edtComNo
            // 
            this.edtComNo.AcceptsReturn = true;
            this.edtComNo.BackColor = System.Drawing.SystemColors.Window;
            this.edtComNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtComNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtComNo.Location = new System.Drawing.Point(528, 16);
            this.edtComNo.MaxLength = 0;
            this.edtComNo.Name = "edtComNo";
            this.edtComNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtComNo.Size = new System.Drawing.Size(65, 20);
            this.edtComNo.TabIndex = 68;
            this.edtComNo.Text = "1";
            // 
            // btnSetUnlockGroup
            // 
            this.btnSetUnlockGroup.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetUnlockGroup.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSetUnlockGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetUnlockGroup.Location = new System.Drawing.Point(712, 40);
            this.btnSetUnlockGroup.Name = "btnSetUnlockGroup";
            this.btnSetUnlockGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSetUnlockGroup.Size = new System.Drawing.Size(137, 25);
            this.btnSetUnlockGroup.TabIndex = 67;
            this.btnSetUnlockGroup.Text = "SSR_SetUnlockGroup";
            this.btnSetUnlockGroup.UseVisualStyleBackColor = false;
            this.btnSetUnlockGroup.Click += new System.EventHandler(this.btnSetUnlockGroup_Click);
            // 
            // btnGetUnlockGroup
            // 
            this.btnGetUnlockGroup.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetUnlockGroup.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGetUnlockGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetUnlockGroup.Location = new System.Drawing.Point(712, 16);
            this.btnGetUnlockGroup.Name = "btnGetUnlockGroup";
            this.btnGetUnlockGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetUnlockGroup.Size = new System.Drawing.Size(137, 25);
            this.btnGetUnlockGroup.TabIndex = 66;
            this.btnGetUnlockGroup.Text = "SSR_GetUnlockGroup";
            this.btnGetUnlockGroup.UseVisualStyleBackColor = false;
            this.btnGetUnlockGroup.Click += new System.EventHandler(this.btnGetUnlockGroup_Click);
            // 
            // btnClearWC
            // 
            this.btnClearWC.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearWC.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClearWC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearWC.Location = new System.Drawing.Point(323, 336);
            this.btnClearWC.Name = "btnClearWC";
            this.btnClearWC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClearWC.Size = new System.Drawing.Size(134, 25);
            this.btnClearWC.TabIndex = 65;
            this.btnClearWC.Text = "SSR_ClearWorkCode";
            this.btnClearWC.UseVisualStyleBackColor = false;
            this.btnClearWC.Click += new System.EventHandler(this.btnClearWC_Click);
            // 
            // btnDeleteWC
            // 
            this.btnDeleteWC.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteWC.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteWC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteWC.Location = new System.Drawing.Point(323, 312);
            this.btnDeleteWC.Name = "btnDeleteWC";
            this.btnDeleteWC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteWC.Size = new System.Drawing.Size(134, 25);
            this.btnDeleteWC.TabIndex = 64;
            this.btnDeleteWC.Text = "SSR_DeleteWorkCode";
            this.btnDeleteWC.UseVisualStyleBackColor = false;
            this.btnDeleteWC.Click += new System.EventHandler(this.btnDeleteWC_Click);
            // 
            // btnSetWC
            // 
            this.btnSetWC.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetWC.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSetWC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetWC.Location = new System.Drawing.Point(323, 288);
            this.btnSetWC.Name = "btnSetWC";
            this.btnSetWC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSetWC.Size = new System.Drawing.Size(134, 25);
            this.btnSetWC.TabIndex = 63;
            this.btnSetWC.Text = "SSR_SetWorkCode";
            this.btnSetWC.UseVisualStyleBackColor = false;
            this.btnSetWC.Click += new System.EventHandler(this.btnSetWC_Click);
            // 
            // btnGetWC
            // 
            this.btnGetWC.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetWC.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGetWC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetWC.Location = new System.Drawing.Point(323, 264);
            this.btnGetWC.Name = "btnGetWC";
            this.btnGetWC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetWC.Size = new System.Drawing.Size(134, 25);
            this.btnGetWC.TabIndex = 62;
            this.btnGetWC.Text = "SSR_GetWorkCode";
            this.btnGetWC.UseVisualStyleBackColor = false;
            this.btnGetWC.Click += new System.EventHandler(this.btnGetWC_Click);
            // 
            // edtWC
            // 
            this.edtWC.AcceptsReturn = true;
            this.edtWC.BackColor = System.Drawing.SystemColors.Window;
            this.edtWC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtWC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtWC.Location = new System.Drawing.Point(72, 296);
            this.edtWC.MaxLength = 0;
            this.edtWC.Multiline = true;
            this.edtWC.Name = "edtWC";
            this.edtWC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtWC.Size = new System.Drawing.Size(249, 65);
            this.edtWC.TabIndex = 61;
            // 
            // edtWCID
            // 
            this.edtWCID.AcceptsReturn = true;
            this.edtWCID.BackColor = System.Drawing.SystemColors.Window;
            this.edtWCID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtWCID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtWCID.Location = new System.Drawing.Point(72, 264);
            this.edtWCID.MaxLength = 0;
            this.edtWCID.Name = "edtWCID";
            this.edtWCID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtWCID.Size = new System.Drawing.Size(57, 20);
            this.edtWCID.TabIndex = 60;
            // 
            // edtFinger
            // 
            this.edtFinger.AcceptsReturn = true;
            this.edtFinger.BackColor = System.Drawing.SystemColors.Window;
            this.edtFinger.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtFinger.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtFinger.Location = new System.Drawing.Point(72, 88);
            this.edtFinger.MaxLength = 0;
            this.edtFinger.Name = "edtFinger";
            this.edtFinger.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtFinger.Size = new System.Drawing.Size(57, 20);
            this.edtFinger.TabIndex = 55;
            this.edtFinger.Text = "0";
            // 
            // edtPwd
            // 
            this.edtPwd.AcceptsReturn = true;
            this.edtPwd.BackColor = System.Drawing.SystemColors.Window;
            this.edtPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtPwd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtPwd.Location = new System.Drawing.Point(72, 64);
            this.edtPwd.MaxLength = 0;
            this.edtPwd.Name = "edtPwd";
            this.edtPwd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtPwd.Size = new System.Drawing.Size(105, 20);
            this.edtPwd.TabIndex = 54;
            // 
            // edtName
            // 
            this.edtName.AcceptsReturn = true;
            this.edtName.BackColor = System.Drawing.SystemColors.Window;
            this.edtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtName.Location = new System.Drawing.Point(72, 40);
            this.edtName.MaxLength = 0;
            this.edtName.Name = "edtName";
            this.edtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtName.Size = new System.Drawing.Size(105, 20);
            this.edtName.TabIndex = 53;
            // 
            // edtEnrollNo
            // 
            this.edtEnrollNo.AcceptsReturn = true;
            this.edtEnrollNo.BackColor = System.Drawing.SystemColors.Window;
            this.edtEnrollNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtEnrollNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtEnrollNo.Location = new System.Drawing.Point(72, 16);
            this.edtEnrollNo.MaxLength = 0;
            this.edtEnrollNo.Name = "edtEnrollNo";
            this.edtEnrollNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtEnrollNo.Size = new System.Drawing.Size(105, 20);
            this.edtEnrollNo.TabIndex = 52;
            this.edtEnrollNo.Text = "1100";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.listBox1.Location = new System.Drawing.Point(0, 368);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.Size = new System.Drawing.Size(457, 251);
            this.listBox1.TabIndex = 51;
            // 
            // _Frame4_4
            // 
            this._Frame4_4.BackColor = System.Drawing.SystemColors.Control;
            this._Frame4_4.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Frame4_4.Location = new System.Drawing.Point(472, 464);
            this._Frame4_4.Name = "_Frame4_4";
            this._Frame4_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Frame4_4.Size = new System.Drawing.Size(377, 9);
            this._Frame4_4.TabIndex = 47;
            this._Frame4_4.TabStop = false;
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFile.Location = new System.Drawing.Point(824, 288);
            this.btnFile.Name = "btnFile";
            this.btnFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFile.Size = new System.Drawing.Size(25, 25);
            this.btnFile.TabIndex = 39;
            this.btnFile.Text = "...";
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // _Frame4_3
            // 
            this._Frame4_3.BackColor = System.Drawing.SystemColors.Control;
            this._Frame4_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Frame4_3.Location = new System.Drawing.Point(472, 272);
            this._Frame4_3.Name = "_Frame4_3";
            this._Frame4_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Frame4_3.Size = new System.Drawing.Size(377, 9);
            this._Frame4_3.TabIndex = 37;
            this._Frame4_3.TabStop = false;
            // 
            // _Frame4_2
            // 
            this._Frame4_2.BackColor = System.Drawing.SystemColors.Control;
            this._Frame4_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Frame4_2.Location = new System.Drawing.Point(472, 176);
            this._Frame4_2.Name = "_Frame4_2";
            this._Frame4_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Frame4_2.Size = new System.Drawing.Size(377, 9);
            this._Frame4_2.TabIndex = 30;
            this._Frame4_2.TabStop = false;
            // 
            // _Frame4_1
            // 
            this._Frame4_1.BackColor = System.Drawing.SystemColors.Control;
            this._Frame4_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Frame4_1.Location = new System.Drawing.Point(472, 72);
            this._Frame4_1.Name = "_Frame4_1";
            this._Frame4_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Frame4_1.Size = new System.Drawing.Size(377, 9);
            this._Frame4_1.TabIndex = 23;
            this._Frame4_1.TabStop = false;
            // 
            // _Frame4_0
            // 
            this._Frame4_0.BackColor = System.Drawing.SystemColors.Control;
            this._Frame4_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Frame4_0.Location = new System.Drawing.Point(6, 248);
            this._Frame4_0.Name = "_Frame4_0";
            this._Frame4_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Frame4_0.Size = new System.Drawing.Size(457, 9);
            this._Frame4_0.TabIndex = 19;
            this._Frame4_0.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox6.Location = new System.Drawing.Point(464, 8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox6.Size = new System.Drawing.Size(4, 609);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // btnDelUserTpl
            // 
            this.btnDelUserTpl.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelUserTpl.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelUserTpl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelUserTpl.Location = new System.Drawing.Point(352, 144);
            this.btnDelUserTpl.Name = "btnDelUserTpl";
            this.btnDelUserTpl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelUserTpl.Size = new System.Drawing.Size(105, 25);
            this.btnDelUserTpl.TabIndex = 17;
            this.btnDelUserTpl.Text = "SSR_DelUserTpl";
            this.btnDelUserTpl.UseVisualStyleBackColor = false;
            this.btnDelUserTpl.Click += new System.EventHandler(this.btnDelUserTpl_Click);
            // 
            // btnSetUserTpl
            // 
            this.btnSetUserTpl.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetUserTpl.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSetUserTpl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetUserTpl.Location = new System.Drawing.Point(352, 120);
            this.btnSetUserTpl.Name = "btnSetUserTpl";
            this.btnSetUserTpl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSetUserTpl.Size = new System.Drawing.Size(105, 25);
            this.btnSetUserTpl.TabIndex = 16;
            this.btnSetUserTpl.Text = "SSR_SetUserTpl";
            this.btnSetUserTpl.UseVisualStyleBackColor = false;
            this.btnSetUserTpl.Click += new System.EventHandler(this.btnSetUserTpl_Click);
            // 
            // btnGetUserTpl
            // 
            this.btnGetUserTpl.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetUserTpl.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGetUserTpl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetUserTpl.Location = new System.Drawing.Point(352, 96);
            this.btnGetUserTpl.Name = "btnGetUserTpl";
            this.btnGetUserTpl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetUserTpl.Size = new System.Drawing.Size(105, 25);
            this.btnGetUserTpl.TabIndex = 15;
            this.btnGetUserTpl.Text = "SSR_GetUserTpl";
            this.btnGetUserTpl.UseVisualStyleBackColor = false;
            this.btnGetUserTpl.Click += new System.EventHandler(this.btnGetUserTpl_Click);
            // 
            // btnSSRDelUserInfo
            // 
            this.btnSSRDelUserInfo.BackColor = System.Drawing.SystemColors.Control;
            this.btnSSRDelUserInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSSRDelUserInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSSRDelUserInfo.Location = new System.Drawing.Point(352, 64);
            this.btnSSRDelUserInfo.Name = "btnSSRDelUserInfo";
            this.btnSSRDelUserInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSSRDelUserInfo.Size = new System.Drawing.Size(105, 25);
            this.btnSSRDelUserInfo.TabIndex = 14;
            this.btnSSRDelUserInfo.Text = "SSR_DelUserInfo";
            this.btnSSRDelUserInfo.UseVisualStyleBackColor = false;
            this.btnSSRDelUserInfo.Click += new System.EventHandler(this.btnSSRDelUserInfo_Click);
            // 
            // btnSSRSetUserInfo
            // 
            this.btnSSRSetUserInfo.BackColor = System.Drawing.SystemColors.Control;
            this.btnSSRSetUserInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSSRSetUserInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSSRSetUserInfo.Location = new System.Drawing.Point(352, 40);
            this.btnSSRSetUserInfo.Name = "btnSSRSetUserInfo";
            this.btnSSRSetUserInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSSRSetUserInfo.Size = new System.Drawing.Size(105, 25);
            this.btnSSRSetUserInfo.TabIndex = 13;
            this.btnSSRSetUserInfo.Text = "SSR_SetUserInfo";
            this.btnSSRSetUserInfo.UseVisualStyleBackColor = false;
            this.btnSSRSetUserInfo.Click += new System.EventHandler(this.btnSSRSetUserInfo_Click);
            // 
            // btnSSRGetUserInfo
            // 
            this.btnSSRGetUserInfo.BackColor = System.Drawing.SystemColors.Control;
            this.btnSSRGetUserInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSSRGetUserInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSSRGetUserInfo.Location = new System.Drawing.Point(352, 16);
            this.btnSSRGetUserInfo.Name = "btnSSRGetUserInfo";
            this.btnSSRGetUserInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSSRGetUserInfo.Size = new System.Drawing.Size(105, 25);
            this.btnSSRGetUserInfo.TabIndex = 12;
            this.btnSSRGetUserInfo.Text = "SSR_GetUserInfo";
            this.btnSSRGetUserInfo.UseVisualStyleBackColor = false;
            this.btnSSRGetUserInfo.Click += new System.EventHandler(this.btnSSRGetUserInfo_Click);
            // 
            // mmTpl
            // 
            this.mmTpl.AcceptsReturn = true;
            this.mmTpl.BackColor = System.Drawing.SystemColors.Window;
            this.mmTpl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mmTpl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mmTpl.Location = new System.Drawing.Point(72, 114);
            this.mmTpl.MaxLength = 0;
            this.mmTpl.Multiline = true;
            this.mmTpl.Name = "mmTpl";
            this.mmTpl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmTpl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mmTpl.Size = new System.Drawing.Size(273, 137);
            this.mmTpl.TabIndex = 59;
            // 
            // edtCardNo
            // 
            this.edtCardNo.AcceptsReturn = true;
            this.edtCardNo.BackColor = System.Drawing.SystemColors.Window;
            this.edtCardNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtCardNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtCardNo.Location = new System.Drawing.Point(240, 64);
            this.edtCardNo.MaxLength = 0;
            this.edtCardNo.Name = "edtCardNo";
            this.edtCardNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtCardNo.Size = new System.Drawing.Size(105, 20);
            this.edtCardNo.TabIndex = 58;
            this.edtCardNo.Text = "0";
            // 
            // edtValid
            // 
            this.edtValid.AcceptsReturn = true;
            this.edtValid.BackColor = System.Drawing.SystemColors.Window;
            this.edtValid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtValid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtValid.Location = new System.Drawing.Point(240, 40);
            this.edtValid.MaxLength = 0;
            this.edtValid.Name = "edtValid";
            this.edtValid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtValid.Size = new System.Drawing.Size(57, 20);
            this.edtValid.TabIndex = 57;
            this.edtValid.Text = "Y";
            // 
            // edtPri
            // 
            this.edtPri.AcceptsReturn = true;
            this.edtPri.BackColor = System.Drawing.SystemColors.Window;
            this.edtPri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtPri.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtPri.Location = new System.Drawing.Point(240, 16);
            this.edtPri.MaxLength = 0;
            this.edtPri.Name = "edtPri";
            this.edtPri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtPri.Size = new System.Drawing.Size(105, 20);
            this.edtPri.TabIndex = 56;
            this.edtPri.Text = "0";
            // 
            // _Label1_33
            // 
            this._Label1_33.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_33.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_33.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_33.Location = new System.Drawing.Point(464, 568);
            this._Label1_33.Name = "_Label1_33";
            this._Label1_33.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_33.Size = new System.Drawing.Size(65, 18);
            this._Label1_33.TabIndex = 50;
            this._Label1_33.Text = "Template :";
            // 
            // _Label1_32
            // 
            this._Label1_32.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_32.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_32.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_32.Location = new System.Drawing.Point(470, 504);
            this._Label1_32.Name = "_Label1_32";
            this._Label1_32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_32.Size = new System.Drawing.Size(49, 17);
            this._Label1_32.TabIndex = 49;
            this._Label1_32.Text = "Finger :";
            // 
            // _Label1_31
            // 
            this._Label1_31.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_31.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_31.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_31.Location = new System.Drawing.Point(470, 480);
            this._Label1_31.Name = "_Label1_31";
            this._Label1_31.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_31.Size = new System.Drawing.Size(65, 17);
            this._Label1_31.TabIndex = 48;
            this._Label1_31.Text = "Enroll No :";
            // 
            // _Label1_30
            // 
            this._Label1_30.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_30.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_30.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_30.Location = new System.Drawing.Point(472, 440);
            this._Label1_30.Name = "_Label1_30";
            this._Label1_30.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_30.Size = new System.Drawing.Size(65, 17);
            this._Label1_30.TabIndex = 46;
            this._Label1_30.Text = "TZ String :";
            // 
            // _Label1_29
            // 
            this._Label1_29.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_29.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_29.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_29.Location = new System.Drawing.Point(472, 416);
            this._Label1_29.Name = "_Label1_29";
            this._Label1_29.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_29.Size = new System.Drawing.Size(65, 17);
            this._Label1_29.TabIndex = 45;
            this._Label1_29.Text = "TZ Group :";
            // 
            // _Label1_28
            // 
            this._Label1_28.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_28.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_28.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_28.Location = new System.Drawing.Point(669, 392);
            this._Label1_28.Name = "_Label1_28";
            this._Label1_28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_28.Size = new System.Drawing.Size(69, 17);
            this._Label1_28.TabIndex = 44;
            this._Label1_28.Text = "Card No :";
            // 
            // _Label1_27
            // 
            this._Label1_27.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_27.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_27.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_27.Location = new System.Drawing.Point(472, 392);
            this._Label1_27.Name = "_Label1_27";
            this._Label1_27.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_27.Size = new System.Drawing.Size(65, 17);
            this._Label1_27.TabIndex = 43;
            this._Label1_27.Text = "Privilege :";
            // 
            // _Label1_26
            // 
            this._Label1_26.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_26.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_26.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_26.Location = new System.Drawing.Point(472, 368);
            this._Label1_26.Name = "_Label1_26";
            this._Label1_26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_26.Size = new System.Drawing.Size(65, 17);
            this._Label1_26.TabIndex = 42;
            this._Label1_26.Text = "Password :";
            // 
            // _Label1_25
            // 
            this._Label1_25.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_25.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_25.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_25.Location = new System.Drawing.Point(472, 344);
            this._Label1_25.Name = "_Label1_25";
            this._Label1_25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_25.Size = new System.Drawing.Size(49, 17);
            this._Label1_25.TabIndex = 41;
            this._Label1_25.Text = "Name :";
            // 
            // _Label1_24
            // 
            this._Label1_24.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_24.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_24.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_24.Location = new System.Drawing.Point(472, 320);
            this._Label1_24.Name = "_Label1_24";
            this._Label1_24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_24.Size = new System.Drawing.Size(65, 17);
            this._Label1_24.TabIndex = 40;
            this._Label1_24.Text = "Enroll No :";
            // 
            // _Label1_23
            // 
            this._Label1_23.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_23.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_23.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_23.Location = new System.Drawing.Point(472, 292);
            this._Label1_23.Name = "_Label1_23";
            this._Label1_23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_23.Size = new System.Drawing.Size(49, 17);
            this._Label1_23.TabIndex = 38;
            this._Label1_23.Text = "File :";
            // 
            // _Label1_22
            // 
            this._Label1_22.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_22.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_22.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_22.Location = new System.Drawing.Point(600, 240);
            this._Label1_22.Name = "_Label1_22";
            this._Label1_22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_22.Size = new System.Drawing.Size(89, 17);
            this._Label1_22.TabIndex = 36;
            this._Label1_22.Text = "End Day :";
            // 
            // _Label1_21
            // 
            this._Label1_21.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_21.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_21.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_21.Location = new System.Drawing.Point(600, 216);
            this._Label1_21.Name = "_Label1_21";
            this._Label1_21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_21.Size = new System.Drawing.Size(89, 17);
            this._Label1_21.TabIndex = 35;
            this._Label1_21.Text = "End Month :";
            // 
            // _Label1_20
            // 
            this._Label1_20.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_20.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_20.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_20.Location = new System.Drawing.Point(472, 240);
            this._Label1_20.Name = "_Label1_20";
            this._Label1_20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_20.Size = new System.Drawing.Size(89, 17);
            this._Label1_20.TabIndex = 34;
            this._Label1_20.Text = "Begin Day :";
            // 
            // _Label1_19
            // 
            this._Label1_19.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_19.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_19.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_19.Location = new System.Drawing.Point(472, 216);
            this._Label1_19.Name = "_Label1_19";
            this._Label1_19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_19.Size = new System.Drawing.Size(89, 17);
            this._Label1_19.TabIndex = 33;
            this._Label1_19.Text = "Begin Month :";
            // 
            // _Label1_18
            // 
            this._Label1_18.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_18.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_18.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_18.Location = new System.Drawing.Point(600, 192);
            this._Label1_18.Name = "_Label1_18";
            this._Label1_18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_18.Size = new System.Drawing.Size(89, 17);
            this._Label1_18.TabIndex = 32;
            this._Label1_18.Text = "TimeZone ID :";
            // 
            // _Label1_17
            // 
            this._Label1_17.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_17.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_17.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_17.Location = new System.Drawing.Point(472, 192);
            this._Label1_17.Name = "_Label1_17";
            this._Label1_17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_17.Size = new System.Drawing.Size(89, 17);
            this._Label1_17.TabIndex = 31;
            this._Label1_17.Text = "Holiday ID :";
            // 
            // _Label1_16
            // 
            this._Label1_16.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_16.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_16.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_16.Location = new System.Drawing.Point(608, 144);
            this._Label1_16.Name = "_Label1_16";
            this._Label1_16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_16.Size = new System.Drawing.Size(41, 17);
            this._Label1_16.TabIndex = 29;
            this._Label1_16.Text = "TZ 3 :";
            // 
            // _Label1_15
            // 
            this._Label1_15.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_15.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_15.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_15.Location = new System.Drawing.Point(608, 120);
            this._Label1_15.Name = "_Label1_15";
            this._Label1_15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_15.Size = new System.Drawing.Size(41, 17);
            this._Label1_15.TabIndex = 28;
            this._Label1_15.Text = "TZ 2 :";
            // 
            // _Label1_14
            // 
            this._Label1_14.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_14.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_14.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_14.Location = new System.Drawing.Point(608, 96);
            this._Label1_14.Name = "_Label1_14";
            this._Label1_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_14.Size = new System.Drawing.Size(41, 17);
            this._Label1_14.TabIndex = 27;
            this._Label1_14.Text = "TZ 1 :";
            // 
            // _Label1_13
            // 
            this._Label1_13.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_13.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_13.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_13.Location = new System.Drawing.Point(472, 144);
            this._Label1_13.Name = "_Label1_13";
            this._Label1_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_13.Size = new System.Drawing.Size(89, 17);
            this._Label1_13.TabIndex = 26;
            this._Label1_13.Text = "Verify Mode :";
            // 
            // _Label1_12
            // 
            this._Label1_12.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_12.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_12.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_12.Location = new System.Drawing.Point(472, 120);
            this._Label1_12.Name = "_Label1_12";
            this._Label1_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_12.Size = new System.Drawing.Size(57, 17);
            this._Label1_12.TabIndex = 25;
            this._Label1_12.Text = "Holiday :";
            // 
            // _Label1_11
            // 
            this._Label1_11.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_11.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_11.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_11.Location = new System.Drawing.Point(472, 96);
            this._Label1_11.Name = "_Label1_11";
            this._Label1_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_11.Size = new System.Drawing.Size(73, 17);
            this._Label1_11.TabIndex = 24;
            this._Label1_11.Text = "TZ Group :";
            // 
            // _Label1_10
            // 
            this._Label1_10.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_10.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_10.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_10.Location = new System.Drawing.Point(472, 40);
            this._Label1_10.Name = "_Label1_10";
            this._Label1_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_10.Size = new System.Drawing.Size(49, 17);
            this._Label1_10.TabIndex = 22;
            this._Label1_10.Text = "Group :";
            // 
            // _Label1_9
            // 
            this._Label1_9.BackColor = System.Drawing.SystemColors.Control;
            this._Label1_9.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_9.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_9.Location = new System.Drawing.Point(472, 16);
            this._Label1_9.Name = "_Label1_9";
            this._Label1_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_9.Size = new System.Drawing.Size(49, 17);
            this._Label1_9.TabIndex = 21;
            this._Label1_9.Text = "ComNo :";
            // 
            // lblWordCode
            // 
            this.lblWordCode.BackColor = System.Drawing.SystemColors.Control;
            this.lblWordCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblWordCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWordCode.Location = new System.Drawing.Point(8, 264);
            this.lblWordCode.Name = "lblWordCode";
            this.lblWordCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWordCode.Size = new System.Drawing.Size(74, 17);
            this.lblWordCode.TabIndex = 20;
            this.lblWordCode.Text = "WorkCode :";
            // 
            // lblTemplate
            // 
            this.lblTemplate.BackColor = System.Drawing.SystemColors.Control;
            this.lblTemplate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTemplate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTemplate.Location = new System.Drawing.Point(8, 112);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTemplate.Size = new System.Drawing.Size(74, 17);
            this.lblTemplate.TabIndex = 11;
            this.lblTemplate.Text = "Template :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(184, 64);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Card No :";
            // 
            // lblValid
            // 
            this.lblValid.BackColor = System.Drawing.SystemColors.Control;
            this.lblValid.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblValid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblValid.Location = new System.Drawing.Point(184, 40);
            this.lblValid.Name = "lblValid";
            this.lblValid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblValid.Size = new System.Drawing.Size(49, 17);
            this.lblValid.TabIndex = 9;
            this.lblValid.Text = "Valid :";
            // 
            // lblPriviledge
            // 
            this.lblPriviledge.BackColor = System.Drawing.SystemColors.Control;
            this.lblPriviledge.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPriviledge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPriviledge.Location = new System.Drawing.Point(184, 16);
            this.lblPriviledge.Name = "lblPriviledge";
            this.lblPriviledge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPriviledge.Size = new System.Drawing.Size(49, 17);
            this.lblPriviledge.TabIndex = 8;
            this.lblPriviledge.Text = "Privilege :";
            // 
            // lblFinger
            // 
            this.lblFinger.BackColor = System.Drawing.SystemColors.Control;
            this.lblFinger.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFinger.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFinger.Location = new System.Drawing.Point(8, 88);
            this.lblFinger.Name = "lblFinger";
            this.lblFinger.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFinger.Size = new System.Drawing.Size(74, 17);
            this.lblFinger.TabIndex = 7;
            this.lblFinger.Text = "Finger :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(8, 64);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password :";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(8, 40);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(8, 16);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enroll No :";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.btnSSRGetGeneralLog);
            this.groupBox4.Controls.Add(this.btnSSRGetAllUser);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(0, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(848, 41);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // btnSSRGetGeneralLog
            // 
            this.btnSSRGetGeneralLog.BackColor = System.Drawing.SystemColors.Control;
            this.btnSSRGetGeneralLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSSRGetGeneralLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSSRGetGeneralLog.Location = new System.Drawing.Point(175, 11);
            this.btnSSRGetGeneralLog.Name = "btnSSRGetGeneralLog";
            this.btnSSRGetGeneralLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSSRGetGeneralLog.Size = new System.Drawing.Size(161, 25);
            this.btnSSRGetGeneralLog.TabIndex = 3;
            this.btnSSRGetGeneralLog.Text = "SSR_GetGeneralLog";
            this.btnSSRGetGeneralLog.UseVisualStyleBackColor = false;
            this.btnSSRGetGeneralLog.Click += new System.EventHandler(this.btnSSRGetGeneralLog_Click);
            // 
            // btnSSRGetAllUser
            // 
            this.btnSSRGetAllUser.BackColor = System.Drawing.SystemColors.Control;
            this.btnSSRGetAllUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSSRGetAllUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSSRGetAllUser.Location = new System.Drawing.Point(8, 11);
            this.btnSSRGetAllUser.Name = "btnSSRGetAllUser";
            this.btnSSRGetAllUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSSRGetAllUser.Size = new System.Drawing.Size(161, 25);
            this.btnSSRGetAllUser.TabIndex = 1;
            this.btnSSRGetAllUser.Text = "SSR_GetAllUserInfo";
            this.btnSSRGetAllUser.UseVisualStyleBackColor = false;
            this.btnSSRGetAllUser.Click += new System.EventHandler(this.btnSSRGetAllUser_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnListBox2Clear);
            this.tabPage5.Controls.Add(this.groupBox7);
            this.tabPage5.Controls.Add(this.btnOpenPhoto);
            this.tabPage5.Controls.Add(this.btnOpenPicture);
            this.tabPage5.Controls.Add(this.listBox2);
            this.tabPage5.Controls.Add(this.edtPicPath);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.edtDownloadPicture);
            this.tabPage5.Controls.Add(this.btnDownloadPicture);
            this.tabPage5.Controls.Add(this.edtPhotoPath);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.edtDownloadPhoto);
            this.tabPage5.Controls.Add(this.btnDownloadPhoto);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.edtDelPhoto);
            this.tabPage5.Controls.Add(this.btnDelPhoto);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.edtDelPicture);
            this.tabPage5.Controls.Add(this.btnDelPicture);
            this.tabPage5.Controls.Add(this.edtPhoto);
            this.tabPage5.Controls.Add(this.btnUploadPhoto);
            this.tabPage5.Controls.Add(this.edtPicture);
            this.tabPage5.Controls.Add(this.btnUploadPicture);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(851, 685);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Multimedia Demo";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnListBox2Clear
            // 
            this.btnListBox2Clear.Location = new System.Drawing.Point(406, 370);
            this.btnListBox2Clear.Name = "btnListBox2Clear";
            this.btnListBox2Clear.Size = new System.Drawing.Size(75, 23);
            this.btnListBox2Clear.TabIndex = 56;
            this.btnListBox2Clear.Text = "Clear";
            this.btnListBox2Clear.UseVisualStyleBackColor = true;
            this.btnListBox2Clear.Click += new System.EventHandler(this.btnListBox2Clear_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnGetFail);
            this.groupBox7.Controls.Add(this.btnGetSuccess);
            this.groupBox7.Location = new System.Drawing.Point(16, 304);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(465, 57);
            this.groupBox7.TabIndex = 55;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "i-Kiosk 100 Plus";
            // 
            // btnGetFail
            // 
            this.btnGetFail.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetFail.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGetFail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetFail.Location = new System.Drawing.Point(143, 19);
            this.btnGetFail.Name = "btnGetFail";
            this.btnGetFail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetFail.Size = new System.Drawing.Size(129, 25);
            this.btnGetFail.TabIndex = 36;
            this.btnGetFail.Text = "Get Fail Photo";
            this.btnGetFail.UseVisualStyleBackColor = false;
            this.btnGetFail.Click += new System.EventHandler(this.btnGetFail_Click);
            // 
            // btnGetSuccess
            // 
            this.btnGetSuccess.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetSuccess.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGetSuccess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetSuccess.Location = new System.Drawing.Point(8, 19);
            this.btnGetSuccess.Name = "btnGetSuccess";
            this.btnGetSuccess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetSuccess.Size = new System.Drawing.Size(129, 25);
            this.btnGetSuccess.TabIndex = 35;
            this.btnGetSuccess.Text = "Get Success Photo";
            this.btnGetSuccess.UseVisualStyleBackColor = false;
            this.btnGetSuccess.Click += new System.EventHandler(this.btnGetSuccess_Click);
            // 
            // btnOpenPhoto
            // 
            this.btnOpenPhoto.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenPhoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOpenPhoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenPhoto.Location = new System.Drawing.Point(440, 54);
            this.btnOpenPhoto.Name = "btnOpenPhoto";
            this.btnOpenPhoto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOpenPhoto.Size = new System.Drawing.Size(33, 25);
            this.btnOpenPhoto.TabIndex = 54;
            this.btnOpenPhoto.Text = "...";
            this.btnOpenPhoto.UseVisualStyleBackColor = false;
            this.btnOpenPhoto.Click += new System.EventHandler(this.btnOpenPhoto_Click);
            // 
            // btnOpenPicture
            // 
            this.btnOpenPicture.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOpenPicture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenPicture.Location = new System.Drawing.Point(440, 14);
            this.btnOpenPicture.Name = "btnOpenPicture";
            this.btnOpenPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOpenPicture.Size = new System.Drawing.Size(33, 25);
            this.btnOpenPicture.TabIndex = 53;
            this.btnOpenPicture.Text = "...";
            this.btnOpenPicture.UseVisualStyleBackColor = false;
            this.btnOpenPicture.Click += new System.EventHandler(this.btnOpenPicture_Click);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.Window;
            this.listBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox2.Location = new System.Drawing.Point(16, 370);
            this.listBox2.Name = "listBox2";
            this.listBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox2.Size = new System.Drawing.Size(465, 303);
            this.listBox2.TabIndex = 52;
            // 
            // edtPicPath
            // 
            this.edtPicPath.AcceptsReturn = true;
            this.edtPicPath.BackColor = System.Drawing.SystemColors.Window;
            this.edtPicPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtPicPath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtPicPath.Location = new System.Drawing.Point(152, 278);
            this.edtPicPath.MaxLength = 0;
            this.edtPicPath.Name = "edtPicPath";
            this.edtPicPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtPicPath.Size = new System.Drawing.Size(281, 20);
            this.edtPicPath.TabIndex = 51;
            this.edtPicPath.Text = "C:\\";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(280, 254);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(188, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "(ad_0.jpg / ad_1.jpg ...)";
            // 
            // edtDownloadPicture
            // 
            this.edtDownloadPicture.AcceptsReturn = true;
            this.edtDownloadPicture.BackColor = System.Drawing.SystemColors.Window;
            this.edtDownloadPicture.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtDownloadPicture.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtDownloadPicture.Location = new System.Drawing.Point(152, 246);
            this.edtDownloadPicture.MaxLength = 0;
            this.edtDownloadPicture.Name = "edtDownloadPicture";
            this.edtDownloadPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtDownloadPicture.Size = new System.Drawing.Size(121, 20);
            this.edtDownloadPicture.TabIndex = 49;
            // 
            // btnDownloadPicture
            // 
            this.btnDownloadPicture.BackColor = System.Drawing.SystemColors.Control;
            this.btnDownloadPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDownloadPicture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDownloadPicture.Location = new System.Drawing.Point(16, 246);
            this.btnDownloadPicture.Name = "btnDownloadPicture";
            this.btnDownloadPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDownloadPicture.Size = new System.Drawing.Size(129, 25);
            this.btnDownloadPicture.TabIndex = 48;
            this.btnDownloadPicture.Text = "Download Picture";
            this.btnDownloadPicture.UseVisualStyleBackColor = false;
            this.btnDownloadPicture.Click += new System.EventHandler(this.btnDownloadPicture_Click);
            // 
            // edtPhotoPath
            // 
            this.edtPhotoPath.AcceptsReturn = true;
            this.edtPhotoPath.BackColor = System.Drawing.SystemColors.Window;
            this.edtPhotoPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtPhotoPath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtPhotoPath.Location = new System.Drawing.Point(152, 206);
            this.edtPhotoPath.MaxLength = 0;
            this.edtPhotoPath.Name = "edtPhotoPath";
            this.edtPhotoPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtPhotoPath.Size = new System.Drawing.Size(281, 20);
            this.edtPhotoPath.TabIndex = 47;
            this.edtPhotoPath.Text = "C:\\";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(112, 206);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Path :";
            // 
            // edtDownloadPhoto
            // 
            this.edtDownloadPhoto.AcceptsReturn = true;
            this.edtDownloadPhoto.BackColor = System.Drawing.SystemColors.Window;
            this.edtDownloadPhoto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtDownloadPhoto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtDownloadPhoto.Location = new System.Drawing.Point(152, 174);
            this.edtDownloadPhoto.MaxLength = 0;
            this.edtDownloadPhoto.Name = "edtDownloadPhoto";
            this.edtDownloadPhoto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtDownloadPhoto.Size = new System.Drawing.Size(121, 20);
            this.edtDownloadPhoto.TabIndex = 45;
            // 
            // btnDownloadPhoto
            // 
            this.btnDownloadPhoto.BackColor = System.Drawing.SystemColors.Control;
            this.btnDownloadPhoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDownloadPhoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDownloadPhoto.Location = new System.Drawing.Point(16, 174);
            this.btnDownloadPhoto.Name = "btnDownloadPhoto";
            this.btnDownloadPhoto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDownloadPhoto.Size = new System.Drawing.Size(129, 25);
            this.btnDownloadPhoto.TabIndex = 44;
            this.btnDownloadPhoto.Text = "Download User Photo";
            this.btnDownloadPhoto.UseVisualStyleBackColor = false;
            this.btnDownloadPhoto.Click += new System.EventHandler(this.btnDownloadPhoto_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(280, 134);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(188, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "(\"UserID\".jpg like 1.jpg, 1234.jpg)";
            // 
            // edtDelPhoto
            // 
            this.edtDelPhoto.AcceptsReturn = true;
            this.edtDelPhoto.BackColor = System.Drawing.SystemColors.Window;
            this.edtDelPhoto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtDelPhoto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtDelPhoto.Location = new System.Drawing.Point(152, 134);
            this.edtDelPhoto.MaxLength = 0;
            this.edtDelPhoto.Name = "edtDelPhoto";
            this.edtDelPhoto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtDelPhoto.Size = new System.Drawing.Size(121, 20);
            this.edtDelPhoto.TabIndex = 42;
            // 
            // btnDelPhoto
            // 
            this.btnDelPhoto.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelPhoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelPhoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelPhoto.Location = new System.Drawing.Point(16, 134);
            this.btnDelPhoto.Name = "btnDelPhoto";
            this.btnDelPhoto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelPhoto.Size = new System.Drawing.Size(129, 25);
            this.btnDelPhoto.TabIndex = 41;
            this.btnDelPhoto.Text = "Delete User Photo";
            this.btnDelPhoto.UseVisualStyleBackColor = false;
            this.btnDelPhoto.Click += new System.EventHandler(this.btnDelPhoto_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(280, 94);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(161, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "(ad_0.jpg / ad_1.jpg ...)";
            // 
            // edtDelPicture
            // 
            this.edtDelPicture.AcceptsReturn = true;
            this.edtDelPicture.BackColor = System.Drawing.SystemColors.Window;
            this.edtDelPicture.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtDelPicture.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtDelPicture.Location = new System.Drawing.Point(152, 94);
            this.edtDelPicture.MaxLength = 0;
            this.edtDelPicture.Name = "edtDelPicture";
            this.edtDelPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtDelPicture.Size = new System.Drawing.Size(121, 20);
            this.edtDelPicture.TabIndex = 39;
            // 
            // btnDelPicture
            // 
            this.btnDelPicture.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelPicture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelPicture.Location = new System.Drawing.Point(16, 94);
            this.btnDelPicture.Name = "btnDelPicture";
            this.btnDelPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelPicture.Size = new System.Drawing.Size(129, 25);
            this.btnDelPicture.TabIndex = 38;
            this.btnDelPicture.Text = "Delete Picture";
            this.btnDelPicture.UseVisualStyleBackColor = false;
            this.btnDelPicture.Click += new System.EventHandler(this.btnDelPicture_Click);
            // 
            // edtPhoto
            // 
            this.edtPhoto.AcceptsReturn = true;
            this.edtPhoto.BackColor = System.Drawing.SystemColors.Window;
            this.edtPhoto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtPhoto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtPhoto.Location = new System.Drawing.Point(152, 54);
            this.edtPhoto.MaxLength = 0;
            this.edtPhoto.Name = "edtPhoto";
            this.edtPhoto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtPhoto.Size = new System.Drawing.Size(281, 20);
            this.edtPhoto.TabIndex = 37;
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.BackColor = System.Drawing.SystemColors.Control;
            this.btnUploadPhoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUploadPhoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUploadPhoto.Location = new System.Drawing.Point(16, 54);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUploadPhoto.Size = new System.Drawing.Size(129, 25);
            this.btnUploadPhoto.TabIndex = 36;
            this.btnUploadPhoto.Text = "Upload User Photo";
            this.btnUploadPhoto.UseVisualStyleBackColor = false;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
            // 
            // edtPicture
            // 
            this.edtPicture.AcceptsReturn = true;
            this.edtPicture.BackColor = System.Drawing.SystemColors.Window;
            this.edtPicture.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtPicture.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtPicture.Location = new System.Drawing.Point(152, 14);
            this.edtPicture.MaxLength = 0;
            this.edtPicture.Name = "edtPicture";
            this.edtPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtPicture.Size = new System.Drawing.Size(281, 20);
            this.edtPicture.TabIndex = 35;
            // 
            // btnUploadPicture
            // 
            this.btnUploadPicture.BackColor = System.Drawing.SystemColors.Control;
            this.btnUploadPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUploadPicture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUploadPicture.Location = new System.Drawing.Point(16, 14);
            this.btnUploadPicture.Name = "btnUploadPicture";
            this.btnUploadPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUploadPicture.Size = new System.Drawing.Size(129, 25);
            this.btnUploadPicture.TabIndex = 34;
            this.btnUploadPicture.Text = "Upload Picture";
            this.btnUploadPicture.UseVisualStyleBackColor = false;
            this.btnUploadPicture.Click += new System.EventHandler(this.btnUploadPicture_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox17);
            this.tabPage4.Controls.Add(this.groupBox18);
            this.tabPage4.Controls.Add(this.groupBox15);
            this.tabPage4.Controls.Add(this.groupBox13);
            this.tabPage4.Controls.Add(this.groupBox14);
            this.tabPage4.Controls.Add(this.groupBox12);
            this.tabPage4.Controls.Add(this.groupBox11);
            this.tabPage4.Controls.Add(this.groupBox10);
            this.tabPage4.Controls.Add(this.btnListBox3Clear);
            this.tabPage4.Controls.Add(this.groupBox9);
            this.tabPage4.Controls.Add(this.listBox3);
            this.tabPage4.Controls.Add(this.groupBox8);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(851, 685);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Others";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.btnGroupTimezone_Set);
            this.groupBox17.Controls.Add(this.txtGroupTimezone_Verify);
            this.groupBox17.Controls.Add(this.txtGroupTimezone_Timezone);
            this.groupBox17.Controls.Add(this.label22);
            this.groupBox17.Controls.Add(this.txtGroupTimezone_Group);
            this.groupBox17.Controls.Add(this.label26);
            this.groupBox17.Controls.Add(this.label27);
            this.groupBox17.Controls.Add(this.btnGroupTimezone_Get);
            this.groupBox17.Location = new System.Drawing.Point(656, 94);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(187, 115);
            this.groupBox17.TabIndex = 66;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Group Timezone Verify Style";
            // 
            // btnGroupTimezone_Set
            // 
            this.btnGroupTimezone_Set.Location = new System.Drawing.Point(99, 85);
            this.btnGroupTimezone_Set.Name = "btnGroupTimezone_Set";
            this.btnGroupTimezone_Set.Size = new System.Drawing.Size(67, 25);
            this.btnGroupTimezone_Set.TabIndex = 61;
            this.btnGroupTimezone_Set.Text = "Set";
            this.btnGroupTimezone_Set.UseVisualStyleBackColor = false;
            this.btnGroupTimezone_Set.Click += new System.EventHandler(this.btnGroupTimezone_Set_Click);
            // 
            // txtGroupTimezone_Verify
            // 
            this.txtGroupTimezone_Verify.AcceptsReturn = true;
            this.txtGroupTimezone_Verify.Location = new System.Drawing.Point(72, 58);
            this.txtGroupTimezone_Verify.MaxLength = 0;
            this.txtGroupTimezone_Verify.Name = "txtGroupTimezone_Verify";
            this.txtGroupTimezone_Verify.Size = new System.Drawing.Size(112, 20);
            this.txtGroupTimezone_Verify.TabIndex = 60;
            // 
            // txtGroupTimezone_Timezone
            // 
            this.txtGroupTimezone_Timezone.AcceptsReturn = true;
            this.txtGroupTimezone_Timezone.Location = new System.Drawing.Point(72, 37);
            this.txtGroupTimezone_Timezone.MaxLength = 0;
            this.txtGroupTimezone_Timezone.Name = "txtGroupTimezone_Timezone";
            this.txtGroupTimezone_Timezone.Size = new System.Drawing.Size(112, 20);
            this.txtGroupTimezone_Timezone.TabIndex = 59;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(5, 58);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 17);
            this.label22.TabIndex = 58;
            this.label22.Text = "Verify Style";
            // 
            // txtGroupTimezone_Group
            // 
            this.txtGroupTimezone_Group.AcceptsReturn = true;
            this.txtGroupTimezone_Group.Location = new System.Drawing.Point(72, 15);
            this.txtGroupTimezone_Group.MaxLength = 0;
            this.txtGroupTimezone_Group.Name = "txtGroupTimezone_Group";
            this.txtGroupTimezone_Group.Size = new System.Drawing.Size(112, 20);
            this.txtGroupTimezone_Group.TabIndex = 57;
            this.txtGroupTimezone_Group.Text = "1";
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(5, 36);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(61, 17);
            this.label26.TabIndex = 44;
            this.label26.Text = "Timezone";
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(5, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(61, 17);
            this.label27.TabIndex = 43;
            this.label27.Text = "Group ID";
            // 
            // btnGroupTimezone_Get
            // 
            this.btnGroupTimezone_Get.Location = new System.Drawing.Point(16, 85);
            this.btnGroupTimezone_Get.Name = "btnGroupTimezone_Get";
            this.btnGroupTimezone_Get.Size = new System.Drawing.Size(71, 25);
            this.btnGroupTimezone_Get.TabIndex = 42;
            this.btnGroupTimezone_Get.Text = "Get";
            this.btnGroupTimezone_Get.UseVisualStyleBackColor = false;
            this.btnGroupTimezone_Get.Click += new System.EventHandler(this.btnGroupTimezone_Get_Click);
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.btnSleepSet);
            this.groupBox18.Controls.Add(this.label23);
            this.groupBox18.Controls.Add(this.btnSleepGet);
            this.groupBox18.Controls.Add(this.txtSleepM);
            this.groupBox18.Controls.Add(this.label24);
            this.groupBox18.Controls.Add(this.txtSleepH);
            this.groupBox18.Controls.Add(this.label25);
            this.groupBox18.Location = new System.Drawing.Point(463, 176);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(180, 82);
            this.groupBox18.TabIndex = 65;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Sleep";
            // 
            // btnSleepSet
            // 
            this.btnSleepSet.Location = new System.Drawing.Point(88, 42);
            this.btnSleepSet.Name = "btnSleepSet";
            this.btnSleepSet.Size = new System.Drawing.Size(80, 25);
            this.btnSleepSet.TabIndex = 42;
            this.btnSleepSet.Text = "Set ";
            this.btnSleepSet.UseVisualStyleBackColor = false;
            this.btnSleepSet.Click += new System.EventHandler(this.btnSleepSet_Click);
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(134, 19);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 17);
            this.label23.TabIndex = 40;
            this.label23.Text = "Minute";
            // 
            // btnSleepGet
            // 
            this.btnSleepGet.Location = new System.Drawing.Point(10, 42);
            this.btnSleepGet.Name = "btnSleepGet";
            this.btnSleepGet.Size = new System.Drawing.Size(72, 25);
            this.btnSleepGet.TabIndex = 34;
            this.btnSleepGet.Text = "Get";
            this.btnSleepGet.UseVisualStyleBackColor = false;
            this.btnSleepGet.Click += new System.EventHandler(this.btnSleepGet_Click);
            // 
            // txtSleepM
            // 
            this.txtSleepM.AcceptsReturn = true;
            this.txtSleepM.Location = new System.Drawing.Point(108, 16);
            this.txtSleepM.MaxLength = 0;
            this.txtSleepM.Name = "txtSleepM";
            this.txtSleepM.Size = new System.Drawing.Size(25, 20);
            this.txtSleepM.TabIndex = 28;
            this.txtSleepM.Text = "00";
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(72, 19);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 17);
            this.label24.TabIndex = 41;
            this.label24.Text = "Hour";
            // 
            // txtSleepH
            // 
            this.txtSleepH.AcceptsReturn = true;
            this.txtSleepH.Location = new System.Drawing.Point(46, 16);
            this.txtSleepH.MaxLength = 0;
            this.txtSleepH.Name = "txtSleepH";
            this.txtSleepH.Size = new System.Drawing.Size(25, 20);
            this.txtSleepH.TabIndex = 29;
            this.txtSleepH.Text = "00";
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(6, 19);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 17);
            this.label25.TabIndex = 38;
            this.label25.Text = "Sleep";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.btnPlatform);
            this.groupBox15.Controls.Add(this.txtPlatform);
            this.groupBox15.Controls.Add(this.label20);
            this.groupBox15.Location = new System.Drawing.Point(463, 89);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(180, 81);
            this.groupBox15.TabIndex = 62;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Platform";
            // 
            // btnPlatform
            // 
            this.btnPlatform.Location = new System.Drawing.Point(47, 42);
            this.btnPlatform.Name = "btnPlatform";
            this.btnPlatform.Size = new System.Drawing.Size(72, 25);
            this.btnPlatform.TabIndex = 34;
            this.btnPlatform.Text = "Get";
            this.btnPlatform.UseVisualStyleBackColor = false;
            this.btnPlatform.Click += new System.EventHandler(this.btnPlatform_Click);
            // 
            // txtPlatform
            // 
            this.txtPlatform.AcceptsReturn = true;
            this.txtPlatform.Location = new System.Drawing.Point(59, 16);
            this.txtPlatform.MaxLength = 0;
            this.txtPlatform.Name = "txtPlatform";
            this.txtPlatform.ReadOnly = true;
            this.txtPlatform.Size = new System.Drawing.Size(101, 20);
            this.txtPlatform.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(6, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 17);
            this.label20.TabIndex = 38;
            this.label20.Text = "Platform";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.btnSubnetSet);
            this.groupBox13.Controls.Add(this.btnSubnetGet);
            this.groupBox13.Controls.Add(this.txtSubnet);
            this.groupBox13.Controls.Add(this.label19);
            this.groupBox13.Location = new System.Drawing.Point(656, 6);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(180, 82);
            this.groupBox13.TabIndex = 61;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Subnet Mask";
            // 
            // btnSubnetSet
            // 
            this.btnSubnetSet.Location = new System.Drawing.Point(86, 42);
            this.btnSubnetSet.Name = "btnSubnetSet";
            this.btnSubnetSet.Size = new System.Drawing.Size(80, 25);
            this.btnSubnetSet.TabIndex = 42;
            this.btnSubnetSet.Text = "Set ";
            this.btnSubnetSet.UseVisualStyleBackColor = false;
            this.btnSubnetSet.Click += new System.EventHandler(this.btnSubnetSet_Click);
            // 
            // btnSubnetGet
            // 
            this.btnSubnetGet.Location = new System.Drawing.Point(8, 42);
            this.btnSubnetGet.Name = "btnSubnetGet";
            this.btnSubnetGet.Size = new System.Drawing.Size(72, 25);
            this.btnSubnetGet.TabIndex = 34;
            this.btnSubnetGet.Text = "Get";
            this.btnSubnetGet.UseVisualStyleBackColor = false;
            this.btnSubnetGet.Click += new System.EventHandler(this.btnSubnetGet_Click);
            // 
            // txtSubnet
            // 
            this.txtSubnet.AcceptsReturn = true;
            this.txtSubnet.Location = new System.Drawing.Point(77, 16);
            this.txtSubnet.MaxLength = 0;
            this.txtSubnet.Name = "txtSubnet";
            this.txtSubnet.Size = new System.Drawing.Size(101, 20);
            this.txtSubnet.TabIndex = 29;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(6, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 17);
            this.label19.TabIndex = 38;
            this.label19.Text = "Subnet Mask";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.btnGatewaySet);
            this.groupBox14.Controls.Add(this.btnGatewayGet);
            this.groupBox14.Controls.Add(this.txtGateway);
            this.groupBox14.Controls.Add(this.label18);
            this.groupBox14.Location = new System.Drawing.Point(463, 6);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(180, 82);
            this.groupBox14.TabIndex = 60;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Gateway";
            // 
            // btnGatewaySet
            // 
            this.btnGatewaySet.Location = new System.Drawing.Point(80, 42);
            this.btnGatewaySet.Name = "btnGatewaySet";
            this.btnGatewaySet.Size = new System.Drawing.Size(80, 25);
            this.btnGatewaySet.TabIndex = 42;
            this.btnGatewaySet.Text = "Set ";
            this.btnGatewaySet.UseVisualStyleBackColor = false;
            this.btnGatewaySet.Click += new System.EventHandler(this.btnGatewaySet_Click);
            // 
            // btnGatewayGet
            // 
            this.btnGatewayGet.Location = new System.Drawing.Point(2, 42);
            this.btnGatewayGet.Name = "btnGatewayGet";
            this.btnGatewayGet.Size = new System.Drawing.Size(72, 25);
            this.btnGatewayGet.TabIndex = 34;
            this.btnGatewayGet.Text = "Get";
            this.btnGatewayGet.UseVisualStyleBackColor = false;
            this.btnGatewayGet.Click += new System.EventHandler(this.btnGatewayGet_Click);
            // 
            // txtGateway
            // 
            this.txtGateway.AcceptsReturn = true;
            this.txtGateway.Location = new System.Drawing.Point(59, 16);
            this.txtGateway.MaxLength = 0;
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(101, 20);
            this.txtGateway.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(6, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 17);
            this.label18.TabIndex = 38;
            this.label18.Text = "Gateway";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.txtBeginCard);
            this.groupBox12.Controls.Add(this.txtBeginPassword);
            this.groupBox12.Controls.Add(this.label17);
            this.groupBox12.Controls.Add(this.txtBeginEnroll);
            this.groupBox12.Controls.Add(this.label15);
            this.groupBox12.Controls.Add(this.label14);
            this.groupBox12.Controls.Add(this.btnBeginStart);
            this.groupBox12.Location = new System.Drawing.Point(234, 145);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(223, 115);
            this.groupBox12.TabIndex = 58;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "BeginBatchUpdate/BatchUpdate";
            // 
            // txtBeginCard
            // 
            this.txtBeginCard.AcceptsReturn = true;
            this.txtBeginCard.Location = new System.Drawing.Point(73, 58);
            this.txtBeginCard.MaxLength = 0;
            this.txtBeginCard.Name = "txtBeginCard";
            this.txtBeginCard.Size = new System.Drawing.Size(112, 20);
            this.txtBeginCard.TabIndex = 60;
            this.txtBeginCard.Text = "0";
            // 
            // txtBeginPassword
            // 
            this.txtBeginPassword.AcceptsReturn = true;
            this.txtBeginPassword.Location = new System.Drawing.Point(73, 37);
            this.txtBeginPassword.MaxLength = 0;
            this.txtBeginPassword.Name = "txtBeginPassword";
            this.txtBeginPassword.Size = new System.Drawing.Size(112, 20);
            this.txtBeginPassword.TabIndex = 59;
            this.txtBeginPassword.Text = "0";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(6, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 17);
            this.label17.TabIndex = 58;
            this.label17.Text = "Card num.";
            // 
            // txtBeginEnroll
            // 
            this.txtBeginEnroll.AcceptsReturn = true;
            this.txtBeginEnroll.Location = new System.Drawing.Point(73, 15);
            this.txtBeginEnroll.MaxLength = 0;
            this.txtBeginEnroll.Name = "txtBeginEnroll";
            this.txtBeginEnroll.Size = new System.Drawing.Size(112, 20);
            this.txtBeginEnroll.TabIndex = 57;
            this.txtBeginEnroll.Text = "1100";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(6, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 17);
            this.label15.TabIndex = 44;
            this.label15.Text = "Password";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 17);
            this.label14.TabIndex = 43;
            this.label14.Text = "Enroll ID";
            // 
            // btnBeginStart
            // 
            this.btnBeginStart.Location = new System.Drawing.Point(26, 81);
            this.btnBeginStart.Name = "btnBeginStart";
            this.btnBeginStart.Size = new System.Drawing.Size(163, 25);
            this.btnBeginStart.TabIndex = 42;
            this.btnBeginStart.Text = "Begin Batch Update";
            this.btnBeginStart.UseVisualStyleBackColor = false;
            this.btnBeginStart.Click += new System.EventHandler(this.btnBeginStart_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btnGetErrorCard);
            this.groupBox11.Controls.Add(this.btnClearErrorCard);
            this.groupBox11.Location = new System.Drawing.Point(4, 176);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(223, 84);
            this.groupBox11.TabIndex = 57;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Error Card Number";
            // 
            // btnGetErrorCard
            // 
            this.btnGetErrorCard.Location = new System.Drawing.Point(6, 50);
            this.btnGetErrorCard.Name = "btnGetErrorCard";
            this.btnGetErrorCard.Size = new System.Drawing.Size(163, 25);
            this.btnGetErrorCard.TabIndex = 42;
            this.btnGetErrorCard.Text = "Get Error Card Number";
            this.btnGetErrorCard.UseVisualStyleBackColor = false;
            this.btnGetErrorCard.Click += new System.EventHandler(this.btnGetErrorCard_Click);
            // 
            // btnClearErrorCard
            // 
            this.btnClearErrorCard.Location = new System.Drawing.Point(6, 19);
            this.btnClearErrorCard.Name = "btnClearErrorCard";
            this.btnClearErrorCard.Size = new System.Drawing.Size(163, 25);
            this.btnClearErrorCard.TabIndex = 34;
            this.btnClearErrorCard.Text = "Clear Error Card Num.";
            this.btnClearErrorCard.UseVisualStyleBackColor = false;
            this.btnClearErrorCard.Click += new System.EventHandler(this.btnClearErrorCard_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnSetAntipassback);
            this.groupBox10.Controls.Add(this.btnGetAntipassback);
            this.groupBox10.Controls.Add(this.txtAntipassback);
            this.groupBox10.Controls.Add(this.label16);
            this.groupBox10.Location = new System.Drawing.Point(4, 88);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(223, 82);
            this.groupBox10.TabIndex = 56;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Antipassback";
            // 
            // btnSetAntipassback
            // 
            this.btnSetAntipassback.Location = new System.Drawing.Point(113, 42);
            this.btnSetAntipassback.Name = "btnSetAntipassback";
            this.btnSetAntipassback.Size = new System.Drawing.Size(104, 25);
            this.btnSetAntipassback.TabIndex = 42;
            this.btnSetAntipassback.Text = "Set Antipassback";
            this.btnSetAntipassback.UseVisualStyleBackColor = false;
            this.btnSetAntipassback.Click += new System.EventHandler(this.btnSetAntipassback_Click);
            // 
            // btnGetAntipassback
            // 
            this.btnGetAntipassback.Location = new System.Drawing.Point(2, 42);
            this.btnGetAntipassback.Name = "btnGetAntipassback";
            this.btnGetAntipassback.Size = new System.Drawing.Size(105, 25);
            this.btnGetAntipassback.TabIndex = 34;
            this.btnGetAntipassback.Text = "Get Antipassback";
            this.btnGetAntipassback.UseVisualStyleBackColor = false;
            this.btnGetAntipassback.Click += new System.EventHandler(this.btnGetAntipassback_Click);
            // 
            // txtAntipassback
            // 
            this.txtAntipassback.AcceptsReturn = true;
            this.txtAntipassback.Location = new System.Drawing.Point(108, 16);
            this.txtAntipassback.MaxLength = 0;
            this.txtAntipassback.Name = "txtAntipassback";
            this.txtAntipassback.Size = new System.Drawing.Size(82, 20);
            this.txtAntipassback.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(6, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 17);
            this.label16.TabIndex = 38;
            this.label16.Text = "Antipassback Value";
            // 
            // btnListBox3Clear
            // 
            this.btnListBox3Clear.Location = new System.Drawing.Point(780, 278);
            this.btnListBox3Clear.Name = "btnListBox3Clear";
            this.btnListBox3Clear.Size = new System.Drawing.Size(75, 23);
            this.btnListBox3Clear.TabIndex = 55;
            this.btnListBox3Clear.Text = "Clear";
            this.btnListBox3Clear.UseVisualStyleBackColor = true;
            this.btnListBox3Clear.Click += new System.EventHandler(this.btnListBox3Clear_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnH2iAdminCard_Set);
            this.groupBox9.Controls.Add(this.txtH2iAdminCard);
            this.groupBox9.Controls.Add(this.btnH2iAdminCard_Get);
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Controls.Add(this.btnH2i_TurnAlarmOff);
            this.groupBox9.Location = new System.Drawing.Point(233, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(224, 133);
            this.groupBox9.TabIndex = 54;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "H2i";
            // 
            // btnH2iAdminCard_Set
            // 
            this.btnH2iAdminCard_Set.Location = new System.Drawing.Point(110, 82);
            this.btnH2iAdminCard_Set.Name = "btnH2iAdminCard_Set";
            this.btnH2iAdminCard_Set.Size = new System.Drawing.Size(94, 25);
            this.btnH2iAdminCard_Set.TabIndex = 56;
            this.btnH2iAdminCard_Set.Text = "Set Admin Card";
            this.btnH2iAdminCard_Set.UseVisualStyleBackColor = false;
            this.btnH2iAdminCard_Set.Click += new System.EventHandler(this.btnH2iAdminCard_Set_Click);
            // 
            // txtH2iAdminCard
            // 
            this.txtH2iAdminCard.AcceptsReturn = true;
            this.txtH2iAdminCard.Location = new System.Drawing.Point(101, 56);
            this.txtH2iAdminCard.MaxLength = 0;
            this.txtH2iAdminCard.Name = "txtH2iAdminCard";
            this.txtH2iAdminCard.Size = new System.Drawing.Size(112, 20);
            this.txtH2iAdminCard.TabIndex = 56;
            // 
            // btnH2iAdminCard_Get
            // 
            this.btnH2iAdminCard_Get.Location = new System.Drawing.Point(10, 82);
            this.btnH2iAdminCard_Get.Name = "btnH2iAdminCard_Get";
            this.btnH2iAdminCard_Get.Size = new System.Drawing.Size(94, 25);
            this.btnH2iAdminCard_Get.TabIndex = 57;
            this.btnH2iAdminCard_Get.Text = "Get Admin Card";
            this.btnH2iAdminCard_Get.UseVisualStyleBackColor = false;
            this.btnH2iAdminCard_Get.Click += new System.EventHandler(this.btnH2iAdminCard_Get_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 56;
            this.label10.Text = "Admin Card Num.";
            // 
            // btnH2i_TurnAlarmOff
            // 
            this.btnH2i_TurnAlarmOff.Location = new System.Drawing.Point(9, 19);
            this.btnH2i_TurnAlarmOff.Name = "btnH2i_TurnAlarmOff";
            this.btnH2i_TurnAlarmOff.Size = new System.Drawing.Size(181, 25);
            this.btnH2i_TurnAlarmOff.TabIndex = 34;
            this.btnH2i_TurnAlarmOff.Text = "Turn Alarm Off";
            this.btnH2i_TurnAlarmOff.UseVisualStyleBackColor = false;
            this.btnH2i_TurnAlarmOff.Click += new System.EventHandler(this.btnH2i_TurnAlarmOff_Click);
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.Window;
            this.listBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBox3.ForeColor = System.Drawing.Color.Red;
            this.listBox3.Location = new System.Drawing.Point(0, 278);
            this.listBox3.Name = "listBox3";
            this.listBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox3.Size = new System.Drawing.Size(851, 407);
            this.listBox3.TabIndex = 53;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnPowerOff);
            this.groupBox8.Controls.Add(this.btnPowerOn);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.txtPowerMinute);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.txtPowerHour);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Location = new System.Drawing.Point(4, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(223, 82);
            this.groupBox8.TabIndex = 37;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Device Power On and Off";
            // 
            // btnPowerOff
            // 
            this.btnPowerOff.Location = new System.Drawing.Point(104, 42);
            this.btnPowerOff.Name = "btnPowerOff";
            this.btnPowerOff.Size = new System.Drawing.Size(86, 25);
            this.btnPowerOff.TabIndex = 42;
            this.btnPowerOff.Text = "Set Power Off";
            this.btnPowerOff.UseVisualStyleBackColor = false;
            this.btnPowerOff.Click += new System.EventHandler(this.btnPowerOff_Click);
            // 
            // btnPowerOn
            // 
            this.btnPowerOn.Location = new System.Drawing.Point(9, 42);
            this.btnPowerOn.Name = "btnPowerOn";
            this.btnPowerOn.Size = new System.Drawing.Size(89, 25);
            this.btnPowerOn.TabIndex = 34;
            this.btnPowerOn.Text = "Set Power On";
            this.btnPowerOn.UseVisualStyleBackColor = false;
            this.btnPowerOn.Click += new System.EventHandler(this.btnPowerOn_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(170, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = "Minute";
            // 
            // txtPowerMinute
            // 
            this.txtPowerMinute.AcceptsReturn = true;
            this.txtPowerMinute.Location = new System.Drawing.Point(144, 16);
            this.txtPowerMinute.MaxLength = 0;
            this.txtPowerMinute.Name = "txtPowerMinute";
            this.txtPowerMinute.Size = new System.Drawing.Size(25, 20);
            this.txtPowerMinute.TabIndex = 28;
            this.txtPowerMinute.Text = "00";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(92, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 17);
            this.label12.TabIndex = 41;
            this.label12.Text = "Hour";
            // 
            // txtPowerHour
            // 
            this.txtPowerHour.AcceptsReturn = true;
            this.txtPowerHour.Location = new System.Drawing.Point(66, 16);
            this.txtPowerHour.MaxLength = 0;
            this.txtPowerHour.Name = "txtPowerHour";
            this.txtPowerHour.Size = new System.Drawing.Size(25, 20);
            this.txtPowerHour.TabIndex = 29;
            this.txtPowerHour.Text = "00";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "Time";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.groupBox19);
            this.tabPage6.Controls.Add(this.groupBox16);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(851, 685);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Access Control";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.label99);
            this.groupBox19.Controls.Add(this.label98);
            this.groupBox19.Controls.Add(this.txtHolidayParamId);
            this.groupBox19.Controls.Add(this.label97);
            this.groupBox19.Controls.Add(this.label96);
            this.groupBox19.Controls.Add(this.label95);
            this.groupBox19.Controls.Add(this.label94);
            this.groupBox19.Controls.Add(this.label93);
            this.groupBox19.Controls.Add(this.btnSetHolidayParam);
            this.groupBox19.Controls.Add(this.txtStartDay);
            this.groupBox19.Controls.Add(this.btnGetHolidayParam);
            this.groupBox19.Controls.Add(this.txtEndMonth);
            this.groupBox19.Controls.Add(this.txtEndDay);
            this.groupBox19.Controls.Add(this.txtTZHolidayParam);
            this.groupBox19.Controls.Add(this.txtStartMonth);
            this.groupBox19.Location = new System.Drawing.Point(0, 376);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(467, 100);
            this.groupBox19.TabIndex = 1;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "GetHolidayParam";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(11, 23);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(123, 13);
            this.label99.TabIndex = 225;
            this.label99.Text = "For Black and White";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(262, 46);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(51, 13);
            this.label98.TabIndex = 224;
            this.label98.Text = "holidayID";
            // 
            // txtHolidayParamId
            // 
            this.txtHolidayParamId.Location = new System.Drawing.Point(267, 62);
            this.txtHolidayParamId.Name = "txtHolidayParamId";
            this.txtHolidayParamId.Size = new System.Drawing.Size(38, 20);
            this.txtHolidayParamId.TabIndex = 223;
            this.txtHolidayParamId.Text = "1";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(209, 46);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(55, 13);
            this.label97.TabIndex = 222;
            this.label97.Text = "TimeZone";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(163, 46);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(45, 13);
            this.label96.TabIndex = 222;
            this.label96.Text = "EndDay";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(108, 46);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(56, 13);
            this.label95.TabIndex = 222;
            this.label95.Text = "EndMonth";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(62, 46);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(48, 13);
            this.label94.TabIndex = 222;
            this.label94.Text = "StartDay";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(3, 46);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(59, 13);
            this.label93.TabIndex = 221;
            this.label93.Text = "StartMonth";
            // 
            // btnSetHolidayParam
            // 
            this.btnSetHolidayParam.Location = new System.Drawing.Point(389, 60);
            this.btnSetHolidayParam.Name = "btnSetHolidayParam";
            this.btnSetHolidayParam.Size = new System.Drawing.Size(67, 23);
            this.btnSetHolidayParam.TabIndex = 220;
            this.btnSetHolidayParam.Text = "SET";
            this.btnSetHolidayParam.UseVisualStyleBackColor = true;
            this.btnSetHolidayParam.Click += new System.EventHandler(this.btnSetHolidayParam_Click);
            // 
            // txtStartDay
            // 
            this.txtStartDay.Location = new System.Drawing.Point(64, 62);
            this.txtStartDay.Name = "txtStartDay";
            this.txtStartDay.Size = new System.Drawing.Size(38, 20);
            this.txtStartDay.TabIndex = 4;
            this.txtStartDay.Text = "1";
            // 
            // btnGetHolidayParam
            // 
            this.btnGetHolidayParam.Location = new System.Drawing.Point(315, 60);
            this.btnGetHolidayParam.Name = "btnGetHolidayParam";
            this.btnGetHolidayParam.Size = new System.Drawing.Size(68, 23);
            this.btnGetHolidayParam.TabIndex = 219;
            this.btnGetHolidayParam.Text = "GET";
            this.btnGetHolidayParam.UseVisualStyleBackColor = true;
            this.btnGetHolidayParam.Click += new System.EventHandler(this.btnGetHolidayParam_Click);
            // 
            // txtEndMonth
            // 
            this.txtEndMonth.Location = new System.Drawing.Point(115, 62);
            this.txtEndMonth.Name = "txtEndMonth";
            this.txtEndMonth.Size = new System.Drawing.Size(38, 20);
            this.txtEndMonth.TabIndex = 3;
            this.txtEndMonth.Text = "1";
            // 
            // txtEndDay
            // 
            this.txtEndDay.Location = new System.Drawing.Point(166, 62);
            this.txtEndDay.Name = "txtEndDay";
            this.txtEndDay.Size = new System.Drawing.Size(38, 20);
            this.txtEndDay.TabIndex = 2;
            this.txtEndDay.Text = "1";
            // 
            // txtTZHolidayParam
            // 
            this.txtTZHolidayParam.Location = new System.Drawing.Point(217, 62);
            this.txtTZHolidayParam.Name = "txtTZHolidayParam";
            this.txtTZHolidayParam.Size = new System.Drawing.Size(38, 20);
            this.txtTZHolidayParam.TabIndex = 1;
            this.txtTZHolidayParam.Text = "1";
            // 
            // txtStartMonth
            // 
            this.txtStartMonth.Location = new System.Drawing.Point(11, 62);
            this.txtStartMonth.Name = "txtStartMonth";
            this.txtStartMonth.Size = new System.Drawing.Size(38, 20);
            this.txtStartMonth.TabIndex = 0;
            this.txtStartMonth.Text = "1";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.btnSetEveryWeekTimezone);
            this.groupBox16.Controls.Add(this.btnGetEveryWeekTimezone);
            this.groupBox16.Controls.Add(this.txtDayOfWeek);
            this.groupBox16.Controls.Add(this.label92);
            this.groupBox16.Controls.Add(this.txtVc50);
            this.groupBox16.Controls.Add(this.txtEt50);
            this.groupBox16.Controls.Add(this.txtSt50);
            this.groupBox16.Controls.Add(this.label79);
            this.groupBox16.Controls.Add(this.txtVc49);
            this.groupBox16.Controls.Add(this.txtEt49);
            this.groupBox16.Controls.Add(this.txtSt49);
            this.groupBox16.Controls.Add(this.label80);
            this.groupBox16.Controls.Add(this.txtVc48);
            this.groupBox16.Controls.Add(this.txtEt48);
            this.groupBox16.Controls.Add(this.txtSt48);
            this.groupBox16.Controls.Add(this.label81);
            this.groupBox16.Controls.Add(this.txtVc47);
            this.groupBox16.Controls.Add(this.txtEt47);
            this.groupBox16.Controls.Add(this.txtSt47);
            this.groupBox16.Controls.Add(this.label82);
            this.groupBox16.Controls.Add(this.txtVc46);
            this.groupBox16.Controls.Add(this.txtEt46);
            this.groupBox16.Controls.Add(this.txtSt46);
            this.groupBox16.Controls.Add(this.label83);
            this.groupBox16.Controls.Add(this.txtVc45);
            this.groupBox16.Controls.Add(this.txtEt45);
            this.groupBox16.Controls.Add(this.txtSt45);
            this.groupBox16.Controls.Add(this.label84);
            this.groupBox16.Controls.Add(this.txtVc44);
            this.groupBox16.Controls.Add(this.txtEt44);
            this.groupBox16.Controls.Add(this.txtSt44);
            this.groupBox16.Controls.Add(this.label85);
            this.groupBox16.Controls.Add(this.txtVc43);
            this.groupBox16.Controls.Add(this.txtEt43);
            this.groupBox16.Controls.Add(this.txtSt43);
            this.groupBox16.Controls.Add(this.label86);
            this.groupBox16.Controls.Add(this.txtVc42);
            this.groupBox16.Controls.Add(this.txtEt42);
            this.groupBox16.Controls.Add(this.txtSt42);
            this.groupBox16.Controls.Add(this.label87);
            this.groupBox16.Controls.Add(this.label88);
            this.groupBox16.Controls.Add(this.label89);
            this.groupBox16.Controls.Add(this.label90);
            this.groupBox16.Controls.Add(this.txtVc41);
            this.groupBox16.Controls.Add(this.txtEt41);
            this.groupBox16.Controls.Add(this.txtSt41);
            this.groupBox16.Controls.Add(this.label91);
            this.groupBox16.Controls.Add(this.txtVc40);
            this.groupBox16.Controls.Add(this.txtEt40);
            this.groupBox16.Controls.Add(this.txtSt40);
            this.groupBox16.Controls.Add(this.label66);
            this.groupBox16.Controls.Add(this.txtVc39);
            this.groupBox16.Controls.Add(this.txtEt39);
            this.groupBox16.Controls.Add(this.txtSt39);
            this.groupBox16.Controls.Add(this.label67);
            this.groupBox16.Controls.Add(this.txtVc38);
            this.groupBox16.Controls.Add(this.txtEt38);
            this.groupBox16.Controls.Add(this.txtSt38);
            this.groupBox16.Controls.Add(this.label68);
            this.groupBox16.Controls.Add(this.txtVc37);
            this.groupBox16.Controls.Add(this.txtEt37);
            this.groupBox16.Controls.Add(this.txtSt37);
            this.groupBox16.Controls.Add(this.label69);
            this.groupBox16.Controls.Add(this.txtVc36);
            this.groupBox16.Controls.Add(this.txtEt36);
            this.groupBox16.Controls.Add(this.txtSt36);
            this.groupBox16.Controls.Add(this.label70);
            this.groupBox16.Controls.Add(this.txtVc35);
            this.groupBox16.Controls.Add(this.txtEt35);
            this.groupBox16.Controls.Add(this.txtSt35);
            this.groupBox16.Controls.Add(this.label71);
            this.groupBox16.Controls.Add(this.txtVc34);
            this.groupBox16.Controls.Add(this.txtEt34);
            this.groupBox16.Controls.Add(this.txtSt34);
            this.groupBox16.Controls.Add(this.label72);
            this.groupBox16.Controls.Add(this.txtVc33);
            this.groupBox16.Controls.Add(this.txtEt33);
            this.groupBox16.Controls.Add(this.txtSt33);
            this.groupBox16.Controls.Add(this.label73);
            this.groupBox16.Controls.Add(this.txtVc32);
            this.groupBox16.Controls.Add(this.txtEt32);
            this.groupBox16.Controls.Add(this.txtSt32);
            this.groupBox16.Controls.Add(this.label74);
            this.groupBox16.Controls.Add(this.label75);
            this.groupBox16.Controls.Add(this.label76);
            this.groupBox16.Controls.Add(this.label77);
            this.groupBox16.Controls.Add(this.txtVc31);
            this.groupBox16.Controls.Add(this.txtEt31);
            this.groupBox16.Controls.Add(this.txtSt31);
            this.groupBox16.Controls.Add(this.label78);
            this.groupBox16.Controls.Add(this.txtVc30);
            this.groupBox16.Controls.Add(this.txtEt30);
            this.groupBox16.Controls.Add(this.txtSt30);
            this.groupBox16.Controls.Add(this.label53);
            this.groupBox16.Controls.Add(this.txtVc29);
            this.groupBox16.Controls.Add(this.txtEt29);
            this.groupBox16.Controls.Add(this.txtSt29);
            this.groupBox16.Controls.Add(this.label54);
            this.groupBox16.Controls.Add(this.txtVc28);
            this.groupBox16.Controls.Add(this.txtEt28);
            this.groupBox16.Controls.Add(this.txtSt28);
            this.groupBox16.Controls.Add(this.label55);
            this.groupBox16.Controls.Add(this.txtVc27);
            this.groupBox16.Controls.Add(this.txtEt27);
            this.groupBox16.Controls.Add(this.txtSt27);
            this.groupBox16.Controls.Add(this.label56);
            this.groupBox16.Controls.Add(this.txtVc26);
            this.groupBox16.Controls.Add(this.txtEt26);
            this.groupBox16.Controls.Add(this.txtSt26);
            this.groupBox16.Controls.Add(this.label57);
            this.groupBox16.Controls.Add(this.txtVc25);
            this.groupBox16.Controls.Add(this.txtEt25);
            this.groupBox16.Controls.Add(this.txtSt25);
            this.groupBox16.Controls.Add(this.label58);
            this.groupBox16.Controls.Add(this.txtVc24);
            this.groupBox16.Controls.Add(this.txtEt24);
            this.groupBox16.Controls.Add(this.txtSt24);
            this.groupBox16.Controls.Add(this.label59);
            this.groupBox16.Controls.Add(this.txtVc23);
            this.groupBox16.Controls.Add(this.txtEt23);
            this.groupBox16.Controls.Add(this.txtSt23);
            this.groupBox16.Controls.Add(this.label60);
            this.groupBox16.Controls.Add(this.txtVc22);
            this.groupBox16.Controls.Add(this.txtEt22);
            this.groupBox16.Controls.Add(this.txtSt22);
            this.groupBox16.Controls.Add(this.label61);
            this.groupBox16.Controls.Add(this.label62);
            this.groupBox16.Controls.Add(this.label63);
            this.groupBox16.Controls.Add(this.label64);
            this.groupBox16.Controls.Add(this.txtVc21);
            this.groupBox16.Controls.Add(this.txtEt21);
            this.groupBox16.Controls.Add(this.txtSt21);
            this.groupBox16.Controls.Add(this.label65);
            this.groupBox16.Controls.Add(this.txtVc20);
            this.groupBox16.Controls.Add(this.txtEt20);
            this.groupBox16.Controls.Add(this.txtSt20);
            this.groupBox16.Controls.Add(this.label40);
            this.groupBox16.Controls.Add(this.txtVc19);
            this.groupBox16.Controls.Add(this.txtEt19);
            this.groupBox16.Controls.Add(this.txtSt19);
            this.groupBox16.Controls.Add(this.label41);
            this.groupBox16.Controls.Add(this.txtVc18);
            this.groupBox16.Controls.Add(this.txtEt18);
            this.groupBox16.Controls.Add(this.txtSt18);
            this.groupBox16.Controls.Add(this.label42);
            this.groupBox16.Controls.Add(this.txtVc17);
            this.groupBox16.Controls.Add(this.txtEt17);
            this.groupBox16.Controls.Add(this.txtSt17);
            this.groupBox16.Controls.Add(this.label43);
            this.groupBox16.Controls.Add(this.txtVc16);
            this.groupBox16.Controls.Add(this.txtEt16);
            this.groupBox16.Controls.Add(this.txtSt16);
            this.groupBox16.Controls.Add(this.label44);
            this.groupBox16.Controls.Add(this.txtVc15);
            this.groupBox16.Controls.Add(this.txtEt15);
            this.groupBox16.Controls.Add(this.txtSt15);
            this.groupBox16.Controls.Add(this.label45);
            this.groupBox16.Controls.Add(this.txtVc14);
            this.groupBox16.Controls.Add(this.txtEt14);
            this.groupBox16.Controls.Add(this.txtSt14);
            this.groupBox16.Controls.Add(this.label46);
            this.groupBox16.Controls.Add(this.txtVc13);
            this.groupBox16.Controls.Add(this.txtEt13);
            this.groupBox16.Controls.Add(this.txtSt13);
            this.groupBox16.Controls.Add(this.label47);
            this.groupBox16.Controls.Add(this.txtVc12);
            this.groupBox16.Controls.Add(this.txtEt12);
            this.groupBox16.Controls.Add(this.txtSt12);
            this.groupBox16.Controls.Add(this.label48);
            this.groupBox16.Controls.Add(this.label49);
            this.groupBox16.Controls.Add(this.label50);
            this.groupBox16.Controls.Add(this.label51);
            this.groupBox16.Controls.Add(this.txtVc11);
            this.groupBox16.Controls.Add(this.txtEt11);
            this.groupBox16.Controls.Add(this.txtSt11);
            this.groupBox16.Controls.Add(this.label52);
            this.groupBox16.Controls.Add(this.txtVc10);
            this.groupBox16.Controls.Add(this.txtEt10);
            this.groupBox16.Controls.Add(this.txtSt10);
            this.groupBox16.Controls.Add(this.label39);
            this.groupBox16.Controls.Add(this.txtVc9);
            this.groupBox16.Controls.Add(this.txtEt9);
            this.groupBox16.Controls.Add(this.txtSt9);
            this.groupBox16.Controls.Add(this.label38);
            this.groupBox16.Controls.Add(this.txtVc8);
            this.groupBox16.Controls.Add(this.txtEt8);
            this.groupBox16.Controls.Add(this.txtSt8);
            this.groupBox16.Controls.Add(this.label37);
            this.groupBox16.Controls.Add(this.txtVc7);
            this.groupBox16.Controls.Add(this.txtEt7);
            this.groupBox16.Controls.Add(this.txtSt7);
            this.groupBox16.Controls.Add(this.label36);
            this.groupBox16.Controls.Add(this.txtVc6);
            this.groupBox16.Controls.Add(this.txtEt6);
            this.groupBox16.Controls.Add(this.txtSt6);
            this.groupBox16.Controls.Add(this.label35);
            this.groupBox16.Controls.Add(this.txtVc5);
            this.groupBox16.Controls.Add(this.txtEt5);
            this.groupBox16.Controls.Add(this.txtSt5);
            this.groupBox16.Controls.Add(this.label34);
            this.groupBox16.Controls.Add(this.txtVc4);
            this.groupBox16.Controls.Add(this.txtEt4);
            this.groupBox16.Controls.Add(this.txtSt4);
            this.groupBox16.Controls.Add(this.label33);
            this.groupBox16.Controls.Add(this.txtVc3);
            this.groupBox16.Controls.Add(this.txtEt3);
            this.groupBox16.Controls.Add(this.txtSt3);
            this.groupBox16.Controls.Add(this.label32);
            this.groupBox16.Controls.Add(this.txtVc2);
            this.groupBox16.Controls.Add(this.txtEt2);
            this.groupBox16.Controls.Add(this.txtSt2);
            this.groupBox16.Controls.Add(this.label31);
            this.groupBox16.Controls.Add(this.label30);
            this.groupBox16.Controls.Add(this.label29);
            this.groupBox16.Controls.Add(this.label28);
            this.groupBox16.Controls.Add(this.txtVc1);
            this.groupBox16.Controls.Add(this.txtEt1);
            this.groupBox16.Controls.Add(this.txtSt1);
            this.groupBox16.Controls.Add(this.label21);
            this.groupBox16.Location = new System.Drawing.Point(0, 4);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(848, 365);
            this.groupBox16.TabIndex = 0;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "SetEveryWeekTimezone";
            // 
            // btnSetEveryWeekTimezone
            // 
            this.btnSetEveryWeekTimezone.Location = new System.Drawing.Point(221, 326);
            this.btnSetEveryWeekTimezone.Name = "btnSetEveryWeekTimezone";
            this.btnSetEveryWeekTimezone.Size = new System.Drawing.Size(75, 23);
            this.btnSetEveryWeekTimezone.TabIndex = 218;
            this.btnSetEveryWeekTimezone.Text = "SET";
            this.btnSetEveryWeekTimezone.UseVisualStyleBackColor = true;
            this.btnSetEveryWeekTimezone.Click += new System.EventHandler(this.btnSetEveryWeekTimezone_Click);
            // 
            // btnGetEveryWeekTimezone
            // 
            this.btnGetEveryWeekTimezone.Location = new System.Drawing.Point(141, 326);
            this.btnGetEveryWeekTimezone.Name = "btnGetEveryWeekTimezone";
            this.btnGetEveryWeekTimezone.Size = new System.Drawing.Size(75, 23);
            this.btnGetEveryWeekTimezone.TabIndex = 217;
            this.btnGetEveryWeekTimezone.Text = "GET";
            this.btnGetEveryWeekTimezone.UseVisualStyleBackColor = true;
            this.btnGetEveryWeekTimezone.Click += new System.EventHandler(this.btnGetEveryWeekTimezone_Click);
            // 
            // txtDayOfWeek
            // 
            this.txtDayOfWeek.Location = new System.Drawing.Point(81, 328);
            this.txtDayOfWeek.Name = "txtDayOfWeek";
            this.txtDayOfWeek.Size = new System.Drawing.Size(54, 20);
            this.txtDayOfWeek.TabIndex = 216;
            this.txtDayOfWeek.Text = "0";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(7, 331);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(70, 13);
            this.label92.TabIndex = 215;
            this.label92.Text = "Day of Week";
            // 
            // txtVc50
            // 
            this.txtVc50.Location = new System.Drawing.Point(788, 283);
            this.txtVc50.MaxLength = 2;
            this.txtVc50.Name = "txtVc50";
            this.txtVc50.Size = new System.Drawing.Size(38, 20);
            this.txtVc50.TabIndex = 214;
            this.txtVc50.Text = "00";
            // 
            // txtEt50
            // 
            this.txtEt50.Location = new System.Drawing.Point(744, 283);
            this.txtEt50.MaxLength = 4;
            this.txtEt50.Name = "txtEt50";
            this.txtEt50.Size = new System.Drawing.Size(38, 20);
            this.txtEt50.TabIndex = 213;
            this.txtEt50.Text = "0000";
            // 
            // txtSt50
            // 
            this.txtSt50.Location = new System.Drawing.Point(700, 283);
            this.txtSt50.MaxLength = 4;
            this.txtSt50.Name = "txtSt50";
            this.txtSt50.Size = new System.Drawing.Size(38, 20);
            this.txtSt50.TabIndex = 212;
            this.txtSt50.Text = "0000";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(668, 287);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(33, 13);
            this.label79.TabIndex = 211;
            this.label79.Text = "TZ50";
            // 
            // txtVc49
            // 
            this.txtVc49.Location = new System.Drawing.Point(788, 257);
            this.txtVc49.MaxLength = 2;
            this.txtVc49.Name = "txtVc49";
            this.txtVc49.Size = new System.Drawing.Size(38, 20);
            this.txtVc49.TabIndex = 210;
            this.txtVc49.Text = "00";
            // 
            // txtEt49
            // 
            this.txtEt49.Location = new System.Drawing.Point(744, 257);
            this.txtEt49.MaxLength = 4;
            this.txtEt49.Name = "txtEt49";
            this.txtEt49.Size = new System.Drawing.Size(38, 20);
            this.txtEt49.TabIndex = 209;
            this.txtEt49.Text = "0000";
            // 
            // txtSt49
            // 
            this.txtSt49.Location = new System.Drawing.Point(700, 257);
            this.txtSt49.MaxLength = 4;
            this.txtSt49.Name = "txtSt49";
            this.txtSt49.Size = new System.Drawing.Size(38, 20);
            this.txtSt49.TabIndex = 208;
            this.txtSt49.Text = "0000";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(668, 261);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(33, 13);
            this.label80.TabIndex = 207;
            this.label80.Text = "TZ49";
            // 
            // txtVc48
            // 
            this.txtVc48.Location = new System.Drawing.Point(788, 231);
            this.txtVc48.MaxLength = 2;
            this.txtVc48.Name = "txtVc48";
            this.txtVc48.Size = new System.Drawing.Size(38, 20);
            this.txtVc48.TabIndex = 206;
            this.txtVc48.Text = "00";
            // 
            // txtEt48
            // 
            this.txtEt48.Location = new System.Drawing.Point(744, 231);
            this.txtEt48.MaxLength = 4;
            this.txtEt48.Name = "txtEt48";
            this.txtEt48.Size = new System.Drawing.Size(38, 20);
            this.txtEt48.TabIndex = 205;
            this.txtEt48.Text = "0000";
            // 
            // txtSt48
            // 
            this.txtSt48.Location = new System.Drawing.Point(700, 231);
            this.txtSt48.MaxLength = 4;
            this.txtSt48.Name = "txtSt48";
            this.txtSt48.Size = new System.Drawing.Size(38, 20);
            this.txtSt48.TabIndex = 204;
            this.txtSt48.Text = "0000";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(668, 235);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(33, 13);
            this.label81.TabIndex = 203;
            this.label81.Text = "TZ48";
            // 
            // txtVc47
            // 
            this.txtVc47.Location = new System.Drawing.Point(788, 205);
            this.txtVc47.MaxLength = 2;
            this.txtVc47.Name = "txtVc47";
            this.txtVc47.Size = new System.Drawing.Size(38, 20);
            this.txtVc47.TabIndex = 202;
            this.txtVc47.Text = "00";
            // 
            // txtEt47
            // 
            this.txtEt47.Location = new System.Drawing.Point(744, 205);
            this.txtEt47.MaxLength = 4;
            this.txtEt47.Name = "txtEt47";
            this.txtEt47.Size = new System.Drawing.Size(38, 20);
            this.txtEt47.TabIndex = 201;
            this.txtEt47.Text = "0000";
            // 
            // txtSt47
            // 
            this.txtSt47.Location = new System.Drawing.Point(700, 205);
            this.txtSt47.MaxLength = 4;
            this.txtSt47.Name = "txtSt47";
            this.txtSt47.Size = new System.Drawing.Size(38, 20);
            this.txtSt47.TabIndex = 200;
            this.txtSt47.Text = "0000";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(668, 209);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(33, 13);
            this.label82.TabIndex = 199;
            this.label82.Text = "TZ47";
            // 
            // txtVc46
            // 
            this.txtVc46.Location = new System.Drawing.Point(788, 179);
            this.txtVc46.MaxLength = 2;
            this.txtVc46.Name = "txtVc46";
            this.txtVc46.Size = new System.Drawing.Size(38, 20);
            this.txtVc46.TabIndex = 198;
            this.txtVc46.Text = "00";
            // 
            // txtEt46
            // 
            this.txtEt46.Location = new System.Drawing.Point(744, 179);
            this.txtEt46.MaxLength = 4;
            this.txtEt46.Name = "txtEt46";
            this.txtEt46.Size = new System.Drawing.Size(38, 20);
            this.txtEt46.TabIndex = 197;
            this.txtEt46.Text = "0000";
            // 
            // txtSt46
            // 
            this.txtSt46.Location = new System.Drawing.Point(700, 179);
            this.txtSt46.MaxLength = 4;
            this.txtSt46.Name = "txtSt46";
            this.txtSt46.Size = new System.Drawing.Size(38, 20);
            this.txtSt46.TabIndex = 196;
            this.txtSt46.Text = "0000";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(668, 183);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(33, 13);
            this.label83.TabIndex = 195;
            this.label83.Text = "TZ46";
            // 
            // txtVc45
            // 
            this.txtVc45.Location = new System.Drawing.Point(788, 153);
            this.txtVc45.MaxLength = 2;
            this.txtVc45.Name = "txtVc45";
            this.txtVc45.Size = new System.Drawing.Size(38, 20);
            this.txtVc45.TabIndex = 194;
            this.txtVc45.Text = "00";
            // 
            // txtEt45
            // 
            this.txtEt45.Location = new System.Drawing.Point(744, 153);
            this.txtEt45.MaxLength = 4;
            this.txtEt45.Name = "txtEt45";
            this.txtEt45.Size = new System.Drawing.Size(38, 20);
            this.txtEt45.TabIndex = 193;
            this.txtEt45.Text = "0000";
            // 
            // txtSt45
            // 
            this.txtSt45.Location = new System.Drawing.Point(700, 153);
            this.txtSt45.MaxLength = 4;
            this.txtSt45.Name = "txtSt45";
            this.txtSt45.Size = new System.Drawing.Size(38, 20);
            this.txtSt45.TabIndex = 192;
            this.txtSt45.Text = "0000";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(668, 157);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(33, 13);
            this.label84.TabIndex = 191;
            this.label84.Text = "TZ45";
            // 
            // txtVc44
            // 
            this.txtVc44.Location = new System.Drawing.Point(788, 127);
            this.txtVc44.MaxLength = 2;
            this.txtVc44.Name = "txtVc44";
            this.txtVc44.Size = new System.Drawing.Size(38, 20);
            this.txtVc44.TabIndex = 190;
            this.txtVc44.Text = "00";
            // 
            // txtEt44
            // 
            this.txtEt44.Location = new System.Drawing.Point(744, 127);
            this.txtEt44.MaxLength = 4;
            this.txtEt44.Name = "txtEt44";
            this.txtEt44.Size = new System.Drawing.Size(38, 20);
            this.txtEt44.TabIndex = 189;
            this.txtEt44.Text = "0000";
            // 
            // txtSt44
            // 
            this.txtSt44.Location = new System.Drawing.Point(700, 127);
            this.txtSt44.MaxLength = 4;
            this.txtSt44.Name = "txtSt44";
            this.txtSt44.Size = new System.Drawing.Size(38, 20);
            this.txtSt44.TabIndex = 188;
            this.txtSt44.Text = "0000";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(668, 131);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(33, 13);
            this.label85.TabIndex = 187;
            this.label85.Text = "TZ44";
            // 
            // txtVc43
            // 
            this.txtVc43.Location = new System.Drawing.Point(788, 101);
            this.txtVc43.MaxLength = 2;
            this.txtVc43.Name = "txtVc43";
            this.txtVc43.Size = new System.Drawing.Size(38, 20);
            this.txtVc43.TabIndex = 186;
            this.txtVc43.Text = "00";
            // 
            // txtEt43
            // 
            this.txtEt43.Location = new System.Drawing.Point(744, 101);
            this.txtEt43.MaxLength = 4;
            this.txtEt43.Name = "txtEt43";
            this.txtEt43.Size = new System.Drawing.Size(38, 20);
            this.txtEt43.TabIndex = 185;
            this.txtEt43.Text = "0000";
            // 
            // txtSt43
            // 
            this.txtSt43.Location = new System.Drawing.Point(700, 101);
            this.txtSt43.MaxLength = 4;
            this.txtSt43.Name = "txtSt43";
            this.txtSt43.Size = new System.Drawing.Size(38, 20);
            this.txtSt43.TabIndex = 184;
            this.txtSt43.Text = "0000";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(668, 105);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(33, 13);
            this.label86.TabIndex = 183;
            this.label86.Text = "TZ43";
            // 
            // txtVc42
            // 
            this.txtVc42.Location = new System.Drawing.Point(788, 75);
            this.txtVc42.MaxLength = 2;
            this.txtVc42.Name = "txtVc42";
            this.txtVc42.Size = new System.Drawing.Size(38, 20);
            this.txtVc42.TabIndex = 182;
            this.txtVc42.Text = "00";
            // 
            // txtEt42
            // 
            this.txtEt42.Location = new System.Drawing.Point(744, 75);
            this.txtEt42.MaxLength = 4;
            this.txtEt42.Name = "txtEt42";
            this.txtEt42.Size = new System.Drawing.Size(38, 20);
            this.txtEt42.TabIndex = 181;
            this.txtEt42.Text = "0000";
            // 
            // txtSt42
            // 
            this.txtSt42.Location = new System.Drawing.Point(700, 75);
            this.txtSt42.MaxLength = 4;
            this.txtSt42.Name = "txtSt42";
            this.txtSt42.Size = new System.Drawing.Size(38, 20);
            this.txtSt42.TabIndex = 180;
            this.txtSt42.Text = "0000";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(668, 79);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(33, 13);
            this.label87.TabIndex = 179;
            this.label87.Text = "TZ42";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.Location = new System.Drawing.Point(783, 33);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(58, 13);
            this.label88.TabIndex = 178;
            this.label88.Text = "VerifyCode";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.Location = new System.Drawing.Point(739, 33);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(49, 13);
            this.label89.TabIndex = 177;
            this.label89.Text = "EndTime";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.Location = new System.Drawing.Point(691, 33);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(52, 13);
            this.label90.TabIndex = 176;
            this.label90.Text = "StartTime";
            // 
            // txtVc41
            // 
            this.txtVc41.Location = new System.Drawing.Point(788, 49);
            this.txtVc41.MaxLength = 2;
            this.txtVc41.Name = "txtVc41";
            this.txtVc41.Size = new System.Drawing.Size(38, 20);
            this.txtVc41.TabIndex = 175;
            this.txtVc41.Text = "00";
            // 
            // txtEt41
            // 
            this.txtEt41.Location = new System.Drawing.Point(744, 49);
            this.txtEt41.MaxLength = 4;
            this.txtEt41.Name = "txtEt41";
            this.txtEt41.Size = new System.Drawing.Size(38, 20);
            this.txtEt41.TabIndex = 174;
            this.txtEt41.Text = "0000";
            // 
            // txtSt41
            // 
            this.txtSt41.Location = new System.Drawing.Point(700, 49);
            this.txtSt41.MaxLength = 4;
            this.txtSt41.Name = "txtSt41";
            this.txtSt41.Size = new System.Drawing.Size(38, 20);
            this.txtSt41.TabIndex = 173;
            this.txtSt41.Text = "0000";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(668, 53);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(33, 13);
            this.label91.TabIndex = 172;
            this.label91.Text = "TZ41";
            // 
            // txtVc40
            // 
            this.txtVc40.Location = new System.Drawing.Point(624, 283);
            this.txtVc40.MaxLength = 2;
            this.txtVc40.Name = "txtVc40";
            this.txtVc40.Size = new System.Drawing.Size(38, 20);
            this.txtVc40.TabIndex = 171;
            this.txtVc40.Text = "00";
            // 
            // txtEt40
            // 
            this.txtEt40.Location = new System.Drawing.Point(580, 283);
            this.txtEt40.MaxLength = 4;
            this.txtEt40.Name = "txtEt40";
            this.txtEt40.Size = new System.Drawing.Size(38, 20);
            this.txtEt40.TabIndex = 170;
            this.txtEt40.Text = "0000";
            // 
            // txtSt40
            // 
            this.txtSt40.Location = new System.Drawing.Point(536, 283);
            this.txtSt40.MaxLength = 4;
            this.txtSt40.Name = "txtSt40";
            this.txtSt40.Size = new System.Drawing.Size(38, 20);
            this.txtSt40.TabIndex = 169;
            this.txtSt40.Text = "0000";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(504, 287);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(33, 13);
            this.label66.TabIndex = 168;
            this.label66.Text = "TZ40";
            // 
            // txtVc39
            // 
            this.txtVc39.Location = new System.Drawing.Point(624, 257);
            this.txtVc39.MaxLength = 2;
            this.txtVc39.Name = "txtVc39";
            this.txtVc39.Size = new System.Drawing.Size(38, 20);
            this.txtVc39.TabIndex = 167;
            this.txtVc39.Text = "00";
            // 
            // txtEt39
            // 
            this.txtEt39.Location = new System.Drawing.Point(580, 257);
            this.txtEt39.MaxLength = 4;
            this.txtEt39.Name = "txtEt39";
            this.txtEt39.Size = new System.Drawing.Size(38, 20);
            this.txtEt39.TabIndex = 166;
            this.txtEt39.Text = "0000";
            // 
            // txtSt39
            // 
            this.txtSt39.Location = new System.Drawing.Point(536, 257);
            this.txtSt39.MaxLength = 4;
            this.txtSt39.Name = "txtSt39";
            this.txtSt39.Size = new System.Drawing.Size(38, 20);
            this.txtSt39.TabIndex = 165;
            this.txtSt39.Text = "0000";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(504, 261);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(33, 13);
            this.label67.TabIndex = 164;
            this.label67.Text = "TZ39";
            // 
            // txtVc38
            // 
            this.txtVc38.Location = new System.Drawing.Point(624, 231);
            this.txtVc38.MaxLength = 2;
            this.txtVc38.Name = "txtVc38";
            this.txtVc38.Size = new System.Drawing.Size(38, 20);
            this.txtVc38.TabIndex = 163;
            this.txtVc38.Text = "00";
            // 
            // txtEt38
            // 
            this.txtEt38.Location = new System.Drawing.Point(580, 231);
            this.txtEt38.MaxLength = 4;
            this.txtEt38.Name = "txtEt38";
            this.txtEt38.Size = new System.Drawing.Size(38, 20);
            this.txtEt38.TabIndex = 162;
            this.txtEt38.Text = "0000";
            // 
            // txtSt38
            // 
            this.txtSt38.Location = new System.Drawing.Point(536, 231);
            this.txtSt38.MaxLength = 4;
            this.txtSt38.Name = "txtSt38";
            this.txtSt38.Size = new System.Drawing.Size(38, 20);
            this.txtSt38.TabIndex = 161;
            this.txtSt38.Text = "0000";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(504, 235);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(33, 13);
            this.label68.TabIndex = 160;
            this.label68.Text = "TZ38";
            // 
            // txtVc37
            // 
            this.txtVc37.Location = new System.Drawing.Point(624, 205);
            this.txtVc37.MaxLength = 2;
            this.txtVc37.Name = "txtVc37";
            this.txtVc37.Size = new System.Drawing.Size(38, 20);
            this.txtVc37.TabIndex = 159;
            this.txtVc37.Text = "00";
            // 
            // txtEt37
            // 
            this.txtEt37.Location = new System.Drawing.Point(580, 205);
            this.txtEt37.MaxLength = 4;
            this.txtEt37.Name = "txtEt37";
            this.txtEt37.Size = new System.Drawing.Size(38, 20);
            this.txtEt37.TabIndex = 158;
            this.txtEt37.Text = "0000";
            // 
            // txtSt37
            // 
            this.txtSt37.Location = new System.Drawing.Point(536, 205);
            this.txtSt37.MaxLength = 4;
            this.txtSt37.Name = "txtSt37";
            this.txtSt37.Size = new System.Drawing.Size(38, 20);
            this.txtSt37.TabIndex = 157;
            this.txtSt37.Text = "0000";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(504, 209);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(33, 13);
            this.label69.TabIndex = 156;
            this.label69.Text = "TZ37";
            // 
            // txtVc36
            // 
            this.txtVc36.Location = new System.Drawing.Point(624, 179);
            this.txtVc36.MaxLength = 2;
            this.txtVc36.Name = "txtVc36";
            this.txtVc36.Size = new System.Drawing.Size(38, 20);
            this.txtVc36.TabIndex = 155;
            this.txtVc36.Text = "00";
            // 
            // txtEt36
            // 
            this.txtEt36.Location = new System.Drawing.Point(580, 179);
            this.txtEt36.MaxLength = 4;
            this.txtEt36.Name = "txtEt36";
            this.txtEt36.Size = new System.Drawing.Size(38, 20);
            this.txtEt36.TabIndex = 154;
            this.txtEt36.Text = "0000";
            // 
            // txtSt36
            // 
            this.txtSt36.Location = new System.Drawing.Point(536, 179);
            this.txtSt36.MaxLength = 4;
            this.txtSt36.Name = "txtSt36";
            this.txtSt36.Size = new System.Drawing.Size(38, 20);
            this.txtSt36.TabIndex = 153;
            this.txtSt36.Text = "0000";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(504, 183);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(33, 13);
            this.label70.TabIndex = 152;
            this.label70.Text = "TZ36";
            // 
            // txtVc35
            // 
            this.txtVc35.Location = new System.Drawing.Point(624, 153);
            this.txtVc35.MaxLength = 2;
            this.txtVc35.Name = "txtVc35";
            this.txtVc35.Size = new System.Drawing.Size(38, 20);
            this.txtVc35.TabIndex = 151;
            this.txtVc35.Text = "00";
            // 
            // txtEt35
            // 
            this.txtEt35.Location = new System.Drawing.Point(580, 153);
            this.txtEt35.MaxLength = 4;
            this.txtEt35.Name = "txtEt35";
            this.txtEt35.Size = new System.Drawing.Size(38, 20);
            this.txtEt35.TabIndex = 150;
            this.txtEt35.Text = "0000";
            // 
            // txtSt35
            // 
            this.txtSt35.Location = new System.Drawing.Point(536, 153);
            this.txtSt35.MaxLength = 4;
            this.txtSt35.Name = "txtSt35";
            this.txtSt35.Size = new System.Drawing.Size(38, 20);
            this.txtSt35.TabIndex = 149;
            this.txtSt35.Text = "0000";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(504, 157);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(33, 13);
            this.label71.TabIndex = 148;
            this.label71.Text = "TZ35";
            // 
            // txtVc34
            // 
            this.txtVc34.Location = new System.Drawing.Point(624, 127);
            this.txtVc34.MaxLength = 2;
            this.txtVc34.Name = "txtVc34";
            this.txtVc34.Size = new System.Drawing.Size(38, 20);
            this.txtVc34.TabIndex = 147;
            this.txtVc34.Text = "00";
            // 
            // txtEt34
            // 
            this.txtEt34.Location = new System.Drawing.Point(580, 127);
            this.txtEt34.MaxLength = 4;
            this.txtEt34.Name = "txtEt34";
            this.txtEt34.Size = new System.Drawing.Size(38, 20);
            this.txtEt34.TabIndex = 146;
            this.txtEt34.Text = "0000";
            // 
            // txtSt34
            // 
            this.txtSt34.Location = new System.Drawing.Point(536, 127);
            this.txtSt34.MaxLength = 4;
            this.txtSt34.Name = "txtSt34";
            this.txtSt34.Size = new System.Drawing.Size(38, 20);
            this.txtSt34.TabIndex = 145;
            this.txtSt34.Text = "0000";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(504, 131);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(33, 13);
            this.label72.TabIndex = 144;
            this.label72.Text = "TZ34";
            // 
            // txtVc33
            // 
            this.txtVc33.Location = new System.Drawing.Point(624, 101);
            this.txtVc33.MaxLength = 2;
            this.txtVc33.Name = "txtVc33";
            this.txtVc33.Size = new System.Drawing.Size(38, 20);
            this.txtVc33.TabIndex = 143;
            this.txtVc33.Text = "00";
            // 
            // txtEt33
            // 
            this.txtEt33.Location = new System.Drawing.Point(580, 101);
            this.txtEt33.MaxLength = 4;
            this.txtEt33.Name = "txtEt33";
            this.txtEt33.Size = new System.Drawing.Size(38, 20);
            this.txtEt33.TabIndex = 142;
            this.txtEt33.Text = "0000";
            // 
            // txtSt33
            // 
            this.txtSt33.Location = new System.Drawing.Point(536, 101);
            this.txtSt33.MaxLength = 4;
            this.txtSt33.Name = "txtSt33";
            this.txtSt33.Size = new System.Drawing.Size(38, 20);
            this.txtSt33.TabIndex = 141;
            this.txtSt33.Text = "0000";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(504, 105);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(33, 13);
            this.label73.TabIndex = 140;
            this.label73.Text = "TZ33";
            // 
            // txtVc32
            // 
            this.txtVc32.Location = new System.Drawing.Point(624, 75);
            this.txtVc32.MaxLength = 2;
            this.txtVc32.Name = "txtVc32";
            this.txtVc32.Size = new System.Drawing.Size(38, 20);
            this.txtVc32.TabIndex = 139;
            this.txtVc32.Text = "00";
            // 
            // txtEt32
            // 
            this.txtEt32.Location = new System.Drawing.Point(580, 75);
            this.txtEt32.MaxLength = 4;
            this.txtEt32.Name = "txtEt32";
            this.txtEt32.Size = new System.Drawing.Size(38, 20);
            this.txtEt32.TabIndex = 138;
            this.txtEt32.Text = "0000";
            // 
            // txtSt32
            // 
            this.txtSt32.Location = new System.Drawing.Point(536, 75);
            this.txtSt32.MaxLength = 4;
            this.txtSt32.Name = "txtSt32";
            this.txtSt32.Size = new System.Drawing.Size(38, 20);
            this.txtSt32.TabIndex = 137;
            this.txtSt32.Text = "0000";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(504, 79);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(33, 13);
            this.label74.TabIndex = 136;
            this.label74.Text = "TZ32";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(620, 33);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(58, 13);
            this.label75.TabIndex = 135;
            this.label75.Text = "VerifyCode";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.Location = new System.Drawing.Point(575, 33);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(49, 13);
            this.label76.TabIndex = 134;
            this.label76.Text = "EndTime";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.Location = new System.Drawing.Point(527, 33);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(52, 13);
            this.label77.TabIndex = 133;
            this.label77.Text = "StartTime";
            // 
            // txtVc31
            // 
            this.txtVc31.Location = new System.Drawing.Point(624, 49);
            this.txtVc31.MaxLength = 2;
            this.txtVc31.Name = "txtVc31";
            this.txtVc31.Size = new System.Drawing.Size(38, 20);
            this.txtVc31.TabIndex = 132;
            this.txtVc31.Text = "00";
            // 
            // txtEt31
            // 
            this.txtEt31.Location = new System.Drawing.Point(580, 49);
            this.txtEt31.MaxLength = 4;
            this.txtEt31.Name = "txtEt31";
            this.txtEt31.Size = new System.Drawing.Size(38, 20);
            this.txtEt31.TabIndex = 131;
            this.txtEt31.Text = "0000";
            // 
            // txtSt31
            // 
            this.txtSt31.Location = new System.Drawing.Point(536, 49);
            this.txtSt31.MaxLength = 4;
            this.txtSt31.Name = "txtSt31";
            this.txtSt31.Size = new System.Drawing.Size(38, 20);
            this.txtSt31.TabIndex = 130;
            this.txtSt31.Text = "0000";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(504, 53);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(33, 13);
            this.label78.TabIndex = 129;
            this.label78.Text = "TZ31";
            // 
            // txtVc30
            // 
            this.txtVc30.Location = new System.Drawing.Point(462, 283);
            this.txtVc30.MaxLength = 2;
            this.txtVc30.Name = "txtVc30";
            this.txtVc30.Size = new System.Drawing.Size(38, 20);
            this.txtVc30.TabIndex = 128;
            this.txtVc30.Text = "00";
            // 
            // txtEt30
            // 
            this.txtEt30.Location = new System.Drawing.Point(418, 283);
            this.txtEt30.MaxLength = 4;
            this.txtEt30.Name = "txtEt30";
            this.txtEt30.Size = new System.Drawing.Size(38, 20);
            this.txtEt30.TabIndex = 127;
            this.txtEt30.Text = "0000";
            // 
            // txtSt30
            // 
            this.txtSt30.Location = new System.Drawing.Point(374, 283);
            this.txtSt30.MaxLength = 4;
            this.txtSt30.Name = "txtSt30";
            this.txtSt30.Size = new System.Drawing.Size(38, 20);
            this.txtSt30.TabIndex = 126;
            this.txtSt30.Text = "0000";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(342, 287);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(33, 13);
            this.label53.TabIndex = 125;
            this.label53.Text = "TZ30";
            // 
            // txtVc29
            // 
            this.txtVc29.Location = new System.Drawing.Point(462, 257);
            this.txtVc29.MaxLength = 2;
            this.txtVc29.Name = "txtVc29";
            this.txtVc29.Size = new System.Drawing.Size(38, 20);
            this.txtVc29.TabIndex = 124;
            this.txtVc29.Text = "00";
            // 
            // txtEt29
            // 
            this.txtEt29.Location = new System.Drawing.Point(418, 257);
            this.txtEt29.MaxLength = 4;
            this.txtEt29.Name = "txtEt29";
            this.txtEt29.Size = new System.Drawing.Size(38, 20);
            this.txtEt29.TabIndex = 123;
            this.txtEt29.Text = "0000";
            // 
            // txtSt29
            // 
            this.txtSt29.Location = new System.Drawing.Point(374, 257);
            this.txtSt29.MaxLength = 4;
            this.txtSt29.Name = "txtSt29";
            this.txtSt29.Size = new System.Drawing.Size(38, 20);
            this.txtSt29.TabIndex = 122;
            this.txtSt29.Text = "0000";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(342, 261);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(33, 13);
            this.label54.TabIndex = 121;
            this.label54.Text = "TZ29";
            // 
            // txtVc28
            // 
            this.txtVc28.Location = new System.Drawing.Point(462, 231);
            this.txtVc28.MaxLength = 2;
            this.txtVc28.Name = "txtVc28";
            this.txtVc28.Size = new System.Drawing.Size(38, 20);
            this.txtVc28.TabIndex = 120;
            this.txtVc28.Text = "00";
            // 
            // txtEt28
            // 
            this.txtEt28.Location = new System.Drawing.Point(418, 231);
            this.txtEt28.MaxLength = 4;
            this.txtEt28.Name = "txtEt28";
            this.txtEt28.Size = new System.Drawing.Size(38, 20);
            this.txtEt28.TabIndex = 119;
            this.txtEt28.Text = "0000";
            // 
            // txtSt28
            // 
            this.txtSt28.Location = new System.Drawing.Point(374, 231);
            this.txtSt28.MaxLength = 4;
            this.txtSt28.Name = "txtSt28";
            this.txtSt28.Size = new System.Drawing.Size(38, 20);
            this.txtSt28.TabIndex = 118;
            this.txtSt28.Text = "0000";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(342, 235);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(33, 13);
            this.label55.TabIndex = 117;
            this.label55.Text = "TZ28";
            // 
            // txtVc27
            // 
            this.txtVc27.Location = new System.Drawing.Point(462, 205);
            this.txtVc27.MaxLength = 2;
            this.txtVc27.Name = "txtVc27";
            this.txtVc27.Size = new System.Drawing.Size(38, 20);
            this.txtVc27.TabIndex = 116;
            this.txtVc27.Text = "00";
            // 
            // txtEt27
            // 
            this.txtEt27.Location = new System.Drawing.Point(418, 205);
            this.txtEt27.MaxLength = 4;
            this.txtEt27.Name = "txtEt27";
            this.txtEt27.Size = new System.Drawing.Size(38, 20);
            this.txtEt27.TabIndex = 115;
            this.txtEt27.Text = "0000";
            // 
            // txtSt27
            // 
            this.txtSt27.Location = new System.Drawing.Point(374, 205);
            this.txtSt27.MaxLength = 4;
            this.txtSt27.Name = "txtSt27";
            this.txtSt27.Size = new System.Drawing.Size(38, 20);
            this.txtSt27.TabIndex = 114;
            this.txtSt27.Text = "0000";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(342, 209);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(33, 13);
            this.label56.TabIndex = 113;
            this.label56.Text = "TZ27";
            // 
            // txtVc26
            // 
            this.txtVc26.Location = new System.Drawing.Point(462, 179);
            this.txtVc26.MaxLength = 2;
            this.txtVc26.Name = "txtVc26";
            this.txtVc26.Size = new System.Drawing.Size(38, 20);
            this.txtVc26.TabIndex = 112;
            this.txtVc26.Text = "00";
            // 
            // txtEt26
            // 
            this.txtEt26.Location = new System.Drawing.Point(418, 179);
            this.txtEt26.MaxLength = 4;
            this.txtEt26.Name = "txtEt26";
            this.txtEt26.Size = new System.Drawing.Size(38, 20);
            this.txtEt26.TabIndex = 111;
            this.txtEt26.Text = "0000";
            // 
            // txtSt26
            // 
            this.txtSt26.Location = new System.Drawing.Point(374, 179);
            this.txtSt26.MaxLength = 4;
            this.txtSt26.Name = "txtSt26";
            this.txtSt26.Size = new System.Drawing.Size(38, 20);
            this.txtSt26.TabIndex = 110;
            this.txtSt26.Text = "0000";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(342, 183);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(33, 13);
            this.label57.TabIndex = 109;
            this.label57.Text = "TZ26";
            // 
            // txtVc25
            // 
            this.txtVc25.Location = new System.Drawing.Point(462, 153);
            this.txtVc25.MaxLength = 2;
            this.txtVc25.Name = "txtVc25";
            this.txtVc25.Size = new System.Drawing.Size(38, 20);
            this.txtVc25.TabIndex = 108;
            this.txtVc25.Text = "00";
            // 
            // txtEt25
            // 
            this.txtEt25.Location = new System.Drawing.Point(418, 153);
            this.txtEt25.MaxLength = 4;
            this.txtEt25.Name = "txtEt25";
            this.txtEt25.Size = new System.Drawing.Size(38, 20);
            this.txtEt25.TabIndex = 107;
            this.txtEt25.Text = "0000";
            // 
            // txtSt25
            // 
            this.txtSt25.Location = new System.Drawing.Point(374, 153);
            this.txtSt25.MaxLength = 4;
            this.txtSt25.Name = "txtSt25";
            this.txtSt25.Size = new System.Drawing.Size(38, 20);
            this.txtSt25.TabIndex = 106;
            this.txtSt25.Text = "0000";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(342, 157);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(33, 13);
            this.label58.TabIndex = 105;
            this.label58.Text = "TZ25";
            // 
            // txtVc24
            // 
            this.txtVc24.Location = new System.Drawing.Point(462, 127);
            this.txtVc24.MaxLength = 2;
            this.txtVc24.Name = "txtVc24";
            this.txtVc24.Size = new System.Drawing.Size(38, 20);
            this.txtVc24.TabIndex = 104;
            this.txtVc24.Text = "00";
            // 
            // txtEt24
            // 
            this.txtEt24.Location = new System.Drawing.Point(418, 127);
            this.txtEt24.MaxLength = 4;
            this.txtEt24.Name = "txtEt24";
            this.txtEt24.Size = new System.Drawing.Size(38, 20);
            this.txtEt24.TabIndex = 103;
            this.txtEt24.Text = "0000";
            // 
            // txtSt24
            // 
            this.txtSt24.Location = new System.Drawing.Point(374, 127);
            this.txtSt24.MaxLength = 4;
            this.txtSt24.Name = "txtSt24";
            this.txtSt24.Size = new System.Drawing.Size(38, 20);
            this.txtSt24.TabIndex = 102;
            this.txtSt24.Text = "0000";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(342, 131);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(33, 13);
            this.label59.TabIndex = 101;
            this.label59.Text = "TZ24";
            // 
            // txtVc23
            // 
            this.txtVc23.Location = new System.Drawing.Point(462, 101);
            this.txtVc23.MaxLength = 2;
            this.txtVc23.Name = "txtVc23";
            this.txtVc23.Size = new System.Drawing.Size(38, 20);
            this.txtVc23.TabIndex = 100;
            this.txtVc23.Text = "00";
            // 
            // txtEt23
            // 
            this.txtEt23.Location = new System.Drawing.Point(418, 101);
            this.txtEt23.MaxLength = 4;
            this.txtEt23.Name = "txtEt23";
            this.txtEt23.Size = new System.Drawing.Size(38, 20);
            this.txtEt23.TabIndex = 99;
            this.txtEt23.Text = "0000";
            // 
            // txtSt23
            // 
            this.txtSt23.Location = new System.Drawing.Point(374, 101);
            this.txtSt23.MaxLength = 4;
            this.txtSt23.Name = "txtSt23";
            this.txtSt23.Size = new System.Drawing.Size(38, 20);
            this.txtSt23.TabIndex = 98;
            this.txtSt23.Text = "0000";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(342, 105);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(33, 13);
            this.label60.TabIndex = 97;
            this.label60.Text = "TZ23";
            // 
            // txtVc22
            // 
            this.txtVc22.Location = new System.Drawing.Point(462, 75);
            this.txtVc22.MaxLength = 2;
            this.txtVc22.Name = "txtVc22";
            this.txtVc22.Size = new System.Drawing.Size(38, 20);
            this.txtVc22.TabIndex = 96;
            this.txtVc22.Text = "00";
            // 
            // txtEt22
            // 
            this.txtEt22.Location = new System.Drawing.Point(418, 75);
            this.txtEt22.MaxLength = 4;
            this.txtEt22.Name = "txtEt22";
            this.txtEt22.Size = new System.Drawing.Size(38, 20);
            this.txtEt22.TabIndex = 95;
            this.txtEt22.Text = "0000";
            // 
            // txtSt22
            // 
            this.txtSt22.Location = new System.Drawing.Point(374, 75);
            this.txtSt22.MaxLength = 4;
            this.txtSt22.Name = "txtSt22";
            this.txtSt22.Size = new System.Drawing.Size(38, 20);
            this.txtSt22.TabIndex = 94;
            this.txtSt22.Text = "0000";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(342, 79);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(33, 13);
            this.label61.TabIndex = 93;
            this.label61.Text = "TZ22";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(458, 33);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(58, 13);
            this.label62.TabIndex = 92;
            this.label62.Text = "VerifyCode";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(414, 33);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(49, 13);
            this.label63.TabIndex = 91;
            this.label63.Text = "EndTime";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(366, 33);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(52, 13);
            this.label64.TabIndex = 90;
            this.label64.Text = "StartTime";
            // 
            // txtVc21
            // 
            this.txtVc21.Location = new System.Drawing.Point(462, 49);
            this.txtVc21.MaxLength = 2;
            this.txtVc21.Name = "txtVc21";
            this.txtVc21.Size = new System.Drawing.Size(38, 20);
            this.txtVc21.TabIndex = 89;
            this.txtVc21.Text = "00";
            // 
            // txtEt21
            // 
            this.txtEt21.Location = new System.Drawing.Point(418, 49);
            this.txtEt21.MaxLength = 4;
            this.txtEt21.Name = "txtEt21";
            this.txtEt21.Size = new System.Drawing.Size(38, 20);
            this.txtEt21.TabIndex = 88;
            this.txtEt21.Text = "0000";
            // 
            // txtSt21
            // 
            this.txtSt21.Location = new System.Drawing.Point(374, 49);
            this.txtSt21.MaxLength = 4;
            this.txtSt21.Name = "txtSt21";
            this.txtSt21.Size = new System.Drawing.Size(38, 20);
            this.txtSt21.TabIndex = 87;
            this.txtSt21.Text = "0000";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(342, 53);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(33, 13);
            this.label65.TabIndex = 86;
            this.label65.Text = "TZ21";
            // 
            // txtVc20
            // 
            this.txtVc20.Location = new System.Drawing.Point(296, 284);
            this.txtVc20.MaxLength = 2;
            this.txtVc20.Name = "txtVc20";
            this.txtVc20.Size = new System.Drawing.Size(38, 20);
            this.txtVc20.TabIndex = 85;
            this.txtVc20.Text = "00";
            // 
            // txtEt20
            // 
            this.txtEt20.Location = new System.Drawing.Point(252, 284);
            this.txtEt20.MaxLength = 4;
            this.txtEt20.Name = "txtEt20";
            this.txtEt20.Size = new System.Drawing.Size(38, 20);
            this.txtEt20.TabIndex = 84;
            this.txtEt20.Text = "0000";
            // 
            // txtSt20
            // 
            this.txtSt20.Location = new System.Drawing.Point(208, 284);
            this.txtSt20.MaxLength = 4;
            this.txtSt20.Name = "txtSt20";
            this.txtSt20.Size = new System.Drawing.Size(38, 20);
            this.txtSt20.TabIndex = 83;
            this.txtSt20.Text = "0000";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(176, 288);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(33, 13);
            this.label40.TabIndex = 82;
            this.label40.Text = "TZ20";
            // 
            // txtVc19
            // 
            this.txtVc19.Location = new System.Drawing.Point(296, 258);
            this.txtVc19.MaxLength = 2;
            this.txtVc19.Name = "txtVc19";
            this.txtVc19.Size = new System.Drawing.Size(38, 20);
            this.txtVc19.TabIndex = 81;
            this.txtVc19.Text = "00";
            // 
            // txtEt19
            // 
            this.txtEt19.Location = new System.Drawing.Point(252, 258);
            this.txtEt19.MaxLength = 4;
            this.txtEt19.Name = "txtEt19";
            this.txtEt19.Size = new System.Drawing.Size(38, 20);
            this.txtEt19.TabIndex = 80;
            this.txtEt19.Text = "0000";
            // 
            // txtSt19
            // 
            this.txtSt19.Location = new System.Drawing.Point(208, 258);
            this.txtSt19.MaxLength = 4;
            this.txtSt19.Name = "txtSt19";
            this.txtSt19.Size = new System.Drawing.Size(38, 20);
            this.txtSt19.TabIndex = 79;
            this.txtSt19.Text = "0000";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(176, 262);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(33, 13);
            this.label41.TabIndex = 78;
            this.label41.Text = "TZ19";
            // 
            // txtVc18
            // 
            this.txtVc18.Location = new System.Drawing.Point(296, 232);
            this.txtVc18.MaxLength = 2;
            this.txtVc18.Name = "txtVc18";
            this.txtVc18.Size = new System.Drawing.Size(38, 20);
            this.txtVc18.TabIndex = 77;
            this.txtVc18.Text = "00";
            // 
            // txtEt18
            // 
            this.txtEt18.Location = new System.Drawing.Point(252, 232);
            this.txtEt18.MaxLength = 4;
            this.txtEt18.Name = "txtEt18";
            this.txtEt18.Size = new System.Drawing.Size(38, 20);
            this.txtEt18.TabIndex = 76;
            this.txtEt18.Text = "0000";
            // 
            // txtSt18
            // 
            this.txtSt18.Location = new System.Drawing.Point(208, 232);
            this.txtSt18.MaxLength = 4;
            this.txtSt18.Name = "txtSt18";
            this.txtSt18.Size = new System.Drawing.Size(38, 20);
            this.txtSt18.TabIndex = 75;
            this.txtSt18.Text = "0000";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(176, 236);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(33, 13);
            this.label42.TabIndex = 74;
            this.label42.Text = "TZ18";
            // 
            // txtVc17
            // 
            this.txtVc17.Location = new System.Drawing.Point(296, 206);
            this.txtVc17.MaxLength = 2;
            this.txtVc17.Name = "txtVc17";
            this.txtVc17.Size = new System.Drawing.Size(38, 20);
            this.txtVc17.TabIndex = 73;
            this.txtVc17.Text = "00";
            // 
            // txtEt17
            // 
            this.txtEt17.Location = new System.Drawing.Point(252, 206);
            this.txtEt17.MaxLength = 4;
            this.txtEt17.Name = "txtEt17";
            this.txtEt17.Size = new System.Drawing.Size(38, 20);
            this.txtEt17.TabIndex = 72;
            this.txtEt17.Text = "0000";
            // 
            // txtSt17
            // 
            this.txtSt17.Location = new System.Drawing.Point(208, 206);
            this.txtSt17.MaxLength = 4;
            this.txtSt17.Name = "txtSt17";
            this.txtSt17.Size = new System.Drawing.Size(38, 20);
            this.txtSt17.TabIndex = 71;
            this.txtSt17.Text = "0000";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(176, 210);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(33, 13);
            this.label43.TabIndex = 70;
            this.label43.Text = "TZ17";
            // 
            // txtVc16
            // 
            this.txtVc16.Location = new System.Drawing.Point(296, 180);
            this.txtVc16.MaxLength = 2;
            this.txtVc16.Name = "txtVc16";
            this.txtVc16.Size = new System.Drawing.Size(38, 20);
            this.txtVc16.TabIndex = 69;
            this.txtVc16.Text = "00";
            // 
            // txtEt16
            // 
            this.txtEt16.Location = new System.Drawing.Point(252, 180);
            this.txtEt16.MaxLength = 4;
            this.txtEt16.Name = "txtEt16";
            this.txtEt16.Size = new System.Drawing.Size(38, 20);
            this.txtEt16.TabIndex = 68;
            this.txtEt16.Text = "0000";
            // 
            // txtSt16
            // 
            this.txtSt16.Location = new System.Drawing.Point(208, 180);
            this.txtSt16.MaxLength = 4;
            this.txtSt16.Name = "txtSt16";
            this.txtSt16.Size = new System.Drawing.Size(38, 20);
            this.txtSt16.TabIndex = 67;
            this.txtSt16.Text = "0000";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(176, 184);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(33, 13);
            this.label44.TabIndex = 66;
            this.label44.Text = "TZ16";
            // 
            // txtVc15
            // 
            this.txtVc15.Location = new System.Drawing.Point(296, 154);
            this.txtVc15.MaxLength = 2;
            this.txtVc15.Name = "txtVc15";
            this.txtVc15.Size = new System.Drawing.Size(38, 20);
            this.txtVc15.TabIndex = 65;
            this.txtVc15.Text = "00";
            // 
            // txtEt15
            // 
            this.txtEt15.Location = new System.Drawing.Point(252, 154);
            this.txtEt15.MaxLength = 4;
            this.txtEt15.Name = "txtEt15";
            this.txtEt15.Size = new System.Drawing.Size(38, 20);
            this.txtEt15.TabIndex = 64;
            this.txtEt15.Text = "0000";
            // 
            // txtSt15
            // 
            this.txtSt15.Location = new System.Drawing.Point(208, 154);
            this.txtSt15.MaxLength = 4;
            this.txtSt15.Name = "txtSt15";
            this.txtSt15.Size = new System.Drawing.Size(38, 20);
            this.txtSt15.TabIndex = 63;
            this.txtSt15.Text = "0000";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(176, 158);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(33, 13);
            this.label45.TabIndex = 62;
            this.label45.Text = "TZ15";
            // 
            // txtVc14
            // 
            this.txtVc14.Location = new System.Drawing.Point(296, 128);
            this.txtVc14.MaxLength = 2;
            this.txtVc14.Name = "txtVc14";
            this.txtVc14.Size = new System.Drawing.Size(38, 20);
            this.txtVc14.TabIndex = 61;
            this.txtVc14.Text = "00";
            // 
            // txtEt14
            // 
            this.txtEt14.Location = new System.Drawing.Point(252, 128);
            this.txtEt14.MaxLength = 4;
            this.txtEt14.Name = "txtEt14";
            this.txtEt14.Size = new System.Drawing.Size(38, 20);
            this.txtEt14.TabIndex = 60;
            this.txtEt14.Text = "0000";
            // 
            // txtSt14
            // 
            this.txtSt14.Location = new System.Drawing.Point(208, 128);
            this.txtSt14.MaxLength = 4;
            this.txtSt14.Name = "txtSt14";
            this.txtSt14.Size = new System.Drawing.Size(38, 20);
            this.txtSt14.TabIndex = 59;
            this.txtSt14.Text = "0000";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(176, 132);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(33, 13);
            this.label46.TabIndex = 58;
            this.label46.Text = "TZ14";
            // 
            // txtVc13
            // 
            this.txtVc13.Location = new System.Drawing.Point(296, 102);
            this.txtVc13.MaxLength = 2;
            this.txtVc13.Name = "txtVc13";
            this.txtVc13.Size = new System.Drawing.Size(38, 20);
            this.txtVc13.TabIndex = 57;
            this.txtVc13.Text = "00";
            // 
            // txtEt13
            // 
            this.txtEt13.Location = new System.Drawing.Point(252, 102);
            this.txtEt13.MaxLength = 4;
            this.txtEt13.Name = "txtEt13";
            this.txtEt13.Size = new System.Drawing.Size(38, 20);
            this.txtEt13.TabIndex = 56;
            this.txtEt13.Text = "0000";
            // 
            // txtSt13
            // 
            this.txtSt13.Location = new System.Drawing.Point(208, 102);
            this.txtSt13.MaxLength = 4;
            this.txtSt13.Name = "txtSt13";
            this.txtSt13.Size = new System.Drawing.Size(38, 20);
            this.txtSt13.TabIndex = 55;
            this.txtSt13.Text = "0000";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(176, 106);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(33, 13);
            this.label47.TabIndex = 54;
            this.label47.Text = "TZ13";
            // 
            // txtVc12
            // 
            this.txtVc12.Location = new System.Drawing.Point(296, 76);
            this.txtVc12.MaxLength = 2;
            this.txtVc12.Name = "txtVc12";
            this.txtVc12.Size = new System.Drawing.Size(38, 20);
            this.txtVc12.TabIndex = 53;
            this.txtVc12.Text = "00";
            // 
            // txtEt12
            // 
            this.txtEt12.Location = new System.Drawing.Point(252, 76);
            this.txtEt12.MaxLength = 4;
            this.txtEt12.Name = "txtEt12";
            this.txtEt12.Size = new System.Drawing.Size(38, 20);
            this.txtEt12.TabIndex = 52;
            this.txtEt12.Text = "0000";
            // 
            // txtSt12
            // 
            this.txtSt12.Location = new System.Drawing.Point(208, 76);
            this.txtSt12.MaxLength = 4;
            this.txtSt12.Name = "txtSt12";
            this.txtSt12.Size = new System.Drawing.Size(38, 20);
            this.txtSt12.TabIndex = 51;
            this.txtSt12.Text = "0000";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(176, 80);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(33, 13);
            this.label48.TabIndex = 50;
            this.label48.Text = "TZ12";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(293, 34);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(58, 13);
            this.label49.TabIndex = 49;
            this.label49.Text = "VerifyCode";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(248, 34);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(49, 13);
            this.label50.TabIndex = 48;
            this.label50.Text = "EndTime";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(199, 34);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(52, 13);
            this.label51.TabIndex = 47;
            this.label51.Text = "StartTime";
            // 
            // txtVc11
            // 
            this.txtVc11.Location = new System.Drawing.Point(296, 50);
            this.txtVc11.MaxLength = 2;
            this.txtVc11.Name = "txtVc11";
            this.txtVc11.Size = new System.Drawing.Size(38, 20);
            this.txtVc11.TabIndex = 46;
            this.txtVc11.Text = "00";
            // 
            // txtEt11
            // 
            this.txtEt11.Location = new System.Drawing.Point(252, 50);
            this.txtEt11.MaxLength = 4;
            this.txtEt11.Name = "txtEt11";
            this.txtEt11.Size = new System.Drawing.Size(38, 20);
            this.txtEt11.TabIndex = 45;
            this.txtEt11.Text = "0000";
            // 
            // txtSt11
            // 
            this.txtSt11.Location = new System.Drawing.Point(208, 50);
            this.txtSt11.MaxLength = 4;
            this.txtSt11.Name = "txtSt11";
            this.txtSt11.Size = new System.Drawing.Size(38, 20);
            this.txtSt11.TabIndex = 44;
            this.txtSt11.Text = "0000";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(176, 54);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(33, 13);
            this.label52.TabIndex = 43;
            this.label52.Text = "TZ11";
            // 
            // txtVc10
            // 
            this.txtVc10.Location = new System.Drawing.Point(125, 283);
            this.txtVc10.MaxLength = 2;
            this.txtVc10.Name = "txtVc10";
            this.txtVc10.Size = new System.Drawing.Size(38, 20);
            this.txtVc10.TabIndex = 42;
            this.txtVc10.Text = "00";
            // 
            // txtEt10
            // 
            this.txtEt10.Location = new System.Drawing.Point(81, 283);
            this.txtEt10.MaxLength = 4;
            this.txtEt10.Name = "txtEt10";
            this.txtEt10.Size = new System.Drawing.Size(38, 20);
            this.txtEt10.TabIndex = 41;
            this.txtEt10.Text = "0000";
            // 
            // txtSt10
            // 
            this.txtSt10.Location = new System.Drawing.Point(37, 283);
            this.txtSt10.MaxLength = 4;
            this.txtSt10.Name = "txtSt10";
            this.txtSt10.Size = new System.Drawing.Size(38, 20);
            this.txtSt10.TabIndex = 40;
            this.txtSt10.Text = "0000";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(7, 287);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(33, 13);
            this.label39.TabIndex = 39;
            this.label39.Text = "TZ10";
            // 
            // txtVc9
            // 
            this.txtVc9.Location = new System.Drawing.Point(125, 257);
            this.txtVc9.MaxLength = 2;
            this.txtVc9.Name = "txtVc9";
            this.txtVc9.Size = new System.Drawing.Size(38, 20);
            this.txtVc9.TabIndex = 38;
            this.txtVc9.Text = "00";
            // 
            // txtEt9
            // 
            this.txtEt9.Location = new System.Drawing.Point(81, 257);
            this.txtEt9.MaxLength = 4;
            this.txtEt9.Name = "txtEt9";
            this.txtEt9.Size = new System.Drawing.Size(38, 20);
            this.txtEt9.TabIndex = 37;
            this.txtEt9.Text = "0000";
            // 
            // txtSt9
            // 
            this.txtSt9.Location = new System.Drawing.Point(37, 257);
            this.txtSt9.MaxLength = 4;
            this.txtSt9.Name = "txtSt9";
            this.txtSt9.Size = new System.Drawing.Size(38, 20);
            this.txtSt9.TabIndex = 36;
            this.txtSt9.Text = "0000";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(7, 261);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(27, 13);
            this.label38.TabIndex = 35;
            this.label38.Text = "TZ9";
            // 
            // txtVc8
            // 
            this.txtVc8.Location = new System.Drawing.Point(125, 231);
            this.txtVc8.MaxLength = 2;
            this.txtVc8.Name = "txtVc8";
            this.txtVc8.Size = new System.Drawing.Size(38, 20);
            this.txtVc8.TabIndex = 34;
            this.txtVc8.Text = "00";
            // 
            // txtEt8
            // 
            this.txtEt8.Location = new System.Drawing.Point(81, 231);
            this.txtEt8.MaxLength = 4;
            this.txtEt8.Name = "txtEt8";
            this.txtEt8.Size = new System.Drawing.Size(38, 20);
            this.txtEt8.TabIndex = 33;
            this.txtEt8.Text = "0000";
            // 
            // txtSt8
            // 
            this.txtSt8.Location = new System.Drawing.Point(37, 231);
            this.txtSt8.MaxLength = 4;
            this.txtSt8.Name = "txtSt8";
            this.txtSt8.Size = new System.Drawing.Size(38, 20);
            this.txtSt8.TabIndex = 32;
            this.txtSt8.Text = "0000";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(7, 235);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(27, 13);
            this.label37.TabIndex = 31;
            this.label37.Text = "TZ8";
            // 
            // txtVc7
            // 
            this.txtVc7.Location = new System.Drawing.Point(125, 205);
            this.txtVc7.MaxLength = 2;
            this.txtVc7.Name = "txtVc7";
            this.txtVc7.Size = new System.Drawing.Size(38, 20);
            this.txtVc7.TabIndex = 30;
            this.txtVc7.Text = "00";
            // 
            // txtEt7
            // 
            this.txtEt7.Location = new System.Drawing.Point(81, 205);
            this.txtEt7.MaxLength = 4;
            this.txtEt7.Name = "txtEt7";
            this.txtEt7.Size = new System.Drawing.Size(38, 20);
            this.txtEt7.TabIndex = 29;
            this.txtEt7.Text = "0000";
            // 
            // txtSt7
            // 
            this.txtSt7.Location = new System.Drawing.Point(37, 205);
            this.txtSt7.MaxLength = 4;
            this.txtSt7.Name = "txtSt7";
            this.txtSt7.Size = new System.Drawing.Size(38, 20);
            this.txtSt7.TabIndex = 28;
            this.txtSt7.Text = "0000";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(7, 209);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(27, 13);
            this.label36.TabIndex = 27;
            this.label36.Text = "TZ7";
            // 
            // txtVc6
            // 
            this.txtVc6.Location = new System.Drawing.Point(125, 179);
            this.txtVc6.MaxLength = 2;
            this.txtVc6.Name = "txtVc6";
            this.txtVc6.Size = new System.Drawing.Size(38, 20);
            this.txtVc6.TabIndex = 26;
            this.txtVc6.Text = "00";
            // 
            // txtEt6
            // 
            this.txtEt6.Location = new System.Drawing.Point(81, 179);
            this.txtEt6.MaxLength = 4;
            this.txtEt6.Name = "txtEt6";
            this.txtEt6.Size = new System.Drawing.Size(38, 20);
            this.txtEt6.TabIndex = 25;
            this.txtEt6.Text = "0000";
            // 
            // txtSt6
            // 
            this.txtSt6.Location = new System.Drawing.Point(37, 179);
            this.txtSt6.MaxLength = 4;
            this.txtSt6.Name = "txtSt6";
            this.txtSt6.Size = new System.Drawing.Size(38, 20);
            this.txtSt6.TabIndex = 24;
            this.txtSt6.Text = "0000";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(7, 183);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(27, 13);
            this.label35.TabIndex = 23;
            this.label35.Text = "TZ6";
            // 
            // txtVc5
            // 
            this.txtVc5.Location = new System.Drawing.Point(125, 153);
            this.txtVc5.MaxLength = 2;
            this.txtVc5.Name = "txtVc5";
            this.txtVc5.Size = new System.Drawing.Size(38, 20);
            this.txtVc5.TabIndex = 22;
            this.txtVc5.Text = "00";
            // 
            // txtEt5
            // 
            this.txtEt5.Location = new System.Drawing.Point(81, 153);
            this.txtEt5.MaxLength = 4;
            this.txtEt5.Name = "txtEt5";
            this.txtEt5.Size = new System.Drawing.Size(38, 20);
            this.txtEt5.TabIndex = 21;
            this.txtEt5.Text = "0000";
            // 
            // txtSt5
            // 
            this.txtSt5.Location = new System.Drawing.Point(37, 153);
            this.txtSt5.MaxLength = 4;
            this.txtSt5.Name = "txtSt5";
            this.txtSt5.Size = new System.Drawing.Size(38, 20);
            this.txtSt5.TabIndex = 20;
            this.txtSt5.Text = "0000";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(7, 157);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(27, 13);
            this.label34.TabIndex = 19;
            this.label34.Text = "TZ5";
            // 
            // txtVc4
            // 
            this.txtVc4.Location = new System.Drawing.Point(125, 127);
            this.txtVc4.MaxLength = 2;
            this.txtVc4.Name = "txtVc4";
            this.txtVc4.Size = new System.Drawing.Size(38, 20);
            this.txtVc4.TabIndex = 18;
            this.txtVc4.Text = "00";
            // 
            // txtEt4
            // 
            this.txtEt4.Location = new System.Drawing.Point(81, 127);
            this.txtEt4.MaxLength = 4;
            this.txtEt4.Name = "txtEt4";
            this.txtEt4.Size = new System.Drawing.Size(38, 20);
            this.txtEt4.TabIndex = 17;
            this.txtEt4.Text = "0000";
            // 
            // txtSt4
            // 
            this.txtSt4.Location = new System.Drawing.Point(37, 127);
            this.txtSt4.MaxLength = 4;
            this.txtSt4.Name = "txtSt4";
            this.txtSt4.Size = new System.Drawing.Size(38, 20);
            this.txtSt4.TabIndex = 16;
            this.txtSt4.Text = "0000";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(7, 131);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(27, 13);
            this.label33.TabIndex = 15;
            this.label33.Text = "TZ4";
            // 
            // txtVc3
            // 
            this.txtVc3.Location = new System.Drawing.Point(125, 101);
            this.txtVc3.MaxLength = 2;
            this.txtVc3.Name = "txtVc3";
            this.txtVc3.Size = new System.Drawing.Size(38, 20);
            this.txtVc3.TabIndex = 14;
            this.txtVc3.Text = "00";
            // 
            // txtEt3
            // 
            this.txtEt3.Location = new System.Drawing.Point(81, 101);
            this.txtEt3.MaxLength = 4;
            this.txtEt3.Name = "txtEt3";
            this.txtEt3.Size = new System.Drawing.Size(38, 20);
            this.txtEt3.TabIndex = 13;
            this.txtEt3.Text = "0000";
            // 
            // txtSt3
            // 
            this.txtSt3.Location = new System.Drawing.Point(37, 101);
            this.txtSt3.MaxLength = 4;
            this.txtSt3.Name = "txtSt3";
            this.txtSt3.Size = new System.Drawing.Size(38, 20);
            this.txtSt3.TabIndex = 12;
            this.txtSt3.Text = "0000";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 105);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(27, 13);
            this.label32.TabIndex = 11;
            this.label32.Text = "TZ3";
            // 
            // txtVc2
            // 
            this.txtVc2.Location = new System.Drawing.Point(125, 75);
            this.txtVc2.MaxLength = 2;
            this.txtVc2.Name = "txtVc2";
            this.txtVc2.Size = new System.Drawing.Size(38, 20);
            this.txtVc2.TabIndex = 10;
            this.txtVc2.Text = "00";
            // 
            // txtEt2
            // 
            this.txtEt2.Location = new System.Drawing.Point(81, 75);
            this.txtEt2.MaxLength = 4;
            this.txtEt2.Name = "txtEt2";
            this.txtEt2.Size = new System.Drawing.Size(38, 20);
            this.txtEt2.TabIndex = 9;
            this.txtEt2.Text = "0000";
            // 
            // txtSt2
            // 
            this.txtSt2.Location = new System.Drawing.Point(37, 75);
            this.txtSt2.MaxLength = 4;
            this.txtSt2.Name = "txtSt2";
            this.txtSt2.Size = new System.Drawing.Size(38, 20);
            this.txtSt2.TabIndex = 8;
            this.txtSt2.Text = "0000";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(7, 79);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(27, 13);
            this.label31.TabIndex = 7;
            this.label31.Text = "TZ2";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(123, 33);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(58, 13);
            this.label30.TabIndex = 6;
            this.label30.Text = "VerifyCode";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(78, 33);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(49, 13);
            this.label29.TabIndex = 5;
            this.label29.Text = "EndTime";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(31, 33);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(52, 13);
            this.label28.TabIndex = 4;
            this.label28.Text = "StartTime";
            // 
            // txtVc1
            // 
            this.txtVc1.Location = new System.Drawing.Point(125, 49);
            this.txtVc1.MaxLength = 2;
            this.txtVc1.Name = "txtVc1";
            this.txtVc1.Size = new System.Drawing.Size(38, 20);
            this.txtVc1.TabIndex = 3;
            this.txtVc1.Text = "00";
            // 
            // txtEt1
            // 
            this.txtEt1.Location = new System.Drawing.Point(81, 49);
            this.txtEt1.MaxLength = 4;
            this.txtEt1.Name = "txtEt1";
            this.txtEt1.Size = new System.Drawing.Size(38, 20);
            this.txtEt1.TabIndex = 2;
            this.txtEt1.Text = "0000";
            // 
            // txtSt1
            // 
            this.txtSt1.Location = new System.Drawing.Point(37, 49);
            this.txtSt1.MaxLength = 4;
            this.txtSt1.Name = "txtSt1";
            this.txtSt1.Size = new System.Drawing.Size(38, 20);
            this.txtSt1.TabIndex = 1;
            this.txtSt1.Text = "0000";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "TZ1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 68);
            this.button2.TabIndex = 139;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 713);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BioBridgeSDK V2.1.028 Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.Frame2.ResumeLayout(false);
            this.Frame2.PerformLayout();
            this.Frame3.ResumeLayout(false);
            this.Frame3.PerformLayout();
            this.Frame4.ResumeLayout(false);
            this.Frame4.PerformLayout();
            this.Frame5.ResumeLayout(false);
            this.Frame5.PerformLayout();
            this.Frame6.ResumeLayout(false);
            this.Frame6.PerformLayout();
            this.Frame7.ResumeLayout(false);
            this.Frame7.PerformLayout();
            this.Frame9.ResumeLayout(false);
            this.Frame9.PerformLayout();
            this.Frame8.ResumeLayout(false);
            this.Frame8.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axBioBridgeSDKv3lib1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox Frame1;
        public System.Windows.Forms.RadioButton rBtnIP;
        public System.Windows.Forms.RadioButton rBtnCOM;
        public System.Windows.Forms.RadioButton rBtnUSB;
        public System.Windows.Forms.Button btnConnect;
        public System.Windows.Forms.Button btnDisconnect;
        public System.Windows.Forms.Button btnSetComm;
        public System.Windows.Forms.Label lblIPAdd;
        public System.Windows.Forms.Button btnRestart;
        public System.Windows.Forms.Button btnAdvance;
        public System.Windows.Forms.Label lblDelay;
        public System.Windows.Forms.Label lblModel;
        public System.Windows.Forms.Label lblBaudRate;
        public System.Windows.Forms.Label lblCommPort;
        public System.Windows.Forms.Label lblCommKey;
        public System.Windows.Forms.Label lblPort;
        public System.Windows.Forms.TextBox txtIPAdd;
        public System.Windows.Forms.Label lblTimeOut;
        public System.Windows.Forms.TextBox txtCommPort;
        public System.Windows.Forms.TextBox txtCommKey;
        public System.Windows.Forms.TextBox txtPort;
        public System.Windows.Forms.TextBox txtDeviceNo;
        public System.Windows.Forms.Label lblDeviceNo;
        public System.Windows.Forms.TextBox txtTimeOut;
        public System.Windows.Forms.TextBox txtDelay;
        public System.Windows.Forms.TextBox txtModel;
        public System.Windows.Forms.TextBox txtBaudRate;
        public System.Windows.Forms.Button btnDisWithTimeOut;
        private System.Windows.Forms.CheckBox chkEnable;
        public System.Windows.Forms.Button btnUnlockDoor;
        public System.Windows.Forms.GroupBox Frame2;
        public System.Windows.Forms.TextBox txtDay;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.TextBox txtYear;
        public System.Windows.Forms.Label lblMonth;
        public System.Windows.Forms.TextBox txtMonth;
        public System.Windows.Forms.Label lblDay;
        public System.Windows.Forms.TextBox txtSecond;
        public System.Windows.Forms.Label lblMinute;
        public System.Windows.Forms.TextBox txtMinute;
        public System.Windows.Forms.Label lblHour;
        public System.Windows.Forms.TextBox txtHour;
        public System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.Button btnSyncTime;
        public System.Windows.Forms.Button btnSetTime;
        public System.Windows.Forms.Button btnGetTime;
        public System.Windows.Forms.Label lblSecond;
        public System.Windows.Forms.GroupBox Frame3;
        public System.Windows.Forms.Button btnClearLog;
        public System.Windows.Forms.Button btnClearUserData;
        public System.Windows.Forms.Button btnReadLog;
        public System.Windows.Forms.Button btnReadUserData;
        public System.Windows.Forms.TextBox txtSetLastCount;
        public System.Windows.Forms.Label lblSetLastCount;
        public System.Windows.Forms.Button btnClearAdmin;
        public System.Windows.Forms.Button btnClearAllFields;
        public System.Windows.Forms.ListBox List1;
        public System.Windows.Forms.GroupBox Frame4;
        public System.Windows.Forms.TextBox txtEnrollNo;
        public System.Windows.Forms.Label lblEnabled;
        public System.Windows.Forms.Label lblPrivilege;
        public System.Windows.Forms.Label lblPassword;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblEnrollNo;
        public System.Windows.Forms.ComboBox cmbEnabled;
        public System.Windows.Forms.TextBox txtPrivilege;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Label lblCardNo;
        public System.Windows.Forms.Button btnDeleteUserInfo;
        public System.Windows.Forms.Button btnSetUserInfo;
        public System.Windows.Forms.Button btnGetUserInfo;
        public System.Windows.Forms.TextBox txtCardNo;
        public System.Windows.Forms.GroupBox Frame5;
        public System.Windows.Forms.Button btnSetTemplate;
        public System.Windows.Forms.Button btnGetTemplate;
        public System.Windows.Forms.TextBox txtFingerIndex;
        public System.Windows.Forms.TextBox txtEnrollNoFinger;
        public System.Windows.Forms.Label lblFingerIndex;
        public System.Windows.Forms.Label lblEnrollNoFinger;
        public System.Windows.Forms.TextBox txtFingerprintTemplate;
        public System.Windows.Forms.Label lblFingerprintTemplate;
        public System.Windows.Forms.Button btnDeleteTemplate;
        public System.Windows.Forms.GroupBox Frame6;
        public System.Windows.Forms.Label lblEnrollNoTimezone;
        public System.Windows.Forms.Label lblUnlockGroup;
        public System.Windows.Forms.Label lblTimeZoneStr;
        public System.Windows.Forms.Label lblTimeZoneNo;
        public System.Windows.Forms.Label lblTimeZoneInfo;
        public System.Windows.Forms.Label lblGroupNo;
        public System.Windows.Forms.TextBox txtGroupNo;
        public System.Windows.Forms.TextBox txtEnrollNoTimezone;
        public System.Windows.Forms.Button btnSetUsergroup;
        public System.Windows.Forms.Button btnGetUsergroup;
        public System.Windows.Forms.TextBox txtTimeZoneInfo;
        public System.Windows.Forms.TextBox txtTimeZoneNo;
        public System.Windows.Forms.TextBox txtTimeZoneStr;
        public System.Windows.Forms.Button btnSetGTimeZone;
        public System.Windows.Forms.Button btnGetGTimeZone;
        public System.Windows.Forms.Button btnSetTimeZone;
        public System.Windows.Forms.Button btnGetTimeZone;
        public System.Windows.Forms.Button btnSetUnlockG;
        public System.Windows.Forms.Button btnGetUnlockG;
        public System.Windows.Forms.TextBox txtUnlockGroup;
        public System.Windows.Forms.Button btnSetTimeZoneNo;
        public System.Windows.Forms.Button btnGetTimeZoneNo;
        private System.Windows.Forms.GroupBox Frame7;
        public System.Windows.Forms.GroupBox Frame8;
        public System.Windows.Forms.Label lblFilename;
        public System.Windows.Forms.Button btnOpenFile;
        public System.Windows.Forms.TextBox txtFilename;
        public System.Windows.Forms.Label lblPriviledgeUSB;
        public System.Windows.Forms.Label lblEnrollNoUSB;
        public System.Windows.Forms.Label lblNameUSB;
        public System.Windows.Forms.TextBox txtPriviledgeUSB;
        public System.Windows.Forms.TextBox txtEnrollNoUSB;
        public System.Windows.Forms.TextBox txtTimeZoneInfoUSB;
        public System.Windows.Forms.TextBox txtTimeZoneGUSB;
        public System.Windows.Forms.Label lblTimeZoneInfoUSB;
        public System.Windows.Forms.Label lblTimeZoneGUSB;
        public System.Windows.Forms.TextBox txtPasswordUSB;
        public System.Windows.Forms.TextBox txtNameUSB;
        public System.Windows.Forms.Label lblPasswordUSB;
        public System.Windows.Forms.GroupBox Frame9;
        public System.Windows.Forms.Label lblFingerTemplateUSB;
        public System.Windows.Forms.Label lblFingerIndexUSB;
        public System.Windows.Forms.TextBox txtFingerIndexUSB;
        public System.Windows.Forms.Button btnSaveToFile;
        public System.Windows.Forms.Button btnGetUserFileUSB;
        public System.Windows.Forms.TextBox txtRecordSize;
        public System.Windows.Forms.Label lblRecordSize;
        public System.Windows.Forms.Button btnSaveTemplateUSB;
        public System.Windows.Forms.Button btnGetTemplateUSB;
        public System.Windows.Forms.TextBox txtFingerTemplateUSB;
        public System.Windows.Forms.Button btnDecryptAttLog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnSetUserVerType;
        public System.Windows.Forms.Button btnGetUserVerType;
        public System.Windows.Forms.TextBox txtVerType;
        public System.Windows.Forms.TextBox txtEnrollNoVerType;
        public System.Windows.Forms.Label lblVerType;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnSSRDelUserSMS;
        public System.Windows.Forms.Button btnSSRSetUserSMS;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.RadioButton optPrivate;
        public System.Windows.Forms.RadioButton optPublic;
        public System.Windows.Forms.Button btnClearUserSMS;
        public System.Windows.Forms.Button btnDeleteUserSMS;
        public System.Windows.Forms.Button btnSetUserSMS;
        public System.Windows.Forms.Button btnClearSMS;
        public System.Windows.Forms.Button btnDeleteSMS;
        public System.Windows.Forms.Button btnSetSMS;
        public System.Windows.Forms.Button btnGetSMS;
        public System.Windows.Forms.TextBox txtEnrollNoSMS;
        public System.Windows.Forms.TextBox txtStartTime;
        public System.Windows.Forms.TextBox txtValidTime;
        public System.Windows.Forms.TextBox txtContent;
        public System.Windows.Forms.TextBox txtSMSID;
        public System.Windows.Forms.Label lblEnrollNoSMS;
        public System.Windows.Forms.Label lblType;
        public System.Windows.Forms.Label lblStartTime;
        public System.Windows.Forms.Label lblValidMinutes;
        public System.Windows.Forms.Label lblContent;
        public System.Windows.Forms.Label lblSMSID;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Button btnSSRGetGeneralLog;
        public System.Windows.Forms.Button btnSSRGetAllUser;
        public System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Button btnDelUserFace;
        public System.Windows.Forms.Button btnSetUserFace;
        public System.Windows.Forms.Button btnGetUserFace;
        public System.Windows.Forms.Button btnSetFaceData;
        public System.Windows.Forms.Button btnGetFaceData;
        public System.Windows.Forms.Button btnSetFP10;
        public System.Windows.Forms.Button GetFP10;
        public System.Windows.Forms.TextBox mmTplT;
        public System.Windows.Forms.TextBox edtFingerT;
        public System.Windows.Forms.TextBox edtEnrollNoT;
        public System.Windows.Forms.Button btnSetTemplateFileData;
        public System.Windows.Forms.Button btnGetTemplateFileData;
        public System.Windows.Forms.TextBox edtTZU;
        public System.Windows.Forms.TextBox edtTZGU;
        public System.Windows.Forms.TextBox edtCardNoU;
        public System.Windows.Forms.TextBox edtPriU;
        public System.Windows.Forms.TextBox edtPwdU;
        public System.Windows.Forms.TextBox edtNameU;
        public System.Windows.Forms.TextBox edtEnrollNoU;
        public System.Windows.Forms.Button btnWriteUserFile;
        public System.Windows.Forms.Button btnReadUserFile;
        public System.Windows.Forms.TextBox edtFile;
        public System.Windows.Forms.TextBox edtED;
        public System.Windows.Forms.TextBox edtEM;
        public System.Windows.Forms.TextBox edtBD;
        public System.Windows.Forms.TextBox edtBM;
        public System.Windows.Forms.Button btnSetHoliday;
        public System.Windows.Forms.Button btnGetHoliday;
        public System.Windows.Forms.TextBox edtTZID;
        public System.Windows.Forms.TextBox edtHolID;
        public System.Windows.Forms.Button btnSetGroupTZ;
        public System.Windows.Forms.Button btnGetGroupTZ;
        public System.Windows.Forms.TextBox edtTZ3;
        public System.Windows.Forms.TextBox edtTZ2;
        public System.Windows.Forms.TextBox edtTZ1;
        public System.Windows.Forms.TextBox edtVerMode;
        public System.Windows.Forms.TextBox edtHol;
        public System.Windows.Forms.TextBox edtTZGID;
        public System.Windows.Forms.TextBox edtG5;
        public System.Windows.Forms.TextBox edtG4;
        public System.Windows.Forms.TextBox edtG3;
        public System.Windows.Forms.TextBox edtG2;
        public System.Windows.Forms.TextBox edtG1;
        public System.Windows.Forms.TextBox edtComNo;
        public System.Windows.Forms.Button btnSetUnlockGroup;
        public System.Windows.Forms.Button btnGetUnlockGroup;
        public System.Windows.Forms.Button btnClearWC;
        public System.Windows.Forms.Button btnDeleteWC;
        public System.Windows.Forms.Button btnSetWC;
        public System.Windows.Forms.Button btnGetWC;
        public System.Windows.Forms.TextBox edtWC;
        public System.Windows.Forms.TextBox edtWCID;
        public System.Windows.Forms.TextBox edtFinger;
        public System.Windows.Forms.TextBox edtPwd;
        public System.Windows.Forms.TextBox edtName;
        public System.Windows.Forms.TextBox edtEnrollNo;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.GroupBox _Frame4_4;
        public System.Windows.Forms.Button btnFile;
        public System.Windows.Forms.GroupBox _Frame4_3;
        public System.Windows.Forms.GroupBox _Frame4_2;
        public System.Windows.Forms.GroupBox _Frame4_1;
        public System.Windows.Forms.GroupBox _Frame4_0;
        public System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.Button btnDelUserTpl;
        public System.Windows.Forms.Button btnSetUserTpl;
        public System.Windows.Forms.Button btnGetUserTpl;
        public System.Windows.Forms.Button btnSSRDelUserInfo;
        public System.Windows.Forms.Button btnSSRSetUserInfo;
        public System.Windows.Forms.Button btnSSRGetUserInfo;
        public System.Windows.Forms.TextBox mmTpl;
        public System.Windows.Forms.TextBox edtCardNo;
        public System.Windows.Forms.TextBox edtValid;
        public System.Windows.Forms.TextBox edtPri;
        public System.Windows.Forms.Label _Label1_33;
        public System.Windows.Forms.Label _Label1_32;
        public System.Windows.Forms.Label _Label1_31;
        public System.Windows.Forms.Label _Label1_30;
        public System.Windows.Forms.Label _Label1_29;
        public System.Windows.Forms.Label _Label1_28;
        public System.Windows.Forms.Label _Label1_27;
        public System.Windows.Forms.Label _Label1_26;
        public System.Windows.Forms.Label _Label1_25;
        public System.Windows.Forms.Label _Label1_24;
        public System.Windows.Forms.Label _Label1_23;
        public System.Windows.Forms.Label _Label1_22;
        public System.Windows.Forms.Label _Label1_21;
        public System.Windows.Forms.Label _Label1_20;
        public System.Windows.Forms.Label _Label1_19;
        public System.Windows.Forms.Label _Label1_18;
        public System.Windows.Forms.Label _Label1_17;
        public System.Windows.Forms.Label _Label1_16;
        public System.Windows.Forms.Label _Label1_15;
        public System.Windows.Forms.Label _Label1_14;
        public System.Windows.Forms.Label _Label1_13;
        public System.Windows.Forms.Label _Label1_12;
        public System.Windows.Forms.Label _Label1_11;
        public System.Windows.Forms.Label _Label1_10;
        public System.Windows.Forms.Label _Label1_9;
        public System.Windows.Forms.Label lblWordCode;
        public System.Windows.Forms.Label lblTemplate;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblValid;
        public System.Windows.Forms.Label lblPriviledge;
        public System.Windows.Forms.Label lblFinger;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnOpenPhoto;
        public System.Windows.Forms.Button btnOpenPicture;
        public System.Windows.Forms.ListBox listBox2;
        public System.Windows.Forms.TextBox edtPicPath;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox edtDownloadPicture;
        public System.Windows.Forms.Button btnDownloadPicture;
        public System.Windows.Forms.TextBox edtPhotoPath;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox edtDownloadPhoto;
        public System.Windows.Forms.Button btnDownloadPhoto;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox edtDelPhoto;
        public System.Windows.Forms.Button btnDelPhoto;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox edtDelPicture;
        public System.Windows.Forms.Button btnDelPicture;
        public System.Windows.Forms.TextBox edtPhoto;
        public System.Windows.Forms.Button btnUploadPhoto;
        public System.Windows.Forms.TextBox edtPicture;
        public System.Windows.Forms.Button btnUploadPicture;
        private System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.Button btnGetFail;
        public System.Windows.Forms.Button btnGetSuccess;
        private System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.GroupBox groupBox8;
        public System.Windows.Forms.Button btnPowerOff;
        public System.Windows.Forms.Button btnPowerOn;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtPowerMinute;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtPowerHour;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.ListBox listBox3;
        public System.Windows.Forms.Button btnIsTFT;
        public System.Windows.Forms.GroupBox groupBox9;
        public System.Windows.Forms.Button btnH2i_TurnAlarmOff;
        private System.Windows.Forms.Button btnListBox3Clear;
        private System.Windows.Forms.Button btnListBox2Clear;
        private System.Windows.Forms.Button btnListBox1Clear;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnH2iAdminCard_Set;
        public System.Windows.Forms.TextBox txtH2iAdminCard;
        public System.Windows.Forms.Button btnH2iAdminCard_Get;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.GroupBox groupBox10;
        public System.Windows.Forms.Button btnSetAntipassback;
        public System.Windows.Forms.Button btnGetAntipassback;
        public System.Windows.Forms.TextBox txtAntipassback;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.GroupBox groupBox11;
        public System.Windows.Forms.Button btnGetErrorCard;
        public System.Windows.Forms.Button btnClearErrorCard;
        public System.Windows.Forms.GroupBox groupBox12;
        public System.Windows.Forms.TextBox txtBeginCard;
        public System.Windows.Forms.TextBox txtBeginPassword;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txtBeginEnroll;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Button btnBeginStart;
        public System.Windows.Forms.GroupBox groupBox13;
        public System.Windows.Forms.Button btnSubnetSet;
        public System.Windows.Forms.Button btnSubnetGet;
        public System.Windows.Forms.TextBox txtSubnet;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.GroupBox groupBox14;
        public System.Windows.Forms.Button btnGatewaySet;
        public System.Windows.Forms.Button btnGatewayGet;
        public System.Windows.Forms.TextBox txtGateway;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.GroupBox groupBox15;
        public System.Windows.Forms.Button btnPlatform;
        public System.Windows.Forms.TextBox txtPlatform;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.Button btnSleepSet;
        public System.Windows.Forms.Button btnSleepGet;
        public System.Windows.Forms.GroupBox groupBox18;
        public System.Windows.Forms.Label label23;
        public System.Windows.Forms.TextBox txtSleepM;
        public System.Windows.Forms.Label label24;
        public System.Windows.Forms.TextBox txtSleepH;
        public System.Windows.Forms.Label label25;
        public System.Windows.Forms.GroupBox groupBox17;
        public System.Windows.Forms.Button btnGroupTimezone_Set;
        public System.Windows.Forms.TextBox txtGroupTimezone_Verify;
        public System.Windows.Forms.TextBox txtGroupTimezone_Timezone;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox txtGroupTimezone_Group;
        public System.Windows.Forms.Label label26;
        public System.Windows.Forms.Label label27;
        public System.Windows.Forms.Button btnGroupTimezone_Get;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.TextBox txtVc50;
        private System.Windows.Forms.TextBox txtEt50;
        private System.Windows.Forms.TextBox txtSt50;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.TextBox txtVc49;
        private System.Windows.Forms.TextBox txtEt49;
        private System.Windows.Forms.TextBox txtSt49;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.TextBox txtVc48;
        private System.Windows.Forms.TextBox txtEt48;
        private System.Windows.Forms.TextBox txtSt48;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.TextBox txtVc47;
        private System.Windows.Forms.TextBox txtEt47;
        private System.Windows.Forms.TextBox txtSt47;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.TextBox txtVc46;
        private System.Windows.Forms.TextBox txtEt46;
        private System.Windows.Forms.TextBox txtSt46;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.TextBox txtVc45;
        private System.Windows.Forms.TextBox txtEt45;
        private System.Windows.Forms.TextBox txtSt45;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.TextBox txtVc44;
        private System.Windows.Forms.TextBox txtEt44;
        private System.Windows.Forms.TextBox txtSt44;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.TextBox txtVc43;
        private System.Windows.Forms.TextBox txtEt43;
        private System.Windows.Forms.TextBox txtSt43;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.TextBox txtVc42;
        private System.Windows.Forms.TextBox txtEt42;
        private System.Windows.Forms.TextBox txtSt42;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.TextBox txtVc41;
        private System.Windows.Forms.TextBox txtEt41;
        private System.Windows.Forms.TextBox txtSt41;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.TextBox txtVc40;
        private System.Windows.Forms.TextBox txtEt40;
        private System.Windows.Forms.TextBox txtSt40;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.TextBox txtVc39;
        private System.Windows.Forms.TextBox txtEt39;
        private System.Windows.Forms.TextBox txtSt39;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox txtVc38;
        private System.Windows.Forms.TextBox txtEt38;
        private System.Windows.Forms.TextBox txtSt38;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TextBox txtVc37;
        private System.Windows.Forms.TextBox txtEt37;
        private System.Windows.Forms.TextBox txtSt37;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox txtVc36;
        private System.Windows.Forms.TextBox txtEt36;
        private System.Windows.Forms.TextBox txtSt36;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TextBox txtVc35;
        private System.Windows.Forms.TextBox txtEt35;
        private System.Windows.Forms.TextBox txtSt35;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TextBox txtVc34;
        private System.Windows.Forms.TextBox txtEt34;
        private System.Windows.Forms.TextBox txtSt34;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TextBox txtVc33;
        private System.Windows.Forms.TextBox txtEt33;
        private System.Windows.Forms.TextBox txtSt33;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.TextBox txtVc32;
        private System.Windows.Forms.TextBox txtEt32;
        private System.Windows.Forms.TextBox txtSt32;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.TextBox txtVc31;
        private System.Windows.Forms.TextBox txtEt31;
        private System.Windows.Forms.TextBox txtSt31;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.TextBox txtVc30;
        private System.Windows.Forms.TextBox txtEt30;
        private System.Windows.Forms.TextBox txtSt30;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox txtVc29;
        private System.Windows.Forms.TextBox txtEt29;
        private System.Windows.Forms.TextBox txtSt29;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox txtVc28;
        private System.Windows.Forms.TextBox txtEt28;
        private System.Windows.Forms.TextBox txtSt28;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox txtVc27;
        private System.Windows.Forms.TextBox txtEt27;
        private System.Windows.Forms.TextBox txtSt27;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox txtVc26;
        private System.Windows.Forms.TextBox txtEt26;
        private System.Windows.Forms.TextBox txtSt26;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox txtVc25;
        private System.Windows.Forms.TextBox txtEt25;
        private System.Windows.Forms.TextBox txtSt25;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox txtVc24;
        private System.Windows.Forms.TextBox txtEt24;
        private System.Windows.Forms.TextBox txtSt24;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox txtVc23;
        private System.Windows.Forms.TextBox txtEt23;
        private System.Windows.Forms.TextBox txtSt23;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox txtVc22;
        private System.Windows.Forms.TextBox txtEt22;
        private System.Windows.Forms.TextBox txtSt22;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox txtVc21;
        private System.Windows.Forms.TextBox txtEt21;
        private System.Windows.Forms.TextBox txtSt21;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox txtVc20;
        private System.Windows.Forms.TextBox txtEt20;
        private System.Windows.Forms.TextBox txtSt20;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtVc19;
        private System.Windows.Forms.TextBox txtEt19;
        private System.Windows.Forms.TextBox txtSt19;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtVc18;
        private System.Windows.Forms.TextBox txtEt18;
        private System.Windows.Forms.TextBox txtSt18;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtVc17;
        private System.Windows.Forms.TextBox txtEt17;
        private System.Windows.Forms.TextBox txtSt17;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox txtVc16;
        private System.Windows.Forms.TextBox txtEt16;
        private System.Windows.Forms.TextBox txtSt16;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtVc15;
        private System.Windows.Forms.TextBox txtEt15;
        private System.Windows.Forms.TextBox txtSt15;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txtVc14;
        private System.Windows.Forms.TextBox txtEt14;
        private System.Windows.Forms.TextBox txtSt14;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtVc13;
        private System.Windows.Forms.TextBox txtEt13;
        private System.Windows.Forms.TextBox txtSt13;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox txtVc12;
        private System.Windows.Forms.TextBox txtEt12;
        private System.Windows.Forms.TextBox txtSt12;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox txtVc11;
        private System.Windows.Forms.TextBox txtEt11;
        private System.Windows.Forms.TextBox txtSt11;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txtVc10;
        private System.Windows.Forms.TextBox txtEt10;
        private System.Windows.Forms.TextBox txtSt10;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtVc9;
        private System.Windows.Forms.TextBox txtEt9;
        private System.Windows.Forms.TextBox txtSt9;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtVc8;
        private System.Windows.Forms.TextBox txtEt8;
        private System.Windows.Forms.TextBox txtSt8;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtVc7;
        private System.Windows.Forms.TextBox txtEt7;
        private System.Windows.Forms.TextBox txtSt7;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtVc6;
        private System.Windows.Forms.TextBox txtEt6;
        private System.Windows.Forms.TextBox txtSt6;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtVc5;
        private System.Windows.Forms.TextBox txtEt5;
        private System.Windows.Forms.TextBox txtSt5;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtVc4;
        private System.Windows.Forms.TextBox txtEt4;
        private System.Windows.Forms.TextBox txtSt4;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtVc3;
        private System.Windows.Forms.TextBox txtEt3;
        private System.Windows.Forms.TextBox txtSt3;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtVc2;
        private System.Windows.Forms.TextBox txtEt2;
        private System.Windows.Forms.TextBox txtSt2;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtVc1;
        private System.Windows.Forms.TextBox txtEt1;
        private System.Windows.Forms.TextBox txtSt1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnSetEveryWeekTimezone;
        private System.Windows.Forms.Button btnGetEveryWeekTimezone;
        private System.Windows.Forms.TextBox txtDayOfWeek;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Button btnSetHolidayParam;
        private System.Windows.Forms.TextBox txtStartDay;
        private System.Windows.Forms.Button btnGetHolidayParam;
        private System.Windows.Forms.TextBox txtEndMonth;
        private System.Windows.Forms.TextBox txtEndDay;
        private System.Windows.Forms.TextBox txtTZHolidayParam;
        private System.Windows.Forms.TextBox txtStartMonth;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.TextBox txtHolidayParamId;
        private System.Windows.Forms.Label label99;
        private AxBioBridgeSDKv3.AxBioBridgeSDKv3lib axBioBridgeSDKv3lib1;
        private System.Windows.Forms.Button button2;
    }
}

