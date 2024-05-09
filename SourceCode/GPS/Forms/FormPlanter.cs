using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgOpenGPS.Forms
{
    public partial class FormPlanter : Form
    {
        private FormGPS mf = null;
        Timer loopTimer = new Timer();
        Timer hearbeatTimer = new Timer();
        public RowModule[] rowModule;
        private byte numberofRowModules = 5;
        

        public FormPlanter(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();
            loopTimer.Interval = 100;
            loopTimer.Enabled = true;
            loopTimer.Tick += new EventHandler(loopTimer_Tick);
            hearbeatTimer.Interval = 1000;
            hearbeatTimer.Enabled = true;
            hearbeatTimer.Tick += new EventHandler(heartbeatTimer_Tick);
            panelPlanterHealth.Location = new Point(12, 12);
            panelPlanterProduct.Location = new Point(12, 12);
            createHealthLabels();
            JObject o1 = JObject.Parse(File.ReadAllText(@"C:\Users\NolteS\source\repos\AgOpenGPS\SourceCode\GPS\ValveData.json"));
            //using (StreamReader file = File.OpenText(@"C:\Users\NolteS\source\repos\AgOpenGPS\SourceCode\GPS\ValveData.json"))
            //using (JsonTextReader reader = new JsonTextReader(file))
            //{
            //    JObject o2 = (JObject)JToken.ReadFrom(reader);
            //}
            Debug.WriteLine(o1["row_0"]["default"].ToString());
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
            public Label ipAddLbl = new Label();
            public Label udpLabel = new Label();
            public Label udpValLbl = new Label();
            public Label versionLabel = new Label();
            public Label versionValLbl = new Label();
            public Panel panel = new Panel();
            public PictureBox moduleIcon = new PictureBox();
            public RowModule() { }
        }
        private void createHealthLabels()
        {
            rowModule = new RowModule[numberofRowModules];
            for (int i = 0; i < numberofRowModules; i++)
            {
                
                rowModule[i] = new RowModule();
                rowModule[i].yPosition = 0;
                rowModule[i].xPosition = i * 175;
                //if (i > 2)
                //{
                //    rowModule[i].xPosition = 300;
                //    rowModule[i].yPosition = (i - 3) * 150;
                //}
                rowModule[i].panel.Size = new System.Drawing.Size(175, 150);
                rowModule[i].panel.Location = new Point(rowModule[i].xPosition, rowModule[i].yPosition);
                rowModule[i].moduleIcon.Image = Properties.Resources.ModuleOff1;
                rowModule[i].moduleIcon.Size = new System.Drawing.Size(64, 64);
                rowModule[i].moduleIcon.Location = new Point(50, 0);


                rowModule[i].ipLabel.Location = new Point(rowModule[i].ipX, rowModule[i].ipY);
                rowModule[i].ipLabel.Text = "IP Address: ";
                rowModule[i].ipLabel.BackColor = System.Drawing.Color.Transparent;
                rowModule[i].ipLabel.TextAlign = ContentAlignment.MiddleRight;
                rowModule[i].ipLabel.BorderStyle = BorderStyle.FixedSingle;
                
                rowModule[i].ipAddLbl.Location = new Point(rowModule[i].ipX + rowModule[i].ipLabel.Width + 10, rowModule[i].ipY);
                //rowModule[i].ipAddLbl.Text = mf.tool.rowModules[i].ipAddress.ToString();
                rowModule[i].ipAddLbl.Text = "- - -";
                rowModule[i].ipAddLbl.BackColor = System.Drawing.Color.Transparent;
                rowModule[i].ipAddLbl.TextAlign = ContentAlignment.MiddleLeft;
                ////////////////////    
                rowModule[i].udpLabel.Location = new Point(rowModule[i].udpX, rowModule[i].udpY);
                rowModule[i].udpLabel.Text = "UDP State: ";
                rowModule[i].udpLabel.BackColor = System.Drawing.Color.Transparent;
                rowModule[i].udpLabel.TextAlign = ContentAlignment.MiddleRight;

                rowModule[i].udpValLbl.Location = new Point(rowModule[i].udpX + rowModule[i].udpLabel.Width + 10, rowModule[i].udpY);
                rowModule[i].udpValLbl.Text = "- - -";
                rowModule[i].udpValLbl.BackColor = System.Drawing.Color.Transparent;
                rowModule[i].udpValLbl.TextAlign = ContentAlignment.MiddleLeft;


                /////////////////
                rowModule[i].versionLabel.Location = new Point(rowModule[i].versionX, rowModule[i].versionY);
                rowModule[i].versionLabel.Text = "Version: ";
                rowModule[i].versionLabel.BackColor = System.Drawing.Color.Transparent;
                rowModule[i].versionLabel.TextAlign = ContentAlignment.MiddleRight;

                rowModule[i].versionValLbl.Location = new Point(rowModule[i].versionX + rowModule[i].versionLabel.Width + 10, rowModule[i].versionY);
                rowModule[i].versionValLbl.Text = "- - -";
                rowModule[i].versionValLbl.BackColor = System.Drawing.Color.Transparent;
                rowModule[i].versionValLbl.TextAlign = ContentAlignment.MiddleLeft;

                /////////////////
                rowModule[i].versionLabel.ForeColor = Color.White;
                rowModule[i].udpLabel.ForeColor = Color.White;
                rowModule[i].ipLabel.ForeColor = Color.White;
                rowModule[i].ipAddLbl.ForeColor = Color.White;
                rowModule[i].udpValLbl.ForeColor = Color.White;
                rowModule[i].versionValLbl.ForeColor = Color.White;

                rowModule[i].panel.Controls.Add(rowModule[i].moduleIcon);
                rowModule[i].panel.Controls.Add(rowModule[i].ipLabel);
                rowModule[i].panel.Controls.Add(rowModule[i].udpLabel);
                rowModule[i].panel.Controls.Add(rowModule[i].versionLabel);
                rowModule[i].panel.Controls.Add(rowModule[i].ipAddLbl);
                rowModule[i].panel.Controls.Add(rowModule[i].udpValLbl);
                rowModule[i].panel.Controls.Add(rowModule[i].versionValLbl);

                panelPlanterHealth.Controls.Add(rowModule[i].panel);
                
            }
        }
        private void loopTimer_Tick(object sender, EventArgs e)
        {
            if (toggleProductEnable.Checked == true)
            {
                mf.tool.productEnable = 2;  // Enables closed loop control
            }
            else
            {
                mf.tool.productEnable = 0;   // System Off
            }
            mf.tool.toolCmdSetup();
            mf.tool.calculateToolFlowrate();
            mf.tool.calculateSectionFlowRate();
            mf.tool.calculateToolPressure();
            mf.tool.calculatePumpRPM();
            mf.tool.calculateRegulatorPosition();
            updateProductLabels();
            updateProgressBars();
            mf.SendPgnToLoop(mf.p_151.pgn);
            //    updates labels ////////////
            //for (int i = 0; i < numberofRowModules; i++)
            //{
            //    rowModule[i].ipAddLbl.Text = DateTime.Now.Second.ToString();
            //}
        }

        private void heartbeatTimer_Tick(object sender, EventArgs e)
        {
            DebugPrint();
            updateHealthLabels();
        }

        private void updateHealthLabels()
        {
            for (int i = 0; i < numberofRowModules; i++)
            {
                if (mf.tool.rowModules[i].isModuleConnected)
                {
                    rowModule[i].ipAddLbl.Text = mf.tool.rowModules[i].ipAddress.ToString();
                    rowModule[i].udpValLbl.Text = mf.tool.rowModules[i].udpState.ToString();
                    rowModule[i].versionValLbl.Text = mf.tool.rowModules[i].version.ToString();
                } 
                else
                {
                    rowModule[i].ipAddLbl.Text = "- - -";
                    rowModule[i].udpValLbl.Text = "- - -";
                    rowModule[i].versionValLbl.Text = "- - -";
                }
            }
        }
        private void DebugPrint()
        {
            Debug.Write("Flowrate Target: ");
            Debug.Write(mf.tool.targetRateGPM.ToString());
            Debug.Write(" Pressure Target: ");
            Debug.Write(mf.tool.targetRailPressure.ToString());
            Debug.WriteLine("");
        }
        #region Display Updates
        private void updateProductLabels()
        {
            labelTargetRate.Text = String.Format("{0:0.00}", mf.tool.targetRateGPA);
            labelpbTargetRate.Text = String.Format("{0:0.00}", mf.tool.targetRateGPA);
            lblpbPressureTarget.Text = String.Format("{0:0.00}", mf.tool.targetRailPressure);
            lblpbFlowTarget.Text = String.Format("{0:0.00}", mf.tool.targetRateGPMsum);
            lblRPMtar.Text = String.Format("{0:0.00}", 0);
            lblpbRegulatorTarget.Text = String.Format("{0:0.00}", mf.tool.targetRegPos);
            lblRPMtar.Text = String.Format("{0:0.00}", mf.tool.targetPumpRPM);

            lblFlowAct.Text = String.Format("{0:0.00}", mf.tool.railFlowrateRpt);
            lblPressureAct.Text = String.Format("{0:0.00}", mf.tool.railPressureRpt);
            lblRegPosAct.Text = String.Format("{0:0.00}", mf.tool.RegPosRpt);
            lblRPMact.Text = String.Format("{0:0.00}", mf.tool.PumpRPMRpt);
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (panelPlanterProduct.Visible)
            {
                panelPlanterProduct.Visible = false;
                panelPlanterHealth.Visible = true;
            } else
            {
                panelPlanterHealth.Visible = false;
                panelPlanterProduct.Visible = true;
            }
        }

        private void btnIncPlntrTarRate_Click_1(object sender, EventArgs e)
        {
            mf.tool.targetRateGPA = mf.tool.targetRateGPA + 0.25;
            Properties.Settings.Default.targetRate = (double)(mf.tool.targetRateGPA);
            Properties.Settings.Default.Save();
        }

        private void btnDecPlntrTarRate_Click_1(object sender, EventArgs e)
        {
            

            if (mf.tool.targetRateGPA == 0) { }
            else
            {
                mf.tool.targetRateGPA = mf.tool.targetRateGPA - 0.25;
                Properties.Settings.Default.targetRate = (double)(mf.tool.targetRateGPA);
                Properties.Settings.Default.Save();

            }
        }
    }
}
