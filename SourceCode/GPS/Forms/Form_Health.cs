using AgOpenGPS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Net.Sockets;
// TODO: how to handle health of various machines
namespace AgOpenGPS.Forms
{
    public partial class Form_Health : Form
    {
        private System.Timers.Timer healthTimer;
        private readonly FormGPS mf = null;
        public Form_Health(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();
            initializePanels();
            healthTimer = new System.Timers.Timer
            {
                Interval = 1000 // Set interval to 1 second for logging
            };
            healthTimer.Elapsed += updateIcons;
            healthTimer.Start();

        }

        private void initializePanels()
        {
            this.Height = 80;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form_Health_Load(object sender, EventArgs e)
        {

        }

        private void updateIcons(object sender, ElapsedEventArgs e)
        {
            // Power Monitor Health
            switch (mf.mc.pm.health)
            {
                case 0:
                    pictureBoxPowerHealth.Image = Resources.Power_Off;
                    break;
                case 1:
                    pictureBoxPowerHealth.Image = Resources.Power_Active;
                    break;
                case 2:
                    pictureBoxPowerHealth.Image = Resources.Warning;
                    break;
                default:
                    break;
            }

            //// Steer Health
            //if (mf.health.steerState == 1)
            //{
            //    iconSteerState.Image = Resources.Green_Check1;
            //} else if (mf.health.steerState == 2)
            //{
            //    iconSteerState.Image = Resources.Red_X;
            //}
            //// GPS Health
            //if (mf.health.gpsState == 0)
            //{
            //    iconGPSstate.Image = Resources.Red_X;
            //}
            //else if (mf.health.gpsState == 1)
            //{
            //    iconGPSstate.Image = Resources.Green_Check1;
            //} else if (mf.health.gpsState == 2)
            //{
            //    iconGPSstate.Image = Resources.Warning;    
            //}

            // TODO: IMU Health

            // TODO: NTRIP Health
        }

        private void powerMonitorButton_Click(object sender, EventArgs e)
        {
            string webserverAddress = "http://192.168.8.2";
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet && ni.OperationalStatus == OperationalStatus.Up)
                {
                    Console.WriteLine($"Network Interface: {ni.Name}");

                    var ipProps = ni.GetIPProperties();
                    foreach (var ip in ipProps.UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork) // IPv4 address
                        {
                            // Get the IP address bytes
                            byte[] octets = ip.Address.GetAddressBytes();
                            webserverAddress = $"http://{octets[0]}.{octets[1]}.{octets[2]}.{mf.mc.pm.ipAddr}";
                            break;
                            // Print each octet



                        }
                    }
                }
            }
            //mf.showPowerMonitor();
            Process.Start(new ProcessStartInfo
            {

                FileName = webserverAddress,
                UseShellExecute = true
            });
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void iconGPSstate_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet && ni.OperationalStatus == OperationalStatus.Up)
                {
                    Console.WriteLine($"Network Interface: {ni.Name}");

                    var ipProps = ni.GetIPProperties();
                    foreach (var ip in ipProps.UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork) // IPv4 address
                        {
                            // Get the IP address bytes
                            byte[] octets = ip.Address.GetAddressBytes();

                            // Print each octet
                            Console.WriteLine($"IP Address: {ip.Address}");
                            Console.WriteLine($"Octet 1: {octets[0]}");
                            Console.WriteLine($"Octet 2: {octets[1]}");
                            Console.WriteLine($"Octet 3: {octets[2]}");
                            Console.WriteLine($"Octet 4: {octets[3]}");
                            mf.p_9506.pgn[mf.p_9506.ipAddr] = octets[3];
                        }
                    }
                }
            }


            mf.p_9506.pgn[mf.p_9506.myPGN] = 6;
            //mf.p_9506.pgn[mf.p_9506.ipAddr] = 151;
            mf.p_9506.pgn[mf.p_9506.portLowByte] = unchecked((byte)(5501));
            mf.p_9506.pgn[mf.p_9506.portHighByte] = unchecked((byte)(5501 >> 8 ));
            mf.SendPgnToLoop(mf.p_9506.pgn);
        }

      
    }
}

// TODO: use the CVehicle type variable to enable combine datalogging
// TODO: in CVehicle, calculate the yield from the mass flow sensor data
