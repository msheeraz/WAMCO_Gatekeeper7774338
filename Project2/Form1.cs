using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Threading;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public MemoryStream memBuf;
        public Form1()
        {
            InitializeComponent();

            txtStartTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            memBuf = new MemoryStream();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rBtnIP.Checked = true; 
             

        }
         
        #region Main
        private void rBtnIP_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnIP.Checked == true)
            {
                btnConnect.Text = "Connect IP";
                txtCommPort.Visible = false;
                lblCommPort.Visible = false;
                txtBaudRate.Visible = false;
                lblBaudRate.Visible = false;
                lblIPAdd.Visible = true;
                txtIPAdd.Visible = true;
                lblPort.Visible = true;
                txtPort.Visible = true;
            }

            
        }

        private void rBtnCOM_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnCOM.Checked == true)
            {
                btnConnect.Text = "Connect COMM";
                txtCommPort.Visible = true;
                lblCommPort.Visible = true;
                txtBaudRate.Visible = true;
                lblBaudRate.Visible = true;
                lblIPAdd.Visible = false;
                txtIPAdd.Visible = false;
                lblPort.Visible = false;
                txtPort.Visible = false;
            }
        }

        private void rBtnUSB_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnUSB.Checked == true)
            {
                btnConnect.Text = "Connect";

                lblIPAdd.Visible = false;
                lblPort.Visible = false;
                lblCommPort.Visible = false;
                lblBaudRate.Visible = false;
                lblCommKey.Visible = true;
                lblModel.Visible = true;
                lblDeviceNo.Visible = true;

                txtIPAdd.Visible = false;
                txtPort.Visible = false;
                txtCommPort.Visible = false;
                txtBaudRate.Visible = false;
                txtCommKey.Visible = true;
                txtModel.Visible = true;
                txtDeviceNo.Visible = true;
            }
        }

        //make a connection to IP or comm address or USB client
        private void btnConnect_Click(object sender, EventArgs e)
        {
            int portNo = 0;
            string devModel = "";
            int devNo = 0;
            string ipAdd = "";
            int comm = 0;
            string sdkVer = "test";
            string firmware = "";
            string sdk = "";
            string firm = "";
            string time = "";

            int yr = 0;
            int mth = 0;
            int day_Renamed = 0;
            int hr = 0;
            int min = 0;
            int sec = 0;
            int commPort = 0;
            int baudRate = 0;
            int i = 0;

            devModel = txtModel.Text;
            devNo = Convert.ToInt32(txtDeviceNo.Text);
            ipAdd = txtIPAdd.Text;
            portNo = Convert.ToInt32(txtPort.Text);
            comm = Convert.ToInt32(txtCommKey.Text);
            commPort = Convert.ToInt32(txtCommPort.Text);
            baudRate = Convert.ToInt32(txtBaudRate.Text);
            
            //option to connect to ip address
            if (rBtnIP.Checked)
            {
                string sError = axBioBridgeSDKv3lib1.Connect_TCPIP(devModel, devNo, ipAdd, portNo, comm).ToString();
                Console.WriteLine("return code : " + sError);
                if (sError == "0")
                {
                    RegisterEvent();

                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;

                    txtIPAdd.Enabled = false;
                    txtPort.Enabled = false;

                    if (axBioBridgeSDKv3lib1.GetSDKVersion(ref sdkVer, 0) == 0)
                    {
                        sdk = "SDK Version: " + sdkVer;
                    }
                    else
                    {
                        sdk = "SDK Version Error";
                    }

                    if (axBioBridgeSDKv3lib1.GetFirmwareVersion(ref firmware) == 0)
                    {
                        firm = "Firmware Version: " + firmware;
                    }
                    else
                    {
                        firm = "Firmware Error";
                    }
                    
                    if (axBioBridgeSDKv3lib1.GetDeviceTime(ref yr, ref mth, ref day_Renamed, ref hr, ref min, ref sec) == 0)
                    {
                        time = "Device Date and Time: " + Convert.ToString(day_Renamed) + "/" + Convert.ToString(mth) + "/" + Convert.ToString(yr) + " " + Convert.ToString(hr) + ":" + Convert.ToString(min) + ":" + Convert.ToString(sec);
                    }
                    else
                    {
                        time = "!Date and Time";
                    }
                    List1.Items.Add(("-------------------------------------------------------------------"));
                    List1.Items.Add((sdk));
                    List1.Items.Add((firm));
                    List1.Items.Add((time));
                    List1.Items.Add(("Manufacturer: " + axBioBridgeSDKv3lib1.VC));
                    List1.Items.Add(("Serial No: " + axBioBridgeSDKv3lib1.SN));
                    List1.Items.Add(("Mac Add: " + axBioBridgeSDKv3lib1.MAC));
                    List1.Items.Add(("Model Name: " + axBioBridgeSDKv3lib1.DC));

                    Console.WriteLine((sdk));
                    Console.WriteLine((firm));
                    Console.WriteLine((time));
                    Console.WriteLine(("Manufacturer: " + axBioBridgeSDKv3lib1.VC));
                    Console.WriteLine(("Serial No: " + axBioBridgeSDKv3lib1.SN));
                    Console.WriteLine(("Mac Add: " + axBioBridgeSDKv3lib1.MAC));
                    Console.WriteLine(("Model Name: " + axBioBridgeSDKv3lib1.DC));

                    if (axBioBridgeSDKv3lib1.Finger10 == 1)
                    {
                        List1.Items.Add(("This is a FP10 reader"));
                    }
                    else
                    {
                        List1.Items.Add(("This is not a FP10 reader"));
                    }

                    if (axBioBridgeSDKv3lib1.GetDeviceStatus(1, ref i) == 0)
                    {
                        List1.Items.Add(("Administrator: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDKv3lib1.GetDeviceStatus(2, ref i) == 0)
                    {
                        List1.Items.Add(("Users: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDKv3lib1.GetDeviceStatus(3, ref i) == 0)
                    {
                        List1.Items.Add(("Fingerprints: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDKv3lib1.GetDeviceStatus(4, ref i) == 0)
                    {
                        List1.Items.Add(("Passwords: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDKv3lib1.GetDeviceStatus(6, ref i) == 0)
                    {
                        List1.Items.Add(("Logs: " + Convert.ToString(i)));
                    }

                    List1.Items.Add(("------------------------------------------------------------------"));

                  

                }
                else
                {
                    List1.Items.Add(("Unable to Connect to IP Address!!"));
                    List1.Items.Add(("Error: " + axBioBridgeSDKv3lib1.VC));
                }
            }

            //option to connect to COMM Port
            if (rBtnCOM.Checked)
            {
                if (axBioBridgeSDKv3lib1.Connect_COMM(devModel, devNo, commPort, baudRate, comm) == 0)
                {
                    RegisterEvent();

                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;

                    txtBaudRate.Enabled = false;
                    txtCommPort.Enabled = false;

                    if (axBioBridgeSDKv3lib1.GetSDKVersion(ref sdkVer, 0) == 0)
                    {
                        sdk = "SDK Version: " + sdkVer;
                    }
                    else
                    {
                        sdk = "SDK Version Error";
                    }

                    if (axBioBridgeSDKv3lib1.GetFirmwareVersion(ref firmware) == 0)
                    {
                        firm = "Firmware Version: " + firmware;
                    }
                    else
                    {
                        firm = "Firmware Error";
                    }

                    if (axBioBridgeSDKv3lib1.GetDeviceTime(ref yr, ref mth, ref day_Renamed, ref hr, ref min, ref sec) == 0)
                    {
                        time = "Device Date and Time: " + Convert.ToString(day_Renamed) + "/" + Convert.ToString(mth) + "/" + Convert.ToString(yr) + " " + Convert.ToString(hr) + ":" + Convert.ToString(min) + ":" + Convert.ToString(sec);
                    }
                    else
                    {
                        time = "!Date and Time";
                    }
                    List1.Items.Add(("-------------------------------------------------------------------"));
                    List1.Items.Add((sdk));
                    List1.Items.Add((firm));
                    List1.Items.Add((time));
                    List1.Items.Add(("Manufacturer: " + axBioBridgeSDKv3lib1.VC));
                    List1.Items.Add(("Serial No: " + axBioBridgeSDKv3lib1.SN));
                    List1.Items.Add(("Mac Add: " + axBioBridgeSDKv3lib1.MAC));
                    List1.Items.Add(("Model Name: " + axBioBridgeSDKv3lib1.DC));

                    //if (axBioBridgeSDKv3lib1.Finger10 == 1)
                    //{
                    //    List1.Items.Add(("This is a FP10 reader"));
                    //}
                    //else
                    //{
                    //    List1.Items.Add(("This is not a FP10 reader"));
                    //}

                    if (axBioBridgeSDKv3lib1.GetDeviceStatus(1, ref i) == 0)
                    {
                        List1.Items.Add(("Administrator: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDKv3lib1.GetDeviceStatus(2, ref i) == 0)
                    {
                        List1.Items.Add(("Users: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDKv3lib1.GetDeviceStatus(3, ref i) == 0)
                    {
                        List1.Items.Add(("Fingerprints: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDKv3lib1.GetDeviceStatus(4, ref i) == 0)
                    {
                        List1.Items.Add(("Passwords: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDKv3lib1.GetDeviceStatus(6, ref i) == 0)
                    {
                        List1.Items.Add(("Logs: " + Convert.ToString(i)));
                    }

                    List1.Items.Add(("------------------------------------------------------------------"));
                }
                else
                {
                    List1.Items.Add(("Unable to Connect to COMM Port!!"));
                    List1.Items.Add(("Error: " + axBioBridgeSDKv3lib1.VC));
                }
            }

            //option to connect to USB Client
            if (rBtnUSB.Checked)
            {
                if (axBioBridgeSDKv3lib1.Connect_USB(devModel, devNo, comm) == 0)
                {
                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;

                    txtIPAdd.Enabled = false;
                    txtPort.Enabled = false;

                    if (axBioBridgeSDKv3lib1.GetSDKVersion(ref sdkVer, 0) == 0)
                    {
                        sdk = "SDK Version: " + sdkVer;
                    }
                    else
                    {
                        sdk = "SDK Version Error";
                    }

                    if (axBioBridgeSDKv3lib1.GetFirmwareVersion(ref firmware) == 0)
                    {
                        firm = "Firmware Version: " + firmware;
                    }
                    else
                    {
                        firm = "Firmware Error";
                    }

                    if (axBioBridgeSDKv3lib1.GetDeviceTime(ref yr, ref mth, ref day_Renamed, ref hr, ref min, ref sec) == 0)
                    {
                        time = "Device Date and Time: " + Convert.ToString(day_Renamed) + "/" + Convert.ToString(mth) + "/" + Convert.ToString(yr) + " " + Convert.ToString(hr) + ":" + Convert.ToString(min) + ":" + Convert.ToString(sec);
                    }
                    else
                    {
                        time = "!Date and Time";
                    }
                    List1.Items.Add(("-------------------------------------------------------------------"));
                    List1.Items.Add((sdk));
                    List1.Items.Add((firm));
                    List1.Items.Add((time));
                    List1.Items.Add(("Manufacturer: " + axBioBridgeSDKv3lib1.VC));
                    List1.Items.Add(("Serial No: " + axBioBridgeSDKv3lib1.SN));
                    List1.Items.Add(("Mac Add: " + axBioBridgeSDKv3lib1.MAC));
                    List1.Items.Add(("Model Name: " + axBioBridgeSDKv3lib1.DC));

                    if (axBioBridgeSDKv3lib1.Finger10 == 1)
                    {
                        List1.Items.Add(("This is a FP10 reader"));
                    }
                    else
                    {
                        List1.Items.Add(("This is not a FP10 reader"));
                    }

                    if (axBioBridgeSDKv3lib1.GetDeviceStatus(1, ref i) == 0)
                    {
                        List1.Items.Add(("Administrator: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDKv3lib1.GetDeviceStatus(2, ref i) == 0)
                    {
                        List1.Items.Add(("Users: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDKv3lib1.GetDeviceStatus(3, ref i) == 0)
                    {
                        List1.Items.Add(("Fingerprints: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDKv3lib1.GetDeviceStatus(4, ref i) == 0)
                    {
                        List1.Items.Add(("Passwords: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDKv3lib1.GetDeviceStatus(6, ref i) == 0)
                    {
                        List1.Items.Add(("Logs: " + Convert.ToString(i)));
                    }

                    List1.Items.Add(("------------------------------------------------------------------"));
                }
                else
                {
                    List1.Items.Add(("Unable to Connect to IP Address!!"));
                    List1.Items.Add(("Error: " + axBioBridgeSDKv3lib1.VC));
                }
            }
        }

        private void RegisterEvent()
        {
            axBioBridgeSDKv3lib1.OnConnect += axBioBridgeSDKv3lib1_OnConnected;
            axBioBridgeSDKv3lib1.OnDisConnect += axBioBridgeSDKv3lib1_OnDisConnected;
            axBioBridgeSDKv3lib1.OnFinger += axBioBridgeSDKv3lib1_OnFinger;
            axBioBridgeSDKv3lib1.OnAttTransactionEx += axBioBridgeSDKv3lib1_OnAttTransactionEx; ;
            axBioBridgeSDKv3lib1.OnDoor += axBioBridgeSDKv3lib1_OnDoor;
            axBioBridgeSDKv3lib1.OnAlarm += axBioBridgeSDKv3lib1_OnAlarm;
        }


        private void axBioBridgeSDKv3lib1_OnFinger(object sender, EventArgs e)
        {
            listBox3.Items.Add("On Finger Event!!!");
            //ThreadProcSafe("On Finger Event!!!");
        }

        private void axBioBridgeSDKv3lib1_OnDisConnected(object sender, EventArgs e)
        {
            listBox3.Items.Add("On Disconnect!!!");
        }

        private void axBioBridgeSDKv3lib1_OnConnected(object sender, EventArgs e)
        {
            listBox3.Items.Add("On Connect!!!");
        }

        private void axBioBridgeSDKv3lib1_OnAttTransactionEx(object sender,AxBioBridgeSDKv3.IBioBridgeSDKv3libEvents_OnAttTransactionExEvent  e)
        {
            string smessage = string.Empty;
            string date = e.year + "-" + e.month + "-" + e.day + " " + e.hour + ":" + e.minute + ":" + e.second;
            smessage = "On Transaction Event:- Date=" + date + " ,EnrollNo=" + e.enrollNo + " ,AttState=" + e.attState + " ,IsInValid=" + e.isInValid + " ,VerifyMode=" + e.verifyMode + " ,WorkCode=" + e.workCode;
            //listBox3.Items.Add("On Transaction Event:- Date=" + date + " ,EnrollNo=" + e.enrollNo + " ,AttState=" + e.attState + " ,IsInValid=" + e.isInValid + " ,VerifyMode=" + e.verifyMode + " ,WorkCode=" + e.workCode );
            ThreadProcSafe(smessage);
        }

        private void axBioBridgeSDKv3lib1_OnAlarm(object sender, AxBioBridgeSDKv3.IBioBridgeSDKv3libEvents_OnAlarmEvent e)
        {
            listBox3.Items.Add("On Alarm Event:- Alarm Type=" + e.alarmType + " ,EnrollNo=" + e.enrollNo + ", Verified=" + e.verified + "");
        }

        private void axBioBridgeSDKv3lib1_OnDoor(object sender, AxBioBridgeSDKv3.IBioBridgeSDKv3libEvents_OnDoorEvent e)
        {
            listBox3.Items.Add("On Door Event:- Event Type=" + e.eventType);
        }

        delegate void SetTextCallback(string text);
        private void ThreadProcSafe(string text)
        {
            // Wait two seconds to simulate some background work
            // being done.
            Thread.Sleep(2000);

            //string text = "Written by the background thread.";
            // Check if this method is running on a different thread
            // than the thread that created the control.
            if (this.listBox3.InvokeRequired)
            {
                // It's on a different thread, so use Invoke.
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke
                    (d, new object[] { text });
            }
            else
            {
                // It's on the same thread, no need for Invoke
                //this.textBox1.Text = text + " (No Invoke)";
                this.listBox3.Items.Add(text);
            }
        }
        // This method is passed in to the SetTextCallBack delegate
        // to set the Text property of textBox1.
        private void SetText(string text)
        {
            this.listBox3.Items.Add(text);
        }

        //function to disconnect from the device
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            txtCommKey.Enabled = true;
            txtCommPort.Enabled = true;
            txtBaudRate.Enabled = true;
            txtIPAdd.Enabled = true;
            txtPort.Enabled = true;

            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;

            if (axBioBridgeSDKv3lib1.Disconnect() == 0)
            {
                List1.Items.Add(("Disconnect from Device"));
            }
            else
            {
                List1.Items.Add(("Unable to disconnect!"));
            }
        }

        //function to set the comm key device
        private void btnSetComm_Click(object sender, EventArgs e)
        {
            int comm;
            comm = Convert.ToInt32(txtCommKey.Text);

            if (axBioBridgeSDKv3lib1.SetDeviceCommKey(comm) == 0)
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            int i = 0;
            int m = 0;
            int h = 0;

            //Date forDisableDeviceWithTimeoutat
            if (axBioBridgeSDKv3lib1.GetDeviceInfo(34, ref i) == 0)
            {
                if (i == 0)
                {
                    List1.Items.Add(("DateFormat : YY-MM-DD"));
                }
                else if (i == 1)
                {
                    List1.Items.Add(("DateFormat : YY/MM/DD"));
                }
                else if (i == 2)
                {
                    List1.Items.Add(("DateFormat : YY.MM.DD"));
                }
                else if (i == 3)
                {
                    List1.Items.Add(("DateFormat : MM-DD-YY"));
                }
                else if (i == 4)
                {
                    List1.Items.Add(("DateFormat : MM/DD/YY"));
                }
                else if (i == 5)
                {
                    List1.Items.Add(("DateFormat : MM.DD.YY"));
                }
                else if (i == 6)
                {
                    List1.Items.Add(("DateFormat : DD-MM-YY"));
                }
                else if (i == 7)
                {
                    List1.Items.Add(("DateFormat : DD/MM/YY"));
                }
                else if (i == 8)
                {
                    List1.Items.Add(("DateFormat : DD.MM.YY"));
                }
                else if (i == 9)
                {
                    List1.Items.Add(("DateFormat : YYYYMMDD"));
                }
            }

            //Voice
            if (axBioBridgeSDKv3lib1.GetDeviceInfo(16, ref i) == 0)
            {
                if (i == 0)
                {
                    List1.Items.Add(("Voice : Off"));
                }
                else
                {
                    List1.Items.Add(("Voice : On"));
                }
            }

            //1 to N
            if (axBioBridgeSDKv3lib1.GetDeviceInfo(23, ref i) == 0)
            {
                List1.Items.Add(("1 to N :" + Convert.ToString(i)));
            }

            //1 to 1
            if (axBioBridgeSDKv3lib1.GetDeviceInfo(25, ref i) == 0)
            {
                List1.Items.Add(("1 to 1 :" + Convert.ToString(i)));
            }

            //Only 1 to 1
            if (axBioBridgeSDKv3lib1.GetDeviceInfo(35, ref i) == 0)
            {
                if (i == 0)
                {
                    List1.Items.Add(("Only 1 to 1 : Off"));
                }
                else
                {
                    List1.Items.Add(("Only 1 to 1 : On"));
                }
            }

            //Idle minutes 0-999
            if (axBioBridgeSDKv3lib1.GetDeviceInfo(4, ref i) == 0)
            {
                List1.Items.Add(("Idle Minutes : " + Convert.ToString(i)));
            }

            //Idle Action
            if (axBioBridgeSDKv3lib1.GetDeviceInfo(18, ref i) == 0)
            {
                if (i == 87)
                {
                    List1.Items.Add(("Idle Action : Power Off"));
                }
                else if (i == 88)
                {
                    List1.Items.Add(("Idle Action : Sleep Mode"));
                }
            }

            //Lock Delay
            if (axBioBridgeSDKv3lib1.GetDeviceInfo(5, ref i) == 0)
            {
                List1.Items.Add(("Lock Delay : " + Convert.ToString(i) + " (*200ms)"));
            }

            //Total Faces
            if (axBioBridgeSDKv3lib1.GetDeviceStatus(21, ref i) == 0)
            {
                List1.Items.Add(("Face Template : " + Convert.ToString(i)));
            }

            //Face Capacity
            if (axBioBridgeSDKv3lib1.GetDeviceStatus(22, ref i) == 0)
            {
                List1.Items.Add(("Face Capacity : " + Convert.ToString(i)));
            }

            //Sleep Time
            if (axBioBridgeSDKv3lib1.GetSleep(ref h, ref m) == 0)
            {
                List1.Items.Add(("Sleep Time = " + Convert.ToString(h) + ":" + Convert.ToString(m)));
            }

            //Power Off Time
            if (axBioBridgeSDKv3lib1.GetPowerOff(ref h, ref m) == 0)
            {
                List1.Items.Add(("Power Off Time = " + Convert.ToString(h) + ":" + Convert.ToString(m)));
            }

            //Power On Time
            if (axBioBridgeSDKv3lib1.GetPowerOn(ref h, ref m) == 0)
            {
                List1.Items.Add(("Power On Time = " + Convert.ToString(h) + ":" + Convert.ToString(m)));
            }

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            List1.Items.Add(("Device is restarting..."));
            axBioBridgeSDKv3lib1.RestartDevice();
        }

        //function to unlock the door connected to the device
        private void btnUnlockDoor_Click(object sender, EventArgs e)
        {
            int delay = 1000;

            if (axBioBridgeSDKv3lib1.UnlockDoor(delay) == 0)
            {
                List1.Items.Add(("Door Unlocked"));
            }
            else
            {
                List1.Items.Add(("Unable to Unlock Door"));
            }
        }

        private void btnDisWithTimeOut_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.DisableDeviceWithTimeout(Convert.ToInt32(txtTimeOut.Text)) == 0)
            {
                List1.Items.Add(("Disable Device with Timeout Success"));
            }
            else
            {
                List1.Items.Add(("DisableDeviceWithTimeout fail"));
            }
        }

        //function to enable / disable the device
        private void chkEnable_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkEnable.CheckState == 0)
            {
                if (axBioBridgeSDKv3lib1.EnableDevice() == 0)
                {
                    List1.Items.Add(("Device Enabled"));
                    chkEnable.Text = "Enable / Disable";
                }
            }
            else
            {
                if (axBioBridgeSDKv3lib1.DisableDevice() == 0)
                {
                    List1.Items.Add(("Device Disabled"));
                    chkEnable.Text = "Disable Device";
                }
            }
        }

        // get is color screen model
        private void btnIsTFT_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.IsTFT() == 0)
            {
                List1.Items.Add(("Is Color Screen Model"));
            }
            else
            {
                List1.Items.Add(("Is Black and White Model"));
            }
        }


        //function to get the date and time from the device
        private void btnGetTime_Click(object sender, EventArgs e)
        {
            int yr = 0;
            int mth = 0;
            int day_Renamed = 0;
            int hr = 0;
            int min = 0;
            int sec = 0;

            if (axBioBridgeSDKv3lib1.GetDeviceTime(ref yr, ref mth, ref day_Renamed, ref hr, ref min, ref sec) == 0)
            {
                txtDay.Text = Convert.ToString(day_Renamed);
                txtMonth.Text = Convert.ToString(mth);
                txtYear.Text = Convert.ToString(yr);
                txtHour.Text = Convert.ToString(hr);
                txtMinute.Text = Convert.ToString(min);
                txtSecond.Text = Convert.ToString(sec);

                List1.Items.Add(("Time: " + Convert.ToString(hr) + ":" + Convert.ToString(min) + ":" + Convert.ToString(sec)));
                List1.Items.Add(("Date: " + Convert.ToString(day_Renamed) + "/" + Convert.ToString(mth) + "/" + Convert.ToString(yr)));
            }
            else
            {
                List1.Items.Add(("No item found!"));
            }
        }

        //function to set the date and time to the device
        private void btnSetTime_Click(object sender, EventArgs e)
        {
            //assign the field values to variables
            int yr = Convert.ToInt32(txtYear.Text);
            int mth = Convert.ToInt32(txtMonth.Text);
            int day_Renamed = Convert.ToInt32(txtDay.Text);
            int hr = Convert.ToInt32(txtHour.Text);
            int min = Convert.ToInt32(txtMinute.Text);
            int sec = Convert.ToInt32(txtSecond.Text);

            if (axBioBridgeSDKv3lib1.SetDeviceTime(yr, mth, day_Renamed, hr, min, sec) == 0)
            {
                List1.Items.Add(("-------------------------------------------------------"));
                List1.Items.Add(("Update Date and Time Done"));
                List1.Items.Add(("Time: " + Convert.ToString(hr) + ":" + Convert.ToString(min) + ":" + Convert.ToString(sec)));
                List1.Items.Add(("Date: " + Convert.ToString(day_Renamed) + "/" + Convert.ToString(mth) + "/" + Convert.ToString(yr)));
                List1.Items.Add(("-------------------------------------------------------"));
            }
            else
            {
                List1.Items.Add(("Unable to Change Date and Time!!"));
            }
        }

        //sync the device date and time according to the computer
        private void btnSyncTime_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.SetDeviceTimeLocal() == 0)
            {
                List1.Items.Add(("Date and Time Synchronize Done"));
            }
            else
            {
                List1.Items.Add(("Unable to Sync!!"));
            }
        }

        //function to read all the user information from the device
        private void btnReadUserData_Click(object sender, EventArgs e)
        {
            int record = 0;
            int enrollNo = 0;

            string name_Renamed = "";
            string pwd = "";
            int priv = 0;
            bool enable = false;

            //read the user information from device into the memory buffer
            if (axBioBridgeSDKv3lib1.ReadAllUserInfo(ref record) == 0)
            {
                do
                {
                    List1.Items.Add(("Enroll No: " + Convert.ToString(enrollNo) + "Name: " + name_Renamed + "Pwd: " + pwd + "Enable: " + Convert.ToString(enable)));
                } while (axBioBridgeSDKv3lib1.GetAllUserInfo(ref enrollNo, ref name_Renamed, ref pwd, ref priv, ref enable) == 0);
            }
            else
            {
                List1.Items.Add(("No Record Found!!"));
            }
        }

        //function to read all the information log device
        private void btnReadLog_Click(object sender, EventArgs e)
        {
            int yr = 0;
            int mth = 0;
            int day_Renamed = 0;
            int hr = 0;
            int min = 0;
            int sec = 0;

            int enrollNo = 0;
            int ver = 0;
            int io = 0;
            int work = 0;
            int log = 0;

            axBioBridgeSDKv3lib1.SetLastCount(Convert.ToInt32(txtSetLastCount.Text));

            if (axBioBridgeSDKv3lib1.ReadGeneralLog(ref log) == 0)
            {
                do
                {
                    List1.Items.Add(("No: " + Convert.ToString(enrollNo) + " Date:" + Convert.ToString(day_Renamed) + "/" + Convert.ToString(mth) + "/" + Convert.ToString(yr) + " Time: " + Convert.ToString(hr) + ":" + Convert.ToString(min) + ":" + Convert.ToString(sec) + " Verify: " + Convert.ToString(ver) + " I/O: " + Convert.ToString(io) + " Work Code: " + Convert.ToString(work)));
                } while (axBioBridgeSDKv3lib1.GetGeneralLog(ref enrollNo, ref yr, ref mth, ref day_Renamed, ref hr, ref min, ref sec, ref ver, ref io, ref work) == 0);
            }
            else
            {
                List1.Items.Add(("Unable to Read General Log!!"));
            }
        }

        //function to clear all the user information in the device
        private void btnClearUserData_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.ClearAllData() == 0)
            {
                List1.Items.Add(("All Data Cleared"));
            }
            else
            {
                List1.Items.Add(("Unable to Clear!!"));
            }
        }

        //function to clear all the logs in the device
        private void btnClearLog_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.DeleteGeneralLog() == 0)
            {
                List1.Items.Add(("All Logs Cleared"));
            }
            else
            {
                List1.Items.Add(("Unable to Clear!!"));
            }
        }

        private void btnClearAllFields_Click(object sender, EventArgs e)
        {
            //Frame2
            txtDay.Text = "";
            txtMonth.Text = "";
            txtYear.Text = "";
            txtHour.Text = "";
            txtMinute.Text = "";
            txtSecond.Text = "";

            //Frame4
            txtEnrollNo.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            txtPrivilege.Text = "";

            //Frame5
            txtEnrollNoFinger.Text = "";
            txtFingerIndex.Text = "";
            txtFingerprintTemplate.Text = "";

            //Frame6
            txtEnrollNoTimezone.Text = "";
            txtGroupNo.Text = "";
            txtTimeZoneInfo.Text = "";
            txtTimeZoneNo.Text = "";
            txtTimeZoneStr.Text = "";
            txtUnlockGroup.Text = "";

            //Frame7
            txtEnrollNoUSB.Text = "";
            txtNameUSB.Text = "";
            txtPasswordUSB.Text = "";
            txtTimeZoneGUSB.Text = "";
            txtTimeZoneInfoUSB.Text = "";
            txtFingerIndexUSB.Text = "";
            txtRecordSize.Text = "";
            txtPriviledgeUSB.Text = "";
            txtFilename.Text = "";
            txtFingerTemplateUSB.Text = "";
        }

        //function to clear all the administrator status
        private void btnClearAdmin_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.ClearAdministrator() == 0)
            {
                List1.Items.Add(("All Admin Status Cleared"));
            }
            else
            {
                List1.Items.Add(("Unable to Clear Admin Status!!"));
            }
        }

        //function to get the user information based on the enrollment number
        private void btnGetUserInfo_Click(object sender, EventArgs e)
        {
            int enrollNo = 0;
            string name_Renamed = "";
            string pwd = "";
            int level = 0;
            string cardNo = "";
            Boolean status = false;

            if (txtEnrollNo.Text == "")
            {
                MessageBox.Show("Required Field: Enrollment No!!");
            }
            else
            {
                enrollNo = Convert.ToInt32(txtEnrollNo.Text);
                if (axBioBridgeSDKv3lib1.GetUserInfo(enrollNo, ref name_Renamed, ref pwd, ref level, ref status) == 0)
                {
                    txtName.Text = name_Renamed;
                    txtPassword.Text = pwd;
                    txtPrivilege.Text = Convert.ToString(level);
                    cmbEnabled.Text = Convert.ToString(status);
                    //cardNo = axBioBridgeSDKv3lib1.CardNo;
                    //axBioBridgeSDKv3lib1.GetCardNo(cardNo);
                    //txtCardNo.Text = Convert.ToString(cardNo);
                    axBioBridgeSDKv3lib1.GetCardNo(ref cardNo);
                    txtCardNo.Text = cardNo;
                    List1.Items.Add(("Enroll No: " + Convert.ToString(enrollNo) + " Name: " + name_Renamed + " Pwd: " + pwd + " Privilege: " + Convert.ToString(level) + " Enabled: " + Convert.ToString(status) + " CardNo: " + Convert.ToString(cardNo)));
                }
                else
                {
                    List1.Items.Add(("No Record Found!!"));
                }
            }
        }

        //function to set / update the user information
        private void btnSetUserInfo_Click(object sender, EventArgs e)
        {
            int enrollNo = 0;
            int level = 0;
            string name_Renamed = "";
            string pwd = "";
            int cardNo = 0;
            Boolean status = false;

            if (txtEnrollNo.Text == "" || txtPrivilege.Text == "")
            {
                MessageBox.Show("Required Field: Enrollment No or Privilege!!");
            }
            else
            {
                enrollNo = Convert.ToInt32(txtEnrollNo.Text);
                name_Renamed = txtName.Text;
                pwd = txtPassword.Text;
                level = Convert.ToInt32(txtPrivilege.Text);
                status = Convert.ToBoolean(cmbEnabled.Text);
                cardNo = Convert.ToInt32(txtCardNo.Text);
                axBioBridgeSDKv3lib1.SetCardNo(cardNo.ToString()); // = cardNo;

                if (axBioBridgeSDKv3lib1.SetUserInfo(enrollNo, name_Renamed, pwd, level, status) == 0)
                {
                    List1.Items.Add(("User Information Set"));
                    List1.Items.Add(("Enroll No: " + Convert.ToString(enrollNo) + " Name: " + name_Renamed + " Pwd: " + pwd + " Privilege: " + Convert.ToString(level) + " Enabled: " + Convert.ToString(status) + " CardNo: " + Convert.ToString(cardNo)));
                }
                else
                {
                    List1.Items.Add(("No Record Found!!"));
                }
            }
        }

        //function to delete user information based on the enrollment number
        private void btnDeleteUserInfo_Click(object sender, EventArgs e)
        {
            int enrollNo = 0;

            if (txtEnrollNo.Text == "")
            {
                MessageBox.Show("Required Field: Enrollment No!!");
            }
            else
            {
                enrollNo = Convert.ToInt32(txtEnrollNo.Text);

                if (axBioBridgeSDKv3lib1.DeleteUserData(enrollNo) == 0)
                {
                    List1.Items.Add(("User Information Removed"));
                }
                else
                {
                    List1.Items.Add(("Unable to Remove User!!"));
                }
            }
        }

        //function to get the user fingerprint template based on the user enrollment number
        private void btnGetTemplate_Click(object sender, EventArgs e)
        {
            int enrollNo = 0;
            int fingerId = 0;
            string template = "";

            if (txtEnrollNoFinger.Text == "" || txtFingerIndex.Text == "")
            {
                MessageBox.Show("Required Field: Enrollment No or Finger Index No!!");
            }
            else
            {
                enrollNo = Convert.ToInt32(txtEnrollNoFinger.Text);
                fingerId = Convert.ToInt32(txtFingerIndex.Text);

                if (axBioBridgeSDKv3lib1.GetUserTemplate(enrollNo, fingerId, ref template) == 0)
                {
                    List1.Items.Add(("Enroll No: " + Convert.ToString(enrollNo) + " Index Finger: " + Convert.ToString(fingerId) + " Template: " + template));
                    txtFingerprintTemplate.Text = template;
                }
                else
                {
                    List1.Items.Add(("No User Record Found!!"));
                }
            }
        }

        //function to set / update user fingerprint template
        private void btnSetTemplate_Click(object sender, EventArgs e)
        {
            int enrollNo = 0;
            int fingerId = 0;
            string template = "";

            if (txtEnrollNoFinger.Text == "" || txtFingerIndex.Text == "" || txtFingerprintTemplate.Text == "")
            {
                MessageBox.Show("Required Field: Enrollment No or Finger Index No or Template!!");
            }
            else
            {
                enrollNo = Convert.ToInt32(txtEnrollNoFinger.Text);
                fingerId = Convert.ToInt32(txtFingerIndex.Text);
                template = txtFingerprintTemplate.Text;

                if (axBioBridgeSDKv3lib1.SetUserTemplate(enrollNo, fingerId, template) == 0)
                {
                     
                    List1.Items.Add(("User Fingerprint Template Set"));
                }
                else
                {
                    List1.Items.Add(("Unable to Set Fingerprint Template!!"));
                }
            }
        }

        //function to delete user fingerprint template based on the enrollment number and finger id
        private void btnDeleteTemplate_Click(object sender, EventArgs e)
        {
            int fingerId = 0;
            int enrollNo = 0;

            if (txtEnrollNoFinger.Text == "" || txtFingerIndex.Text == "")
            {
                MessageBox.Show("Required Field: Enrollment No or Finger Index No!!");
            }
            else
            {
                enrollNo = Convert.ToInt32(txtEnrollNoFinger.Text);
                fingerId = Convert.ToInt32(txtFingerIndex.Text);

                if (axBioBridgeSDKv3lib1.DeleteUserTemplate(enrollNo, fingerId) == 0)
                {
                    List1.Items.Add(("Fingerprint Template Removed"));
                }
                else
                {
                    List1.Items.Add(("Unable to Remove!!"));
                }
            }
        }

        //function to get the user group number based on the enrollment number
        private void btnGetUsergroup_Click(object sender, EventArgs e)
        {
            int enrollNo = 0;
            int groupNo = 0;

            if (txtEnrollNoTimezone.Text == "")
            {
                MessageBox.Show("Required Field: Enroll No!!");
            }
            else
            {
                enrollNo = Convert.ToInt32(txtEnrollNoTimezone.Text);

                if (axBioBridgeSDKv3lib1.GetUserGroup(enrollNo, ref groupNo) == 0)
                {
                    List1.Items.Add(("Enroll No: " + Convert.ToString(enrollNo) + " Group No: " + Convert.ToString(groupNo)));
                    txtGroupNo.Text = Convert.ToString(groupNo);
                }
                else
                {
                    List1.Items.Add(("Record Not Found!!"));
                }
            }
        }

        //function to set / update the user group number
        private void btnSetUsergroup_Click(object sender, EventArgs e)
        {
            int enrollNo = 0;
            int groupNo = 0;

            if (txtEnrollNoTimezone.Text == "" || txtGroupNo.Text == "")
            {
                MessageBox.Show("Required Field: Enroll No or Group No!!");
            }
            else
            {
                enrollNo = Convert.ToInt32(txtEnrollNoTimezone.Text);
                groupNo = Convert.ToInt32(txtGroupNo.Text);

                if (axBioBridgeSDKv3lib1.SetUserGroup(enrollNo, groupNo) == 0)
                {
                    List1.Items.Add(("Group No Set"));
                }
                else
                {
                    List1.Items.Add(("Unable to Set Group No!!"));
                }
            }
        }

        //get the user timezone based on the enrollment number
        private void btnGetTimeZone_Click(object sender, EventArgs e)
        {
            int enrollNo = 0;
            string timeZone = "";

            if (txtEnrollNoTimezone.Text == "")
            {
                MessageBox.Show("Required Field: Enroll No!!");
            }
            else
            {
                enrollNo = Convert.ToInt32(txtEnrollNoTimezone.Text);

                if (axBioBridgeSDKv3lib1.GetUserTimezone(enrollNo, ref timeZone) == 0)
                {
                    List1.Items.Add(("Enroll No: " + Convert.ToString(enrollNo) + " Group No: " + timeZone));
                    txtTimeZoneInfo.Text = timeZone;
                }
                else
                {
                    List1.Items.Add(("Unable to Get User Timezone!!"));
                }
            }
        }

        //function to set / update user timezone
        private void btnSetTimeZone_Click(object sender, EventArgs e)
        {
            int enrollNo = 0;
            string timeZone = "";

            if (txtEnrollNoTimezone.Text == "" || txtEnrollNoTimezone.Text == "")
            {
                MessageBox.Show("Required Field: Enroll No or TimeZone!!");
            }
            else
            {
                enrollNo = Convert.ToInt32(txtEnrollNoTimezone.Text);
                timeZone = txtTimeZoneInfo.Text;

                if (axBioBridgeSDKv3lib1.SetUserTimezone(enrollNo, timeZone) == 0)
                {
                    List1.Items.Add(("Enroll No: " + Convert.ToString(enrollNo) + " Timezone: " + timeZone));
                }
                else
                {
                    List1.Items.Add(("Unable to Set Timezone!"));
                }
            }
        }

        //function to get the group timezone
        private void btnGetGTimeZone_Click(object sender, EventArgs e)
        {
            int groupNo = 0;
            string timeZone = "";

            if (txtGroupNo.Text == "")
            {
                MessageBox.Show("Required Field: Group No!!");
            }
            else
            {
                groupNo = Convert.ToInt32(txtGroupNo.Text);

                if (axBioBridgeSDKv3lib1.GetGroupTimezone(groupNo, ref timeZone) == 0)
                {
                    List1.Items.Add(("Group No: " + Convert.ToString(groupNo) + " Timezone: " + timeZone));
                    txtTimeZoneInfo.Text = timeZone;
                }
                else
                {
                    List1.Items.Add(("No Record Found!!"));
                }
            }
        }

        //function to set / update the group timezone
        private void btnSetGTimeZone_Click(object sender, EventArgs e)
        {
            int groupNo = 0;
            string timeZone = "";

            if (txtGroupNo.Text == "" || txtTimeZoneInfo.Text == "")
            {
                MessageBox.Show("Required Field: Group No or TimeZone!!");
            }
            else
            {
                groupNo = Convert.ToInt32(txtGroupNo.Text);
                timeZone = txtTimeZoneInfo.Text;

                if (axBioBridgeSDKv3lib1.SetGroupTimezone(groupNo, timeZone) == 0)
                {
                    List1.Items.Add(("Group Timezone Set"));
                }
                else
                {
                    List1.Items.Add(("Unable to set Timezone!"));
                }
            }
        }

        //function to get the timezone string based on the timezone id
        private void btnGetTimeZoneNo_Click(object sender, EventArgs e)
        {
            int timeZoneId = 0;
            string timeZoneInfo = "";

            if (txtTimeZoneNo.Text == "")
            {
                MessageBox.Show("Required Field: TimeZone No!!");
            }
            else
            {
                timeZoneId = Convert.ToInt32(txtTimeZoneNo.Text);

                if (axBioBridgeSDKv3lib1.GetTimezoneInfo(timeZoneId, ref timeZoneInfo) == 0)
                {
                    List1.Items.Add(("TimeZone ID: " + Convert.ToString(timeZoneId) + " Info: " + timeZoneInfo));
                    txtTimeZoneStr.Text = timeZoneInfo;
                }
                else
                {
                    List1.Items.Add(("TimeZone Not Found!!"));
                }
            }
        }

        //function to set / update the timezone string information
        private void btnSetTimeZoneNo_Click(object sender, EventArgs e)
        {
            int timeZoneId = 0;
            string timeZoneInfo = "";

            if (txtTimeZoneNo.Text == "" || txtTimeZoneStr.Text == "")
            {
                MessageBox.Show("Required Field: TimeZone No or TimeZone Info!!");
            }
            else
            {
                timeZoneId = Convert.ToInt32(txtTimeZoneNo.Text);
                timeZoneInfo = txtTimeZoneStr.Text;

                if (axBioBridgeSDKv3lib1.SetTimezoneInfo(timeZoneId, timeZoneInfo) == 0)
                {
                    List1.Items.Add(("TimeZone Set"));
                }
                else
                {
                    List1.Items.Add(("Unable to Set TimeZone!!"));
                }
            }
        }

        //function to get the unlock groups
        private void btnGetUnlockG_Click(object sender, EventArgs e)
        {
            string unlockGroup = "";

            if (axBioBridgeSDKv3lib1.GetUnlockGroup(ref unlockGroup) == 0)
            {
                List1.Items.Add(("Unlock group: " + unlockGroup));
                txtUnlockGroup.Text = unlockGroup;
            }
            else
            {
                List1.Items.Add(("Unlock group Not Found!!"));
            }
        }

        //function to set the unlock groups
        private void btnSetUnlockG_Click(object sender, EventArgs e)
        {
            string unlockGroup = "";

            unlockGroup = txtUnlockGroup.Text;

            if (axBioBridgeSDKv3lib1.SetUnlockGroup(unlockGroup) == 0)
            {
                List1.Items.Add(("Unlock Group Set"));
            }
            else
            {
                List1.Items.Add(("Unable to Set!!"));
            }
        }

        //open the specific filename
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            txtFilename.Text = openFileDialog1.FileName;
        }

        //function to get the user data from a filename
        private void btnGetUserFileUSB_Click(object sender, EventArgs e)
        {
            //short Index = btnGetUserFileUSB.//GetIndex(sender);
            object record = "";
            int enrollNo = 0;
            string name_Renamed = "";
            string pwd = "";
            int priv = 0;
            int TZgroup = 0;
            string TZinfo = "";
            string fileName = "";

            if (txtFilename.Text == "")
            {
                MessageBox.Show("Required Field: FileName!!");
            }
            else
            {
                fileName = txtFilename.Text;

                if (axBioBridgeSDKv3lib1.ReadUserFile(fileName) == 0)
                {
                    do //read the user file into the memory buffer
                    {
                        List1.Items.Add(("Enroll No: " + Convert.ToString(enrollNo) + " Name: " + name_Renamed + " Pwd: " + pwd + " Privilege: " + Convert.ToString(priv) + " TimeZone G: " + Convert.ToString(TZgroup) + " TimeZone Info: " + TZinfo));
                        txtEnrollNoUSB.Text = Convert.ToString(enrollNo);
                        txtNameUSB.Text = name_Renamed;
                        txtPasswordUSB.Text = pwd;
                        txtPriviledgeUSB.Text = Convert.ToString(priv);
                        txtTimeZoneGUSB.Text = Convert.ToString(TZgroup);
                        txtTimeZoneInfoUSB.Text = TZinfo;
                        txtRecordSize.Text = Convert.ToString(record);
                    } while (axBioBridgeSDKv3lib1.GetUserFileData(ref enrollNo, ref name_Renamed, ref pwd, ref priv, ref TZgroup, ref TZinfo) == 0);
                }
                else
                {
                    List1.Items.Add(("No Record Found!!"));
                }
            }
        }

        //function to save the user information back to the file
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            int enrollNo = 0;
            string name_Renamed = "";
            string pwd = "";
            int priv = 0;
            int TZgroup = 0;
            string TZinfo = "";
            int record = 0;
            string fileName = "";
            string sCardNo = "";

            if (txtEnrollNoUSB.Text == "" || txtNameUSB.Text == "" || txtPasswordUSB.Text == "" || txtPriviledgeUSB.Text == "" || txtTimeZoneGUSB.Text == "" || txtTimeZoneInfoUSB.Text == "" || txtRecordSize.Text == "" || txtFilename.Text == "")
            {
                MessageBox.Show("Required Fields: Enroll No; Name; Pwd; Privilege; TZGroup; TZInfo; Record No; FileName!!");
            }
            else
            {
                enrollNo = Convert.ToInt32(txtEnrollNoUSB.Text);
                name_Renamed = txtNameUSB.Text;
                pwd = txtPasswordUSB.Text;
                priv = Convert.ToInt32(txtPriviledgeUSB.Text);
                TZgroup = Convert.ToInt32(txtTimeZoneGUSB.Text);
                TZinfo = txtTimeZoneInfoUSB.Text;
                record = Convert.ToInt32(txtRecordSize.Text);
                fileName = txtFilename.Text;
                sCardNo = txtCardNo.Text;

                //read the data back to the memory buffer
                if (axBioBridgeSDKv3lib1.PutUserFileDataCard(enrollNo, name_Renamed, pwd, priv, TZgroup, TZinfo, sCardNo, record) == 0)
                {
                    if (axBioBridgeSDKv3lib1.WriteUserFile(fileName) == 0)
                    {
                        List1.Items.Add(("User Info Saved to File"));
                    }
                    else
                    {
                        List1.Items.Add(("Unable to Save User Info!!"));
                    }
                }
            }
        }

        //function to get user fingerprint template from a file
        private void btnGetTemplateUSB_Click(object sender, EventArgs e)
        {
            string fileName = "";
            int enrollNo = 1;
            int fingerId = 0;
            string template = string.Empty;
            int iTmpLength = 1;
            if (txtFilename.Text == "")
            {
                MessageBox.Show("Required Field: FileName!!");
            }
            else
            {
                fileName = txtFilename.Text;
                try
                {
                    //read the user template data from a filename into a memory buffer
                    if (axBioBridgeSDKv3lib1.ReadTemplateFile(fileName) == 0)
                    {
                        //do
                        //{
                        //    List1.Items.Add(("Enroll No: " + Convert.ToString(enrollNo) + " Finger Index: " + Convert.ToString(fingerId) + " Template: " + template));
                        //    txtEnrollNoUSB.Text = Convert.ToString(enrollNo);
                        //    txtFingerIndexUSB.Text = Convert.ToString(fingerId);
                        //    txtFingerTemplateUSB.Text = template;
                        //} while (axBioBridgeSDKv3lib1.GetTemplateFileData(ref enrollNo, ref fingerId, ref template) == 0);

                        if (axBioBridgeSDKv3lib1.GetTemplateFileData(ref enrollNo, ref fingerId, ref template) == 0)
                        {
                            List1.Items.Add(("Enroll No: " + Convert.ToString(enrollNo) + " Finger Index: " + Convert.ToString(fingerId) + " Template: " + template));
                            txtEnrollNoUSB.Text = Convert.ToString(enrollNo);
                            txtFingerIndexUSB.Text = Convert.ToString(fingerId);
                            txtFingerTemplateUSB.Text = template;
                        }
                    }
                    else
                    {
                        List1.Items.Add(("No Template Found!!"));
                    }

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine(ex.StackTrace.ToString());
                }
            }
        }

        //function to save back the user fingerprint template to a file name
        private void btnSaveTemplateUSB_Click(object sender, EventArgs e)
        {
            int enrollNo = 0;
            int fingerId = 0;
            string template = "";
            int record = 0;
            string fileName = "";

            if (txtEnrollNoUSB.Text == "" || txtFingerIndexUSB.Text == "" || txtFingerTemplateUSB.Text == "" || txtRecordSize.Text == "" || txtFilename.Text == "")
            {
                MessageBox.Show("Required Fields: Enrollment No; Finger Index; Template String; Record No; FileName!!");
            }
            else
            {
                enrollNo = Convert.ToInt32(txtEnrollNoUSB.Text);
                fingerId = Convert.ToInt32(txtFingerIndexUSB.Text);
                template = txtFingerTemplateUSB.Text;
                record = Convert.ToInt32(txtRecordSize.Text);
                fileName = txtFilename.Text;

                //put the data back into the memory buffer
                if (axBioBridgeSDKv3lib1.PutTemplateFileData(enrollNo, fingerId, template, record) == 0)
                {
                    //write back the user fingerprint template data back to the file
                    if (axBioBridgeSDKv3lib1.WriteTemplateFile(fileName) == 0)
                    {
                        List1.Items.Add(("Template Saved"));
                    }
                    else
                    {
                        List1.Items.Add(("Unable to Save Template!!"));
                    }
                }
            }
        }

        private void btnDecryptAttLog_Click(object sender, EventArgs e)
        {
            string val1 = "";
            string val2 = "";
            string tmp = "";
            Form4 myForm4 = new Form4();

            int fLen = FileSystem.FreeFile();
            FileSystem.FileOpen(fLen, txtFilename.Text, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared, -1);

            tmp = new String(' ', Convert.ToInt32(FileSystem.FileLen(txtFilename.Text)));

            FileSystem.FileGet(fLen, ref tmp, -1, false);
            FileSystem.FileClose(fLen);

            val1 = tmp;
            string ReadFile = val1;

            int iRead = 10000;
            int iPos = 0;
            String FullData = "";
            String SubData = "";

            while (val1.Length > iPos)
            {
                if ((iPos + iRead) > val1.Length)
                    iRead = val1.Length - iPos;

                val2 = "";
                SubData = val1.Substring(iPos, iRead);

                if (axBioBridgeSDKv3lib1.DecryptLog(SubData, ref val2) == 0)
                    FullData = FullData + val2;

                iPos = iPos + iRead;
            }

            myForm4.Text1.Text = FullData;
            myForm4.Show();
        }
        #endregion

        #region SMS & GrpVerType Demo
        private void btnGetUserVerType_Click(object sender, EventArgs e)
        {
            int enrollNo = 0;
            int verTypeNo = 0;

            enrollNo = Convert.ToInt32(txtEnrollNoVerType.Text);

            if (axBioBridgeSDKv3lib1.GetUserVerType(enrollNo, ref verTypeNo) == 0)
            {
                lblStatus.Text = ("GetUserVerType Successed");
                txtVerType.Text = Convert.ToString(verTypeNo);
            }
            else
            {
                lblStatus.Text = ("GetUserVerType Fail");
                txtVerType.Text = "0";
            }
        }

        private void btnSetUserVerType_Click(object sender, EventArgs e)
        {
            int enrollNo = 0;
            int verTypeNo = 0;

            enrollNo = Convert.ToInt32(txtEnrollNoVerType.Text);
            verTypeNo = Convert.ToInt32(txtVerType.Text);

            if (axBioBridgeSDKv3lib1.SetUserVerType(enrollNo, verTypeNo) == 0)
            {
                lblStatus.Text = ("SetUserVerType Successed");
            }
            else
            {
                lblStatus.Text = ("SetUserVerType Fail");
            }
        }

        private void btnGetSMS_Click(object sender, EventArgs e)
        {
            int tag_Renamed = 0;
            int validMinutes = 0;
            string startTime = "";
            string content = "";
            int smsid = Convert.ToInt32(txtSMSID.Text);

            if (axBioBridgeSDKv3lib1.GetSMS(smsid, ref tag_Renamed, ref validMinutes, ref startTime, ref content) == 0)
            {
                txtContent.Text = content;

                if (tag_Renamed == 253)
                {
                    optPublic.Checked = true;
                }
                else
                {
                    optPrivate.Checked = true;
                }

                txtValidTime.Text = Convert.ToString(validMinutes);
                txtStartTime.Text = startTime;
                lblStatus.Text = ("GetSMS Successed");
            }
            else
            {
                lblStatus.Text = ("GetSMS Fail");
            }
        }

        private void btnSetSMS_Click(object sender, EventArgs e)
        {
            int smsId = 0;
            int smsTag = 0;
            int validMinutes = 0;
            string startTime = "";
            string content = "";
            //int b = 0;

            smsId = Convert.ToInt32(txtSMSID.Text);
            content = txtContent.Text;

            if ((optPublic.Checked) == true)
            {
                smsTag = 253;
            }
            else
            {
                smsTag = 254;
            }

            validMinutes = Convert.ToInt32(txtValidTime.Text);
            startTime = txtStartTime.Text;

            if (axBioBridgeSDKv3lib1.SetSMS(smsId, smsTag, validMinutes, startTime, content) == 0)
            {
                lblStatus.Text = ("Set SMS Successed");
            }
            else
            {
                lblStatus.Text = ("Set SMS Fail");
            }
        }

        private void btnDeleteSMS_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.DeleteSMS(Convert.ToInt32(txtSMSID.Text)) == 0)
            {
                lblStatus.Text = ("DeleteSMS Successed");
            }
            else
            {
                lblStatus.Text = ("DeleteSMS Fail");
            }
        }

        private void btnClearSMS_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.ClearSMS() == 0)
            {
                lblStatus.Text = ("ClearSMS Successed");
            }
            else
            {
                lblStatus.Text = ("ClearSMS Fail");
            }
        }

        private void btnSetUserSMS_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.SetUserSMS(Convert.ToInt32(txtEnrollNoSMS.Text), Convert.ToInt32(txtSMSID.Text)) == 0)
            {
                lblStatus.Text = ("SetUserSMS Successed");
            }
            else
            {
                lblStatus.Text = ("SetUserSMS Fail");
            }
        }

        private void btnDeleteUserSMS_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.DeleteUserSMS(Convert.ToInt32(txtEnrollNoSMS.Text), Convert.ToInt32(txtSMSID.Text)) == 0)
            {
                lblStatus.Text = ("DeleteUserSMS Successed");
            }
            else
            {
                lblStatus.Text = ("DeleteUserSMS Fail");
            }
        }

        private void btnClearUserSMS_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.ClearUserSMS() == 0)
            {
                lblStatus.Text = ("ClearUserSMS Successed");
            }
            else
            {
                lblStatus.Text = ("ClearUserSMS Fail");
            }
        }

        private void btnSSRSetUserSMS_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.SSR_SetUserSMS(Convert.ToString(txtEnrollNoSMS.Text), Convert.ToInt32(txtSMSID.Text)) == 0)
            {
                lblStatus.Text = ("SetUserSMS Successed");
            }
            else
            {
                lblStatus.Text = ("SetUserSMS Fail");
            }
        }

        private void btnSSRDelUserSMS_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.SSR_DeleteUserSMS(Convert.ToString(txtEnrollNoSMS.Text), Convert.ToInt32(txtSMSID.Text)) == 0)
            {
                lblStatus.Text = ("DeleteUserSMS Successed");
            }
            else
            {
                lblStatus.Text = ("DeleteUserSMS Fail");
            }
        }
        #endregion
        
        #region Color Screen Models Functions Demo
        private void btnSSRGetAllUser_Click(object sender, EventArgs e)
        {
            string enrollNo = "";
            string name_Renamed = "";
            string pwd = "";
            int priv = 0;
            Boolean enable = false;
            int iSize = 0;

            if (axBioBridgeSDKv3lib1.ReadAllUserInfo(ref iSize) == 0)
            {
                do
                {
                    listBox1.Items.Add(("Enroll No: " + enrollNo + " Name: " + name_Renamed + " Pwd: " + pwd + " Enable: " + Convert.ToString(enable)));
                } while (axBioBridgeSDKv3lib1.SSR_GetAllUserInfo(ref enrollNo, ref name_Renamed, ref pwd, ref priv, ref enable) == 0);
            }
        }

        private void btnSSRGetGeneralLog_Click(object sender, EventArgs e)
        {
            string enrollNo = "";
            int yr = 0;
            int mth = 0;
            int day_Renamed = 0;
            int hr = 0;
            int min = 0;
            int sec = 0;
            int ver = 0;
            int io = 0;
            int work = 0;
            int iSize = 0;

            //Console.WriteLine(axBioBridgeSDKv3lib1.SetLastCount(Convert.ToInt32(txtSetLastCount.Text)));

            if (axBioBridgeSDKv3lib1.ReadGeneralLog(ref iSize) == 0)
            {
                do
                {
                    listBox1.Items.Add(("No: " + enrollNo + " Date: " + Convert.ToString(day_Renamed) + "/" + Convert.ToString(mth) + "/" + Convert.ToString(yr) + " Time: " + Convert.ToString(hr) + ":" + Convert.ToString(min) + ":" + Convert.ToString(sec) + " Verify: " + Convert.ToString(ver) + " I/O: " + Convert.ToString(io) + " Work Code: " + Convert.ToString(work)));
                } while (axBioBridgeSDKv3lib1.SSR_GetGeneralLog(ref enrollNo, ref yr, ref mth, ref day_Renamed, ref hr, ref min, ref sec, ref ver, ref io, ref work) == 0);
            }
        }

        private void btnSSRGetUserInfo_Click(object sender, EventArgs e)
        {
            object Combo1;
            string enrollNo = "";
            string name_Renamed = "";
            string pwd = "";
            int level = 0;
            string cardNo = "";
            Boolean status = false;

            if (edtEnrollNo.Text == "")
            {
                MessageBox.Show("Required Field: Enrollment No!!");
            }
            else
            {
                enrollNo = edtEnrollNo.Text;
                if (axBioBridgeSDKv3lib1.SSR_GetUserInfo(enrollNo, ref name_Renamed, ref pwd, ref level, ref status) == 0)
                {
                    edtName.Text = name_Renamed;
                    edtPwd.Text = pwd;
                    edtPri.Text = Convert.ToString(level);

                    if (status)
                    {
                        edtValid.Text = "Y";
                    }
                    else
                    {
                        edtValid.Text = "N";
                    }

                    Combo1 = status;
                    //cardNo = axBioBridgeSDKv3lib1.CardNo;
                    axBioBridgeSDKv3lib1.GetCardNo(ref cardNo);
                    edtCardNo.Text = cardNo;

                    listBox1.Items.Add(("Enroll No: " + enrollNo + " Name: " + name_Renamed + " Pwd: " + pwd + " Privilege: " + Convert.ToString(level) + " Enabled: " + Convert.ToString(status) + " CardNo: " + Convert.ToString(cardNo)));
                }
                else
                {
                    listBox1.Items.Add(("No Record Found!!"));
                }
            }
        }

        private void btnSSRSetUserInfo_Click(object sender, EventArgs e)
        {
            string enrollNo = "";
            string name_Renamed = "";
            string pwd = "";
            int priv = 0;
            string cardNo = "";
            Boolean status = false;

            if (edtEnrollNo.Text == "" || edtValid.Text == "")
            {
                MessageBox.Show("Required Field: Enrollment No; Privilege!!");
            }
            else
            {
                enrollNo = edtEnrollNo.Text;
                name_Renamed = edtName.Text;
                pwd = edtPwd.Text;
                priv = Convert.ToInt32(edtPri.Text);
                //axBioBridgeSDKv3lib1.CardNo = cardNo;
                cardNo = edtCardNo.Text;
                axBioBridgeSDKv3lib1.SetCardNo(cardNo);

                if (edtValid.Text == "Y")
                {
                    status = true;
                }
                else
                {
                    status = false;
                }

                if (axBioBridgeSDKv3lib1.SSR_SetUserInfo(enrollNo, name_Renamed, pwd, priv, status) == 0)
                {
                    listBox1.Items.Add(("User Info Set"));
                    listBox1.Items.Add(("Enroll No: " + enrollNo + " Name: " + name_Renamed + " Pwd: " + pwd + " Privilege: " + Convert.ToString(priv) + " Enabled: " + Convert.ToString(status) + " CardNo: " + cardNo));
                }
                else
                {
                    listBox1.Items.Add(("No Record Found!!"));
                }
            }
        }

        private void btnSSRDelUserInfo_Click(object sender, EventArgs e)
        {
            string enrollNo = "";

            if (edtEnrollNo.Text == "")
            {
                MessageBox.Show("Required Field: Enrollment No!!");
            }
            else
            {
                enrollNo = edtEnrollNo.Text;

                if (axBioBridgeSDKv3lib1.SSR_DeleteUserData(enrollNo) == 0)
                {
                    listBox1.Items.Add(("User Information Removed"));
                }
                else
                {
                    listBox1.Items.Add(("Unable to Remove User!!"));
                }
            }
        }

        private void btnGetUserTpl_Click(object sender, EventArgs e)
        {
            string enrollNo = "";
            int fingerId = 0;
            string template = "";

            if (edtEnrollNo.Text == "" || edtFinger.Text == "")
            {
                MessageBox.Show("Required Field: Enrollment No; Finger Index No!");
            }
            else
            {
                enrollNo = edtEnrollNo.Text;
                fingerId = Convert.ToInt32(edtFinger.Text);

                if (axBioBridgeSDKv3lib1.SSR_GetUserTemplate(enrollNo, fingerId, ref template) == 0)
                {
                    listBox1.Items.Add(("Enroll No: " + enrollNo + " Index Finger: " + Convert.ToString(fingerId) + " Template: " + template));
                    mmTpl.Text = template;
                }
                else
                {
                    listBox1.Items.Add(("No User Record Found!!"));
                }
            }
        }

        private void btnSetUserTpl_Click(object sender, EventArgs e)
        {
            string enrollNo = "";
            int fingerId = 0;
            string template = "";

            if (edtEnrollNo.Text == "" || edtFinger.Text == "" || mmTpl.Text == "")
            {
                MessageBox.Show("Required Field: Enrollment No; Finger Index No; Template String!");
            }
            else
            {
                enrollNo = edtEnrollNo.Text;
                fingerId = Convert.ToInt32(edtFinger.Text);
                template = mmTpl.Text;

                if (axBioBridgeSDKv3lib1.SSR_SetUserTemplate(enrollNo, fingerId, template) == 0)
                {
                    listBox1.Items.Add(("User fingerprint template SET"));
                }
                else
                {
                    listBox1.Items.Add(("Unable to Set Fingerprint Template!"));
                }
            }
        }

        private void btnDelUserTpl_Click(object sender, EventArgs e)
        {
            int fingerId = 0;
            string enrollNo = "";

            if (edtEnrollNo.Text == "" || edtFinger.Text == "")
            {
                MessageBox.Show("Required Field: Enrollment No; Finger Index No!!");
            }
            else
            {
                enrollNo = edtEnrollNo.Text;
                fingerId = Convert.ToInt32(edtFinger.Text);

                if (axBioBridgeSDKv3lib1.SSR_DeleteUserTemplate(enrollNo, fingerId) == 0)
                {
                    listBox1.Items.Add(("Fingerprint Template Removed"));
                }
                else
                {
                    listBox1.Items.Add(("Unable to Remove!!"));
                }
            }
        }

        private void btnGetUserFace_Click(object sender, EventArgs e)
        {
            string faceTpl = "";
            mmTpl.Text = "";

            if (axBioBridgeSDKv3lib1.GetUserFace(edtEnrollNo.Text, ref faceTpl) == 0)
            {
                mmTpl.Text = faceTpl;
                listBox1.Items.Add(("GetUserFace OK"));
            }
            else
            {
                listBox1.Items.Add(("GetUserFace Error!!"));
            }
        }

        private void btnSetUserFace_Click(object sender, EventArgs e)
        {
            string faceTpl = mmTpl.Text;

            if (axBioBridgeSDKv3lib1.SetUserFace(edtEnrollNo.Text, faceTpl) == 0)
            {
                listBox1.Items.Add(("SetUserFace OK"));
            }
            else
            {
                listBox1.Items.Add(("SetUserFace Error!!"));
            }
        }

        private void btnDelUserFace_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.DeleteUserFace(edtEnrollNo.Text) == 0)
            {
                listBox1.Items.Add(("DeleteUserFace OK"));
            }
            else
            {
                listBox1.Items.Add(("DeleteUserFace Error!!"));
            }
        }

        private void btnGetWC_Click(object sender, EventArgs e)
        {
            int WCID = 0;
            string workCode = "";

            if (edtWCID.Text == "")
            {
                MessageBox.Show("Required Field: WorkCode ID!");
            }
            else
            {
                WCID = Convert.ToInt32(edtWCID.Text);

                if (axBioBridgeSDKv3lib1.SSR_GetWorkCode(WCID, ref workCode) == 0)
                {
                    edtWC.Text = workCode;
                    listBox1.Items.Add(("WorkCode ID: " + Convert.ToString(WCID) + " WorkCode: " + workCode));
                }
                else
                {
                    listBox1.Items.Add(("No WorkCode Record Found!!"));
                    edtWC.Text = "";
                }
            }
        }

        private void btnSetWC_Click(object sender, EventArgs e)
        {
            int WCID = 0;
            string workCode = "";

            if (edtWCID.Text == "" || edtWC.Text == "")
            {
                MessageBox.Show("Required Field: WorkCode ID, WorkCode!");
            }
            else
            {
                WCID = Convert.ToInt32(edtWCID.Text);
                workCode = edtWC.Text;

                if (axBioBridgeSDKv3lib1.SSR_SetWorkCode(WCID, workCode) == 0)
                {
                    listBox1.Items.Add(("WorkCode Set WorkCode ID: " + Convert.ToString(WCID) + " WorkCode:" + workCode));
                }
                else
                {
                    listBox1.Items.Add(("Unable to Set WorkCode!"));
                }
            }
        }

        private void btnDeleteWC_Click(object sender, EventArgs e)
        {
            int WCID = 0;

            if (edtWCID.Text == "")
            {
                MessageBox.Show("Required Field: WorkCode ID!");
            }
            else
            {
                WCID = Convert.ToInt32(edtWCID.Text);

                if (axBioBridgeSDKv3lib1.SSR_DeleteWorkCode(WCID) == 0)
                {
                    listBox1.Items.Add(("Deleted WorkCode ID: " + Convert.ToString(WCID)));
                }
                else
                {
                    listBox1.Items.Add(("Unable to Delete WorkCode!!"));
                }
            }
        }

        private void btnClearWC_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.SSR_ClearWorkCode() == 0)
            {
                listBox1.Items.Add(("All WorkCode Cleared"));
            }
            else
            {
                listBox1.Items.Add(("Unable to Clear WorkCode!!"));
            }
        }

        private void btnGetUnlockGroup_Click(object sender, EventArgs e)
        {
            int combNo = 0;
            int G1 = 0;
            int G2 = 0;
            int G3 = 0;
            int G4 = 0;
            int G5 = 0;

            if (edtComNo.Text == "")
            {
                MessageBox.Show("Required Field: Comb No!");
            }
            else
            {
                combNo = Convert.ToInt32(edtComNo.Text);

                if (axBioBridgeSDKv3lib1.SSR_GetUnlockGroup(combNo, ref G1, ref G2, ref G3, ref G4, ref G5) == 0)
                {
                    List1.Items.Add(("GetUnlockGroup   CombNo:" + Convert.ToString(combNo) + " Group1: " + Convert.ToString(G1) + "  Group2: " + Convert.ToString(G2) + "  Group3: " + Convert.ToString(G3) + "  Group4: " + Convert.ToString(G4) + "  Group5: " + Convert.ToString(G5)));
                    edtG1.Text = Convert.ToString(G1);
                    edtG2.Text = Convert.ToString(G2);
                    edtG3.Text = Convert.ToString(G3);
                    edtG4.Text = Convert.ToString(G4);
                    edtG5.Text = Convert.ToString(G5);
                }
                else
                {
                    List1.Items.Add(("No Record Found!!"));
                    edtG1.Text = "0";
                    edtG2.Text = "0";
                    edtG3.Text = "0";
                    edtG4.Text = "0";
                    edtG5.Text = "0";
                }
            }
        }

        private void btnSetUnlockGroup_Click(object sender, EventArgs e)
        {
            int combNo = 0;
            int G1 = 0;
            int G2 = 0;
            int G3 = 0;
            int G4 = 0;
            int G5 = 0;

            if (edtComNo.Text == "" || edtG1.Text == "" || edtG2.Text == "" || edtG3.Text == "" || edtG4.Text == "" || edtG5.Text == "")
            {
                MessageBox.Show("Required Field: Comb No, G1, G2, G3, G4, G5!");
            }
            else
            {
                combNo = Convert.ToInt32(edtComNo.Text);
                G1 = Convert.ToInt32(edtG1.Text);
                G2 = Convert.ToInt32(edtG2.Text);
                G3 = Convert.ToInt32(edtG3.Text);
                G4 = Convert.ToInt32(edtG4.Text);
                G5 = Convert.ToInt32(edtG5.Text);

                if (axBioBridgeSDKv3lib1.SSR_SetUnLockGroup(combNo, G1, G2, G3, G4, G5) == 0)
                {
                    listBox1.Items.Add(("SetUnlockGroup   CombNo:" + Convert.ToString(combNo) + " Group1: " + Convert.ToString(G1) + "  Group2: " + Convert.ToString(G2) + "  Group3: " + Convert.ToString(G3) + "  Group4: " + Convert.ToString(G4) + "  Group5: " + Convert.ToString(G5)));
                }
                else
                {
                    listBox1.Items.Add(("SetUnlockGroup Failed!!"));
                }
            }
        }

        private void btnGetGroupTZ_Click(object sender, EventArgs e)
        {
            int TZGID = 0;
            int Hol = 0;
            int VerMode = 0;
            int TZ1 = 0;
            int TZ2 = 0;
            int TZ3 = 0;

            if (edtTZGID.Text == "")
            {
                MessageBox.Show("Required Field: TimeZoneGroup!!");
            }
            else
            {
                TZGID = Convert.ToInt32(edtTZGID.Text);

                //if (axBioBridgeSDKv3lib1.SSR_GetGroupTimeZone(TZGID, ref TZ1, ref TZ2, ref TZ3, ref Hol, ref VerMode) == 0)
                //{
                //    listBox1.Items.Add(("GetGroupTimeZone :" + Convert.ToString(TZGID) + " Holiday:" + Convert.ToString(Hol) + "  VerMode:" + Convert.ToString(VerMode) + "   TZ1:" + Convert.ToString(TZ1) + " TZ2:" + Convert.ToString(TZ2) + " TZ3:" + Convert.ToString(TZ3)));
                //    edtHol.Text = Convert.ToString(Hol);
                //    edtVerMode.Text = Convert.ToString(VerMode);
                //    edtTZ1.Text = Convert.ToString(TZ1);
                //    edtTZ2.Text = Convert.ToString(TZ2);
                //    edtTZ3.Text = Convert.ToString(TZ3);
                //}
                //else
                //{
                //    listBox1.Items.Add(("No Record Found!!"));
                //    edtHol.Text = "";
                //    edtVerMode.Text = "";
                //    edtTZ1.Text = "";
                //    edtTZ2.Text = "";
                //    edtTZ3.Text = "";
                //}
            }
        }

        private void btnSetGroupTZ_Click(object sender, EventArgs e)
        {
            int TZGID = 0;
            int Hol = 0;
            int VerMode = 0;
            int TZ1 = 0;
            int TZ2 = 0;
            int TZ3 = 0;

            if (edtTZGID.Text == "" || edtHol.Text == "" || edtVerMode.Text == "" || edtTZ1.Text == "" || edtTZ2.Text == "" || edtTZ3.Text == "")
            {
                MessageBox.Show("Required Field: TimeZoneGroup, Holiday, VerMode, TZ1, TZ2, TZ3!!");
            }
            else
            {
                TZGID = Convert.ToInt32(edtTZGID.Text);
                Hol = Convert.ToInt32(edtHol.Text);
                VerMode = Convert.ToInt32(edtVerMode.Text);
                TZ1 = Convert.ToInt32(edtTZ1.Text);
                TZ2 = Convert.ToInt32(edtTZ2.Text);
                TZ3 = Convert.ToInt32(edtTZ3.Text);

                if (axBioBridgeSDKv3lib1.SSR_SetGroupTZ(TZGID, TZ1, TZ2, TZ3, Hol, VerMode) == 0)
                {
                    listBox1.Items.Add(("SetGroupTimeZone :" + Convert.ToString(TZGID) + " Holiday:" + Convert.ToString(Hol) + "  VerMode:" + Convert.ToString(VerMode) + "   TZ1:" + Convert.ToString(TZ1) + " TZ2:" + Convert.ToString(TZ2) + " TZ3:" + Convert.ToString(TZ3)));
                }
                else
                {
                    listBox1.Items.Add(("SetGroupTimeZone Failed!!"));
                }
            }
        }

        private void btnGetHoliday_Click(object sender, EventArgs e)
        {
            int HolID = 0;
            int TZID = 0;
            int BM = 0;
            int BD = 0;
            int EM = 0;
            int ED = 0;

            if (edtHolID.Text == "")
            {
                MessageBox.Show("Required Field: Holiday ID!");
            }
            else
            {
                HolID = Convert.ToInt32(edtHolID.Text);

                if (axBioBridgeSDKv3lib1.SSR_GetHoliday(HolID, ref BM, ref BD, ref EM, ref ED, ref TZID) == 0)
                {
                    listBox1.Items.Add(("GetHoliday :" + Convert.ToString(HolID) + " TZGroup:" + Convert.ToString(TZID) + "   Begin Month:" + Convert.ToString(BM) + " Begin Day:" + Convert.ToString(BD) + "   End Month:" + Convert.ToString(EM) + "   End Day:" + Convert.ToString(ED)));
                    edtTZID.Text = Convert.ToString(TZID);
                    edtBM.Text = Convert.ToString(BM);
                    edtBD.Text = Convert.ToString(BD);
                    edtEM.Text = Convert.ToString(EM);
                    edtED.Text = Convert.ToString(ED);
                }
                else
                {
                    listBox1.Items.Add(("No Record Found!!"));
                    edtTZID.Text = "";
                    edtBM.Text = "";
                    edtBD.Text = "";
                    edtEM.Text = "";
                    edtED.Text = "";
                }
            }
        }

        private void btnSetHoliday_Click(object sender, EventArgs e)
        {
            int HolID = 0;
            int TZID = 0;
            int BM = 0;
            int BD = 0;
            int EM = 0;
            int ED = 0;

            if (edtHolID.Text == "" || edtTZID.Text == "" || edtBM.Text == "" || edtBD.Text == "" || edtEM.Text == "" || edtED.Text == "")
            {
                MessageBox.Show("Required Field: Holiday ID, TimezoneGroup, Begin Month, Begin Day, End Month, End Day!");
            }
            else
            {
                HolID = Convert.ToInt32(edtHolID.Text);
                TZID = Convert.ToInt32(edtTZID.Text);
                BM = Convert.ToInt32(edtBM.Text);
                BD = Convert.ToInt32(edtBD.Text);
                EM = Convert.ToInt32(edtEM.Text);
                ED = Convert.ToInt32(edtED.Text);

                if (axBioBridgeSDKv3lib1.SSR_SetHoliday(HolID, BM, BD, EM, ED, TZID) == 0)
                {
                    listBox1.Items.Add(("SetHoliday :" + Convert.ToString(HolID) + " TZGroup:" + Convert.ToString(TZID) + "   Begin Month:" + Convert.ToString(BM) + " Begin Day:" + Convert.ToString(BD) + "   End Month:" + Convert.ToString(EM) + "   End Day:" + Convert.ToString(ED)));
                }
                else
                {
                    listBox1.Items.Add(("SetHoliday Failed!!"));
                }
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            edtFile.Text = openFileDialog1.FileName;
        }

        private void btnReadUserFile_Click(object sender, EventArgs e)
        {
            try
            {
                int enrollNo = 0;
                string name_Renamed = "";
                string pwd = "";
                string TZ = "";
                int pri = 0;
                string cardNo = "";
                int TZG = 0;

                if (edtFile.Text == "")
                {
                    MessageBox.Show("Required Field: File!");
                }
                else
                {
                    if (axBioBridgeSDKv3lib1.SSR_ReadUserFile(edtFile.Text) == 0)
                    {
                        do
                        {
                            listBox1.Items.Add(("Enroll No: " + Convert.ToString(enrollNo) + " Name: " + name_Renamed + " Pwd: " + pwd + " Privilege: " + Convert.ToString(pri) + " TimeZone G: " + Convert.ToString(TZG) + " TimeZone Info: " + TZ + "   CardNo:" + cardNo));
                            //listBox1.Items.Add(("Enroll No: " + Convert.ToString(enrollNo)));
                        } while (axBioBridgeSDKv3lib1.SSR_GetUserFileDataCard(ref enrollNo, ref name_Renamed, ref pwd, ref pri, ref TZG, ref TZ, ref cardNo) == 0);
                    }
                    else
                    {
                        listBox1.Items.Add(("No Record Found!!"));
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("error at btnReadUserFile_Click : " + ex.ToString());
            }
        }

        private void btnWriteUserFile_Click(object sender, EventArgs e)
        {
            string CardN = "";

            int enrollNo = 0;
            string name_Renamed = "";
            string pwd = "";
            int pri = 0;
            int TZG = 0;
            string TZ = "";
            string cardNo = "";

            if (edtEnrollNoU.Text == "" || edtNameU.Text == "" || edtPwdU.Text == "" || edtPriU.Text == "" || edtTZU.Text == "" || edtTZGU.Text == "" || edtCardNoU.Text == "" || edtFile.Text == "")
            {
                MessageBox.Show("Required Fields: Enroll No, Name, Pwd, Privilege, TZGroup, TZInfo, CardNo, File!");
            }
            else
            {
                enrollNo = Convert.ToInt32(edtEnrollNoU.Text);
                name_Renamed = edtNameU.Text;
                pwd = edtPwdU.Text;
                pri = Convert.ToInt32(edtPriU.Text);
                TZG = Convert.ToInt32(edtTZGU.Text);
                TZ = edtTZU.Text;
                CardN = edtCardNoU.Text;

                //read the data back to the memory buffer
                if (axBioBridgeSDKv3lib1.SSR_PutUserFileDataCard(enrollNo, name_Renamed, pwd, pri, TZG, TZ, cardNo, 1) == 0)
                {
                    //write back and save the data into the file
                    if (axBioBridgeSDKv3lib1.SSR_WriteUserFile(edtFile.Text) == 0)
                    {
                        listBox1.Items.Add(("User Info Saved to File"));
                    }
                    else
                    {
                        listBox1.Items.Add(("Unable to Save User Info!!"));
                    }
                }
            }
        }

        private void btnGetTemplateFileData_Click(object sender, EventArgs e)
        {
            int enrollNo = 0;
            int fingerId = 0;
            string template = "";

            if (edtFile.Text == "")
            {
                MessageBox.Show("Required Field: FileName!");
            }
            else
            {
                //read the user template data from a filename into a memory buffer
                if (axBioBridgeSDKv3lib1.ReadTemplateFile(edtFile.Text) == 0)
                {
                    //get the user template from the memory buffer
                    do
                    {
                        listBox1.Items.Add(("Enroll No: " + Convert.ToString(enrollNo) + " Finger Index: " + Convert.ToString(fingerId) + " Template: " + template));
                    } while (axBioBridgeSDKv3lib1.GetTemplateFileData(ref enrollNo, ref fingerId, ref template) == 0);
                }
                else
                {
                    listBox1.Items.Add(("No Template Found!!"));
                }
            }
        }

        private void btnSetTemplateFileData_Click(object sender, EventArgs e)
        {
            int enrollNo = 0;
            int fingerId = 0;
            string template = "";

            if (edtFile.Text == "" || edtEnrollNoT.Text == "" || edtFingerT.Text == "" || mmTplT.Text == "")
            {
                MessageBox.Show("Required Fields: Enrollment No; Finger Index; Template String; FileName!");
            }
            else
            {
                enrollNo = Convert.ToInt32(edtEnrollNoT.Text);
                fingerId = Convert.ToInt32(edtFingerT.Text);
                template = mmTplT.Text;

                //put the data back into the memory buffer
                if (axBioBridgeSDKv3lib1.PutTemplateFileData(enrollNo, fingerId, template, 1) == 0)
                {
                    if (axBioBridgeSDKv3lib1.WriteTemplateFile(edtFile.Text) == 0)
                    {
                        listBox1.Items.Add(("Template Saved"));
                    }
                    else
                    {
                        listBox1.Items.Add(("Unable to Save Template!!"));
                    }
                }
            }
        }

        private void GetFP10_Click(object sender, EventArgs e)
        {
            int enrollNo = 0;
            int fingerId = 0;
            string template = "";

            if (edtFile.Text == "")
            {
                MessageBox.Show("Required Field: FileName!");
            }
            else
            {
                //read the user template data from a filename into a memory buffer
                if (axBioBridgeSDKv3lib1.ReadFinger10File(edtFile.Text) == 0)
                {
                    do
                    {
                        listBox1.Items.Add(("Enroll No: " + Convert.ToString(enrollNo) + " Finger Index: " + Convert.ToString(fingerId) + " Template: " + template));
                    } while (axBioBridgeSDKv3lib1.GetFinger10FileData(ref enrollNo, ref fingerId, ref template) == 0);
                }
                else
                {
                    listBox1.Items.Add(("No Template Found!!"));
                }
            }
        }

        private void btnSetFP10_Click(object sender, EventArgs e)
        {
            int enrollNo = 0;
            int fingerId = 0;
            string template = "";

            if (edtFile.Text == "" || edtEnrollNoT.Text == "" || edtFingerT.Text == "" || mmTplT.Text == "")
            {
                MessageBox.Show("Required Field: Enrollment No; Finger Index; Template String; FileName!");
            }
            else
            {
                enrollNo = Convert.ToInt32(edtEnrollNoT.Text);
                fingerId = Convert.ToInt32(edtFingerT.Text);
                template = mmTplT.Text;

                //put the data back into the memory buffer
                if (axBioBridgeSDKv3lib1.PutFinger10FileData(enrollNo, fingerId, template, 1) == 0)
                {
                    if (axBioBridgeSDKv3lib1.WriteFinger10File(edtFile.Text) == 0)
                    {
                        listBox1.Items.Add(("Template Saved"));
                    }
                    else
                    {
                        listBox1.Items.Add(("Unable to Save Template!!"));
                    }
                }
            }
        }

        private void btnGetFaceData_Click(object sender, EventArgs e)
        {
            int enrollNo = 0;
            string template = "";

            if (edtFile.Text == "")
            {
                MessageBox.Show("Required Field: FileName!");
            }
            else
            {
                //read the user face template data from a filename into a memory buffer
                if (axBioBridgeSDKv3lib1.ReadFaceFile(edtFile.Text) == 0)
                {
                    //get the user face template from the memory buffer
                    do
                    {
                        listBox1.Items.Add(("Enroll No: " + Convert.ToString(enrollNo) + " Template: " + template));
                    } while (axBioBridgeSDKv3lib1.GetFaceFileData(ref enrollNo, ref template) == 0);
                }
                else
                {
                    listBox1.Items.Add(("No Template Found!!"));
                }
            }
        }

        private void btnSetFaceData_Click(object sender, EventArgs e)
        {
            int enrollNo = 0;
            string template = "";

            if (edtFile.Text == "" || edtEnrollNoT.Text == "" || mmTplT.Text == "")
            {
                MessageBox.Show("Required Fields: Enrollment No; Template String; FileName!");
            }
            else
            {
                enrollNo = Convert.ToInt32(edtEnrollNoT.Text);
                template = mmTplT.Text;

                //put the data back into the memory buffer
                if (axBioBridgeSDKv3lib1.PutFaceFileData(enrollNo, template, 1) == 0)
                {
                    if (axBioBridgeSDKv3lib1.WriteFaceFile(edtFile.Text) == 0)
                    {
                        listBox1.Items.Add(("Template Saved"));
                    }
                    else
                    {
                        listBox1.Items.Add(("Unable to Save Template!!"));
                    }
                }
            }
        }

      
        #endregion
        
        #region MULTIMEDIA DEMO
        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.UploadPicture(edtPicture.Text) == 0)
            {
                listBox2.Items.Add(("Upload Photo Success"));
            }
            else
            {
                listBox2.Items.Add(("Upload Photo Fail!!"));
            }
        }

        private void btnOpenPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            edtPicture.Text = openFileDialog1.FileName;
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.UploadUserPhoto(edtPhoto.Text) == 0)
            {
                listBox2.Items.Add(("Upload Photo Success"));
            }
            else
            {
                listBox2.Items.Add(("Upload Photo Fail!!"));
            }
        }

        private void btnOpenPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            edtPhoto.Text = openFileDialog1.FileName;
        }

        private void btnDelPicture_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.DeletePicture(edtDelPicture.Text) == 0)
            {
                listBox2.Items.Add(("Delete Picture Success"));
            }
            else
            {
                listBox2.Items.Add(("Delete Picture Fail!!"));
            }
        }

        private void btnDelPhoto_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.DeleteUserPhoto(edtDelPhoto.Text) == 0)
            {
                listBox2.Items.Add(("Delete Photo Success"));
            }
            else
            {
                listBox2.Items.Add(("Delete Photo Fail!!"));
            }
        }

        // application must run as administrator
        private void btnDownloadPhoto_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.DownloadUserPhoto(edtDownloadPhoto.Text, edtPhotoPath.Text) == 0)
            {
                listBox2.Items.Add(("Download Photo Success"));
            }
            else
            {
                listBox2.Items.Add(("Download Photo Fail!!"));
            }
        }

        // application must run as administrator
        private void btnDownloadPicture_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.DownloadPicture(edtDownloadPicture.Text, edtPicPath.Text) == 0)
            {
                listBox2.Items.Add(("Download Picture Success"));
            }
            else
            {
                listBox2.Items.Add(("Download Picture Fail!!"));
            }
        }

        private void btnGetSuccess_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\";
            string fileName = "";
            string filep = "";

            if (axBioBridgeSDKv3lib1.GetSuccessPhotos(filePath, ref filep) == 0)
            {
                int length = 0;
                int start = 1;
                int endc = (filep.IndexOf("&") + start);
                length = endc - start;
                int newstart = 0;

                while (endc > 0)
                {
                    fileName = filep.Substring(newstart, length);
                    listBox2.Items.Add(fileName);
                    start = endc + 1;
                    endc = (filep.IndexOf("&") - start);
                    length = endc - start;
                }

                MessageBox.Show("Download Success Picture Success");
            }
            else
            {
                MessageBox.Show("Download Success Picture Failed");
            }
        }

        private void btnGetFail_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\";
            string fileName = "";
            string filep = "";

            if (axBioBridgeSDKv3lib1.GetFailPhotos(filePath, ref filep) == 0)
            {
                int length = 0;
                int start = 1;
                int endc = (filep.IndexOf("&") + start);
                length = endc - start;
                int newstart = 0;

                while (endc > 0)
                {
                    fileName = filep.Substring(newstart, length);
                    listBox2.Items.Add(fileName);
                    start = endc + 1;
                    endc = (filep.IndexOf("&") - start);
                    length = endc - start;
                }
                
                MessageBox.Show("Download Success Picture Success");
            }
            else
            {
                MessageBox.Show("Download Success Picture Failed");
            }
        }
        #endregion

        #region Add On
        private void btnPowerOn_Click(object sender, EventArgs e)
        {
            int iHour = Convert.ToInt32(txtPowerHour.Text.Trim());
            int iMin = Convert.ToInt32(txtPowerMinute.Text.Trim());

            if (axBioBridgeSDKv3lib1.SetPowerOn(iHour, iMin) == 0)
            {
                listBox3.Items.Add(("Set Power On time Success"));
            }
            else
            {
                listBox3.Items.Add(("Set Power On time Fail"));
            }

        }

        private void btnPowerOff_Click(object sender, EventArgs e)
        {
            int iHour = Convert.ToInt32(txtPowerHour.Text.Trim());
            int iMin = Convert.ToInt32(txtPowerMinute.Text.Trim());

            if (axBioBridgeSDKv3lib1.SetPowerOff(iHour, iMin) == 0)
            {
                listBox3.Items.Add(("Set Power Off time Success"));
            }
            else
            {
                listBox3.Items.Add(("Set Power Off time Fail"));
            }

            

        }

        private void btnH2i_TurnAlarmOff_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.TurnOffAlarm() == 0)
            {
                listBox3.Items.Add(("Turn off alarm Success"));
            }
            else
            {
                listBox3.Items.Add(("Turn off alarm Fail"));
            }
        }

        private void btnH2iAdminCard_Get_Click(object sender, EventArgs e)
        {
            int admincard = 0;
            if (axBioBridgeSDKv3lib1.GetAdminCardNumber(ref admincard) == 0)
            {
                txtH2iAdminCard.Text = admincard.ToString();
                listBox3.Items.Add(("Administrator Card Number = " + admincard));
            }
            else
            {
                listBox3.Items.Add(("Get Administrator Card Number Fail"));
            }
              
        }

        private void btnH2iAdminCard_Set_Click(object sender, EventArgs e)
        {
            int admincard = Convert.ToInt32(txtH2iAdminCard.Text.Trim());
            if (axBioBridgeSDKv3lib1.SetAdminCardNumber(admincard) == 0)
            {
                listBox3.Items.Add(("Set Administrator Card Number success "));
            }
            else
            {
                listBox3.Items.Add(("Set Administrator Card Number Fail"));
            }
        }
        
        private void btnSetAntipassback_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.SetAntipassback(txtAntipassback.Text.Trim()) == 0)
            {
                listBox3.Items.Add(("Set Antipassback Success"));
            }
            else
            {
                listBox3.Items.Add(("Set Antipassback Fail"));
            }
        }

        private void btnGetAntipassback_Click(object sender, EventArgs e)
        {
            string antipass = string.Empty;
            if (axBioBridgeSDKv3lib1.GetAntipassback(ref antipass ) == 0)
            {
                listBox3.Items.Add(("Antipassback = " + antipass ));
            }
            else
            {
                listBox3.Items.Add(("Set Antipassback Fail"));
            }

            txtAntipassback.Text = antipass;
        }

        private void btnClearErrorCard_Click(object sender, EventArgs e)
        {
            //if (axBioBridgeSDKv3lib1.ClearErrorCard() == 0)
            //{
            //    listBox3.Items.Add(("Clear error card number success"));
            //}
            //else
            //{
            //    listBox3.Items.Add(("Clear error card number Fail"));
            //}
        }

        private void btnGetErrorCard_Click(object sender, EventArgs e)
        { 
            if (axBioBridgeSDKv3lib1.ReadErrorCard() == 0)
            {
                int card = 0;
                string str = string.Empty;
                while (axBioBridgeSDKv3lib1.GetErrorCardData(ref card, ref str) == 0)
                {
                    listBox3.Items.Add(("Error Card Number : CardNum.=" + card.ToString() + " ,DateTime=" + str  ));
                } 
            }
            else
            {
                listBox3.Items.Add(("Get error card number Fail"));
            }
        }

        private void btnBeginStart_Click(object sender, EventArgs e)
        {
            if (txtBeginEnroll.Text.Trim() == "")
            {
                listBox3.Items.Add(("Enroll No cannot be empty!!!"));
                return;
            }

            string pass = txtBeginPassword.Text.Trim();
            string card = txtBeginCard.Text.Trim() == "" ? "0" : txtBeginCard.Text.Trim();

            axBioBridgeSDKv3lib1.SetCardNo(card);
            if (axBioBridgeSDKv3lib1.IsTFT() == 0)
            {
                axBioBridgeSDKv3lib1.BeginBatchUpdate();
                axBioBridgeSDKv3lib1.SSR_SetUserInfo(txtBeginEnroll.Text.Trim(), "", pass, 0, true);
                axBioBridgeSDKv3lib1.BatchUpdate();
            }
            else
            {
                axBioBridgeSDKv3lib1.BeginBatchUpdate();
                axBioBridgeSDKv3lib1.SetUserInfo(Convert.ToInt32(txtBeginEnroll.Text.Trim()), "", pass, 0, true);
                axBioBridgeSDKv3lib1.BatchUpdate();
            }

            listBox3.Items.Add(("Begin batch update complete."));
        }

        private void btnGatewayGet_Click(object sender, EventArgs e)
        {
            string Gateway = string.Empty;
            if (axBioBridgeSDKv3lib1.GetGateway(ref Gateway) == 0)
            {
                listBox3.Items.Add(("Gateway = " + Gateway));
            }
            else
            {
                listBox3.Items.Add(("Set Gateway Fail"));
            }

          txtGateway   .Text = Gateway;
        }

        private void btnGatewaySet_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.SetGateway (txtGateway.Text.Trim()) == 0)
            {
                listBox3.Items.Add(("Set Gateway Success"));
            }
            else
            {
                listBox3.Items.Add(("Set Gateway Fail"));
            }
        }

        private void btnSubnetGet_Click(object sender, EventArgs e)
        {
            string SubnetMask = string.Empty;
            if (axBioBridgeSDKv3lib1.GetSubnetMask( ref SubnetMask) == 0)
            {
                listBox3.Items.Add(("SubnetMask = " + SubnetMask));
            }
            else
            {
                listBox3.Items.Add(("Set SubnetMask Fail"));
            }

            txtSubnet.Text = SubnetMask;
        }

        private void btnSubnetSet_Click(object sender, EventArgs e)
        {
            if (axBioBridgeSDKv3lib1.SetSubnetMask(txtSubnet.Text.Trim()) == 0)
            {
                listBox3.Items.Add(("Set Subnet Mask Success"));
            }
            else
            {
                listBox3.Items.Add(("Set Subnet Mask Fail"));
            }
        }

        private void btnPlatform_Click(object sender, EventArgs e)
        {
            string Platform = string.Empty;
            if (axBioBridgeSDKv3lib1.GetPlatform(ref Platform) == 0)
            {
                listBox3.Items.Add(("Platform = " + Platform));
            }
            else
            {
                listBox3.Items.Add(("Get Platform Fail"));
            }

            txtPlatform.Text = Platform;
        }
         
        private void btnSleepGet_Click(object sender, EventArgs e)
        {
            int hour = 0;
            int min = 0;

            if (axBioBridgeSDKv3lib1.GetSleep(ref hour,ref min) == 0)
            { 
                listBox3.Items.Add(("Sleep time=" + hour + ":" + min ));
            }
            else
            {
                listBox3.Items.Add(("Get Sleep time Fail"));
            }
            txtSleepH.Text = hour.ToString();
            txtSleepM.Text = min.ToString();
        }

        private void btnSleepSet_Click(object sender, EventArgs e)
        {
            int hour = Convert.ToInt32(txtSleepH.Text.Trim());
            int min = Convert.ToInt32(txtSleepM.Text.Trim());
            if (axBioBridgeSDKv3lib1.SetSleep(hour, min) == 0)
            {
                listBox3.Items.Add(("Set Sleep time success"));
            }
            else
            {
                listBox3.Items.Add(("Set Sleep time Fail"));
            }
        }

        private void btnGroupTimezone_Get_Click(object sender, EventArgs e)
        {
            int groupid = Convert.ToInt32(txtGroupTimezone_Group.Text.Trim());
            string timezone = string.Empty;
            string verifystyle = string.Empty;

            if (axBioBridgeSDKv3lib1.GetGroupTimezoneVerify(groupid, ref timezone, ref verifystyle) == 0)
            {
                listBox3.Items.Add(("Get Group Timezone Verify success"));
            }
            else
            {
                listBox3.Items.Add(("Get Group Timezone Verify Fail"));
            }

            txtGroupTimezone_Timezone.Text = timezone;
            txtGroupTimezone_Verify.Text = verifystyle;
        }

        private void btnGroupTimezone_Set_Click(object sender, EventArgs e)
        {
            int groupid = Convert.ToInt32(txtGroupTimezone_Group.Text.Trim());
            string timezone = txtGroupTimezone_Timezone.Text.Trim();
            string verifystyle = txtGroupTimezone_Verify.Text.Trim();

            if (axBioBridgeSDKv3lib1.SetGroupTimezoneVerify(groupid, timezone, verifystyle) == 0)
            {
                listBox3.Items.Add(("Set Group Timezone Verify success"));
            }
            else
            {
                listBox3.Items.Add(("Set Group Timezone Verify Fail"));
            }


        }
        #endregion
         
        #region Clear
        private void btnListBox3Clear_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }

        private void btnListBox2Clear_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void btnListBox1Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List1.Items.Clear();
        }


        #endregion

        private void btnSetHolidayParam_Click(object sender, EventArgs e)
        {
            if (!(txtHolidayParamId.Text == "" || txtTZHolidayParam.Text == "" || txtStartMonth.Text == "" || txtStartDay.Text == "" || txtEndMonth.Text == "" || txtEndDay.Text == ""))
            {
                int iHolidayid = Convert.ToInt32(txtHolidayParamId.Text);
                int iTimezoneId = Convert.ToInt32(txtTZHolidayParam.Text);
                int iSM = Convert.ToInt32(txtStartMonth.Text);
                int iSD = Convert.ToInt32(txtStartDay.Text);
                int iEM = Convert.ToInt32(txtEndMonth.Text);
                int iED = Convert.ToInt32(txtEndDay.Text);

                axBioBridgeSDKv3lib1.SetHolidayParam(iHolidayid, iTimezoneId, iSM, iSD, iEM, iED);
            }
            else
            {
                MessageBox.Show("required field not fill in");
            }
        }

        private void btnGetHolidayParam_Click(object sender, EventArgs e)
        {
            int iTZ = 0, iStartM = 0, iStartD = 0, iEndM = 0, iEndD = 0, iHolidayId = 0;
            iHolidayId = Convert.ToInt32(txtHolidayParamId.Text);

            if (axBioBridgeSDKv3lib1.GetHolidayParam(1, ref iTZ, ref iStartM, ref iStartD, ref iEndM, ref iEndD) == 0)
            {
                txtTZHolidayParam.Text = iTZ.ToString();
                txtStartMonth.Text = iStartM.ToString();
                txtStartDay.Text = iStartD.ToString();
                txtEndMonth.Text = iEndM.ToString();
                txtEndDay.Text = iEndD.ToString();
            }
        }

        private void btnSetEveryWeekTimezone_Click(object sender, EventArgs e)
        {
            //load from text box
            string sTimeZone = string.Empty;
            string sVerifyCode = string.Empty;
            int iDayOfWeek = Convert.ToInt32(txtDayOfWeek.Text);
            sTimeZone = GetEveryTimeZone(lEveryTimezoneToList());
            sVerifyCode = GetVerifyCodeEveryTimezone(lVerifyCodeEveryTimezone());

            if (axBioBridgeSDKv3lib1.SetEveryWeekTimeZone(iDayOfWeek, sTimeZone, sVerifyCode) == 0)
            {
                MessageBox.Show("SetEveryWeekTimeZone Successful");
            }
            else
            {
                MessageBox.Show("SetEveryWeekTimeZone failed");
            }

            axBioBridgeSDKv3lib1.Refresh();
        }

        private void btnGetEveryWeekTimezone_Click(object sender, EventArgs e)
        {
            string ss = string.Empty, sTZ = string.Empty, sVS = string.Empty;
            List<TextBox> lTextBoxVC = lTextboxVC();//get all start time and end time textbox
            List<TextBox> lTextBox = lTextbox();// get all VC textbox

            if (axBioBridgeSDKv3lib1.GetEveryWeekTimeZone(Convert.ToInt32(txtDayOfWeek.Text), ref sTZ, ref sVS) == 0)
            {
                if (sVS.Length > 100)
                {
                    sVS = sVS.Remove(100);//remove character from index 100 
                }
                List<string> lTZ = Enumerable.Range(0, sTZ.Length / 4).Select(i => sTZ.Substring(i * 4, 4)).ToList();//split string by 4 char to list
                List<string> lVS = Enumerable.Range(0, sVS.Length / 2).Select(i => sVS.Substring(i * 2, 2)).ToList();//split string by 2 char to list

                for (int i = 0; i < lTZ.Count; i++)//100 item - 50 Start time, 50 End time
                {
                    lTextBox[i].Text = lTZ[i];//assign value to respective textbox
                }

                for (int i = 0; i < lVS.Count; i++)
                {
                    lTextBoxVC[i].Text = lVS[i];//assign value to respective verifycode textbox
                }
            }
        }

        protected List<string> lEveryTimezoneToList()
        {
            List<string> lTimezone = new List<string>();
            lTimezone.Add(txtSt1.Text);
            lTimezone.Add(txtEt1.Text);
            lTimezone.Add(txtSt2.Text);
            lTimezone.Add(txtEt2.Text);
            lTimezone.Add(txtSt3.Text);
            lTimezone.Add(txtEt3.Text);
            lTimezone.Add(txtSt4.Text);
            lTimezone.Add(txtEt4.Text);
            lTimezone.Add(txtSt5.Text);
            lTimezone.Add(txtEt5.Text);
            lTimezone.Add(txtSt6.Text);
            lTimezone.Add(txtEt6.Text);
            lTimezone.Add(txtSt7.Text);
            lTimezone.Add(txtEt7.Text);
            lTimezone.Add(txtSt8.Text);
            lTimezone.Add(txtEt8.Text);
            lTimezone.Add(txtSt9.Text);
            lTimezone.Add(txtEt9.Text);
            lTimezone.Add(txtSt10.Text);
            lTimezone.Add(txtEt10.Text);

            lTimezone.Add(txtSt11.Text);
            lTimezone.Add(txtEt11.Text);
            lTimezone.Add(txtSt12.Text);
            lTimezone.Add(txtEt12.Text);
            lTimezone.Add(txtSt13.Text);
            lTimezone.Add(txtEt13.Text);
            lTimezone.Add(txtSt14.Text);
            lTimezone.Add(txtEt14.Text);
            lTimezone.Add(txtSt15.Text);
            lTimezone.Add(txtEt15.Text);
            lTimezone.Add(txtSt16.Text);
            lTimezone.Add(txtEt16.Text);
            lTimezone.Add(txtSt17.Text);
            lTimezone.Add(txtEt17.Text);
            lTimezone.Add(txtSt18.Text);
            lTimezone.Add(txtEt18.Text);
            lTimezone.Add(txtSt19.Text);
            lTimezone.Add(txtEt19.Text);
            lTimezone.Add(txtSt20.Text);
            lTimezone.Add(txtEt20.Text);

            lTimezone.Add(txtSt21.Text);
            lTimezone.Add(txtEt21.Text);
            lTimezone.Add(txtSt22.Text);
            lTimezone.Add(txtEt22.Text);
            lTimezone.Add(txtSt23.Text);
            lTimezone.Add(txtEt23.Text);
            lTimezone.Add(txtSt24.Text);
            lTimezone.Add(txtEt24.Text);
            lTimezone.Add(txtSt25.Text);
            lTimezone.Add(txtEt25.Text);
            lTimezone.Add(txtSt26.Text);
            lTimezone.Add(txtEt26.Text);
            lTimezone.Add(txtSt27.Text);
            lTimezone.Add(txtEt27.Text);
            lTimezone.Add(txtSt28.Text);
            lTimezone.Add(txtEt28.Text);
            lTimezone.Add(txtSt29.Text);
            lTimezone.Add(txtEt29.Text);
            lTimezone.Add(txtSt30.Text);
            lTimezone.Add(txtEt30.Text);

            lTimezone.Add(txtSt31.Text);
            lTimezone.Add(txtEt31.Text);
            lTimezone.Add(txtSt32.Text);
            lTimezone.Add(txtEt32.Text);
            lTimezone.Add(txtSt33.Text);
            lTimezone.Add(txtEt33.Text);
            lTimezone.Add(txtSt34.Text);
            lTimezone.Add(txtEt34.Text);
            lTimezone.Add(txtSt35.Text);
            lTimezone.Add(txtEt35.Text);
            lTimezone.Add(txtSt36.Text);
            lTimezone.Add(txtEt36.Text);
            lTimezone.Add(txtSt37.Text);
            lTimezone.Add(txtEt37.Text);
            lTimezone.Add(txtSt38.Text);
            lTimezone.Add(txtEt38.Text);
            lTimezone.Add(txtSt39.Text);
            lTimezone.Add(txtEt39.Text);
            lTimezone.Add(txtSt40.Text);
            lTimezone.Add(txtEt40.Text);

            lTimezone.Add(txtSt41.Text);
            lTimezone.Add(txtEt41.Text);
            lTimezone.Add(txtSt42.Text);
            lTimezone.Add(txtEt42.Text);
            lTimezone.Add(txtSt43.Text);
            lTimezone.Add(txtEt43.Text);
            lTimezone.Add(txtSt44.Text);
            lTimezone.Add(txtEt44.Text);
            lTimezone.Add(txtSt45.Text);
            lTimezone.Add(txtEt45.Text);
            lTimezone.Add(txtSt46.Text);
            lTimezone.Add(txtEt46.Text);
            lTimezone.Add(txtSt47.Text);
            lTimezone.Add(txtEt47.Text);
            lTimezone.Add(txtSt48.Text);
            lTimezone.Add(txtEt48.Text);
            lTimezone.Add(txtSt49.Text);
            lTimezone.Add(txtEt49.Text);
            lTimezone.Add(txtSt50.Text);
            lTimezone.Add(txtEt50.Text);

            return lTimezone;
        }

        protected string GetEveryTimeZone(List<string> lEveryTimezone)
        {
            string sEveryTimezone = string.Empty;

            foreach (string sTimezone in lEveryTimezone)
            {
                sEveryTimezone += sTimezone;
            }

            return sEveryTimezone;
        }

        protected List<string> lVerifyCodeEveryTimezone()
        {
            List<string> lVerifyCode = new List<string>();

            lVerifyCode.Add(txtVc1.Text);
            lVerifyCode.Add(txtVc2.Text);
            lVerifyCode.Add(txtVc3.Text);
            lVerifyCode.Add(txtVc4.Text);
            lVerifyCode.Add(txtVc5.Text);
            lVerifyCode.Add(txtVc6.Text);
            lVerifyCode.Add(txtVc7.Text);
            lVerifyCode.Add(txtVc8.Text);
            lVerifyCode.Add(txtVc9.Text);
            lVerifyCode.Add(txtVc10.Text);

            lVerifyCode.Add(txtVc11.Text);
            lVerifyCode.Add(txtVc12.Text);
            lVerifyCode.Add(txtVc13.Text);
            lVerifyCode.Add(txtVc14.Text);
            lVerifyCode.Add(txtVc15.Text);
            lVerifyCode.Add(txtVc16.Text);
            lVerifyCode.Add(txtVc17.Text);
            lVerifyCode.Add(txtVc18.Text);
            lVerifyCode.Add(txtVc19.Text);
            lVerifyCode.Add(txtVc20.Text);

            lVerifyCode.Add(txtVc21.Text);
            lVerifyCode.Add(txtVc22.Text);
            lVerifyCode.Add(txtVc23.Text);
            lVerifyCode.Add(txtVc24.Text);
            lVerifyCode.Add(txtVc25.Text);
            lVerifyCode.Add(txtVc26.Text);
            lVerifyCode.Add(txtVc27.Text);
            lVerifyCode.Add(txtVc28.Text);
            lVerifyCode.Add(txtVc29.Text);
            lVerifyCode.Add(txtVc30.Text);

            lVerifyCode.Add(txtVc31.Text);
            lVerifyCode.Add(txtVc32.Text);
            lVerifyCode.Add(txtVc33.Text);
            lVerifyCode.Add(txtVc34.Text);
            lVerifyCode.Add(txtVc35.Text);
            lVerifyCode.Add(txtVc36.Text);
            lVerifyCode.Add(txtVc37.Text);
            lVerifyCode.Add(txtVc38.Text);
            lVerifyCode.Add(txtVc39.Text);
            lVerifyCode.Add(txtVc40.Text);

            lVerifyCode.Add(txtVc41.Text);
            lVerifyCode.Add(txtVc42.Text);
            lVerifyCode.Add(txtVc43.Text);
            lVerifyCode.Add(txtVc44.Text);
            lVerifyCode.Add(txtVc45.Text);
            lVerifyCode.Add(txtVc46.Text);
            lVerifyCode.Add(txtVc47.Text);
            lVerifyCode.Add(txtVc48.Text);
            lVerifyCode.Add(txtVc49.Text);
            lVerifyCode.Add(txtVc50.Text);

            return lVerifyCode;
        }

        protected List<TextBox> lTextbox()
        {
            List<TextBox> lTxtBox = new List<TextBox>();

            lTxtBox.Add(txtSt1);
            lTxtBox.Add(txtEt1);
            lTxtBox.Add(txtSt2);
            lTxtBox.Add(txtEt2);
            lTxtBox.Add(txtSt3);
            lTxtBox.Add(txtEt3);
            lTxtBox.Add(txtSt4);
            lTxtBox.Add(txtEt4);
            lTxtBox.Add(txtSt5);
            lTxtBox.Add(txtEt5);
            lTxtBox.Add(txtSt6);
            lTxtBox.Add(txtEt6);
            lTxtBox.Add(txtSt7);
            lTxtBox.Add(txtEt7);
            lTxtBox.Add(txtSt8);
            lTxtBox.Add(txtEt8);
            lTxtBox.Add(txtSt9);
            lTxtBox.Add(txtEt9);
            lTxtBox.Add(txtSt10);
            lTxtBox.Add(txtEt10);

            lTxtBox.Add(txtSt11);
            lTxtBox.Add(txtEt11);
            lTxtBox.Add(txtSt12);
            lTxtBox.Add(txtEt12);
            lTxtBox.Add(txtSt13);
            lTxtBox.Add(txtEt13);
            lTxtBox.Add(txtSt14);
            lTxtBox.Add(txtEt14);
            lTxtBox.Add(txtSt15);
            lTxtBox.Add(txtEt15);
            lTxtBox.Add(txtSt16);
            lTxtBox.Add(txtEt16);
            lTxtBox.Add(txtSt17);
            lTxtBox.Add(txtEt17);
            lTxtBox.Add(txtSt18);
            lTxtBox.Add(txtEt18);
            lTxtBox.Add(txtSt19);
            lTxtBox.Add(txtEt19);
            lTxtBox.Add(txtSt20);
            lTxtBox.Add(txtEt20);

            lTxtBox.Add(txtSt21);
            lTxtBox.Add(txtEt21);
            lTxtBox.Add(txtSt22);
            lTxtBox.Add(txtEt22);
            lTxtBox.Add(txtSt23);
            lTxtBox.Add(txtEt23);
            lTxtBox.Add(txtSt24);
            lTxtBox.Add(txtEt24);
            lTxtBox.Add(txtSt25);
            lTxtBox.Add(txtEt25);
            lTxtBox.Add(txtSt26);
            lTxtBox.Add(txtEt26);
            lTxtBox.Add(txtSt27);
            lTxtBox.Add(txtEt27);
            lTxtBox.Add(txtSt28);
            lTxtBox.Add(txtEt28);
            lTxtBox.Add(txtSt29);
            lTxtBox.Add(txtEt29);
            lTxtBox.Add(txtSt30);
            lTxtBox.Add(txtEt30);

            lTxtBox.Add(txtSt31);
            lTxtBox.Add(txtEt31);
            lTxtBox.Add(txtSt32);
            lTxtBox.Add(txtEt32);
            lTxtBox.Add(txtSt33);
            lTxtBox.Add(txtEt33);
            lTxtBox.Add(txtSt34);
            lTxtBox.Add(txtEt34);
            lTxtBox.Add(txtSt35);
            lTxtBox.Add(txtEt35);
            lTxtBox.Add(txtSt36);
            lTxtBox.Add(txtEt36);
            lTxtBox.Add(txtSt37);
            lTxtBox.Add(txtEt37);
            lTxtBox.Add(txtSt38);
            lTxtBox.Add(txtEt38);
            lTxtBox.Add(txtSt39);
            lTxtBox.Add(txtEt39);
            lTxtBox.Add(txtSt40);
            lTxtBox.Add(txtEt40);

            lTxtBox.Add(txtSt41);
            lTxtBox.Add(txtEt41);
            lTxtBox.Add(txtSt42);
            lTxtBox.Add(txtEt42);
            lTxtBox.Add(txtSt43);
            lTxtBox.Add(txtEt43);
            lTxtBox.Add(txtSt44);
            lTxtBox.Add(txtEt44);
            lTxtBox.Add(txtSt45);
            lTxtBox.Add(txtEt45);
            lTxtBox.Add(txtSt46);
            lTxtBox.Add(txtEt46);
            lTxtBox.Add(txtSt47);
            lTxtBox.Add(txtEt47);
            lTxtBox.Add(txtSt48);
            lTxtBox.Add(txtEt48);
            lTxtBox.Add(txtSt49);
            lTxtBox.Add(txtEt49);
            lTxtBox.Add(txtSt50);
            lTxtBox.Add(txtEt50);

            return lTxtBox;
        }

        protected List<TextBox> lTextboxVC()
        {
            List<TextBox> ltextboxvc = new List<TextBox>();

            ltextboxvc.Add(txtVc1);
            ltextboxvc.Add(txtVc2);
            ltextboxvc.Add(txtVc3);
            ltextboxvc.Add(txtVc4);
            ltextboxvc.Add(txtVc5);
            ltextboxvc.Add(txtVc6);
            ltextboxvc.Add(txtVc7);
            ltextboxvc.Add(txtVc8);
            ltextboxvc.Add(txtVc9);
            ltextboxvc.Add(txtVc10);

            ltextboxvc.Add(txtVc11);
            ltextboxvc.Add(txtVc12);
            ltextboxvc.Add(txtVc13);
            ltextboxvc.Add(txtVc14);
            ltextboxvc.Add(txtVc15);
            ltextboxvc.Add(txtVc16);
            ltextboxvc.Add(txtVc17);
            ltextboxvc.Add(txtVc18);
            ltextboxvc.Add(txtVc19);
            ltextboxvc.Add(txtVc20);

            ltextboxvc.Add(txtVc21);
            ltextboxvc.Add(txtVc22);
            ltextboxvc.Add(txtVc23);
            ltextboxvc.Add(txtVc24);
            ltextboxvc.Add(txtVc25);
            ltextboxvc.Add(txtVc26);
            ltextboxvc.Add(txtVc27);
            ltextboxvc.Add(txtVc28);
            ltextboxvc.Add(txtVc29);
            ltextboxvc.Add(txtVc30);

            ltextboxvc.Add(txtVc31);
            ltextboxvc.Add(txtVc32);
            ltextboxvc.Add(txtVc33);
            ltextboxvc.Add(txtVc34);
            ltextboxvc.Add(txtVc35);
            ltextboxvc.Add(txtVc36);
            ltextboxvc.Add(txtVc37);
            ltextboxvc.Add(txtVc38);
            ltextboxvc.Add(txtVc39);
            ltextboxvc.Add(txtVc40);

            ltextboxvc.Add(txtVc41);
            ltextboxvc.Add(txtVc42);
            ltextboxvc.Add(txtVc43);
            ltextboxvc.Add(txtVc44);
            ltextboxvc.Add(txtVc45);
            ltextboxvc.Add(txtVc46);
            ltextboxvc.Add(txtVc47);
            ltextboxvc.Add(txtVc48);
            ltextboxvc.Add(txtVc49);
            ltextboxvc.Add(txtVc50);

            return ltextboxvc;
        }

        protected string GetVerifyCodeEveryTimezone(List<string> lVerifyCode)
        {
            string sVerifyCode = string.Empty;

            foreach (string sVc in lVerifyCode)
            {
                sVerifyCode += sVc;
            }

            return sVerifyCode;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //StartPosition:
            //initSync();
            //Thread.Sleep(5000);
            //goto StartPosition;
            StartTimer();


        }
        public async System.Threading.Tasks.Task StartTimer()
        {

            await Task.Run(async() =>
            {
                while (true)
                {
                    initSync();
                    await Task.Delay(100000);
                    
                }
            });

        }
        private void initSync()
        {
            using (MySqlConnection conn = new MySqlConnection("Persist Security Info=False;server=localhost;database=test;uid=root;password="))
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tblcards WHERE Processed = @Processed";
                    cmd.Parameters.AddWithValue("@Processed", 'N');

                    try
                    {
                        conn.Open();

                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {

                            int enrollNo = 0;
                            int level = 0;
                            string name_Renamed = "";
                            string pwd = "";
                            int cardNo = 0;
                            Boolean status = false;

                            if (reader.GetString(0) != null)
                            {

                                Console.WriteLine(reader.GetInt32(0));


                                enrollNo = Convert.ToInt32(reader.GetInt32(0));
                                name_Renamed = reader.GetString(2);
                                pwd = null;
                                level = Convert.ToInt32(0);
                                status = Convert.ToBoolean(true);
                                cardNo = Convert.ToInt32(reader.GetString(10));
                                axBioBridgeSDKv3lib1.SetCardNo(cardNo.ToString()); // = cardNo;

                                if (axBioBridgeSDKv3lib1.SetUserInfo(enrollNo, name_Renamed, pwd, level, status) == 0)
                                {
                                    Console.WriteLine("added : " + reader.GetString(0));
                                   // List1.Items.Add(("User Information Set"));
                                  //  List1.Items.Add(("Enroll No: " + Convert.ToString(enrollNo) + " Name: " + name_Renamed + " Pwd: " + pwd + " Privilege: " + Convert.ToString(level) + " Enabled: " + Convert.ToString(status) + " CardNo: " + Convert.ToString(cardNo)));
                                }

                            }
                            else
                            {
                                List1.Items.Add(("No Record Found!!"));
                            }

                        }

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                    }
                }
            }

            //    MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=test;uid=root;password=");
            //    MySqlCommand cmd = dbConn.CreateCommand();
            //    cmd.CommandText = "SELECT * FROM tblcards";


            //    try
            //    {
            //        dbConn.Open();
            //        MySqlDataReader reader = cmd.ExecuteReader();

            //        while (reader.Read())
            //        {
            //            Console.WriteLine(reader.GetString(0) + " ---- " + reader.GetString(1));
            //            // Console.WriteLine("Flight, Date: {0}, {1}, {2}, {3}", flight.AirLineName, Regex.Replace(flight.FlightID, @"\s+", ""), flight.Scheduled, flight.Date);
            //        }
            //    }
            //    catch (Exception erro)
            //    {

            //    }
            //    finally
            //    {
            //        dbConn.Close();
            //    }
            //}
        }
    }
}
