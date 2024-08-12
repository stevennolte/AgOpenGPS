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
            healthTimer = new System.Timers.Timer
            {
                Interval = 1000 // Set interval to 1 second for logging
            };
            healthTimer.Elapsed += updateIcons;
            healthTimer.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form_Health_Load(object sender, EventArgs e)
        {

        }

        private void updateIcons(object sender, ElapsedEventArgs e)
        {
            // Steer Health
            if (mf.health.steerState == 1)
            {
                iconSteerState.Image = Resources.Green_Check1;
            } else if (mf.health.steerState == 2)
            {
                iconSteerState.Image = Resources.Red_X;
            }
            // GPS Health
            if (mf.health.gpsState == 0)
            {
                iconGPSstate.Image = Resources.Red_X;
            }
            else if (mf.health.gpsState == 1)
            {
                iconGPSstate.Image = Resources.Green_Check1;
            } else if (mf.health.gpsState == 2)
            {
                iconGPSstate.Image = Resources.Warning;    
            }

            // TODO: IMU Health

            // TODO: NTRIP Health
        }
    }
}

// TODO: use the CVehicle type variable to enable combine datalogging
// TODO: in CVehicle, calculate the yield from the mass flow sensor data
