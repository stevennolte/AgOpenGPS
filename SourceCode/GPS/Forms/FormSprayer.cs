using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using AgOpenGPS.Classes;
using OpenTK.Audio.OpenAL;
using static AgOpenGPS.Forms.FormPlanter;



namespace AgOpenGPS.Forms
{
    public partial class FormSprayer : Form
    {

        private FormGPS mf = null;
        Timer loopTimer = new Timer();
        Timer hearbeatTimer = new Timer();
        public const double GainProportional = 1.5;
        const double GainIntegral = 0.01;
        const float GainDerivative = 0;
        const double OutputMax = 100;
        const double OutputMin = 0;
        PidController pumpController = new PidController(GainProportional,GainIntegral,GainDerivative,OutputMax,OutputMin);
        public DateTime previousPumpCtrlTime = DateTime.UtcNow;
        public RowModule[] rowModule;

        public FormSprayer(Form callingForm)
        {
            
            mf = callingForm as FormGPS;
            InitializeComponent();
            loopTimer.Interval = 100;
            loopTimer.Enabled = true;
            loopTimer.Tick += new EventHandler(loopTimer_Tick);
            hearbeatTimer.Interval = 1000;
            hearbeatTimer.Enabled = true;
            hearbeatTimer.Tick += new EventHandler(heartbeatTimer_Tick);
            createHealthLabels();
            



        }
        public class Remote
        {
            public DateTime lastMsgRecieved = DateTime.UtcNow;
            public Remote() 
            { 
                
            }
        }
        public class RowModule
        {
            public int xPosition = 0;
            public int yPosition = 0;
            public int ipX = 0;
            public int ipY = 75;
            public int udpX = 0;
            public int udpY = 95;
            public int versionX = 0;
            public int versionY = 115;
            public Label ipLabel = new Label();
            public Label udpLabel = new Label();
            public Label versionLabel = new Label();
            public Panel panel = new Panel();
            public PictureBox moduleIcon = new PictureBox();
            public RowModule() { }
        }

        private void createHealthLabels()
        {
            rowModule = new RowModule[mf.tool.numofRowModules];
            for (int i = 0; i < mf.tool.numofRowModules; i++)
            {

                rowModule[i] = new RowModule();
                rowModule[i].yPosition = i * 150;
                if (i > 2)
                {
                    rowModule[i].xPosition = 300;
                    rowModule[i].yPosition = (i - 3) * 150;
                }
                rowModule[i].panel.Size = new System.Drawing.Size(228, 150);
                rowModule[i].panel.Location = new Point(rowModule[i].xPosition, rowModule[i].yPosition);
                rowModule[i].moduleIcon.Image = Properties.Resources.ModuleOff1;
                rowModule[i].moduleIcon.Size = new System.Drawing.Size(64, 64);


                rowModule[i].ipLabel.Location = new Point(rowModule[i].ipX, rowModule[i].ipY);
                rowModule[i].ipLabel.Text = "IP Address: ";
                rowModule[i].ipLabel.BackColor = System.Drawing.Color.Transparent;
                rowModule[i].udpLabel.Location = new Point(rowModule[i].udpX, rowModule[i].udpY);
                rowModule[i].udpLabel.Text = "UDP State: ";
                rowModule[i].udpLabel.BackColor = System.Drawing.Color.Transparent;
                rowModule[i].versionLabel.Location = new Point(rowModule[i].versionX, rowModule[i].versionY);
                rowModule[i].versionLabel.Text = "Version: ";
                rowModule[i].versionLabel.BackColor = System.Drawing.Color.Transparent;

                rowModule[i].versionLabel.ForeColor = Color.White;
                rowModule[i].udpLabel.ForeColor = Color.White;
                rowModule[i].ipLabel.ForeColor = Color.White;

                rowModule[i].panel.Controls.Add(rowModule[i].moduleIcon);
                rowModule[i].panel.Controls.Add(rowModule[i].ipLabel);
                rowModule[i].panel.Controls.Add(rowModule[i].udpLabel);
                rowModule[i].panel.Controls.Add(rowModule[i].versionLabel);

                panelSprayerHealth.Controls.Add(rowModule[i].panel);

            }
        }
        private void loopTimer_Tick(object sender, EventArgs e)
        {
            

            if (toggleProductEnable.Checked == true)
            {
                if (toggleAutoControl.Checked)
                {
                    mf.tool.productEnable = 2;  // Enables closed loop control
                }
                else
                {
                    mf.tool.productEnable = 1;  // Enables manual control
                }
            }
            else
            {
                mf.tool.productEnable = 0;   // System Off
            }
            mf.tool.toolCmdSetup();
            mf.tool.calculateToolFlowrate();
            mf.tool.calculateSectionFlowRate();
            mf.tool.calculateToolPressure();
            mf.tool.calculateSectionCmd();
            pumpControlLoop();
            updateLabels();
            updateProgressBars();
            mf.SendPgnToLoop(mf.p_151.pgn);
            checkModuleHealth();
            
        }

        private void checkModuleHealth()
        {
            if ((DateTime.UtcNow - mf.tool.foldModule.lastJoystickMessageTimestamp).TotalSeconds > mf.tool.foldModule.joystickTimeout)
            {
                mf.tool.foldModule.isJoystickConnected = false;
                picboxJoystick.Image = Properties.Resources.joystick_Off;

            } else
            {
                picboxJoystick.Image = Properties.Resources.Joystick_Active;
            }
        }
        private void heartbeatTimer_Tick(object sender, EventArgs e)
        {
            DebugPrint();
        }

        private void DebugPrint()
        {
            Debug.Write("Flowrate Target: ");
            Debug.Write(mf.tool.targetRateGPM.ToString());
            Debug.Write(" Pressure Target: ");
            Debug.Write(mf.tool.targetRailPressure.ToString());
            Debug.Write(" Rpt Press: ");
            Debug.Write(mf.tool.railPressureRpt.ToString());
            Debug.Write(" Pump Cmd: ");
            Debug.WriteLine(mf.tool.manualPumpCmd);
            Debug.WriteLine("");
            
        }
        public static float remap(float val, float in1, float in2, float out1, float out2)
        {
            return out1 + (val - in1) * (out2 - out1) / (in2 - in1);
        }
        private void pumpControlLoop()
        {
            if (mf.tool.productEnable == 2)
            {
                pumpController.SetPoint = mf.tool.targetRailPressure;
                pumpController.ProcessVariable = mf.tool.railPressureRpt;
                pumpController.GainIntegral = GainIntegral;
                double val = pumpController.ControlVariable(DateTime.UtcNow - previousPumpCtrlTime);
                mf.tool.manualPumpCmd = (int)(remap((float)val, 0, 100, 2500, 8000));
                mf.p_151.pgn[mf.p_151.manualPumpCmdLowByte] = unchecked((byte)((int)(mf.tool.manualPumpCmd)));
                mf.p_151.pgn[mf.p_151.manualPumpCmdHighByte] = unchecked((byte)((int)(mf.tool.manualPumpCmd) >> 8));
            } else
            {
                pumpController.SetPoint = 0;
                
                
                double val = pumpController.ControlVariable(DateTime.UtcNow - previousPumpCtrlTime);
                mf.tool.manualPumpCmd = (int)(remap((float)val, 0, 100, 2500, 8000));
                mf.p_151.pgn[mf.p_151.manualPumpCmdLowByte] = unchecked((byte)((int)(mf.tool.manualPumpCmd)));
                mf.p_151.pgn[mf.p_151.manualPumpCmdHighByte] = unchecked((byte)((int)(mf.tool.manualPumpCmd) >> 8));
            }
            
            previousPumpCtrlTime = DateTime.UtcNow;
        }
#region Display Updates
        private void updateLabels()
        {
            labelTargetRate.Text = String.Format("{0:0.00}", mf.tool.targetRateGPA);
            labelpbTargetRate.Text = String.Format("{0:0.00}", mf.tool.targetRateGPA);
            lblpbPressureTarget.Text = String.Format("{0:0.00}", mf.tool.targetRailPressure);
            lblpbFlowTarget.Text = String.Format("{0:0.00}", mf.tool.targetRateGPM);
            lblpbPumpCmdTarget.Text = String.Format("{0:0.00}", 0);
        }

        private void updateProgressBars()
        {
            pbRateTarget.Value = (int)(mf.tool.targetRateGPA * 100);
        }
        #endregion

#region Butttons
        private void btnDecPlntrTarRate_Click(object sender, EventArgs e)
        {
            if (mf.tool.targetRateGPA > 0)
            {
                mf.tool.targetRateGPA = mf.tool.targetRateGPA - 0.25;
            }

        }

        private void btnIncPlntrTarRate_Click(object sender, EventArgs e)
        {
            if (mf.tool.targetRateGPA < 30)
            {
                mf.tool.targetRateGPA = mf.tool.targetRateGPA + 0.25;
            }

        }



        #endregion
        private void FormSprayer_Load(object sender, EventArgs e)
        {

        }
#region Fold
        private void toggleLeftFlipOut_CheckedChanged(object sender)
        {
            if (toggleLeftFlipOut.Checked) { mf.tool.foldModule.lhOuterWingRotate = 1; }
            else if (!toggleLeftFlipOut.Checked) { mf.tool.foldModule.lhOuterWingRotate = 0; }
        }

        private void toggleLeftFlipIn_CheckedChanged(object sender)
        {
            if (toggleLeftFlipIn.Checked) { mf.tool.foldModule.lhOuterWingRotate = 2; }
            else if (!toggleLeftFlipIn.Checked) { mf.tool.foldModule.lhOuterWingRotate = 0; }
        }

        private void toggleLeftRotOut_CheckedChanged(object sender)
        {
            if (toggleLeftRotOut.Checked) { mf.tool.foldModule.lhWingRotate = 2; }
            else if (!toggleLeftRotOut.Checked) { mf.tool.foldModule.lhWingRotate=0; }
        }

        private void toggleLeftRotIn_CheckedChanged(object sender)
        {
            if (toggleLeftRotIn.Checked) { mf.tool.foldModule.lhWingRotate = 1; }
            else if (!toggleLeftRotIn.Checked) { mf.tool.foldModule.lhWingRotate = 0; }
        }

        private void toggleLeftLiftUp_CheckedChanged(object sender)
        {
            if (toggleLeftLiftUp.Checked) { mf.tool.foldModule.lhWingLift = 1; }
            else if (!toggleLeftLiftUp.Checked) { mf.tool.foldModule.lhWingLift = 0; }
        }

        private void toggleLeftLiftDown_CheckedChanged(object sender)
        {
            if (toggleLeftLiftDown.Checked) { mf.tool.foldModule.lhWingLift = 2; }
            else if (!toggleLeftLiftDown.Checked) { mf.tool.foldModule.lhWingLift = 0; }
        }

        private void toggleRightFlipOut_CheckedChanged(object sender)
        {
            if (toggleRightFlipOut.Checked) { mf.tool.foldModule.rhOuterWingRotate = 1; }
            else if (!toggleRightFlipOut.Checked) { mf.tool.foldModule.rhOuterWingRotate = 0; }
        }

        private void toggleRightFlipIn_CheckedChanged(object sender)
        {
            if (toggleRightFlipIn.Checked) { mf.tool.foldModule.rhOuterWingRotate = 2; }
            else if (!toggleRightFlipIn.Checked) { mf.tool.foldModule.rhOuterWingRotate = 0; }
        }

        private void toggleRightRotOut_CheckedChanged(object sender)
        {
            if (toggleRightRotOut.Checked) { mf.tool.foldModule.rhWingRotate = 2; }
            else if (!toggleRightRotOut.Checked) { mf.tool.foldModule.rhWingRotate = 0; }
        }

        private void toggleRightRotIn_CheckedChanged(object sender)
        {
            if (toggleRightRotIn.Checked) { mf.tool.foldModule.rhWingRotate = 1; }
            else if (!toggleRightRotIn.Checked) { mf.tool.foldModule.rhWingRotate = 0; }
        }

        private void toggleRightLiftUp_CheckedChanged(object sender)
        {
            if (toggleRightLiftUp.Checked) { mf.tool.foldModule.rhWingLift = 1; }
            else if (!toggleRightLiftUp.Checked) { mf.tool.foldModule.rhWingLift = 0; }
        }

        private void toggleRightLiftDown_CheckedChanged(object sender)
        {
            if (toggleRightLiftDown.Checked) { mf.tool.foldModule.rhWingLift = 2; }
            else if (!toggleRightLiftDown.Checked) { mf.tool.foldModule.rhWingLift = 0; }
        }

        private void toggleMainUp_CheckedChanged(object sender)
        {
            if (toggleMainUp.Checked) { mf.tool.foldModule.centerLift = 1; }
            else if (!toggleMainUp.Checked) { mf.tool.foldModule.centerLift = 0; }
        }

        private void toggleMainDown_CheckedChanged(object sender)
        {
            if (toggleMainDown.Checked) { mf.tool.foldModule.centerLift = 2; }
            else if (!toggleMainDown.Checked) { mf.tool.foldModule.centerLift = 0; }
        }
        #endregion

        private void tabPageFold_Click(object sender, EventArgs e)
        {

        }

        private void toggleRemote_CheckedChanged(object sender)
        {
            if (toggleRemote.Checked) { mf.tool.foldModule.joystickEnabled = true; }
            else if (!toggleRemote.Checked) { mf.tool.foldModule.joystickEnabled = false; } 
        }
    }
}
