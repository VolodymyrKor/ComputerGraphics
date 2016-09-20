using System;
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
            Gr = ((Panel)sender).CreateGraphics();

            var w = ((Panel)sender).Width;
            var h = ((Panel)sender).Height;
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

        private void DrawBtn_Click(object sender, EventArgs e)
        {
            if (A_X_TextBox.Text.Length > 0 && B_X_TextBox.Text.Length > 0 && C_X_TextBox.Text.Length > 0 &&
                D_X_TextBox.Text.Length > 0 && D_Y_TextBox.Text.Length > 0 && C_Y_TextBox.Text.Length > 0 &&
                B_Y_TextBox.Text.Length > 0 && A_Y_TextBox.Text.Length > 0)
            {
                Gr = DrawPanel.CreateGraphics();

                var myPen = new Pen(Brushes.BlueViolet, 2);

                Gr.DrawLine(myPen,
                    new Point(300 + 4 * int.Parse(A_X_TextBox.Text), 220 - 4 * int.Parse(A_Y_TextBox.Text)),
                    new Point(300 + 4 * int.Parse(B_X_TextBox.Text), 220 - 4 * int.Parse(B_Y_TextBox.Text)));
                Gr.DrawLine(myPen,
                    new Point(300 + 4 * int.Parse(A_X_TextBox.Text), 220 - 4 * int.Parse(A_Y_TextBox.Text)),
                    new Point(300 + 4 * int.Parse(C_X_TextBox.Text), 220 - 4 * int.Parse(C_Y_TextBox.Text)));
                Gr.DrawLine(myPen,
                    new Point(300 + 4 * int.Parse(A_X_TextBox.Text), 220 - 4 * int.Parse(A_Y_TextBox.Text)),
                    new Point(300 + 4 * int.Parse(D_X_TextBox.Text), 220 - 4 * int.Parse(D_Y_TextBox.Text)));
                Gr.DrawLine(myPen,
                    new Point(300 + 4 * int.Parse(B_X_TextBox.Text), 220 - 4 * int.Parse(B_Y_TextBox.Text)),
                    new Point(300 + 4 * int.Parse(C_X_TextBox.Text), 220 - 4 * int.Parse(C_Y_TextBox.Text)));
                Gr.DrawLine(myPen,
                    new Point(300 + 4 * int.Parse(B_X_TextBox.Text), 220 - 4 * int.Parse(B_Y_TextBox.Text)),
                    new Point(300 + 4 * int.Parse(D_X_TextBox.Text), 220 - 4 * int.Parse(D_Y_TextBox.Text)));
                Gr.DrawLine(myPen,
                    new Point(300 + 4 * int.Parse(C_X_TextBox.Text), 220 - 4 * int.Parse(C_Y_TextBox.Text)),
                    new Point(300 + 4 * int.Parse(D_X_TextBox.Text), 220 - 4 * int.Parse(D_Y_TextBox.Text)));
            }
            else
                MessageBox.Show(@"Некоректне введення!", @"Помилка!");
        }

        private void ChooseColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1 != null && colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //Color? color = colorDialog1.Color;
                //new Pen(color.Value, 2);
            }
        }

        private void Coordinates_Enter(object sender, EventArgs e)
        {
            Picture = new PictureBox(){ Name = "helpPicture", Location = new Point(13, 180), Size = new Size(272, 186) };
            Controls.Add(Picture);
            Picture.Load("../../download.png");
        }

        private void Coordinates_Leave(object sender, EventArgs e)
        {
            Controls.Remove(Picture);
        }
    }
}