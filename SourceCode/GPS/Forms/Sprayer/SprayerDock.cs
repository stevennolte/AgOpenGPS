using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgOpenGPS.Forms.Sprayer
{
    public partial class SprayerDock : Form
    {
        private FormGPS mf = null;
        public SprayerDock(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();
        }

        private void toggleAutoControl_CheckedChanged(object sender)
        {

        }
    }
}
