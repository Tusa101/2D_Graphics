using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _2D_Graphics
{
    public partial class Form1 : Form
    {
        private void Button1_Click(object sender, EventArgs e)
        {
            LockPainting = !LockPainting;
            Graphics graphics = dotsButton.CreateGraphics();
            ControlPaint.DrawBorder(graphics, dotsButton.ClientRectangle,
                    ColorTranslator.FromHtml("#1A9CB6"), 4, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#1A9CB6"), 4, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#ebfcff"), 4, ButtonBorderStyle.Solid,
                    ColorTranslator.FromHtml("#ebfcff"), 4, ButtonBorderStyle.Solid);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = button2.CreateGraphics();
            ControlPaint.DrawBorder(graphics, button2.ClientRectangle,
                    ColorTranslator.FromHtml("#1A9CB6"), 4, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#1A9CB6"), 4, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#ebfcff"), 4, ButtonBorderStyle.Solid,
                    ColorTranslator.FromHtml("#ebfcff"), 4, ButtonBorderStyle.Solid);
            Form2 form2 = new Form2
            {
                Owner = this
            };
            form2.ShowDialog();
        }

        private void Button2_Pressed(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button2.ClientRectangle,
                ColorTranslator.FromHtml("#1A9CB6"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#1A9CB6"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#ebfcff"), 4, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#ebfcff"), 4, ButtonBorderStyle.Solid);
        }

        private void DotsButton_Paint(object sender, PaintEventArgs e)
        {

            ControlPaint.DrawBorder(e.Graphics, dotsButton.ClientRectangle,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset);

        }

        private void Button2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button2.ClientRectangle,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset);
        }

        private void Button3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button3.ClientRectangle,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset);
        }

        private void Button4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button4.ClientRectangle,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset);
        }

        private void Button5_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button5.ClientRectangle,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset);
        }

        private void Button6_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button6.ClientRectangle,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset);
        }

        private void Button7_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button7.ClientRectangle,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset);
        }

        private void Button8_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button8.ClientRectangle,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen p = new Pen(color: ColorTranslator.FromHtml("#1A9CB6"), width: PaintPenSize);
            Brush brush = new SolidBrush(color: ColorTranslator.FromHtml("#1A9CB6"));
            var clickCoords = e.Location;
            if (!LockPainting)
            {
                Array.Resize(ref points, points.Length+1);
                points[points.Length-1] = clickCoords;
            }
            for (int i = 0; i < points.Length; i++)
            {

                g.DrawEllipse(p, new Rectangle(new Point(points[i].X - PaintPenSize/2, 
                                                         points[i].Y - PaintPenSize / 2), 
                                               new Size(PaintPenSize, PaintPenSize)));
                g.FillEllipse(brush, new Rectangle(new Point(points[i].X - PaintPenSize / 2, points[i].Y - PaintPenSize / 2), new Size(PaintPenSize, PaintPenSize)));
            }

            //graphics.FillClosedCurve(Brushes.ForestGreen, arPoints)
        }

        private void DotsButton_MouseHover(object sender, EventArgs e)
        {
            Graphics graphics = dotsButton.CreateGraphics();
            ControlPaint.DrawBorder(graphics, dotsButton.ClientRectangle,
                    ColorTranslator.FromHtml("#C3F5FF"), 6, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#C3F5FF"), 6, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#C3F5FF"), 6, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#C3F5FF"), 6, ButtonBorderStyle.Outset);


        }
        private void DotsButton_Paint_Hovered(object sender, PaintEventArgs e)
        {



        }

        private void DotsButton_MouseLeave(object sender, EventArgs e)
        {
            Graphics graphics = dotsButton.CreateGraphics();
            ControlPaint.DrawBorder(graphics, dotsButton.ClientRectangle,
                    ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset);
        }

        private void Curve_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen p = new Pen(color: ColorTranslator.FromHtml("#1A9CB6"), width: PaintLineSize);
            try
            {
                g.DrawClosedCurve(p, points);
            }
            catch (Exception)
            {            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            Array.Resize(ref points, 0);
            Refresh();
        }
        private void Polygon_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen p = new Pen(color: ColorTranslator.FromHtml("#1A9CB6"), width: PaintLineSize);
            try
            {  
                g.DrawPolygon(p, points);
            }
            catch (Exception)
            { }
        }
        private void Beziers_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen p = new Pen(color: ColorTranslator.FromHtml("#1A9CB6"), width: PaintLineSize);
            Pen pDelete = new Pen(color: ColorTranslator.FromHtml("#ebfcff"), width: PaintPenSize);
            Brush brush = new SolidBrush(color: ColorTranslator.FromHtml("#ebfcff"));
            
            if(DrawBeziersCustom(g, p, points))
            {
                try
                {
                    g.DrawEllipse(pDelete, new Rectangle(new Point(points[points.Length - 2].X - PaintPenSize / 2,
                                                            points[points.Length - 2].Y - PaintPenSize / 2),
                                                    new Size(PaintPenSize, PaintPenSize)));
                    g.FillEllipse(brush, new Rectangle(new Point(points[points.Length - 2].X - PaintPenSize / 2,
                                                                    points[points.Length - 2].Y - PaintPenSize / 2),
                                                        new Size(PaintPenSize, PaintPenSize)));
                    g.DrawEllipse(pDelete, new Rectangle(new Point(points[points.Length - 3].X - PaintPenSize / 2,
                                                                    points[points.Length - 3].Y - PaintPenSize / 2),
                                                            new Size(PaintPenSize, PaintPenSize)));
                    g.FillEllipse(brush, new Rectangle(new Point(points[points.Length - 3].X - PaintPenSize / 2,
                                                                    points[points.Length - 3].Y - PaintPenSize / 2),
                                                        new Size(PaintPenSize, PaintPenSize)));
                    Point temp = new Point(points[points.Length - 1].X, points[points.Length - 1].Y);
                    Text = points.Length.ToString();
                    Array.Clear(points, points.Length - 2, 2);
                    Array.Resize(ref points, points.Length - 3);
                    points[points.Length - 1].X = temp.X;
                    points[points.Length - 1].Y = temp.Y;
                }
                catch (Exception)
                { }
            }
        }
        private void FillCurve_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen p = new Pen(color: ColorTranslator.FromHtml("#1A9CB6"), width: PaintLineSize*1.5f);
            Brush brush = new SolidBrush(color: ColorTranslator.FromHtml("#23cbff"));
            try
            {
                g.FillClosedCurve(brush, points);
                g.DrawClosedCurve(p, points);
            }
            catch (Exception)
            { }
        }

        private bool DrawBeziersCustom(Graphics g, Pen pen, Point[] points)
        {
            try
            {
                g.DrawBeziers(pen, points);
                return true;
            }
            catch (Exception)
            {
                return false; 
            }
        }
        
    }
}
