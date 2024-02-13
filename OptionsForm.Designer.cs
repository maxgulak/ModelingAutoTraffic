namespace ModelingAutoTraffic
{
    partial class OptionsForm
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
            this.labelTypeSpeed = new System.Windows.Forms.Label();
            this.labelDet_Time = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxDispTime = new System.Windows.Forms.TextBox();
            this.labelLawTime = new System.Windows.Forms.Label();
            this.labelDispTime = new System.Windows.Forms.Label();
            this.labelMOTime = new System.Windows.Forms.Label();
            this.textBoxMOTime = new System.Windows.Forms.TextBox();
            this.lawRandomTime = new System.Windows.Forms.ComboBox();
            this.textBoxIntervalRTime = new System.Windows.Forms.TextBox();
            this.textBoxIntervalLTime = new System.Windows.Forms.TextBox();
            this.determinateNumberSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.menuSettings = new System.Windows.Forms.MenuStrip();
            this.lawRandomSpeed = new System.Windows.Forms.ComboBox();
            this.textBoxMOSpeed = new System.Windows.Forms.TextBox();
            this.labelMOSpeed = new System.Windows.Forms.Label();
            this.labelDispSpeed = new System.Windows.Forms.Label();
            this.labelLawSpeed = new System.Windows.Forms.Label();
            this.textBoxIntervalRSpeed = new System.Windows.Forms.TextBox();
            this.textBoxDispSpeed = new System.Windows.Forms.TextBox();
            this.textBoxIntervalLSpeed = new System.Windows.Forms.TextBox();
            this.textBoxIntensSpeed = new System.Windows.Forms.TextBox();
            this.labelSettingTime = new System.Windows.Forms.Label();
            this.labelSettingSpeed = new System.Windows.Forms.Label();
            this.labelIntervalLSpeed = new System.Windows.Forms.Label();
            this.labelIntensSpeed = new System.Windows.Forms.Label();
            this.labelIntervalRTime = new System.Windows.Forms.Label();
            this.labelIntensTime = new System.Windows.Forms.Label();
            this.labelIntervalLTime = new System.Windows.Forms.Label();
            this.labelTypeTime = new System.Windows.Forms.Label();
            this.textBoxIntensTime = new System.Windows.Forms.TextBox();
            this.comboBoxTypeSpeed = new System.Windows.Forms.ComboBox();
            this.labelRSpeed = new System.Windows.Forms.Label();
            this.comboBoxTypeTime = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.determinateNumberSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTypeSpeed
            // 
            this.labelTypeSpeed.AutoSize = true;
            this.labelTypeSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTypeSpeed.Location = new System.Drawing.Point(125, 53);
            this.labelTypeSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTypeSpeed.Name = "labelTypeSpeed";
            this.labelTypeSpeed.Size = new System.Drawing.Size(117, 25);
            this.labelTypeSpeed.TabIndex = 17;
            this.labelTypeSpeed.Text = "Вид потока";
            // 
            // labelDet_Time
            // 
            this.labelDet_Time.AutoSize = true;
            this.labelDet_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDet_Time.Location = new System.Drawing.Point(453, 188);
            this.labelDet_Time.Name = "labelDet_Time";
            this.labelDet_Time.Size = new System.Drawing.Size(339, 25);
            this.labelDet_Time.TabIndex = 23;
            this.labelDet_Time.Text = "Интервал появления автомобилей";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(571, 218);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(133, 22);
            this.numericUpDown1.TabIndex = 24;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(357, 326);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(153, 64);
            this.buttonOK.TabIndex = 26;
            this.buttonOK.Text = "Сохранить и выйти";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxDispTime
            // 
            this.textBoxDispTime.Location = new System.Drawing.Point(571, 293);
            this.textBoxDispTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDispTime.Name = "textBoxDispTime";
            this.textBoxDispTime.Size = new System.Drawing.Size(132, 22);
            this.textBoxDispTime.TabIndex = 22;
            // 
            // labelLawTime
            // 
            this.labelLawTime.AutoSize = true;
            this.labelLawTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLawTime.Location = new System.Drawing.Point(524, 122);
            this.labelLawTime.Name = "labelLawTime";
            this.labelLawTime.Size = new System.Drawing.Size(215, 25);
            this.labelLawTime.TabIndex = 27;
            this.labelLawTime.Text = "Закон распределения";
            // 
            // labelDispTime
            // 
            this.labelDispTime.AutoSize = true;
            this.labelDispTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDispTime.Location = new System.Drawing.Point(583, 268);
            this.labelDispTime.Name = "labelDispTime";
            this.labelDispTime.Size = new System.Drawing.Size(115, 25);
            this.labelDispTime.TabIndex = 28;
            this.labelDispTime.Text = "Дисперсия";
            // 
            // labelMOTime
            // 
            this.labelMOTime.AutoSize = true;
            this.labelMOTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMOTime.Location = new System.Drawing.Point(495, 188);
            this.labelMOTime.Name = "labelMOTime";
            this.labelMOTime.Size = new System.Drawing.Size(274, 25);
            this.labelMOTime.TabIndex = 29;
            this.labelMOTime.Text = "Математическое ожидание";
            // 
            // textBoxMOTime
            // 
            this.textBoxMOTime.Location = new System.Drawing.Point(571, 219);
            this.textBoxMOTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMOTime.Name = "textBoxMOTime";
            this.textBoxMOTime.Size = new System.Drawing.Size(132, 22);
            this.textBoxMOTime.TabIndex = 30;
            // 
            // lawRandomTime
            // 
            this.lawRandomTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lawRandomTime.FormattingEnabled = true;
            this.lawRandomTime.Location = new System.Drawing.Point(571, 149);
            this.lawRandomTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lawRandomTime.Name = "lawRandomTime";
            this.lawRandomTime.Size = new System.Drawing.Size(132, 24);
            this.lawRandomTime.TabIndex = 31;
            this.lawRandomTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxRand_SV_SelectedIndexChanged);
            // 
            // textBoxIntervalRTime
            // 
            this.textBoxIntervalRTime.Location = new System.Drawing.Point(571, 293);
            this.textBoxIntervalRTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIntervalRTime.Name = "textBoxIntervalRTime";
            this.textBoxIntervalRTime.Size = new System.Drawing.Size(132, 22);
            this.textBoxIntervalRTime.TabIndex = 22;
            // 
            // textBoxIntervalLTime
            // 
            this.textBoxIntervalLTime.Location = new System.Drawing.Point(571, 218);
            this.textBoxIntervalLTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIntervalLTime.Name = "textBoxIntervalLTime";
            this.textBoxIntervalLTime.Size = new System.Drawing.Size(132, 22);
            this.textBoxIntervalLTime.TabIndex = 22;
            // 
            // determinateNumberSpeed
            // 
            this.determinateNumberSpeed.InterceptArrowKeys = false;
            this.determinateNumberSpeed.Location = new System.Drawing.Point(125, 215);
            this.determinateNumberSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.determinateNumberSpeed.Maximum = (decimal)90;
            this.determinateNumberSpeed.Minimum = (decimal)30;
            this.determinateNumberSpeed.Name = "determinateNumberSpeed";
            this.determinateNumberSpeed.ReadOnly = true;
            this.determinateNumberSpeed.Size = new System.Drawing.Size(120, 22);
            this.determinateNumberSpeed.TabIndex = 24;
            this.determinateNumberSpeed.Value = (decimal)50;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeed.Location = new System.Drawing.Point(96, 188);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(170, 25);
            this.labelSpeed.TabIndex = 23;
            this.labelSpeed.Text = "Скорость машин";
            // 
            // menuSettings
            // 
            this.menuSettings.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuSettings.Location = new System.Drawing.Point(0, 0);
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuSettings.Size = new System.Drawing.Size(861, 24);
            this.menuSettings.TabIndex = 35;
            this.menuSettings.Text = "menuStrip1";
            // 
            // lawRandomSpeed
            // 
            this.lawRandomSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lawRandomSpeed.FormattingEnabled = true;
            this.lawRandomSpeed.Location = new System.Drawing.Point(121, 149);
            this.lawRandomSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lawRandomSpeed.Name = "lawRandomSpeed";
            this.lawRandomSpeed.Size = new System.Drawing.Size(132, 24);
            this.lawRandomSpeed.TabIndex = 31;
            this.lawRandomSpeed.SelectedIndexChanged += new System.EventHandler(this.lowRandomSpeed_SelectedIndexChanged);
            // 
            // textBoxMOSpeed
            // 
            this.textBoxMOSpeed.Location = new System.Drawing.Point(121, 219);
            this.textBoxMOSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMOSpeed.Name = "textBoxMOSpeed";
            this.textBoxMOSpeed.Size = new System.Drawing.Size(132, 22);
            this.textBoxMOSpeed.TabIndex = 30;
            // 
            // labelMOSpeed
            // 
            this.labelMOSpeed.AutoSize = true;
            this.labelMOSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMOSpeed.Location = new System.Drawing.Point(43, 191);
            this.labelMOSpeed.Name = "labelMOSpeed";
            this.labelMOSpeed.Size = new System.Drawing.Size(274, 25);
            this.labelMOSpeed.TabIndex = 29;
            this.labelMOSpeed.Text = "Математическое ожидание";
            // 
            // labelDispSpeed
            // 
            this.labelDispSpeed.AutoSize = true;
            this.labelDispSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDispSpeed.Location = new System.Drawing.Point(124, 268);
            this.labelDispSpeed.Name = "labelDispSpeed";
            this.labelDispSpeed.Size = new System.Drawing.Size(115, 25);
            this.labelDispSpeed.TabIndex = 28;
            this.labelDispSpeed.Text = "Дисперсия";
            // 
            // labelLawSpeed
            // 
            this.labelLawSpeed.AutoSize = true;
            this.labelLawSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLawSpeed.Location = new System.Drawing.Point(73, 122);
            this.labelLawSpeed.Name = "labelLawSpeed";
            this.labelLawSpeed.Size = new System.Drawing.Size(215, 25);
            this.labelLawSpeed.TabIndex = 27;
            this.labelLawSpeed.Text = "Закон распределения";
            // 
            // textBoxIntervalRSpeed
            // 
            this.textBoxIntervalRSpeed.Location = new System.Drawing.Point(121, 293);
            this.textBoxIntervalRSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIntervalRSpeed.Name = "textBoxIntervalRSpeed";
            this.textBoxIntervalRSpeed.Size = new System.Drawing.Size(132, 22);
            this.textBoxIntervalRSpeed.TabIndex = 22;
            // 
            // textBoxDispSpeed
            // 
            this.textBoxDispSpeed.Location = new System.Drawing.Point(121, 293);
            this.textBoxDispSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDispSpeed.Name = "textBoxDispSpeed";
            this.textBoxDispSpeed.Size = new System.Drawing.Size(132, 22);
            this.textBoxDispSpeed.TabIndex = 22;
            // 
            // textBoxIntervalLSpeed
            // 
            this.textBoxIntervalLSpeed.Location = new System.Drawing.Point(121, 219);
            this.textBoxIntervalLSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIntervalLSpeed.Name = "textBoxIntervalLSpeed";
            this.textBoxIntervalLSpeed.Size = new System.Drawing.Size(132, 22);
            this.textBoxIntervalLSpeed.TabIndex = 22;
            // 
            // textBoxIntensSpeed
            // 
            this.textBoxIntensSpeed.Location = new System.Drawing.Point(121, 217);
            this.textBoxIntensSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIntensSpeed.Name = "textBoxIntensSpeed";
            this.textBoxIntensSpeed.Size = new System.Drawing.Size(132, 22);
            this.textBoxIntensSpeed.TabIndex = 22;
            // 
            // labelSettingTime
            // 
            this.labelSettingTime.AutoSize = true;
            this.labelSettingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSettingTime.Location = new System.Drawing.Point(468, 11);
            this.labelSettingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSettingTime.Name = "labelSettingTime";
            this.labelSettingTime.Size = new System.Drawing.Size(316, 25);
            this.labelSettingTime.TabIndex = 36;
            this.labelSettingTime.Text = "Настройка параметров времени";
            // 
            // labelSettingSpeed
            // 
            this.labelSettingSpeed.AutoSize = true;
            this.labelSettingSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSettingSpeed.Location = new System.Drawing.Point(13, 11);
            this.labelSettingSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSettingSpeed.Name = "labelSettingSpeed";
            this.labelSettingSpeed.Size = new System.Drawing.Size(320, 25);
            this.labelSettingSpeed.TabIndex = 37;
            this.labelSettingSpeed.Text = "Настройка параметров скорости";
            // 
            // labelIntervalLSpeed
            // 
            this.labelIntervalLSpeed.AutoSize = true;
            this.labelIntervalLSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIntervalLSpeed.Location = new System.Drawing.Point(55, 190);
            this.labelIntervalLSpeed.Name = "labelIntervalLSpeed";
            this.labelIntervalLSpeed.Size = new System.Drawing.Size(250, 25);
            this.labelIntervalLSpeed.TabIndex = 31;
            this.labelIntervalLSpeed.Text = "Левая граница интервала";
            // 
            // labelIntensSpeed
            // 
            this.labelIntensSpeed.AutoSize = true;
            this.labelIntensSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIntensSpeed.Location = new System.Drawing.Point(109, 190);
            this.labelIntensSpeed.Name = "labelIntensSpeed";
            this.labelIntensSpeed.Size = new System.Drawing.Size(156, 25);
            this.labelIntensSpeed.TabIndex = 39;
            this.labelIntensSpeed.Text = "Интенсивность";
            // 
            // labelIntervalRTime
            // 
            this.labelIntervalRTime.AutoSize = true;
            this.labelIntervalRTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIntervalRTime.Location = new System.Drawing.Point(497, 268);
            this.labelIntervalRTime.Name = "labelIntervalRTime";
            this.labelIntervalRTime.Size = new System.Drawing.Size(259, 25);
            this.labelIntervalRTime.TabIndex = 40;
            this.labelIntervalRTime.Text = "Правая граница интервала";
            // 
            // labelIntensTime
            // 
            this.labelIntensTime.AutoSize = true;
            this.labelIntensTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIntensTime.Location = new System.Drawing.Point(551, 191);
            this.labelIntensTime.Name = "labelIntensTime";
            this.labelIntensTime.Size = new System.Drawing.Size(156, 25);
            this.labelIntensTime.TabIndex = 41;
            this.labelIntensTime.Text = "Интенсивность";
            // 
            // labelIntervalLTime
            // 
            this.labelIntervalLTime.AutoSize = true;
            this.labelIntervalLTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIntervalLTime.Location = new System.Drawing.Point(509, 191);
            this.labelIntervalLTime.Name = "labelIntervalLTime";
            this.labelIntervalLTime.Size = new System.Drawing.Size(250, 25);
            this.labelIntervalLTime.TabIndex = 42;
            this.labelIntervalLTime.Text = "Левая граница интервала";
            // 
            // labelTypeTime
            // 
            this.labelTypeTime.AutoSize = true;
            this.labelTypeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTypeTime.Location = new System.Drawing.Point(575, 53);
            this.labelTypeTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTypeTime.Name = "labelTypeTime";
            this.labelTypeTime.Size = new System.Drawing.Size(117, 25);
            this.labelTypeTime.TabIndex = 43;
            this.labelTypeTime.Text = "Вид потока";
            // 
            // textBoxIntensTime
            // 
            this.textBoxIntensTime.Location = new System.Drawing.Point(571, 219);
            this.textBoxIntensTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIntensTime.Name = "textBoxIntensTime";
            this.textBoxIntensTime.Size = new System.Drawing.Size(132, 22);
            this.textBoxIntensTime.TabIndex = 44;
            // 
            // comboBoxTypeSpeed
            // 
            this.comboBoxTypeSpeed.FormattingEnabled = true;
            this.comboBoxTypeSpeed.Location = new System.Drawing.Point(79, 85);
            this.comboBoxTypeSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTypeSpeed.Name = "comboBoxTypeSpeed";
            this.comboBoxTypeSpeed.Size = new System.Drawing.Size(212, 24);
            this.comboBoxTypeSpeed.TabIndex = 45;
            this.comboBoxTypeSpeed.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeSpeed_SelectedIndexChanged);
            // 
            // labelRSpeed
            // 
            this.labelRSpeed.AutoSize = true;
            this.labelRSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRSpeed.Location = new System.Drawing.Point(55, 268);
            this.labelRSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRSpeed.Name = "labelRSpeed";
            this.labelRSpeed.Size = new System.Drawing.Size(259, 25);
            this.labelRSpeed.TabIndex = 46;
            this.labelRSpeed.Text = "Правая граница интервала";
            // 
            // comboBoxTypeTime
            // 
            this.comboBoxTypeTime.FormattingEnabled = true;
            this.comboBoxTypeTime.Location = new System.Drawing.Point(529, 85);
            this.comboBoxTypeTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTypeTime.Name = "comboBoxTypeTime";
            this.comboBoxTypeTime.Size = new System.Drawing.Size(212, 24);
            this.comboBoxTypeTime.TabIndex = 47;
            this.comboBoxTypeTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeTime_SelectedIndexChanged);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 404);
            this.Controls.Add(this.comboBoxTypeTime);
            this.Controls.Add(this.labelRSpeed);
            this.Controls.Add(this.comboBoxTypeSpeed);
            this.Controls.Add(this.textBoxIntensTime);
            this.Controls.Add(this.labelTypeTime);
            this.Controls.Add(this.labelIntervalLTime);
            this.Controls.Add(this.labelIntensTime);
            this.Controls.Add(this.labelIntervalRTime);
            this.Controls.Add(this.labelIntensSpeed);
            this.Controls.Add(this.textBoxIntervalLSpeed);
            this.Controls.Add(this.labelIntervalLSpeed);
            this.Controls.Add(this.textBoxDispSpeed);
            this.Controls.Add(this.labelDispSpeed);
            this.Controls.Add(this.textBoxMOSpeed);
            this.Controls.Add(this.labelMOSpeed);
            this.Controls.Add(this.lawRandomTime);
            this.Controls.Add(this.textBoxIntensSpeed);
            this.Controls.Add(this.labelLawTime);
            this.Controls.Add(this.textBoxMOTime);
            this.Controls.Add(this.textBoxIntervalLTime);
            this.Controls.Add(this.textBoxIntervalRTime);
            this.Controls.Add(this.textBoxIntervalRSpeed);
            this.Controls.Add(this.textBoxDispTime);
            this.Controls.Add(this.labelDispTime);
            this.Controls.Add(this.labelMOTime);
            this.Controls.Add(this.lawRandomSpeed);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.determinateNumberSpeed);
            this.Controls.Add(this.labelDet_Time);
            this.Controls.Add(this.labelSettingSpeed);
            this.Controls.Add(this.labelLawSpeed);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelSettingTime);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelTypeSpeed);
            this.Controls.Add(this.menuSettings);
            this.MainMenuStrip = this.menuSettings;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OptionsForm";
            this.Text = "Параметры";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.determinateNumberSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTypeSpeed;
        private System.Windows.Forms.Label labelDet_Time;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxDispTime;
        private System.Windows.Forms.Label labelLawTime;
        private System.Windows.Forms.Label labelDispTime;
        private System.Windows.Forms.Label labelMOTime;
        private System.Windows.Forms.TextBox textBoxMOTime;
        private System.Windows.Forms.ComboBox lawRandomTime;
        private System.Windows.Forms.TextBox textBoxIntervalLTime;
        private System.Windows.Forms.TextBox textBoxIntervalRTime;
        private System.Windows.Forms.MenuStrip menuSettings;
        private System.Windows.Forms.ComboBox lawRandomSpeed;
        private System.Windows.Forms.TextBox textBoxMOSpeed;
        private System.Windows.Forms.Label labelMOSpeed;
        private System.Windows.Forms.Label labelDispSpeed;
        private System.Windows.Forms.Label labelLawSpeed;
        private System.Windows.Forms.TextBox textBoxIntervalRSpeed;
        private System.Windows.Forms.TextBox textBoxDispSpeed;
        private System.Windows.Forms.TextBox textBoxIntensSpeed;
        private System.Windows.Forms.TextBox textBoxIntervalLSpeed;
        private System.Windows.Forms.NumericUpDown determinateNumberSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelSettingTime;
        private System.Windows.Forms.Label labelSettingSpeed;
        private System.Windows.Forms.Label labelIntervalLSpeed;
        private System.Windows.Forms.Label labelIntensSpeed;
        private System.Windows.Forms.Label labelIntervalRTime;
        private System.Windows.Forms.Label labelIntensTime;
        private System.Windows.Forms.Label labelIntervalLTime;
        private System.Windows.Forms.Label labelTypeTime;
        private System.Windows.Forms.TextBox textBoxIntensTime;
        private System.Windows.Forms.ComboBox comboBoxTypeSpeed;
        private System.Windows.Forms.Label labelRSpeed;
        private System.Windows.Forms.ComboBox comboBoxTypeTime;
    }
}