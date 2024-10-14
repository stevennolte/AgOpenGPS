using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgOpenGPS.Classes
{
    public class CMapColor
    {
        private readonly FormGPS mf;
        public Color Start = Color.FromArgb(255,255,0,0);
        public Color Center = Color.FromArgb(255, 236, 29, 1);
        public Color End = Color.FromArgb(255, 3, 255, 1);
        public double MinValue = 0;
        public double MaxValue = 100;
        public double Value = 0;
        public double centerValue = 75;
        public double percentage = 0;
        public string mappingField;

        public CMapColor(FormGPS _f)
        {
            mf = _f;
            

        }
        
        
        public int LinearInterp(int start, int end, double percentage) => start + (int)Math.Round(percentage * (end - start));
        public Color ColorInterp(Color start, Color end, double percentage) =>
            Color.FromArgb(LinearInterp(start.A, end.A, percentage),
                           LinearInterp(start.R, end.R, percentage),
                           LinearInterp(start.G, end.G, percentage),
                           LinearInterp(start.B, end.B, percentage));
        
        private void getValue(int _section)
        {
            switch (mappingField)
            {
                case "Coverage":
                    Value = MaxValue;
                    break;
                case "Speed":
                    Value = mf.section[_section].speed;
                    break;
            }
        }
        
        public Color getMapColor(int _section)
        {
            getValue(_section);
            


            if ((Value <= MaxValue) && (Value >= MinValue))
            {
                if (Value < centerValue)
                {
                    percentage = (Value - MinValue) / (centerValue - MinValue);
                }
                else if (Value > centerValue)
                {
                    percentage = (Value - centerValue) / (MaxValue - centerValue);
                }
                
                //percentage = Value / MaxValue;
            }
            else if (Value >= MaxValue)
            {
                percentage = 1.0;
            }
            else if (Value <= MinValue)
            {
                percentage = 0.0;
            }

            Debug.WriteLine($"Max: {MaxValue}  Min: {MinValue}  Center: {centerValue}  Value: {Value:F2}  Percentage: {percentage:F2}");
            if (Value < centerValue)
            {
                return ColorInterp(Start, Center, percentage);
            }
            else
            {
                return ColorInterp(Center, End, percentage);
            }
           

            //else
                
        }

    }

}
