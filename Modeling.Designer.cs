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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeedLimitFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeedLimitSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeedLimitThird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeedLimitFourth)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(232, 390);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(462, 390);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(344, 390);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 2;
            this.buttonPause.Text = "Пауза";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(63, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(652, 310);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(84, 390);
            this.buttonSet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 4;
            this.buttonSet.Text = "Параметры";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // pictureSpeedLimitFirst
            // 
            this.pictureSpeedLimitFirst.Location = new System.Drawing.Point(63, 3);
            this.pictureSpeedLimitFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureSpeedLimitFirst.Name = "pictureSpeedLimitFirst";
            this.pictureSpeedLimitFirst.Size = new System.Drawing.Size(52, 41);
            this.pictureSpeedLimitFirst.TabIndex = 5;
            this.pictureSpeedLimitFirst.TabStop = false;
            this.pictureSpeedLimitFirst.Click += new System.EventHandler(this.pictureSpeedLimitFirst_Click);
            this.pictureSpeedLimitFirst.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureSpeedLimitFirstPaint);
            // 
            // pictureSpeedLimitSecond
            // 
            this.pictureSpeedLimitSecond.Location = new System.Drawing.Point(119, 3);
            this.pictureSpeedLimitSecond.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureSpeedLimitSecond.Name = "pictureSpeedLimitSecond";
            this.pictureSpeedLimitSecond.Size = new System.Drawing.Size(52, 41);
            this.pictureSpeedLimitSecond.TabIndex = 5;
            this.pictureSpeedLimitSecond.TabStop = false;
            this.pictureSpeedLimitSecond.Click += new System.EventHandler(this.pictureSpeedLimitSecond_Click);
            this.pictureSpeedLimitSecond.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureSpeedLimitSecondPaint);
            // 
            // pictureSpeedLimitThird
            // 
            this.pictureSpeedLimitThird.Location = new System.Drawing.Point(176, 3);
            this.pictureSpeedLimitThird.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureSpeedLimitThird.Name = "pictureSpeedLimitThird";
            this.pictureSpeedLimitThird.Size = new System.Drawing.Size(52, 41);
            this.pictureSpeedLimitThird.TabIndex = 5;
            this.pictureSpeedLimitThird.TabStop = false;
            this.pictureSpeedLimitThird.Click += new System.EventHandler(this.pictureSpeedLimitThird_Click);
            this.pictureSpeedLimitThird.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureSpeedLimitThirdPaint);
            // 
            // pictureSpeedLimitFirstFourth
            // 
            this.pictureSpeedLimitFourth.Location = new System.Drawing.Point(232, 3);
            this.pictureSpeedLimitFourth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureSpeedLimitFourth.Name = "pictureSpeedLimitFirstFourth";
            this.pictureSpeedLimitFourth.Size = new System.Drawing.Size(52, 41);
            this.pictureSpeedLimitFourth.TabIndex = 5;
            this.pictureSpeedLimitFourth.TabStop = false;
            this.pictureSpeedLimitFourth.Click += new System.EventHandler(this.pictureSpeedLimitFirstFourth_Click);
            this.pictureSpeedLimitFourth.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureSpeedLimitFourthPaint);
            // 
            // Modeling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureSpeedLimitFourth);
            this.Controls.Add(this.pictureSpeedLimitThird);
            this.Controls.Add(this.pictureSpeedLimitSecond);
            this.Controls.Add(this.pictureSpeedLimitFirst);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Name = "Modeling";
            this.Text = "Модель транспортного потока";
            this.Load += new System.EventHandler(this.Modeling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeedLimitFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeedLimitSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeedLimitThird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeedLimitFourth)).EndInit();
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
    }
}