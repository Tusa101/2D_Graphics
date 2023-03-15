using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _2D_Graphics
{
    //public class PictureBox1: PictureBox
    //{
    //    public bool DoubleBufferedPicture
    //    {
    //        get
    //        {
    //            return GetStyle(ControlStyles.OptimizedDoubleBuffer);
    //        }
    //        set
    //        {
    //            if (value != DoubleBuffered)
    //            {
    //                if (value)
    //                {
    //                    SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value);
    //                }
    //                else
    //                {
    //                    SetStyle(ControlStyles.OptimizedDoubleBuffer, value);
    //                }
    //            }
    //        }
    //    }
    //}
    public partial class Form1 : Form
    {
        private void DrawHoveredBorder(Graphics g, Button b)
        {
            ControlPaint.DrawBorder(g, b.ClientRectangle,
                    ColorTranslator.FromHtml("#C3F5FF"), 6, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#C3F5FF"), 6, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#C3F5FF"), 6, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#C3F5FF"), 6, ButtonBorderStyle.Outset);
        }
        private void DrawPressedBorder(Graphics g, Button b)
        {
            ControlPaint.DrawBorder(g, b.ClientRectangle,
                    ColorTranslator.FromHtml("#1A9CB6"), 4, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#1A9CB6"), 4, ButtonBorderStyle.Outset,
                    ColorTranslator.FromHtml("#ebfcff"), 4, ButtonBorderStyle.Solid,
                    ColorTranslator.FromHtml("#ebfcff"), 4, ButtonBorderStyle.Solid);
        }

        private void DrawNormalBorder(Graphics g, Button b)
        {
            ControlPaint.DrawBorder(g, b.ClientRectangle,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = paramsButton.CreateGraphics();
            DrawPressedBorder(graphics, paramsButton);
            Form2 form2 = new Form2
            {
                Owner = this
            };
            form2.Show();
        }

        private void DotsButton_Paint(object sender, PaintEventArgs e)
        {
            DrawNormalBorder(e.Graphics, dotsButton);

            ControlPaint.DrawBorder(e.Graphics, dotsButton.ClientRectangle,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset,
                ColorTranslator.FromHtml("#C3F5FF"), 4, ButtonBorderStyle.Outset);

        }

        private void Button2_Paint(object sender, PaintEventArgs e)
        {
            DrawNormalBorder(e.Graphics, paramsButton);
        }

        private void Button3_Paint(object sender, PaintEventArgs e)
        {
            if (movePaintingButton.Enabled)
            {
                DrawNormalBorder(e.Graphics, movePaintingButton);
            }
            else
            {
                DrawPressedBorder(e.Graphics, movePaintingButton);
            }
            
        }

        private void Button4_Paint(object sender, PaintEventArgs e)
        {
            if (clearButton.Enabled)
            {
                DrawNormalBorder(e.Graphics, clearButton);
            }
            else
            {
                DrawPressedBorder(e.Graphics, clearButton);
            }
            
        }

        private void Button5_Paint(object sender, PaintEventArgs e)
        {
            if (curveButton.Enabled)
            {
                DrawNormalBorder(e.Graphics, curveButton);
            }
            else
            {
                DrawPressedBorder(e.Graphics, curveButton);
            }
        }

        private void Button6_Paint(object sender, PaintEventArgs e)
        {
            if (polygonButton.Enabled)
            {
                DrawNormalBorder(e.Graphics, polygonButton);
            }
            else
            {
                DrawPressedBorder(e.Graphics, polygonButton);
            }
            
        }

        private void Button7_Paint(object sender, PaintEventArgs e)
        {
            if (beizerButton.Enabled)
            {
                DrawNormalBorder(e.Graphics, beizerButton);
            }
            else
            {
                DrawPressedBorder(e.Graphics, beizerButton);
            }
        }

        private void Button8_Paint(object sender, PaintEventArgs e)
        {
            if (filledCurveButton.Enabled)
            {
                DrawNormalBorder(e.Graphics, filledCurveButton);
            }
            else
            {
                DrawPressedBorder(e.Graphics, filledCurveButton);
            }
        }
        private void TraceButton_Paint(object sender, PaintEventArgs e)
        {
            if (traceButton.Enabled)
            {
                DrawNormalBorder(e.Graphics, traceButton);
            }
            else
            {
                DrawPressedBorder(e.Graphics, traceButton);
            }
        }

        private void TraceTimerTickHandler(object sender, EventArgs e)
        {
         
            Graphics g = paintingField.CreateGraphics();
            Pen p = new Pen(color: ColorTranslator.FromHtml("#1A9CB6"), width: PaintPenSize);
            Brush brush = new SolidBrush(color: ColorTranslator.FromHtml("#1A9CB6"));
            int[] temp = new int[2];
            Text = paintingField.Width + "x" + paintingField.Height;
            for (int i = 0; i < points.Length; i++)
            {

                if (points[i].X + _movingSpeed <= 0)
                {
                    Random random = new Random();
                    temp[0] = 1;
                    temp[1] = 2;
                    _direction = temp[random.Next(0, 1)];
                }
                if (points[i].Y + _movingSpeed <= 0)
                {
                    Random random = new Random();
                    temp[0] = 1;
                    temp[1] = 4;
                    _direction = temp[random.Next(0, 1)];
                }
                if (points[i].X + _movingSpeed >= paintingField.Width)
                {
                    Random random = new Random();
                    temp[0] = 3;
                    temp[1] = 4;
                    _direction = temp[random.Next(0, 1)];
                }
                if (points[i].Y + _movingSpeed >= paintingField.Height)
                {
                    Random random = new Random();
                    temp[0] = 2;
                    temp[1] = 4;
                    _direction = temp[random.Next(0, 1)];
                }
                switch (_direction)
                {
                    case 1:
                        {
                            points[i] = new Point(points[i].X + _movingSpeed, points[i].Y + _movingSpeed);
                            DrawDot(g, p, brush, points[i]);
                        }
                        break;
                    case 2:
                        {
                            points[i] = new Point(points[i].X + _movingSpeed, points[i].Y - _movingSpeed);
                            DrawDot(g, p, brush, points[i]);
                        }
                        break;
                    case 3:
                        {
                            points[i] = new Point(points[i].X - _movingSpeed, points[i].Y - _movingSpeed);
                            DrawDot(g, p, brush, points[i]);
                        }
                        break;
                    case 4:
                        {
                            points[i] = new Point(points[i].X - _movingSpeed, points[i].Y + _movingSpeed);
                            DrawDot(g, p, brush, points[i]);
                        }
                        break;
                    default:
                        break;
                }
                Brush brushFill = new SolidBrush(color: ColorTranslator.FromHtml("#23cbff"));
                try
                {
                    CurveFilledDone = true;
                    g.FillClosedCurve(brushFill, points);
                    g.DrawClosedCurve(p, points);
                }
                catch (Exception)
                { }

            }
        }


        private void MoveTimerTickHandler(object sender, EventArgs e)
        {
            Refresh();
            Graphics g = paintingField.CreateGraphics();
            Pen p = new Pen(color: ColorTranslator.FromHtml("#1A9CB6"), width: PaintPenSize);
            Brush brush = new SolidBrush(color: ColorTranslator.FromHtml("#1A9CB6"));
            int[] temp= new int[2];
            Text = paintingField.Width + "x" + paintingField.Height;
            for (int i = 0; i < points.Length; i++)
            {

                if(points[i].X + _movingSpeed <= 0)
                {
                    Random random = new Random();
                    temp[0] = 1;
                    temp[1] = 2;
                    _direction = temp[random.Next(0,1)];   
                }
                if (points[i].Y + _movingSpeed <= 0)
                {
                    Random random = new Random();
                    temp[0] = 1;
                    temp[1] = 4;
                    _direction = temp[random.Next(0, 1)];
                }
                if (points[i].X + _movingSpeed >= paintingField.Width)
                {
                    Random random = new Random();
                    temp[0] = 3;
                    temp[1] = 4;
                    _direction = temp[random.Next(0, 1)];
                }
                if (points[i].Y + _movingSpeed >= paintingField.Height)
                {
                    Random random = new Random();
                    temp[0] = 2;
                    temp[1] = 4;
                    _direction = temp[random.Next(0, 1)];
                }
                switch (_direction)
                {
                    case 1:
                        {
                            points[i] = new Point(points[i].X + _movingSpeed, points[i].Y + _movingSpeed);
                            DrawDot(g, p, brush, points[i]);
                        }
                        break;
                    case 2:
                        {
                            points[i] = new Point(points[i].X + _movingSpeed, points[i].Y - _movingSpeed);
                            DrawDot(g, p, brush, points[i]);
                        }
                        break;
                    case 3:
                        {
                            points[i] = new Point(points[i].X - _movingSpeed, points[i].Y - _movingSpeed);
                            DrawDot(g, p, brush, points[i]);
                        }
                        break;
                    case 4:
                        {
                            points[i] = new Point(points[i].X - _movingSpeed, points[i].Y + _movingSpeed);
                            DrawDot(g, p, brush, points[i]);
                        }
                        break;
                    default:
                        break;
                }   
            }
        }

        private void MovePaintingButton_MouseHover(object sender, EventArgs e)
        {
            Graphics graphics = movePaintingButton.CreateGraphics();
            DrawHoveredBorder(graphics, movePaintingButton);
        }

        private void MovePaintingButton_MouseLeave(object sender, EventArgs e)
        {
            Graphics graphics = movePaintingButton.CreateGraphics();
            DrawNormalBorder(graphics, movePaintingButton);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LockPainting = !LockPainting;
            Graphics graphics = dotsButton.CreateGraphics();
            DrawPressedBorder(graphics, dotsButton);
        }

        private void DotsButton_MouseHover(object sender, EventArgs e)
        {
            Graphics graphics = dotsButton.CreateGraphics();
            DrawHoveredBorder(graphics, dotsButton);
        }

        private void DotsButton_MouseLeave(object sender, EventArgs e)
        {
            Graphics graphics = dotsButton.CreateGraphics();
            DrawNormalBorder(graphics, dotsButton);
        }
        private void ClearButton_MouseHover(object sender, EventArgs e)
        {
            Graphics graphics = clearButton.CreateGraphics();
            DrawHoveredBorder(graphics, clearButton);
        }

        private void ClearButton_MouseLeave(object sender, EventArgs e)
        {
            Graphics graphics = clearButton.CreateGraphics();
            DrawNormalBorder(graphics, clearButton);
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (points.Length >=0)
            {
                clearButton.Enabled = true;
                movePaintingButton.Enabled = true;  
            }
            if (points.Length >=1)
            {
                curveButton.Enabled = true;
                polygonButton.Enabled = true;
            }
            if(points.Length >=2)
            {
                traceButton.Enabled = true;
                filledCurveButton.Enabled = true;
            }
            if (points.Length >=3)
            {
                beizerButton.Enabled = true;
            }
            if(!_movingPoint)
            {
                CurveDone = false;
                BeziersDone = false;
                CurveFilledDone = false;
                PolygonDone = false;
                Graphics g = paintingField.CreateGraphics();
                Pen p = new Pen(color: ColorTranslator.FromHtml("#1A9CB6"), width: PaintPenSize);
                Brush brush = new SolidBrush(color: ColorTranslator.FromHtml("#1A9CB6"));
                var clickCoords = e.Location;
                if (!LockPainting)
                {
                    Array.Resize(ref points, points.Length + 1);
                    points[points.Length - 1] = clickCoords;
                }
                for (int i = 0; i < points.Length; i++)
                {
                    DrawDot(g, p, brush, points[i]);
                }
            }
            
        }


        private void DrawDot(Graphics g, Pen p, Brush brush, Point point)
        {
            g.DrawEllipse(p, new Rectangle(new Point(point.X - PaintPenSize / 2,
                                                         point.Y - PaintPenSize / 2),
                                               new Size(PaintPenSize, PaintPenSize)));
            g.FillEllipse(brush, new Rectangle(new Point(point.X - PaintPenSize / 2,
                                                         point.Y - PaintPenSize / 2),
                                               new Size(PaintPenSize, PaintPenSize)));
        }

        private void Curve_Click(object sender, EventArgs e)
        {
            Refresh();
            BeziersDone = false;
            CurveFilledDone = false;
            PolygonDone = false;
            Graphics g = paintingField.CreateGraphics();
            Pen p = new Pen(color: ColorTranslator.FromHtml("#1A9CB6"), width: PaintLineSize);
            try
            {
                CurveDone = true;
                g.DrawClosedCurve(p, points);
            }
            catch (Exception)
            {            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            movePaintingButton.Enabled = false;
            clearButton.Enabled = false;
            curveButton.Enabled = false;
            traceButton.Enabled = false;
            filledCurveButton.Enabled = false;
            polygonButton.Enabled = false;
            beizerButton.Enabled = false;

            Graphics g = clearButton.CreateGraphics();
            DrawPressedBorder(g, clearButton);
            CurveDone = false;
            PolygonDone = false;
            BeziersDone = false;
            CurveFilledDone = false;
            Array.Resize(ref points, 0);
            Refresh();
        }
        private void Polygon_Click(object sender, EventArgs e)
        {
            Refresh();
            DrawPressedBorder(polygonButton.CreateGraphics(), polygonButton);
            CurveDone = false;
            BeziersDone = false;
            CurveFilledDone = false;
            Graphics g = paintingField.CreateGraphics();
            Pen p = new Pen(color: ColorTranslator.FromHtml("#1A9CB6"), width: PaintLineSize);
            try
            {
                PolygonDone = true;
                g.DrawPolygon(p, points);
            }
            catch (Exception)
            { }
        }
        private void Beziers_Click(object sender, EventArgs e)
        {
            Refresh();
            
            CurveDone = false;
            CurveFilledDone = false;
            PolygonDone = false;
            Graphics g = paintingField.CreateGraphics();
            DrawPressedBorder(beizerButton.CreateGraphics(), beizerButton);
            Pen p = new Pen(color: ColorTranslator.FromHtml("#1A9CB6"), width: PaintLineSize);
            try
            {
                BeziersDone = true;
                g.DrawBeziers(p, points);
            }
            catch (Exception)
            { }
        }
        private void FillCurve_Click(object sender, EventArgs e)
        {
            DrawPressedBorder(filledCurveButton.CreateGraphics(), filledCurveButton);
            Refresh();
            CurveDone = false;
            BeziersDone = false;
            PolygonDone = false;
            Graphics g = paintingField.CreateGraphics();
            Pen p = new Pen(color: ColorTranslator.FromHtml("#1A9CB6"), width: PaintLineSize);
            Brush brush = new SolidBrush(color: ColorTranslator.FromHtml("#23cbff"));
            try
            {
                CurveFilledDone = true;
                g.FillClosedCurve(brush, points);
                g.DrawClosedCurve(p, points);
            }
            catch (Exception)
            { }
        }
        private void PaintingField_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < points.Length; i++)
            {
                if (e.X >= points[i].X - PaintPenSize * 1.5 &&
                    e.X <= points[i].X + PaintPenSize * 1.5 &&
                    e.Y >= points[i].Y - PaintPenSize * 1.5 &&
                    e.Y <= points[i].Y + PaintPenSize * 1.5)
                {
                    _draggingPoint = i;
                    _movingPoint = true;
                }
            }
        }

        private void PaintingField_MouseMove(object sender, MouseEventArgs e)
        {
            if (_movingPoint)
            {
                points[_draggingPoint] = new Point(e.Location.X, e.Location.Y);
                Refresh();
            }
        }

        private void PaintingField_MouseUp(object sender, MouseEventArgs e)
        {
            _movingPoint = false;
        }
    }
}
