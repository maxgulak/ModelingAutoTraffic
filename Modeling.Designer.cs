namespace ModelingAutoTraffic
{
    partial class Modeling
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modeling));
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.timerTrafficLight = new System.Windows.Forms.Timer(this.components);
            this.pictureSpeedLimitFirst = new System.Windows.Forms.PictureBox();
            this.pictureSpeedLimitSecond = new System.Windows.Forms.PictureBox();
            this.pictureSpeedLimitThird = new System.Windows.Forms.PictureBox();
            this.pictureSpeedLimitFourth = new System.Windows.Forms.PictureBox();
            this.timerSignum = new System.Windows.Forms.Timer(this.components);
            this.timerUpLigth = new System.Windows.Forms.Timer(this.components);
            this.timerDownLigth = new System.Windows.Forms.Timer(this.components);
            this.pictureSpeedLimitFifth = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeedLimitFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeedLimitSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeedLimitThird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeedLimitFourth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeedLimitFifth)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Image = ((System.Drawing.Image)(resources.GetObject("buttonStart.Image")));
            this.buttonStart.Location = new System.Drawing.Point(792, 15);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(43, 39);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Image = ((System.Drawing.Image)(resources.GetObject("buttonStop.Image")));
            this.buttonStop.Location = new System.Drawing.Point(893, 15);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(43, 39);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Image = ((System.Drawing.Image)(resources.GetObject("buttonPause.Image")));
            this.buttonPause.Location = new System.Drawing.Point(843, 15);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(43, 39);
            this.buttonPause.TabIndex = 2;
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(84, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(869, 382);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(517, 21);
            this.buttonSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(100, 28);
            this.buttonSet.TabIndex = 4;
            this.buttonSet.Text = "Параметры";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // pictureSpeedLimitFirst
            // 
            this.pictureSpeedLimitFirst.Location = new System.Drawing.Point(84, 4);
            this.pictureSpeedLimitFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureSpeedLimitFirst.Name = "pictureSpeedLimitFirst";
            this.pictureSpeedLimitFirst.Size = new System.Drawing.Size(60, 60);
            this.pictureSpeedLimitFirst.TabIndex = 5;
            this.pictureSpeedLimitFirst.TabStop = false;
            this.pictureSpeedLimitFirst.Click += new System.EventHandler(this.pictureSpeedLimitFirst_Click);
            this.pictureSpeedLimitFirst.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureSpeedLimitFirstPaint);
            // 
            // pictureSpeedLimitSecond
            // 
            this.pictureSpeedLimitSecond.Location = new System.Drawing.Point(150, 4);
            this.pictureSpeedLimitSecond.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureSpeedLimitSecond.Name = "pictureSpeedLimitSecond";
            this.pictureSpeedLimitSecond.Size = new System.Drawing.Size(60, 60);
            this.pictureSpeedLimitSecond.TabIndex = 5;
            this.pictureSpeedLimitSecond.TabStop = false;
            this.pictureSpeedLimitSecond.Click += new System.EventHandler(this.pictureSpeedLimitSecond_Click);
            this.pictureSpeedLimitSecond.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureSpeedLimitSecondPaint);
            // 
            // pictureSpeedLimitThird
            // 
            this.pictureSpeedLimitThird.Location = new System.Drawing.Point(216, 4);
            this.pictureSpeedLimitThird.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureSpeedLimitThird.Name = "pictureSpeedLimitThird";
            this.pictureSpeedLimitThird.Size = new System.Drawing.Size(60, 60);
            this.pictureSpeedLimitThird.TabIndex = 5;
            this.pictureSpeedLimitThird.TabStop = false;
            this.pictureSpeedLimitThird.Click += new System.EventHandler(this.pictureSpeedLimitThird_Click);
            this.pictureSpeedLimitThird.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureSpeedLimitThirdPaint);
            // 
            // pictureSpeedLimitFourth
            // 
            this.pictureSpeedLimitFourth.Location = new System.Drawing.Point(282, 4);
            this.pictureSpeedLimitFourth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureSpeedLimitFourth.Name = "pictureSpeedLimitFourth";
            this.pictureSpeedLimitFourth.Size = new System.Drawing.Size(60, 60);
            this.pictureSpeedLimitFourth.TabIndex = 5;
            this.pictureSpeedLimitFourth.TabStop = false;
            this.pictureSpeedLimitFourth.Click += new System.EventHandler(this.pictureSpeedLimitFirstFourth_Click);
            this.pictureSpeedLimitFourth.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureSpeedLimitFourthPaint);
            // 
            // pictureSpeedLimitFifth
            // 
            this.pictureSpeedLimitFifth.Location = new System.Drawing.Point(348, 4);
            this.pictureSpeedLimitFifth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureSpeedLimitFifth.Name = "pictureSpeedLimitFifth";
            this.pictureSpeedLimitFifth.Size = new System.Drawing.Size(60, 60);
            this.pictureSpeedLimitFifth.TabIndex = 6;
            this.pictureSpeedLimitFifth.TabStop = false;
            this.pictureSpeedLimitFifth.Click += new System.EventHandler(this.pictureSpeedLimitFirstFifth_Click);
            this.pictureSpeedLimitFifth.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureSpeedLimitFifthPaint);
            // 
            // Modeling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 492);
            this.Controls.Add(this.pictureSpeedLimitFifth);
            this.Controls.Add(this.pictureSpeedLimitFourth);
            this.Controls.Add(this.pictureSpeedLimitThird);
            this.Controls.Add(this.pictureSpeedLimitSecond);
            this.Controls.Add(this.pictureSpeedLimitFirst);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Modeling";
            this.Text = "Модель транспортного потока";
            this.Load += new System.EventHandler(this.Modeling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeedLimitFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeedLimitSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeedLimitThird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeedLimitFourth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeedLimitFifth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Timer timerTrafficLight;
        private System.Windows.Forms.PictureBox pictureSpeedLimitFirst;
        private System.Windows.Forms.PictureBox pictureSpeedLimitSecond;
        private System.Windows.Forms.PictureBox pictureSpeedLimitThird;
        private System.Windows.Forms.PictureBox pictureSpeedLimitFourth;
        private System.Windows.Forms.Timer timerSignum;
        private System.Windows.Forms.Timer timerUpLigth;
        private System.Windows.Forms.Timer timerDownLigth;
        private System.Windows.Forms.PictureBox pictureSpeedLimitFifth;
    }
}