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

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = button2.CreateGraphics();
            ControlPaint.DrawBorder(graphics, button2.ClientRectangle,
                    ColorTranslator.FromHtml("#1A9CB6"), 4, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#1A9CB6"), 4, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#ebfcff"), 4, ButtonBorderStyle.Solid,
                    ColorTranslator.FromHtml("#ebfcff"), 4, ButtonBorderStyle.Solid);
            Form2 form2 = new Form2();
            form2.Owner = this;
            form2.ShowDialog();
        }

        private void button2_Pressed(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button2.ClientRectangle,
                ColorTranslator.FromHtml("#1A9CB6"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#1A9CB6"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#ebfcff"), 4, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#ebfcff"), 4, ButtonBorderStyle.Solid);
        }

        private void dotsButton_Paint(object sender, PaintEventArgs e)
        {

            ControlPaint.DrawBorder(e.Graphics, dotsButton.ClientRectangle,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset);

        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button2.ClientRectangle,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset);
        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button3.ClientRectangle,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset);
        }

        private void button4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button4.ClientRectangle,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset);
        }

        private void button5_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button5.ClientRectangle,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset);
        }

        private void button6_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button6.ClientRectangle,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset);
        }

        private void button7_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button7.ClientRectangle,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset);
        }

        private void button8_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button8.ClientRectangle,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen p = new Pen(color: ColorTranslator.FromHtml("#1A9CB6"), width: PaintBrush);
            Brush brush = new SolidBrush(color: ColorTranslator.FromHtml("#1A9CB6"));
            var clickCoords = e.Location;
            if (!LockPainting)
            {
                Array.Resize(ref points, points.Length+1);
                points[points.Length-1] = clickCoords;
            }
            for (int i = 0; i < points.Length; i++)
            {

                g.DrawEllipse(p, new Rectangle(new Point(points[i].X - PaintBrush/2, 
                                                         points[i].Y - PaintBrush / 2), 
                                               new Size(PaintBrush, PaintBrush)));
                g.FillEllipse(brush, new Rectangle(new Point(points[i].X - PaintBrush / 2, points[i].Y - PaintBrush / 2), new Size(PaintBrush, PaintBrush)));
            }

            //graphics.FillClosedCurve(Brushes.ForestGreen, arPoints)
        }

        private void dotsButton_MouseHover(object sender, EventArgs e)
        {
            Graphics graphics = dotsButton.CreateGraphics();
            ControlPaint.DrawBorder(graphics, dotsButton.ClientRectangle,
                    ColorTranslator.FromHtml("#C3F5FF"), 6, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#C3F5FF"), 6, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#C3F5FF"), 6, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#C3F5FF"), 6, ButtonBorderStyle.Outset);


        }
        private void dotsButton_Paint_Hovered(object sender, PaintEventArgs e)
        {



        }

        private void dotsButton_MouseLeave(object sender, EventArgs e)
        {
            Graphics graphics = dotsButton.CreateGraphics();
            ControlPaint.DrawBorder(graphics, dotsButton.ClientRectangle,
                    ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen p = new Pen(color: ColorTranslator.FromHtml("#1A9CB6"), width: PaintBrush);
            try
            {
                g.DrawClosedCurve(p, points);
            }
            catch (Exception)
            {            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Array.Resize(ref points, 0);
            Refresh();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen p = new Pen(color: ColorTranslator.FromHtml("#1A9CB6"), width: PaintBrush);
            try
            {  
                g.DrawPolygon(p, points);
            }
            catch (Exception)
            { }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen p = new Pen(color: ColorTranslator.FromHtml("#1A9CB6"), width: PaintBrush);
            Pen pDelete = new Pen(color: ColorTranslator.FromHtml("#ebfcff"), width: PaintBrush);
            Brush brush = new SolidBrush(color: ColorTranslator.FromHtml("#ebfcff"));
            
            if(DrawBeziersCustom(g, p, points))
            {
                try
                {
                    g.DrawEllipse(pDelete, new Rectangle(new Point(points[points.Length - 2].X - PaintBrush / 2,
                                                            points[points.Length - 2].Y - PaintBrush / 2),
                                                    new Size(PaintBrush, PaintBrush)));
                    g.FillEllipse(brush, new Rectangle(new Point(points[points.Length - 2].X - PaintBrush / 2,
                                                                    points[points.Length - 2].Y - PaintBrush / 2),
                                                        new Size(PaintBrush, PaintBrush)));
                    g.DrawEllipse(pDelete, new Rectangle(new Point(points[points.Length - 3].X - PaintBrush / 2,
                                                                    points[points.Length - 3].Y - PaintBrush / 2),
                                                            new Size(PaintBrush, PaintBrush)));
                    g.FillEllipse(brush, new Rectangle(new Point(points[points.Length - 3].X - PaintBrush / 2,
                                                                    points[points.Length - 3].Y - PaintBrush / 2),
                                                        new Size(PaintBrush, PaintBrush)));
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
