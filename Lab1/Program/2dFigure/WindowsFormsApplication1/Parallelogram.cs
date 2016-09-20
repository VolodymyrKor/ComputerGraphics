using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Parallelogram
    {
        public Parallelogram(Point vertexA, Point vertexB, Point vertexC, Point vertexD)
        {
            VertexA = vertexA;
            VertexB = vertexB;
            VertexC = vertexC;
            VertexD = vertexD;
        }

        public Color DiagonalColor { get; set; } = Color.BlueViolet;
        public Color BackgroundColor { get; set; } = Color.Aquamarine;

        public Point VertexA { get; set; }

        public Point VertexB { get; set; }

        public Point VertexC { get; set; }

        public Point VertexD { get; set; }

        public bool IsCorrect()
        {
            var l1 = new Line(VertexA.X, VertexA.Y, VertexB.X, VertexB.Y);
            var l2 = new Line(VertexB.X, VertexB.Y, VertexC.X, VertexC.Y);
            var l3 = new Line(VertexC.X, VertexC.Y, VertexD.X, VertexD.Y);
            var l4 = new Line(VertexA.X, VertexA.Y, VertexD.X, VertexD.Y);
            return l1 | l3 && l2 | l4;
        }

        public Point IntersectionPoint(Point vertex, Line l)
        {
            var p = new Point();
            if (l.K == 0 && l.Y1 == l.Y2)
            {
                p.X = vertex.X;
                p.Y = l.Y1;
            }
            else
            {
                if (l.K == 0 && l.X1 == l.X2)
                {
                    p.X = l.X1;
                    p.Y = vertex.Y;
                }
                else
                {
                    double k_h = -1 / l.K;
                    double b_h = vertex.Y - k_h * vertex.X;
                    double b_l = l.Y1 - l.K * l.X1;
                    double X = (b_l - b_h) / (k_h - l.K);
                    double Y = b_h + k_h * X;
                    p.X = Convert.ToInt32(X);
                    p.Y = Convert.ToInt32(Y);
                }
            }
            return p;
        }
    }
}
