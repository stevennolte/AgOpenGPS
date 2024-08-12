using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;

// TODO: configure vehicle type to set the data to be logged
// TODO: set default logs: row states, gps locations, etc..



namespace AgOpenGPS.Forms
{
    public partial class FormDataLogger : Form
    {
        private System.Timers.Timer loggingTimer;
        private bool isLogging;
        private string filePath;
        private string fileName;
        private readonly FormGPS mf = null;
        private bool wasJobStarted = false;
        private bool wasJobFinished = false;
        private bool prevJobState = false;
        private long epochTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        public FormDataLogger(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();
            InitializeTimer();
            loggingTimer.Start();



        }

        private void InitializeTimer()
        {
            loggingTimer = new System.Timers.Timer
            {
                Interval = 100 // Set interval to 1 second for logging
            };
            loggingTimer.Elapsed += LoggingTimer_Elapsed;
        }

        private void createFile()
        {

        }

        private void LoggingTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (mf.logData == true)
            {
                

            
            
                if (prevJobState == false & mf.isJobStarted == true)
                {
                    epochTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                    fileName = $"Field_Data_{epochTime}.txt";
                    filePath = mf.fieldsDirectory + "\\" + mf.currentFieldDirectory + "\\" + fileName;
                    prevJobState = mf.isJobStarted;
                    isLogging = true;
                    loggingTimer.Start();
                }
                else if (prevJobState == true & mf.isJobStarted == false)
                {
                    isLogging = false;
                    loggingTimer.Stop();
                    prevJobState = mf.isJobStarted;
                }
            }
            
            if (isLogging)
            {
                string dataToWrite = "This is the data to be written to the file.";
                string timestampedData = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} {dataToWrite}";

                try
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                    {
                        using (StreamWriter writer = new StreamWriter(fs))
                        {
                            writer.WriteLine(timestampedData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Show message box on the UI thread
                    this.Invoke((MethodInvoker)delegate {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    });
                }
            }
        }
    }
}
