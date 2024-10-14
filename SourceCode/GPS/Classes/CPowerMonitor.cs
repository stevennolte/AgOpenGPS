using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgOpenGPS.Classes
{

    public class CPowerMonitor
    {
        private readonly FormGPS mf;
        public bool isConnected = false;
        public byte health = 0;
        public byte version1 = 0;
        public byte version2 = 0;
        public byte version3 = 0;
        public byte keyPowerState;
        public byte pcPowerState;
        public byte isConnectedAOG;
        public byte isConnectedCAN1;
        public byte isConnectedCAN2;
        public byte isConnectedISOvehicle;
        public byte isConnectedISOimplement;
        public byte isConnectedINA219;
        public double lastMsgRecieved = 0;
        private bool isOpen = false;
        private byte prevKeyState;

        public CPowerMonitor(FormGPS _f)
        {
            //constructor
            mf = _f as FormGPS;
            
        }
        public bool checkConnection()
        {
            if ((DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds - lastMsgRecieved < 1)
            {
                if (isConnectedINA219 == 1 & isConnectedCAN1 == 1)
                {
                    health = 1;
                } 
                else
                {
                    health = 2;
                }
                return true;
            }
            else
            {
                health = 0;
                return false;
            }
            
        }
        public void checkKeyState()
        {
            if (keyPowerState == 2 && prevKeyState == 1 && !isOpen)
            {
                isOpen = true;
                DialogResult dr = MessageBox.Show("POWER DOWN?", "Want something else?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    mf.SendPgnToLoop(mf.p_9505.pgn);
                    powerDown();
                }
                else if (dr == DialogResult.Cancel)
                {
                    //
                }
             }
            prevKeyState = keyPowerState;
                // Pop up form shutdown
                // if accept or timeout, send shutdown message
                // else, cancel all
            
        }
       
        public void powerDown()
        {
            // TODO: add popup for shutdown confirmation or cancelation
            int shutdownDelay = 20; // Example: 60 seconds delay

            // Construct the shutdown command
            string shutdownCommand = $"/s /t {shutdownDelay}";
            //Process.Start("shutdown", shutdownCommand);

            Console.WriteLine($"The PC will shut down in {shutdownDelay} seconds.");

            mf.Close();
        }
    }
}
