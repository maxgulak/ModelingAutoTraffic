namespace ModelingAutoTraffic
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownWay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLines = new System.Windows.Forms.NumericUpDown();
            this.labelLights = new System.Windows.Forms.Label();
            this.numericUpDownTonnel = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПроектеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оРазработчикахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTonnel)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(85, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Начать моделирование";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбор типа автодороги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество направлений движения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество полос";
            // 
            // numericUpDownWay
            // 
            this.numericUpDownWay.Location = new System.Drawing.Point(16, 119);
            this.numericUpDownWay.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownWay.Name = "numericUpDownWay";
            this.numericUpDownWay.Size = new System.Drawing.Size(121, 20);
            this.numericUpDownWay.TabIndex = 17;
            // 
            // numericUpDownLines
            // 
            this.numericUpDownLines.Location = new System.Drawing.Point(16, 174);
            this.numericUpDownLines.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownLines.Name = "numericUpDownLines";
            this.numericUpDownLines.Size = new System.Drawing.Size(121, 20);
            this.numericUpDownLines.TabIndex = 18;
            // 
            // labelLights
            // 
            this.labelLights.AutoSize = true;
            this.labelLights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLights.Location = new System.Drawing.Point(12, 97);
            this.labelLights.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLights.Name = "labelLights";
            this.labelLights.Size = new System.Drawing.Size(213, 20);
            this.labelLights.TabIndex = 21;
            this.labelLights.Text = "Длина светофорной фазы";
            this.labelLights.Visible = false;
            // 
            // numericUpDownTonnel
            // 
            this.numericUpDownTonnel.InterceptArrowKeys = false;
            this.numericUpDownTonnel.Location = new System.Drawing.Point(16, 119);
            this.numericUpDownTonnel.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownTonnel.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownTonnel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTonnel.Name = "numericUpDownTonnel";
            this.numericUpDownTonnel.Size = new System.Drawing.Size(121, 20);
            this.numericUpDownTonnel.TabIndex = 23;
            this.numericUpDownTonnel.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПроектеToolStripMenuItem,
            this.оРазработчикахToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(308, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПроектеToolStripMenuItem
            // 
            this.оПроектеToolStripMenuItem.Name = "оПроектеToolStripMenuItem";
            this.оПроектеToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.оПроектеToolStripMenuItem.Text = "О системе";
            this.оПроектеToolStripMenuItem.Click += new System.EventHandler(this.оПроектеToolStripMenuItem_Click);
            // 
            // оРазработчикахToolStripMenuItem
            // 
            this.оРазработчикахToolStripMenuItem.Name = "оРазработчикахToolStripMenuItem";
            this.оРазработчикахToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.оРазработчикахToolStripMenuItem.Text = "О разработчиках";
            this.оРазработчикахToolStripMenuItem.Click += new System.EventHandler(this.оРазработчикахToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 276);
            this.Controls.Add(this.numericUpDownTonnel);
            this.Controls.Add(this.labelLights);
            this.Controls.Add(this.numericUpDownLines);
            this.Controls.Add(this.numericUpDownWay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка параметров";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTonnel)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownWay;
        private System.Windows.Forms.NumericUpDown numericUpDownLines;
        private System.Windows.Forms.Label labelLights;
        private System.Windows.Forms.NumericUpDown numericUpDownTonnel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПроектеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оРазработчикахToolStripMenuItem;
    }
}

