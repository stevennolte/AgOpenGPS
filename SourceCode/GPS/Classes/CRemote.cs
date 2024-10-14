using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgOpenGPS.Classes
{

    public class CRemote
    {
        public double lastMessageRecieved;
        public bool isConnected = false;
        public byte health = 0;
        public byte version1 = 0;
        public byte version2 = 0;
        public byte version3 = 0;

        private readonly FormGPS mf;

        public CRemote(FormGPS _f)
        {
            mf = _f;


        }
    }
}
