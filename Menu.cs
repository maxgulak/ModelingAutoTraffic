using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ModelingAutoTraffic
{
    public partial class Menu : Form
    {
        Modeling form2;
        private int CountWays;
        private int CountLines;
        private string roadType;
        private bool isTonnel = false;

        public int getCountWays
        {
            get { return CountWays; }
        }

        public int getCountLines
        {
            get { return CountLines; }
        }
        public Menu()
        {
            InitializeComponent();
            numericUpDownWay.Minimum = 1;
            numericUpDownWay.Maximum = 2;
            numericUpDownWay.ReadOnly = true;
            numericUpDownLines.Minimum = 1;
            numericUpDownLines.Maximum = 3;
            numericUpDownLines.ReadOnly = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new string[] { "Автострада", "Тоннель" });
            comboBox1.SelectedItem = "Автострада";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            numericUpDownTonnel.Minimum = 1;
            numericUpDownTonnel.Maximum = 20;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CountLines = (int)numericUpDownLines.Value;
            CountWays = (int)numericUpDownWay.Value;
            roadType = comboBox1.Text;

            form2 = new Modeling();
            int time = -1;
            form2.setCountLines = CountLines;
            form2.setCountWays = CountWays;
            form2.setRoaType = roadType;
            form2.setTimeTrafficLight = (int)numericUpDownTonnel.Value;
            form2.ShowDialog();
        }
        private void оРазработчикахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\nЛабораторный практикум по дисциплине: \n\t«Технологии программирования» \nТема: «Система моделирования движения транспорта на автодороге (в тоннеле / на автостраде)» \n\nРазработчики:\nОбучающиеся группы 6404-090301D \n\tГулак Максим \n\tВоронцов Владислав \nРуководитель: \n\tЗеленко Лариса Сергеевна",
               "Информация о разработчиках", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void оПроектеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = @"file:///C:\Users\maxim\Desktop\ModelingAutoTraffic\О%20системе.html",
                UseShellExecute = true
            });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Тоннель")
            {
                label2.Visible = false;
                label3.Visible = false;
                numericUpDownLines.Visible = false;
                numericUpDownWay.Visible = false;
                labelLights.Visible = true;
                numericUpDownTonnel.Visible = true;
            }
            else
            {
                label2.Visible = true;
                label3.Visible = true;
                numericUpDownLines.Visible = true;
                numericUpDownWay.Visible = true;
                labelLights.Visible = false;
                numericUpDownTonnel.Visible = false;
            }
        }

       
    }
}


