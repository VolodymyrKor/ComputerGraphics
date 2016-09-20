using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public static Graphics Gr;
        public static PictureBox Picture;
        public static int ParallelogramCounter = 0;
        public static List<Parallelogram> Parallelograms = new List<Parallelogram>();

        public Main()
        {
            InitializeComponent();
        }

        private void onlyDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawCoordinates();
        }

        private void DrawBtn_Click(object sender, EventArgs e)
        {
            if (A_X_TextBox.Text.Length > 0 && B_X_TextBox.Text.Length > 0 && C_X_TextBox.Text.Length > 0 &&
                D_X_TextBox.Text.Length > 0 && D_Y_TextBox.Text.Length > 0 && C_Y_TextBox.Text.Length > 0 &&
                B_Y_TextBox.Text.Length > 0 && A_Y_TextBox.Text.Length > 0)
            {
                var a = new Point(int.Parse(A_X_TextBox.Text), int.Parse(A_Y_TextBox.Text));
                var b = new Point(int.Parse(B_X_TextBox.Text), int.Parse(B_Y_TextBox.Text));
                var c = new Point(int.Parse(C_X_TextBox.Text), int.Parse(C_Y_TextBox.Text));
                var d = new Point(int.Parse(D_X_TextBox.Text), int.Parse(D_Y_TextBox.Text));

                var p = new Parallelogram(a, b, c, d);

                if (p.IsCorrect())
                {
                    ParallelogramCounter++;
                    Parallelograms.Add(p);

                    DrawCoordinates();

                    Gr = DrawPanel.CreateGraphics();

                    var myPen = new Pen(Brushes.BlueViolet, 2);

                    Gr.DrawLine(myPen,
                        new Point(300 + 4 * int.Parse(A_X_TextBox.Text), 220 - 4 * int.Parse(A_Y_TextBox.Text)),
                        new Point(300 + 4 * int.Parse(B_X_TextBox.Text), 220 - 4 * int.Parse(B_Y_TextBox.Text)));
                    Gr.DrawLine(myPen,
                        new Point(300 + 4 * int.Parse(A_X_TextBox.Text), 220 - 4 * int.Parse(A_Y_TextBox.Text)),
                        new Point(300 + 4 * int.Parse(D_X_TextBox.Text), 220 - 4 * int.Parse(D_Y_TextBox.Text)));
                    Gr.DrawLine(myPen,
                        new Point(300 + 4 * int.Parse(B_X_TextBox.Text), 220 - 4 * int.Parse(B_Y_TextBox.Text)),
                        new Point(300 + 4 * int.Parse(C_X_TextBox.Text), 220 - 4 * int.Parse(C_Y_TextBox.Text)));
                    Gr.DrawLine(myPen,
                        new Point(300 + 4 * int.Parse(C_X_TextBox.Text), 220 - 4 * int.Parse(C_Y_TextBox.Text)),
                        new Point(300 + 4 * int.Parse(D_X_TextBox.Text), 220 - 4 * int.Parse(D_Y_TextBox.Text)));
                    Gr.DrawLine(myPen,
                        new Point(300 + 4 * int.Parse(A_X_TextBox.Text), 220 - 4 * int.Parse(A_Y_TextBox.Text)),
                        new Point(300 + 4 * int.Parse(C_X_TextBox.Text), 220 - 4 * int.Parse(C_Y_TextBox.Text)));
                    Gr.DrawLine(myPen,
                        new Point(300 + 4 * int.Parse(B_X_TextBox.Text), 220 - 4 * int.Parse(B_Y_TextBox.Text)),
                        new Point(300 + 4 * int.Parse(D_X_TextBox.Text), 220 - 4 * int.Parse(D_Y_TextBox.Text)));
                    DrawPerpendicular(p.VertexB, p.IntersectionPoint(p.VertexB, new Line(p.VertexA.X, p.VertexA.Y, p.VertexD.X, p.VertexD.Y)));
                }
                else
                {
                    MessageBox.Show(@"Введена вами фігура не являється паралелограмом!", @"Помилка!");
                }
            }
            else
                MessageBox.Show(@"Некоректне введення!", @"Помилка!");
        }

        private void ChooseColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1 != null && colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color? color = colorDialog1.Color;
                var myPen = new Pen(color.Value, 2);
                Parallelograms[ParallelogramCounter - 1].DiagonalColor = color.Value;
                Gr.DrawLine(myPen,
                    new Point(300 + 4 * int.Parse(A_X_TextBox.Text), 220 - 4 * int.Parse(A_Y_TextBox.Text)),
                    new Point(300 + 4 * int.Parse(C_X_TextBox.Text), 220 - 4 * int.Parse(C_Y_TextBox.Text)));
                Gr.DrawLine(myPen,
                    new Point(300 + 4 * int.Parse(B_X_TextBox.Text), 220 - 4 * int.Parse(B_Y_TextBox.Text)),
                    new Point(300 + 4 * int.Parse(D_X_TextBox.Text), 220 - 4 * int.Parse(D_Y_TextBox.Text)));
            }
        }

        private void DrawPerpendicular(Point A, Point B)
        {
            var myPen = new Pen(Brushes.BlueViolet, 2);
            Gr.DrawLine(myPen, 
                new Point(300 + 4 * A.X, 220 - 4 * A.Y), 
                new Point(300 + 4 * B.X, 220 - 4 * B.Y));
        }

        private void Coordinates_Enter(object sender, EventArgs e)
        {
            Picture = new PictureBox() { Name = "helpPicture", Location = new Point(13, 220), Size = new Size(272, 186) };
            Controls.Add(Picture);
            Picture.Load("../../download.png");
        }

        private void Coordinates_Leave(object sender, EventArgs e)
        {
            Controls.Remove(Picture);
        }

        private void DrawCoordinates()
        {
            //DrawPanel.Invalidate();
            Gr = DrawPanel.CreateGraphics();

            Gr.FillRectangle(Brushes.White, 0, 0, 522, 522);

            var w = DrawPanel.Width;
            var h = DrawPanel.Height;
            var widthLines = 20;
            var heightLines = 20;
            Pen myPen = new Pen(Brushes.Black, 1);

            for (int i = 0; i < w; i += widthLines)
            {
                Gr.DrawLine(myPen, new Point(i + widthLines, 0), new Point(i + widthLines, h));
                Gr.DrawLine(myPen, new Point(0, i + heightLines), new Point(w, i + heightLines));
            }
            myPen.Width = 5;
            myPen.StartCap = LineCap.ArrowAnchor;
            Gr.DrawLine(myPen, new Point(300, 0), new Point(300, h));
            myPen.StartCap = LineCap.NoAnchor;
            myPen.EndCap = LineCap.ArrowAnchor;
            Gr.DrawLine(myPen, new Point(0, 220), new Point(w, 220));
            myPen.EndCap = LineCap.NoAnchor;
            myPen.Width = 2;
            Gr.DrawLine(myPen, new Point(260, 0), new Point(260, h));
            Gr.DrawLine(myPen, new Point(0, 260), new Point(w, 260));
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawCoordinates();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}