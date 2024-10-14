using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AgOpenGPS.Forms
{
    public partial class FormImplement : Form
    {
        private readonly FormGPS mf = null;
        private System.Timers.Timer tick;
        int width = 10;
        int height = 50;
        //int implementIndex = 0;
        int top;
        int left;//planter = 0, liquid = 1
        List<Panel> myPanels = new List<Panel>();

        public FormImplement(Form callingForm)
        {
            mf = callingForm as FormGPS;
            
            InitializeComponent();
            myPanels.Add(panelEmpty);
            myPanels.Add(panelPlanter);
            myPanels.Add(panelLiquid);
            myPanels.Add(panelCombine);
            //panelBar1.Paint += this.OnPaint;
            string[] mappingItemsCombine = new string[] { "Coverage", "Yield", "Mass Flow", "Moisture", "Speed", "Nothing"};
            //comboBoxCombineMapping.Items.AddRange(mappingItemsCombine);
            string[] mappingItemsPlanter = new string[] { "Coverage", "Tank Weight", "Pitch", "Roll", "Speed", "Nothing" };
            comboBoxPlanterMapping.Items.AddRange(mappingItemsPlanter);
            updatePanels();
            getMapSettings();
            InitializeTimer();
           

        }

        private void getMapSettings()
        {
            mf.mapColor.MaxValue = Properties.Settings.Default.mapColorMax;
            
            mf.mapColor.MinValue = Properties.Settings.Default.mapColorMin;
           
            mf.mapColor.centerValue = Properties.Settings.Default.mapCenterVal;
            
            mf.mapColor.Start = Properties.Settings.Default.mapStartColor;
            mf.mapColor.Center = Properties.Settings.Default.mapCenterColor;
            mf.mapColor.End = Properties.Settings.Default.mapEndColor;
            mf.mapColor.mappingField = Properties.Settings.Default.mapColorField;

            nudlessNumericUpDownMapTarget.Value = (decimal)mf.mapColor.centerValue;
            nudlessNumericUpDownPlanterMin.Value = (decimal)mf.mapColor.MinValue;
            nudlessNumericUpDownPlanterMax.Value = (decimal)mf.mapColor.MaxValue;
            comboBoxPlanterMapping.Text = mf.mapColor.mappingField;
        }
        protected override void OnMove(EventArgs e)
        {
            updatePanels();
            
        }
        private void InitializeTimer()
        {
            tick = new System.Timers.Timer
            {
                Interval = 500 
            };
            tick.Elapsed += updateLabels;
            tick.Start();
        }
        void updateLabels(object sender, ElapsedEventArgs e)
        {
            //if (mf.tool.implementIndex == 3)
            //{
                labelYield.Text = mf.vehicle.yeild.ToString();
                labelMassFlow.Text = mf.vehicle.massFlowrate.ToString();
                labelMoisture.Text = mf.vehicle.moisture.ToString();
                //lBLTOTALMASS.Text = mf.fd.totalMass.ToString();
            //}
        }
        
        public void updatePanels()
        {

            //Debug.Write("Left: ");
            //Debug.WriteLine(this.Left);
            //Debug.Write(" Width: ");
            //Debug.WriteLine(this.Width);
            //Debug.Write(" Top: ");
            //Debug.WriteLine(this.Top);
            //Debug.Write(" Height: ");
            //Debug.WriteLine(this.Height);

            Form f = Application.OpenForms["FormImplement"];
            if (f != null)
            {
               
                top = f.Top;
                height = f.Height;
            }
            Panel _panel = null;
            for (byte i = 0; i < myPanels.Count; i++)
            {
                _panel = myPanels[i];
                _panel.Visible = false;
                _panel.Enabled = false;
            }
            _panel = myPanels[mf.tool.implementIndex];
            _panel.Visible = true;
            _panel.Enabled = true;
            _panel.Height = this.Height - 300;
            _panel.Width = 200;
            _panel.Left = 10;
            _panel.Top = 60;

            
            this.Update();
        }

        

        private void mapping_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormImplement"];
            if (f != null)
            {
                top = f.Top;
                height = f.Height;
            }
            if (!panelMapping.Visible)
            {
                panelMapping.Visible = true;
                panelMapping.Enabled = true;
                panelMapping.Top = 60;
                panelMapping.Width = 200;
                panelMapping.Height = height;
                panelMapping.Left = 10;
                panelMapping.BringToFront();
            } else
            {
                panelMapping.Visible = false;
                panelMapping.Enabled = false;
            }
        }

        private void implementSelector_Click(object sender, EventArgs e)
        {
            if (mf.tool.implementIndex < myPanels.Count())
            {
                if (!panelImpConfigSelector.Visible)
                {
                    panelImpConfigSelector.Visible = true;
                    panelImpConfigSelector.Enabled = true;
                    panelImpConfigSelector.Left = 0;
                    panelImpConfigSelector.Top = 50;
                    panelImpConfigSelector.Width = 200;
                    panelImpConfigSelector.BringToFront();
                }
                else
                {
                    panelImpConfigSelector.Visible = false;
                    panelImpConfigSelector.Enabled = false;
                }
            }

        }

        private void buttonSelectPlanter_Click(object sender, EventArgs e)
        {
            mf.tool.implementIndex = 1;
            updatePanels();
            
        }

        private void buttonSelectLiquid_Click(object sender, EventArgs e)
        {
            mf.tool.implementIndex = 2;
            updatePanels();
        }

        private void buttonSelectCombine_Click(object sender, EventArgs e)
        {
            mf.tool.implementIndex = 3;
            updatePanels();
        }

        private void targetRate_Click(object sender, EventArgs e)
        {
            mf.KeypadToNUD((NudlessNumericUpDown)sender, this);
            mf.tool.targetRate = (double)nudlessNumericUpDownTargetRate.Value;
        }

        private void planterMapMax_Click(object sender, EventArgs e)
        {
            mf.KeypadToNUD((NudlessNumericUpDown)sender, this);
            mf.mapColor.MaxValue = (double)nudlessNumericUpDownPlanterMax.Value;
            
        }

        private void planterMapMin_Click(object sender, EventArgs e)
        {
            mf.KeypadToNUD((NudlessNumericUpDown)sender, this);
            mf.mapColor.MinValue = (double)nudlessNumericUpDownPlanterMin.Value;
            
        }

        private void mappingMin_Click(object sender, EventArgs e)
        {
            mf.KeypadToNUD((NudlessNumericUpDown)sender, this);
            mf.mapColor.MinValue = (double)nudlessNumericUpDownPlanterMin.Value;
            Properties.Settings.Default.mapColorMin = mf.mapColor.MinValue;
            Properties.Settings.Default.Save();
        }

        private void mappingTarget_Click(object sender, EventArgs e)
        {
            mf.KeypadToNUD((NudlessNumericUpDown)sender, this);
            mf.mapColor.centerValue = (double)nudlessNumericUpDownMapTarget.Value;
            Properties.Settings.Default.mapCenterVal = mf.mapColor.centerValue;
            Properties.Settings.Default.Save();
        }

        private void mappingMax_Click(object sender, EventArgs e)
        {
            mf.KeypadToNUD((NudlessNumericUpDown)sender, this);
            mf.mapColor.MaxValue = (double)nudlessNumericUpDownPlanterMax.Value;
            Properties.Settings.Default.mapColorMax = mf.mapColor.MaxValue;
            Properties.Settings.Default.Save();
           
        }

        private void mappingBoxChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                
                Debug.WriteLine(comboBox.Text);
                mf.mapColor.mappingField = comboBox.Text;
                Properties.Settings.Default.mapColorField = comboBox.Text;
                Properties.Settings.Default.Save();
            }
            
        }

        public void foldButtonClick(object sender, EventArgs e)
        {
            if (panelFold.Visible == false)
            {
                panelFold.Visible = true;
                panelFold.Enabled = true;
                panelFold.Left = 10;
                panelFold.Top = 50;
                buttonFold.BackColor = Color.Blue;
            } else
            {
                panelFold.Visible = false;
                panelFold.Enabled = false;
                buttonFold.BackColor = Color.DimGray;
            }
            

        }

        //private void button_LH_Outer_Out_down(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.lhOuterWingRotate] = 1;
        //    Debug.WriteLine(mf.p_150.pgn[mf.p_150.lhOuterWingRotate]);
        //}

        //private void button_LH_Outer_Out_up(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.lhOuterWingRotate] = 0;
        //}

        //private void button_LH_Outer_In_Down(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.lhOuterWingRotate] = 2;
        //    Debug.WriteLine(mf.p_150.pgn[mf.p_150.lhOuterWingRotate]);
        //}

        //private void button_LH_Outer_In_Up(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.lhOuterWingRotate] = 0;
        //}

        //private void button_LH_Wing_Raise_down(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.lhWingLift] = 1;
        //}

        //private void button_LH_Wing_Raise_up(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.lhWingLift] = 0;
        //}

        //private void button_LH_Wing_Lower_down(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.lhWingLift] = 2;
        //}

        //private void button_LH_Wing_Lower_up(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.lhWingLift] = 0;
        //}

        //private void button_LH_Wing_Rotate_Out_down(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.lhWingRotate] = 1;
        //}

        //private void button_LH_Wing_Rotate_Out_Up(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.lhWingRotate] = 0;
        //}

        //private void button_LH_Wing_Rotate_In_Down(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.lhWingRotate] = 2;
        //}

        //private void button_LH_Wing_Rotate_In_Up(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.lhWingRotate] = 0;
        //}

        //private void button_RH_Outer_Out_down(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.rhOuterWingRotate] = 1;
        //}

        //private void button_RH_Outer_Out_up(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.rhOuterWingRotate] = 0;
        //}

        //private void button_RH_Outer_In_down(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.rhOuterWingRotate] = 2;
        //}

        //private void button_RH_Outer_In_up(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.rhOuterWingRotate] = 0;
        //}

        //private void button_RH_Wing_Raise_down(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.rhWingLift] = 1;
        //}

        //private void button_RH_Wing_Raise_up(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.rhWingLift] = 0;
        //}

        //private void button_RH_Wing_Lower_down(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.rhWingLift] = 2;
        //}

        //private void button_RH_Wing_Lower_up(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.rhWingLift] = 0;
        //}

        //private void button_RH_Wing_Rotate_Out_down(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.rhWingRotate] = 1;
        //}

        //private void button_RH_Wing_Rotate_Out_up(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.rhWingRotate] = 0;
        //}

        //private void button_RH_Wing_Rotate_In_down(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.rhWingRotate] = 2;
        //}

        //private void button_RH_Wing_Rotate_In_up(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.rhWingRotate] = 0;
        //}

        //private void button_Center_Raise_down(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.centerLift] = 1;
        //}

        //private void button_Center_Raise_up(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.centerLift] = 0;
        //}

        //private void button_Center_Lower_down(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.centerLift] = 2;
        //}

        //private void button_Center_Lower_up(object sender, MouseEventArgs e)
        //{
        //    mf.p_150.pgn[mf.p_150.centerLift] = 0;
        //}

    }
}
