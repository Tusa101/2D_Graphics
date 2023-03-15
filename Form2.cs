using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_Graphics
{
    public partial class Form2 : Form
    {
        private static bool _applyDone = false;
        private static int _prevTrackBar1Value = 4;
        private static int _prevTrackBar2Value = 4;
        private static int PrevTrackBar1Value
        {
            get { return _prevTrackBar1Value; }
            set { _prevTrackBar1Value = value; }
        }
        private static int PrevTrackBar2Value
        {
            get { return _prevTrackBar2Value; }
            set { _prevTrackBar2Value = value; }
        }
        public Form2()
        { 
            StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            //FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(370, 180);
            Size = new Size(trackBar1.Width + label1.Width, 
                            label1.Height*3 + trackBar1.Height*3);
            BackColor = ColorTranslator.FromHtml("#c3f5ff");
            ForeColor = ColorTranslator.FromHtml("#1A9CB6");
            MinimizeBox = false;
            MaximizeBox = false;

            trackBar1.Width = MinimumSize.Width - 30;
            trackBar1.Value = 0;
            trackBar1.LargeChange = 2;
            trackBar1.TickFrequency = 2;
            trackBar1.Minimum = 4; 
            trackBar1.Maximum = 16;
            trackBar1.Anchor = AnchorStyles.None;
            trackBar1.Location = new Point(this.Width / 2 - trackBar1.Width / 2 - 10,
                                           (this.Height / 4 - trackBar1.Height / 2));
            label1.Width = label1.Text.Length*12;
            label1.Text = "Толщина кривой";
            label1.Font = new Font("Ermilov", 12);
            label1.Anchor = AnchorStyles.None;
            label1.Location = new Point(trackBar1.Location.X, 
                                        trackBar1.Location.Y - label1.Height);
            label2.Width = label2.Text.Length * 12;
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Ermilov", 12);
            label2.Location = new Point(trackBar1.Location.X + trackBar1.Width - label2.Width,
                                        trackBar1.Location.Y - label2.Height);
            trackBar2.Width = MinimumSize.Width - 30;
            trackBar2.Value = 0;
            trackBar2.LargeChange = 2;
            trackBar2.TickFrequency = 2;
            trackBar2.Minimum = 4;
            trackBar2.Maximum = 16;
            trackBar2.Anchor = AnchorStyles.None;
            trackBar2.Location = new Point(trackBar1.Location.X, 
                                           trackBar1.Location.Y + trackBar1.Height + label3.Height);
            label3.Width = label3.Text.Length * 12;
            label3.Text = "Радиус точки";
            label3.Font = new Font("Ermilov", 12);
            label3.Anchor = AnchorStyles.None;
            label3.Location = new Point(trackBar2.Location.X, trackBar2.Location.Y - label3.Height);
            label4.Width = label4.Text.Length * 12;
            label4.Font = new Font("Ermilov", 12);
            label4.Anchor = AnchorStyles.None;
            label4.Location = new Point(trackBar2.Location.X + trackBar2.Width - label4.Width, 
                                        trackBar2.Location.Y - label4.Height);
            applyButton.Enabled = false;
            applyButton.Location = new Point(trackBar2.Location.X + trackBar2.Width - applyButton.Width,
                                        trackBar2.Location.Y + applyButton.Height);
            applyButton.Anchor = AnchorStyles.None;
            applyButton.Font = new Font("Ermilov", 12);
            applyButton.Text = "Применить";

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            trackBar1.Value = PrevTrackBar1Value;
            trackBar2.Value = PrevTrackBar2Value;
            label2.Text = String.Format("Текущее значение: {0}", PrevTrackBar1Value);
            label4.Text = String.Format("Текущее значение: {0}", PrevTrackBar2Value);
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
            label2.Text = String.Format("Текущее значение: {0}", trackBar1.Value);
            
            (this.Owner as Form1).PaintLineSize = trackBar1.Value;
            (this.Owner as Form1).Refresh();

        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
            label4.Text = String.Format("Текущее значение: {0}", trackBar2.Value);
            (this.Owner as Form1).PaintPenSize = trackBar2.Value;
            
            (this.Owner as Form1).Refresh();

        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            _applyDone = true;

            PrevTrackBar2Value = trackBar2.Value;
            (this.Owner as Form1).PaintPenSize = trackBar2.Value;
            
            PrevTrackBar1Value = trackBar1.Value;
            (this.Owner as Form1).PaintLineSize = trackBar1.Value;
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_applyDone)
            {
                (this.Owner as Form1).PaintPenSize = PrevTrackBar1Value;
                (this.Owner as Form1).PaintLineSize = PrevTrackBar2Value;
                (this.Owner as Form1).Refresh();
            }
            
        }
    }
}
