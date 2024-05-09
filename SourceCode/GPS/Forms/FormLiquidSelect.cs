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
    public partial class FormLiquidSelect : Form
    {
        private readonly FormGPS mf = null;
        public FormLiquidSelect(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();
        }

        private void btnPlanter_Click(object sender, EventArgs e)
        {
            mf.tool.machineConfig = 1;
            Form f = Application.OpenForms["FormPlanter"];
            if (f != null)
            {
                f.Focus();
                return;
            }
            Form form = new FormPlanter(mf);
            form.Show(this);
            
            
        }

        private void btnSprayer_Click(object sender, EventArgs e)
        {
            mf.tool.machineConfig = 2;
            Form f = Application.OpenForms["FormSprayer"];
            if (f != null)
            {
                f.Focus();
                return;
            }
            Form form = new FormSprayer(mf);
            form.Show(this);
            
        }
    }
}
