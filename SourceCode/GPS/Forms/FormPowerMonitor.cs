using AgOpenGPS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgOpenGPS.Forms
{
    public partial class FormPowerMonitor : Form
    {
        private readonly FormGPS mf = null;
        public List<Label> labels = new List<Label>();
        Timer t = new Timer();
        public FormPowerMonitor(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();
            labels.Add(labelVersion);
            labels.Add(labelKeyState);
            labels.Add(labelPCstate);
            labels.Add(labelAOGstate);
            labels.Add(labelCAN1state);
            labels.Add(labelCAN2state);
            labels.Add(labelVehicleISO);
            labels.Add(labelImpIso);
            t.Interval = 500;
            t.Enabled = true;
            t.Tick += new EventHandler(timer1_Tick);
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
                updateLabels();
           
        }
        public void updateLabels()
        {

            mf.powerMonitor.checkKeyState();
            if (mf.powerMonitor.checkConnection())
            {
                labelVersion.Text = mf.powerMonitor.version1.ToString() + "." + mf.powerMonitor.version2.ToString() + "." + mf.powerMonitor.version3.ToString();
                switch (mf.powerMonitor.keyPowerState)
                {
                    case 0:
                        labelKeyState.Text = "- - -";
                        break;
                    case 1:
                        labelKeyState.Text = "ON";
                        break;
                    case 2:
                        labelKeyState.Text = "OFF";
                        break;
                    default:
                        labelKeyState.Text = "- - -";
                        break;
                }
                switch (mf.powerMonitor.pcPowerState)
                {
                    case 0:
                        labelPCstate.Text = "- - -";
                        break;
                    case 1:
                        labelPCstate.Text = "ON";
                        break;
                    case 2:
                        labelPCstate.Text = "OFF";
                        break;
                    default:
                        labelPCstate.Text = "- - -";
                        break;
                }
                switch (mf.powerMonitor.isConnectedAOG)
                {
                    case 0:
                        labelAOGstate.Text = "- - -";
                        break;
                    case 1:
                        labelAOGstate.Text = "ACTIVE";
                        break;
                    case 2:
                        labelAOGstate.Text = "NA";
                        break;
                    default:
                        labelAOGstate.Text = "- - -";
                        break;
                }
                switch (mf.powerMonitor.isConnectedCAN1)
                {
                    case 0:
                        labelCAN1state.Text = "- - -";
                        break;
                    case 1:
                        labelCAN1state.Text = "ACTIVE";
                        break;
                    case 2:
                        labelCAN1state.Text = "NA";
                        break;
                    default:
                        labelCAN1state.Text = "- - -";
                        break;
                }
                switch (mf.powerMonitor.isConnectedCAN2)
                {
                    case 0:
                        labelCAN2state.Text = "- - -";
                        break;
                    case 1:
                        labelCAN2state.Text = "ACTIVE";
                        break;
                    case 2:
                        labelCAN2state.Text = "NA";
                        break;
                    default:
                        labelCAN2state.Text = "- - -";
                        break;
                }
                switch (mf.powerMonitor.isConnectedISOvehicle)
                {
                    case 0:
                        labelVehicleISO.Text = "- - -";
                        break;
                    case 1:
                        labelVehicleISO.Text = "ACTIVE";
                        break;
                    case 2:
                        labelVehicleISO.Text = "NA";
                        break;
                    default:
                        labelVehicleISO.Text = "- - -";
                        break;
                }
                switch (mf.powerMonitor.isConnectedISOimplement)
                {
                    case 0:
                        labelImpIso.Text = "- - -";
                        break;
                    case 1:
                        labelImpIso.Text = "ACTIVE";
                        break;
                    case 2:
                        labelImpIso.Text = "NA";
                        break;
                    default:
                        labelImpIso.Text = "- - -";
                        break;
                }
                switch (mf.powerMonitor.isConnectedINA219)
                {
                    case 0:
                        labelINA219.Text = "- - -";
                        break;
                    case 1:
                        labelINA219.Text = "ACTIVE";
                        break;
                    case 2:
                        labelINA219.Text = "NA";
                        break;
                    default:
                        labelINA219.Text = "- - -";
                        break;
                }


            }
            else if (!mf.powerMonitor.checkConnection()) 
            {
                foreach (Label item in labels)
                {
                    item.Text = "- - -";
                }
            }
        }

        private void labelVersion_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
