using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgOpenGPS.Classes
{
    public class CHealth
    {
        public byte imuState;
        public byte gpsState;
        public byte steerState;
        private readonly FormGPS mf;
        public CHealth(FormGPS _f)
        {
            //constructor
            mf = _f;
        }

        public void checkAIOstates()
        {

        }

    }
}
