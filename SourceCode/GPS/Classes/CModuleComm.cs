using System.Windows.Forms;
using System;
using System.Timers;

namespace AgOpenGPS
{
    public class CModuleComm
    {
        

        //copy of the mainform address
        public readonly FormGPS mf;

        #region CreateModuleSubclasses
        public AioModule aiom;
        public PowerMonitor pm;
        #endregion

        //Critical Safety Properties
        public bool isOutOfBounds = true;

        // ---- Section control switches to AOG  ---------------------------------------------------------
        //PGN - 32736 - 127.249 0x7FF9
        public byte[] ss = new byte[9];

        public byte[] ssP = new byte[9];

        public int
            swHeader = 0,
            swMain = 1,
            swReserve = 2,
            swReserve2 = 3,
            swNumSections = 4,
            swOnGr0 = 5,
            swOffGr0 = 6,
            swOnGr1 = 7,
            swOffGr1 = 8;

        public int pwmDisplay = 0;
        public double actualSteerAngleDegrees = 0;
        public int actualSteerAngleChart = 0, sensorData = -1;

        //for the workswitch
        public bool isWorkSwitchActiveLow, isRemoteWorkSystemOn, isWorkSwitchEnabled,
            isWorkSwitchManualSections, isSteerWorkSwitchManualSections, isSteerWorkSwitchEnabled;

        public bool workSwitchHigh, oldWorkSwitchHigh, steerSwitchHigh, oldSteerSwitchHigh, oldSteerSwitchRemote;
        

        //constructor
        public CModuleComm(FormGPS _f)
        {
            mf = _f;
            #region Init Module Classes
            aiom = new AioModule(mf);
            pm = new PowerMonitor(mf);
            #endregion
            //WorkSwitch logic
            isRemoteWorkSystemOn = false;

            //does a low, grounded out, mean on
            isWorkSwitchActiveLow = true;

        }

        //Called from "OpenGL.Designer.cs" when requied
        public void CheckWorkAndSteerSwitch()
        {
            //AutoSteerAuto button enable - Ray Bear inspired code - Thx Ray!
            if (mf.ahrs.isAutoSteerAuto && steerSwitchHigh != oldSteerSwitchRemote)
            {
                oldSteerSwitchRemote = steerSwitchHigh;
                //steerSwith is active low
                if (steerSwitchHigh == mf.isBtnAutoSteerOn)
                    mf.btnAutoSteer.PerformClick();
            }

            if (isRemoteWorkSystemOn)
            {
                if (isWorkSwitchEnabled && (oldWorkSwitchHigh != workSwitchHigh))
                {
                    oldWorkSwitchHigh = workSwitchHigh;

                    if (workSwitchHigh != isWorkSwitchActiveLow)
                    {
                        if (isWorkSwitchManualSections)
                        {
                            if (mf.manualBtnState != btnStates.On)
                                mf.btnSectionMasterManual.PerformClick();
                        }
                        else
                        {
                            if (mf.autoBtnState != btnStates.Auto)
                                mf.btnSectionMasterAuto.PerformClick();
                        }
                    }

                    else//Checks both on-screen buttons, performs click if button is not off
                    {
                        if (mf.autoBtnState != btnStates.Off)
                            mf.btnSectionMasterAuto.PerformClick();
                        if (mf.manualBtnState != btnStates.Off)
                            mf.btnSectionMasterManual.PerformClick();
                    }
                }

                if (isSteerWorkSwitchEnabled && (oldSteerSwitchHigh != steerSwitchHigh))
                {
                    oldSteerSwitchHigh = steerSwitchHigh;

                    if ((mf.isBtnAutoSteerOn && mf.ahrs.isAutoSteerAuto)
                        || !mf.ahrs.isAutoSteerAuto && !steerSwitchHigh)
                    {
                        if (isSteerWorkSwitchManualSections)
                        {
                            if (mf.manualBtnState != btnStates.On)
                                mf.btnSectionMasterManual.PerformClick();
                        }
                        else
                        {
                            if (mf.autoBtnState != btnStates.Auto)
                                mf.btnSectionMasterAuto.PerformClick();
                        }
                    }

                    else//Checks both on-screen buttons, performs click if button is not off
                    {
                        if (mf.autoBtnState != btnStates.Off)
                            mf.btnSectionMasterAuto.PerformClick();
                        if (mf.manualBtnState != btnStates.Off)
                            mf.btnSectionMasterManual.PerformClick();
                    }
                }
            }
        }

        public class AioModule
        {
            private FormGPS mf;
            public bool isConnected = false;
            public byte health = 0;
            public byte version1 = 0;
            public byte version2 = 0;
            public byte version3 = 0;
            public double lastMsgRecieved = 0;
            private bool isOpen = false;


            public AioModule(FormGPS _mf)
            {
                mf = _mf;
            }
        }

        public class PowerMonitor
        {
            private FormGPS mf;
            public bool isConnected = false;
            public byte ipAddr = 70;
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
            private System.Timers.Timer shutdownTimer;
            private bool isDialogOpen = false;
            public PowerMonitor(FormGPS _mf)
            {
                mf = _mf;
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
                    isDialogOpen = true;

                    // Start the timer (e.g., 10 seconds = 10000 milliseconds)
                    shutdownTimer = new System.Timers.Timer(10000); // 10 second delay
                    shutdownTimer.Elapsed += OnTimedEvent;
                    shutdownTimer.AutoReset = false; // Ensure it only triggers once
                    shutdownTimer.Start();

                    // Show the dialog
                    DialogResult dr = MessageBox.Show("POWER DOWN?", "Want something else?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    // Stop the timer if user made a choice
                    if (isDialogOpen)
                    {
                        shutdownTimer.Stop();
                    }

                    if (dr == DialogResult.Yes)
                    {
                        mf.SendPgnToLoop(mf.p_9505.pgn);
                        powerDown();
                    }
                    else if (dr == DialogResult.Cancel)
                    {
                        // Handle cancel if needed
                    }

                    isDialogOpen = false;
                }

                prevKeyState = keyPowerState;
            }
            private void OnTimedEvent(Object source, ElapsedEventArgs e)
            {
                if (isDialogOpen)
                {
                    // Simulate "Yes" button click if the timer elapses
                    isDialogOpen = false; // Prevent further interaction
                    mf.SendPgnToLoop(mf.p_9505.pgn);
                    powerDown();
                }
            }
            public void powerDown()
            {
                // TODO: add popup for shutdown confirmation or cancelation
                int shutdownDelay = 10; // Example: 60 seconds delay

                // Construct the shutdown command
                string shutdownCommand = $"/s /t {shutdownDelay}";
                System.Diagnostics.Process.Start("shutdown", shutdownCommand);

                Console.WriteLine($"The PC will shut down in {shutdownDelay} seconds.");

                mf.Close();
            }
        }
    }
}