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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace AgOpenGPS.Forms
{
    public partial class FormPlanter : Form
    {
        private FormGPS mf = null;
        Timer loopTimer = new Timer();
        Timer hearbeatTimer = new Timer();
        public RowModule[] rowModule;
        public ProductModule productModule;
        private byte numberofRowModules = 5;
        DataTable chartData = null;
        public int ex = 1;
       
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
            //JObject o1 = JObject.Parse(File.ReadAllText(@"C:\Users\NolteS\Tools\Fertilizer\Packet_Parser\AOG_DataBase.json"));
            //foreach (var i in o1)
            //{
            //    //Debug.WriteLine(i);
            //    foreach (var ii in i.Value)
            //    { 

            //        Debug.WriteLine(ii); 
                    
            //    }
            //}
            chartData = new DataTable("RptData");
            chartData.Columns.Add("ROW", typeof(int));
            chartData.Columns.Add("CMD_FREQ", typeof(int));
            chartData.Columns.Add("CMD_DUTY", typeof(int));
            chartData.Columns.Add("FREQ_RPT", typeof(int));
            chartData.Columns.Add("CAN_FM_RPT", typeof(int));

            StringBuilder result = new StringBuilder();

            //Load xml
            //XDocument xdoc = XDocument.Load("C:\\Users\\NolteS\\Tools\\Fertilizer\\Packet_Parser\\AOG_DataBase.xml");

            //Run query
            

            
            for (int i = 1; i < 25; i++)
            {
                chartData.Rows.Add(i, 0, 0, 0, 0);
            }
            barChartPlanter.DataSource = chartData;
            

            
            
        }
       
        public class ProductModule
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
            public ProductModule() { }
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
            
            productModule = new ProductModule();
            
            productModule.panel.Size = new System.Drawing.Size(175, 150);
            productModule.panel.Location = new Point(productModule.xPosition, productModule.yPosition);
            productModule.moduleIcon.Image = Properties.Resources.ModuleOff1;
            productModule.moduleIcon.Size = new System.Drawing.Size(64, 64);
            productModule.moduleIcon.Location = new Point(50, 0);


            productModule.ipLabel.Location = new Point(productModule.ipX, productModule.ipY);
            productModule.ipLabel.Text = "IP Address: ";
            productModule.ipLabel.BackColor = System.Drawing.Color.Transparent;
            productModule.ipLabel.TextAlign = ContentAlignment.MiddleRight;
            productModule.ipLabel.BorderStyle = BorderStyle.FixedSingle;

            productModule.ipAddLbl.Location = new Point(productModule.ipX + productModule.ipLabel.Width + 10, productModule.ipY);
            productModule.ipAddLbl.Text = "- - -";
            productModule.ipAddLbl.BackColor = System.Drawing.Color.Transparent;
            productModule.ipAddLbl.TextAlign = ContentAlignment.MiddleLeft;
            ////////////////////    
            productModule.udpLabel.Location = new Point(productModule.udpX, productModule.udpY);
            productModule.udpLabel.Text = "UDP State: ";
            productModule.udpLabel.BackColor = System.Drawing.Color.Transparent;
            productModule.udpLabel.TextAlign = ContentAlignment.MiddleRight;

            productModule.udpValLbl.Location = new Point(productModule.udpX + productModule.udpLabel.Width + 10, productModule.udpY);
            productModule.udpValLbl.Text = "- - -";
            productModule.udpValLbl.BackColor = System.Drawing.Color.Transparent;
            productModule.udpValLbl.TextAlign = ContentAlignment.MiddleLeft;
            
            productModule.versionLabel.Location = new Point(productModule.versionX, productModule.versionY);
            productModule.versionLabel.Text = "Version: ";
            productModule.versionLabel.BackColor = System.Drawing.Color.Transparent;
            productModule.versionLabel.TextAlign = ContentAlignment.MiddleRight;

            productModule.versionValLbl.Location = new Point(productModule.versionX + productModule.versionLabel.Width + 10, productModule.versionY);
            productModule.versionValLbl.Text = "- - -";
            productModule.versionValLbl.BackColor = System.Drawing.Color.Transparent;
            productModule.versionValLbl.TextAlign = ContentAlignment.MiddleLeft;

            /////////////////
            productModule.versionLabel.ForeColor = Color.White;
            productModule.udpLabel.ForeColor = Color.White;
            productModule.ipLabel.ForeColor = Color.White;
            productModule.ipAddLbl.ForeColor = Color.White;
            productModule.udpValLbl.ForeColor = Color.White;
            productModule.versionValLbl.ForeColor = Color.White;

            productModule.panel.Controls.Add(productModule.moduleIcon);
            productModule.panel.Controls.Add(productModule.ipLabel);
            productModule.panel.Controls.Add(productModule.udpLabel);
            productModule.panel.Controls.Add(productModule.versionLabel);
            productModule.panel.Controls.Add(productModule.ipAddLbl);
            productModule.panel.Controls.Add(productModule.udpValLbl);
            productModule.panel.Controls.Add(productModule.versionValLbl);

            panelPlanterHealth.Controls.Add(productModule.panel);

            rowModule = new RowModule[numberofRowModules];
            for (int i = 0; i < numberofRowModules; i++)
            {
                
                rowModule[i] = new RowModule();
                rowModule[i].yPosition = 0;
                rowModule[i].xPosition = 175+i * 175;
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
                mf.tool.productEnable = 1;
                mf.p_151.pgn[mf.p_151.productEnable] = 1;// Enables closed loop control
            }
            else
            {
                mf.tool.productEnable = 0;
                mf.p_151.pgn[mf.p_151.productEnable] = 0;// System Off
            }
            mf.tool.toolCmdSetup();
            mf.tool.calculateToolFlowrate();
            mf.tool.calculateSectionFlowRate();
            mf.tool.calculateToolPressure();
            mf.tool.calculatePumpRPM();
            mf.tool.calculateRegulatorPosition();
            mf.tool.calculateSectionCmd();
            mf.tool.productModule.checkStatus();
            for (int i = 0; i < 5; i++)
            {
                mf.tool.rowModules[i].checkStatus();
            }
            
            updateProductLabels();
            updateProgressBars();
            updateDatatable();
            
            //mf.SendPgnToLoop(mf.p_151.pgn);
            if (ex == 1)
            {
                barChartPlanter.DataBind();
            }
            barChartPlanter.Update();
            //    updates labels ////////////
            //for (int i = 0; i < numberofRowModules; i++)
            //{
            //    rowModule[i].ipAddLbl.Text = DateTime.Now.Second.ToString();
            //}
        }
       
        private void FormPlanter_FormClosing(object sender, FormClosingEventArgs e)
        {
            ex = 0;

        }
        private void updateDatatable()
        {
            for (int i = 0; i < mf.tool.numOfSections; i++)
            {
                chartData.Rows[i]["CMD_DUTY"] = mf.section[i].sectionDutyTarget;
            }
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
                if (mf.tool.productModule.isModuleConnected)
                {
                    productModule.ipAddLbl.Text = mf.tool.productModule.ipAddress.ToString();
                    productModule.udpValLbl.Text = mf.tool.productModule.udpState.ToString();
                    productModule.versionValLbl.Text = mf.tool.productModule.version.ToString();
                } else
                {
                    productModule.ipAddLbl.Text = "- - -";
                    productModule.udpValLbl.Text = "- - -";
                    productModule.versionValLbl.Text = "- - -";
                }

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
            pbRailFlowrateTarget.Value = (int)(mf.tool.targetRateGPMsum * 100);
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void FormPlanter_Load(object sender, EventArgs e)
        {

        }

        private void btnModuleReboot_Click(object sender, EventArgs e)
        {
            mf.p_157.pgn[mf.p_157.ipAddressReboot] = 51;
            mf.SendPgnToLoop(mf.p_157.pgn);
        }
    }
}
