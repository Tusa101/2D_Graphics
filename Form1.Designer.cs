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
            this.paramsButton = new System.Windows.Forms.Button();
            this.movePaintingButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.curveButton = new System.Windows.Forms.Button();
            this.polygonButton = new System.Windows.Forms.Button();
            this.beizerButton = new System.Windows.Forms.Button();
            this.filledCurveButton = new System.Windows.Forms.Button();
            this.paintingField = new System.Windows.Forms.PictureBox();
            this.traceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paintingField)).BeginInit();
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
            // paramsButton
            // 
            this.paramsButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.paramsButton.Font = new System.Drawing.Font("Ermilov", 40F);
            this.paramsButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.paramsButton.Location = new System.Drawing.Point(40, 147);
            this.paramsButton.Name = "paramsButton";
            this.paramsButton.Size = new System.Drawing.Size(400, 110);
            this.paramsButton.TabIndex = 1;
            this.paramsButton.Text = "Параметры";
            this.paramsButton.UseVisualStyleBackColor = false;
            this.paramsButton.Click += new System.EventHandler(this.Button2_Click);
            this.paramsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.Button2_Paint);
            // 
            // movePaintingButton
            // 
            this.movePaintingButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.movePaintingButton.Font = new System.Drawing.Font("Ermilov", 40F);
            this.movePaintingButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.movePaintingButton.Location = new System.Drawing.Point(40, 274);
            this.movePaintingButton.Name = "movePaintingButton";
            this.movePaintingButton.Size = new System.Drawing.Size(400, 110);
            this.movePaintingButton.TabIndex = 2;
            this.movePaintingButton.Text = "Движение";
            this.movePaintingButton.UseVisualStyleBackColor = false;
            this.movePaintingButton.Paint += new System.Windows.Forms.PaintEventHandler(this.Button3_Paint);
            this.movePaintingButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MovePaintingButton_MouseClick);
            this.movePaintingButton.MouseLeave += new System.EventHandler(this.MovePaintingButton_MouseLeave);
            this.movePaintingButton.MouseHover += new System.EventHandler(this.MovePaintingButton_MouseHover);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clearButton.Font = new System.Drawing.Font("Ermilov", 40F);
            this.clearButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.clearButton.Location = new System.Drawing.Point(40, 402);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(400, 110);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.Clear_Click);
            this.clearButton.Paint += new System.Windows.Forms.PaintEventHandler(this.Button4_Paint);
            // 
            // curveButton
            // 
            this.curveButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.curveButton.Font = new System.Drawing.Font("Ermilov", 40F);
            this.curveButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.curveButton.Location = new System.Drawing.Point(40, 529);
            this.curveButton.Name = "curveButton";
            this.curveButton.Size = new System.Drawing.Size(400, 110);
            this.curveButton.TabIndex = 4;
            this.curveButton.Text = "Кривая";
            this.curveButton.UseVisualStyleBackColor = false;
            this.curveButton.Click += new System.EventHandler(this.Curve_Click);
            this.curveButton.Paint += new System.Windows.Forms.PaintEventHandler(this.Button5_Paint);
            // 
            // polygonButton
            // 
            this.polygonButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.polygonButton.Font = new System.Drawing.Font("Ermilov", 40F);
            this.polygonButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.polygonButton.Location = new System.Drawing.Point(40, 656);
            this.polygonButton.Name = "polygonButton";
            this.polygonButton.Size = new System.Drawing.Size(400, 110);
            this.polygonButton.TabIndex = 5;
            this.polygonButton.Text = "Ломанная";
            this.polygonButton.UseVisualStyleBackColor = false;
            this.polygonButton.Click += new System.EventHandler(this.Polygon_Click);
            this.polygonButton.Paint += new System.Windows.Forms.PaintEventHandler(this.Button6_Paint);
            // 
            // beizerButton
            // 
            this.beizerButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.beizerButton.Font = new System.Drawing.Font("Ermilov", 40F);
            this.beizerButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.beizerButton.Location = new System.Drawing.Point(40, 783);
            this.beizerButton.Name = "beizerButton";
            this.beizerButton.Size = new System.Drawing.Size(400, 110);
            this.beizerButton.TabIndex = 6;
            this.beizerButton.Text = "Бейзеры";
            this.beizerButton.UseVisualStyleBackColor = false;
            this.beizerButton.Click += new System.EventHandler(this.Beziers_Click);
            this.beizerButton.Paint += new System.Windows.Forms.PaintEventHandler(this.Button7_Paint);
            // 
            // filledCurveButton
            // 
            this.filledCurveButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.filledCurveButton.Font = new System.Drawing.Font("Ermilov", 40F);
            this.filledCurveButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.filledCurveButton.Location = new System.Drawing.Point(40, 910);
            this.filledCurveButton.Name = "filledCurveButton";
            this.filledCurveButton.Size = new System.Drawing.Size(400, 110);
            this.filledCurveButton.TabIndex = 7;
            this.filledCurveButton.Text = "Закрашенная";
            this.filledCurveButton.UseVisualStyleBackColor = false;
            this.filledCurveButton.Click += new System.EventHandler(this.FillCurve_Click);
            this.filledCurveButton.Paint += new System.Windows.Forms.PaintEventHandler(this.Button8_Paint);
            // 
            // paintingField
            // 
            this.paintingField.Image = ((System.Drawing.Image)(resources.GetObject("paintingField.Image")));
            this.paintingField.Location = new System.Drawing.Point(504, 20);
            this.paintingField.Name = "paintingField";
            this.paintingField.Size = new System.Drawing.Size(1376, 1000);
            this.paintingField.TabIndex = 8;
            this.paintingField.TabStop = false;
            this.paintingField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            this.paintingField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintingField_MouseDown);
            this.paintingField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintingField_MouseMove);
            this.paintingField.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintingField_MouseUp);
            // 
            // traceButton
            // 
            this.traceButton.Font = new System.Drawing.Font("Ermilov", 40F);
            this.traceButton.Location = new System.Drawing.Point(40, 1000);
            this.traceButton.Name = "traceButton";
            this.traceButton.Size = new System.Drawing.Size(400, 110);
            this.traceButton.TabIndex = 9;
            this.traceButton.Text = "След";
            this.traceButton.UseVisualStyleBackColor = true;
            this.traceButton.Paint += new System.Windows.Forms.PaintEventHandler(this.TraceButton_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.traceButton);
            this.Controls.Add(this.paintingField);
            this.Controls.Add(this.filledCurveButton);
            this.Controls.Add(this.beizerButton);
            this.Controls.Add(this.polygonButton);
            this.Controls.Add(this.curveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.movePaintingButton);
            this.Controls.Add(this.paramsButton);
            this.Controls.Add(this.dotsButton);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Ermilov", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.paintingField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dotsButton;
        private System.Windows.Forms.Button paramsButton;
        private System.Windows.Forms.Button movePaintingButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button curveButton;
        private System.Windows.Forms.Button polygonButton;
        private System.Windows.Forms.Button beizerButton;
        private System.Windows.Forms.Button filledCurveButton;
        private System.Windows.Forms.PictureBox paintingField;
        private System.Windows.Forms.Button traceButton;
    }
}

