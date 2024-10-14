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
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.IO.Pipes;

// TODO: configure vehicle type to set the data to be logged
// TODO: set default logs: row states, gps locations, etc..



namespace AgOpenGPS.Forms
{
    public partial class FormDataLogger : Form
    {
        private double dummy;
        private System.Timers.Timer loggingTimer;
        private System.Timers.Timer flushTimer;
        private bool isLogging;
        private string filePath;
        private string fileName;
        private readonly FormGPS mf = null;
        //private bool wasJobStarted = false;
        //private bool wasJobFinished = false;
        private bool prevJobState = false;
        private long epochTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        private StringBuilder buffer; // Buffer to hold the data stream
        private int bufferSize = 1024;
        private string logFilePath = "";
        private FileStream fileStream;  // Stream to handle the file
        private StreamWriter streamWriter; // Writer to handle text logging

        public FormDataLogger(Form callingForm)
        {
            mf = callingForm as FormGPS;
            buffer = new StringBuilder();

            InitializeComponent();
            
            epochTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            fileName = $"Field_Data_{epochTime}.txt";
            logFilePath = mf.fieldsDirectory + "\\" + mf.currentFieldDirectory + "\\" + fileName;
            fileStream = new FileStream(logFilePath, FileMode.Append, FileAccess.Write, FileShare.Read);
            streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
            flushTimer = new System.Timers.Timer(5000); // Set flush interval (e.g., 5 seconds)
            flushTimer.Elapsed += FlushTimer_Elapsed;
            buildHeader();

            InitializeTimer();
            flushTimer.Start();
            loggingTimer.Start();
            mf.dataLogger.checkForFile();



        }
        private void FlushTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            FlushBufferToFile();
            mf.dataLogger.UpdateParameter("massHarvested", mf.fd.totalMass.ToString());
            mf.dataLogger.UpdateParameter("moisture", mf.fd.averageMoisture.ToString());
            mf.dataLogger.UpdateParameter("moistureCnt", mf.fd.moistureCnt.ToString());
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

        public void ReceiveData(string data)
        {
            buffer.Append(data);

            // Check if the buffer has reached its capacity
            if (buffer.Length >= bufferSize)
            {
                FlushBufferToFile();
            }

        }
        private void FlushBufferToFile()
        {
            if (buffer.Length > 0)
            {
                try
                {
                    streamWriter.Write(buffer.ToString()); // Write buffer to file
                    streamWriter.Flush(); // Ensure data is written to file
                    buffer.Clear(); // Clear the buffer after writing
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error writing to log file: " + ex.Message);
                }
            }
            
            
        }
        private void buildHeader()
        {
            string header = "timestamp,latitude,longitude,number_of_sections,speed,target_rate,moisture,mass_flow,yeild";
            for (int i = 0; i < mf.tool.numOfSections; i++)
            {
                header = header + $",row_{i}_lat,row_{i}_lon,row_{i}_speed,row_{i}_state";
            }
            ReceiveData(header + "\n");
        }
        private void LoggingTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            
            
            
            string dataToWrite = "";
            string timestampedData = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}";
            dataToWrite += timestampedData;
            dataToWrite += $",{mf.Latitude},{mf.Longitude},{mf.tool.numOfSections},{mf.avgSpeed},{mf.tool.targetRate},{mf.vehicle.moisture},{mf.vehicle.massFlowrate},{mf.vehicle.yeild}";
                
            for (int i = 0; i < mf.tool.numOfSections; i++)
            {
                double lat = 0;
                double lon = 0;
                mf.pn.ConvertLocalToWGS84(mf.section[i].leftPoint.northing, mf.section[i].leftPoint.easting, out lat, out lon);
                dataToWrite += $",{lat.ToString()},{lon.ToString()},{mf.section[i].speed},{mf.section[i].isSectionOn}";
            }
            try
            {
                ReceiveData(dataToWrite+"\n");
                //using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                //{
                //    using (StreamWriter writer = new StreamWriter(fs))
                //    {
                //        writer.WriteLine(dataToWrite);
                //    }
                //}
            }
            catch (Exception ex)
            {
                //// Show message box on the UI thread
                //this.Invoke((MethodInvoker)delegate {
                //    MessageBox.Show($"An error occurred: {ex.Message}");
                //});
            }
            
        }
    }
}
