using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Home : Form
    {
        private System.Windows.Forms.Timer timer1;
        public MemoryStream memBuf;
      //  List<int> list = new List<int>();
        public Home()
        {
            InitializeComponent();
            memBuf = new MemoryStream();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Text = "Connecting....";
            connectDevice();
            btnConnect.Text = "Connected";
            

        }
        private void connectDevice()
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
            devNo = Convert.ToInt32(1);
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


                    ClearLog();

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

                    InitTimer();


                }
                else
                {
                    List1.Items.Add(("Unable to Connect to IP Address!!"));
                    List1.Items.Add(("Error: " + axBioBridgeSDKv3lib1.VC));
                }
            }
        }
        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            start();
        }

        private void start()
        {

            // get log
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


            axBioBridgeSDKv3lib1.SetLastCount(0);


            if (axBioBridgeSDKv3lib1.ReadGeneralLog(ref log) == 0)
            {
                do
                {

                    // list.Add(Convert.ToInt32(enrollNo));
                    if (Convert.ToInt32(enrollNo) != 0)
                    {
                        lblName.Text = "---------";
                        lblNIC.Text = "---------";
                        lblPrev.Text = "---------";
                        btnStatus.Visible = false;
                        checkDB(Convert.ToInt32(enrollNo));
                        
                    }

                    //  Console.WriteLine("FOUND -- " + Convert.ToInt32(enrollNo));
                    //List2.Invoke(t => t.Items.Add(("No: " + Convert.ToString(enrollNo) + " Date:" + Convert.ToString(day_Renamed))));
                    //  List1.Items.Add(("No: " + Convert.ToString(enrollNo) + " Date:" + Convert.ToString(day_Renamed) + "/" + Convert.ToString(mth) + "/" + Convert.ToString(yr) + " Time: " + Convert.ToString(hr) + ":" + Convert.ToString(min) + ":" + Convert.ToString(sec) + " Verify: " + Convert.ToString(ver) + " I/O: " + Convert.ToString(io) + " Work Code: " + Convert.ToString(work)));
                } while (axBioBridgeSDKv3lib1.GetGeneralLog(ref enrollNo, ref yr, ref mth, ref day_Renamed, ref hr, ref min, ref sec, ref ver, ref io, ref work) == 0);
            }
            else
            {
                List2.Invoke(t => t.Items.Insert(0,"No New Records.."));
            }
        }
       
      

        private void checkDB(int EnrolNo)
        {
            
            using (MySqlConnection conn = new MySqlConnection("Persist Security Info=False;server=localhost;database=test;uid=root;password="))
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    try
                    {
                        conn.Open();
                        cmd.CommandText = "CALL checkLog(@NO)";
                        cmd.Parameters.AddWithValue("@NO", EnrolNo);
                        //cmd.ExecuteNonQuery();
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            if (reader.GetInt32(0) != 1)
                            {
                                if(reader.GetString(3) == "Y")
                                {
                                    btnStatus.Visible = true;
                                    btnStatus.Text = "CHARGABLE";
                                    btnStatus.BackColor = Color.Red;
                                }
                                else
                                {
                                    btnStatus.Visible = true;
                                    btnStatus.Text = "NOT CHARGABLE";
                                    btnStatus.BackColor = Color.Green;
                                }
                             
                                lblName.Text = reader.GetString(2);
                                lblNIC.Text = reader.GetString(1);
                                lblPrev.Text = reader.GetString(4);
                                List2.Invoke(t => t.Items.Insert(0, "Checking : " + reader.GetString(2)));

                            }
                            else
                            {
                                MessageBox.Show("Invalid Card!!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                        }
                       


                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                    finally
                    {
                        conn.Close();
                        ClearLog();
                    }

                }
            }
        }

        private void ClearLog()
        {
            if (axBioBridgeSDKv3lib1.DeleteGeneralLog() == 0)
            {
                List2.Invoke(t => t.Items.Insert(0,"All Logs Cleared"));                
            }
            else
            {
                List2.Invoke(t => t.Items.Insert(0,"Unable to Clear"));
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
            Console.WriteLine("On Finger Event!!!");
           
            //ThreadProcSafe("On Finger Event!!!");
        }

        private void axBioBridgeSDKv3lib1_OnDisConnected(object sender, EventArgs e)
        {
            Console.WriteLine("On Disconnect!!!");

        }

        private void axBioBridgeSDKv3lib1_OnConnected(object sender, EventArgs e)
        {
            Console.WriteLine("On DisConnectconnect!!!");

        }

        private void axBioBridgeSDKv3lib1_OnAttTransactionEx(object sender, AxBioBridgeSDKv3.IBioBridgeSDKv3libEvents_OnAttTransactionExEvent e)
        {
            string smessage = string.Empty;
            string date = e.year + "-" + e.month + "-" + e.day + " " + e.hour + ":" + e.minute + ":" + e.second;
            smessage = "On Transaction Event:- Date=" + date + " ,EnrollNo=" + e.enrollNo + " ,AttState=" + e.attState + " ,IsInValid=" + e.isInValid + " ,VerifyMode=" + e.verifyMode + " ,WorkCode=" + e.workCode;
            //listBox3.Items.Add("On Transaction Event:- Date=" + date + " ,EnrollNo=" + e.enrollNo + " ,AttState=" + e.attState + " ,IsInValid=" + e.isInValid + " ,VerifyMode=" + e.verifyMode + " ,WorkCode=" + e.workCode );
            
        }

        private void axBioBridgeSDKv3lib1_OnAlarm(object sender, AxBioBridgeSDKv3.IBioBridgeSDKv3libEvents_OnAlarmEvent e)
        {
            Console.WriteLine("On Alarm!!!");

        }

        private void axBioBridgeSDKv3lib1_OnDoor(object sender, AxBioBridgeSDKv3.IBioBridgeSDKv3libEvents_OnDoorEvent e)
        {
            Console.WriteLine("On Door!!!");

        }

       
    }
}

public static class Extensions
{
    public static void Invoke<TControlType>(this TControlType control, Action<TControlType> del)
        where TControlType : Control
    {
        if (control.InvokeRequired)
            control.Invoke(new Action(() => del(control)));
        else
            del(control);
    }
}
