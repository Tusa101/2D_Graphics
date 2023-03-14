namespace _2D_Graphics
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dotsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dotsButton
            // 
            this.dotsButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dotsButton.Font = new System.Drawing.Font("Ermilov", 40F);
            this.dotsButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.dotsButton.Location = new System.Drawing.Point(40, 20);
            this.dotsButton.Name = "dotsButton";
            this.dotsButton.Size = new System.Drawing.Size(400, 110);
            this.dotsButton.TabIndex = 0;
            this.dotsButton.Text = "Точки";
            this.dotsButton.UseVisualStyleBackColor = false;
            this.dotsButton.Click += new System.EventHandler(this.Button1_Click);
            this.dotsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.DotsButton_Paint);
            this.dotsButton.MouseLeave += new System.EventHandler(this.DotsButton_MouseLeave);
            this.dotsButton.MouseHover += new System.EventHandler(this.DotsButton_MouseHover);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Font = new System.Drawing.Font("Ermilov", 40F);
            this.button2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Location = new System.Drawing.Point(40, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(400, 110);
            this.button2.TabIndex = 1;
            this.button2.Text = "Параметры";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            this.button2.Paint += new System.Windows.Forms.PaintEventHandler(this.Button2_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Font = new System.Drawing.Font("Ermilov", 40F);
            this.button3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Location = new System.Drawing.Point(40, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(400, 110);
            this.button3.TabIndex = 2;
            this.button3.Text = "Движение";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Paint += new System.Windows.Forms.PaintEventHandler(this.Button3_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Font = new System.Drawing.Font("Ermilov", 40F);
            this.button4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Location = new System.Drawing.Point(40, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(400, 110);
            this.button4.TabIndex = 3;
            this.button4.Text = "Очистить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Clear_Click);
            this.button4.Paint += new System.Windows.Forms.PaintEventHandler(this.Button4_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Font = new System.Drawing.Font("Ermilov", 40F);
            this.button5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button5.Location = new System.Drawing.Point(40, 529);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(400, 110);
            this.button5.TabIndex = 4;
            this.button5.Text = "Кривая";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Curve_Click);
            this.button5.Paint += new System.Windows.Forms.PaintEventHandler(this.Button5_Paint);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Font = new System.Drawing.Font("Ermilov", 40F);
            this.button6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button6.Location = new System.Drawing.Point(40, 656);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(400, 110);
            this.button6.TabIndex = 5;
            this.button6.Text = "Ломанная";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Polygon_Click);
            this.button6.Paint += new System.Windows.Forms.PaintEventHandler(this.Button6_Paint);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Font = new System.Drawing.Font("Ermilov", 40F);
            this.button7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button7.Location = new System.Drawing.Point(40, 783);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(400, 110);
            this.button7.TabIndex = 6;
            this.button7.Text = "Бейзеры";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Beziers_Click);
            this.button7.Paint += new System.Windows.Forms.PaintEventHandler(this.Button7_Paint);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button8.Font = new System.Drawing.Font("Ermilov", 40F);
            this.button8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button8.Location = new System.Drawing.Point(40, 910);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(400, 110);
            this.button8.TabIndex = 7;
            this.button8.Text = "Закрашенная";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.FillCurve_Click);
            this.button8.Paint += new System.Windows.Forms.PaintEventHandler(this.Button8_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(504, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1376, 1000);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dotsButton);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Ermilov", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dotsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

