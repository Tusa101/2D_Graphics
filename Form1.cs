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
        private static bool _beziersDone = false;
        public bool BeziersDone
        {
            get { return _beziersDone; }
            set { _beziersDone = value;}
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
            this.Size = new Size(1280, 720);
            FormBorderStyle = FormBorderStyle.Fixed3D;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColorTranslator.FromHtml("#c3f5ff");
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MinimumSize = new Size(600, 600);
            this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            

            Size size = new Size(dotsButton.Width * 1280 / 1920, dotsButton.Height * 600 / 1080);


            dotsButton.Size = size;
            button2.Size = size;
            button3.Size = size;
            button4.Size = size;
            button5.Size = size;
            button6.Size = size;
            button7.Size = size;
            button8.Size = size;

            dotsButton.Location = new Point(dotsButton.Location.X, dotsButton.Location.Y * this.Height / 1080 - 10);
            button2.Location = new Point(button2.Location.X, button2.Location.Y * this.Height / 1080 - 10);
            button3.Location = new Point(button3.Location.X, button3.Location.Y * this.Height / 1080 - 10);
            button4.Location = new Point(button4.Location.X, button4.Location.Y * this.Height / 1080 - 10);
            button5.Location = new Point(button5.Location.X, button5.Location.Y * this.Height / 1080 - 10);
            button6.Location = new Point(button6.Location.X, button6.Location.Y * this.Height / 1080 - 10);
            button7.Location = new Point(button7.Location.X, button7.Location.Y * this.Height / 1080 - 10);
            button8.Location = new Point(button8.Location.X, button8.Location.Y * this.Height / 1080 - 10);
            pictureBox1.Location = new Point(pictureBox1.Location.X * 1280 / 1920, dotsButton.Location.Y + dotsButton.Height / 2);
            pictureBox1.Size = new Size(pictureBox1.Width * 1280 / 1920, button8.Location.Y);
            dotsButton.BackColor = ColorTranslator.FromHtml("#C3F5FF");
            button2.BackColor = ColorTranslator.FromHtml("#C3F5FF");
            button3.BackColor = ColorTranslator.FromHtml("#C3F5FF");
            button4.BackColor = ColorTranslator.FromHtml("#C3F5FF");
            button5.BackColor = ColorTranslator.FromHtml("#C3F5FF");
            button6.BackColor = ColorTranslator.FromHtml("#C3F5FF");
            button7.BackColor = ColorTranslator.FromHtml("#C3F5FF");
            button8.BackColor = ColorTranslator.FromHtml("#C3F5FF");

            dotsButton.ForeColor = ColorTranslator.FromHtml("#1A9CB6");
            button2.ForeColor = ColorTranslator.FromHtml("#1A9CB6");
            button3.ForeColor = ColorTranslator.FromHtml("#1A9CB6");
            button4.ForeColor = ColorTranslator.FromHtml("#1A9CB6");
            button5.ForeColor = ColorTranslator.FromHtml("#1A9CB6");
            button6.ForeColor = ColorTranslator.FromHtml("#1A9CB6");
            button7.ForeColor = ColorTranslator.FromHtml("#1A9CB6");
            button8.ForeColor = ColorTranslator.FromHtml("#1A9CB6");

            dotsButton.Text = "Точки";
            button2.Text = "Параметры";
            button3.Text = "Движение";
            button4.Text = "Очистить";
            button5.Text = "Кривая";
            button6.Text = "Ломанная";
            button7.Text = "Бейзеры";
            button8.Text = "Закрашенная";

            dotsButton.Font = new Font("Ermilov", 20);
            button2.Font = new Font("Ermilov", 20);
            button3.Font = new Font("Ermilov", 20);
            button4.Font = new Font("Ermilov", 20);
            button5.Font = new Font("Ermilov", 20);
            button6.Font = new Font("Ermilov", 20);
            button7.Font = new Font("Ermilov", 20);
            button8.Font = new Font("Ermilov", 20);

        }

        
    }
}
