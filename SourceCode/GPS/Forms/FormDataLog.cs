using Parquet.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgOpenGPS.Forms
{
    public partial class FormDataLog : Form
    {
        
        private FormGPS mf = null;
        Timer logTimer = new Timer();
        public StreamWriter outputData = null;
        private String prevCurrentFieldDirectory;
        UInt32 t_output = (UInt32)(Math.Round((DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds));
        public FormDataLog(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();


            #region logTimer settings
            logTimer.Interval = 100;
            logTimer.Enabled = true;
            logTimer.Tick += new EventHandler(dataWrite);
            #endregion

            
        }

        public void dataWrite(object sender, EventArgs e)
        {
            if (mf.currentFieldDirectory != prevCurrentFieldDirectory)
            {
                outputData = new StreamWriter(mf.fieldsDirectory + "\\" + mf.currentFieldDirectory + "\\TaskData_" + t_output.ToString() + ".txt");
            }
            prevCurrentFieldDirectory = mf.currentFieldDirectory;
            String writeString = "";
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);

            writeString += "Timestamp:" + t.ToString();
            writeString += " ;Lat " + mf.Latitude.ToString();
            writeString += " ;Lon " + mf.Longitude.ToString();
            writeString += " ;TargetGPA " + mf.tool.targetRateGPA.ToString();

            for (int i = 0; i < mf.tool.numOfSections; i++)
            {
                writeString += " ; Section " + (i + 1).ToString() + " {";
                writeString += " speed " + mf.section[i].sectionSpeed.ToString("0.###");
                if (mf.section[i].isSectionOn)
                {
                    writeString += " , state: 1";
                }
                else
                {
                    writeString += " , state: 0";
                }
                writeString += " ;targetGPM " + mf.section[i].sectionTargetRate.ToString("0.###");
                writeString += " ;targetDutyCycle " + mf.section[i].sectionDutyTarget.ToString("0.###");
                writeString += "}";
            }
            outputData.WriteLine(writeString);
        }
    }
}
