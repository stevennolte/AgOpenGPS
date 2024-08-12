using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgOpenGPS.Classes
{

    public class CPowerMonitor
    {
        private readonly FormGPS mf;
        public byte version1;
        public byte version2;
        public byte version3;


        public CPowerMonitor(FormGPS _f)
        {
            //constructor
            mf = _f;
        }

        public void powerDown()
        {
            // TODO: add popup for shutdown confirmation or cancelation
            int shutdownDelay = 20; // Example: 60 seconds delay

            // Construct the shutdown command
            string shutdownCommand = $"/s /t {shutdownDelay}";
            Process.Start("shutdown", shutdownCommand);

            Console.WriteLine($"The PC will shut down in {shutdownDelay} seconds.");

            Application.Exit();
        }
    }
}
