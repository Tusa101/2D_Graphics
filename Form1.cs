using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _2D_Graphics
{
    public partial class Form1 : Form
    {   
        private static int _movingSpeed = 5;
        private static bool _movingEnabled = false;
        private static int _direction = (new Random()).Next(0,3);
        private static bool _beziersDone = false;
        private static bool _curveDone = false;
        private static bool _polygonDone = false;
        private static bool _curveFilledDone = false;
        private static int _draggingPoint;
        private static bool _movingPoint;
        private static Timer moveTimer = new Timer();
        private static Timer traceTimer = new Timer();
        public Size ButtonDefaultSize
        { get; set; }
        public Point ButtonDefaultLocation
        { get; set; }
        public Size PaintFieldDefaultSize
        { get; set; }
        public Point PaintFieldDefaultLocation
        { get; set; }
        public bool BeziersDone
        {
            get { return _beziersDone; }
            set { _beziersDone = value;}
        }
        public bool CurveDone
        {
            get { return _curveDone; }
            set { _curveDone = value; }
        }
        public bool PolygonDone
        {
            get { return _polygonDone; }
            set { _polygonDone = value; }
        }
        public bool CurveFilledDone
        {
            get { return _curveFilledDone; }
            set { _curveFilledDone = value; }
        }

        private static bool LockPainting = false;
        private static Point[] points = new Point[] { };
        
        private static int _paintPenSize = 4;
        public int PaintPenSize 
        {
            get
            {
                return _paintPenSize;
            }
            set
            { _paintPenSize = value; }
        }
        private static int _paintLineSize = 4;
        public int PaintLineSize
        {
            get
            {
                return _paintLineSize;
            }
            set
            { _paintLineSize = value; }
        }
        
        public Form1()
        {
            this.InitializeComponent();
            //Text = (('T' + 'A') % 8).ToString();//5 var
            
            FormBorderStyle = FormBorderStyle.Sizable;
            SizeGripStyle = SizeGripStyle.Hide;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColorTranslator.FromHtml("#c3f5ff");
            this.MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Size.Width /2, Screen.PrimaryScreen.WorkingArea.Size.Height/2);
            KeyPreview = true;
            KeyDown += new KeyEventHandler(Form1_KeyDown);

            moveTimer.Tick += new EventHandler(MoveTimerTickHandler);
            traceTimer.Tick += new EventHandler(TraceTimerTickHandler);

            Size = new Size(Screen.PrimaryScreen.WorkingArea.Size.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
            ButtonDefaultSize = new Size(400, Screen.PrimaryScreen.WorkingArea.Height / 11);
            Size size = ButtonDefaultSize;

            dotsButton.Size = size;
            paramsButton.Size = size;
            movePaintingButton.Size = size;
            clearButton.Size = size;
            curveButton.Size = size;
            polygonButton.Size = size;
            beizerButton.Size = size;
            filledCurveButton.Size = size;
            traceButton.Size = size;

            ButtonDefaultLocation = new Point(dotsButton.Location.X,
                                              Screen.PrimaryScreen.WorkingArea.Height / 9 -
                                              Screen.PrimaryScreen.WorkingArea.Height / 10);

            dotsButton.Location = new Point(ButtonDefaultLocation.X, 
                                            ButtonDefaultLocation.Y);
            
            paramsButton.Location = MakeButtonLocation(1, 2);
            movePaintingButton.Location = MakeButtonLocation(2, 3);
            clearButton.Location = MakeButtonLocation(3, 4);
            curveButton.Location = MakeButtonLocation(4, 5);
            polygonButton.Location = MakeButtonLocation(5, 6);
            beizerButton.Location = MakeButtonLocation(6, 7);
            filledCurveButton.Location = MakeButtonLocation(7, 8);
            traceButton.Location = MakeButtonLocation(8, 9);
            //PictureBox1 pictureBox1 = new PictureBox1();
            //pictureBox1.DoubleBufferedPicture = true;
            //paintingField.Dou
            //paintingField.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value);
            //paintingField.CreateControl();
            
            PaintFieldDefaultLocation = new Point(ButtonDefaultLocation.X +
                                             dotsButton.Width +
                                             Screen.PrimaryScreen.WorkingArea.Height / 9 -
                                             Screen.PrimaryScreen.WorkingArea.Height / 10,
                                             dotsButton.Location.Y + dotsButton.Height / 2);
            PaintFieldDefaultSize = new Size(Screen.PrimaryScreen.WorkingArea.Width -
                                        paintingField.Location.X -
                                        50 * (Screen.PrimaryScreen.WorkingArea.Height / 9 -
                                        Screen.PrimaryScreen.WorkingArea.Height / 10),
                                        filledCurveButton.Location.Y);
            paintingField.Location = PaintFieldDefaultLocation;
            paintingField.Size = PaintFieldDefaultSize;

            dotsButton.BackColor = ColorTranslator.FromHtml("#C3F5FF");
            paramsButton.BackColor = ColorTranslator.FromHtml("#C3F5FF");
            movePaintingButton.BackColor = ColorTranslator.FromHtml("#C3F5FF");
            clearButton.BackColor = ColorTranslator.FromHtml("#C3F5FF");
            curveButton.BackColor = ColorTranslator.FromHtml("#C3F5FF");
            polygonButton.BackColor = ColorTranslator.FromHtml("#C3F5FF");
            beizerButton.BackColor = ColorTranslator.FromHtml("#C3F5FF");
            filledCurveButton.BackColor = ColorTranslator.FromHtml("#C3F5FF");
            traceButton.BackColor = ColorTranslator.FromHtml("#C3F5FF");

            dotsButton.ForeColor = ColorTranslator.FromHtml("#1A9CB6");
            paramsButton.ForeColor = ColorTranslator.FromHtml("#1A9CB6");
            movePaintingButton.ForeColor = ColorTranslator.FromHtml("#1A9CB6");
            clearButton.ForeColor = ColorTranslator.FromHtml("#1A9CB6");
            curveButton.ForeColor = ColorTranslator.FromHtml("#1A9CB6");
            polygonButton.ForeColor = ColorTranslator.FromHtml("#1A9CB6");
            beizerButton.ForeColor = ColorTranslator.FromHtml("#1A9CB6");
            filledCurveButton.ForeColor = ColorTranslator.FromHtml("#1A9CB6");
            traceButton.ForeColor = ColorTranslator.FromHtml("#1A9CB6");

            dotsButton.Text = "Точки";
            paramsButton.Text = "Параметры";
            movePaintingButton.Text = "Движение";
            clearButton.Text = "Очистить";
            curveButton.Text = "Кривая";
            polygonButton.Text = "Ломанная";
            beizerButton.Text = "Бейзеры";
            filledCurveButton.Text = "Закрашенная";
            traceButton.Text = "След";

            dotsButton.Font = new Font("Ermilov", 20);
            paramsButton.Font = new Font("Ermilov", 20);
            movePaintingButton.Font = new Font("Ermilov", 20);
            clearButton.Font = new Font("Ermilov", 20);
            curveButton.Font = new Font("Ermilov", 20);
            polygonButton.Font = new Font("Ermilov", 20);
            beizerButton.Font = new Font("Ermilov", 20);
            filledCurveButton.Font = new Font("Ermilov", 20);
            traceButton.Font = new Font("Ermilov", 20);
            DoubleBuffered = true;

            dotsButton.Enabled = true;
            paramsButton.Enabled = true;
            movePaintingButton.Enabled = true;
            clearButton.Enabled = false;
            curveButton.Enabled = false;
            traceButton.Enabled = false;
            filledCurveButton.Enabled = false;
            polygonButton.Enabled = false;
            beizerButton.Enabled = false;
        }


        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            dotsButton.Size = new Size(ButtonDefaultSize.Width * this.Width / Screen.PrimaryScreen.WorkingArea.Width, 
                                       ButtonDefaultSize.Height* this.Height / Screen.PrimaryScreen.WorkingArea.Height);
            paramsButton.Size = new Size(ButtonDefaultSize.Width * this.Width / Screen.PrimaryScreen.WorkingArea.Width,
                                       ButtonDefaultSize.Height * this.Height / Screen.PrimaryScreen.WorkingArea.Height);
            movePaintingButton.Size = new Size(ButtonDefaultSize.Width * this.Width / Screen.PrimaryScreen.WorkingArea.Width,
                                       ButtonDefaultSize.Height * this.Height / Screen.PrimaryScreen.WorkingArea.Height);
            clearButton.Size = new Size(ButtonDefaultSize.Width * this.Width / Screen.PrimaryScreen.WorkingArea.Width,
                                       ButtonDefaultSize.Height * this.Height / Screen.PrimaryScreen.WorkingArea.Height);
            curveButton.Size = new Size(ButtonDefaultSize.Width * this.Width / Screen.PrimaryScreen.WorkingArea.Width,
                                       ButtonDefaultSize.Height * this.Height / Screen.PrimaryScreen.WorkingArea.Height);
            polygonButton.Size = new Size(ButtonDefaultSize.Width * this.Width / Screen.PrimaryScreen.WorkingArea.Width,
                                       ButtonDefaultSize.Height * this.Height / Screen.PrimaryScreen.WorkingArea.Height);
            beizerButton.Size = new Size(ButtonDefaultSize.Width * this.Width / Screen.PrimaryScreen.WorkingArea.Width,
                                       ButtonDefaultSize.Height * this.Height / Screen.PrimaryScreen.WorkingArea.Height);
            filledCurveButton.Size = new Size(ButtonDefaultSize.Width * this.Width / Screen.PrimaryScreen.WorkingArea.Width,
                                       ButtonDefaultSize.Height * this.Height / Screen.PrimaryScreen.WorkingArea.Height);
            traceButton.Size = new Size(ButtonDefaultSize.Width * this.Width / Screen.PrimaryScreen.WorkingArea.Width,
                                       ButtonDefaultSize.Height * this.Height / Screen.PrimaryScreen.WorkingArea.Height);

            dotsButton.Location = new Point(ButtonDefaultLocation.X* this.Width / Screen.PrimaryScreen.WorkingArea.Width,
                                            ButtonDefaultLocation.Y * this.Height / Screen.PrimaryScreen.WorkingArea.Height);
            Point[] temp = new Point[7];
            for (int i = 0; i < 7; i++)
            {
                temp[i] = MakeButtonLocation(i + 1, i + 2);
            }
            paramsButton.Location = new Point(temp[0].X* 
                                         this.Width / Screen.PrimaryScreen.WorkingArea.Width,
                                         temp[0].Y * 
                                         this.Height / Screen.PrimaryScreen.WorkingArea.Height);
            movePaintingButton.Location = new Point(temp[1].X *
                                         this.Width / Screen.PrimaryScreen.WorkingArea.Width,
                                         temp[1].Y *
                                         this.Height / Screen.PrimaryScreen.WorkingArea.Height);
            clearButton.Location = new Point(temp[2].X *
                                         this.Width / Screen.PrimaryScreen.WorkingArea.Width,
                                         temp[2].Y *
                                         this.Height / Screen.PrimaryScreen.WorkingArea.Height);
            curveButton.Location = new Point(temp[3].X *
                                         this.Width / Screen.PrimaryScreen.WorkingArea.Width,
                                         temp[3].Y *
                                         this.Height / Screen.PrimaryScreen.WorkingArea.Height);
            polygonButton.Location = new Point(temp[4].X *
                                         this.Width / Screen.PrimaryScreen.WorkingArea.Width,
                                         temp[4].Y *
                                         this.Height / Screen.PrimaryScreen.WorkingArea.Height);
            beizerButton.Location = new Point(temp[5].X *
                                         this.Width / Screen.PrimaryScreen.WorkingArea.Width,
                                         temp[5].Y *
                                         this.Height / Screen.PrimaryScreen.WorkingArea.Height);
            filledCurveButton.Location = new Point(temp[6].X *
                                         this.Width / Screen.PrimaryScreen.WorkingArea.Width,
                                         temp[6].Y *
                                         this.Height / Screen.PrimaryScreen.WorkingArea.Height);
            traceButton.Location = new Point(temp[6].X *
                                         this.Width / Screen.PrimaryScreen.WorkingArea.Width,
                                         temp[6].Y *
                                         this.Height / Screen.PrimaryScreen.WorkingArea.Height);

            paintingField.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width -
                                        paintingField.Location.X -
                                        50 * (Screen.PrimaryScreen.WorkingArea.Height / 9 -
                                        Screen.PrimaryScreen.WorkingArea.Height / 10),
                                        filledCurveButton.Location.Y);
            paintingField.Location = new Point(ButtonDefaultLocation.X +
                                             dotsButton.Width +
                                             Screen.PrimaryScreen.WorkingArea.Height / 9 -
                                             Screen.PrimaryScreen.WorkingArea.Height / 10,
                                             dotsButton.Location.Y + dotsButton.Height / 2);
        }
        //apply
        //
        public Point MakeButtonLocation(int buttonNumberMinus1, int buttonNumberMinus2)
        {
            return new Point(ButtonDefaultLocation.X,
                       dotsButton.Height * buttonNumberMinus1 +
                       (Screen.PrimaryScreen.WorkingArea.Height / 9 -
                       Screen.PrimaryScreen.WorkingArea.Height / 10) * 
                       buttonNumberMinus2);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (points.Length!=0) 
            {
                Graphics g = paintingField.CreateGraphics();
                Pen pDots = new Pen(color: ColorTranslator.FromHtml("#1A9CB6"), width: PaintPenSize);
                Pen pLine = new Pen(color: ColorTranslator.FromHtml("#1A9CB6"), width: PaintLineSize);
                Brush brushDots = new SolidBrush(color: ColorTranslator.FromHtml("#1A9CB6"));
                Brush brushFilled = new SolidBrush(color: ColorTranslator.FromHtml("#23cbff"));
                for (int i = 0; i < points.Length; i++)
                {
                    DrawDot(g, pDots, brushDots, points[i]);
                }                
                if (BeziersDone)
                {
                    try
                    {
                        g.DrawBeziers(pLine, points);
                    }
                    catch (Exception)
                    { }   
                }
                if (CurveDone)
                {
                    try
                    {
                        g.DrawClosedCurve(pLine, points);
                    }
                    catch (Exception)
                    { }
                }
                if (CurveFilledDone)
                {

                    try
                    {
                        g.FillClosedCurve(brushFilled, points);
                        g.DrawClosedCurve(pLine, points);
                    }
                    catch (Exception)
                    { }
                }
                if (PolygonDone)
                {
                    try
                    {
                        g.DrawPolygon(pLine, points);
                    }
                    catch (Exception)
                    { }
                }
            }
        }

        private void MovePaintingButton_Click(object sender, EventArgs e)
        {
            Graphics graphics = movePaintingButton.CreateGraphics();
            DrawPressedBorder(graphics, movePaintingButton);
            _movingEnabled = !_movingEnabled;
            if (_movingEnabled)
            {
                moveTimer.Interval = 5;
                moveTimer.Start();
            }

            else
            {
                Refresh();
                moveTimer.Stop();
            }
        }

        private void TraceButton_Click(object sender, EventArgs e)
        {
            Graphics graphics = traceButton.CreateGraphics();
            DrawPressedBorder(graphics, traceButton);
            _movingEnabled = !_movingEnabled;
            if (_movingEnabled)
            {
                traceTimer.Interval = 5;
                traceTimer.Start();
            }

            else
            {
                Refresh();
                traceTimer.Stop();
            }
        }

        
    }
}
