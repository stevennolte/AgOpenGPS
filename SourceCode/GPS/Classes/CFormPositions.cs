using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgOpenGPS.Classes
{
    public class CFormPositions
    {
        public int
            mainFormTop,
            mainFormLeft,
            mainFormHeight,
            mainFormWidth,
            oglTop,
            oglLeft,
            oglHeight,
            oglWidth,
            impPanelTop,
            impPanelLeft,
            impPanelRight,
            impPanelHeight;
        private readonly FormGPS mf;
        public CFormPositions(FormGPS _f)
        {
            mf = _f;
        }
    }
}
