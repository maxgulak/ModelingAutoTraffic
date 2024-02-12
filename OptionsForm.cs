using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ModelingAutoTraffic
{
    public partial class OptionsForm : Form
    {
 
        private TransportSettingModel _typeTransport;


        private TransportSettingModel _speedTransport;


        private delegate bool Validate(System.Windows.Forms.TextBox textBox, out string errorMessge);

        private Validate _validate;

  
        private bool _isActiveSpeedTransport = false;

    
        private bool _isError = false;

        public TransportSettingModel TypeTransport
        {
            get => _typeTransport;
            set => _typeTransport = value;
        }


        public TransportSettingModel SpeedTransport
        {
            get => _speedTransport;
            set => _speedTransport = value;
        }


        private int timeApeare;


        public int getTimeApeare
        {
            get { return timeApeare; }
        }

        public OptionsForm(TransportSettingModel typeTransport, TransportSettingModel speedTransport)
        {
            InitializeComponent();
            comboBoxTypeSpeed.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeSpeed.Items.AddRange(new string[] { "Детерминированный", "Случайный" });
            comboBoxTypeSpeed.SelectedItem = "Детерминированный";
            comboBoxTypeTime.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeTime.Items.AddRange(new string[] { "Детерминированный", "Случайный" });
            comboBoxTypeTime.SelectedItem = "Детерминированный";
            lawRandomTime.Items.AddRange(new string[] { "Нормальный", "Равномерный", "Показательный" });
            lawRandomTime.SelectedIndex = 0;
            lawRandomSpeed.Items.AddRange(new string[] { "Нормальный", "Равномерный", "Показательный" });
            lawRandomSpeed.SelectedIndex = 0;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            determinateNumberSpeed.Visible = true;
            labelSpeed.Visible = true;

            labelDet_Time.Visible = true;
            numericUpDown1.Visible = true;

            labelDispSpeed.Visible = false;
            labelMOSpeed.Visible = false;
            textBoxDispSpeed.Visible = false;
            textBoxMOSpeed.Visible = false;

            labelIntervalLSpeed.Visible = false;
            labelRSpeed.Visible = false;
            textBoxIntervalRSpeed.Visible = false;
            textBoxIntervalLSpeed.Visible = false;

            labelIntensSpeed.Visible = false;
            textBoxIntensSpeed.Visible = false;

            lawRandomSpeed.Visible = false;
            labelLawSpeed.Visible = false;

            labelDispTime.Visible = false;
            labelMOTime.Visible = false;
            textBoxDispTime.Visible = false;
            textBoxMOTime.Visible = false;

            labelIntervalLTime.Visible = false;
            labelIntervalRTime.Visible = false;
            textBoxIntervalRTime.Visible = false;
            textBoxIntervalLTime.Visible = false;

            labelIntensTime.Visible = false;
            textBoxIntensTime.Visible = false;

            lawRandomTime.Visible = false;
            labelLawTime.Visible = false;

            _typeTransport = typeTransport;
            _speedTransport = speedTransport;


            SetValueTypeTransport();
           SetValueSpeedTransport();

        }

        private System.Windows.Forms.TextBox GetActiveElement()
        {
            var textBox = this.ActiveControl;

            if (textBox is System.Windows.Forms.TextBox)
            {
                return (System.Windows.Forms.TextBox)textBox;
            }

            return null;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var textBox = GetActiveElement();
            var errorMessage = string.Empty;

            if (_validate != null && textBox != null && !_validate(textBox, out errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }
            _speedTransport = GetSpeedTransport();
            _typeTransport = GetTypeTransport();
            

            timeApeare = (int)numericUpDown1.Value;
            this.Close();
        }

        private void comboBoxRand_SV_SelectedIndexChanged(object sender, EventArgs e)
        {
            var law = lawRandomTime.SelectedItem.ToString();

            switch (law)
            {
                case "Нормальный":
                    labelDispTime.Visible = true;
                    labelMOTime.Visible = true;
                    textBoxDispTime.Visible = true;
                    textBoxMOTime.Visible = true;

                    labelIntervalLTime.Visible = false;
                    labelIntervalRTime.Visible = false;
                    textBoxIntervalRTime.Visible = false;
                    textBoxIntervalLTime.Visible = false;

                    labelIntensTime.Visible = false;
                    textBoxIntensTime.Visible = false;

                    labelDet_Time.Visible = false;
                    numericUpDown1.Visible = false;
                    break;
                case "Равномерный":
                    labelIntervalLTime.Visible = true;
                    labelIntervalRTime.Visible = true;
                    textBoxIntervalRTime.Visible = true;
                    textBoxIntervalLTime.Visible = true;

                    labelDispTime.Visible = false;
                    labelMOTime.Visible = false;
                    textBoxDispTime.Visible = false;
                    textBoxMOTime.Visible = false;

                    labelIntensTime.Visible = false;
                    textBoxIntensTime.Visible = false;

                    labelDet_Time.Visible = false;
                    numericUpDown1.Visible = false;

                    break;
                case "Показательный":
                    labelIntensTime.Visible = true;
                    textBoxIntensTime.Visible = true;

                    labelDispTime.Visible = false;
                    labelMOTime.Visible = false;
                    textBoxDispTime.Visible = false;
                    textBoxMOTime.Visible = false;

                    labelIntervalLTime.Visible = false;
                    labelIntervalRTime.Visible = false;
                    textBoxIntervalRTime.Visible = false;
                    textBoxIntervalLTime.Visible = false;

                    labelDet_Time.Visible = false;
                    numericUpDown1.Visible = false;
                    break;
            }

        }

        private void lowRandomSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            var law = lawRandomSpeed.SelectedItem.ToString();

            switch (law)
            {
                case "Нормальный":
                    labelDispSpeed.Visible = true;
                    labelMOSpeed.Visible = true;
                    textBoxDispSpeed.Visible = true;
                    textBoxMOSpeed.Visible = true;

                    labelIntervalLSpeed.Visible = false;
                    labelRSpeed.Visible = false;
                    textBoxIntervalRSpeed.Visible = false;
                    textBoxIntervalLSpeed.Visible = false;

                    labelIntensSpeed.Visible = false;
                    textBoxIntensSpeed.Visible = false;

                    determinateNumberSpeed.Visible = false;
                    labelSpeed.Visible = false;
                    break;
                case "Равномерный":
                    labelRSpeed.Visible = true;
                    labelIntervalLSpeed.Visible = true;
                    textBoxIntervalRSpeed.Visible = true;
                    textBoxIntervalLSpeed.Visible = true;

                    labelDispSpeed.Visible = false;
                    labelMOSpeed.Visible = false;
                    textBoxDispSpeed.Visible = false;
                    textBoxMOSpeed.Visible = false;

                    labelIntensSpeed.Visible = false;
                    textBoxIntensSpeed.Visible = false;

                    determinateNumberSpeed.Visible = false;
                    labelSpeed.Visible = false;

                    break;
                case "Показательный":
                    labelIntensSpeed.Visible = true;
                    textBoxIntensSpeed.Visible = true;

                    labelDispSpeed.Visible = false;
                    labelMOSpeed.Visible = false;
                    textBoxDispSpeed.Visible = false;
                    textBoxMOSpeed.Visible = false;

                    labelIntervalLSpeed.Visible = false;
                    labelRSpeed.Visible = false;
                    textBoxIntervalRSpeed.Visible = false;
                    textBoxIntervalLSpeed.Visible = false;

                    determinateNumberSpeed.Visible = false;
                    labelSpeed.Visible = false;
                    break;
            }
        }
        private void comboBoxTypeSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTypeSpeed.SelectedItem.ToString() == "Детерминированный")
            {
                determinateNumberSpeed.Visible = true;
                labelSpeed.Visible = true;

                labelDispSpeed.Visible = false;
                labelMOSpeed.Visible = false;
                textBoxDispSpeed.Visible = false;
                textBoxMOSpeed.Visible = false;

                labelIntervalLSpeed.Visible = false;
                labelRSpeed.Visible = false;
                textBoxIntervalRSpeed.Visible = false;
                textBoxIntervalLSpeed.Visible = false;

                labelIntensSpeed.Visible = false;
                textBoxIntensSpeed.Visible = false;
                lawRandomSpeed.Visible = false;
                labelLawSpeed.Visible = false;

            }
            else
            {
                lawRandomSpeed.Visible = true;
                labelLawSpeed.Visible = true;
                determinateNumberSpeed.Visible = false;
                labelSpeed.Visible = false;

            }
        }
        private void comboBoxTypeTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTypeTime.SelectedItem.ToString() == "Детерминированный")
            {
                labelDet_Time.Visible = true;
                numericUpDown1.Visible = true;
                labelDispTime.Visible = false;
                labelMOTime.Visible = false;
                textBoxDispTime.Visible = false;
                textBoxMOTime.Visible = false;

                labelIntervalLTime.Visible = false;
                labelIntervalRTime.Visible = false;
                textBoxIntervalRTime.Visible = false;
                textBoxIntervalLTime.Visible = false;

                labelIntensTime.Visible = false;
                textBoxIntensTime.Visible = false;
                lawRandomTime.Visible = false;
                labelLawTime.Visible = false;

            }
            else
            {
                lawRandomTime.Visible = true;
                labelLawTime.Visible = true;
                labelDet_Time.Visible = false;
                numericUpDown1.Visible = false;

            }
        }
        
        private void SetValueTypeTransport()
        {
            if (_typeTransport.IsDeterminate || (!_typeTransport.IsDeterminate && !_typeTransport.IsRandom))
            {
                numericUpDown1.Value = _typeTransport.DeterminateInterval;
            }
            else
            {

                lawRandomTime.SelectedItem = _typeTransport.Law;

                if (!float.IsNaN(_typeTransport.Intensity))
                {
                    textBoxIntensTime.Text = _typeTransport.Intensity.ToString();
                }

                if (!float.IsNaN(_typeTransport.StartInterval))
                {
                    textBoxIntervalLTime.Text = _typeTransport.StartInterval.ToString();
                }

                if (!float.IsNaN(_typeTransport.EndInterval))
                {
                    textBoxIntervalRTime.Text = _typeTransport.EndInterval.ToString();
                }

                if (!float.IsNaN(_typeTransport.RandomDispersion))
                {
                    textBoxDispTime.Text = _typeTransport.RandomDispersion.ToString();
                }

                if (!float.IsNaN(_typeTransport.MathExpectation))
                {
                    textBoxMOTime.Text = _typeTransport.MathExpectation.ToString();
                }
            }
        }

        private void SetValueSpeedTransport()
        {
            if (_speedTransport.IsDeterminate || (!_speedTransport.IsDeterminate && !_speedTransport.IsRandom))
            {
                determinateNumberSpeed.Value = _speedTransport.DeterminateInterval;
            }
            else
            {
                lawRandomSpeed.SelectedItem = _speedTransport.Law;
                if (!float.IsNaN(_speedTransport.Intensity))
                {
                    textBoxIntensSpeed.Text = _speedTransport.Intensity.ToString();
                }
                if (!float.IsNaN(_speedTransport.StartInterval))
                {
                    textBoxIntervalLSpeed.Text = _speedTransport.StartInterval.ToString();
                }
                if (!float.IsNaN(_speedTransport.EndInterval))
                {
                    textBoxIntervalRSpeed.Text = _speedTransport.EndInterval.ToString();
                }
                if (!float.IsNaN(_speedTransport.RandomDispersion))
                {
                    textBoxDispSpeed.Text = _speedTransport.RandomDispersion.ToString();
                }
                if (!float.IsNaN(_speedTransport.MathExpectation))
                {
                    textBoxMOSpeed.Text = _speedTransport.MathExpectation.ToString();
                }
            }
        }
        private TransportSettingModel GetTypeTransport()
        {
            return new TransportSettingModel()
            {
                IsDeterminate = (comboBoxTypeTime.SelectedItem.ToString() == "Детерминированный")
                ? true : false,
                IsRandom = (comboBoxTypeTime.SelectedItem.ToString() == "Случайный")
                ? true : false,
                DeterminateInterval = (int)numericUpDown1.Value,
                Law = (lawRandomTime.SelectedItem == null)
                       ? String.Empty
                       : lawRandomTime.SelectedItem.ToString(),
                Intensity = (string.IsNullOrEmpty(textBoxIntensTime.Text))
                       ? float.NaN
                       : float.Parse(textBoxIntensTime.Text),
                StartInterval = (string.IsNullOrEmpty(textBoxIntervalLTime.Text))
                       ? float.NaN
                       : float.Parse(textBoxIntervalLTime.Text),
                EndInterval = (string.IsNullOrEmpty(textBoxIntervalRTime.Text))
                       ? float.NaN
                       : float.Parse(textBoxIntervalRTime.Text),
                RandomDispersion = (string.IsNullOrEmpty(textBoxDispTime.Text))
                       ? float.NaN
                       : float.Parse(textBoxDispTime.Text),
                MathExpectation = (string.IsNullOrEmpty(textBoxMOTime.Text))
                       ? float.NaN
                       : float.Parse(textBoxMOTime.Text)
            };
        }
        private TransportSettingModel GetSpeedTransport()
        {
            return new TransportSettingModel()
            {
                IsDeterminate = (comboBoxTypeSpeed.SelectedItem.ToString() == "Детерминированный") 
                ? true : false,              
                IsRandom = (comboBoxTypeSpeed.SelectedItem.ToString() == "Случайный")
                ? true : false,
                DeterminateInterval = (int)determinateNumberSpeed.Value,
                Law = (lawRandomSpeed.SelectedItem == null)
                        ? String.Empty
                        : lawRandomSpeed.SelectedItem.ToString(),
                Intensity = (string.IsNullOrEmpty(textBoxIntensSpeed.Text))
                        ? float.NaN
                        : float.Parse(textBoxIntensSpeed.Text),
                StartInterval = (string.IsNullOrEmpty(textBoxIntervalLSpeed.Text))
                        ? float.NaN
                        : float.Parse(textBoxIntervalLSpeed.Text),
                EndInterval = (string.IsNullOrEmpty(textBoxIntervalRSpeed.Text))
                        ? float.NaN
                        : float.Parse(textBoxIntervalRSpeed.Text),
                RandomDispersion = (string.IsNullOrEmpty(textBoxDispSpeed.Text))
                        ? float.NaN
                        : float.Parse(textBoxDispSpeed.Text),
                MathExpectation = (string.IsNullOrEmpty(textBoxMOSpeed.Text))
                        ? float.NaN
                        : float.Parse(textBoxMOSpeed.Text)
            };
        }
    }
}
