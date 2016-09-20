using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Line
    {
        public Line(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public int X1 { get; set; }

        public int Y1 { get; set; }

        public int X2 { get; set; }

        public int Y2 { get; set; }

        public double K
        {
            get
            {
                if ((X2 == X1) && (Y1 != Y2))
                    return 0;
                return ((double)(Y2 - Y1)) / ((double)(X2 - X1));
            }
        }

        public double Angle => Math.Atan(K) * 180 / Math.PI;

        public string Output()
        {
            double k = K, b = Y1 - k * X1;
            return $"y = {(Y2 - Y1)/(X2 - X1)} * x {(b < 0 ? '-' : '+')} {Math.Abs(b)}";
        }

        public static bool operator |(Line left, Line right)
        {
            return Math.Abs(left.K - right.K) < 0.1;
        }
    }
}
