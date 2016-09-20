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

        public Color DiagramColor { get; set; } = Color.BlueViolet;
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
            return l1|l3 && l2|l4;
        }
    }
}
